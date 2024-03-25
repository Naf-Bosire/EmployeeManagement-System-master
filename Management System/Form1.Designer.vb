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
        Label1 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 20.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Drawing.Color.White
        Label1.Location = New System.Drawing.Point(165, 20)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(435, 37)
        Label1.TabIndex = 0
        Label1.Text = "Employeee Management System"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New System.Drawing.Point(12, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(909, 324)
        Panel1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New System.Drawing.Point(3, 255)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(288, 38)
        Button1.TabIndex = 3
        Button1.Text = "NewEmployee"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(44, 20)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(0, 15)
        Label2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Location = New System.Drawing.Point(394, 255)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(125, 38)
        Button2.TabIndex = 4
        Button2.Text = "Details"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New System.Drawing.Point(28, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(151, 96)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._240_F_127158933_cDZA4suMXsx2n0LQ03FzpX50R7fBaUx2
        PictureBox2.Location = New System.Drawing.Point(3, 60)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(288, 177)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New System.Drawing.Point(324, 60)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New System.Drawing.Size(219, 189)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Drawing.Color.Black
        ClientSize = New System.Drawing.Size(952, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
