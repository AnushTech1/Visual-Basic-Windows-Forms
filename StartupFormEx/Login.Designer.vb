<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Login = New Button()
        username = New TextBox()
        password = New TextBox()
        SuspendLayout()
        ' 
        ' Login
        ' 
        Login.Location = New Point(280, 144)
        Login.Name = "Login"
        Login.Size = New Size(75, 23)
        Login.TabIndex = 0
        Login.Text = "login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' username
        ' 
        username.Location = New Point(280, 41)
        username.Name = "username"
        username.Size = New Size(100, 23)
        username.TabIndex = 1
        ' 
        ' password
        ' 
        password.Location = New Point(280, 89)
        password.Name = "password"
        password.Size = New Size(100, 23)
        password.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(password)
        Controls.Add(username)
        Controls.Add(Login)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login As Button
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox

End Class
