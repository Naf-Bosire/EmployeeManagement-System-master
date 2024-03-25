<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        userid = New TextBox()
        passwordTb = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 14.25F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, CByte(0))
        Label1.Location = New System.Drawing.Point(145, 21)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(289, 25)
        Label1.TabIndex = 0
        Label1.Text = "Employee Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(38, 181)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(36, 110)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(44, 15)
        Label3.TabIndex = 2
        Label3.Text = "User ID"
        ' 
        ' userid
        ' 
        userid.Location = New System.Drawing.Point(101, 110)
        userid.Name = "userid"
        userid.Size = New System.Drawing.Size(145, 23)
        userid.TabIndex = 3
        ' 
        ' passwordTb
        ' 
        passwordTb.Location = New System.Drawing.Point(101, 178)
        passwordTb.Name = "passwordTb"
        passwordTb.Size = New System.Drawing.Size(145, 23)
        passwordTb.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New System.Drawing.Point(115, 306)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(109, 30)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New System.Drawing.Point(315, 306)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(109, 30)
        Button2.TabIndex = 6
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Drawing.Color.White
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(passwordTb)
        Controls.Add(userid)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "loginform"
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents userid As TextBox
    Friend WithEvents passwordTb As TextBox
End Class
