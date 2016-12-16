Imports CapaNegocio
Imports Entidades

Public Class frmCampeones
    Private Sub btnCampeonatosPelotari_Click(sender As Object, e As EventArgs) Handles btnCampeonatosPelotari.Click
        Dim pelotari As Pelotari = _negocio.ObtenerPelotari(txtPelotari.Text)

        If IsNothing(pelotari) Then
            MessageBox.Show("Error, el pelotari " & txtPelotari.Text & " no existe o no está registrado en nuestra base de datos")
            Exit Sub
        Else
            Dim campeonatos As List(Of Campeonato) = _negocio.CampeonatosDePelotari(pelotari)
            If campeonatos.Count = 0 Then
                MessageBox.Show("Error, el pelotari " & pelotari.Nombre & " no ha participado en ningún campeonato")
            Else
                dgvCampeonatos.DataSource = campeonatos
            End If
        End If
    End Sub

    Private Sub btnCampeonatosProvincia_Click(sender As Object, e As EventArgs) Handles btnCampeonatosProvincia.Click
        Dim provincia As Provincia = _negocio.ObtenerProvincia(txtNombreProvincia.Text)
        If IsNothing(provincia) Then
            MessageBox.Show("Error, no tenemos ninguna provincia registrada con el nombre " & txtNombreProvincia.Text)
            Exit Sub
        Else
            If provincia.Pelotaris.Count = 0 Then
                MessageBox.Show("Error, no hay ningún pelotari en " & provincia.Nombre)
                Exit Sub
            Else
                Dim campeonatos As List(Of Campeonato) = _negocio.CampeonatosConGanadoresDeProvincia(provincia)
                If campeonatos.Count = 0 Then
                    MessageBox.Show("De los " & provincia.Pelotaris.Count & " pelotaris registrados de " & provincia.Nombre & " ninguno ha llegado a la final")
                    Exit Sub
                Else
                    dgvCampeonatos.DataSource = campeonatos
                End If
            End If
        End If
    End Sub

    Private Sub btnAltaCampeonato_Click(sender As Object, e As EventArgs) Handles btnAltaCampeonato.Click
        frmAltaCampeonato.Show()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Me.Close()
    End Sub
End Class
