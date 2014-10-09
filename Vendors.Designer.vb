<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendors
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.VendorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.VNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebsiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New EventManager.Database1DataSet()
        Me.VNameLabel = New System.Windows.Forms.Label()
        Me.VNameTextBox = New System.Windows.Forms.TextBox()
        Me.VendorsTableAdapter = New EventManager.Database1DataSetTableAdapters.VendorsTableAdapter()
        Me.VTypeLabel = New System.Windows.Forms.Label()
        Me.VendorsSearchLabel = New System.Windows.Forms.Label()
        Me.VTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.ShowAllVendorsButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChosenVendorTextBox = New System.Windows.Forms.TextBox()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.VendorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VendorsDataGridView
        '
        Me.VendorsDataGridView.AllowUserToAddRows = False
        Me.VendorsDataGridView.AllowUserToDeleteRows = False
        Me.VendorsDataGridView.AllowUserToResizeColumns = False
        Me.VendorsDataGridView.AllowUserToResizeRows = False
        Me.VendorsDataGridView.AutoGenerateColumns = False
        Me.VendorsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.VendorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.VendorsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VendorsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VNameDataGridViewTextBoxColumn, Me.VTypeDataGridViewTextBoxColumn, Me.VContactDataGridViewTextBoxColumn, Me.VPhoneDataGridViewTextBoxColumn, Me.WebsiteDataGridViewTextBoxColumn})
        Me.VendorsDataGridView.DataSource = Me.VendorsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VendorsDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.VendorsDataGridView.EnableHeadersVisualStyles = False
        Me.VendorsDataGridView.GridColor = System.Drawing.SystemColors.ControlLight
        Me.VendorsDataGridView.Location = New System.Drawing.Point(12, 156)
        Me.VendorsDataGridView.Name = "VendorsDataGridView"
        Me.VendorsDataGridView.ReadOnly = True
        Me.VendorsDataGridView.RowHeadersVisible = False
        Me.VendorsDataGridView.Size = New System.Drawing.Size(645, 410)
        Me.VendorsDataGridView.TabIndex = 0
        '
        'VNameDataGridViewTextBoxColumn
        '
        Me.VNameDataGridViewTextBoxColumn.DataPropertyName = "VName"
        Me.VNameDataGridViewTextBoxColumn.HeaderText = "Vendor Name"
        Me.VNameDataGridViewTextBoxColumn.Name = "VNameDataGridViewTextBoxColumn"
        Me.VNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.VNameDataGridViewTextBoxColumn.Width = 150
        '
        'VTypeDataGridViewTextBoxColumn
        '
        Me.VTypeDataGridViewTextBoxColumn.DataPropertyName = "VType"
        Me.VTypeDataGridViewTextBoxColumn.HeaderText = "Vendor Type"
        Me.VTypeDataGridViewTextBoxColumn.Name = "VTypeDataGridViewTextBoxColumn"
        Me.VTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.VTypeDataGridViewTextBoxColumn.Width = 110
        '
        'VContactDataGridViewTextBoxColumn
        '
        Me.VContactDataGridViewTextBoxColumn.DataPropertyName = "VContact"
        Me.VContactDataGridViewTextBoxColumn.HeaderText = "Contact Person"
        Me.VContactDataGridViewTextBoxColumn.Name = "VContactDataGridViewTextBoxColumn"
        Me.VContactDataGridViewTextBoxColumn.ReadOnly = True
        Me.VContactDataGridViewTextBoxColumn.Width = 140
        '
        'VPhoneDataGridViewTextBoxColumn
        '
        Me.VPhoneDataGridViewTextBoxColumn.DataPropertyName = "VPhone"
        Me.VPhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.VPhoneDataGridViewTextBoxColumn.Name = "VPhoneDataGridViewTextBoxColumn"
        Me.VPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WebsiteDataGridViewTextBoxColumn
        '
        Me.WebsiteDataGridViewTextBoxColumn.DataPropertyName = "Website"
        Me.WebsiteDataGridViewTextBoxColumn.HeaderText = "Website"
        Me.WebsiteDataGridViewTextBoxColumn.Name = "WebsiteDataGridViewTextBoxColumn"
        Me.WebsiteDataGridViewTextBoxColumn.ReadOnly = True
        Me.WebsiteDataGridViewTextBoxColumn.Width = 141
        '
        'VendorsBindingSource
        '
        Me.VendorsBindingSource.DataMember = "Vendors"
        Me.VendorsBindingSource.DataSource = Me.Database1DataSetBindingSource
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VNameLabel
        '
        Me.VNameLabel.AutoSize = True
        Me.VNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VNameLabel.Location = New System.Drawing.Point(6, 45)
        Me.VNameLabel.Name = "VNameLabel"
        Me.VNameLabel.Size = New System.Drawing.Size(95, 16)
        Me.VNameLabel.TabIndex = 2
        Me.VNameLabel.Text = "Vendor Name:"
        '
        'VNameTextBox
        '
        Me.VNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VNameTextBox.Location = New System.Drawing.Point(102, 42)
        Me.VNameTextBox.Name = "VNameTextBox"
        Me.VNameTextBox.Size = New System.Drawing.Size(286, 22)
        Me.VNameTextBox.TabIndex = 3
        '
        'VendorsTableAdapter
        '
        Me.VendorsTableAdapter.ClearBeforeFill = True
        '
        'VTypeLabel
        '
        Me.VTypeLabel.AutoSize = True
        Me.VTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTypeLabel.Location = New System.Drawing.Point(6, 93)
        Me.VTypeLabel.Name = "VTypeLabel"
        Me.VTypeLabel.Size = New System.Drawing.Size(90, 16)
        Me.VTypeLabel.TabIndex = 5
        Me.VTypeLabel.Text = "Vendor Type:"
        '
        'VendorsSearchLabel
        '
        Me.VendorsSearchLabel.AutoSize = True
        Me.VendorsSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendorsSearchLabel.Location = New System.Drawing.Point(6, 16)
        Me.VendorsSearchLabel.Name = "VendorsSearchLabel"
        Me.VendorsSearchLabel.Size = New System.Drawing.Size(144, 16)
        Me.VendorsSearchLabel.TabIndex = 7
        Me.VendorsSearchLabel.Text = "Search Vendors by:"
        '
        'VTypeComboBox
        '
        Me.VTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTypeComboBox.FormattingEnabled = True
        Me.VTypeComboBox.Items.AddRange(New Object() {"Caterer", "Florist", "Bar", "A/V", "Installer", "Facility"})
        Me.VTypeComboBox.Location = New System.Drawing.Point(102, 91)
        Me.VTypeComboBox.Name = "VTypeComboBox"
        Me.VTypeComboBox.Size = New System.Drawing.Size(286, 24)
        Me.VTypeComboBox.TabIndex = 8
        '
        'ShowAllVendorsButton
        '
        Me.ShowAllVendorsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAllVendorsButton.Location = New System.Drawing.Point(420, 45)
        Me.ShowAllVendorsButton.Name = "ShowAllVendorsButton"
        Me.ShowAllVendorsButton.Size = New System.Drawing.Size(72, 49)
        Me.ShowAllVendorsButton.TabIndex = 9
        Me.ShowAllVendorsButton.Text = "Show All Vendors"
        Me.ShowAllVendorsButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.VendorsSearchLabel)
        Me.GroupBox1.Controls.Add(Me.VNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ShowAllVendorsButton)
        Me.GroupBox1.Controls.Add(Me.VTypeLabel)
        Me.GroupBox1.Controls.Add(Me.VNameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 126)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'ChosenVendorTextBox
        '
        Me.ChosenVendorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChosenVendorTextBox.Location = New System.Drawing.Point(102, 589)
        Me.ChosenVendorTextBox.Name = "ChosenVendorTextBox"
        Me.ChosenVendorTextBox.Size = New System.Drawing.Size(374, 22)
        Me.ChosenVendorTextBox.TabIndex = 15
        '
        'OpenButton
        '
        Me.OpenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenButton.Location = New System.Drawing.Point(494, 588)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 16
        Me.OpenButton.Text = "Open"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(582, 587)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Vendors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 633)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.ChosenVendorTextBox)
        Me.Controls.Add(Me.VendorsDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Vendors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendors"
        CType(Me.VendorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VendorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As EventManager.Database1DataSet
    Friend WithEvents VNameLabel As System.Windows.Forms.Label
    Friend WithEvents VNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VendorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VendorsTableAdapter As EventManager.Database1DataSetTableAdapters.VendorsTableAdapter
    Friend WithEvents VTypeLabel As System.Windows.Forms.Label
    Friend WithEvents VendorsSearchLabel As System.Windows.Forms.Label
    Friend WithEvents VTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ShowAllVendorsButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChosenVendorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents VNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WebsiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
