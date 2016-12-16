Imports CapaNegocio
Imports Entidades

Public Class frmCampeones
    Private _negocio As New Negocio
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

    End Sub

    Private Sub btnAltaCampeonato_Click(sender As Object, e As EventArgs) Handles btnAltaCampeonato.Click
        frmAltaCampeonato.Show()
    End Sub
End Class
