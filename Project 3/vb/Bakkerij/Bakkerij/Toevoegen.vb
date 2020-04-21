Public Class Toevoegen
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tempBrood As New brood()
        tempBrood.broodCode = numCode.Value
        tempBrood.typeBrood = txtType.Text
        tempBrood.aantal = 0
        tempBrood.prijs = numPrijs.Value
        tempBrood.Add()
        MessageBox.Show("Brood Toegevoegd")
        Me.Close()

    End Sub
End Class