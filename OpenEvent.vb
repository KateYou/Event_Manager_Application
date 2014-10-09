Public Class OpenEvent
    Dim db As New DataClasses1DataContext
    Public ThisEvent As String
    Public PassDate As String

    Private Sub EMEventsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EMEventsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
    End Sub

    Private Sub OpenEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Events' table. You can move, or remove it, as needed.
        Me.EmEventsTableAdapter1.Fill(Me.Database1DataSet.EMEvents)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchNameTextBox.TextChanged
        'searches for event by name
        Dim ChooseEvent = From shindigs In db.EMEvents
                  Where shindigs.EventName = SearchNameTextBox.Text
                  Order By shindigs.EventName
                  Select shindigs.EventName, shindigs.EventLocation, shindigs.StartDate, shindigs.StartTime
        EventsDataGridView.DataSource = ChooseEvent
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles SearchLocationTextBox.TextChanged
        'searches for event by location
        Dim ChooseEvent = From shindigs In db.EMEvents
                  Where shindigs.EventLocation = SearchLocationTextBox.Text
                  Order By shindigs.EventName
                  Select shindigs.EventName, shindigs.EventLocation, shindigs.StartDate, shindigs.StartTime
        EventsDataGridView.DataSource = ChooseEvent
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        'searches for event by calendar date
        Dim ChosenDate = FormatDateTime(Me.MonthCalendar1.SelectionRange.Start, DateFormat.LongDate)
        Dim ChooseEvent = From shindigs In db.EMEvents
                Where shindigs.StartDate = CDate(ChosenDate)
                Order By shindigs.EventName
                Select shindigs.EventName, shindigs.EventLocation, shindigs.StartDate, shindigs.StartTime
        EventsDataGridView.DataSource = ChooseEvent
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ShowAllEventsButton.Click
        'shows all Events
        Dim ChooseEvent = From shindigs In db.EMEvents
                          Order By shindigs.StartDate
                        Select shindigs.EventName, shindigs.EventLocation, shindigs.StartDate, shindigs.StartTime
        EventsDataGridView.DataSource = ChooseEvent
        SearchNameTextBox.Text = ""
        ChosenEventNameTextBox.Text = ""
        SearchLocationTextBox.Text = ""

    End Sub

    Private Sub EventsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EventsDataGridView.CellContentClick
        'puts name of event selected from eventsdatagridview box into textbox
        ChosenEventNameTextBox.Text = CStr(EventsDataGridView.Item(0, EventsDataGridView.CurrentRow.Index).Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        'Display Textbox.2 text in listbox on Main.  Main automatically pulls up event details
        Main.ChosenEventsLabel.Visible = False
        ThisEvent = ChosenEventNameTextBox.Text
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes form
        Me.Close()
    End Sub

End Class