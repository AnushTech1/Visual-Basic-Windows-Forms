<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateTimePicker
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
        DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(173, 31)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(451, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 40)
        Button1.TabIndex = 1
        Button1.Text = "Show Selected Date"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(33, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 21)
        Label1.TabIndex = 2
        Label1.Text = "select a date"
        ' 
        ' DateTimePicker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Name = "DateTimePicker"
        Text = "DateTimePicker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
