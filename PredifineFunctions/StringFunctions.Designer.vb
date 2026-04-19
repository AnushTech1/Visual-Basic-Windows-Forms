<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StringFunctions
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
        Label1 = New Label()
        lblResult = New Label()
        Button1 = New Button()
        txtInput = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter your text"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(592, 216)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 15)
        lblResult.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(78, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 36)
        Button1.TabIndex = 2
        Button1.Text = "btnProcess"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(174, 65)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(100, 23)
        txtInput.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtInput)
        Controls.Add(Button1)
        Controls.Add(lblResult)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtInput As TextBox

End Class
