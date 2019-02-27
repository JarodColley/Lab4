<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lvwCustomers = New System.Windows.Forms.ListView()
        Me.colVIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkVIP = New System.Windows.Forms.CheckBox()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.cmbTitles = New System.Windows.Forms.ComboBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(13, 446)
        Me.lbResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(440, 74)
        Me.lbResult.TabIndex = 20
        '
        'lvwCustomers
        '
        Me.lvwCustomers.CheckBoxes = True
        Me.lvwCustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colVIP, Me.colID, Me.colTitle, Me.colFirstName, Me.colLastName})
        Me.lvwCustomers.FullRowSelect = True
        Me.lvwCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCustomers.Location = New System.Drawing.Point(13, 140)
        Me.lvwCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwCustomers.MultiSelect = False
        Me.lvwCustomers.Name = "lvwCustomers"
        Me.lvwCustomers.Size = New System.Drawing.Size(439, 302)
        Me.lvwCustomers.TabIndex = 19
        Me.lvwCustomers.UseCompatibleStateImageBehavior = False
        Me.lvwCustomers.View = System.Windows.Forms.View.Details
        '
        'colVIP
        '
        Me.colVIP.Text = "VIP"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colTitle
        '
        Me.colTitle.Text = "Title"
        '
        'colFirstName
        '
        Me.colFirstName.Text = "FirstName"
        '
        'colLastName
        '
        Me.colLastName.Text = "Last Name"
        '
        'chkVIP
        '
        Me.chkVIP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVIP.Location = New System.Drawing.Point(78, 109)
        Me.chkVIP.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVIP.Name = "chkVIP"
        Me.chkVIP.Size = New System.Drawing.Size(61, 30)
        Me.chkVIP.TabIndex = 18
        Me.chkVIP.Text = "&VIP:"
        Me.chkVIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVIP.UseVisualStyleBackColor = True
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(26, 85)
        Me.lbLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(88, 16)
        Me.lbLastName.TabIndex = 16
        Me.lbLastName.Text = "&Last Name: "
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(26, 49)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 16)
        Me.lblFirstName.TabIndex = 14
        Me.lblFirstName.Text = "&First Name: "
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstName.UseWaitCursor = True
        '
        'lbTitle
        '
        Me.lbTitle.Location = New System.Drawing.Point(23, 19)
        Me.lbTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(88, 16)
        Me.lbTitle.TabIndex = 12
        Me.lbTitle.Text = "&Title: "
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTitles
        '
        Me.cmbTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitles.FormattingEnabled = True
        Me.cmbTitles.Items.AddRange(New Object() {"Mr.", "Mrs.", "Miss.", "Ms.", "Mstr.", "Dr."})
        Me.cmbTitles.Location = New System.Drawing.Point(122, 16)
        Me.cmbTitles.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTitles.Name = "cmbTitles"
        Me.cmbTitles.Size = New System.Drawing.Size(160, 24)
        Me.cmbTitles.TabIndex = 13
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(122, 81)
        Me.tbLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(160, 22)
        Me.tbLastName.TabIndex = 17
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(122, 49)
        Me.tbFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(160, 22)
        Me.tbFirstName.TabIndex = 15
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(353, 526)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(245, 526)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(137, 526)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 21
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 593)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCustomers)
        Me.Controls.Add(Me.chkVIP)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.cmbTitles)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbResult As Label
    Friend WithEvents lvwCustomers As ListView
    Friend WithEvents colVIP As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colTitle As ColumnHeader
    Friend WithEvents colFirstName As ColumnHeader
    Friend WithEvents colLastName As ColumnHeader
    Friend WithEvents chkVIP As CheckBox
    Friend WithEvents lbLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbTitle As Label
    Friend WithEvents cmbTitles As ComboBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
End Class
