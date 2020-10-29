Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class FrmGlobalData
    Private Sub FrmGlobalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CoronaGlobalCases()
        CoronaGlobalRecovered()
        CoronaGlobalDeaths()

        CoronaGlobalDetail()
    End Sub
    Private Sub CoronaGlobalCases()
        Dim json As String = (New WebClient).DownloadString("https://api.kawalcorona.com/positif/")
        Dim jarr As Linq.JArray = Linq.JArray.Parse("[" & json & "]")
        For Each jtk As JToken In jarr
                LblTotalCases.Text = jtk.SelectToken("value")
            Next

    End Sub
    Private Sub CoronaGlobalRecovered()
        Dim json As String = (New WebClient).DownloadString("https://api.kawalcorona.com/sembuh/")

        Dim jarr As Linq.JArray = Linq.JArray.Parse("[" & json & "]")
        For Each jtk As JToken In jarr
            LblTotalRecovered.Text = jtk.SelectToken("value")
        Next
    End Sub
    Private Sub CoronaGlobalDeaths()
        Dim json As String = (New WebClient).DownloadString("https://api.kawalcorona.com/meninggal/")
        Dim jarr As Linq.JArray = Linq.JArray.Parse("[" & json & "]")
            For Each jtk As JToken In jarr
                LblTotalDeaths.Text = jtk.SelectToken("value")
            Next

    End Sub
    Private Sub CoronaGlobalDetail()
        Dim json As String = (New WebClient).DownloadString("https://api.kawalcorona.com/all")

        Dim jarr As Linq.JArray = Linq.JArray.Parse(json)
            Dim Province, Cases, Recovered, Deaths As String
            For Each jtk As JToken In jarr
                Province = jtk.SelectToken("attributes.Country_Region")
                Cases = jtk.SelectToken("attributes.Confirmed")
                Recovered = jtk.SelectToken("attributes.Recovered")
                Deaths = jtk.SelectToken("attributes.Deaths")

                DGVGlobal.Rows.Add()
                DGVGlobal.Rows(DGVGlobal.Rows.Count - 1).Cells(1).Value = Province
                DGVGlobal.Rows(DGVGlobal.Rows.Count - 1).Cells(2).Value = Val(Cases)
                DGVGlobal.Rows(DGVGlobal.Rows.Count - 1).Cells(3).Value = Val(Recovered)
                DGVGlobal.Rows(DGVGlobal.Rows.Count - 1).Cells(4).Value = Val(Deaths)
            Next

            Dim row As Integer = 0
            For row = 0 To DGVGlobal.RowCount - 1
                DGVGlobal.Rows(row).Cells(0).Value = row + 1
            Next

    End Sub

End Class