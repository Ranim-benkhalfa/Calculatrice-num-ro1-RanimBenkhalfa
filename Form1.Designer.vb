<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Button5 = New Button()
        Button6 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Button1.ForeColor = Color.Maroon
        Button1.Location = New Point(500, 63)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 71)
        Button1.TabIndex = 0
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Button2.ForeColor = Color.Maroon
        Button2.Location = New Point(506, 184)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 71)
        Button2.TabIndex = 1
        Button2.Text = "-"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Button3.ForeColor = Color.Maroon
        Button3.Location = New Point(511, 318)
        Button3.Name = "Button3"
        Button3.Size = New Size(83, 71)
        Button3.TabIndex = 2
        Button3.Text = "*"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaption
        Button4.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Button4.ForeColor = Color.Maroon
        Button4.Location = New Point(641, 63)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 71)
        Button4.TabIndex = 3
        Button4.Text = "/"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        TextBox1.Location = New Point(245, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        TextBox2.Location = New Point(245, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(676, 343)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 41)
        Label1.TabIndex = 6
        Label1.Text = "reset"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ActiveCaption
        Button5.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Button5.ForeColor = Color.Maroon
        Button5.Location = New Point(641, 184)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 65)
        Button5.TabIndex = 7
        Button5.Text = "="
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Teal
        Button6.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(201, 299)
        Button6.Name = "Button6"
        Button6.Size = New Size(179, 71)
        Button6.TabIndex = 8
        Button6.Text = "résultat"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(114, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 38)
        Label2.TabIndex = 9
        Label2.Text = "A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(114, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 38)
        Label3.TabIndex = 10
        Label3.Text = "B"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
