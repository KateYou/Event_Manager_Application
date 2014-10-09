<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorInfo
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
        Dim VTaxIDLabel As System.Windows.Forms.Label
        Dim VFaxLabel As System.Windows.Forms.Label
        Dim VInsuranceLabel As System.Windows.Forms.Label
        Dim AttachmentsLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New EventManager.Database1DataSet()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorsTableAdapter = New EventManager.Database1DataSetTableAdapters.VendorsTableAdapter()
        Me.TableAdapterManager = New EventManager.Database1DataSetTableAdapters.TableAdapterManager()
        Me.VNameTextBox = New System.Windows.Forms.TextBox()
        Me.VAddressTextBox = New System.Windows.Forms.TextBox()
        Me.VCityTextBox = New System.Windows.Forms.TextBox()
        Me.VStateTextBox = New System.Windows.Forms.TextBox()
        Me.VZipTextBox = New System.Windows.Forms.TextBox()
        Me.VContactTextBox = New System.Windows.Forms.TextBox()
        Me.VPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.VTaxIDTextBox = New System.Windows.Forms.TextBox()
        Me.VFaxTextBox = New System.Windows.Forms.TextBox()
        Me.VInsuranceTextBox = New System.Windows.Forms.TextBox()
        Me.AttachmentsComboBox = New System.Windows.Forms.ComboBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.VTypeTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        VNameLabel = New System.Windows.Forms.Label()
        VTypeLabel = New System.Windows.Forms.Label()
        VAddressLabel = New System.Windows.Forms.Label()
        VCityLabel = New System.Windows.Forms.Label()
        VStateLabel = New System.Windows.Forms.Label()
        VZipLabel = New System.Windows.Forms.Label()
        VContactLabel = New System.Windows.Forms.Label()
        VPhoneLabel = New System.Windows.Forms.Label()
        VTaxIDLabel = New System.Windows.Forms.Label()
        VFaxLabel = New System.Windows.Forms.Label()
        VInsuranceLabel = New System.Windows.Forms.Label()
        AttachmentsLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VNameLabel
        '
        VNameLabel.AutoSize = True
        VNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VNameLabel.Location = New System.Drawing.Point(10, 31)
        VNameLabel.Name = "VNameLabel"
        VNameLabel.Size = New System.Drawing.Size(48, 16)
        VNameLabel.TabIndex = 1
        VNameLabel.Text = "Name:"
        '
        'VTypeLabel
        '
        VTypeLabel.AutoSize = True
        VTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VTypeLabel.Location = New System.Drawing.Point(10, 66)
        VTypeLabel.Name = "VTypeLabel"
        VTypeLabel.Size = New System.Drawing.Size(90, 16)
        VTypeLabel.TabIndex = 3
        VTypeLabel.Text = "Vendor Type:"
        '
        'VAddressLabel
        '
        VAddressLabel.AutoSize = True
        VAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VAddressLabel.Location = New System.Drawing.Point(10, 101)
        VAddressLabel.Name = "VAddressLabel"
        VAddressLabel.Size = New System.Drawing.Size(62, 16)
        VAddressLabel.TabIndex = 5
        VAddressLabel.Text = "Address:"
        '
        'VCityLabel
        '
        VCityLabel.AutoSize = True
        VCityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VCityLabel.Location = New System.Drawing.Point(10, 136)
        VCityLabel.Name = "VCityLabel"
        VCityLabel.Size = New System.Drawing.Size(33, 16)
        VCityLabel.TabIndex = 6
        VCityLabel.Text = "City:"
        '
        'VStateLabel
        '
        VStateLabel.AutoSize = True
        VStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VStateLabel.Location = New System.Drawing.Point(10, 171)
        VStateLabel.Name = "VStateLabel"
        VStateLabel.Size = New System.Drawing.Size(42, 16)
        VStateLabel.TabIndex = 8
        VStateLabel.Text = "State:"
        '
        'VZipLabel
        '
        VZipLabel.AutoSize = True
        VZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VZipLabel.Location = New System.Drawing.Point(10, 206)
        VZipLabel.Name = "VZipLabel"
        VZipLabel.Size = New System.Drawing.Size(30, 16)
        VZipLabel.TabIndex = 10
        VZipLabel.Text = "Zip:"
        '
        'VContactLabel
        '
        VContactLabel.AutoSize = True
        VContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VContactLabel.Location = New System.Drawing.Point(369, 31)
        VContactLabel.Name = "VContactLabel"
        VContactLabel.Size = New System.Drawing.Size(102, 16)
        VContactLabel.TabIndex = 12
        VContactLabel.Text = "Contact Person:"
        '
        'VPhoneLabel
        '
        VPhoneLabel.AutoSize = True
        VPhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VPhoneLabel.Location = New System.Drawing.Point(369, 66)
        VPhoneLabel.Name = "VPhoneLabel"
        VPhoneLabel.Size = New System.Drawing.Size(50, 16)
        VPhoneLabel.TabIndex = 14
        VPhoneLabel.Text = "Phone:"
        '
        'VTaxIDLabel
        '
        VTaxIDLabel.AutoSize = True
        VTaxIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VTaxIDLabel.Location = New System.Drawing.Point(10, 241)
        VTaxIDLabel.Name = "VTaxIDLabel"
        VTaxIDLabel.Size = New System.Drawing.Size(50, 16)
        VTaxIDLabel.TabIndex = 16
        VTaxIDLabel.Text = "Tax ID:"
        '
        'VFaxLabel
        '
        VFaxLabel.AutoSize = True
        VFaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VFaxLabel.Location = New System.Drawing.Point(369, 101)
        VFaxLabel.Name = "VFaxLabel"
        VFaxLabel.Size = New System.Drawing.Size(33, 16)
        VFaxLabel.TabIndex = 18
        VFaxLabel.Text = "Fax:"
        '
        'VInsuranceLabel
        '
        VInsuranceLabel.AutoSize = True
        VInsuranceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VInsuranceLabel.Location = New System.Drawing.Point(369, 136)
        VInsuranceLabel.Name = "VInsuranceLabel"
        VInsuranceLabel.Size = New System.Drawing.Size(119, 16)
        VInsuranceLabel.TabIndex = 20
        VInsuranceLabel.Text = "Insurance on File?:"
        '
        'AttachmentsLabel
        '
        AttachmentsLabel.AutoSize = True
        AttachmentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AttachmentsLabel.Location = New System.Drawing.Point(368, 171)
        AttachmentsLabel.Name = "AttachmentsLabel"
        AttachmentsLabel.Size = New System.Drawing.Size(84, 16)
        AttachmentsLabel.TabIndex = 22
        AttachmentsLabel.Text = "Attachments:"
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WebsiteLabel.Location = New System.Drawing.Point(369, 206)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(61, 16)
        WebsiteLabel.TabIndex = 24
        WebsiteLabel.Text = "Website:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(10, 278)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(47, 16)
        NotesLabel.TabIndex = 26
        NotesLabel.Text = "Notes:"
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
        'VNameTextBox
        '
        Me.VNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VName", True))
        Me.VNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VNameTextBox.Location = New System.Drawing.Point(100, 28)
        Me.VNameTextBox.Name = "VNameTextBox"
        Me.VNameTextBox.Size = New System.Drawing.Size(233, 22)
        Me.VNameTextBox.TabIndex = 2
        '
        'VAddressTextBox
        '
        Me.VAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VAddress", True))
        Me.VAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VAddressTextBox.Location = New System.Drawing.Point(100, 98)
        Me.VAddressTextBox.Name = "VAddressTextBox"
        Me.VAddressTextBox.Size = New System.Drawing.Size(233, 22)
        Me.VAddressTextBox.TabIndex = 6
        '
        'VCityTextBox
        '
        Me.VCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VCity", True))
        Me.VCityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VCityTextBox.Location = New System.Drawing.Point(100, 133)
        Me.VCityTextBox.Name = "VCityTextBox"
        Me.VCityTextBox.Size = New System.Drawing.Size(233, 22)
        Me.VCityTextBox.TabIndex = 7
        '
        'VStateTextBox
        '
        Me.VStateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VState", True))
        Me.VStateTextBox.Location = New System.Drawing.Point(100, 170)
        Me.VStateTextBox.Name = "VStateTextBox"
        Me.VStateTextBox.Size = New System.Drawing.Size(47, 22)
        Me.VStateTextBox.TabIndex = 9
        '
        'VZipTextBox
        '
        Me.VZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VZip", True))
        Me.VZipTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VZipTextBox.Location = New System.Drawing.Point(100, 203)
        Me.VZipTextBox.Name = "VZipTextBox"
        Me.VZipTextBox.Size = New System.Drawing.Size(144, 22)
        Me.VZipTextBox.TabIndex = 11
        '
        'VContactTextBox
        '
        Me.VContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VContact", True))
        Me.VContactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VContactTextBox.Location = New System.Drawing.Point(500, 28)
        Me.VContactTextBox.Name = "VContactTextBox"
        Me.VContactTextBox.Size = New System.Drawing.Size(222, 22)
        Me.VContactTextBox.TabIndex = 13
        '
        'VPhoneTextBox
        '
        Me.VPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VPhone", True))
        Me.VPhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPhoneTextBox.Location = New System.Drawing.Point(500, 62)
        Me.VPhoneTextBox.Name = "VPhoneTextBox"
        Me.VPhoneTextBox.Size = New System.Drawing.Size(121, 22)
        Me.VPhoneTextBox.TabIndex = 15
        '
        'VTaxIDTextBox
        '
        Me.VTaxIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VTaxID", True))
        Me.VTaxIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTaxIDTextBox.Location = New System.Drawing.Point(100, 238)
        Me.VTaxIDTextBox.Name = "VTaxIDTextBox"
        Me.VTaxIDTextBox.Size = New System.Drawing.Size(144, 22)
        Me.VTaxIDTextBox.TabIndex = 17
        '
        'VFaxTextBox
        '
        Me.VFaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VFax", True))
        Me.VFaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VFaxTextBox.Location = New System.Drawing.Point(500, 96)
        Me.VFaxTextBox.Name = "VFaxTextBox"
        Me.VFaxTextBox.Size = New System.Drawing.Size(121, 22)
        Me.VFaxTextBox.TabIndex = 19
        '
        'VInsuranceTextBox
        '
        Me.VInsuranceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VInsurance", True))
        Me.VInsuranceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VInsuranceTextBox.Location = New System.Drawing.Point(500, 130)
        Me.VInsuranceTextBox.Name = "VInsuranceTextBox"
        Me.VInsuranceTextBox.Size = New System.Drawing.Size(121, 22)
        Me.VInsuranceTextBox.TabIndex = 21
        '
        'AttachmentsComboBox
        '
        Me.AttachmentsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Attachments", True))
        Me.AttachmentsComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttachmentsComboBox.FormattingEnabled = True
        Me.AttachmentsComboBox.Location = New System.Drawing.Point(500, 164)
        Me.AttachmentsComboBox.Name = "AttachmentsComboBox"
        Me.AttachmentsComboBox.Size = New System.Drawing.Size(222, 24)
        Me.AttachmentsComboBox.TabIndex = 23
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Website", True))
        Me.WebsiteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(500, 200)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(222, 22)
        Me.WebsiteTextBox.TabIndex = 25
        '
        'VTypeTextBox
        '
        Me.VTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTypeTextBox.Location = New System.Drawing.Point(100, 63)
        Me.VTypeTextBox.Name = "VTypeTextBox"
        Me.VTypeTextBox.Size = New System.Drawing.Size(233, 22)
        Me.VTypeTextBox.TabIndex = 26
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(100, 275)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(622, 68)
        Me.NotesTextBox.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NotesLabel)
        Me.GroupBox1.Controls.Add(Me.NotesTextBox)
        Me.GroupBox1.Controls.Add(Me.VTypeTextBox)
        Me.GroupBox1.Controls.Add(WebsiteLabel)
        Me.GroupBox1.Controls.Add(Me.WebsiteTextBox)
        Me.GroupBox1.Controls.Add(AttachmentsLabel)
        Me.GroupBox1.Controls.Add(Me.AttachmentsComboBox)
        Me.GroupBox1.Controls.Add(VInsuranceLabel)
        Me.GroupBox1.Controls.Add(Me.VInsuranceTextBox)
        Me.GroupBox1.Controls.Add(VFaxLabel)
        Me.GroupBox1.Controls.Add(Me.VFaxTextBox)
        Me.GroupBox1.Controls.Add(VTaxIDLabel)
        Me.GroupBox1.Controls.Add(Me.VTaxIDTextBox)
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
        Me.GroupBox1.Controls.Add(VNameLabel)
        Me.GroupBox1.Controls.Add(Me.VNameTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 357)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vendor Information"
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(659, 389)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 29
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'VendorInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 424)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VendorInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendor Information"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database1DataSet As EventManager.Database1DataSet
    Friend WithEvents VendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendorsTableAdapter As EventManager.Database1DataSetTableAdapters.VendorsTableAdapter
    Friend WithEvents TableAdapterManager As EventManager.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VTaxIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VFaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VInsuranceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AttachmentsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
