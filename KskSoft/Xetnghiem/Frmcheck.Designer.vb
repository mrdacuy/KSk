﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcheck))
        Me.TbSoiamdaoTableAdapter = New KskSoft.KskDbDataSetTableAdapters.TbSoiamdaoTableAdapter()
        Me.NNamsinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHoten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NMacode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NIdSolieuhoso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NGioitinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NManhanvien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBophan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCongty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNgaylaymau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCheckmau = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NChecknuoctieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCheckphan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Checkthongtin = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BntTaodulieu = New DevExpress.XtraBars.BarButtonItem()
        Me.BntXoadulieu = New DevExpress.XtraBars.BarButtonItem()
        Me.CheckPhan = New DevExpress.XtraEditors.CheckEdit()
        Me.Checknuoctieu = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckMau = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.DtNgaylaymau = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimkiem = New DevExpress.XtraEditors.TextEdit()
        Me.SlCongty = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.DenNgay = New DevExpress.XtraEditors.DateEdit()
        Me.TuNgay = New DevExpress.XtraEditors.DateEdit()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Checkthongtin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPhan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Checknuoctieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckMau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtNgaylaymau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtNgaylaymau.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimkiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlCongty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DenNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TuNgay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbSoiamdaoTableAdapter
        '
        Me.TbSoiamdaoTableAdapter.ClearBeforeFill = True
        '
        'NNamsinh
        '
        Me.NNamsinh.Caption = "NĂM SINH"
        Me.NNamsinh.FieldName = "Namsinh"
        Me.NNamsinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.NNamsinh.Name = "NNamsinh"
        Me.NNamsinh.Visible = True
        Me.NNamsinh.VisibleIndex = 2
        Me.NNamsinh.Width = 126
        '
        'NHoten
        '
        Me.NHoten.Caption = "HỌ TÊN"
        Me.NHoten.FieldName = "Hoten"
        Me.NHoten.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.NHoten.Name = "NHoten"
        Me.NHoten.Visible = True
        Me.NHoten.VisibleIndex = 1
        Me.NHoten.Width = 250
        '
        'NMacode
        '
        Me.NMacode.Caption = "MÃ ID"
        Me.NMacode.FieldName = "Macode"
        Me.NMacode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.NMacode.Name = "NMacode"
        Me.NMacode.Visible = True
        Me.NMacode.VisibleIndex = 0
        Me.NMacode.Width = 66
        '
        'NIdSolieuhoso
        '
        Me.NIdSolieuhoso.Caption = "Id"
        Me.NIdSolieuhoso.FieldName = "IdSolieuhoso"
        Me.NIdSolieuhoso.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.NIdSolieuhoso.MinWidth = 23
        Me.NIdSolieuhoso.Name = "NIdSolieuhoso"
        Me.NIdSolieuhoso.Width = 51
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIdSolieuhoso, Me.NMacode, Me.NHoten, Me.NNamsinh, Me.NGioitinh, Me.NManhanvien, Me.NBophan, Me.NCongty, Me.NNgaylaymau, Me.NCheckmau, Me.NChecknuoctieu, Me.NCheckphan})
        Me.GridView2.DetailHeight = 431
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'NGioitinh
        '
        Me.NGioitinh.Caption = "GIỚI TÍNH"
        Me.NGioitinh.FieldName = "Gioitinh"
        Me.NGioitinh.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.NGioitinh.Name = "NGioitinh"
        Me.NGioitinh.Visible = True
        Me.NGioitinh.VisibleIndex = 3
        Me.NGioitinh.Width = 106
        '
        'NManhanvien
        '
        Me.NManhanvien.Caption = "MNV"
        Me.NManhanvien.FieldName = "Manhanvien"
        Me.NManhanvien.Name = "NManhanvien"
        Me.NManhanvien.Width = 70
        '
        'NBophan
        '
        Me.NBophan.Caption = "BỘ PHẬN"
        Me.NBophan.FieldName = "Bophan"
        Me.NBophan.Name = "NBophan"
        Me.NBophan.Width = 108
        '
        'NCongty
        '
        Me.NCongty.Caption = "CÔNG TY"
        Me.NCongty.FieldName = "Congty"
        Me.NCongty.Name = "NCongty"
        Me.NCongty.Width = 60
        '
        'NNgaylaymau
        '
        Me.NNgaylaymau.Caption = "NGÀY LẤY MẪU"
        Me.NNgaylaymau.FieldName = "Ngaylaymau"
        Me.NNgaylaymau.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.NNgaylaymau.Name = "NNgaylaymau"
        Me.NNgaylaymau.Visible = True
        Me.NNgaylaymau.VisibleIndex = 7
        Me.NNgaylaymau.Width = 129
        '
        'NCheckmau
        '
        Me.NCheckmau.Caption = "CHECK MÁU"
        Me.NCheckmau.FieldName = "Checkmau"
        Me.NCheckmau.MinWidth = 23
        Me.NCheckmau.Name = "NCheckmau"
        Me.NCheckmau.Visible = True
        Me.NCheckmau.VisibleIndex = 4
        Me.NCheckmau.Width = 137
        '
        'NChecknuoctieu
        '
        Me.NChecknuoctieu.Caption = "CHECK NƯỚC TIỂU"
        Me.NChecknuoctieu.FieldName = "Checknuoctieu"
        Me.NChecknuoctieu.MinWidth = 23
        Me.NChecknuoctieu.Name = "NChecknuoctieu"
        Me.NChecknuoctieu.Visible = True
        Me.NChecknuoctieu.VisibleIndex = 5
        Me.NChecknuoctieu.Width = 161
        '
        'NCheckphan
        '
        Me.NCheckphan.Caption = "CHECK PHÂN"
        Me.NCheckphan.FieldName = "Checkphan"
        Me.NCheckphan.MinWidth = 23
        Me.NCheckphan.Name = "NCheckphan"
        Me.NCheckphan.Visible = True
        Me.NCheckphan.VisibleIndex = 6
        Me.NCheckphan.Width = 131
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.MaximumSize = New System.Drawing.Size(1135, 500)
        Me.GridControl2.MinimumSize = New System.Drawing.Size(1135, 500)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(1135, 500)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.DetailHeight = 431
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Checkthongtin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckPhan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Checknuoctieu)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckMau)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DtNgaylaymau)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1133, 590)
        Me.SplitContainer1.SplitterDistance = 86
        Me.SplitContainer1.TabIndex = 12
        '
        'Checkthongtin
        '
        Me.Checkthongtin.Location = New System.Drawing.Point(1099, 14)
        Me.Checkthongtin.MenuManager = Me.BarManager1
        Me.Checkthongtin.Name = "Checkthongtin"
        Me.Checkthongtin.Properties.Caption = ""
        Me.Checkthongtin.Size = New System.Drawing.Size(22, 19)
        Me.Checkthongtin.TabIndex = 54
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1133, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 590)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1133, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 590)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1133, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 590)
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
        'CheckPhan
        '
        Me.CheckPhan.Location = New System.Drawing.Point(1032, 45)
        Me.CheckPhan.MenuManager = Me.BarManager1
        Me.CheckPhan.Name = "CheckPhan"
        Me.CheckPhan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CheckPhan.Properties.Appearance.Options.UseFont = True
        Me.CheckPhan.Properties.Caption = "Check Phân"
        Me.CheckPhan.Size = New System.Drawing.Size(100, 20)
        Me.CheckPhan.TabIndex = 53
        '
        'Checknuoctieu
        '
        Me.Checknuoctieu.Location = New System.Drawing.Point(903, 44)
        Me.Checknuoctieu.MenuManager = Me.BarManager1
        Me.Checknuoctieu.Name = "Checknuoctieu"
        Me.Checknuoctieu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Checknuoctieu.Properties.Appearance.Options.UseFont = True
        Me.Checknuoctieu.Properties.Caption = "Check Nước Tiểu"
        Me.Checknuoctieu.Size = New System.Drawing.Size(127, 20)
        Me.Checknuoctieu.TabIndex = 52
        '
        'CheckMau
        '
        Me.CheckMau.Location = New System.Drawing.Point(808, 44)
        Me.CheckMau.MenuManager = Me.BarManager1
        Me.CheckMau.Name = "CheckMau"
        Me.CheckMau.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CheckMau.Properties.Appearance.Options.UseFont = True
        Me.CheckMau.Properties.Caption = "Check Máu"
        Me.CheckMau.Size = New System.Drawing.Size(89, 20)
        Me.CheckMau.TabIndex = 51
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(808, 16)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl5.TabIndex = 50
        Me.LabelControl5.Text = "Ngày nhận mẫu :"
        '
        'DtNgaylaymau
        '
        Me.DtNgaylaymau.EditValue = Nothing
        Me.DtNgaylaymau.Location = New System.Drawing.Point(912, 13)
        Me.DtNgaylaymau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtNgaylaymau.Name = "DtNgaylaymau"
        Me.DtNgaylaymau.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtNgaylaymau.Properties.Appearance.Options.UseFont = True
        Me.DtNgaylaymau.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtNgaylaymau.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtNgaylaymau.Size = New System.Drawing.Size(180, 22)
        Me.DtNgaylaymau.TabIndex = 49
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
        Me.SimpleButton2.Location = New System.Drawing.Point(692, 23)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(105, 44)
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
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BntTaodulieu), New DevExpress.XtraBars.LinkPersistInfo(Me.BntXoadulieu)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'Frmcheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 590)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frmcheck"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Checkthongtin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPhan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Checknuoctieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckMau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtNgaylaymau.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtNgaylaymau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimkiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlCongty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DenNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DenNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TuNgay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TuNgay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbSoiamdaoTableAdapter As KskDbDataSetTableAdapters.TbSoiamdaoTableAdapter
    Friend WithEvents NNamsinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHoten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NMacode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NIdSolieuhoso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NGioitinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NManhanvien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NBophan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCongty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNgaylaymau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCheckmau As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NChecknuoctieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCheckphan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CheckPhan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BntTaodulieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BntXoadulieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Checknuoctieu As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckMau As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtNgaylaymau As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTimkiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SlCongty As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents DenNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TuNgay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Checkthongtin As DevExpress.XtraEditors.CheckEdit
End Class
