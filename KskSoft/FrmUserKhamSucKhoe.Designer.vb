<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserKhamSucKhoe
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserKhamSucKhoe))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimkiem = New DevExpress.XtraEditors.TextEdit()
        Me.SlCongty = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.TuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.grSolieuhoso = New DevExpress.XtraGrid.GridControl()
        Me.gvSolieuhoso = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NMacode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHoten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNamsinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGioitinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NManhanvien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nnghenghiep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nchucvu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bophan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NPhatso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NThuso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNgay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
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
        CType(Me.grSolieuhoso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSolieuhoso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SimpleButton1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTimkiem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SlCongty)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DenNgay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TuNgay)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grSolieuhoso)
        Me.SplitContainer1.Size = New System.Drawing.Size(1206, 714)
        Me.SplitContainer1.SplitterDistance = 86
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 2
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton5.Location = New System.Drawing.Point(840, 46)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(125, 32)
        Me.SimpleButton5.TabIndex = 14
        Me.SimpleButton5.Text = "In Nhãn"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton4.Location = New System.Drawing.Point(971, 11)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(149, 32)
        Me.SimpleButton4.TabIndex = 13
        Me.SimpleButton4.Text = "Xuất Excel"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton3.Location = New System.Drawing.Point(840, 11)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(125, 32)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "In phiếu"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(252, 53)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Nhập từ khóa :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(252, 25)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Công ty :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(15, 50)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Đến ngày :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 18)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Từ ngày :"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(714, 46)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(119, 32)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Tìm kiếm"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(714, 10)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(119, 33)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Import"
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(353, 49)
        Me.txtTimkiem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimkiem.Properties.Appearance.Options.UseFont = True
        Me.txtTimkiem.Size = New System.Drawing.Size(336, 22)
        Me.txtTimkiem.TabIndex = 3
        '
        'SlCongty
        '
        Me.SlCongty.Location = New System.Drawing.Point(353, 16)
        Me.SlCongty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SlCongty.Name = "SlCongty"
        Me.SlCongty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlCongty.Properties.Appearance.Options.UseFont = True
        Me.SlCongty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SlCongty.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SlCongty.Size = New System.Drawing.Size(336, 22)
        Me.SlCongty.TabIndex = 2
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
        Me.DenNgay.Location = New System.Drawing.Point(89, 48)
        Me.DenNgay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DenNgay.Name = "DenNgay"
        Me.DenNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DenNgay.Properties.Appearance.Options.UseFont = True
        Me.DenNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DenNgay.Size = New System.Drawing.Size(149, 22)
        Me.DenNgay.TabIndex = 1
        '
        'TuNgay
        '
        Me.TuNgay.EditValue = Nothing
        Me.TuNgay.Location = New System.Drawing.Point(89, 16)
        Me.TuNgay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TuNgay.Name = "TuNgay"
        Me.TuNgay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuNgay.Properties.Appearance.Options.UseFont = True
        Me.TuNgay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TuNgay.Size = New System.Drawing.Size(149, 22)
        Me.TuNgay.TabIndex = 0
        '
        'grSolieuhoso
        '
        Me.grSolieuhoso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grSolieuhoso.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grSolieuhoso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode1.RelationName = "Level1"
        Me.grSolieuhoso.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grSolieuhoso.Location = New System.Drawing.Point(0, 0)
        Me.grSolieuhoso.MainView = Me.gvSolieuhoso
        Me.grSolieuhoso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grSolieuhoso.Name = "grSolieuhoso"
        Me.grSolieuhoso.Size = New System.Drawing.Size(1206, 623)
        Me.grSolieuhoso.TabIndex = 2
        Me.grSolieuhoso.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSolieuhoso})
        '
        'gvSolieuhoso
        '
        Me.gvSolieuhoso.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSolieuhoso.Appearance.FooterPanel.Options.UseFont = True
        Me.gvSolieuhoso.Appearance.FooterPanel.Options.UseTextOptions = True
        Me.gvSolieuhoso.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvSolieuhoso.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvSolieuhoso.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSolieuhoso.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSolieuhoso.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSolieuhoso.Appearance.Row.Options.UseFont = True
        Me.gvSolieuhoso.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NMacode, Me.NHoten, Me.NNamsinh, Me.NGioitinh, Me.NManhanvien, Me.Nnghenghiep, Me.Nchucvu, Me.Bophan, Me.NPhatso, Me.NThuso, Me.NNgay})
        Me.gvSolieuhoso.DetailHeight = 431
        Me.gvSolieuhoso.GridControl = Me.grSolieuhoso
        Me.gvSolieuhoso.Name = "gvSolieuhoso"
        Me.gvSolieuhoso.OptionsBehavior.Editable = False
        Me.gvSolieuhoso.OptionsSelection.MultiSelect = True
        Me.gvSolieuhoso.OptionsView.ShowFooter = True
        Me.gvSolieuhoso.OptionsView.ShowGroupPanel = False
        Me.gvSolieuhoso.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'NMacode
        '
        Me.NMacode.Caption = "MÃ ID"
        Me.NMacode.FieldName = "Macode"
        Me.NMacode.MinWidth = 23
        Me.NMacode.Name = "NMacode"
        Me.NMacode.Visible = True
        Me.NMacode.VisibleIndex = 0
        Me.NMacode.Width = 87
        '
        'NHoten
        '
        Me.NHoten.Caption = "HỌ VÀ TÊN"
        Me.NHoten.FieldName = "Hoten"
        Me.NHoten.MinWidth = 23
        Me.NHoten.Name = "NHoten"
        Me.NHoten.Visible = True
        Me.NHoten.VisibleIndex = 1
        Me.NHoten.Width = 228
        '
        'NNamsinh
        '
        Me.NNamsinh.Caption = "NĂM SINH"
        Me.NNamsinh.FieldName = "Namsinh"
        Me.NNamsinh.MinWidth = 23
        Me.NNamsinh.Name = "NNamsinh"
        Me.NNamsinh.Visible = True
        Me.NNamsinh.VisibleIndex = 2
        Me.NNamsinh.Width = 110
        '
        'NGioitinh
        '
        Me.NGioitinh.Caption = "GIỚI TÍNH"
        Me.NGioitinh.FieldName = "Gioitinh"
        Me.NGioitinh.MinWidth = 23
        Me.NGioitinh.Name = "NGioitinh"
        Me.NGioitinh.Visible = True
        Me.NGioitinh.VisibleIndex = 3
        Me.NGioitinh.Width = 85
        '
        'NManhanvien
        '
        Me.NManhanvien.Caption = "MÃ NHÂN VIÊN"
        Me.NManhanvien.FieldName = "Manhanvien"
        Me.NManhanvien.MinWidth = 23
        Me.NManhanvien.Name = "NManhanvien"
        Me.NManhanvien.Visible = True
        Me.NManhanvien.VisibleIndex = 4
        Me.NManhanvien.Width = 123
        '
        'Nnghenghiep
        '
        Me.Nnghenghiep.Caption = "Nghề nghiệp"
        Me.Nnghenghiep.FieldName = "Nghenghiep"
        Me.Nnghenghiep.Name = "Nnghenghiep"
        Me.Nnghenghiep.Visible = True
        Me.Nnghenghiep.VisibleIndex = 5
        Me.Nnghenghiep.Width = 92
        '
        'Nchucvu
        '
        Me.Nchucvu.Caption = "Chức vụ"
        Me.Nchucvu.FieldName = "Chucvu"
        Me.Nchucvu.Name = "Nchucvu"
        Me.Nchucvu.Visible = True
        Me.Nchucvu.VisibleIndex = 6
        Me.Nchucvu.Width = 89
        '
        'Bophan
        '
        Me.Bophan.Caption = "BỘ PHẬN"
        Me.Bophan.FieldName = "Bophan"
        Me.Bophan.MinWidth = 23
        Me.Bophan.Name = "Bophan"
        Me.Bophan.Visible = True
        Me.Bophan.VisibleIndex = 7
        Me.Bophan.Width = 99
        '
        'NPhatso
        '
        Me.NPhatso.Caption = "PHÁT SỔ"
        Me.NPhatso.FieldName = "Phatso"
        Me.NPhatso.MinWidth = 23
        Me.NPhatso.Name = "NPhatso"
        Me.NPhatso.Visible = True
        Me.NPhatso.VisibleIndex = 8
        Me.NPhatso.Width = 108
        '
        'NThuso
        '
        Me.NThuso.Caption = "THU SỔ"
        Me.NThuso.FieldName = "Thuso"
        Me.NThuso.MinWidth = 23
        Me.NThuso.Name = "NThuso"
        Me.NThuso.Visible = True
        Me.NThuso.VisibleIndex = 9
        Me.NThuso.Width = 113
        '
        'NNgay
        '
        Me.NNgay.Caption = "Ngày khám"
        Me.NNgay.FieldName = "Ngay"
        Me.NNgay.Name = "NNgay"
        Me.NNgay.Visible = True
        Me.NNgay.VisibleIndex = 10
        Me.NNgay.Width = 109
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmUserKhamSucKhoe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmUserKhamSucKhoe"
        Me.Size = New System.Drawing.Size(1206, 714)
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
        CType(Me.grSolieuhoso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSolieuhoso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTimkiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SlCongty As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grSolieuhoso As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSolieuhoso As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NMacode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHoten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNamsinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGioitinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NManhanvien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nnghenghiep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nchucvu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bophan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NPhatso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NThuso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNgay As DevExpress.XtraGrid.Columns.GridColumn
End Class
