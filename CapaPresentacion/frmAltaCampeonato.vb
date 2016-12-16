Imports CapaNegocio
Imports Entidades
Public Class frmAltaCampeonato
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim año As Integer
        Dim puntosSubCampeon As Integer
        Try
            año = Integer.Parse(txtAño.Text)
            puntosSubCampeon = Integer.Parse(txtTantosSubCampeon.Text)
        Catch ex As Exception
            MessageBox.Show("Error, el año y los tantos del subcampeon deben ser números...")
            Exit Sub
        End Try
        If año > Today.Year OrElse año < 1940 Then
            MessageBox.Show("Error, el año debe estar entre 1940 y el año actual")
            Exit Sub
        Else
            If puntosSubCampeon < 0 OrElse puntosSubCampeon > 21 Then
                MessageBox.Show("Error, el subcampeon debe tener entre 0 y 21 puntos")
                Exit Sub
            Else
                Dim campeonato As Campeonato = _negocio.CampeonatoDeUnAño(año)
                If Not IsNothing(campeonato) Then
                    MessageBox.Show("Error, el campeonato de " & año & "lo ganó " & campeonato.Campeon.Nombre & " jugando contra " &
                                    campeonato.SubCampeon.Nombre & " por 22 a " & campeonato.TantosSubCampeon & " en " & campeonato.Fronton.Id)
                    Exit Sub
                Else
                    Dim camp As Pelotari = _negocio.ObtenerPelotari(txtCampeon.Text)
                    Dim subCamp As Pelotari = _negocio.ObtenerPelotari(txtSubCampeon.Text)
                    Dim fronton As Fronton = _negocio.ObtenerFronton(txtFronton.Text)
                    If IsNothing(camp) OrElse IsNothing(subCamp) OrElse IsNothing(fronton) Then
                        MessageBox.Show("Error, alguno de los pelotaris o el fronton no estan registrados en nuestra base de datos")
                        Exit Sub
                    Else
                        _negocio.InsertarNuevoCampeonato(año, camp, subCamp, puntosSubCampeon, fronton)
                        MessageBox.Show("Campeonato añadido correctamente")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class