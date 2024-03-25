
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class EmployeeForm
    Dim MySqlConnection As New MySqlConnection("host=127.001;user=root;database=management;")
    Dim cm As MySqlCommand
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MySqlConnection.Open()
            MessageBox.Show("successful connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ListView1.Columns.Add("EmployeeName", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("EmployeeAddress", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("EmployeePhoneNo", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("Gender", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("DOB", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("EmployeePosition", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("EducationLevel", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("Specilization", 110, HorizontalAlignment.Left)




    End Sub



    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Specilization.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles EmployeeName.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cm = New MySqlCommand("insert into employeedetails values('" & id.Text & "','" & EmployeeName.Text & "','" & EmployeeAddress.Text & "','" & EmployeePhoneNo.Text & "','" & Gender.Text & "','" & DOB.Text & "','" & EmployeePosition.Text & "','" & EducationLevel.Text & "','" & Specilization.Text & "')", MySqlConnection)
            cm.ExecuteNonQuery()
            MsgBox("Data sent Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim newItem As New ListViewItem(EmployeeName.Text)
        newItem.SubItems.Add(EmployeeAddress.Text)
        newItem.SubItems.Add(EmployeePhoneNo.Text)
        newItem.SubItems.Add(Gender.Text)
        newItem.SubItems.Add(DOB.Text)
        newItem.SubItems.Add(EmployeePosition.Text)
        newItem.SubItems.Add(EducationLevel.Text)
        newItem.SubItems.Add(Specilization.Text)

        ListView1.Items.Add(newItem)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Dim key = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).SubItems(0).Text = EmployeeName.Text
            ListView1.SelectedItems(0).SubItems(1).Text = EmployeeAddress.Text
            ListView1.SelectedItems(0).SubItems(2).Text = EmployeePhoneNo.Text
            ListView1.SelectedItems(0).SubItems(3).Text = Gender.Text
            ListView1.SelectedItems(0).SubItems(4).Text = DOB.Text
            ListView1.SelectedItems(0).SubItems(5).Text = EducationLevel.Text
            ListView1.SelectedItems(0).SubItems(6).Text = EmployeePosition.Text
            ListView1.SelectedItems(0).SubItems(7).Text = Specilization.Text
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EmployeeName.Text = ""
        EmployeeAddress.Text = ""
        EmployeePhoneNo.Text = ""
        Gender.Text = ""
        DOB.Text = ""
        EducationLevel.Text = ""
        EmployeePosition.Text = ""
        Specilization.Text = ""

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            EmployeeName.Text = ListView1.SelectedItems(0).SubItems(0).Text
            EmployeeAddress.Text = ListView1.SelectedItems(0).SubItems(1).Text
            EmployeePhoneNo.Text = ListView1.SelectedItems(0).SubItems(2).Text
            Gender.Text = ListView1.SelectedItems(0).SubItems(3).Text
            DOB.Text = ListView1.SelectedItems(0).SubItems(4).Text
            EmployeePosition.Text = ListView1.SelectedItems(0).SubItems(5).Text
            EducationLevel.Text = ListView1.SelectedItems(0).SubItems(6).Text
            Specilization.Text = ListView1.SelectedItems(0).SubItems(7).Text







        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newForm As New MainForm()
        newForm.Show()
    End Sub
End Class