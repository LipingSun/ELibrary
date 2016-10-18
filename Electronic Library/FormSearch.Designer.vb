<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearch
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
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.Keyword1ComboBox = New System.Windows.Forms.ComboBox()
        Me.Like1ComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchResourceListView = New System.Windows.Forms.ListView()
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PublicationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Series = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Subject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckOutPeriod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Avaibility = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.AccountButton = New System.Windows.Forms.Button()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.UserInputTextBox1 = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(38, 31)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(81, 26)
        Me.SearchLabel.TabIndex = 1
        Me.SearchLabel.Text = "Search"
        '
        'Keyword1ComboBox
        '
        Me.Keyword1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Keyword1ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keyword1ComboBox.FormattingEnabled = True
        Me.Keyword1ComboBox.Items.AddRange(New Object() {"Title", "Author", "ISBN"})
        Me.Keyword1ComboBox.Location = New System.Drawing.Point(77, 91)
        Me.Keyword1ComboBox.Name = "Keyword1ComboBox"
        Me.Keyword1ComboBox.Size = New System.Drawing.Size(120, 26)
        Me.Keyword1ComboBox.TabIndex = 2
        '
        'Like1ComboBox
        '
        Me.Like1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Like1ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Like1ComboBox.FormattingEnabled = True
        Me.Like1ComboBox.Items.AddRange(New Object() {"=", "Like"})
        Me.Like1ComboBox.Location = New System.Drawing.Point(230, 91)
        Me.Like1ComboBox.Name = "Like1ComboBox"
        Me.Like1ComboBox.Size = New System.Drawing.Size(60, 26)
        Me.Like1ComboBox.TabIndex = 4
        '
        'SearchResourceListView
        '
        Me.SearchResourceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Title, Me.Author, Me.PublicationDate, Me.Series, Me.ISBN, Me.Subject, Me.CheckOutPeriod, Me.Avaibility})
        Me.SearchResourceListView.Location = New System.Drawing.Point(43, 208)
        Me.SearchResourceListView.Name = "SearchResourceListView"
        Me.SearchResourceListView.Size = New System.Drawing.Size(570, 214)
        Me.SearchResourceListView.TabIndex = 10
        Me.SearchResourceListView.UseCompatibleStateImageBehavior = False
        Me.SearchResourceListView.View = System.Windows.Forms.View.Details
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
        Me.Subject.Width = 66
        '
        'CheckOutPeriod
        '
        Me.CheckOutPeriod.Text = "CheckOutPeriod"
        '
        'Avaibility
        '
        Me.Avaibility.Text = "Avaibility"
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(182, 156)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(90, 31)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.Location = New System.Drawing.Point(655, 93)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(90, 31)
        Me.LogoutButton.TabIndex = 12
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'AccountButton
        '
        Me.AccountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountButton.Location = New System.Drawing.Point(655, 31)
        Me.AccountButton.Name = "AccountButton"
        Me.AccountButton.Size = New System.Drawing.Size(90, 31)
        Me.AccountButton.TabIndex = 13
        Me.AccountButton.Text = "Account"
        Me.AccountButton.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutButton.Location = New System.Drawing.Point(655, 367)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(90, 55)
        Me.CheckOutButton.TabIndex = 14
        Me.CheckOutButton.Text = "Check Out"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'UserInputTextBox1
        '
        Me.UserInputTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInputTextBox1.Location = New System.Drawing.Point(339, 91)
        Me.UserInputTextBox1.Name = "UserInputTextBox1"
        Me.UserInputTextBox1.Size = New System.Drawing.Size(132, 24)
        Me.UserInputTextBox1.TabIndex = 15
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(339, 156)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(90, 31)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FormSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.UserInputTextBox1)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Controls.Add(Me.AccountButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchResourceListView)
        Me.Controls.Add(Me.Like1ComboBox)
        Me.Controls.Add(Me.Keyword1ComboBox)
        Me.Controls.Add(Me.SearchLabel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FormSearch"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchLabel As Label
    Friend WithEvents Keyword1ComboBox As ComboBox
    Friend WithEvents Like1ComboBox As ComboBox
    Friend WithEvents SearchResourceListView As ListView
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Author As ColumnHeader
    Friend WithEvents PublicationDate As ColumnHeader
    Friend WithEvents Series As ColumnHeader
    Friend WithEvents ISBN As ColumnHeader
    Friend WithEvents Subject As ColumnHeader
    Friend WithEvents CheckOutPeriod As ColumnHeader
    Friend WithEvents Avaibility As ColumnHeader
    Friend WithEvents SearchButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents AccountButton As Button
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents UserInputTextBox1 As TextBox
    Friend WithEvents ClearButton As Button
End Class
