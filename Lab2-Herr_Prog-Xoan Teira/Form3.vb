Public Class Form3
    Dim clase As New ClaseProblema1
    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub VolverAPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAPrincipalToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNoCancel, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim monto, tiempo, deuda As String
        monto = TextBox1.Text
        tiempo = TextBox2.Text
        If monto = "" Or tiempo = "" Then
            MsgBox("Por favor ingrese un dato valido en los campo")
        ElseIf (InStr(tiempo, ".", CompareMethod.Text) <> 0 Or InStr(tiempo, ",", CompareMethod.Text) <> 0 Or InStr(tiempo, "-", CompareMethod.Text) <> 0) Then
            MsgBox("Solamente se pueden aceptar valores enteros como cantidad de días validado")
        ElseIf InStr(monto, "-", CompareMethod.Text) <> 0 Then
            MsgBox("Solamente se pueden aceptar valores positivos como monto validad0")
        End If

        If InStr(monto, ",", CompareMethod.Text) Then
            monto = Replace(monto, ",", ".")
        End If
        Try
            deuda = FormatCurrency(clase.calculoDeuda(CDbl(monto), CInt(tiempo)),,, TriState.True, TriState.True)
            Label6.Text = deuda
        Catch ex As Exception
            MsgBox("Por favor ingrese un dato valido en el campo")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label6.Text = ""
    End Sub

    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()


    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class