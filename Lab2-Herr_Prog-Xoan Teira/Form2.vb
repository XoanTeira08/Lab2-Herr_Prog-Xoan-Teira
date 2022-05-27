Public Class Form2
    Dim clase As New ClaseProblema1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '####################### BOTONES MENUSTRIP #########################################'
    Private Sub VolverAPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAPrincipalToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Problema2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNoCancel, "Pregunta") = vbYes Then
            End
        End If
    End Sub
    '########################################################################'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim horas = TextBox1.Text, salario As String
        If TextBox1.Text = "" Then 'Comprueba que el campo no este vacio'
            MsgBox("Por favor ingrese un dato valido en el campo")
        ElseIf InStr(horas, ".", CompareMethod.Text) <> 0 Or InStr(horas, ",", CompareMethod.Text) <> 0 Or InStr(horas, "-", CompareMethod.Text) <> 0 Then 'Compara si el String tiene , o . para si es decimal'
            MsgBox("Por politicas de la empresa solamente se pueden aceptar valores enteros como hora validad")
        Else
            Try
                salario = FormatCurrency(clase.salarioTrabajador(CInt(horas)),,, TriState.True, TriState.True)
                Label4.Text = salario
            Catch ex As Exception
                MsgBox("Por favor ingrese un dato valido en el campo")
            End Try

        End If



    End Sub
    '########################### BOTON LIMPIAR ########################'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label4.Text = ""
    End Sub

    Private Sub Problema4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema4ToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Problema3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Problema3ToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()

    End Sub
    '##########################################

End Class