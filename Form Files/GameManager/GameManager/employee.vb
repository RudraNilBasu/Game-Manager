Public Class employee

    Private Sub Employee_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Employee_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Employee_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Employee_Details' table. You can move, or remove it, as needed.
        Me.Employee_DetailsTableAdapter.Fill(Me.DatabaseDataSet.Employee_Details)

    End Sub

    
    
End Class