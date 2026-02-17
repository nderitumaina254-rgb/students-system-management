Public Class Form1
    Dim table As New DataTable()


    Private Sub frmStudentManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        table.Columns.Add("Student ID")
        table.Columns.Add("Student Name")
        table.Columns.Add("Email")
        table.Columns.Add("Phone")
        table.Columns.Add("Course")
        table.Columns.Add("Gender")

        dgvStudents.DataSource = table

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtStudentID.Text = "" Or txtStudentName.Text = "" Then
            MessageBox.Show("Please fill all required fields.")
            Exit Sub
        End If

        table.Rows.Add(txtStudentID.Text,
                       txtStudentName.Text,
                       txtEmail.Text,
                       txtPhone.Text,
                       txtCourse.Text,
                       txtGender.Text)

        MessageBox.Show("Record Added Successfully!")

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgvStudents.CurrentRow IsNot Nothing Then

            dgvStudents.CurrentRow.Cells(0).Value = txtStudentID.Text
            dgvStudents.CurrentRow.Cells(1).Value = txtStudentName.Text
            dgvStudents.CurrentRow.Cells(2).Value = txtEmail.Text
            dgvStudents.CurrentRow.Cells(3).Value = txtPhone.Text
            dgvStudents.CurrentRow.Cells(4).Value = txtCourse.Text
            dgvStudents.CurrentRow.Cells(5).Value = txtGender.Text

            MessageBox.Show("Record Updated!")

        End If

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvStudents.CurrentRow IsNot Nothing Then
            dgvStudents.Rows.Remove(dgvStudents.CurrentRow)
            MessageBox.Show("Record Deleted!")
        End If

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtStudentID.Clear()
        txtStudentName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtCourse.Clear()
        txtGender.Clear()

    End Sub
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick

        If e.RowIndex >= 0 Then

            txtStudentID.Text = dgvStudents.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtStudentName.Text = dgvStudents.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtEmail.Text = dgvStudents.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtPhone.Text = dgvStudents.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtCourse.Text = dgvStudents.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtGender.Text = dgvStudents.Rows(e.RowIndex).Cells(5).Value.ToString()

        End If

    End Sub
End Class