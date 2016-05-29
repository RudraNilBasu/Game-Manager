Public Class employee
    Dim searchItem As String
    Private Sub Employee_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Employee_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Employee_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Employee_Details' table. You can move, or remove it, as needed.
        Me.Employee_DetailsTableAdapter.Fill(Me.DatabaseDataSet.Employee_Details)

        ' After this from search tutorial
        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
        
        ' search tut ends here

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ComboBox1.SelectedItem = "All" Then
            DataGridView1.DataSource = Employee_DetailsBindingSource
            searchItem = "All"
        ElseIf ComboBox1.SelectedItem = "Graphics" Then
            'DataGridView1.DataSource = Nothing
            searchItem = "Graphics"
        ElseIf ComboBox1.SelectedItem = "Programmer" Then
            'DataGridView1.DataSource = Nothing
            searchItem = "Programmer"
        ElseIf ComboBox1.SelectedItem = "Sound" Then
            'DataGridView1.DataSource = Nothing
            searchItem = "Sound"
        End If

        'Search tutorial begins here
        If searchItem = "All" Then
            On Error GoTo ErrRe
            Employee_DetailsBindingSource.Filter = Nothing

            With DataGridView1
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = Employee_DetailsBindingSource
            End With
ErrEx:
            Exit Sub
ErrRe:
            MsgBox("Error Occured Lol, didn't expect that, did you ? Err No " & Err.Number & vbNewLine & "Descripton : " & Err.Description)
            Resume ErrEx
        Else
            On Error GoTo SearchErr

            'Employee_DetailsBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & _
            '   searchItem & "')" & "OR (YourName LIKE '" & searchItem & "') OR LastName LIKE '" & searchItem & "')"
            Employee_DetailsBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & _
               searchItem & "')" & "OR (NAME LIKE '" & searchItem & "') OR (Position LIKE '" & searchItem & "')"

            If Employee_DetailsBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = Employee_DetailsBindingSource
                End With
            Else
                MsgBox("lel, You don't have any employee in this position. Good Luck With your Project")
                Employee_DetailsBindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = Employee_DetailsBindingSource
                End With
            End If

SearchErr:
            MsgBox("Error Occured Lol, didn't expect that, did you ? Err No " & Err.Number & vbNewLine & "Descripton : " & Err.Description)
            Resume ErrEx


        End If
        ' Search tut ends here

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Employee_DetailsBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Employee_DetailsBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub



End Class