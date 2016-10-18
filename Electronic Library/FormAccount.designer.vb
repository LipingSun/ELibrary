<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Me.AccountLabel = New System.Windows.Forms.Label()
        Me.ResourceLabel = New System.Windows.Forms.Label()
        Me.AccountResourceListView = New System.Windows.Forms.ListView()
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PublicationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Series = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Subject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.RenewBotton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DNameLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.DEmailLabel = New System.Windows.Forms.Label()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AccountLabel
        '
        Me.AccountLabel.AutoSize = True
        Me.AccountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountLabel.Location = New System.Drawing.Point(38, 31)
        Me.AccountLabel.Name = "AccountLabel"
        Me.AccountLabel.Size = New System.Drawing.Size(91, 26)
        Me.AccountLabel.TabIndex = 0
        Me.AccountLabel.Text = "Account"
        '
        'ResourceLabel
        '
        Me.ResourceLabel.AutoSize = True
        Me.ResourceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResourceLabel.Location = New System.Drawing.Point(39, 160)
        Me.ResourceLabel.Name = "ResourceLabel"
        Me.ResourceLabel.Size = New System.Drawing.Size(105, 26)
        Me.ResourceLabel.TabIndex = 1
        Me.ResourceLabel.Text = "Resource"
        '
        'AccountResourceListView
        '
        Me.AccountResourceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Title, Me.Author, Me.PublicationDate, Me.Series, Me.ISBN, Me.Subject})
        Me.AccountResourceListView.Location = New System.Drawing.Point(41, 200)
        Me.AccountResourceListView.Name = "AccountResourceListView"
        Me.AccountResourceListView.Size = New System.Drawing.Size(590, 222)
        Me.AccountResourceListView.TabIndex = 2
        Me.AccountResourceListView.UseCompatibleStateImageBehavior = False
        Me.AccountResourceListView.View = System.Windows.Forms.View.Details
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 140
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 100
        '
        'PublicationDate
        '
        Me.PublicationDate.Text = "Publication Date"
        Me.PublicationDate.Width = 90
        '
        'Series
        '
        Me.Series.Text = "Series"
        Me.Series.Width = 70
        '
        'ISBN
        '
        Me.ISBN.Text = "ISBN"
        Me.ISBN.Width = 80
        '
        'Subject
        '
        Me.Subject.Text = "Subject"
        Me.Subject.Width = 86
        '
        'ReturnButton
        '
        Me.ReturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.ReturnButton.Location = New System.Drawing.Point(664, 200)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(90, 30)
        Me.ReturnButton.TabIndex = 3
        Me.ReturnButton.Text = "Return"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'RenewBotton
        '
        Me.RenewBotton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.RenewBotton.Location = New System.Drawing.Point(664, 250)
        Me.RenewBotton.Name = "RenewBotton"
        Me.RenewBotton.Size = New System.Drawing.Size(90, 30)
        Me.RenewBotton.TabIndex = 4
        Me.RenewBotton.Text = "Renew"
        Me.RenewBotton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.NameLabel.Location = New System.Drawing.Point(41, 77)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(48, 18)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'DNameLabel
        '
        Me.DNameLabel.AutoSize = True
        Me.DNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.DNameLabel.Location = New System.Drawing.Point(123, 77)
        Me.DNameLabel.Name = "DNameLabel"
        Me.DNameLabel.Size = New System.Drawing.Size(32, 18)
        Me.DNameLabel.TabIndex = 6
        Me.DNameLabel.Text = "abc"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.EmailLabel.Location = New System.Drawing.Point(40, 113)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(45, 18)
        Me.EmailLabel.TabIndex = 7
        Me.EmailLabel.Text = "Email"
        '
        'DEmailLabel
        '
        Me.DEmailLabel.AutoSize = True
        Me.DEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.DEmailLabel.Location = New System.Drawing.Point(123, 113)
        Me.DEmailLabel.Name = "DEmailLabel"
        Me.DEmailLabel.Size = New System.Drawing.Size(32, 18)
        Me.DEmailLabel.TabIndex = 8
        Me.DEmailLabel.Text = "bcd"
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LogoutButton.Location = New System.Drawing.Point(664, 392)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(90, 30)
        Me.LogoutButton.TabIndex = 10
        Me.LogoutButton.Text = "Logout "
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.DEmailLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.DNameLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.RenewBotton)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.AccountResourceListView)
        Me.Controls.Add(Me.ResourceLabel)
        Me.Controls.Add(Me.AccountLabel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Account"
        Me.Text = "Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccountLabel As Label
    Friend WithEvents ResourceLabel As Label
    Friend WithEvents AccountResourceListView As ListView
    Friend WithEvents ReturnButton As Button
    Friend WithEvents RenewBotton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents DNameLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents DEmailLabel As Label
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Author As ColumnHeader
    Friend WithEvents PublicationDate As ColumnHeader
    Friend WithEvents Series As ColumnHeader
    Friend WithEvents ISBN As ColumnHeader
    Friend WithEvents Subject As ColumnHeader
    Friend WithEvents LogoutButton As Button
End Class
