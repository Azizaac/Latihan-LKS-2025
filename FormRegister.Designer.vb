<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Me.NamaLengkap = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.NoHP = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNamaLengkap = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NamaLengkap
        '
        Me.NamaLengkap.AutoSize = True
        Me.NamaLengkap.Location = New System.Drawing.Point(208, 188)
        Me.NamaLengkap.Name = "NamaLengkap"
        Me.NamaLengkap.Size = New System.Drawing.Size(80, 13)
        Me.NamaLengkap.TabIndex = 8
        Me.NamaLengkap.Text = "Nama Lengkap"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(208, 162)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(53, 13)
        Me.Password.TabIndex = 9
        Me.Password.Text = "Password"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(294, 304)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(105, 32)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(294, 211)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(287, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtNoHp
        '
        Me.txtNoHp.Location = New System.Drawing.Point(294, 237)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(287, 20)
        Me.txtNoHp.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(294, 133)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(287, 20)
        Me.txtUsername.TabIndex = 5
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(208, 140)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 9
        Me.Username.Text = "Username"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(208, 211)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(32, 13)
        Me.Email.TabIndex = 8
        Me.Email.Text = "Email"
        '
        'NoHP
        '
        Me.NoHP.AutoSize = True
        Me.NoHP.Location = New System.Drawing.Point(208, 237)
        Me.NoHP.Name = "NoHP"
        Me.NoHP.Size = New System.Drawing.Size(39, 13)
        Me.NoHP.TabIndex = 8
        Me.NoHP.Text = "No HP"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(294, 159)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(287, 20)
        Me.txtPassword.TabIndex = 5
        '
        'txtNamaLengkap
        '
        Me.txtNamaLengkap.Location = New System.Drawing.Point(294, 185)
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.Size = New System.Drawing.Size(287, 20)
        Me.txtNamaLengkap.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(435, 304)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 32)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NoHP)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.NamaLengkap)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtNoHp)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNamaLengkap)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "FormRegister"
        Me.Text = "formRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NamaLengkap As Label
    Friend WithEvents Password As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents Email As Label
    Friend WithEvents NoHP As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtNamaLengkap As TextBox
    Friend WithEvents btnCancel As Button
End Class
