﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lvwCustomers = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(13, 506)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(440, 74)
        Me.lblResult.TabIndex = 20
        '
        'lvwCustomers
        '
        Me.lvwCustomers.CheckBoxes = True
        Me.lvwCustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCustomers.FullRowSelect = True
        Me.lvwCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCustomers.Location = New System.Drawing.Point(13, 200)
        Me.lvwCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwCustomers.MultiSelect = False
        Me.lvwCustomers.Name = "lvwCustomers"
        Me.lvwCustomers.Size = New System.Drawing.Size(439, 302)
        Me.lvwCustomers.TabIndex = 19
        Me.lvwCustomers.UseCompatibleStateImageBehavior = False
        Me.lvwCustomers.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(78, 146)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(61, 30)
        Me.chkNew.TabIndex = 5
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.chkNew, "check if the car is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(26, 85)
        Me.lbLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(88, 16)
        Me.lbLastName.TabIndex = 16
        Me.lbLastName.Text = "&Year:"
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(26, 49)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 16)
        Me.lblFirstName.TabIndex = 14
        Me.lblFirstName.Text = "M&odel: "
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
        Me.lbTitle.Text = "&Make: "
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Honda", "Hyundai", "Volkswagon"})
        Me.cmbMake.Location = New System.Drawing.Point(122, 16)
        Me.cmbMake.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(160, 24)
        Me.cmbMake.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.cmbMake, "list of car makes")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(122, 49)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(160, 22)
        Me.txtModel.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(353, 586)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.btnExit, "exit application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(245, 586)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.ToolTip.SetToolTip(Me.btnReset, "resets the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(137, 586)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip.SetToolTip(Me.btnEnter, "press to enter data")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(122, 82)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(160, 24)
        Me.cmbYear.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.cmbYear, "list of years")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "&Price: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.UseWaitCursor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(122, 116)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(160, 22)
        Me.txtPrice.TabIndex = 4
        '
        'FrmMain
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(503, 648)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwCustomers)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.txtModel)
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

    Friend WithEvents lblResult As Label
    Friend WithEvents lvwCustomers As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lbLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbTitle As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents ToolTip As ToolTip
End Class
