Public Class VendorInfo
    Public ThisVendor As String
    Dim db As New DataClasses1DataContext

    'Private Sub VendorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.VendorsBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    'End Sub

    Private Sub VendorInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Vendors' table. You can move, or remove it, as needed.
        'Me.VendorsTableAdapter.Fill(Me.Database1DataSet.Vendors)

        'Assigns values returned from below functions to textboxes on form
        If Vendors.ThisVendor <> Nothing Then

            Me.VNameTextBox.Text = GetVName(Vendors.ThisVendor)
            Me.VTypeTextBox.Text = GetVType(Vendors.ThisVendor)
            Me.VAddressTextBox.Text = GetVAddress(Vendors.ThisVendor)
            Me.VCityTextBox.Text = GetVCity(Vendors.ThisVendor)
            Me.VStateTextBox.Text = GetVState(Vendors.ThisVendor)
            Me.VZipTextBox.Text = GetVZip(Vendors.ThisVendor)
            Me.VContactTextBox.Text = GetVContact(Vendors.ThisVendor)
            Me.VPhoneTextBox.Text = GetVPhone(Vendors.ThisVendor)
            Me.VFaxTextBox.Text = GetVFax(Vendors.ThisVendor)
            Me.VTaxIDTextBox.Text = GetVTaxID(Vendors.ThisVendor)
            Me.NotesTextBox.Text = GetVNotes(Vendors.ThisVendor)
            'Me.AttachmentsComboBox.Text = GetVAttachments(Vendors.ThisVendor)
            Me.WebsiteTextBox.Text = GetVWebsite(Vendors.ThisVendor)
            Me.VInsuranceTextBox.Text = GetVInsurance(Vendors.ThisVendor)
        End If

    End Sub

    'all below functions run queries to associate data with the form, using ThisVendor variable, passed from Vendors, to search
    Function GetVName(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VName).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVType(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VType).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVAddress(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VAddress).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVCity(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VCity).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVState(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VState).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVZip(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VZip).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVContact(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VContact).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVPhone(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VPhone).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVFax(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VFax).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVTaxID(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VTaxID).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVNotes(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.Notes).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    Function GetVInsurance(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.VInsurance).Single()
            Return CStr(ChooseVendor2)
        End If
    End Function

    'Function GetVAttachments(ThisVendor As String) As String
    '    If Vendors.ThisVendor <> Nothing Then
    '        Dim ChooseVendor2 = (From peeps In db.Vendors
    '                  Where peeps.VName = Vendors.ThisVendor
    '                  Order By peeps.VType
    '                  Select peeps.Attachments).Single()
    '        Return ChooseVendor2
    '    End If
    'End Function

    Function GetVWebsite(ThisVendor As String) As String
        If Vendors.ThisVendor <> Nothing Then
            Dim ChooseVendor2 = (From peeps In db.Vendors
                      Where peeps.VName = Vendors.ThisVendor
                      Order By peeps.VType
                      Select peeps.Website).Single()
            Return CStr(ChooseVendor2)
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ThisVendor = ""
        Me.Close()
    End Sub
End Class