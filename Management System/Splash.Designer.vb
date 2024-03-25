<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        percentage = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 14.25F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Drawing.Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label1.Location = New System.Drawing.Point(223, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(289, 25)
        Label1.TabIndex = 6
        Label1.Text = "Employee Management System"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._240_F_127158933_cDZA4suMXsx2n0LQ03FzpX50R7fBaUx21
        PictureBox1.Location = New System.Drawing.Point(241, 128)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(297, 216)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New System.Drawing.Point(244, 354)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New System.Drawing.Size(294, 51)
        ProgressBar1.TabIndex = 8
        ' 
        ' percentage
        ' 
        percentage.AutoSize = True
        percentage.Font = New System.Drawing.Font("Segoe UI", 15.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        percentage.Location = New System.Drawing.Point(544, 369)
        percentage.Name = "percentage"
        percentage.Size = New System.Drawing.Size(73, 30)
        percentage.TabIndex = 9
        percentage.Text = "Label2"
        ' 
        ' Splash
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._240_F_329873918_0Nsig2fHlpyxZkV8o56PkxSp9meBrc2i1
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(percentage)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash"
        Text = "Splash"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents percentage As Label
End Class
