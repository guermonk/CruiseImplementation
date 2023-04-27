Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim busTour As Decimal = 30D
        Dim whaleWatch As Decimal = 100D
        Dim foodReview As Decimal = 40D
        Dim averageTrip As Decimal
        Dim RadioMessage As String
        Dim excursionChecked As String



        If IsNumeric(TextBoxPeople.Text) Then
            averageTrip = Convert.ToDecimal(TextBoxPeople.Text)  '#num of people
            If averageTrip > 0 Then
                If RadioWhale.Checked Then
                    RadioMessage = "Whale Watching"
                    RadioWhale.Checked.ToString()
                    averageTrip = whaleWatch   'excursion cost
                    excursionChecked = "Whale Watch"
                ElseIf RadioFood.Checked Then
                    RadioFood.Checked.ToString()
                    averageTrip = foodReview
                    excursionChecked = "Food Review"
                ElseIf RadioBus.Checked Then
                    RadioBus.Checked.ToString()
                    averageTrip = busTour
                    excursionChecked = "Bus Tour"

                End If
                lblMessage.Text = TextBoxPeople.Text & " people reserved " & TextBoxPeople.Text & " tickets for a " & excursionChecked & " and it adds to a sum of " & lblTotal.Text

                lblTotal.Text = FormatCurrency(Convert.ToInt32(TextBoxPeople.Text) * averageTrip.ToString("C"))

            Else
                MsgBox("You entered " & averageTrip.ToString() & ". Enter a positive number", , "Input Error")
                TextBoxPeople.Text = ""
                lblMessage.Text = ""
                lblTotal.Text = ""
                TextBoxPeople.Focus()

            End If
        Else
            MsgBox("Enter a valid number", , "Input Error")
            TextBoxPeople.Text = ""
            TextBoxPeople.Focus()
            lblMessage.Text = ""
            lblTotal.Text = ""

        End If

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotal.Text = ""
        TextBoxPeople.Text = ""
        lblMessage.Text = ""


    End Sub

End Class
