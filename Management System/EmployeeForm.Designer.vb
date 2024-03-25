<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        EmployeeName = New TextBox()
        EmployeeAddress = New TextBox()
        EmployeePhoneNo = New TextBox()
        EmployeePosition = New ComboBox()
        EducationLevel = New ComboBox()
        Specilization = New ComboBox()
        DOB = New DateTimePicker()
        Gender = New ComboBox()
        ListView1 = New ListView()
        Button4 = New Button()
        Label9 = New Label()
        id = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(23, 99)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(91, 15)
        Label1.TabIndex = 0
        Label1.Text = "EmployeeName"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(267, 99)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(105, 15)
        Label6.TabIndex = 5
        Label6.Text = "Employee position"
        ' 
        ' Button1
        ' 
        Button1.Location = New System.Drawing.Point(7, 399)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(105, 39)
        Button1.TabIndex = 20
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.CausesValidation = False
        Button2.Location = New System.Drawing.Point(181, 399)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(105, 39)
        Button2.TabIndex = 21
        Button2.Text = "New "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New System.Drawing.Point(375, 399)
        Button3.Name = "Button3"
        Button3.Size = New System.Drawing.Size(105, 39)
        Button3.TabIndex = 22
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._240_F_434268583_xKp6hBulOD9fcgMsEJpG3HvJMg7vNCSB
        PictureBox1.Location = New System.Drawing.Point(7, -12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(221, 123)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New System.Drawing.Point(7, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(829, 96)
        Panel1.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(21, 157)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(101, 15)
        Label2.TabIndex = 1
        Label2.Text = "EmployeeAddress"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(23, 217)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(109, 15)
        Label3.TabIndex = 2
        Label3.Text = "EmployeePhoneNo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(23, 280)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 15)
        Label4.TabIndex = 3
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(21, 335)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(75, 15)
        Label5.TabIndex = 4
        Label5.Text = "Date Of Birth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(273, 199)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(90, 15)
        Label7.TabIndex = 6
        Label7.Text = "Education Level"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(273, 262)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(73, 15)
        Label8.TabIndex = 7
        Label8.Text = "Specilization"
        ' 
        ' EmployeeName
        ' 
        EmployeeName.Location = New System.Drawing.Point(21, 117)
        EmployeeName.Name = "EmployeeName"
        EmployeeName.Size = New System.Drawing.Size(158, 23)
        EmployeeName.TabIndex = 8
        ' 
        ' EmployeeAddress
        ' 
        EmployeeAddress.Location = New System.Drawing.Point(21, 175)
        EmployeeAddress.Name = "EmployeeAddress"
        EmployeeAddress.Size = New System.Drawing.Size(158, 23)
        EmployeeAddress.TabIndex = 9
        ' 
        ' EmployeePhoneNo
        ' 
        EmployeePhoneNo.Location = New System.Drawing.Point(21, 235)
        EmployeePhoneNo.Name = "EmployeePhoneNo"
        EmployeePhoneNo.Size = New System.Drawing.Size(158, 23)
        EmployeePhoneNo.TabIndex = 10
        ' 
        ' EmployeePosition
        ' 
        EmployeePosition.FormattingEnabled = True
        EmployeePosition.Items.AddRange(New Object() {"Manager", "Accountant", "Driver", "Security", "ICT consultant"})
        EmployeePosition.Location = New System.Drawing.Point(267, 117)
        EmployeePosition.Name = "EmployeePosition"
        EmployeePosition.Size = New System.Drawing.Size(93, 23)
        EmployeePosition.TabIndex = 12
        ' 
        ' EducationLevel
        ' 
        EducationLevel.FormattingEnabled = True
        EducationLevel.Items.AddRange(New Object() {"Certificate", "Diploma", "Degree", "Masters", "PhD"})
        EducationLevel.Location = New System.Drawing.Point(267, 217)
        EducationLevel.Name = "EducationLevel"
        EducationLevel.Size = New System.Drawing.Size(119, 23)
        EducationLevel.TabIndex = 13
        ' 
        ' Specilization
        ' 
        Specilization.FormattingEnabled = True
        Specilization.Items.AddRange(New Object() {"ICT", "Marketing", "Internal Auditing", "Security & Logistics", "Management", "Tender"})
        Specilization.Location = New System.Drawing.Point(273, 280)
        Specilization.Name = "Specilization"
        Specilization.Size = New System.Drawing.Size(93, 23)
        Specilization.TabIndex = 19
        ' 
        ' DOB
        ' 
        DOB.Location = New System.Drawing.Point(21, 353)
        DOB.Name = "DOB"
        DOB.Size = New System.Drawing.Size(214, 23)
        DOB.TabIndex = 18
        ' 
        ' Gender
        ' 
        Gender.FormattingEnabled = True
        Gender.Items.AddRange(New Object() {"Male", "Female"})
        Gender.Location = New System.Drawing.Point(23, 298)
        Gender.Name = "Gender"
        Gender.Size = New System.Drawing.Size(156, 23)
        Gender.TabIndex = 25
        ' 
        ' ListView1
        ' 
        ListView1.Font = New System.Drawing.Font("Segoe UI", 8F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New System.Drawing.Point(392, 99)
        ListView1.Name = "ListView1"
        ListView1.Size = New System.Drawing.Size(444, 251)
        ListView1.TabIndex = 26
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Button4
        ' 
        Button4.Location = New System.Drawing.Point(522, 399)
        Button4.Name = "Button4"
        Button4.Size = New System.Drawing.Size(116, 39)
        Button4.TabIndex = 27
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(660, 391)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(41, 15)
        Label9.TabIndex = 28
        Label9.Text = "Label9"
        ' 
        ' id
        ' 
        id.Location = New System.Drawing.Point(707, 383)
        id.Name = "id"
        id.Size = New System.Drawing.Size(73, 23)
        id.TabIndex = 29
        ' 
        ' EmployeeForm
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(864, 452)
        Controls.Add(id)
        Controls.Add(Label9)
        Controls.Add(Button4)
        Controls.Add(ListView1)
        Controls.Add(Gender)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Specilization)
        Controls.Add(DOB)
        Controls.Add(EducationLevel)
        Controls.Add(EmployeePosition)
        Controls.Add(EmployeePhoneNo)
        Controls.Add(EmployeeAddress)
        Controls.Add(EmployeeName)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EmployeeForm"
        Text = "EmployeeForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EmployeeName As TextBox
    Friend WithEvents EmployeeAddress As TextBox
    Friend WithEvents EmployeePhoneNo As TextBox
    Friend WithEvents EmployeePosition As ComboBox
    Friend WithEvents EducationLevel As ComboBox
    Friend WithEvents Specilization As ComboBox
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Gender As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button4 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents id As TextBox
End Class
