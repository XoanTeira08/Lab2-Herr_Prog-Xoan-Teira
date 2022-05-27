Public Class ClaseProblema1
    Public Function salarioTrabajador(ByVal horas)
        Dim salario As Double
        If horas <= 35 Then
            salario = 15.0 * horas
            Return salario
        ElseIf horas > 35 Then
            salario = (horas - 35) * 22.5
            Return salario
        End If
    End Function

    Public Function calculoDeuda(ByVal monto, ByVal tiempo)
        Dim deuda, interes As Double
        If tiempo < 30 Then
            interes = 0
            Return deuda
        ElseIf tiempo >= 30 Or tiempo <= 60 Then
            interes = 1.02
        ElseIf tiempo >= 61 Or tiempo <= 90 Then
            interes = 1.05
        ElseIf tiempo >= 91 Or tiempo <= 129 Then
            interes = 1.07
        ElseIf tiempo > 129 Then
            interes = 1.15
        End If
        deuda = (monto * interes) + monto
        Return deuda
    End Function
    Public Function importeVehiculo(ByVal tipoVe, ByVal Km, ByVal Tone)
        Dim importe As Double
        Select Case tipoVe
            Case 1
                importe = 100
                Return importe
            Case 2
                importe = Km * 30
                Return importe
            Case 3
                importe = (Km * 30) + (Tone * 25)
                Return importe
        End Select
    End Function
    Public Function costoLlamada(ByVal minLoc, ByVal minLocD, ByVal minInter, ByVal horaLoc, ByVal horaLocD, ByVal horaInter)
        Dim costoLoc, costoLocD, costoInter, costoTotal As Double
        minLoc = minLoc - 10
        costoLoc = minLoc * 0.03
        costoLocD = minLocD * 0.06
        costoInter = minInter * 0.1
        If horaLoc = True Then
            costoLoc = costoLoc * 2
        ElseIf horaLocD = True Then
            costoLocD = costoLocD * 2
        ElseIf horaInter = True Then
            costoInter = costoInter * 2
        End If
        costoTotal = costoLoc + costoLocD + costoInter
        Return costoTotal

    End Function


End Class
