﻿Imports System.Collections.ObjectModel
Imports CapaDatos
Imports Entidades

Public Class Negocio
    Private _datos As New Datos
    Public Function ObtenerPelotari(idPelotari As String) As Pelotari
        Return _datos.ObtenerPelotari(idPelotari)
    End Function

End Class