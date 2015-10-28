<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(383, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "High Score:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(386, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(385, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sudokugui_1._0._1.My.Resources.Resources._12
        Me.PictureBox2.Location = New System.Drawing.Point(387, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 42)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._4
        Me.Button5.Location = New System.Drawing.Point(379, 323)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 25)
        Me.Button5.TabIndex = 10
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._11
        Me.Button4.Location = New System.Drawing.Point(379, 278)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 25)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._8
        Me.Button3.Location = New System.Drawing.Point(379, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 25)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._7
        Me.Button2.Location = New System.Drawing.Point(379, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 25)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._1
        Me.Button1.Location = New System.Drawing.Point(124, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 25)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._5
        Me.PictureBox1.Location = New System.Drawing.Point(76, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 64)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(523, 442)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
End Class
