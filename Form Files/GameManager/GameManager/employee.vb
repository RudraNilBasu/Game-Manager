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

    
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Employee_DetailsBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Employee_DetailsBindingSource.EndEdit()
            Employee_DetailsTableAdapter.Update(DatabaseDataSet.Employee_Details)
            MsgBox("Saved!")
        Catch ex As Exception
            MsgBox("Failed to Save")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Employee_DetailsBindingSource.RemoveCurrent()
    End Sub
End Class