<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(160, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(93, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._3
        Me.Button3.Location = New System.Drawing.Point(160, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 25)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._4
        Me.Button2.Location = New System.Drawing.Point(160, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 25)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._2
        Me.Button5.Location = New System.Drawing.Point(160, 138)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 25)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._5
        Me.PictureBox1.Location = New System.Drawing.Point(77, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 64)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.BackgroundImage = Global.Sudokugui_1._0._1.My.Resources.Resources._1
        Me.Button1.Location = New System.Drawing.Point(160, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(430, 378)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
