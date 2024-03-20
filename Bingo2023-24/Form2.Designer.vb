<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class board
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(board))
        Me.pnlBoard = New System.Windows.Forms.Panel()
        Me.pnlCardTop = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlBoard
        '
        Me.pnlBoard.Location = New System.Drawing.Point(35, 115)
        Me.pnlBoard.Name = "pnlBoard"
        Me.pnlBoard.Size = New System.Drawing.Size(256, 260)
        Me.pnlBoard.TabIndex = 0
        '
        'pnlCardTop
        '
        Me.pnlCardTop.Location = New System.Drawing.Point(35, 32)
        Me.pnlCardTop.Name = "pnlCardTop"
        Me.pnlCardTop.Size = New System.Drawing.Size(256, 58)
        Me.pnlCardTop.TabIndex = 1
        '
        'board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(483, 521)
        Me.Controls.Add(Me.pnlCardTop)
        Me.Controls.Add(Me.pnlBoard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "board"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBoard As Panel
    Friend WithEvents pnlCardTop As Panel
End Class
