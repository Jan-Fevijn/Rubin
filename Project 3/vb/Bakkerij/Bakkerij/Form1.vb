Public Class Aanpassen
    Private mbrood As New DataTable
    Private currentRow() As DataRow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On load Data van DB ophalen en in combobox zetten
        FillCbx()
    End Sub
    Private Sub FillCbx()
        cbxBrood.Items.Clear()
        mbrood = brood.GetAll()
        For Each i As DataRow In mbrood.Select()
            cbxBrood.Items.Add(i("typeBrood"))
        Next
    End Sub
    Private Sub cbxBrood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBrood.SelectedIndexChanged
        'Update Saldo in tekstveld

        currentRow = mbrood.Select($"typeBrood = '{cbxBrood.SelectedItem.ToString}'")
        numPrijs.Value = currentRow(0)("prijs")
        numCode.Value = currentRow(0)("broodCode")
        txtType.Text = currentRow(0)("typeBrood")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim tempBrood As brood = brood.GetOne(currentRow(0)("id"))
        If numCode.Value <> 0 Then
            tempBrood.broodCode = numCode.Value
        End If
        If txtType.Text <> "" Then
            tempBrood.typeBrood = txtType.Text
        End If
        tempBrood.prijs = numPrijs.Value
        tempBrood.Update()
        MessageBox.Show("Brood geüpdate!")
        Me.Close()
    End Sub

    Private Sub cbxBrood_click(sender As Object, e As EventArgs) Handles cbxBrood.Click
        FillCbx()
    End Sub
End Class
