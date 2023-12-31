﻿Imports System.Data.Odbc

Public Class ClsCtlKategori : Implements InfProses

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntKategori
        data = Ob
        CMD = New OdbcCommand("insert into kategori values('" & data.IdKategori & "','" & data.NamaKategori & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntKategori
        data = Ob
        CMD = New OdbcCommand("update kategori set namakategori ='" & data.NamaKategori & "'where idkategori='" & data.IdKategori & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProses.deleteData
        CMD = New OdbcCommand("delete from kategori" & "where idkategori='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from kategori", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kategori")
            Dim grid As New DataView(DTS.Tables("Tabel_Kategori"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function kodebaru() As String
        Dim baru As String
        Dim kodeAkhir As Integer

        Try
            DTA = New OdbcDataAdapter("select max(right(idkategori, 3))from kategori", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeAkhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KT" & Strings.Right("00" & kodeAkhir + 1, 3)
            Return baru
        Catch ex As Exception

        End Try
    End Function

    Function CekKategoriDirefernsi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OdbcDataAdapter("select count(id_Menu)) from Detail_Jual" & "where id_menu=" & kunci & "", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
