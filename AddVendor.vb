Public Class AddVendor
    Public ThisVendor As String
    Dim db As New DataClasses1DataContext

    Private Sub AddVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.Database1DataSet.Vendors)
    End Sub

    Private Sub VendorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VendorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        MsgBox("Update successful")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.VendorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
        MsgBox("Update successful")
    End Sub
End Class