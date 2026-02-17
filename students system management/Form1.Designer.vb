<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblStudentID = New Label()
        lblStudentName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblCourse = New Label()
        lblGender = New Label()
        txtStudentID = New TextBox()
        txtStudentName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtCourse = New TextBox()
        txtGender = New TextBox()
        btnSubmit = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnReset = New Button()
        dgvStudents = New DataGridView()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.BackColor = SystemColors.ButtonShadow
        lblStudentID.Location = New Point(69, 21)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(96, 25)
        lblStudentID.TabIndex = 0
        lblStudentID.Text = "Student ID"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.BackColor = SystemColors.AppWorkspace
        lblStudentName.Location = New Point(69, 71)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(125, 25)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "Student Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = SystemColors.AppWorkspace
        lblEmail.Location = New Point(69, 118)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.BackColor = SystemColors.AppWorkspace
        lblPhone.Location = New Point(69, 167)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(132, 25)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone Number"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.BackColor = SystemColors.AppWorkspace
        lblCourse.Location = New Point(69, 211)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(67, 25)
        lblCourse.TabIndex = 4
        lblCourse.Text = "Course"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = SystemColors.AppWorkspace
        lblGender.Location = New Point(67, 253)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 5
        lblGender.Text = "Gender"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.BackColor = SystemColors.InactiveCaption
        txtStudentID.Location = New Point(244, 21)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(150, 31)
        txtStudentID.TabIndex = 6
        ' 
        ' txtStudentName
        ' 
        txtStudentName.BackColor = SystemColors.InactiveCaption
        txtStudentName.Location = New Point(244, 65)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(150, 31)
        txtStudentName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.InactiveCaption
        txtEmail.Location = New Point(244, 118)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.InactiveCaption
        txtPhone.Location = New Point(244, 161)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 9
        ' 
        ' txtCourse
        ' 
        txtCourse.BackColor = SystemColors.InactiveCaption
        txtCourse.Location = New Point(244, 205)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(150, 31)
        txtCourse.TabIndex = 10
        ' 
        ' txtGender
        ' 
        txtGender.BackColor = SystemColors.InactiveCaption
        txtGender.Location = New Point(244, 253)
        txtGender.Name = "txtGender"
        txtGender.ScrollBars = ScrollBars.Both
        txtGender.Size = New Size(150, 31)
        txtGender.TabIndex = 11
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Aqua
        btnSubmit.Location = New Point(120, 319)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 12
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.MenuHighlight
        btnUpdate.Location = New Point(267, 319)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Location = New Point(418, 322)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnReset.Location = New Point(570, 319)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 15
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' dgvStudents
        ' 
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(-11, 380)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersWidth = 62
        dgvStudents.Size = New Size(899, 225)
        dgvStudents.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvStudents)
        Controls.Add(btnReset)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSubmit)
        Controls.Add(txtGender)
        Controls.Add(txtCourse)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtStudentName)
        Controls.Add(txtStudentID)
        Controls.Add(lblGender)
        Controls.Add(lblCourse)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblStudentName)
        Controls.Add(lblStudentID)
        Name = "Form1"
        Text = "Form1"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents dgvStudents As DataGridView

End Class
