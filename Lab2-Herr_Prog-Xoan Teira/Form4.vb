Public Class Form4
    Dim tipoV As Integer
    Dim km, tone, importe As String
    Dim clase As New ClaseProblema1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label4.Click, Label3.Click

    End Sub

    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        tipoV = 1
        Label3.Hide()
        TextBox1.Hide()
        Label4.Hide()
        TextBox2.Hide()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label3.Show()
        TextBox1.Show()
        Label4.Hide()
        TextBox2.Hide()
        tipoV = 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label6.Text = ""
    End Sub

    Private Sub Problema4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema4ToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Label3.Show()
        TextBox1.Show()
        Label4.Show()
        TextBox2.Show()
        tipoV = 3
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case tipoV
            Case 1
                km = "1"
                tone = "1"
            Case 2
                tone = "1"
                km = TextBox1.Text
            Case 3
                km = TextBox1.Text
                tone = TextBox2.Text
        End Select
        If km = "" Or tone = "" Then
            MsgBox("Por favor ingrese un dato valido en los campo")
        ElseIf InStr(km, "-", CompareMethod.Text) <> 0 Or InStr(tone, "-", CompareMethod.Text) <> 0 Then
            MsgBox("Solamente se pueden aceptar valores positivos como monto validado")
        End If

        If InStr(km, ",", CompareMethod.Text) <> 0 Then
            km = Replace(km, ",", ".")
        End If
        If InStr(tone, ",", CompareMethod.Text) <> 0 Then
            km = Replace(tone, ",", ".")
        End If
        Try
            importe = FormatCurrency(clase.importeVehiculo(tipoV, CDbl(km), CDbl(tone)),,, TriState.True, TriState.True)
            Label6.Text = importe
        Catch ex As Exception
            MsgBox("Por favor ingrese un dato valido en los campo")
        End Try
    End Sub

End Class