Public Class Form5
    Dim clase As New ClaseProblema1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox3.SelectedIndexChanged, ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim minLoc, minLocD, minInter, costoTotal As String
        Dim horaLoc, horaLocD, horaInter As Boolean
        minLoc = TextBox1.Text
        minLocD = TextBox2.Text
        minInter = TextBox3.Text
        If minLoc = "" Or minLocD = "" Or minInter Then
            MsgBox("Por favor ingrese un dato valido en los campo")
        ElseIf ((InStr(minLoc, ".", CompareMethod.Text) <> 0 Or InStr(minLoc, ",", CompareMethod.Text) <> 0 Or InStr(minLoc, "-", CompareMethod.Text) <> 0)) Or
            (InStr(minLocD, ".", CompareMethod.Text) <> 0 Or InStr(minLocD, ",", CompareMethod.Text) <> 0 Or InStr(minLocD, "-", CompareMethod.Text) <> 0) Or
             (InStr(minInter, ".", CompareMethod.Text) <> 0 Or InStr(minInter, ",", CompareMethod.Text) <> 0 Or InStr(minInter, "-", CompareMethod.Text) <> 0) Then
            MsgBox("Solamente se pueden aceptar valores enteros como cantidad de días validado")
        End If
        If ComboBox1.Text = "6:00 a.m. -12:00 p.m." Then
            horaLoc = True
        ElseIf ComboBox2.Text = "6:00 a.m. -12:00 p.m." Then
            horaLocD = True
        ElseIf ComboBox3.Text = "6:00 a.m. -12:00 p.m." Then
            horaInter = True
        Else
            horaInter = horaLoc = horaLocD = False
        End If
        Try
            costoTotal = FormatCurrency(clase.costoLlamada(CDbl(minLoc), CDbl(minLocD), CDbl(minInter), horaLoc, horaLocD, horaInter),,, TriState.True, TriState.True)
            Label11.Text = costoTotal
        Catch ex As Exception
            MsgBox("Por favor ingrese un dato valido en los campo")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        Label11.Text = ""
    End Sub

    Private Sub Problema1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
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
End Class