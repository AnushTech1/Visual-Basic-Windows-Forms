<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arithmetic
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
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label1.Location = New Point(139, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter First number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.Location = New Point(139, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 20)
        Label2.TabIndex = 1
        Label2.Text = "Enter Second number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(358, 104)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(358, 148)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(138, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(369, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 34)
        Button1.TabIndex = 4
        Button1.Text = "Result"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 30
        ListBox1.Items.AddRange(New Object() {"+", "-", "*", "/", "%"})
        ListBox1.Location = New Point(542, 89)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(39, 154)
        ListBox1.TabIndex = 5
        ' 
        ' Arithmetic
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1038, 493)
        Controls.Add(ListBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Arithmetic"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox

End Class
