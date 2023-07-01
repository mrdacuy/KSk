<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TraPhanTichNuocTieu
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TraPhanTichNuocTieu))
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NIdSolieuhoso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBLOOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGLU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NKET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NLEU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NPH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NPRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NURO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ChonGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.BoChonGrid = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl2
        '
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Location = New System.Drawing.Point(0, 27)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(1514, 565)
        Me.GridControl2.TabIndex = 7
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIdSolieuhoso, Me.NBIL, Me.NBLOOD, Me.NGLU, Me.NKET, Me.NLEU, Me.NNIT, Me.NPH, Me.NPRO, Me.NSG, Me.NURO})
        Me.GridView2.DetailHeight = 431
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'NIdSolieuhoso
        '
        Me.NIdSolieuhoso.Caption = "Id"
        Me.NIdSolieuhoso.FieldName = "IdSolieuhoso"
        Me.NIdSolieuhoso.MinWidth = 23
        Me.NIdSolieuhoso.Name = "NIdSolieuhoso"
        Me.NIdSolieuhoso.Visible = True
        Me.NIdSolieuhoso.VisibleIndex = 0
        Me.NIdSolieuhoso.Width = 87
        '
        'NBIL
        '
        Me.NBIL.Caption = "BIL "
        Me.NBIL.FieldName = "BIL"
        Me.NBIL.MinWidth = 23
        Me.NBIL.Name = "NBIL"
        Me.NBIL.Visible = True
        Me.NBIL.VisibleIndex = 1
        Me.NBIL.Width = 87
        '
        'NBLOOD
        '
        Me.NBLOOD.Caption = " BLOOD"
        Me.NBLOOD.FieldName = "BLOOD"
        Me.NBLOOD.MinWidth = 23
        Me.NBLOOD.Name = "NBLOOD"
        Me.NBLOOD.Visible = True
        Me.NBLOOD.VisibleIndex = 2
        Me.NBLOOD.Width = 87
        '
        'NGLU
        '
        Me.NGLU.Caption = "GLU "
        Me.NGLU.FieldName = "GLU"
        Me.NGLU.MinWidth = 23
        Me.NGLU.Name = "NGLU"
        Me.NGLU.Visible = True
        Me.NGLU.VisibleIndex = 3
        Me.NGLU.Width = 87
        '
        'NKET
        '
        Me.NKET.Caption = "KET "
        Me.NKET.FieldName = "KET"
        Me.NKET.MinWidth = 23
        Me.NKET.Name = "NKET"
        Me.NKET.Visible = True
        Me.NKET.VisibleIndex = 4
        Me.NKET.Width = 87
        '
        'NLEU
        '
        Me.NLEU.Caption = "LEU "
        Me.NLEU.FieldName = "LEU"
        Me.NLEU.MinWidth = 23
        Me.NLEU.Name = "NLEU"
        Me.NLEU.Visible = True
        Me.NLEU.VisibleIndex = 5
        Me.NLEU.Width = 87
        '
        'NNIT
        '
        Me.NNIT.Caption = "NIT "
        Me.NNIT.FieldName = "NIT"
        Me.NNIT.MinWidth = 23
        Me.NNIT.Name = "NNIT"
        Me.NNIT.Visible = True
        Me.NNIT.VisibleIndex = 6
        Me.NNIT.Width = 87
        '
        'NPH
        '
        Me.NPH.Caption = "PH "
        Me.NPH.FieldName = "PH"
        Me.NPH.MinWidth = 23
        Me.NPH.Name = "NPH"
        Me.NPH.Visible = True
        Me.NPH.VisibleIndex = 7
        Me.NPH.Width = 87
        '
        'NPRO
        '
        Me.NPRO.Caption = "PRO "
        Me.NPRO.FieldName = "PRO"
        Me.NPRO.MinWidth = 23
        Me.NPRO.Name = "NPRO"
        Me.NPRO.Visible = True
        Me.NPRO.VisibleIndex = 8
        Me.NPRO.Width = 87
        '
        'NSG
        '
        Me.NSG.Caption = "SG "
        Me.NSG.FieldName = "SG"
        Me.NSG.MinWidth = 23
        Me.NSG.Name = "NSG"
        Me.NSG.Visible = True
        Me.NSG.VisibleIndex = 9
        Me.NSG.Width = 87
        '
        'NURO
        '
        Me.NURO.Caption = "URO "
        Me.NURO.FieldName = "URO"
        Me.NURO.MinWidth = 23
        Me.NURO.Name = "NURO"
        Me.NURO.Visible = True
        Me.NURO.VisibleIndex = 10
        Me.NURO.Width = 87
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.ChonGrid, Me.BoChonGrid})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1514, 25)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 597)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1514, 21)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 25)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 572)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1514, 25)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 572)
        '
        'ChonGrid
        '
        Me.ChonGrid.Caption = "Chọn"
        Me.ChonGrid.Id = 1
        Me.ChonGrid.ImageOptions.SvgImage = CType(resources.GetObject("ChonGrid.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.ChonGrid.Name = "ChonGrid"
        '
        'BoChonGrid
        '
        Me.BoChonGrid.Caption = "Bỏ chọn"
        Me.BoChonGrid.Id = 2
        Me.BoChonGrid.ImageOptions.SvgImage = CType(resources.GetObject("BoChonGrid.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BoChonGrid.Name = "BoChonGrid"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ChonGrid), New DevExpress.XtraBars.LinkPersistInfo(Me.BoChonGrid)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(414, -3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(497, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'TraPhanTichNuocTieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1514, 618)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TraPhanTichNuocTieu"
        Me.Text = "TraPhanTichNuocTieu"
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NIdSolieuhoso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NBIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NBLOOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGLU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NKET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NLEU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NPH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NPRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NURO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ChonGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BoChonGrid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
