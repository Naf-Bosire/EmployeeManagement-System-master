<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        labelposition = New Label()
        labelname = New Label()
        Button3 = New Button()
        employeetextbox = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        salarytextbox = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        RichTextBox1 = New RichTextBox()
        Button4 = New Button()
        Newemployee = New Button()
        SuspendLayout()
        ' 
        ' labelposition
        ' 
        labelposition.AutoSize = True
        labelposition.ForeColor = Drawing.Color.Red
        labelposition.Location = New System.Drawing.Point(18, 220)
        labelposition.Name = "labelposition"
        labelposition.Size = New System.Drawing.Size(105, 15)
        labelposition.TabIndex = 71
        labelposition.Text = "Employee position"
        ' 
        ' labelname
        ' 
        labelname.AutoSize = True
        labelname.ForeColor = Drawing.Color.Red
        labelname.Location = New System.Drawing.Point(12, 143)
        labelname.Name = "labelname"
        labelname.Size = New System.Drawing.Size(91, 15)
        labelname.TabIndex = 70
        labelname.Text = "EmployeeName"
        ' 
        ' Button3
        ' 
        Button3.Location = New System.Drawing.Point(258, 31)
        Button3.Name = "Button3"
        Button3.Size = New System.Drawing.Size(89, 23)
        Button3.TabIndex = 65
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' employeetextbox
        ' 
        employeetextbox.Location = New System.Drawing.Point(94, 27)
        employeetextbox.Name = "employeetextbox"
        employeetextbox.Size = New System.Drawing.Size(158, 23)
        employeetextbox.TabIndex = 64
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(18, 35)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(70, 15)
        Label9.TabIndex = 63
        Label9.Text = "EmployeeID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(18, 191)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(105, 15)
        Label6.TabIndex = 60
        Label6.Text = "Employee position"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(18, 280)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(137, 15)
        Label3.TabIndex = 57
        Label3.Text = "Number of Days Worked"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 107)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(91, 15)
        Label1.TabIndex = 55
        Label1.Text = "EmployeeName"
        ' 
        ' salarytextbox
        ' 
        salarytextbox.Location = New System.Drawing.Point(18, 298)
        salarytextbox.Name = "salarytextbox"
        salarytextbox.Size = New System.Drawing.Size(158, 23)
        salarytextbox.TabIndex = 72
        ' 
        ' Button1
        ' 
        Button1.Location = New System.Drawing.Point(18, 396)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(89, 23)
        Button1.TabIndex = 73
        Button1.Text = "Print"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New System.Drawing.Point(204, 298)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(89, 23)
        Button2.TabIndex = 74
        Button2.Text = "View"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New System.Drawing.Point(356, 98)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New System.Drawing.Size(432, 264)
        RichTextBox1.TabIndex = 75
        RichTextBox1.Text = ""
        ' 
        ' Button4
        ' 
        Button4.Location = New System.Drawing.Point(309, 396)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(89, 23)
        Button4.TabIndex = 76
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Newemployee
        ' 
        Newemployee.Location = New System.Drawing.Point(160, 396)
        Newemployee.Name = "Newemployee"
        Newemployee.Size = New System.Drawing.Size(92, 23)
        Newemployee.TabIndex = 77
        Newemployee.Text = "New"
        Newemployee.UseVisualStyleBackColor = True
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(Newemployee)
        Controls.Add(Button4)
        Controls.Add(RichTextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(salarytextbox)
        Controls.Add(labelposition)
        Controls.Add(labelname)
        Controls.Add(Button3)
        Controls.Add(employeetextbox)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Salary"
        Text = "Salary"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelposition As Label
    Friend WithEvents labelname As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents employeetextbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents salarytextbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Newemployee As Button
End Class
