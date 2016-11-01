<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.KeywordComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchResourceListView = New System.Windows.Forms.ListView()
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.PublicationDate = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Series = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ISBN = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Subject = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.CheckOutPeriod = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Availability = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.AccountButton = New System.Windows.Forms.Button()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.KeywordTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = true
        Me.SearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(38, 31)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(81, 26)
        Me.SearchLabel.TabIndex = 1
        Me.SearchLabel.Text = "Search"
        '
        'KeywordComboBox
        '
        Me.KeywordComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KeywordComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.KeywordComboBox.FormattingEnabled = true
        Me.KeywordComboBox.Items.AddRange(New Object() {"Title", "AuthorFirst", "AuthorLast", "ISBN"})
        Me.KeywordComboBox.Location = New System.Drawing.Point(43, 91)
        Me.KeywordComboBox.Name = "KeywordComboBox"
        Me.KeywordComboBox.Size = New System.Drawing.Size(98, 26)
        Me.KeywordComboBox.TabIndex = 2
        '
        'SearchResourceListView
        '
        Me.SearchResourceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Title, Me.Author, Me.PublicationDate, Me.Series, Me.ISBN, Me.Subject, Me.CheckOutPeriod, Me.Availability})
        Me.SearchResourceListView.FullRowSelect = true
        Me.SearchResourceListView.Location = New System.Drawing.Point(43, 200)
        Me.SearchResourceListView.MultiSelect = false
        Me.SearchResourceListView.Name = "SearchResourceListView"
        Me.SearchResourceListView.Size = New System.Drawing.Size(593, 222)
        Me.SearchResourceListView.TabIndex = 10
        Me.SearchResourceListView.UseCompatibleStateImageBehavior = false
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
        'Availability
        '
        Me.Availability.Text = "Avaibility"
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.SearchButton.Location = New System.Drawing.Point(546, 87)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(90, 30)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = true
        '
        'LogoutButton
        '
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.LogoutButton.Location = New System.Drawing.Point(655, 392)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(90, 30)
        Me.LogoutButton.TabIndex = 12
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = true
        '
        'AccountButton
        '
        Me.AccountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.AccountButton.Location = New System.Drawing.Point(655, 356)
        Me.AccountButton.Name = "AccountButton"
        Me.AccountButton.Size = New System.Drawing.Size(90, 30)
        Me.AccountButton.TabIndex = 13
        Me.AccountButton.Text = "Account"
        Me.AccountButton.UseVisualStyleBackColor = true
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.CheckOutButton.Location = New System.Drawing.Point(655, 198)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(90, 30)
        Me.CheckOutButton.TabIndex = 14
        Me.CheckOutButton.Text = "Check Out"
        Me.CheckOutButton.UseVisualStyleBackColor = true
        '
        'KeywordTextBox
        '
        Me.KeywordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.KeywordTextBox.Location = New System.Drawing.Point(166, 91)
        Me.KeywordTextBox.Name = "KeywordTextBox"
        Me.KeywordTextBox.Size = New System.Drawing.Size(358, 24)
        Me.KeywordTextBox.TabIndex = 15
        Me.KeywordTextBox.Text = "Unbroken: A World War II Story of Survival, Resilience, and Redemption"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.ClearButton.Location = New System.Drawing.Point(655, 88)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(90, 30)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = true
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = true
        Me.ResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ResultLabel.Location = New System.Drawing.Point(38, 160)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(74, 26)
        Me.ResultLabel.TabIndex = 17
        Me.ResultLabel.Text = "Result"
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.KeywordTextBox)
        Me.Controls.Add(Me.CheckOutButton)
        Me.Controls.Add(Me.AccountButton)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchResourceListView)
        Me.Controls.Add(Me.KeywordComboBox)
        Me.Controls.Add(Me.SearchLabel)
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "SearchForm"
        Me.Text = "Search"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents SearchLabel As Label
    Friend WithEvents KeywordComboBox As ComboBox
    Friend WithEvents SearchResourceListView As ListView
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Author As ColumnHeader
    Friend WithEvents PublicationDate As ColumnHeader
    Friend WithEvents Series As ColumnHeader
    Friend WithEvents ISBN As ColumnHeader
    Friend WithEvents Subject As ColumnHeader
    Friend WithEvents CheckOutPeriod As ColumnHeader
    Friend WithEvents Availability As ColumnHeader
    Friend WithEvents SearchButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents AccountButton As Button
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents KeywordTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents ResultLabel As Label
End Class
