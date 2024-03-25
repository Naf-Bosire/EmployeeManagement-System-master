Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing


Public Class Employee_Details
    Dim connection As New MySqlConnection("Server=localhost; Database=management; Uid=root; Pwd=;")
    Private WithEvents printDoc As New PrintDocument()
    Private printDialog As New PrintDialog()



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As Integer = CInt(TextBox1.Text) ' Assuming you have a TextBox for ID input
        Dim query As String = "SELECT * FROM employeedetails WHERE id = @id"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", id)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                Labela.Text = reader.GetString("EmployeeName") ' Replace "column_name1" with your column name
                labelb.Text = reader.GetString("EmployeeAddress") ' Replace "column_name2" with your column name
                labelc.Text = reader.GetString("EmployeePhoneNo")
                labeld.Text = reader.GetString("Gender")
                labele.Text = reader.GetString("DateOfBirth")
                labelf.Text = reader.GetString("EmployeePosition")
                labelg.Text = reader.GetString("EduacationLevel")
                labelh.Text = reader.GetString("Specialization")



                ' Add more labels as needed
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Employee_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles labelf.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New MainForm()
        newForm.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        printDialog.Document = printDoc
        printDialog.ShowDialog()
    End Sub
    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim font As New Font("Arial", 12) ' Replace "Arial" and 12 with desired font name and size
        Dim text As String = Labela.Text & Environment.NewLine & labelb.Text & Environment.NewLine & labelc.Text & Environment.NewLine & labeld.Text & Environment.NewLine & labele.Text & Environment.NewLine & labelf.Text & Environment.NewLine & labelg.Text & Environment.NewLine & labelh.Text
        e.Graphics.DrawString(text, font, Brushes.Black, e.MarginBounds) ' Replace Brushes.Black with desired color
    End Sub

    Private Sub Newdetail_Click(sender As Object, e As EventArgs) Handles Newdetail.Click
        Labela.Text = ""
        labelb.Text = ""
        labelc.Text = ""
        labeld.Text = ""
        labele.Text = ""
        labelf.Text = ""
        labelg.Text = ""
        labelh.Text = ""
    End Sub
End Class