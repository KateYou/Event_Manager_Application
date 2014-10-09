<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVendor
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
        Dim VNameLabel As System.Windows.Forms.Label
        Dim VTypeLabel As System.Windows.Forms.Label
        Dim VAddressLabel As System.Windows.Forms.Label
        Dim VCityLabel As System.Windows.Forms.Label
        Dim VStateLabel As System.Windows.Forms.Label
        Dim VZipLabel As System.Windows.Forms.Label
        Dim VContactLabel As System.Windows.Forms.Label
        Dim VPhoneLabel As System.Windows.Forms.Label
        Dim VFaxLabel As System.Windows.Forms.Label
        Dim VTaxIDLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim AttachmentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVendor))
        Me.Database1DataSet = New EventManager.Database1DataSet()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorsTableAdapter = New EventManager.Database1DataSetTableAdapters.VendorsTableAdapter()
        Me.TableAdapterManager = New EventManager.Database1DataSetTableAdapters.TableAdapterManager()
        Me.VendorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.VendorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VNameTextBox = New System.Windows.Forms.TextBox()
        Me.VTypeTextBox = New System.Windows.Forms.TextBox()
        Me.VAddressTextBox = New System.Windows.Forms.TextBox()
        Me.VCityTextBox = New System.Windows.Forms.TextBox()
        Me.VStateTextBox = New System.Windows.Forms.TextBox()
        Me.VZipTextBox = New System.Windows.Forms.TextBox()
        Me.VContactTextBox = New System.Windows.Forms.TextBox()
        Me.VPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.VFaxTextBox = New System.Windows.Forms.TextBox()
        Me.VTaxIDTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.AttachmentsListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        VNameLabel = New System.Windows.Forms.Label()
        VTypeLabel = New System.Windows.Forms.Label()
        VAddressLabel = New System.Windows.Forms.Label()
        VCityLabel = New System.Windows.Forms.Label()
        VStateLabel = New System.Windows.Forms.Label()
        VZipLabel = New System.Windows.Forms.Label()
        VContactLabel = New System.Windows.Forms.Label()
        VPhoneLabel = New System.Windows.Forms.Label()
        VFaxLabel = New System.Windows.Forms.Label()
        VTaxIDLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        AttachmentsLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendorsBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VNameLabel
        '
        VNameLabel.AutoSize = True
        VNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VNameLabel.Location = New System.Drawing.Point(12, 28)
        VNameLabel.Name = "VNameLabel"
        VNameLabel.Size = New System.Drawing.Size(95, 16)
        VNameLabel.TabIndex = 1
        VNameLabel.Text = "Vendor Name:"
        '
        'VTypeLabel
        '
        VTypeLabel.AutoSize = True
        VTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VTypeLabel.Location = New System.Drawing.Point(12, 68)
        VTypeLabel.Name = "VTypeLabel"
        VTypeLabel.Size = New System.Drawing.Size(90, 16)
        VTypeLabel.TabIndex = 3
        VTypeLabel.Text = "Vendor Type:"
        '
        'VAddressLabel
        '
        VAddressLabel.AutoSize = True
        VAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VAddressLabel.Location = New System.Drawing.Point(12, 108)
        VAddressLabel.Name = "VAddressLabel"
        VAddressLabel.Size = New System.Drawing.Size(109, 16)
        VAddressLabel.TabIndex = 5
        VAddressLabel.Text = "Vendor Address:"
        '
        'VCityLabel
        '
        VCityLabel.AutoSize = True
        VCityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VCityLabel.Location = New System.Drawing.Point(12, 150)
        VCityLabel.Name = "VCityLabel"
        VCityLabel.Size = New System.Drawing.Size(33, 16)
        VCityLabel.TabIndex = 7
        VCityLabel.Text = "City:"
        '
        'VStateLabel
        '
        VStateLabel.AutoSize = True
        VStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VStateLabel.Location = New System.Drawing.Point(12, 188)
        VStateLabel.Name = "VStateLabel"
        VStateLabel.Size = New System.Drawing.Size(42, 16)
        VStateLabel.TabIndex = 9
        VStateLabel.Text = "State:"
        '
        'VZipLabel
        '
        VZipLabel.AutoSize = True
        VZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VZipLabel.Location = New System.Drawing.Point(12, 230)
        VZipLabel.Name = "VZipLabel"
        VZipLabel.Size = New System.Drawing.Size(30, 16)
        VZipLabel.TabIndex = 11
        VZipLabel.Text = "Zip:"
        '
        'VContactLabel
        '
        VContactLabel.AutoSize = True
        VContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VContactLabel.Location = New System.Drawing.Point(12, 268)
        VContactLabel.Name = "VContactLabel"
        VContactLabel.Size = New System.Drawing.Size(102, 16)
        VContactLabel.TabIndex = 13
        VContactLabel.Text = "Contact Person:"
        '
        'VPhoneLabel
        '
        VPhoneLabel.AutoSize = True
        VPhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VPhoneLabel.Location = New System.Drawing.Point(455, 27)
        VPhoneLabel.Name = "VPhoneLabel"
        VPhoneLabel.Size = New System.Drawing.Size(50, 16)
        VPhoneLabel.TabIndex = 15
        VPhoneLabel.Text = "Phone:"
        '
        'VFaxLabel
        '
        VFaxLabel.AutoSize = True
        VFaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VFaxLabel.Location = New System.Drawing.Point(455, 70)
        VFaxLabel.Name = "VFaxLabel"
        VFaxLabel.Size = New System.Drawing.Size(33, 16)
        VFaxLabel.TabIndex = 17
        VFaxLabel.Text = "Fax:"
        '
        'VTaxIDLabel
        '
        VTaxIDLabel.AutoSize = True
        VTaxIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VTaxIDLabel.Location = New System.Drawing.Point(455, 113)
        VTaxIDLabel.Name = "VTaxIDLabel"
        VTaxIDLabel.Size = New System.Drawing.Size(50, 16)
        VTaxIDLabel.TabIndex = 19
        VTaxIDLabel.Text = "Tax ID:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(455, 156)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(47, 16)
        NotesLabel.TabIndex = 21
        NotesLabel.Text = "Notes:"
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WebsiteLabel.Location = New System.Drawing.Point(455, 380)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(61, 16)
        WebsiteLabel.TabIndex = 23
        WebsiteLabel.Text = "Website:"
        '
        'AttachmentsLabel
        '
        AttachmentsLabel.AutoSize = True
        AttachmentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AttachmentsLabel.Location = New System.Drawing.Point(455, 199)
        AttachmentsLabel.Name = "AttachmentsLabel"
        AttachmentsLabel.Size = New System.Drawing.Size(84, 16)
        AttachmentsLabel.TabIndex = 25
        AttachmentsLabel.Text = "Attachments:"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorsBindingSource
        '
        Me.VendorsBindingSource.DataMember = "Vendors"
        Me.VendorsBindingSource.DataSource = Me.Database1DataSet
        '
        'VendorsTableAdapter
        '
        Me.VendorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EMEventsTableAdapter = Nothing
        Me.TableAdapterManager.FacilitiesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EventManager.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Me.VendorsTableAdapter
        '
        'VendorsBindingNavigator
        '
        Me.VendorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VendorsBindingNavigator.BackColor = System.Drawing.SystemColors.Control
        Me.VendorsBindingNavigator.BindingSource = Me.VendorsBindingSource
        Me.VendorsBindingNavigator.CountItem = Nothing
        Me.VendorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VendorsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VendorsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.VendorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VendorsBindingNavigatorSaveItem})
        Me.VendorsBindingNavigator.Location = New System.Drawing.Point(0, 437)
        Me.VendorsBindingNavigator.MoveFirstItem = Nothing
        Me.VendorsBindingNavigator.MoveLastItem = Nothing
        Me.VendorsBindingNavigator.MoveNextItem = Nothing
        Me.VendorsBindingNavigator.MovePreviousItem = Nothing
        Me.VendorsBindingNavigator.Name = "VendorsBindingNavigator"
        Me.VendorsBindingNavigator.PositionItem = Nothing
        Me.VendorsBindingNavigator.Size = New System.Drawing.Size(803, 48)
        Me.VendorsBindingNavigator.TabIndex = 0
        Me.VendorsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Margin = New System.Windows.Forms.Padding(0, 1, 25, 25)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Margin = New System.Windows.Forms.Padding(0, 1, 20, 25)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'VendorsBindingNavigatorSaveItem
        '
        Me.VendorsBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.VendorsBindingNavigatorSaveItem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.VendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.VendorsBindingNavigatorSaveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendorsBindingNavigatorSaveItem.Image = CType(resources.GetObject("VendorsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VendorsBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.VendorsBindingNavigatorSaveItem.Margin = New System.Windows.Forms.Padding(0, 1, 25, 25)
        Me.VendorsBindingNavigatorSaveItem.Name = "VendorsBindingNavigatorSaveItem"
        Me.VendorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(89, 22)
        Me.VendorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VNameTextBox
        '
        Me.VNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VName", True))
        Me.VNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VNameTextBox.Location = New System.Drawing.Point(137, 25)
        Me.VNameTextBox.Name = "VNameTextBox"
        Me.VNameTextBox.Size = New System.Drawing.Size(282, 22)
        Me.VNameTextBox.TabIndex = 2
        '
        'VTypeTextBox
        '
        Me.VTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VType", True))
        Me.VTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTypeTextBox.Location = New System.Drawing.Point(137, 65)
        Me.VTypeTextBox.Name = "VTypeTextBox"
        Me.VTypeTextBox.Size = New System.Drawing.Size(282, 22)
        Me.VTypeTextBox.TabIndex = 4
        '
        'VAddressTextBox
        '
        Me.VAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VAddress", True))
        Me.VAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VAddressTextBox.Location = New System.Drawing.Point(137, 105)
        Me.VAddressTextBox.Name = "VAddressTextBox"
        Me.VAddressTextBox.Size = New System.Drawing.Size(282, 22)
        Me.VAddressTextBox.TabIndex = 6
        '
        'VCityTextBox
        '
        Me.VCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VCity", True))
        Me.VCityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VCityTextBox.Location = New System.Drawing.Point(137, 145)
        Me.VCityTextBox.Name = "VCityTextBox"
        Me.VCityTextBox.Size = New System.Drawing.Size(282, 22)
        Me.VCityTextBox.TabIndex = 8
        '
        'VStateTextBox
        '
        Me.VStateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VState", True))
        Me.VStateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VStateTextBox.Location = New System.Drawing.Point(137, 185)
        Me.VStateTextBox.Name = "VStateTextBox"
        Me.VStateTextBox.Size = New System.Drawing.Size(282, 22)
        Me.VStateTextBox.TabIndex = 10
        '
        'VZipTextBox
        '
        Me.VZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VZip", True))
        Me.VZipTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VZipTextBox.Location = New System.Drawing.Point(137, 225)
        Me.VZipTextBox.Name = "VZipTextBox"
        Me.VZipTextBox.Size = New System.Drawing.Size(282, 22)
        Me.VZipTextBox.TabIndex = 12
        '
        'VContactTextBox
        '
        Me.VContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VContact", True))
        Me.VContactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VContactTextBox.Location = New System.Drawing.Point(137, 265)
        Me.VContactTextBox.Name = "VContactTextBox"
        Me.VContactTextBox.Size = New System.Drawing.Size(282, 22)
        Me.VContactTextBox.TabIndex = 14
        '
        'VPhoneTextBox
        '
        Me.VPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VPhone", True))
        Me.VPhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPhoneTextBox.Location = New System.Drawing.Point(521, 22)
        Me.VPhoneTextBox.Name = "VPhoneTextBox"
        Me.VPhoneTextBox.Size = New System.Drawing.Size(226, 22)
        Me.VPhoneTextBox.TabIndex = 16
        '
        'VFaxTextBox
        '
        Me.VFaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VFax", True))
        Me.VFaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFaxTextBox.Location = New System.Drawing.Point(521, 66)
        Me.VFaxTextBox.Name = "VFaxTextBox"
        Me.VFaxTextBox.Size = New System.Drawing.Size(226, 22)
        Me.VFaxTextBox.TabIndex = 18
        '
        'VTaxIDTextBox
        '
        Me.VTaxIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VTaxID", True))
        Me.VTaxIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTaxIDTextBox.Location = New System.Drawing.Point(521, 110)
        Me.VTaxIDTextBox.Name = "VTaxIDTextBox"
        Me.VTaxIDTextBox.Size = New System.Drawing.Size(226, 22)
        Me.VTaxIDTextBox.TabIndex = 20
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(521, 154)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(226, 22)
        Me.NotesTextBox.TabIndex = 22
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Website", True))
        Me.WebsiteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(522, 375)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(225, 22)
        Me.WebsiteTextBox.TabIndex = 24
        '
        'AttachmentsListBox
        '
        Me.AttachmentsListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendorsBindingSource, "Attachments", True))
        Me.AttachmentsListBox.FormattingEnabled = True
        Me.AttachmentsListBox.Location = New System.Drawing.Point(545, 199)
        Me.AttachmentsListBox.Name = "AttachmentsListBox"
        Me.AttachmentsListBox.Size = New System.Drawing.Size(202, 160)
        Me.AttachmentsListBox.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AttachmentsListBox)
        Me.GroupBox1.Controls.Add(AttachmentsLabel)
        Me.GroupBox1.Controls.Add(WebsiteLabel)
        Me.GroupBox1.Controls.Add(Me.WebsiteTextBox)
        Me.GroupBox1.Controls.Add(NotesLabel)
        Me.GroupBox1.Controls.Add(Me.NotesTextBox)
        Me.GroupBox1.Controls.Add(VTaxIDLabel)
        Me.GroupBox1.Controls.Add(Me.VTaxIDTextBox)
        Me.GroupBox1.Controls.Add(VFaxLabel)
        Me.GroupBox1.Controls.Add(Me.VFaxTextBox)
        Me.GroupBox1.Controls.Add(VPhoneLabel)
        Me.GroupBox1.Controls.Add(Me.VPhoneTextBox)
        Me.GroupBox1.Controls.Add(VContactLabel)
        Me.GroupBox1.Controls.Add(Me.VContactTextBox)
        Me.GroupBox1.Controls.Add(VZipLabel)
        Me.GroupBox1.Controls.Add(Me.VZipTextBox)
        Me.GroupBox1.Controls.Add(VStateLabel)
        Me.GroupBox1.Controls.Add(Me.VStateTextBox)
        Me.GroupBox1.Controls.Add(VCityLabel)
        Me.GroupBox1.Controls.Add(Me.VCityTextBox)
        Me.GroupBox1.Controls.Add(VAddressLabel)
        Me.GroupBox1.Controls.Add(Me.VAddressTextBox)
        Me.GroupBox1.Controls.Add(VTypeLabel)
        Me.GroupBox1.Controls.Add(Me.VTypeTextBox)
        Me.GroupBox1.Controls.Add(VNameLabel)
        Me.GroupBox1.Controls.Add(Me.VNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 408)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'AddVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VendorsBindingNavigator)
        Me.Name = "AddVendor"
        Me.Text = "Add Vendor"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendorsBindingNavigator.ResumeLayout(False)
        Me.VendorsBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As EventManager.Database1DataSet
    Friend WithEvents VendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendorsTableAdapter As EventManager.Database1DataSetTableAdapters.VendorsTableAdapter
    Friend WithEvents TableAdapterManager As EventManager.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendorsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VendorsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VFaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VTaxIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AttachmentsListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
