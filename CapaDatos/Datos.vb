Imports System.Collections.ObjectModel
Imports Entidades

Public Class Datos
    Private contexto As CampeonatosPelotaEntities
    Sub New()
        contexto = New CampeonatosPelotaEntities
    End Sub
    Public Function ObtenerPelotari(idPelotari As String) As Pelotari
        Dim pelotaria As Pelotari = contexto.Pelotaris.SingleOrDefault(Function(pel) pel.Id.ToUpper = idPelotari.ToUpper)

        'pelotaria = (From pel As Pelotari In contexto.Pelotaris
        '             Where pel.Id.ToUpper = idPelotari.ToUpper
        '             Select pel).SingleOrDefault

        Return pelotaria
    End Function
    Public Function CampeonatosDePelotari(pelotari As Pelotari) As List(Of Campeonato)
        Dim campeonatos = From cmp In contexto.Campeonatos
                          Where cmp.IdCampeon.ToUpper = pelotari.Id.ToUpper Or cmp.IdSubCampeon.ToUpper = pelotari.Id.ToUpper
                          Select cmp

        Return campeonatos.ToList
    End Function

    Public Function ObtenerProvincia(nombreProvincia As String) As Provincia
        Dim provincia As Provincia = contexto.Provincias.SingleOrDefault(Function(prov) prov.Nombre.ToUpper = nombreProvincia.ToUpper)
        Return provincia
    End Function

    Public Function CampeonatosConGanadoresDeProvincia(provincia As Provincia) As List(Of Campeonato)
        Dim campeonatos = From cmp In contexto.Campeonatos
                          Where cmp.Campeon.IdProvincia = provincia.Id
                          Select cmp

        Return campeonatos.ToList
    End Function
End Class
