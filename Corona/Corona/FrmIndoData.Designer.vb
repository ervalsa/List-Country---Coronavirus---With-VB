<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndoData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotalCases = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblTotalRecovered = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblTotalDeaths = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DGVIndonesian = New System.Windows.Forms.DataGridView()
        Me.DgvIndoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvIndoProvince = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvIndoCases = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvIndoRecovered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvIndoDeaths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVIndonesian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LblTotalCases)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(31, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 116)
        Me.Panel1.TabIndex = 0
        '
        'LblTotalCases
        '
        Me.LblTotalCases.AutoSize = True
        Me.LblTotalCases.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalCases.ForeColor = System.Drawing.Color.Black
        Me.LblTotalCases.Location = New System.Drawing.Point(10, 44)
        Me.LblTotalCases.Name = "LblTotalCases"
        Me.LblTotalCases.Size = New System.Drawing.Size(25, 28)
        Me.LblTotalCases.TabIndex = 3
        Me.LblTotalCases.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Cases"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(31, 168)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 25)
        Me.Panel5.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LblTotalRecovered)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(266, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 116)
        Me.Panel2.TabIndex = 1
        '
        'LblTotalRecovered
        '
        Me.LblTotalRecovered.AutoSize = True
        Me.LblTotalRecovered.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalRecovered.ForeColor = System.Drawing.Color.Black
        Me.LblTotalRecovered.Location = New System.Drawing.Point(10, 44)
        Me.LblTotalRecovered.Name = "LblTotalRecovered"
        Me.LblTotalRecovered.Size = New System.Drawing.Size(25, 28)
        Me.LblTotalRecovered.TabIndex = 4
        Me.LblTotalRecovered.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Recovered"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 91)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 25)
        Me.Panel6.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.LblTotalDeaths)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(502, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 116)
        Me.Panel3.TabIndex = 2
        '
        'LblTotalDeaths
        '
        Me.LblTotalDeaths.AutoSize = True
        Me.LblTotalDeaths.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDeaths.ForeColor = System.Drawing.Color.Black
        Me.LblTotalDeaths.Location = New System.Drawing.Point(10, 44)
        Me.LblTotalDeaths.Name = "LblTotalDeaths"
        Me.LblTotalDeaths.Size = New System.Drawing.Size(25, 28)
        Me.LblTotalDeaths.TabIndex = 5
        Me.LblTotalDeaths.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Deaths"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 91)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 25)
        Me.Panel7.TabIndex = 3
        '
        'DGVIndonesian
        '
        Me.DGVIndonesian.AllowUserToAddRows = False
        Me.DGVIndonesian.AllowUserToDeleteRows = False
        Me.DGVIndonesian.AllowUserToResizeColumns = False
        Me.DGVIndonesian.AllowUserToResizeRows = False
        Me.DGVIndonesian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVIndonesian.BackgroundColor = System.Drawing.Color.White
        Me.DGVIndonesian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVIndonesian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVIndonesian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVIndonesian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVIndonesian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvIndoNo, Me.DgvIndoProvince, Me.DgvIndoCases, Me.DgvIndoRecovered, Me.DgvIndoDeaths})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVIndonesian.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVIndonesian.EnableHeadersVisualStyles = False
        Me.DGVIndonesian.Location = New System.Drawing.Point(31, 212)
        Me.DGVIndonesian.MultiSelect = False
        Me.DGVIndonesian.Name = "DGVIndonesian"
        Me.DGVIndonesian.ReadOnly = True
        Me.DGVIndonesian.RowHeadersVisible = False
        Me.DGVIndonesian.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVIndonesian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVIndonesian.Size = New System.Drawing.Size(671, 270)
        Me.DGVIndonesian.TabIndex = 0
        '
        'DgvIndoNo
        '
        Me.DgvIndoNo.FillWeight = 38.07107!
        Me.DgvIndoNo.HeaderText = "No"
        Me.DgvIndoNo.Name = "DgvIndoNo"
        Me.DgvIndoNo.ReadOnly = True
        '
        'DgvIndoProvince
        '
        Me.DgvIndoProvince.FillWeight = 115.4822!
        Me.DgvIndoProvince.HeaderText = "Province"
        Me.DgvIndoProvince.Name = "DgvIndoProvince"
        Me.DgvIndoProvince.ReadOnly = True
        '
        'DgvIndoCases
        '
        Me.DgvIndoCases.FillWeight = 115.4822!
        Me.DgvIndoCases.HeaderText = "Cases"
        Me.DgvIndoCases.Name = "DgvIndoCases"
        Me.DgvIndoCases.ReadOnly = True
        '
        'DgvIndoRecovered
        '
        Me.DgvIndoRecovered.FillWeight = 115.4822!
        Me.DgvIndoRecovered.HeaderText = "Recovered"
        Me.DgvIndoRecovered.Name = "DgvIndoRecovered"
        Me.DgvIndoRecovered.ReadOnly = True
        '
        'DgvIndoDeaths
        '
        Me.DgvIndoDeaths.FillWeight = 115.4822!
        Me.DgvIndoDeaths.HeaderText = "Deaths"
        Me.DgvIndoDeaths.Name = "DgvIndoDeaths"
        Me.DgvIndoDeaths.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(2, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(323, 30)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Covid-19 Indonesian Data"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(31, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 35)
        Me.Panel4.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(31, 74)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 5)
        Me.Panel8.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(266, 74)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 5)
        Me.Panel9.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(502, 74)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(200, 5)
        Me.Panel10.TabIndex = 6
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.Label11)
        Me.Panel11.Location = New System.Drawing.Point(31, 12)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(326, 35)
        Me.Panel11.TabIndex = 6
        '
        'FrmIndoData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 501)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DGVIndonesian)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(732, 501)
        Me.MinimumSize = New System.Drawing.Size(732, 501)
        Me.Name = "FrmIndoData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmIndoData"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVIndonesian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LblTotalCases As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblTotalRecovered As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTotalDeaths As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVIndonesian As DataGridView
    Friend WithEvents DgvIndoNo As DataGridViewTextBoxColumn
    Friend WithEvents DgvIndoProvince As DataGridViewTextBoxColumn
    Friend WithEvents DgvIndoCases As DataGridViewTextBoxColumn
    Friend WithEvents DgvIndoRecovered As DataGridViewTextBoxColumn
    Friend WithEvents DgvIndoDeaths As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
End Class
