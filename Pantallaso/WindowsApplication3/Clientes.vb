Public Class Clientes
    Dim Contador2c
    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_Paciente_T2.TextChanged

    End Sub

    Private Sub Boton_Confirmar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Confirmar2.Click
        If ID_Paciente_T1.Text <> "" Then
            Contador2c += 1
        End If
        If Nombre_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Apellido_T2.Text <> "" Then
            Contador2c += 1
        End If
        If DNI_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Telefono_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Direccion_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Obra_social_T2.Text <> "" Then
            Contador2c += 1
        End If
        If Contador2c > 1 Then
            Contador2c = 0
        Else
            AdvertenciaEl.Show()
        End If

    End Sub

    Private Sub Boton_Confirmar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Confirmar1.Click
        If (Nombre_T1.Text <> "") And (Apellido_T1.Text <> "") And (DNI_T1.Text <> "") And (Telefono_T1.Text <> "") And (Direccion_T1.Text <> "") And (Obra_social_T1.Text <> "") Then

        Else
            Agr_Advertencia.Show()
        End If
    End Sub
End Class