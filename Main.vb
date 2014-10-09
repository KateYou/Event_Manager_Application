Public Class Main
    Dim db As New DataClasses1DataContext  'Names new data context
    Public ThisEvent As String  'Names public variable for easy passing of an event's name

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim ChosenDate As String

        ChosenDate = FormatDateTime(Me.MonthCalendar1.SelectionRange.Start, DateFormat.LongDate)
        ChosenEventsLabel.Visible = True
        Me.ChosenEventsLabel.Text = ("on: " & ChosenDate)  'Displays chosen date as label text

        Dim Datedata As New Date
        Datedata = CDate(ChosenDate)  'Converts date string to date 

        'Query to show events in grid box which are happening on the calendar date displayed in label
        Dim ChooseEvent = From shindig In db.EMEvents
            Where shindig.StartDate = Datedata
            Order By shindig.StartTime
            Select shindig
        EventsDataGridView.DataSource = ChooseEvent

        'Unused: Shows query results in listbox
        'For Each EventResult In ChooseEvent
        '    ListBox1.Items.Add(EventResult.EventName)
        'Next

    End Sub

    Private Sub EventsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EventsDataGridView.CellContentClick
        'User chooses an event(cell) in the EventsDataGridView and the details will be displayed in the tabbed boxes below
        Dim ChosenEvent = CStr(EventsDataGridView.Item(0, EventsDataGridView.CurrentRow.Index).Value)
        Dim ChosenDate = CStr(EventsDataGridView.Item(3, EventsDataGridView.CurrentRow.Index).Value)
        NotesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'Query to choose vendor important info, currently shows ALL info
        Dim ChooseVendor = From shindig In db.EMEvents Join peeps In db.Vendors
                          On shindig.CommonCode Equals peeps.CommonCode
                          Where shindig.EventName = ChosenEvent
                           Select peeps '.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website
        VendorDataGridView.DataSource = ChooseVendor

        Dim ChooseNotes = From shindig In db.EMEvents
                          Where shindig.EventName = ChosenEvent
                          Select shindig
        NotesDataGridView.DataSource = ChooseNotes

    End Sub

    Private Sub NewEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEventToolStripMenuItem.Click
        Dim ShowForm As String = CStr(AddEvent.ShowDialog())  'shows Add Event form

        'Shows the newly created Event in EventsDataGrid View
        Dim ShowEvent = From shindig In db.EMEvents
                        Where shindig.EventName = AddEvent.ThisEvent
                        Select shindig

        EventsDataGridView.DataSource = ShowEvent
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ShowAllEventsButton.Click
        'resets Eventsdatagridview to show all events
        Dim ChooseEvent = From shindig In db.EMEvents
                Order By shindig.StartTime
                Select shindig
        EventsDataGridView.DataSource = ChooseEvent
        ChosenEventsLabel.Visible = False
    End Sub

    Private Sub AddVendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVendorToolStripMenuItem.Click
        Dim ShowForm As String = CStr(AddVendor.ShowDialog())   'shows Add Vendor form
    End Sub

    Private Sub CateringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CateringToolStripMenuItem.Click
        'shows Vendors Form with all caterers
        Dim ChooseVendor = From peeps In db.Vendors
        Where peeps.VType = "Caterer"
                          Order By peeps.VName
                          Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        Vendors.VendorsDataGridView.DataSource = ChooseVendor
        Dim ShowForm As String = CStr(Vendors.ShowDialog())
    End Sub

    Private Sub FloralDecorationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FloralDecorationToolStripMenuItem.Click
        'shows Vendors Form with all florists
        Dim ChooseVendor = From peeps In db.Vendors
                          Where peeps.VType = "Florist"
                          Order By peeps.VName
                          Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        Vendors.VendorsDataGridView.DataSource = ChooseVendor
        Dim ShowForm As String = CStr(Vendors.ShowDialog())
    End Sub

    Private Sub AudioVisualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioVisualToolStripMenuItem.Click
        'shows Vendors Form with all Audio/Visual providers
        Dim ChooseVendor = From peeps In db.Vendors
                          Where peeps.VType = "A/V"
                          Order By peeps.VName
                          Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        Vendors.VendorsDataGridView.DataSource = ChooseVendor
        Dim ShowForm As String = CStr(Vendors.ShowDialog())
    End Sub

    Private Sub InstallersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallersToolStripMenuItem.Click
        'shows Vendors Form with all event Installation crews
        Dim ChooseVendor = From peeps In db.Vendors
                          Where peeps.VType = "Installer"
                          Order By peeps.VName
                          Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        Vendors.VendorsDataGridView.DataSource = ChooseVendor
        Dim ShowForm As String = CStr(Vendors.ShowDialog())
    End Sub

    Private Sub FacilitiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacilitiesToolStripMenuItem.Click
        'shows Vendors Form with all facilities
        Dim ChooseVendor = From peeps In db.Vendors
                          Where peeps.VType = "Facility"
                          Order By peeps.VName
                          Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        Vendors.VendorsDataGridView.DataSource = ChooseVendor
        Dim ShowForm As String = CStr(Vendors.ShowDialog())
    End Sub

    Private Sub BarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarToolStripMenuItem.Click
        'shows Vendors Form with all Bar vendors
        Dim ChooseVendor = From peeps In db.Vendors
                          Where peeps.VType = "Bar"
                          Order By peeps.VName
                          Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        Vendors.VendorsDataGridView.DataSource = ChooseVendor
        Dim ShowForm As String = CStr(Vendors.ShowDialog())
    End Sub

    Private Sub OpenEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenEventToolStripMenuItem.Click
        Dim ShowForm As String = CStr(OpenEvent.ShowDialog())    'shows Form to open existing event
        Dim ShowEvent = From shindig In db.EMEvents
                        Where shindig.EventName = OpenEvent.ThisEvent
                        Select shindig

        EventsDataGridView.DataSource = ShowEvent
    End Sub

    Private Sub ExitManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitManagerToolStripMenuItem.Click
        Me.Close()  'closes program
    End Sub

End Class
