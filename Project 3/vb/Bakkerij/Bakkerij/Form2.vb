Public Class Form2
    Private mbrood As New DataTable
    Private currentRow() As DataRow
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        currentRow = mbrood.Select($"typeBrood = '{cbxBrood.SelectedItem.ToString}'")
        numStock.Value = currentRow(0)("aantal")
    End Sub
    Private Sub KaartHerladenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaartHerladenToolStripMenuItem.Click
        Herlaad()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim tempBrood As brood = brood.GetOne(currentRow(0)("id"))
        If numStock.Value <> 0 Then
            tempBrood.aantal = numStock.Value
        End If
        tempBrood.Update()
        MessageBox.Show($"{numStock.Value} {tempBrood.typeBrood} Toegevoegd")
    End Sub
    Private Sub Herlaad()
        Dim klantcode As String
        Dim mklant As klant
        klantcode = InputBox("Vul de klantcode in.")
        If klantcode <> "" Then
            mklant = klant.GetOne(klantcode)
            If mklant.id IsNot Nothing Then
                Dim inputSaldo As String = InputBox("Hoeveel wilt u herladen?")
                Dim newSaldo = CheckInput(inputSaldo)
                If newSaldo = 0 Then
                    MessageBox.Show("U moet een bedrag ingeven.")
                End If
                mklant.saldo += newSaldo
                mklant.Update()
            Else
                MessageBox.Show("Geen Klant gevonden")
            End If

        End If
    End Sub
    Private Function CheckInput(ByVal value As String) As Decimal
        If String.IsNullOrWhiteSpace(value) Then Return Nothing
        If IsNumeric(value) Then
            If value.Contains(".") Then
                value = value.Replace(".", ",")
            End If
            Return CDec(value)
        End If
    End Function

    Private Sub BroodAanpassenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BroodAanpassenToolStripMenuItem.Click
        Aanpassen.Show()
    End Sub

    Private Sub BroodToevoegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BroodToevoegenToolStripMenuItem.Click
        Toevoegen.Show()
    End Sub

    Private Sub cbxBrood_click(sender As Object, e As EventArgs) Handles cbxBrood.Click
        FillCbx()
    End Sub
End Class