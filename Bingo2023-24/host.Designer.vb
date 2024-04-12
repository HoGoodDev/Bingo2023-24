<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class host
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(host))
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.lblCurrentNum = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstPrevious = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(43, 168)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(264, 49)
        Me.btnDraw.TabIndex = 0
        Me.btnDraw.Text = "Draw Number"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'lblCurrentNum
        '
        Me.lblCurrentNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentNum.Location = New System.Drawing.Point(43, 234)
        Me.lblCurrentNum.Name = "lblCurrentNum"
        Me.lblCurrentNum.Size = New System.Drawing.Size(264, 139)
        Me.lblCurrentNum.TabIndex = 1
        Me.lblCurrentNum.Text = "B17"
        Me.lblCurrentNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lstPrevious
        '
        Me.lstPrevious.FormattingEnabled = True
        Me.lstPrevious.Location = New System.Drawing.Point(352, 57)
        Me.lstPrevious.Name = "lstPrevious"
        Me.lstPrevious.Size = New System.Drawing.Size(80, 316)
        Me.lstPrevious.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Previous Calls"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(522, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ReturnToMenuToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&file"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ReturnToMenuToolStripMenuItem
        '
        Me.ReturnToMenuToolStripMenuItem.Name = "ReturnToMenuToolStripMenuItem"
        Me.ReturnToMenuToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ReturnToMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReturnToMenuToolStripMenuItem.Text = "Return To Menu"
        '
        'host
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 388)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPrevious)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCurrentNum)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "host"
        Me.Text = "Bing Host"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents lblCurrentNum As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstPrevious As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToMenuToolStripMenuItem As ToolStripMenuItem
End Class
