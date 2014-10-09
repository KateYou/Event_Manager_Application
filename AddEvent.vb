Public Class AddEvent
    Public ThisEvent As String
    Private Sub EMEventsBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EMEventsBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
    End Sub

    Private Sub AddEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.EMEvents' table. You can move, or remove it, as needed.
        Me.EMEventsTableAdapter.Fill(Me.Database1DataSet.EMEvents)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        'Puts date selected from calendar in two textboxes
        Dim ChosenDate As String
        ChosenDate = FormatDateTime(Me.MonthCalendar1.SelectionRange.Start, DateFormat.ShortDate)

        If StartTextBox.Text = "" Then
            StartTextBox.Text = ChosenDate
            EndTextBox.Text = ChosenDate
        Else : EndTextBox.Text = ChosenDate
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CreateEventButton.Click
        'Method One not saving
        Dim db As New DataClasses1DataContext
        Dim Evnt As New EMEvent With {.EventName = NameTextBox.Text, .StartTime = StartMaskedTextBox.Text, .EndTime = EndMaskedTextBox.Text, .EventLocation = LocatTextBox.Text}

        'Loads New Event's name into ThisEvent public variable to be passed to Main.vb on close
        ThisEvent = NameTextBox.Text

        'Add the new object to db Events.
        db.EMEvents.InsertOnSubmit(Evnt)
        db.SubmitChanges()
        MsgBox("Update successful")


        'Method two not saving but always says "successful"
        'Me.EMEventsTableAdapter.Insert(TextBox1.Text, TextBox2.Text, CDate(MaskedTextBox3.Text), MaskedTextBox1.Text, CDate(MaskedTextBox4.Text), MaskedTextBox2.Text,
        '                             _TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, ComboBox1.Text, TextBox9.Text, "1")
        'Me.EMEventsTableAdapter.Fill(Me.Database1DataSet.EMEvents)
        'Try
        '    Me.Validate()
        '    Me.EMEventsBindingSource1.EndEdit()
        '    Me.EMEventsTableAdapter.Update(Me.Database1DataSet.EMEvents)
        '    MsgBox("Update successful")

        'Catch ex As Exception
        '    MsgBox("Update failed")
        'End Try

        'Clears textboxes & closes form
        NameTextBox.Text = ""
        LocatTextBox.Text = ""
        StartTextBox.Text = ""
        EndTextBox.Text = ""
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        NameTextBox.Text = ""
        LocatTextBox.Text = ""
        StartTextBox.Text = ""
        EndTextBox.Text = ""

        Me.Close()
    End Sub
End Class