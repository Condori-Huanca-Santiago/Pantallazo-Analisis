Public Class Turnos
    Dim Contador2c
    Private Sub Confirmar_Boton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirmar_Boton2.Click
        If ID_Turno_T1.Text <> "" Then
            Contador2c += 1
        End If
        If ID_paciente_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Fecha_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Horario_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Tipo_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Contador2c > 1 Then
            Contador2c = 0
        Else
            AdvertenciaEl.Show()
        End If
    End Sub
    Private Sub Confirmar_Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirmar_Boton1.Click
        If (ID_Paciente_T1.Text <> "") And (Fecha_T1.Text <> "") And (Horario_T1.Text <> "") And (Tipo_T1.Text <> "") Then

        Else
            Agr_Advertencia.Show()
        End If
    End Sub
End Class