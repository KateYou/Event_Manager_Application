Public Class Vendors
    Dim db As New DataClasses1DataContext
    Public ThisVendor As String

    Private Sub Vendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.Database1DataSet.Vendors)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles VNameTextBox.TextChanged
        'Searches for Vendor by Name
        Dim ChooseVendor = From peeps In db.Vendors
                    Where peeps.VName = VNameTextBox.Text
                    Order By peeps.VType
                    Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        VendorsDataGridView.DataSource = ChooseVendor
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VTypeComboBox.SelectedIndexChanged
        'Searches for Vendor by type
        Dim ChooseVendor = From peeps In db.Vendors
                          Where peeps.VType = VTypeComboBox.Text
                          Order By peeps.VName
                          Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website

        VendorsDataGridView.DataSource = ChooseVendor
    End Sub

    Private Sub VendorsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VendorsDataGridView.CellContentClick
        'Puts Vendor Name from chosen cell into textbox, assigns name to ThisVendor variable
        ChosenVendorTextBox.Text = CStr(VendorsDataGridView.Item(0, VendorsDataGridView.CurrentRow.Index).Value)
        ThisVendor = ChosenVendorTextBox.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ShowAllVendorsButton.Click
        'Shows all vendors
        Dim ChooseVendor = From peeps In db.Vendors Select peeps.VName, peeps.VType, peeps.VContact, peeps.VPhone, peeps.Website
        VendorsDataGridView.DataSource = ChooseVendor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        'Opens Vendor Information Form
        Dim ShowForm As String = CStr(VendorInfo.ShowDialog())
        ChosenVendorTextBox.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes form
        ChosenVendorTextBox.Text = ""
        Me.Close()
    End Sub
End Class