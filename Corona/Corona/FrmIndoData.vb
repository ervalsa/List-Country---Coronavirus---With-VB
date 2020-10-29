Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net
Public Class FrmIndoData
    Private Sub FrmIndoData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CoronaIndonesian()
        CoronaIndonesianDetail()
    End Sub
    Private Sub CoronaIndonesian()
        Dim json As String = (New WebClient).DownloadString("https://api.kawalcorona.com/indonesia/")
        Dim jarr As Linq.JArray = Linq.JArray.Parse(json)
        For Each jtk As JToken In jarr
            LblTotalCases.Text = jtk.SelectToken("positif")
            LblTotalRecovered.Text = jtk.SelectToken("sembuh")
            LblTotalDeaths.Text = jtk.SelectToken("meninggal")
        Next
    End Sub
    Private Sub CoronaIndonesianDetail()
        Dim json As String = (New WebClient).DownloadString("https://api.kawalcorona.com/indonesia/provinsi/")
        Dim jarr As Linq.JArray = Linq.JArray.Parse(json)
            Dim Province, Cases, Recovered, Deaths As String
            For Each jtk As JToken In jarr
                Province = jtk.SelectToken("attributes.Provinsi")
                Cases = jtk.SelectToken("attributes.Kasus_Posi")
                Recovered = jtk.SelectToken("attributes.Kasus_Semb")
                Deaths = jtk.SelectToken("attributes.Kasus_Meni")

                DGVIndonesian.Rows.Add()
                DGVIndonesian.Rows(DGVIndonesian.Rows.Count - 1).Cells(1).Value = Province
                DGVIndonesian.Rows(DGVIndonesian.Rows.Count - 1).Cells(2).Value = Cases
                DGVIndonesian.Rows(DGVIndonesian.Rows.Count - 1).Cells(3).Value = Recovered
                DGVIndonesian.Rows(DGVIndonesian.Rows.Count - 1).Cells(4).Value = Deaths
            Next

            Dim row As Integer = 0
        For row = 0 To DGVIndonesian.RowCount - 1
            DGVIndonesian.Rows(row).Cells(0).Value = row + 1
        Next
    End Sub

End Class