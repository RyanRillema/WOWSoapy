<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverView
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpControlsMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpFull = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpBase = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain.SuspendLayout()
        Me.tlpControlsMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpFull.SuspendLayout()
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
        Me.tlpMain.Size = New System.Drawing.Size(1349, 632)
        Me.tlpMain.TabIndex = 0
        '
        'tlpControlsMain
        '
        Me.tlpControlsMain.ColumnCount = 2
        Me.tlpControlsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControlsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControlsMain.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.tlpControlsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControlsMain.Location = New System.Drawing.Point(0, 602)
        Me.tlpControlsMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpControlsMain.Name = "tlpControlsMain"
        Me.tlpControlsMain.RowCount = 1
        Me.tlpControlsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControlsMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpControlsMain.Size = New System.Drawing.Size(1349, 30)
        Me.tlpControlsMain.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdClose, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(674, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(675, 30)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdClose.Location = New System.Drawing.Point(560, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(115, 30)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tlpFull
        '
        Me.tlpFull.ColumnCount = 1
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFull.Controls.Add(Me.tlpBase, 0, 0)
        Me.tlpFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFull.Location = New System.Drawing.Point(0, 0)
        Me.tlpFull.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFull.Name = "tlpFull"
        Me.tlpFull.RowCount = 1
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFull.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFull.Size = New System.Drawing.Size(1349, 602)
        Me.tlpFull.TabIndex = 1
        '
        'tlpBase
        '
        Me.tlpBase.ColumnCount = 2
        Me.tlpBase.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpBase.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBase.Location = New System.Drawing.Point(0, 0)
        Me.tlpBase.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpBase.Name = "tlpBase"
        Me.tlpBase.RowCount = 26
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846731!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846732!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846731!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.845578!))
        Me.tlpBase.Size = New System.Drawing.Size(1349, 602)
        Me.tlpBase.TabIndex = 0
        '
        'OverView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 632)
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "OverView"
        Me.Text = "OverView"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpControlsMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlpFull.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpControlsMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmdClose As Button
    Friend WithEvents tlpFull As TableLayoutPanel
    Friend WithEvents tlpBase As TableLayoutPanel
End Class
