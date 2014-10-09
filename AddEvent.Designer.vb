<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEvent
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EventNameLabel = New System.Windows.Forms.Label()
        Me.UploadDocumentsButton = New System.Windows.Forms.Button()
        Me.UploadImagesButton = New System.Windows.Forms.Button()
        Me.CreateEventButton = New System.Windows.Forms.Button()
        Me.StartLabel = New System.Windows.Forms.Label()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.LocatLabel = New System.Windows.Forms.Label()
        Me.LocatTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StartDateLabel = New System.Windows.Forms.Label()
        Me.EndDateLabel = New System.Windows.Forms.Label()
        Me.StartMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EndMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EndTextBox = New System.Windows.Forms.TextBox()
        Me.StartTextBox = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.AttachComboBox = New System.Windows.Forms.ComboBox()
        Me.NotesLabel = New System.Windows.Forms.Label()
        Me.AttachLabel = New System.Windows.Forms.Label()
        Me.InstallLabel = New System.Windows.Forms.Label()
        Me.AVLabel = New System.Windows.Forms.Label()
        Me.FloristLabel = New System.Windows.Forms.Label()
        Me.BarLabel = New System.Windows.Forms.Label()
        Me.CatLabel = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.InstallTextBox = New System.Windows.Forms.TextBox()
        Me.AVTextBox = New System.Windows.Forms.TextBox()
        Me.FlorTextBox = New System.Windows.Forms.TextBox()
        Me.BarTextBox = New System.Windows.Forms.TextBox()
        Me.CatTextBox = New System.Windows.Forms.TextBox()
        Me.Database1DataSet = New EventManager.Database1DataSet()
        Me.TableAdapterManager = New EventManager.Database1DataSetTableAdapters.TableAdapterManager()
        Me.EMEventsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMEventsTableAdapter = New EventManager.Database1DataSetTableAdapters.EMEventsTableAdapter()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMEventsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(132, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(485, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'EventNameLabel
        '
        Me.EventNameLabel.AutoSize = True
        Me.EventNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventNameLabel.Location = New System.Drawing.Point(13, 29)
        Me.EventNameLabel.Name = "EventNameLabel"
        Me.EventNameLabel.Size = New System.Drawing.Size(45, 16)
        Me.EventNameLabel.TabIndex = 2
        Me.EventNameLabel.Text = "Name"
        '
        'UploadDocumentsButton
        '
        Me.UploadDocumentsButton.Enabled = False
        Me.UploadDocumentsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadDocumentsButton.Location = New System.Drawing.Point(24, 537)
        Me.UploadDocumentsButton.Name = "UploadDocumentsButton"
        Me.UploadDocumentsButton.Size = New System.Drawing.Size(159, 34)
        Me.UploadDocumentsButton.TabIndex = 3
        Me.UploadDocumentsButton.Text = "Upload Documents"
        Me.UploadDocumentsButton.UseVisualStyleBackColor = True
        '
        'UploadImagesButton
        '
        Me.UploadImagesButton.Enabled = False
        Me.UploadImagesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadImagesButton.Location = New System.Drawing.Point(205, 537)
        Me.UploadImagesButton.Name = "UploadImagesButton"
        Me.UploadImagesButton.Size = New System.Drawing.Size(149, 34)
        Me.UploadImagesButton.TabIndex = 4
        Me.UploadImagesButton.Text = "Upload Images"
        Me.UploadImagesButton.UseVisualStyleBackColor = True
        '
        'CreateEventButton
        '
        Me.CreateEventButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateEventButton.Location = New System.Drawing.Point(428, 537)
        Me.CreateEventButton.Name = "CreateEventButton"
        Me.CreateEventButton.Size = New System.Drawing.Size(124, 34)
        Me.CreateEventButton.TabIndex = 5
        Me.CreateEventButton.Text = "Create Event"
        Me.CreateEventButton.UseVisualStyleBackColor = True
        '
        'StartLabel
        '
        Me.StartLabel.AutoSize = True
        Me.StartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartLabel.Location = New System.Drawing.Point(13, 64)
        Me.StartLabel.Name = "StartLabel"
        Me.StartLabel.Size = New System.Drawing.Size(69, 16)
        Me.StartLabel.TabIndex = 7
        Me.StartLabel.Text = "Start Time"
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndLabel.Location = New System.Drawing.Point(13, 98)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(66, 16)
        Me.EndLabel.TabIndex = 8
        Me.EndLabel.Text = "End Time"
        '
        'LocatLabel
        '
        Me.LocatLabel.AutoSize = True
        Me.LocatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocatLabel.Location = New System.Drawing.Point(13, 247)
        Me.LocatLabel.Name = "LocatLabel"
        Me.LocatLabel.Size = New System.Drawing.Size(59, 16)
        Me.LocatLabel.TabIndex = 9
        Me.LocatLabel.Text = "Location"
        '
        'LocatTextBox
        '
        Me.LocatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocatTextBox.Location = New System.Drawing.Point(132, 244)
        Me.LocatTextBox.Name = "LocatTextBox"
        Me.LocatTextBox.Size = New System.Drawing.Size(485, 22)
        Me.LocatTextBox.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StartDateLabel
        '
        Me.StartDateLabel.AutoSize = True
        Me.StartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateLabel.Location = New System.Drawing.Point(13, 136)
        Me.StartDateLabel.Name = "StartDateLabel"
        Me.StartDateLabel.Size = New System.Drawing.Size(67, 16)
        Me.StartDateLabel.TabIndex = 10
        Me.StartDateLabel.Text = "Start Date"
        '
        'EndDateLabel
        '
        Me.EndDateLabel.AutoSize = True
        Me.EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLabel.Location = New System.Drawing.Point(13, 170)
        Me.EndDateLabel.Name = "EndDateLabel"
        Me.EndDateLabel.Size = New System.Drawing.Size(64, 16)
        Me.EndDateLabel.TabIndex = 11
        Me.EndDateLabel.Text = "End Date"
        '
        'StartMaskedTextBox
        '
        Me.StartMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartMaskedTextBox.Location = New System.Drawing.Point(132, 63)
        Me.StartMaskedTextBox.Mask = "90:00"
        Me.StartMaskedTextBox.Name = "StartMaskedTextBox"
        Me.StartMaskedTextBox.Size = New System.Drawing.Size(39, 22)
        Me.StartMaskedTextBox.TabIndex = 12
        Me.StartMaskedTextBox.ValidatingType = GetType(Date)
        '
        'EndMaskedTextBox
        '
        Me.EndMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndMaskedTextBox.Location = New System.Drawing.Point(132, 97)
        Me.EndMaskedTextBox.Mask = "90:00"
        Me.EndMaskedTextBox.Name = "EndMaskedTextBox"
        Me.EndMaskedTextBox.Size = New System.Drawing.Size(39, 22)
        Me.EndMaskedTextBox.TabIndex = 13
        Me.EndMaskedTextBox.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EndTextBox)
        Me.GroupBox1.Controls.Add(Me.StartTextBox)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.AttachComboBox)
        Me.GroupBox1.Controls.Add(Me.NotesLabel)
        Me.GroupBox1.Controls.Add(Me.AttachLabel)
        Me.GroupBox1.Controls.Add(Me.InstallLabel)
        Me.GroupBox1.Controls.Add(Me.AVLabel)
        Me.GroupBox1.Controls.Add(Me.FloristLabel)
        Me.GroupBox1.Controls.Add(Me.BarLabel)
        Me.GroupBox1.Controls.Add(Me.CatLabel)
        Me.GroupBox1.Controls.Add(Me.NotesTextBox)
        Me.GroupBox1.Controls.Add(Me.InstallTextBox)
        Me.GroupBox1.Controls.Add(Me.AVTextBox)
        Me.GroupBox1.Controls.Add(Me.FlorTextBox)
        Me.GroupBox1.Controls.Add(Me.BarTextBox)
        Me.GroupBox1.Controls.Add(Me.CatTextBox)
        Me.GroupBox1.Controls.Add(Me.EndMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.StartMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.EndDateLabel)
        Me.GroupBox1.Controls.Add(Me.StartDateLabel)
        Me.GroupBox1.Controls.Add(Me.LocatTextBox)
        Me.GroupBox1.Controls.Add(Me.LocatLabel)
        Me.GroupBox1.Controls.Add(Me.EndLabel)
        Me.GroupBox1.Controls.Add(Me.StartLabel)
        Me.GroupBox1.Controls.Add(Me.EventNameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 503)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'EndTextBox
        '
        Me.EndTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndTextBox.Location = New System.Drawing.Point(132, 169)
        Me.EndTextBox.Name = "EndTextBox"
        Me.EndTextBox.Size = New System.Drawing.Size(86, 22)
        Me.EndTextBox.TabIndex = 35
        '
        'StartTextBox
        '
        Me.StartTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTextBox.Location = New System.Drawing.Point(132, 133)
        Me.StartTextBox.Name = "StartTextBox"
        Me.StartTextBox.Size = New System.Drawing.Size(86, 22)
        Me.StartTextBox.TabIndex = 34
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(251, 63)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 33
        '
        'AttachComboBox
        '
        Me.AttachComboBox.FormattingEnabled = True
        Me.AttachComboBox.Location = New System.Drawing.Point(405, 318)
        Me.AttachComboBox.Name = "AttachComboBox"
        Me.AttachComboBox.Size = New System.Drawing.Size(212, 21)
        Me.AttachComboBox.TabIndex = 32
        '
        'NotesLabel
        '
        Me.NotesLabel.AutoSize = True
        Me.NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesLabel.Location = New System.Drawing.Point(319, 361)
        Me.NotesLabel.Name = "NotesLabel"
        Me.NotesLabel.Size = New System.Drawing.Size(44, 16)
        Me.NotesLabel.TabIndex = 31
        Me.NotesLabel.Text = "Notes"
        '
        'AttachLabel
        '
        Me.AttachLabel.AutoSize = True
        Me.AttachLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttachLabel.Location = New System.Drawing.Point(319, 319)
        Me.AttachLabel.Name = "AttachLabel"
        Me.AttachLabel.Size = New System.Drawing.Size(81, 16)
        Me.AttachLabel.TabIndex = 30
        Me.AttachLabel.Text = "Attachments"
        '
        'InstallLabel
        '
        Me.InstallLabel.AutoSize = True
        Me.InstallLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstallLabel.Location = New System.Drawing.Point(319, 282)
        Me.InstallLabel.Name = "InstallLabel"
        Me.InstallLabel.Size = New System.Drawing.Size(54, 16)
        Me.InstallLabel.TabIndex = 29
        Me.InstallLabel.Text = "Installer"
        '
        'AVLabel
        '
        Me.AVLabel.AutoSize = True
        Me.AVLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AVLabel.Location = New System.Drawing.Point(13, 402)
        Me.AVLabel.Name = "AVLabel"
        Me.AVLabel.Size = New System.Drawing.Size(33, 16)
        Me.AVLabel.TabIndex = 28
        Me.AVLabel.Text = "A/V "
        '
        'FloristLabel
        '
        Me.FloristLabel.AutoSize = True
        Me.FloristLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FloristLabel.Location = New System.Drawing.Point(13, 362)
        Me.FloristLabel.Name = "FloristLabel"
        Me.FloristLabel.Size = New System.Drawing.Size(44, 16)
        Me.FloristLabel.TabIndex = 27
        Me.FloristLabel.Text = "Florist"
        '
        'BarLabel
        '
        Me.BarLabel.AutoSize = True
        Me.BarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarLabel.Location = New System.Drawing.Point(13, 325)
        Me.BarLabel.Name = "BarLabel"
        Me.BarLabel.Size = New System.Drawing.Size(29, 16)
        Me.BarLabel.TabIndex = 26
        Me.BarLabel.Text = "Bar"
        '
        'CatLabel
        '
        Me.CatLabel.AutoSize = True
        Me.CatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatLabel.Location = New System.Drawing.Point(13, 288)
        Me.CatLabel.Name = "CatLabel"
        Me.CatLabel.Size = New System.Drawing.Size(52, 16)
        Me.CatLabel.TabIndex = 25
        Me.CatLabel.Text = "Caterer"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Location = New System.Drawing.Point(404, 359)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(212, 124)
        Me.NotesTextBox.TabIndex = 24
        '
        'InstallTextBox
        '
        Me.InstallTextBox.Location = New System.Drawing.Point(405, 281)
        Me.InstallTextBox.Name = "InstallTextBox"
        Me.InstallTextBox.Size = New System.Drawing.Size(212, 20)
        Me.InstallTextBox.TabIndex = 22
        '
        'AVTextBox
        '
        Me.AVTextBox.Location = New System.Drawing.Point(132, 395)
        Me.AVTextBox.Name = "AVTextBox"
        Me.AVTextBox.Size = New System.Drawing.Size(178, 20)
        Me.AVTextBox.TabIndex = 21
        '
        'FlorTextBox
        '
        Me.FlorTextBox.Location = New System.Drawing.Point(132, 359)
        Me.FlorTextBox.Name = "FlorTextBox"
        Me.FlorTextBox.Size = New System.Drawing.Size(178, 20)
        Me.FlorTextBox.TabIndex = 20
        '
        'BarTextBox
        '
        Me.BarTextBox.Location = New System.Drawing.Point(132, 318)
        Me.BarTextBox.Name = "BarTextBox"
        Me.BarTextBox.Size = New System.Drawing.Size(178, 20)
        Me.BarTextBox.TabIndex = 19
        '
        'CatTextBox
        '
        Me.CatTextBox.Location = New System.Drawing.Point(132, 281)
        Me.CatTextBox.Name = "CatTextBox"
        Me.CatTextBox.Size = New System.Drawing.Size(178, 20)
        Me.CatTextBox.TabIndex = 18
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EMEventsTableAdapter = Nothing
        Me.TableAdapterManager.FacilitiesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EventManager.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'EMEventsBindingSource1
        '
        Me.EMEventsBindingSource1.DataMember = "EMEvents"
        Me.EMEventsBindingSource1.DataSource = Me.Database1DataSet
        '
        'EMEventsTableAdapter
        '
        Me.EMEventsTableAdapter.ClearBeforeFill = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(574, 537)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 34)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 592)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CreateEventButton)
        Me.Controls.Add(Me.UploadImagesButton)
        Me.Controls.Add(Me.UploadDocumentsButton)
        Me.Name = "AddEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Event"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMEventsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventNameLabel As System.Windows.Forms.Label
    Friend WithEvents UploadDocumentsButton As System.Windows.Forms.Button
    Friend WithEvents UploadImagesButton As System.Windows.Forms.Button
    Friend WithEvents CreateEventButton As System.Windows.Forms.Button
    Friend WithEvents StartLabel As System.Windows.Forms.Label
    Friend WithEvents EndLabel As System.Windows.Forms.Label
    Friend WithEvents LocatLabel As System.Windows.Forms.Label
    Friend WithEvents LocatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StartDateLabel As System.Windows.Forms.Label
    Friend WithEvents EndDateLabel As System.Windows.Forms.Label
    Friend WithEvents StartMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EndMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Database1DataSet As EventManager.Database1DataSet
    Friend WithEvents TableAdapterManager As EventManager.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InstallTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AVTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FlorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesLabel As System.Windows.Forms.Label
    Friend WithEvents AttachLabel As System.Windows.Forms.Label
    Friend WithEvents InstallLabel As System.Windows.Forms.Label
    Friend WithEvents AVLabel As System.Windows.Forms.Label
    Friend WithEvents FloristLabel As System.Windows.Forms.Label
    Friend WithEvents BarLabel As System.Windows.Forms.Label
    Friend WithEvents CatLabel As System.Windows.Forms.Label
    Friend WithEvents AttachComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EMEventsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EMEventsTableAdapter As EventManager.Database1DataSetTableAdapters.EMEventsTableAdapter
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents StartTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
