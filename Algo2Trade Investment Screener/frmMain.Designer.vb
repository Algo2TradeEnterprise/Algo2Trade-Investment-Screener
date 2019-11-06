<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmbProcedure = New System.Windows.Forms.ComboBox()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.dtpckrToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpckrFromDate = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.dgrvMain = New System.Windows.Forms.DataGridView()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgrvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbProcedure
        '
        Me.cmbProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProcedure.FormattingEnabled = True
        Me.cmbProcedure.Items.AddRange(New Object() {"200 MA"})
        Me.cmbProcedure.Location = New System.Drawing.Point(89, 13)
        Me.cmbProcedure.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProcedure.Name = "cmbProcedure"
        Me.cmbProcedure.Size = New System.Drawing.Size(286, 24)
        Me.cmbProcedure.TabIndex = 43
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.Location = New System.Drawing.Point(8, 15)
        Me.lblProcedure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(78, 17)
        Me.lblProcedure.TabIndex = 42
        Me.lblProcedure.Text = "Procedure:"
        '
        'dtpckrToDate
        '
        Me.dtpckrToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpckrToDate.Location = New System.Drawing.Point(267, 51)
        Me.dtpckrToDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpckrToDate.Name = "dtpckrToDate"
        Me.dtpckrToDate.Size = New System.Drawing.Size(108, 22)
        Me.dtpckrToDate.TabIndex = 41
        '
        'dtpckrFromDate
        '
        Me.dtpckrFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpckrFromDate.Location = New System.Drawing.Point(85, 52)
        Me.dtpckrFromDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpckrFromDate.Name = "dtpckrFromDate"
        Me.dtpckrFromDate.Size = New System.Drawing.Size(108, 22)
        Me.dtpckrFromDate.TabIndex = 40
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(202, 52)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(63, 17)
        Me.lblToDate.TabIndex = 39
        Me.lblToDate.Text = "To Date:"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(7, 53)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(78, 17)
        Me.lblFromDate.TabIndex = 38
        Me.lblFromDate.Text = "From Date:"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(400, 27)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(119, 38)
        Me.btnStart.TabIndex = 44
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(652, 27)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(135, 39)
        Me.btnExport.TabIndex = 45
        Me.btnExport.Text = "Export CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(528, 26)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(117, 39)
        Me.btnStop.TabIndex = 46
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'dgrvMain
        '
        Me.dgrvMain.AllowUserToAddRows = False
        Me.dgrvMain.AllowUserToDeleteRows = False
        Me.dgrvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrvMain.Location = New System.Drawing.Point(6, 86)
        Me.dgrvMain.Margin = New System.Windows.Forms.Padding(4)
        Me.dgrvMain.Name = "dgrvMain"
        Me.dgrvMain.ReadOnly = True
        Me.dgrvMain.RowHeadersVisible = False
        Me.dgrvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrvMain.Size = New System.Drawing.Size(781, 385)
        Me.dgrvMain.TabIndex = 48
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.Location = New System.Drawing.Point(6, 478)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(781, 70)
        Me.lblProgress.TabIndex = 47
        Me.lblProgress.Text = "Progress Status"
        '
        'saveFile
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 553)
        Me.Controls.Add(Me.dgrvMain)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.cmbProcedure)
        Me.Controls.Add(Me.lblProcedure)
        Me.Controls.Add(Me.dtpckrToDate)
        Me.Controls.Add(Me.dtpckrFromDate)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investment Screener"
        CType(Me.dgrvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProcedure As ComboBox
    Friend WithEvents lblProcedure As Label
    Friend WithEvents dtpckrToDate As DateTimePicker
    Friend WithEvents dtpckrFromDate As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents dgrvMain As DataGridView
    Friend WithEvents lblProgress As Label
    Friend WithEvents saveFile As SaveFileDialog
End Class
