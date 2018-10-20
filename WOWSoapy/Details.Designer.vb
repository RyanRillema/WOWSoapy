<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpControlsMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpControlsRight = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpControlsLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.tlpFull = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpDetailsMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpProfMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpProfMid = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbProf2Name = New System.Windows.Forms.Label()
        Me.lbProf1Name = New System.Windows.Forms.Label()
        Me.pbProf1Vanilla = New System.Windows.Forms.ProgressBar()
        Me.tlpNameMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain.SuspendLayout()
        Me.tlpControlsMain.SuspendLayout()
        Me.tlpControlsRight.SuspendLayout()
        Me.tlpControlsLeft.SuspendLayout()
        Me.tlpFull.SuspendLayout()
        Me.tlpDetailsMain.SuspendLayout()
        Me.tlpProfMain.SuspendLayout()
        Me.tlpProfMid.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpControlsMain, 0, 1)
        Me.tlpMain.Controls.Add(Me.tlpFull, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1041, 596)
        Me.tlpMain.TabIndex = 1
        '
        'tlpControlsMain
        '
        Me.tlpControlsMain.ColumnCount = 2
        Me.tlpControlsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControlsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControlsMain.Controls.Add(Me.tlpControlsRight, 1, 0)
        Me.tlpControlsMain.Controls.Add(Me.tlpControlsLeft, 0, 0)
        Me.tlpControlsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControlsMain.Location = New System.Drawing.Point(0, 566)
        Me.tlpControlsMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpControlsMain.Name = "tlpControlsMain"
        Me.tlpControlsMain.RowCount = 1
        Me.tlpControlsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControlsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpControlsMain.Size = New System.Drawing.Size(1041, 30)
        Me.tlpControlsMain.TabIndex = 0
        '
        'tlpControlsRight
        '
        Me.tlpControlsRight.ColumnCount = 6
        Me.tlpControlsRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControlsRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControlsRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControlsRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControlsRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControlsRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpControlsRight.Controls.Add(Me.cmdClose, 5, 0)
        Me.tlpControlsRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControlsRight.Location = New System.Drawing.Point(520, 0)
        Me.tlpControlsRight.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpControlsRight.Name = "tlpControlsRight"
        Me.tlpControlsRight.RowCount = 1
        Me.tlpControlsRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControlsRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpControlsRight.Size = New System.Drawing.Size(521, 30)
        Me.tlpControlsRight.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdClose.Location = New System.Drawing.Point(430, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(91, 30)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tlpControlsLeft
        '
        Me.tlpControlsLeft.ColumnCount = 6
        Me.tlpControlsLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67083!))
        Me.tlpControlsLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583!))
        Me.tlpControlsLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583!))
        Me.tlpControlsLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583!))
        Me.tlpControlsLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583!))
        Me.tlpControlsLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583!))
        Me.tlpControlsLeft.Controls.Add(Me.cmdPrevious, 4, 0)
        Me.tlpControlsLeft.Controls.Add(Me.cmdNext, 5, 0)
        Me.tlpControlsLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControlsLeft.Location = New System.Drawing.Point(0, 0)
        Me.tlpControlsLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpControlsLeft.Name = "tlpControlsLeft"
        Me.tlpControlsLeft.RowCount = 1
        Me.tlpControlsLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControlsLeft.Size = New System.Drawing.Size(520, 30)
        Me.tlpControlsLeft.TabIndex = 1
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdPrevious.Location = New System.Drawing.Point(344, 0)
        Me.cmdPrevious.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(86, 30)
        Me.cmdPrevious.TabIndex = 0
        Me.cmdPrevious.Text = "Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdNext.Location = New System.Drawing.Point(430, 0)
        Me.cmdNext.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(90, 30)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'tlpFull
        '
        Me.tlpFull.ColumnCount = 1
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFull.Controls.Add(Me.tlpDetailsMain, 0, 0)
        Me.tlpFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFull.Location = New System.Drawing.Point(0, 0)
        Me.tlpFull.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFull.Name = "tlpFull"
        Me.tlpFull.RowCount = 1
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.tlpFull.Size = New System.Drawing.Size(1041, 566)
        Me.tlpFull.TabIndex = 1
        '
        'tlpDetailsMain
        '
        Me.tlpDetailsMain.ColumnCount = 2
        Me.tlpDetailsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDetailsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDetailsMain.Controls.Add(Me.tlpProfMain, 1, 0)
        Me.tlpDetailsMain.Controls.Add(Me.tlpNameMain, 0, 0)
        Me.tlpDetailsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDetailsMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpDetailsMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpDetailsMain.Name = "tlpDetailsMain"
        Me.tlpDetailsMain.RowCount = 2
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDetailsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDetailsMain.Size = New System.Drawing.Size(1041, 566)
        Me.tlpDetailsMain.TabIndex = 0
        '
        'tlpProfMain
        '
        Me.tlpProfMain.ColumnCount = 1
        Me.tlpProfMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProfMain.Controls.Add(Me.tlpProfMid, 0, 1)
        Me.tlpProfMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpProfMain.Location = New System.Drawing.Point(520, 0)
        Me.tlpProfMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpProfMain.Name = "tlpProfMain"
        Me.tlpProfMain.RowCount = 3
        Me.tlpProfMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpProfMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProfMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpProfMain.Size = New System.Drawing.Size(521, 283)
        Me.tlpProfMain.TabIndex = 0
        '
        'tlpProfMid
        '
        Me.tlpProfMid.ColumnCount = 6
        Me.tlpProfMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpProfMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpProfMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpProfMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpProfMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpProfMid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.tlpProfMid.Controls.Add(Me.Label5, 5, 0)
        Me.tlpProfMid.Controls.Add(Me.Label4, 4, 0)
        Me.tlpProfMid.Controls.Add(Me.Label3, 3, 0)
        Me.tlpProfMid.Controls.Add(Me.lbProf2Name, 2, 0)
        Me.tlpProfMid.Controls.Add(Me.lbProf1Name, 1, 0)
        Me.tlpProfMid.Controls.Add(Me.pbProf1Vanilla, 1, 1)
        Me.tlpProfMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpProfMid.Location = New System.Drawing.Point(0, 10)
        Me.tlpProfMid.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpProfMid.Name = "tlpProfMid"
        Me.tlpProfMid.RowCount = 10
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpProfMid.Size = New System.Drawing.Size(521, 263)
        Me.tlpProfMid.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(433, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Archaelogy"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(347, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fishing"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(261, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cooking"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbProf2Name
        '
        Me.lbProf2Name.AutoSize = True
        Me.lbProf2Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProf2Name.Location = New System.Drawing.Point(175, 0)
        Me.lbProf2Name.Name = "lbProf2Name"
        Me.lbProf2Name.Size = New System.Drawing.Size(80, 26)
        Me.lbProf2Name.TabIndex = 2
        Me.lbProf2Name.Text = "Prof2"
        Me.lbProf2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbProf1Name
        '
        Me.lbProf1Name.AutoSize = True
        Me.lbProf1Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProf1Name.Location = New System.Drawing.Point(89, 0)
        Me.lbProf1Name.Name = "lbProf1Name"
        Me.lbProf1Name.Size = New System.Drawing.Size(80, 26)
        Me.lbProf1Name.TabIndex = 0
        Me.lbProf1Name.Text = "Prof1"
        Me.lbProf1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbProf1Vanilla
        '
        Me.pbProf1Vanilla.Location = New System.Drawing.Point(86, 26)
        Me.pbProf1Vanilla.Margin = New System.Windows.Forms.Padding(0)
        Me.pbProf1Vanilla.Maximum = 300
        Me.pbProf1Vanilla.Name = "pbProf1Vanilla"
        Me.pbProf1Vanilla.Size = New System.Drawing.Size(86, 23)
        Me.pbProf1Vanilla.TabIndex = 6
        '
        'tlpNameMain
        '
        Me.tlpNameMain.ColumnCount = 2
        Me.tlpNameMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99751!))
        Me.tlpNameMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00249!))
        Me.tlpNameMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpNameMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpNameMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpNameMain.Name = "tlpNameMain"
        Me.tlpNameMain.RowCount = 1
        Me.tlpNameMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpNameMain.Size = New System.Drawing.Size(520, 283)
        Me.tlpNameMain.TabIndex = 1
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 596)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "Details"
        Me.Text = "Details"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpControlsMain.ResumeLayout(False)
        Me.tlpControlsRight.ResumeLayout(False)
        Me.tlpControlsLeft.ResumeLayout(False)
        Me.tlpFull.ResumeLayout(False)
        Me.tlpDetailsMain.ResumeLayout(False)
        Me.tlpProfMain.ResumeLayout(False)
        Me.tlpProfMid.ResumeLayout(False)
        Me.tlpProfMid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpControlsMain As TableLayoutPanel
    Friend WithEvents tlpControlsRight As TableLayoutPanel
    Friend WithEvents cmdClose As Button
    Friend WithEvents tlpFull As TableLayoutPanel
    Friend WithEvents tlpDetailsMain As TableLayoutPanel
    Friend WithEvents tlpProfMain As TableLayoutPanel
    Friend WithEvents tlpNameMain As TableLayoutPanel
    Friend WithEvents tlpProfMid As TableLayoutPanel
    Friend WithEvents tlpControlsLeft As TableLayoutPanel
    Friend WithEvents cmdPrevious As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbProf2Name As Label
    Friend WithEvents lbProf1Name As Label
    Friend WithEvents pbProf1Vanilla As ProgressBar
End Class
