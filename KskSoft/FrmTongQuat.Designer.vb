<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTongQuat
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NIdSolieuhoso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ncongty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NMacodd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHoten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNamsinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGioitinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NManhanvien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBophan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NChieucao = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCannang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NBMI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHuyetap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTheluc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTuanhoan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHohap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTieuhoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NThantietnieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNoitiet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCoxuongkhop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NThankinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTamthan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NNgoaikhoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NMat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTaimuihong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NRanghammat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NDalieu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSanphukhoa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSieuambung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nsieuamtuyengiap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nsieuamtuyenvu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSieuammachcanh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSoicotucung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NSieuamtim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NXquangphoi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NXquangCstl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NDientim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NDoloangxuong = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(0, 25)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1172, 456)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIdSolieuhoso, Me.Ncongty, Me.NMacodd, Me.NHoten, Me.NNamsinh, Me.NGioitinh, Me.NManhanvien, Me.NBophan, Me.NChieucao, Me.NCannang, Me.NBMI, Me.NHuyetap, Me.NTheluc, Me.NTuanhoan, Me.NHohap, Me.NTieuhoa, Me.NThantietnieu, Me.NNoitiet, Me.NCoxuongkhop, Me.NThankinh, Me.NTamthan, Me.NNgoaikhoa, Me.NMat, Me.NTaimuihong, Me.NRanghammat, Me.NDalieu, Me.NSanphukhoa, Me.NSieuambung, Me.Nsieuamtuyengiap, Me.Nsieuamtuyenvu, Me.NSieuammachcanh, Me.NSoicotucung, Me.NSieuamtim, Me.NXquangphoi, Me.NXquangCstl, Me.NDientim, Me.NDoloangxuong})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'NIdSolieuhoso
        '
        Me.NIdSolieuhoso.Caption = "Id"
        Me.NIdSolieuhoso.FieldName = "IdSolieuhoso"
        Me.NIdSolieuhoso.MinWidth = 23
        Me.NIdSolieuhoso.Name = "NIdSolieuhoso"
        Me.NIdSolieuhoso.Visible = True
        Me.NIdSolieuhoso.VisibleIndex = 0
        Me.NIdSolieuhoso.Width = 80
        '
        'Ncongty
        '
        Me.Ncongty.Caption = "Công ty"
        Me.Ncongty.FieldName = "Congty"
        Me.Ncongty.Name = "Ncongty"
        Me.Ncongty.Visible = True
        Me.Ncongty.VisibleIndex = 1
        '
        'NMacodd
        '
        Me.NMacodd.Caption = "ID"
        Me.NMacodd.FieldName = "Macode"
        Me.NMacodd.Name = "NMacodd"
        Me.NMacodd.Visible = True
        Me.NMacodd.VisibleIndex = 2
        '
        'NHoten
        '
        Me.NHoten.Caption = "HỌ TÊN"
        Me.NHoten.FieldName = "Hoten"
        Me.NHoten.Name = "NHoten"
        Me.NHoten.Visible = True
        Me.NHoten.VisibleIndex = 3
        Me.NHoten.Width = 161
        '
        'NNamsinh
        '
        Me.NNamsinh.Caption = "NĂM SINH"
        Me.NNamsinh.FieldName = "Namsinh"
        Me.NNamsinh.Name = "NNamsinh"
        Me.NNamsinh.Visible = True
        Me.NNamsinh.VisibleIndex = 4
        Me.NNamsinh.Width = 111
        '
        'NGioitinh
        '
        Me.NGioitinh.Caption = "GIỚI TÍNH"
        Me.NGioitinh.FieldName = "Gioitinh"
        Me.NGioitinh.Name = "NGioitinh"
        Me.NGioitinh.Visible = True
        Me.NGioitinh.VisibleIndex = 5
        '
        'NManhanvien
        '
        Me.NManhanvien.Caption = "MÃ NHÂN VIÊN"
        Me.NManhanvien.FieldName = "Manhanvien"
        Me.NManhanvien.Name = "NManhanvien"
        Me.NManhanvien.Visible = True
        Me.NManhanvien.VisibleIndex = 6
        Me.NManhanvien.Width = 93
        '
        'NBophan
        '
        Me.NBophan.Caption = "BỘ PHẬN"
        Me.NBophan.FieldName = "Bophan"
        Me.NBophan.Name = "NBophan"
        Me.NBophan.Visible = True
        Me.NBophan.VisibleIndex = 7
        '
        'NChieucao
        '
        Me.NChieucao.Caption = "CHIỀU CAO"
        Me.NChieucao.FieldName = "Chieucao"
        Me.NChieucao.MinWidth = 23
        Me.NChieucao.Name = "NChieucao"
        Me.NChieucao.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.NChieucao.Visible = True
        Me.NChieucao.VisibleIndex = 8
        Me.NChieucao.Width = 87
        '
        'NCannang
        '
        Me.NCannang.Caption = "CÂN NẶNG(KG)"
        Me.NCannang.FieldName = "Cannang"
        Me.NCannang.Name = "NCannang"
        Me.NCannang.Visible = True
        Me.NCannang.VisibleIndex = 9
        '
        'NBMI
        '
        Me.NBMI.Caption = "CHỈ SỐ BMI"
        Me.NBMI.FieldName = "BMI"
        Me.NBMI.Name = "NBMI"
        Me.NBMI.Visible = True
        Me.NBMI.VisibleIndex = 10
        '
        'NHuyetap
        '
        Me.NHuyetap.Caption = "HUYẾT ÁP"
        Me.NHuyetap.FieldName = "Huyetap"
        Me.NHuyetap.Name = "NHuyetap"
        Me.NHuyetap.Visible = True
        Me.NHuyetap.VisibleIndex = 11
        '
        'NTheluc
        '
        Me.NTheluc.Caption = "THỂ LỰC"
        Me.NTheluc.FieldName = "Theluc"
        Me.NTheluc.Name = "NTheluc"
        Me.NTheluc.Visible = True
        Me.NTheluc.VisibleIndex = 12
        '
        'NTuanhoan
        '
        Me.NTuanhoan.Caption = "TUẦN HOÀN"
        Me.NTuanhoan.FieldName = "Tuanhoan"
        Me.NTuanhoan.Name = "NTuanhoan"
        Me.NTuanhoan.Visible = True
        Me.NTuanhoan.VisibleIndex = 13
        '
        'NHohap
        '
        Me.NHohap.Caption = "HÔ HẤP"
        Me.NHohap.FieldName = "Hohap"
        Me.NHohap.Name = "NHohap"
        Me.NHohap.Visible = True
        Me.NHohap.VisibleIndex = 14
        '
        'NTieuhoa
        '
        Me.NTieuhoa.Caption = "TIÊU HÓA"
        Me.NTieuhoa.FieldName = "Tieuhoa"
        Me.NTieuhoa.Name = "NTieuhoa"
        Me.NTieuhoa.Visible = True
        Me.NTieuhoa.VisibleIndex = 15
        '
        'NThantietnieu
        '
        Me.NThantietnieu.Caption = "THẬN TIẾT NIỆU"
        Me.NThantietnieu.FieldName = "Thantietnieu"
        Me.NThantietnieu.Name = "NThantietnieu"
        Me.NThantietnieu.Visible = True
        Me.NThantietnieu.VisibleIndex = 16
        '
        'NNoitiet
        '
        Me.NNoitiet.Caption = "NỘI TIẾT"
        Me.NNoitiet.FieldName = "Noitiet"
        Me.NNoitiet.Name = "NNoitiet"
        Me.NNoitiet.Visible = True
        Me.NNoitiet.VisibleIndex = 17
        '
        'NCoxuongkhop
        '
        Me.NCoxuongkhop.Caption = "CƠ XƯƠNG KHỚP"
        Me.NCoxuongkhop.FieldName = "Coxuongkhop"
        Me.NCoxuongkhop.Name = "NCoxuongkhop"
        Me.NCoxuongkhop.Visible = True
        Me.NCoxuongkhop.VisibleIndex = 18
        '
        'NThankinh
        '
        Me.NThankinh.Caption = "THẦN KINH"
        Me.NThankinh.FieldName = "Thankinh"
        Me.NThankinh.Name = "NThankinh"
        Me.NThankinh.Visible = True
        Me.NThankinh.VisibleIndex = 19
        '
        'NTamthan
        '
        Me.NTamthan.Caption = "TÂM THẦN"
        Me.NTamthan.FieldName = "Tamthan"
        Me.NTamthan.Name = "NTamthan"
        Me.NTamthan.Visible = True
        Me.NTamthan.VisibleIndex = 20
        '
        'NNgoaikhoa
        '
        Me.NNgoaikhoa.Caption = "NGOẠI KHOA"
        Me.NNgoaikhoa.FieldName = "Ngoaikhoa"
        Me.NNgoaikhoa.Name = "NNgoaikhoa"
        Me.NNgoaikhoa.Visible = True
        Me.NNgoaikhoa.VisibleIndex = 21
        '
        'NMat
        '
        Me.NMat.Caption = "MẮT"
        Me.NMat.FieldName = "Mat"
        Me.NMat.Name = "NMat"
        Me.NMat.Visible = True
        Me.NMat.VisibleIndex = 22
        '
        'NTaimuihong
        '
        Me.NTaimuihong.Caption = "TAI MŨI HỌNG"
        Me.NTaimuihong.FieldName = "Taimuihong"
        Me.NTaimuihong.Name = "NTaimuihong"
        Me.NTaimuihong.Visible = True
        Me.NTaimuihong.VisibleIndex = 23
        '
        'NRanghammat
        '
        Me.NRanghammat.Caption = "RĂNG HÀM MẶT"
        Me.NRanghammat.FieldName = "Ranghammat"
        Me.NRanghammat.Name = "NRanghammat"
        Me.NRanghammat.Visible = True
        Me.NRanghammat.VisibleIndex = 24
        '
        'NDalieu
        '
        Me.NDalieu.Caption = "DA LIỄU"
        Me.NDalieu.FieldName = "Dalieu"
        Me.NDalieu.Name = "NDalieu"
        Me.NDalieu.Visible = True
        Me.NDalieu.VisibleIndex = 25
        '
        'NSanphukhoa
        '
        Me.NSanphukhoa.Caption = "SẢN PHỤ KHOA"
        Me.NSanphukhoa.FieldName = "Sanphukhoa"
        Me.NSanphukhoa.Name = "NSanphukhoa"
        Me.NSanphukhoa.Visible = True
        Me.NSanphukhoa.VisibleIndex = 26
        '
        'NSieuambung
        '
        Me.NSieuambung.Caption = "SIÊU ÂM BỤNG"
        Me.NSieuambung.FieldName = "Sieuambung"
        Me.NSieuambung.Name = "NSieuambung"
        Me.NSieuambung.Visible = True
        Me.NSieuambung.VisibleIndex = 27
        '
        'Nsieuamtuyengiap
        '
        Me.Nsieuamtuyengiap.Caption = "SIÊU ÂM TUYẾN GIÁP"
        Me.Nsieuamtuyengiap.FieldName = "Sieuamtuyengiap"
        Me.Nsieuamtuyengiap.Name = "Nsieuamtuyengiap"
        Me.Nsieuamtuyengiap.Visible = True
        Me.Nsieuamtuyengiap.VisibleIndex = 28
        '
        'Nsieuamtuyenvu
        '
        Me.Nsieuamtuyenvu.Caption = "SIÊU ÂM TUYẾN VÚ"
        Me.Nsieuamtuyenvu.FieldName = "Sieuamtuyenvu"
        Me.Nsieuamtuyenvu.Name = "Nsieuamtuyenvu"
        Me.Nsieuamtuyenvu.Visible = True
        Me.Nsieuamtuyenvu.VisibleIndex = 29
        '
        'NSieuammachcanh
        '
        Me.NSieuammachcanh.Caption = "SIÊU ÂM MẠCH CẢNH"
        Me.NSieuammachcanh.FieldName = "Sieuammachcanh"
        Me.NSieuammachcanh.Name = "NSieuammachcanh"
        Me.NSieuammachcanh.Visible = True
        Me.NSieuammachcanh.VisibleIndex = 30
        '
        'NSoicotucung
        '
        Me.NSoicotucung.Caption = "SOI CỔ TỬ CUNG"
        Me.NSoicotucung.FieldName = "Soicotucung"
        Me.NSoicotucung.Name = "NSoicotucung"
        Me.NSoicotucung.Visible = True
        Me.NSoicotucung.VisibleIndex = 31
        '
        'NSieuamtim
        '
        Me.NSieuamtim.Caption = "SIÊU ÂM TIM"
        Me.NSieuamtim.FieldName = "Sieuamtim"
        Me.NSieuamtim.Name = "NSieuamtim"
        Me.NSieuamtim.Visible = True
        Me.NSieuamtim.VisibleIndex = 32
        '
        'NXquangphoi
        '
        Me.NXquangphoi.Caption = "X- QUANG PHỔI"
        Me.NXquangphoi.FieldName = "Xquangphoi"
        Me.NXquangphoi.Name = "NXquangphoi"
        Me.NXquangphoi.Visible = True
        Me.NXquangphoi.VisibleIndex = 33
        '
        'NXquangCstl
        '
        Me.NXquangCstl.Caption = "X-QUANG CSTL"
        Me.NXquangCstl.FieldName = "XquangCstl"
        Me.NXquangCstl.Name = "NXquangCstl"
        Me.NXquangCstl.Visible = True
        Me.NXquangCstl.VisibleIndex = 34
        '
        'NDientim
        '
        Me.NDientim.Caption = "ĐIỆN TIM"
        Me.NDientim.FieldName = "Dientim"
        Me.NDientim.Name = "NDientim"
        Me.NDientim.Visible = True
        Me.NDientim.VisibleIndex = 35
        '
        'NDoloangxuong
        '
        Me.NDoloangxuong.Caption = "ĐO LOÃNG XƯƠNG"
        Me.NDoloangxuong.FieldName = "Doloangxuong"
        Me.NDoloangxuong.Name = "NDoloangxuong"
        Me.NDoloangxuong.Visible = True
        Me.NDoloangxuong.VisibleIndex = 36
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Tạo Dữ Liệu"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1172, 25)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 481)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1172, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 25)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 456)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1172, 25)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 456)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Tạo Data"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'FrmTongQuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 481)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmTongQuat"
        Me.Text = "FrmTongQuat"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NIdSolieuhoso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ncongty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NMacodd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHoten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNamsinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGioitinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NManhanvien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NBophan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NChieucao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCannang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NBMI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHuyetap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTheluc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTuanhoan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHohap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTieuhoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NThantietnieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNoitiet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCoxuongkhop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NThankinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTamthan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NNgoaikhoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NMat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTaimuihong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NRanghammat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NDalieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSanphukhoa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSieuambung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nsieuamtuyengiap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nsieuamtuyenvu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSieuammachcanh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSoicotucung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NSieuamtim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NXquangphoi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NXquangCstl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NDientim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NDoloangxuong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
End Class
