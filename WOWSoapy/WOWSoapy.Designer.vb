<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WOWSoapy
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
        Me.TlpLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpAbout = New System.Windows.Forms.TableLayoutPanel()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.tlpCharMain = New System.Windows.Forms.TableLayoutPanel()
        Me.lbChars = New System.Windows.Forms.ListBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpRight = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.LblOutputData = New System.Windows.Forms.Label()
        Me.cmdOutputData = New System.Windows.Forms.Button()
        Me.cmdGetData = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.LblGetData = New System.Windows.Forms.Label()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdOverview = New System.Windows.Forms.Button()
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.cmdDetails = New System.Windows.Forms.Button()
        Me.TlpLeft.SuspendLayout()
        Me.TlpAbout.SuspendLayout()
        Me.tlpCharMain.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.TlpRight.SuspendLayout()
        Me.TlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlpLeft
        '
        Me.TlpLeft.ColumnCount = 1
        Me.TlpLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLeft.Controls.Add(Me.TlpAbout, 0, 1)
        Me.TlpLeft.Controls.Add(Me.tlpCharMain, 0, 0)
        Me.TlpLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpLeft.Location = New System.Drawing.Point(0, 0)
        Me.TlpLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpLeft.Name = "TlpLeft"
        Me.TlpLeft.RowCount = 2
        Me.TlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TlpLeft.Size = New System.Drawing.Size(757, 494)
        Me.TlpLeft.TabIndex = 1
        '
        'TlpAbout
        '
        Me.TlpAbout.ColumnCount = 2
        Me.TlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpAbout.Controls.Add(Me.LblVersion, 0, 0)
        Me.TlpAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpAbout.Location = New System.Drawing.Point(0, 469)
        Me.TlpAbout.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpAbout.Name = "TlpAbout"
        Me.TlpAbout.RowCount = 1
        Me.TlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TlpAbout.Size = New System.Drawing.Size(757, 25)
        Me.TlpAbout.TabIndex = 0
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblVersion.Location = New System.Drawing.Point(1, 1)
        Me.LblVersion.Margin = New System.Windows.Forms.Padding(1)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(376, 23)
        Me.LblVersion.TabIndex = 0
        Me.LblVersion.Text = "Version: 0.1.1"
        Me.LblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpCharMain
        '
        Me.tlpCharMain.ColumnCount = 2
        Me.tlpCharMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCharMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpCharMain.Controls.Add(Me.lbChars, 1, 0)
        Me.tlpCharMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCharMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpCharMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpCharMain.Name = "tlpCharMain"
        Me.tlpCharMain.RowCount = 1
        Me.tlpCharMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCharMain.Size = New System.Drawing.Size(757, 469)
        Me.tlpCharMain.TabIndex = 1
        '
        'lbChars
        '
        Me.lbChars.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbChars.FormattingEnabled = True
        Me.lbChars.ItemHeight = 16
        Me.lbChars.Location = New System.Drawing.Point(617, 0)
        Me.lbChars.Margin = New System.Windows.Forms.Padding(0)
        Me.lbChars.Name = "lbChars"
        Me.lbChars.Size = New System.Drawing.Size(140, 469)
        Me.lbChars.TabIndex = 0
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpMain.Controls.Add(Me.TlpLeft, 0, 0)
        Me.tlpMain.Controls.Add(Me.TlpRight, 1, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(957, 494)
        Me.tlpMain.TabIndex = 1
        '
        'TlpRight
        '
        Me.TlpRight.ColumnCount = 1
        Me.TlpRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpRight.Controls.Add(Me.TlpButtons, 0, 2)
        Me.TlpRight.Controls.Add(Me.lbOutput, 0, 0)
        Me.TlpRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpRight.Location = New System.Drawing.Point(757, 0)
        Me.TlpRight.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpRight.Name = "TlpRight"
        Me.TlpRight.RowCount = 3
        Me.TlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TlpRight.Size = New System.Drawing.Size(200, 494)
        Me.TlpRight.TabIndex = 2
        '
        'TlpButtons
        '
        Me.TlpButtons.ColumnCount = 2
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpButtons.Controls.Add(Me.LblOutputData, 1, 1)
        Me.TlpButtons.Controls.Add(Me.cmdOutputData, 0, 1)
        Me.TlpButtons.Controls.Add(Me.cmdGetData, 0, 0)
        Me.TlpButtons.Controls.Add(Me.cmdExit, 1, 4)
        Me.TlpButtons.Controls.Add(Me.LblGetData, 1, 0)
        Me.TlpButtons.Controls.Add(Me.cmdRefresh, 0, 4)
        Me.TlpButtons.Controls.Add(Me.cmdOverview, 1, 3)
        Me.TlpButtons.Controls.Add(Me.cmdDetails, 0, 3)
        Me.TlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpButtons.Location = New System.Drawing.Point(0, 334)
        Me.TlpButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpButtons.Name = "TlpButtons"
        Me.TlpButtons.RowCount = 5
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpButtons.Size = New System.Drawing.Size(200, 160)
        Me.TlpButtons.TabIndex = 2
        '
        'LblOutputData
        '
        Me.LblOutputData.AutoSize = True
        Me.LblOutputData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblOutputData.Location = New System.Drawing.Point(101, 33)
        Me.LblOutputData.Margin = New System.Windows.Forms.Padding(1)
        Me.LblOutputData.Name = "LblOutputData"
        Me.LblOutputData.Size = New System.Drawing.Size(98, 30)
        Me.LblOutputData.TabIndex = 4
        Me.LblOutputData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdOutputData
        '
        Me.cmdOutputData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOutputData.Location = New System.Drawing.Point(1, 33)
        Me.cmdOutputData.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdOutputData.Name = "cmdOutputData"
        Me.cmdOutputData.Size = New System.Drawing.Size(98, 30)
        Me.cmdOutputData.TabIndex = 1
        Me.cmdOutputData.Text = "Output Data"
        Me.cmdOutputData.UseVisualStyleBackColor = True
        '
        'cmdGetData
        '
        Me.cmdGetData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdGetData.Location = New System.Drawing.Point(1, 1)
        Me.cmdGetData.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdGetData.Name = "cmdGetData"
        Me.cmdGetData.Size = New System.Drawing.Size(98, 30)
        Me.cmdGetData.TabIndex = 0
        Me.cmdGetData.Text = "Get Data"
        Me.cmdGetData.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdExit.Location = New System.Drawing.Point(101, 129)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(98, 30)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'LblGetData
        '
        Me.LblGetData.AutoSize = True
        Me.LblGetData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblGetData.Location = New System.Drawing.Point(101, 1)
        Me.LblGetData.Margin = New System.Windows.Forms.Padding(1)
        Me.LblGetData.Name = "LblGetData"
        Me.LblGetData.Size = New System.Drawing.Size(98, 30)
        Me.LblGetData.TabIndex = 3
        Me.LblGetData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRefresh.Location = New System.Drawing.Point(1, 129)
        Me.cmdRefresh.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(98, 30)
        Me.cmdRefresh.TabIndex = 5
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdOverview
        '
        Me.cmdOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOverview.Location = New System.Drawing.Point(101, 97)
        Me.cmdOverview.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdOverview.Name = "cmdOverview"
        Me.cmdOverview.Size = New System.Drawing.Size(98, 30)
        Me.cmdOverview.TabIndex = 6
        Me.cmdOverview.Text = "Overview"
        Me.cmdOverview.UseVisualStyleBackColor = True
        '
        'lbOutput
        '
        Me.lbOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.ItemHeight = 16
        Me.lbOutput.Location = New System.Drawing.Point(3, 3)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(194, 94)
        Me.lbOutput.TabIndex = 3
        '
        'cmdDetails
        '
        Me.cmdDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDetails.Location = New System.Drawing.Point(0, 96)
        Me.cmdDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(100, 32)
        Me.cmdDetails.TabIndex = 7
        Me.cmdDetails.Text = "Details"
        Me.cmdDetails.UseVisualStyleBackColor = True
        '
        'WOWSoapy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 494)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "WOWSoapy"
        Me.Text = "WOWSoapy"
        Me.TlpLeft.ResumeLayout(False)
        Me.TlpAbout.ResumeLayout(False)
        Me.TlpAbout.PerformLayout()
        Me.tlpCharMain.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.TlpRight.ResumeLayout(False)
        Me.TlpButtons.ResumeLayout(False)
        Me.TlpButtons.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TlpLeft As TableLayoutPanel
    Friend WithEvents TlpAbout As TableLayoutPanel
    Friend WithEvents LblVersion As Label
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents TlpRight As TableLayoutPanel
    Friend WithEvents TlpButtons As TableLayoutPanel
    Friend WithEvents LblOutputData As Label
    Friend WithEvents cmdOutputData As Button
    Friend WithEvents cmdGetData As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents LblGetData As Label
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents lbOutput As ListBox
    Friend WithEvents tlpCharMain As TableLayoutPanel
    Friend WithEvents lbChars As ListBox
    Friend WithEvents cmdOverview As Button
    Friend WithEvents cmdDetails As Button
End Class
