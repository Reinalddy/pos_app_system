<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerimaanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RincianStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RincianPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerimaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.PemasokToolStripMenuItem, Me.PemakaiToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(55, 20)
        Me.FileMenu.Text = "Master"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'PemasokToolStripMenuItem
        '
        Me.PemasokToolStripMenuItem.Name = "PemasokToolStripMenuItem"
        Me.PemasokToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PemasokToolStripMenuItem.Text = "Pemasok"
        '
        'PemakaiToolStripMenuItem
        '
        Me.PemakaiToolStripMenuItem.Name = "PemakaiToolStripMenuItem"
        Me.PemakaiToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PemakaiToolStripMenuItem.Text = "Pemakai"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenerimaanBarangToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(68, 20)
        Me.EditMenu.Text = "Transaksi"
        '
        'PenerimaanBarangToolStripMenuItem
        '
        Me.PenerimaanBarangToolStripMenuItem.Name = "PenerimaanBarangToolStripMenuItem"
        Me.PenerimaanBarangToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PenerimaanBarangToolStripMenuItem.Text = "Penerimaan Barang"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RincianStokToolStripMenuItem, Me.RincianPenjualanToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(71, 20)
        Me.ViewMenu.Text = "Pencarian"
        '
        'RincianStokToolStripMenuItem
        '
        Me.RincianStokToolStripMenuItem.Name = "RincianStokToolStripMenuItem"
        Me.RincianStokToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RincianStokToolStripMenuItem.Text = "Rincian Stok"
        '
        'RincianPenjualanToolStripMenuItem
        '
        Me.RincianPenjualanToolStripMenuItem.Name = "RincianPenjualanToolStripMenuItem"
        Me.RincianPenjualanToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RincianPenjualanToolStripMenuItem.Text = "Rincian Penjualan"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.PenerimaanToolStripMenuItem, Me.PenjualanToolStripMenuItem1})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(62, 20)
        Me.ToolsMenu.Text = "Laporan"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PenerimaanToolStripMenuItem
        '
        Me.PenerimaanToolStripMenuItem.Name = "PenerimaanToolStripMenuItem"
        Me.PenerimaanToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.PenerimaanToolStripMenuItem.Text = "Penerimaan"
        '
        'PenjualanToolStripMenuItem1
        '
        Me.PenjualanToolStripMenuItem1.Name = "PenjualanToolStripMenuItem1"
        Me.PenjualanToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.PenjualanToolStripMenuItem1.Text = "Penjualan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Panel1, Me.Panel2, Me.Panel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(39, 17)
        Me.Panel1.Text = "Status"
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(121, 17)
        Me.Panel2.Text = "ToolStripStatusLabel1"
        '
        'Panel3
        '
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(121, 17)
        Me.Panel3.Text = "ToolStripStatusLabel2"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemasokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemakaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents PenerimaanBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents RincianStokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RincianPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsMenu As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenerimaanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As ToolStripStatusLabel
    Friend WithEvents Panel2 As ToolStripStatusLabel
    Friend WithEvents Panel3 As ToolStripStatusLabel
End Class
