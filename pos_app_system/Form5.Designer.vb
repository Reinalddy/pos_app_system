<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penerimaan
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
        Me.TxtBoxName = New System.Windows.Forms.TextBox()
        Me.LBLNomor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TKode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TNama = New System.Windows.Forms.TextBox()
        Me.TStok = New System.Windows.Forms.TextBox()
        Me.TTerima = New System.Windows.Forms.TextBox()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.TxtBoxTanggal = New System.Windows.Forms.TextBox()
        Me.LBLNama = New System.Windows.Forms.Label()
        Me.TxtBoxNama = New System.Windows.Forms.TextBox()
        Me.NomorReff = New System.Windows.Forms.TextBox()
        Me.LBLPerson = New System.Windows.Forms.Label()
        Me.TxtBoxPerson = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TotalTerima = New System.Windows.Forms.Label()
        Me.TxtBoxTotalTerima = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBoxName
        '
        Me.TxtBoxName.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBoxName.Location = New System.Drawing.Point(119, 16)
        Me.TxtBoxName.Name = "TxtBoxName"
        Me.TxtBoxName.Size = New System.Drawing.Size(121, 20)
        Me.TxtBoxName.TabIndex = 0
        '
        'LBLNomor
        '
        Me.LBLNomor.AutoSize = True
        Me.LBLNomor.Location = New System.Drawing.Point(120, 19)
        Me.LBLNomor.Name = "LBLNomor"
        Me.LBLNomor.Size = New System.Drawing.Size(0, 13)
        Me.LBLNomor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kode Pemasok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contact Person"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama Pemasok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nomor Reff"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(119, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'TKode
        '
        Me.TKode.Location = New System.Drawing.Point(58, 120)
        Me.TKode.Name = "TKode"
        Me.TKode.Size = New System.Drawing.Size(52, 20)
        Me.TKode.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(178, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Tutup"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(123, 120)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(261, 20)
        Me.TNama.TabIndex = 13
        '
        'TStok
        '
        Me.TStok.Location = New System.Drawing.Point(401, 120)
        Me.TStok.Name = "TStok"
        Me.TStok.Size = New System.Drawing.Size(69, 20)
        Me.TStok.TabIndex = 14
        '
        'TTerima
        '
        Me.TTerima.Location = New System.Drawing.Point(484, 119)
        Me.TTerima.Name = "TTerima"
        Me.TTerima.Size = New System.Drawing.Size(82, 20)
        Me.TTerima.TabIndex = 15
        '
        'LBLTanggal
        '
        Me.LBLTanggal.AutoSize = True
        Me.LBLTanggal.Location = New System.Drawing.Point(414, 19)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(0, 13)
        Me.LBLTanggal.TabIndex = 17
        '
        'TxtBoxTanggal
        '
        Me.TxtBoxTanggal.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBoxTanggal.Location = New System.Drawing.Point(413, 16)
        Me.TxtBoxTanggal.Name = "TxtBoxTanggal"
        Me.TxtBoxTanggal.Size = New System.Drawing.Size(154, 20)
        Me.TxtBoxTanggal.TabIndex = 16
        '
        'LBLNama
        '
        Me.LBLNama.AutoSize = True
        Me.LBLNama.Location = New System.Drawing.Point(414, 54)
        Me.LBLNama.Name = "LBLNama"
        Me.LBLNama.Size = New System.Drawing.Size(0, 13)
        Me.LBLNama.TabIndex = 19
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBoxNama.Location = New System.Drawing.Point(413, 51)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(154, 20)
        Me.TxtBoxNama.TabIndex = 18
        '
        'NomorReff
        '
        Me.NomorReff.Location = New System.Drawing.Point(413, 85)
        Me.NomorReff.Name = "NomorReff"
        Me.NomorReff.Size = New System.Drawing.Size(154, 20)
        Me.NomorReff.TabIndex = 20
        '
        'LBLPerson
        '
        Me.LBLPerson.AutoSize = True
        Me.LBLPerson.Location = New System.Drawing.Point(120, 88)
        Me.LBLPerson.Name = "LBLPerson"
        Me.LBLPerson.Size = New System.Drawing.Size(0, 13)
        Me.LBLPerson.TabIndex = 22
        '
        'TxtBoxPerson
        '
        Me.TxtBoxPerson.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBoxPerson.Location = New System.Drawing.Point(119, 85)
        Me.TxtBoxPerson.Name = "TxtBoxPerson"
        Me.TxtBoxPerson.Size = New System.Drawing.Size(121, 20)
        Me.TxtBoxPerson.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 117)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "....."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(16, 146)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(550, 150)
        Me.DGV.TabIndex = 24
        '
        'TotalTerima
        '
        Me.TotalTerima.AutoSize = True
        Me.TotalTerima.Location = New System.Drawing.Point(476, 308)
        Me.TotalTerima.Name = "TotalTerima"
        Me.TotalTerima.Size = New System.Drawing.Size(0, 13)
        Me.TotalTerima.TabIndex = 26
        '
        'TxtBoxTotalTerima
        '
        Me.TxtBoxTotalTerima.BackColor = System.Drawing.SystemColors.Control
        Me.TxtBoxTotalTerima.Location = New System.Drawing.Point(475, 305)
        Me.TxtBoxTotalTerima.Name = "TxtBoxTotalTerima"
        Me.TxtBoxTotalTerima.Size = New System.Drawing.Size(91, 20)
        Me.TxtBoxTotalTerima.TabIndex = 25
        '
        'Penerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 336)
        Me.Controls.Add(Me.TotalTerima)
        Me.Controls.Add(Me.TxtBoxTotalTerima)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LBLPerson)
        Me.Controls.Add(Me.TxtBoxPerson)
        Me.Controls.Add(Me.NomorReff)
        Me.Controls.Add(Me.LBLNama)
        Me.Controls.Add(Me.TxtBoxNama)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.TxtBoxTanggal)
        Me.Controls.Add(Me.TTerima)
        Me.Controls.Add(Me.TStok)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TKode)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLNomor)
        Me.Controls.Add(Me.TxtBoxName)
        Me.Name = "Penerimaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form : Penerimaan"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBoxName As TextBox
    Friend WithEvents LBLNomor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TKode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TNama As TextBox
    Friend WithEvents TStok As TextBox
    Friend WithEvents TTerima As TextBox
    Friend WithEvents LBLTanggal As Label
    Friend WithEvents TxtBoxTanggal As TextBox
    Friend WithEvents LBLNama As Label
    Friend WithEvents TxtBoxNama As TextBox
    Friend WithEvents NomorReff As TextBox
    Friend WithEvents LBLPerson As Label
    Friend WithEvents TxtBoxPerson As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TotalTerima As Label
    Friend WithEvents TxtBoxTotalTerima As TextBox
End Class
