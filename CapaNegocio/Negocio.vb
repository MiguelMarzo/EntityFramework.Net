Imports System.Collections.ObjectModel
Imports CapaDatos
Imports Entidades

Public Class Negocio
    Private _datos As New Datos
    Public Function ObtenerPelotari(idPelotari As String) As Pelotari
        Return _datos.ObtenerPelotari(idPelotari)
    End Function

    Public Function CampeonatosDePelotari(pelotari As Pelotari) As List(Of Campeonato)
        Return _datos.CampeonatosDePelotari(pelotari)
    End Function

    Public Function ObtenerProvincia(provincia As String) As Provincia
        Return _datos.ObtenerProvincia(provincia)
    End Function

    Public Function CampeonatosConGanadoresDeProvincia(provincia As Provincia) As List(Of Campeonato)
        Return _datos.CampeonatosConGanadoresDeProvincia(provincia)
    End Function

    Public Function CampeonatoDeUnAño(año As Integer) As Campeonato
        Return _datos.CampeonatoDeUnAño(año)
    End Function

    Public Function ObtenerFronton(id As String) As Fronton
        Return _datos.ObtenerFronton(id)
    End Function

    Public Sub InsertarNuevoCampeonato(año As Integer, camp As Pelotari, subCamp As Pelotari, puntosSubCampeon As Integer, fronton As Fronton)
        _datos.InsertarNuevoCampeonato(año, camp, subCamp, puntosSubCampeon, fronton)
    End Sub
End Class
