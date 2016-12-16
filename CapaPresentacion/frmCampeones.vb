Imports CapaNegocio
Imports Entidades

Public Class frmCampeones
    Private _negocio As New Negocio
    Private Sub btnCampeonatosPelotari_Click(sender As Object, e As EventArgs) Handles btnCampeonatosPelotari.Click
        Dim pelotari As Pelotari = _negocio.ObtenerPelotari("Artola")
        pelotari = pelotari
    End Sub
End Class
