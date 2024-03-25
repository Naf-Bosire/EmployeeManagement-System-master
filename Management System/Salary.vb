Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Salary
    Dim connection As New MySqlConnection("Server=localhost; Database=management; Uid=root; Pwd=;")

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As Integer = CInt(employeetextbox.Text) ' Assuming you have a TextBox for ID input
        Dim query As String = "SELECT * FROM employeedetails WHERE id = @id"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", id)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                labelname.Text = reader.GetString("EmployeeName") ' Replace "column_name1" with your column name
                labelposition.Text = reader.GetString("EmployeePosition") ' Replace "column_name2" with your column name
                ' Add more labels as needed
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newForm As New MainForm()
        newForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Const constantValue As Integer = 1728 ' Declare your constant integer value here
        Dim inputValue As Integer

        If Integer.TryParse(salarytextbox.Text, inputValue) Then ' Check if the input can be parsed as an integer
            Dim result As Integer = constantValue * inputValue ' Multiply the constant and the input value
            MessageBox.Show($"Your Salary is🤑🤑🤑$: {result}") ' Display the result in a MessageBox
        Else
            MessageBox.Show("Please enter a valid days☹️.") ' Inform the user if the input is not a valid integer
        End If

        RichTextBox1.Clear() ' Clear the RichTextBox before adding new content

        ' Add the text from Label1 to the RichTextBox
        RichTextBox1.AppendText("Employee Name: " & labelname.Text & Environment.NewLine)

        ' Add the text from Label2 to the RichTextBox
        RichTextBox1.AppendText("Employee Position: " & labelposition.Text & Environment.NewLine)

        ' Add the text from TextBox1 to the RichTextBox
        RichTextBox1.AppendText("No of Days Worked: " & salarytextbox.Text & Environment.NewLine)
    End Sub

    Private Sub Newemployee_Click(sender As Object, e As EventArgs) Handles Newemployee.Click
        labelname.Text = ""
        labelposition.Text = ""
        salarytextbox.Text = ""
        employeetextbox.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub salarytextbox_TextChanged(sender As Object, e As EventArgs) Handles salarytextbox.TextChanged

    End Sub
End Class