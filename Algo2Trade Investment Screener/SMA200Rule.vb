Imports System.Threading
Imports Algo2TradeBLL

Public Class SMA200Rule
    Inherits Rule

    Public Sub New(ByVal canceller As CancellationTokenSource)
        MyBase.New(canceller)
    End Sub

    Public Overrides Async Function RunAsync(startDate As Date, endDate As Date) As Task(Of DataTable)
        Await Task.Delay(0).ConfigureAwait(False)
        Dim ret As New DataTable
        ret.Columns.Add("Date")
        ret.Columns.Add("Instrument")
        ret.Columns.Add("SMA %")
        ret.Columns.Add("52 Weeks High")
        Dim chkDate As Date = startDate
        While chkDate <= endDate
            _cts.Token.ThrowIfCancellationRequested()
            Dim stockList As List(Of String) = _cmn.GetAllStockList(Common.DataBaseTable.EOD_Cash, chkDate)
            _cts.Token.ThrowIfCancellationRequested()
            If stockList IsNot Nothing AndAlso stockList.Count > 0 Then
                For Each stock In stockList
                    _cts.Token.ThrowIfCancellationRequested()
                    Dim inputPayload As Dictionary(Of Date, Payload) = Await _cmn.GetHistoricalDataAsync(Common.DataBaseTable.EOD_Cash, stock, chkDate.AddYears(-3), chkDate).ConfigureAwait(False)
                    _cts.Token.ThrowIfCancellationRequested()
                    If inputPayload IsNot Nothing AndAlso inputPayload.Count > 0 Then
                        Dim smaPayload As Dictionary(Of Date, Decimal) = Nothing
                        Indicator.SMA.CalculateSMA(200, Payload.PayloadFields.Close, inputPayload, smaPayload)

                        Dim avgChkFrom As Date = chkDate.AddYears(-2)
                        Dim highChkFrom As Date = chkDate.AddDays(-365)
                        Dim totalDayCount As Integer = 0
                        Dim aboveSMACount As Integer = 0
                        Dim yearHigh As Decimal = Decimal.MinValue
                        For Each runningPayload In inputPayload.Values
                            _cts.Token.ThrowIfCancellationRequested()
                            If runningPayload.PayloadDate.Date >= avgChkFrom.Date Then
                                totalDayCount += 1
                                If runningPayload.Close > smaPayload(runningPayload.PayloadDate) Then
                                    aboveSMACount += 1
                                End If
                            End If
                            If runningPayload.PayloadDate.Date >= highChkFrom.Date Then
                                yearHigh = Math.Max(yearHigh, runningPayload.High)
                            End If
                        Next
                        _cts.Token.ThrowIfCancellationRequested()
                        If totalDayCount <> 0 Then
                            Dim aboveSMA200Avg As Decimal = Math.Round((aboveSMACount / totalDayCount) * 100, 2)
                            Dim row As DataRow = ret.NewRow
                            row("Date") = inputPayload.LastOrDefault.Value.PayloadDate.ToString("yyyy-MM-dd")
                            row("Instrument") = inputPayload.LastOrDefault.Value.TradingSymbol
                            row("SMA %") = aboveSMA200Avg
                            row("52 Weeks High") = yearHigh
                            ret.Rows.Add(row)
                        End If
                    End If
                Next
            End If
            chkDate = chkDate.AddDays(1)
        End While
        Return ret
    End Function
End Class
