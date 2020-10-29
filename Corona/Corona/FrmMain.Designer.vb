<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PnlSideMenu = New System.Windows.Forms.Panel()
        Me.BtnAbout = New FontAwesome.Sharp.IconButton()
        Me.BtnHelp = New FontAwesome.Sharp.IconButton()
        Me.BtnGetKnow = New FontAwesome.Sharp.IconButton()
        Me.BtnLogout = New FontAwesome.Sharp.IconButton()
        Me.PanelDataSubMenu = New System.Windows.Forms.Panel()
        Me.BtnGlobalData = New FontAwesome.Sharp.IconButton()
        Me.BtnIndoData = New FontAwesome.Sharp.IconButton()
        Me.BtnData = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMainFrm = New System.Windows.Forms.Panel()
        Me.PnlSideMenu.SuspendLayout()
        Me.PanelDataSubMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlSideMenu
        '
        Me.PnlSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.PnlSideMenu.Controls.Add(Me.BtnAbout)
        Me.PnlSideMenu.Controls.Add(Me.BtnHelp)
        Me.PnlSideMenu.Controls.Add(Me.BtnGetKnow)
        Me.PnlSideMenu.Controls.Add(Me.BtnLogout)
        Me.PnlSideMenu.Controls.Add(Me.PanelDataSubMenu)
        Me.PnlSideMenu.Controls.Add(Me.BtnData)
        Me.PnlSideMenu.Controls.Add(Me.Panel3)
        Me.PnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnlSideMenu.Name = "PnlSideMenu"
        Me.PnlSideMenu.Size = New System.Drawing.Size(172, 501)
        Me.PnlSideMenu.TabIndex = 0
        '
        'BtnAbout
        '
        Me.BtnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAbout.FlatAppearance.BorderSize = 0
        Me.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAbout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbout.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.BtnAbout.IconColor = System.Drawing.Color.GhostWhite
        Me.BtnAbout.IconSize = 20
        Me.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAbout.Location = New System.Drawing.Point(0, 272)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnAbout.Rotation = 0R
        Me.BtnAbout.Size = New System.Drawing.Size(172, 40)
        Me.BtnAbout.TabIndex = 14
        Me.BtnAbout.Text = "  About"
        Me.BtnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'BtnHelp
        '
        Me.BtnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHelp.FlatAppearance.BorderSize = 0
        Me.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnHelp.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHelp.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnHelp.IconChar = FontAwesome.Sharp.IconChar.Hospital
        Me.BtnHelp.IconColor = System.Drawing.Color.GhostWhite
        Me.BtnHelp.IconSize = 20
        Me.BtnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHelp.Location = New System.Drawing.Point(0, 232)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnHelp.Rotation = 0R
        Me.BtnHelp.Size = New System.Drawing.Size(172, 40)
        Me.BtnHelp.TabIndex = 13
        Me.BtnHelp.Text = "  Help Center"
        Me.BtnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHelp.UseVisualStyleBackColor = True
        '
        'BtnGetKnow
        '
        Me.BtnGetKnow.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGetKnow.FlatAppearance.BorderSize = 0
        Me.BtnGetKnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGetKnow.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnGetKnow.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetKnow.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnGetKnow.IconChar = FontAwesome.Sharp.IconChar.Question
        Me.BtnGetKnow.IconColor = System.Drawing.Color.GhostWhite
        Me.BtnGetKnow.IconSize = 20
        Me.BtnGetKnow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetKnow.Location = New System.Drawing.Point(0, 192)
        Me.BtnGetKnow.Name = "BtnGetKnow"
        Me.BtnGetKnow.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnGetKnow.Rotation = 0R
        Me.BtnGetKnow.Size = New System.Drawing.Size(172, 40)
        Me.BtnGetKnow.TabIndex = 12
        Me.BtnGetKnow.Text = "  Get to know"
        Me.BtnGetKnow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGetKnow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGetKnow.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.BtnLogout.IconColor = System.Drawing.Color.GhostWhite
        Me.BtnLogout.IconSize = 20
        Me.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Location = New System.Drawing.Point(0, 461)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnLogout.Rotation = 0R
        Me.BtnLogout.Size = New System.Drawing.Size(172, 40)
        Me.BtnLogout.TabIndex = 11
        Me.BtnLogout.Text = "  Logout"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'PanelDataSubMenu
        '
        Me.PanelDataSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.PanelDataSubMenu.Controls.Add(Me.BtnGlobalData)
        Me.PanelDataSubMenu.Controls.Add(Me.BtnIndoData)
        Me.PanelDataSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDataSubMenu.Location = New System.Drawing.Point(0, 111)
        Me.PanelDataSubMenu.Name = "PanelDataSubMenu"
        Me.PanelDataSubMenu.Size = New System.Drawing.Size(172, 81)
        Me.PanelDataSubMenu.TabIndex = 9
        '
        'BtnGlobalData
        '
        Me.BtnGlobalData.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGlobalData.FlatAppearance.BorderSize = 0
        Me.BtnGlobalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGlobalData.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnGlobalData.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGlobalData.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnGlobalData.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnGlobalData.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnGlobalData.IconSize = 28
        Me.BtnGlobalData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGlobalData.Location = New System.Drawing.Point(0, 40)
        Me.BtnGlobalData.Name = "BtnGlobalData"
        Me.BtnGlobalData.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnGlobalData.Rotation = 0R
        Me.BtnGlobalData.Size = New System.Drawing.Size(172, 40)
        Me.BtnGlobalData.TabIndex = 12
        Me.BtnGlobalData.Text = "World Data"
        Me.BtnGlobalData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGlobalData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGlobalData.UseVisualStyleBackColor = True
        '
        'BtnIndoData
        '
        Me.BtnIndoData.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnIndoData.FlatAppearance.BorderSize = 0
        Me.BtnIndoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIndoData.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnIndoData.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIndoData.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnIndoData.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnIndoData.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnIndoData.IconSize = 28
        Me.BtnIndoData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIndoData.Location = New System.Drawing.Point(0, 0)
        Me.BtnIndoData.Name = "BtnIndoData"
        Me.BtnIndoData.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnIndoData.Rotation = 0R
        Me.BtnIndoData.Size = New System.Drawing.Size(172, 40)
        Me.BtnIndoData.TabIndex = 11
        Me.BtnIndoData.Text = "Indonesian Data"
        Me.BtnIndoData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIndoData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIndoData.UseVisualStyleBackColor = True
        '
        'BtnData
        '
        Me.BtnData.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BtnData.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnData.FlatAppearance.BorderSize = 0
        Me.BtnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnData.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnData.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnData.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnData.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.BtnData.IconColor = System.Drawing.Color.GhostWhite
        Me.BtnData.IconSize = 20
        Me.BtnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnData.Location = New System.Drawing.Point(0, 71)
        Me.BtnData.Name = "BtnData"
        Me.BtnData.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BtnData.Rotation = 0R
        Me.BtnData.Size = New System.Drawing.Size(172, 40)
        Me.BtnData.TabIndex = 1
        Me.BtnData.Text = "  Covid-19 Data"
        Me.BtnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnData.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(172, 71)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 30.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, -27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 48)
        Me.Label2.TabIndex = 1
        '
        'PanelMainFrm
        '
        Me.PanelMainFrm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainFrm.Location = New System.Drawing.Point(172, 0)
        Me.PanelMainFrm.Name = "PanelMainFrm"
        Me.PanelMainFrm.Size = New System.Drawing.Size(732, 501)
        Me.PanelMainFrm.TabIndex = 1
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(904, 501)
        Me.Controls.Add(Me.PanelMainFrm)
        Me.Controls.Add(Me.PnlSideMenu)
        Me.MaximumSize = New System.Drawing.Size(920, 540)
        Me.MinimumSize = New System.Drawing.Size(920, 540)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PnlSideMenu.ResumeLayout(False)
        Me.PanelDataSubMenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlSideMenu As Panel
    Friend WithEvents BtnData As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAbout As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnHelp As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnGetKnow As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDataSubMenu As Panel
    Friend WithEvents BtnGlobalData As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnIndoData As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMainFrm As Panel
End Class
