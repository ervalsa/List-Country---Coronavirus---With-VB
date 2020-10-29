Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cutomizeSubMenuPanel()

        Try
            FrmIndoData.TopLevel = False
            Me.PanelMainFrm.Controls.Add(FrmIndoData)
            FrmIndoData.Show()
        Catch ex As Exception
            MsgBox("There is a Problem!" & ex.Message)
        End Try
    End Sub
    'SubMenu Setting
    Private Sub cutomizeSubMenuPanel()
        PanelDataSubMenu.Visible = False
    End Sub
    Private Sub hideSubMenu()
        If PanelDataSubMenu.Visible = True Then
            PanelDataSubMenu.Visible = False
        End If
    End Sub
    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub
    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles BtnData.Click
        showSubMenu(PanelDataSubMenu)
    End Sub

    Private Sub BtnIndoData_Click(sender As Object, e As EventArgs) Handles BtnIndoData.Click
        hideSubMenu()

        Try
            FrmIndoData.TopLevel = False
            Me.PanelMainFrm.Controls.Add(FrmIndoData)
            FrmIndoData.Show()

            FrmGlobalData.Close()
            FrmGetKnow.Close()
            FrmAbout.Close()
            FrmHelpCenter.Close()
        Catch ex As Exception
            MsgBox("There is a Problem!" & ex.Message)
        End Try
    End Sub

    Private Sub BtnGlobalData_Click(sender As Object, e As EventArgs) Handles BtnGlobalData.Click
        hideSubMenu()

        Try
            FrmGlobalData.TopLevel = False
            Me.PanelMainFrm.Controls.Add(FrmGlobalData)
            FrmGlobalData.Show()

            FrmIndoData.Close()
            FrmAbout.Close()
            FrmHelpCenter.Close()
            FrmGetKnow.Close()
        Catch ex As Exception
            MsgBox("There is a Problem!" & ex.Message)
        End Try
    End Sub
    'End SubMenu Setting
    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Application.Exit()
    End Sub

    Private Sub BtnGetKnow_Click(sender As Object, e As EventArgs) Handles BtnGetKnow.Click
        Try
            FrmGetKnow.TopLevel = False
            Me.PanelMainFrm.Controls.Add(FrmGetKnow)
            FrmGetKnow.Show()

            FrmIndoData.Close()
            FrmGlobalData.Close()
            FrmAbout.Close()
            FrmHelpCenter.Close()
        Catch ex As Exception
            MsgBox("There is a Problem!" & ex.Message)
        End Try
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Try
            FrmAbout.TopLevel = False
            Me.PanelMainFrm.Controls.Add(FrmAbout)
            FrmAbout.Show()

            FrmIndoData.Close()
            FrmGlobalData.Close()
            FrmGetKnow.Close()
            FrmHelpCenter.Close()
        Catch ex As Exception
            MsgBox("There is a Problem!" & ex.Message)
        End Try
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        Try
            FrmHelpCenter.TopLevel = False
            Me.PanelMainFrm.Controls.Add(FrmHelpCenter)
            FrmHelpCenter.Show()

            FrmIndoData.Close()
            FrmGlobalData.Close()
            FrmGetKnow.Close()
            FrmAbout.Close()
        Catch ex As Exception
            MsgBox("There is a Problem!" & ex.Message)
        End Try
    End Sub
End Class
