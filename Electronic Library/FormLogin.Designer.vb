﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.LoginPictureBox = New System.Windows.Forms.PictureBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.LoginPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = true
        Me.UserNameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.UserNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UserNameLabel.Location = New System.Drawing.Point(69, 429)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(45, 18)
        Me.UserNameLabel.TabIndex = 0
        Me.UserNameLabel.Text = "Email"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameTextBox.Location = New System.Drawing.Point(120, 430)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(170, 20)
        Me.UserNameTextBox.TabIndex = 1
        Me.UserNameTextBox.Text = "nora.chang@sbcglobal.net"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = true
        Me.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PasswordLabel.Location = New System.Drawing.Point(315, 429)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(75, 18)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.Location = New System.Drawing.Point(396, 429)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(170, 20)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.Text = "nora"
        Me.PasswordTextBox.UseSystemPasswordChar = true
        '
        'LoginButton
        '
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.LoginButton.Location = New System.Drawing.Point(611, 423)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(90, 30)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = true
        '
        'LoginPictureBox
        '
        Me.LoginPictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginPictureBox.Image = CType(resources.GetObject("LoginPictureBox.Image"),System.Drawing.Image)
        Me.LoginPictureBox.InitialImage = Nothing
        Me.LoginPictureBox.Location = New System.Drawing.Point(46, 49)
        Me.LoginPictureBox.Name = "LoginPictureBox"
        Me.LoginPictureBox.Size = New System.Drawing.Size(785, 365)
        Me.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LoginPictureBox.TabIndex = 5
        Me.LoginPictureBox.TabStop = false
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = true
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.NameLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NameLabel.Location = New System.Drawing.Point(46, 18)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(283, 24)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Weclome to Electronic Library"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(191, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "A collaboration between the City of San Jose and San Jose State University"
        '
        'CloseButton
        '
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.CloseButton.Location = New System.Drawing.Point(717, 423)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(90, 30)
        Me.CloseButton.TabIndex = 8
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = true
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(872, 462)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.LoginPictureBox)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(888, 500)
        Me.MinimumSize = New System.Drawing.Size(888, 500)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        CType(Me.LoginPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents UserNameLabel As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents LoginPictureBox As PictureBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseButton As Button
End Class
