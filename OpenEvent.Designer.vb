<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenEvent
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
        Me.EventsDataGridView = New System.Windows.Forms.DataGridView()
        Me.EventNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMEventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New EventManager.Database1DataSet()
        Me.SearchNameTextBox = New System.Windows.Forms.TextBox()
        Me.EventNameLabel = New System.Windows.Forms.Label()
        Me.EmEventsTableAdapter1 = New EventManager.Database1DataSetTableAdapters.EMEventsTableAdapter()
        Me.TableAdapterManager = New EventManager.Database1DataSetTableAdapters.TableAdapterManager()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ChosenEventNameTextBox = New System.Windows.Forms.TextBox()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.EventLocationLabel = New System.Windows.Forms.Label()
        Me.EventDateLabel = New System.Windows.Forms.Label()
        Me.SearchLocationTextBox = New System.Windows.Forms.TextBox()
        Me.ShowAllEventsButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SelectEventLabel = New System.Windows.Forms.Label()
        CType(Me.EventsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMEventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventsDataGridView
        '
        Me.EventsDataGridView.AllowUserToAddRows = False
        Me.EventsDataGridView.AllowUserToDeleteRows = False
        Me.EventsDataGridView.AllowUserToResizeColumns = False
        Me.EventsDataGridView.AllowUserToResizeRows = False
        Me.EventsDataGridView.AutoGenerateColumns = False
        Me.EventsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.EventsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EventsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.EventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventNameDataGridViewTextBoxColumn, Me.EventLocationDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn})
        Me.EventsDataGridView.DataSource = Me.EMEventsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EventsDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.EventsDataGridView.EnableHeadersVisualStyles = False
        Me.EventsDataGridView.GridColor = System.Drawing.SystemColors.ControlLight
        Me.EventsDataGridView.Location = New System.Drawing.Point(22, 257)
        Me.EventsDataGridView.Name = "EventsDataGridView"
        Me.EventsDataGridView.ReadOnly = True
        Me.EventsDataGridView.RowHeadersVisible = False
        Me.EventsDataGridView.Size = New System.Drawing.Size(552, 320)
        Me.EventsDataGridView.TabIndex = 1
        '
        'EventNameDataGridViewTextBoxColumn
        '
        Me.EventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName"
        Me.EventNameDataGridViewTextBoxColumn.HeaderText = "EventName"
        Me.EventNameDataGridViewTextBoxColumn.Name = "EventNameDataGridViewTextBoxColumn"
        Me.EventNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EventNameDataGridViewTextBoxColumn.Width = 200
        '
        'EventLocationDataGridViewTextBoxColumn
        '
        Me.EventLocationDataGridViewTextBoxColumn.DataPropertyName = "EventLocation"
        Me.EventLocationDataGridViewTextBoxColumn.HeaderText = "EventLocation"
        Me.EventLocationDataGridViewTextBoxColumn.Name = "EventLocationDataGridViewTextBoxColumn"
        Me.EventLocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.EventLocationDataGridViewTextBoxColumn.Width = 147
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "StartDate"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        Me.StartTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMEventsBindingSource
        '
        Me.EMEventsBindingSource.DataMember = "EMEvents"
        Me.EMEventsBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchNameTextBox
        '
        Me.SearchNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchNameTextBox.Location = New System.Drawing.Point(6, 38)
        Me.SearchNameTextBox.Name = "SearchNameTextBox"
        Me.SearchNameTextBox.Size = New System.Drawing.Size(262, 22)
        Me.SearchNameTextBox.TabIndex = 2
        '
        'EventNameLabel
        '
        Me.EventNameLabel.AutoSize = True
        Me.EventNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventNameLabel.Location = New System.Drawing.Point(6, 16)
        Me.EventNameLabel.Name = "EventNameLabel"
        Me.EventNameLabel.Size = New System.Drawing.Size(149, 16)
        Me.EventNameLabel.TabIndex = 3
        Me.EventNameLabel.Text = "Search Event Name:"
        '
        'EmEventsTableAdapter1
        '
        Me.EmEventsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EMEventsTableAdapter = Me.EmEventsTableAdapter1
        Me.TableAdapterManager.FacilitiesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EventManager.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ChosenEventNameTextBox
        '
        Me.ChosenEventNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChosenEventNameTextBox.Location = New System.Drawing.Point(22, 594)
        Me.ChosenEventNameTextBox.Name = "ChosenEventNameTextBox"
        Me.ChosenEventNameTextBox.Size = New System.Drawing.Size(374, 22)
        Me.ChosenEventNameTextBox.TabIndex = 4
        '
        'OpenButton
        '
        Me.OpenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenButton.Location = New System.Drawing.Point(410, 593)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 5
        Me.OpenButton.Text = "Open"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'EventLocationLabel
        '
        Me.EventLocationLabel.AutoSize = True
        Me.EventLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventLocationLabel.Location = New System.Drawing.Point(3, 75)
        Me.EventLocationLabel.Name = "EventLocationLabel"
        Me.EventLocationLabel.Size = New System.Drawing.Size(124, 16)
        Me.EventLocationLabel.TabIndex = 6
        Me.EventLocationLabel.Text = "Search Location:"
        '
        'EventDateLabel
        '
        Me.EventDateLabel.AutoSize = True
        Me.EventDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventDateLabel.Location = New System.Drawing.Point(310, 16)
        Me.EventDateLabel.Name = "EventDateLabel"
        Me.EventDateLabel.Size = New System.Drawing.Size(141, 16)
        Me.EventDateLabel.TabIndex = 7
        Me.EventDateLabel.Text = "Search Event Date:"
        '
        'SearchLocationTextBox
        '
        Me.SearchLocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLocationTextBox.Location = New System.Drawing.Point(6, 94)
        Me.SearchLocationTextBox.Name = "SearchLocationTextBox"
        Me.SearchLocationTextBox.Size = New System.Drawing.Size(262, 22)
        Me.SearchLocationTextBox.TabIndex = 8
        '
        'ShowAllEventsButton
        '
        Me.ShowAllEventsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAllEventsButton.Location = New System.Drawing.Point(140, 148)
        Me.ShowAllEventsButton.Name = "ShowAllEventsButton"
        Me.ShowAllEventsButton.Size = New System.Drawing.Size(128, 25)
        Me.ShowAllEventsButton.TabIndex = 13
        Me.ShowAllEventsButton.Text = "Show All Events"
        Me.ShowAllEventsButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(499, 593)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.SearchLocationTextBox)
        Me.GroupBox1.Controls.Add(Me.EventDateLabel)
        Me.GroupBox1.Controls.Add(Me.ShowAllEventsButton)
        Me.GroupBox1.Controls.Add(Me.EventLocationLabel)
        Me.GroupBox1.Controls.Add(Me.EventNameLabel)
        Me.GroupBox1.Controls.Add(Me.SearchNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 212)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(313, 38)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'SelectEventLabel
        '
        Me.SelectEventLabel.AutoSize = True
        Me.SelectEventLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectEventLabel.Location = New System.Drawing.Point(22, 238)
        Me.SelectEventLabel.Name = "SelectEventLabel"
        Me.SelectEventLabel.Size = New System.Drawing.Size(99, 16)
        Me.SelectEventLabel.TabIndex = 16
        Me.SelectEventLabel.Text = "Select Event:"
        '
        'OpenEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 631)
        Me.Controls.Add(Me.SelectEventLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.ChosenEventNameTextBox)
        Me.Controls.Add(Me.EventsDataGridView)
        Me.Name = "OpenEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Open Event"
        CType(Me.EventsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMEventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EventsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet As EventManager.Database1DataSet
    Friend WithEvents SearchNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventNameLabel As System.Windows.Forms.Label
    Friend WithEvents EmEventsTableAdapter1 As EventManager.Database1DataSetTableAdapters.EMEventsTableAdapter
    Friend WithEvents EMEventsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As EventManager.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ChosenEventNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenButton As System.Windows.Forms.Button
    Friend WithEvents EventLocationLabel As System.Windows.Forms.Label
    Friend WithEvents EventDateLabel As System.Windows.Forms.Label
    Friend WithEvents SearchLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowAllEventsButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SelectEventLabel As System.Windows.Forms.Label
    Friend WithEvents EventNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
