<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraSinhHoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTraSinhHoa))
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NIdSolieuhoso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NAST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NALT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGlucose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCreatine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCholesterol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTriglyceride = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NLDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUric = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NProtein = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.NNgaykham = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCongty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBophan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NManhanvien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGioitinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNamsinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHoten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NMacode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHbA1c = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
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
        Me.GridControl2.Size = New System.Drawing.Size(1153, 428)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIdSolieuhoso, Me.NMacode, Me.NHoten, Me.NNamsinh, Me.NGioitinh, Me.NManhanvien, Me.NBophan, Me.NCongty, Me.NNgaykham, Me.NAST, Me.NALT, Me.NGGT, Me.NGlucose, Me.NCreatine, Me.NUre, Me.NCholesterol, Me.NTriglyceride, Me.NHDL, Me.NLDL, Me.NUric, Me.NProtein, Me.NHbA1c})
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
        'NAST
        '
        Me.NAST.Caption = "AST "
        Me.NAST.FieldName = "AST"
        Me.NAST.MinWidth = 23
        Me.NAST.Name = "NAST"
        Me.NAST.Visible = True
        Me.NAST.VisibleIndex = 8
        Me.NAST.Width = 41
        '
        'NALT
        '
        Me.NALT.Caption = "ALT "
        Me.NALT.FieldName = "ALT"
        Me.NALT.MinWidth = 23
        Me.NALT.Name = "NALT"
        Me.NALT.Visible = True
        Me.NALT.VisibleIndex = 9
        Me.NALT.Width = 41
        '
        'NGGT
        '
        Me.NGGT.Caption = "GGT "
        Me.NGGT.FieldName = "GGT"
        Me.NGGT.MinWidth = 23
        Me.NGGT.Name = "NGGT"
        Me.NGGT.Visible = True
        Me.NGGT.VisibleIndex = 10
        Me.NGGT.Width = 41
        '
        'NGlucose
        '
        Me.NGlucose.Caption = "Glucose "
        Me.NGlucose.FieldName = "Glucose"
        Me.NGlucose.MinWidth = 23
        Me.NGlucose.Name = "NGlucose"
        Me.NGlucose.Visible = True
        Me.NGlucose.VisibleIndex = 11
        Me.NGlucose.Width = 61
        '
        'NCreatine
        '
        Me.NCreatine.Caption = "Creatine "
        Me.NCreatine.FieldName = "Creatine"
        Me.NCreatine.MinWidth = 23
        Me.NCreatine.Name = "NCreatine"
        Me.NCreatine.Visible = True
        Me.NCreatine.VisibleIndex = 12
        Me.NCreatine.Width = 58
        '
        'NUre
        '
        Me.NUre.Caption = "Ure "
        Me.NUre.FieldName = "Ure"
        Me.NUre.MinWidth = 23
        Me.NUre.Name = "NUre"
        Me.NUre.Visible = True
        Me.NUre.VisibleIndex = 13
        Me.NUre.Width = 41
        '
        'NCholesterol
        '
        Me.NCholesterol.Caption = "Cholesterol "
        Me.NCholesterol.FieldName = "Cholesterol"
        Me.NCholesterol.MinWidth = 23
        Me.NCholesterol.Name = "NCholesterol"
        Me.NCholesterol.Visible = True
        Me.NCholesterol.VisibleIndex = 14
        Me.NCholesterol.Width = 65
        '
        'NTriglyceride
        '
        Me.NTriglyceride.Caption = "Triglyceride"
        Me.NTriglyceride.FieldName = "Triglyceride"
        Me.NTriglyceride.MinWidth = 23
        Me.NTriglyceride.Name = "NTriglyceride"
        Me.NTriglyceride.Visible = True
        Me.NTriglyceride.VisibleIndex = 15
        Me.NTriglyceride.Width = 41
        '
        'NHDL
        '
        Me.NHDL.Caption = "HDL "
        Me.NHDL.FieldName = "HDL"
        Me.NHDL.MinWidth = 23
        Me.NHDL.Name = "NHDL"
        Me.NHDL.Visible = True
        Me.NHDL.VisibleIndex = 16
        Me.NHDL.Width = 41
        '
        'NLDL
        '
        Me.NLDL.Caption = "LDL "
        Me.NLDL.FieldName = "LDL"
        Me.NLDL.MinWidth = 23
        Me.NLDL.Name = "NLDL"
        Me.NLDL.Visible = True
        Me.NLDL.VisibleIndex = 17
        Me.NLDL.Width = 41
        '
        'NUric
        '
        Me.NUric.Caption = "Uric"
        Me.NUric.FieldName = "Uric"
        Me.NUric.MinWidth = 23
        Me.NUric.Name = "NUric"
        Me.NUric.Visible = True
        Me.NUric.VisibleIndex = 18
        Me.NUric.Width = 41
        '
        'NProtein
        '
        Me.NProtein.Caption = "Protein "
        Me.NProtein.FieldName = "Protein"
        Me.NProtein.MinWidth = 23
        Me.NProtein.Name = "NProtein"
        Me.NProtein.Visible = True
        Me.NProtein.VisibleIndex = 19
        Me.NProtein.Width = 41
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'NNgaykham
        '
        Me.NNgaykham.Caption = "NGÀY KHÁM"
        Me.NNgaykham.FieldName = "Ngay"
        Me.NNgaykham.Name = "NNgaykham"
        Me.NNgaykham.Visible = True
        Me.NNgaykham.VisibleIndex = 21
        Me.NNgaykham.Width = 74
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
        'NBophan
        '
        Me.NBophan.Caption = "BỘ PHẬN"
        Me.NBophan.FieldName = "Bophan"
        Me.NBophan.Name = "NBophan"
        Me.NBophan.Visible = True
        Me.NBophan.VisibleIndex = 7
        Me.NBophan.Width = 108
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
        'NGioitinh
        '
        Me.NGioitinh.Caption = "GIỚI TÍNH"
        Me.NGioitinh.FieldName = "Gioitinh"
        Me.NGioitinh.Name = "NGioitinh"
        Me.NGioitinh.Visible = True
        Me.NGioitinh.VisibleIndex = 5
        Me.NGioitinh.Width = 83
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
        'NHoten
        '
        Me.NHoten.Caption = "HỌ TÊN"
        Me.NHoten.FieldName = "Hoten"
        Me.NHoten.Name = "NHoten"
        Me.NHoten.Visible = True
        Me.NHoten.VisibleIndex = 3
        Me.NHoten.Width = 148
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
        'NHbA1c
        '
        Me.NHbA1c.Caption = "HbA1c"
        Me.NHbA1c.FieldName = "HbA1c"
        Me.NHbA1c.Name = "NHbA1c"
        Me.NHbA1c.Visible = True
        Me.NHbA1c.VisibleIndex = 20
        Me.NHbA1c.Width = 41
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1153, 521)
        Me.SplitContainer1.SplitterDistance = 89
        Me.SplitContainer1.TabIndex = 9
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
        'frmTraSinhHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 521)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTraSinhHoa"
        Me.Text = "frmTraSinhHoa"
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NIdSolieuhoso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NAST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NALT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGlucose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCreatine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCholesterol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTriglyceride As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NLDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUric As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NProtein As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents NMacode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHoten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNamsinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGioitinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NManhanvien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NBophan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCongty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNgaykham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHbA1c As DevExpress.XtraGrid.Columns.GridColumn
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
End Class
