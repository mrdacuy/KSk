<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoidichamdao
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoidichamdao))
        Me.NGioitinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NIdSolieuhoso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NMacode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHoten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNamsinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NManhanvien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBophan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCongty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNgaykham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTebaobieumo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSoituoiamdaobachcau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSoituoiamdaohongcau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSoitonamgia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTrichomonasvaginalis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTapkhuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NKetluansoiamdao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NThamvansoiamdao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimkiem = New DevExpress.XtraEditors.TextEdit()
        Me.SlCongty = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.TuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BntTaodulieu = New DevExpress.XtraBars.BarButtonItem()
        Me.BntXoadulieu = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.txtTimkiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlCongty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NGioitinh
        '
        Me.NGioitinh.Caption = "GIỚI TÍNH"
        Me.NGioitinh.FieldName = "Gioitinh"
        Me.NGioitinh.Name = "NGioitinh"
        Me.NGioitinh.Visible = True
        Me.NGioitinh.VisibleIndex = 5
        Me.NGioitinh.Width = 83
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIdSolieuhoso, Me.NMacode, Me.NHoten, Me.NNamsinh, Me.NGioitinh, Me.NManhanvien, Me.NBophan, Me.NCongty, Me.NNgaykham, Me.NTebaobieumo, Me.NSoituoiamdaobachcau, Me.NSoituoiamdaohongcau, Me.NNam, Me.NSoitonamgia, Me.NTrichomonasvaginalis, Me.NTapkhuan, Me.NKetluansoiamdao, Me.NThamvansoiamdao})
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
        Me.NIdSolieuhoso.Width = 51
        '
        'NMacode
        '
        Me.NMacode.Caption = "MÃ ID"
        Me.NMacode.FieldName = "Macode"
        Me.NMacode.Name = "NMacode"
        Me.NMacode.Visible = True
        Me.NMacode.VisibleIndex = 1
        Me.NMacode.Width = 51
        '
        'NHoten
        '
        Me.NHoten.Caption = "HỌ TÊN"
        Me.NHoten.FieldName = "Hoten"
        Me.NHoten.Name = "NHoten"
        Me.NHoten.Visible = True
        Me.NHoten.VisibleIndex = 3
        Me.NHoten.Width = 148
        '
        'NNamsinh
        '
        Me.NNamsinh.Caption = "NĂM SINH"
        Me.NNamsinh.FieldName = "Namsinh"
        Me.NNamsinh.Name = "NNamsinh"
        Me.NNamsinh.Visible = True
        Me.NNamsinh.VisibleIndex = 4
        Me.NNamsinh.Width = 79
        '
        'NManhanvien
        '
        Me.NManhanvien.Caption = "MNV"
        Me.NManhanvien.FieldName = "Manhanvien"
        Me.NManhanvien.Name = "NManhanvien"
        Me.NManhanvien.Visible = True
        Me.NManhanvien.VisibleIndex = 6
        Me.NManhanvien.Width = 70
        '
        'NBophan
        '
        Me.NBophan.Caption = "BỘ PHẬN"
        Me.NBophan.FieldName = "Bophan"
        Me.NBophan.Name = "NBophan"
        Me.NBophan.Visible = True
        Me.NBophan.VisibleIndex = 7
        Me.NBophan.Width = 108
        '
        'NCongty
        '
        Me.NCongty.Caption = "CÔNG TY"
        Me.NCongty.FieldName = "Congty"
        Me.NCongty.Name = "NCongty"
        Me.NCongty.Visible = True
        Me.NCongty.VisibleIndex = 2
        Me.NCongty.Width = 60
        '
        'NNgaykham
        '
        Me.NNgaykham.Caption = "NGÀY KHÁM"
        Me.NNgaykham.FieldName = "Ngay"
        Me.NNgaykham.Name = "NNgaykham"
        Me.NNgaykham.Visible = True
        Me.NNgaykham.VisibleIndex = 17
        Me.NNgaykham.Width = 74
        '
        'NTebaobieumo
        '
        Me.NTebaobieumo.Caption = "TB BIỂU MÔ"
        Me.NTebaobieumo.FieldName = "Tebaobieumo"
        Me.NTebaobieumo.MinWidth = 23
        Me.NTebaobieumo.Name = "NTebaobieumo"
        Me.NTebaobieumo.Visible = True
        Me.NTebaobieumo.VisibleIndex = 8
        Me.NTebaobieumo.Width = 41
        '
        'NSoituoiamdaobachcau
        '
        Me.NSoituoiamdaobachcau.Caption = "BẠCH CẦU"
        Me.NSoituoiamdaobachcau.FieldName = "Soituoiamdaobachcau"
        Me.NSoituoiamdaobachcau.MinWidth = 23
        Me.NSoituoiamdaobachcau.Name = "NSoituoiamdaobachcau"
        Me.NSoituoiamdaobachcau.Visible = True
        Me.NSoituoiamdaobachcau.VisibleIndex = 9
        Me.NSoituoiamdaobachcau.Width = 41
        '
        'NSoituoiamdaohongcau
        '
        Me.NSoituoiamdaohongcau.Caption = "HỒNG CẦU"
        Me.NSoituoiamdaohongcau.FieldName = "Soituoiamdaohongcau"
        Me.NSoituoiamdaohongcau.MinWidth = 23
        Me.NSoituoiamdaohongcau.Name = "NSoituoiamdaohongcau"
        Me.NSoituoiamdaohongcau.Visible = True
        Me.NSoituoiamdaohongcau.VisibleIndex = 10
        Me.NSoituoiamdaohongcau.Width = 41
        '
        'NNam
        '
        Me.NNam.Caption = "NẤM"
        Me.NNam.FieldName = "Nam"
        Me.NNam.MinWidth = 23
        Me.NNam.Name = "NNam"
        Me.NNam.Visible = True
        Me.NNam.VisibleIndex = 11
        Me.NNam.Width = 61
        '
        'NSoitonamgia
        '
        Me.NSoitonamgia.Caption = "SỢI TƠ NẤM"
        Me.NSoitonamgia.FieldName = "Soitonamgia"
        Me.NSoitonamgia.MinWidth = 23
        Me.NSoitonamgia.Name = "NSoitonamgia"
        Me.NSoitonamgia.Visible = True
        Me.NSoitonamgia.VisibleIndex = 12
        Me.NSoitonamgia.Width = 58
        '
        'NTrichomonasvaginalis
        '
        Me.NTrichomonasvaginalis.Caption = "Trichomonasvaginalis"
        Me.NTrichomonasvaginalis.FieldName = "Trichomonasvaginalis"
        Me.NTrichomonasvaginalis.MinWidth = 23
        Me.NTrichomonasvaginalis.Name = "NTrichomonasvaginalis"
        Me.NTrichomonasvaginalis.Visible = True
        Me.NTrichomonasvaginalis.VisibleIndex = 13
        Me.NTrichomonasvaginalis.Width = 41
        '
        'NTapkhuan
        '
        Me.NTapkhuan.Caption = "TẠP KHUẨN"
        Me.NTapkhuan.FieldName = "Tapkhuan"
        Me.NTapkhuan.MinWidth = 23
        Me.NTapkhuan.Name = "NTapkhuan"
        Me.NTapkhuan.Visible = True
        Me.NTapkhuan.VisibleIndex = 14
        Me.NTapkhuan.Width = 65
        '
        'NKetluansoiamdao
        '
        Me.NKetluansoiamdao.Caption = "KẾT LUẬN"
        Me.NKetluansoiamdao.FieldName = "Ketluansoiamdao"
        Me.NKetluansoiamdao.MinWidth = 23
        Me.NKetluansoiamdao.Name = "NKetluansoiamdao"
        Me.NKetluansoiamdao.Visible = True
        Me.NKetluansoiamdao.VisibleIndex = 15
        Me.NKetluansoiamdao.Width = 41
        '
        'NThamvansoiamdao
        '
        Me.NThamvansoiamdao.Caption = "THAM VẤN"
        Me.NThamvansoiamdao.FieldName = "Thamvansoiamdao"
        Me.NThamvansoiamdao.MinWidth = 23
        Me.NThamvansoiamdao.Name = "NThamvansoiamdao"
        Me.NThamvansoiamdao.Visible = True
        Me.NThamvansoiamdao.VisibleIndex = 16
        Me.NThamvansoiamdao.Width = 41
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(1248, 526)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTimkiem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SlCongty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DenNgay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TuNgay)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1248, 616)
        Me.SplitContainer1.SplitterDistance = 86
        Me.SplitContainer1.TabIndex = 12
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton4.Location = New System.Drawing.Point(822, 9)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(115, 32)
        Me.SimpleButton4.TabIndex = 49
        Me.SimpleButton4.Text = "Xuất Excel"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton3.Location = New System.Drawing.Point(711, 9)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(105, 32)
        Me.SimpleButton3.TabIndex = 48
        Me.SimpleButton3.Text = "In phiếu"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(249, 51)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl4.TabIndex = 47
        Me.LabelControl4.Text = "Nhập từ khóa :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(249, 23)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "Công ty :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 48)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Đến ngày :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 16)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Từ ngày :"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(711, 44)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(105, 32)
        Me.SimpleButton2.TabIndex = 43
        Me.SimpleButton2.Text = "Tìm kiếm"
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(350, 47)
        Me.txtTimkiem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimkiem.Properties.Appearance.Options.UseFont = True
        Me.txtTimkiem.Size = New System.Drawing.Size(336, 22)
        Me.txtTimkiem.TabIndex = 42
        '
        'SlCongty
        '
        Me.SlCongty.Location = New System.Drawing.Point(350, 14)
        Me.SlCongty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SlCongty.Name = "SlCongty"
        Me.SlCongty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlCongty.Properties.Appearance.Options.UseFont = True
        Me.SlCongty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SlCongty.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SlCongty.Size = New System.Drawing.Size(336, 22)
        Me.SlCongty.TabIndex = 41
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.DetailHeight = 431
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'DenNgay
        '
        Me.DenNgay.EditValue = Nothing
        Me.DenNgay.Location = New System.Drawing.Point(86, 46)
        Me.DenNgay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DenNgay.Name = "DenNgay"
        Me.DenNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DenNgay.Properties.Appearance.Options.UseFont = True
        Me.DenNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DenNgay.Size = New System.Drawing.Size(149, 22)
        Me.DenNgay.TabIndex = 40
        '
        'TuNgay
        '
        Me.TuNgay.EditValue = Nothing
        Me.TuNgay.Location = New System.Drawing.Point(86, 14)
        Me.TuNgay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TuNgay.Name = "TuNgay"
        Me.TuNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuNgay.Properties.Appearance.Options.UseFont = True
        Me.TuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TuNgay.Size = New System.Drawing.Size(149, 22)
        Me.TuNgay.TabIndex = 39
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 616)
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BntTaodulieu, Me.BntXoadulieu})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1248, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 616)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1248, 0)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1248, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 616)
        '
        'BntTaodulieu
        '
        Me.BntTaodulieu.Caption = "Tạo dữ liệu"
        Me.BntTaodulieu.Id = 0
        Me.BntTaodulieu.ImageOptions.SvgImage = CType(resources.GetObject("BntTaodulieu.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BntTaodulieu.Name = "BntTaodulieu"
        '
        'BntXoadulieu
        '
        Me.BntXoadulieu.Caption = "Xóa dữ liệu"
        Me.BntXoadulieu.Id = 1
        Me.BntXoadulieu.ImageOptions.SvgImage = CType(resources.GetObject("BntXoadulieu.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BntXoadulieu.Name = "BntXoadulieu"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BntTaodulieu), New DevExpress.XtraBars.LinkPersistInfo(Me.BntXoadulieu)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'FrmSoidichamdao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmSoidichamdao"
        Me.Text = "Soi Dịch Âm Đạo"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.txtTimkiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlCongty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NGioitinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NIdSolieuhoso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NMacode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHoten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNamsinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NManhanvien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NBophan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCongty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNgaykham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTebaobieumo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSoituoiamdaobachcau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSoituoiamdaohongcau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSoitonamgia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTrichomonasvaginalis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTapkhuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NKetluansoiamdao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NThamvansoiamdao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTimkiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SlCongty As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BntTaodulieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BntXoadulieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
End Class
