Public Class table
    Dim noOfEmp, empReqd, salary As Integer

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim budget, weekRem As Integer
        Dim hoursToWork As Integer ' amount of hours to work
        Dim type, genre As String
        type = ComboBox1.SelectedItem
        genre = ComboBox2.SelectedItem
        If type = "" Or genre = "" Then
            MsgBox("Invalid")
        End If
        ' Calculating the hours and employee reqd to work per week
        hoursToWork = 0
        empReqd = 0
        If type = "2D" Then
            hoursToWork = hoursToWork + 10
            empReqd = empReqd + 3
        ElseIf type = "3D" Then
            hoursToWork = hoursToWork + 40
            empReqd = empReqd + 9
        End If

        If genre = "Platformer" Then
            hoursToWork = hoursToWork + 20
            empReqd = empReqd + 1
        ElseIf genre = "Survival Shooter" Then
            hoursToWork = hoursToWork + 50
            empReqd = empReqd + 2
        End If

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Invalid")
        Else
            ' budget from the input
            budget = CInt(TextBox1.Text)
            ' Weeks Remaining
            weekRem = CInt(TextBox2.Text)
        End If
        

        ' salary of each employee
        salary = TextBox3.Text

        employee.Close()
        employee.Show()
        noOfEmp = employee.noOfEmpl

        Dim currentBudget As Integer
        currentBudget = salary * noOfEmp

        Dim budgetReview, empNoReview As String

        If currentBudget > budget Then
            budgetReview = "Budget Exceeded"
            'Label7.ForeColor = Color.Red
        Else
            budgetReview = "No Budget Problem"
            'Label7.ForeColor = Color.Green
        End If


        If noOfEmp < empReqd Then
            empNoReview = "Less no of Employee"
        Else
            empNoReview = "Enough Employees are present"
        End If
        TextBox4.Text = budgetReview & vbNewLine & empNoReview & vbNewLine
        ' "Employee Required " & empReqd & vbNewLine & " no of empl = " & noOfEmp

        If empNoReview = "Enough Employees are present" And budgetReview = "No Budget Problem" Then
            Label7.ForeColor = Color.Green
            Label7.Text = "Status : Safe"
            Button2.Visible = False
        Else
            Label7.ForeColor = Color.Red
            Label7.Text = "Status : Danger"
            Button2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Employee Required " & empReqd & vbNewLine & " no of empl = " & noOfEmp)
    End Sub

    Private Sub table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False
    End Sub
End Class