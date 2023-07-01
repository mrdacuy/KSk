<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class RpNhan
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Id = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Hoten = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Namsinh = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Gioitinh = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Manhanvien = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Bophan = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Chucvu = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Congty = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Nghenghiep = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ngaykham = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 10.41667!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 9.375!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17, Me.XrLabel18, Me.XrLabel19, Me.XrLabel15, Me.XrLabel16, Me.XrLabel13, Me.XrLabel14, Me.XrLabel11, Me.XrLabel12, Me.XrLabel9, Me.XrLabel10, Me.XrLabel7, Me.XrLabel8, Me.XrLabel5, Me.XrLabel6, Me.XrLabel4, Me.XrLabel3, Me.XrBarCode1, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.HeightF = 173.7411!
        Me.Detail.Name = "Detail"
        '
        'XrLabel17
        '
        Me.XrLabel17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Nghenghiep")})
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(259.4582!, 3.000005!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(124.5418!, 19.875!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "1258"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(6.87503!, 122.25!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(88.5416!, 19.87498!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Ngày khám:"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ngaykham")})
        Me.XrLabel19.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(95.41663!, 122.25!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(291.5833!, 19.87498!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Sale"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Congty")})
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(65.20842!, 142.125!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(321.7914!, 19.875!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "CÔNG TY CP NGUYÊN LIỆU THỰC PHẨM Á CHÂU SÀI GÒN"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(6.874959!, 142.125!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(58.33347!, 19.875!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Công ty:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(200.0834!, 101.25!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(58.3334!, 19.87498!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Chức vụ:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.CanGrow = False
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Chucvu")})
        Me.XrLabel14.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(259.4583!, 101.25!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(127.5419!, 19.87498!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Sale"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Bophan")})
        Me.XrLabel11.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(65.20844!, 101.25!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(134.8749!, 19.875!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Bán hàng"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(6.87503!, 101.25!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(58.33341!, 19.875!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Bộ phận:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(200.0834!, 61.50003!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(68.75002!, 19.875!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Giới tính:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Gioitinh")})
        Me.XrLabel10.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(268.8335!, 61.50001!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(118.1667!, 19.875!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Nữ"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(6.87503!, 81.37503!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(88.54167!, 19.87499!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Mã nhân viên:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Manhanvien")})
        Me.XrLabel8.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(95.4167!, 81.37503!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(291.5833!, 19.87499!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "1254622"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(6.875094!, 61.50001!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(68.75!, 19.875!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Năm sinh:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Namsinh")})
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(75.6251!, 61.50003!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(124.4583!, 19.875!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "1995"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Hoten")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("times New Roman", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(54.79166!, 22.87502!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(332.2083!, 38.625!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "NGUYỄN VĂN A A A A A"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6.875006!, 22.87501!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(47.91666!, 38.625!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Họ tên:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Id")})
        Me.XrBarCode1.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(126.125!, 3.000005!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.ShowText = False
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(133.3333!, 19.875!)
        Me.XrBarCode1.StylePriority.UseFont = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = Code128Generator1
        Me.XrBarCode1.Text = "1258"
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Id")})
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("times New Roman", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(30.83334!, 3.000005!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(95.29164!, 19.875!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "1258"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("times New Roman", 9.75!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.875006!, 3.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(23.95833!, 19.875!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "ID:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Id
        '
        Me.Id.AllowNull = True
        Me.Id.Description = "Parameter1"
        Me.Id.MultiValue = True
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'Hoten
        '
        Me.Hoten.AllowNull = True
        Me.Hoten.Description = "Parameter1"
        Me.Hoten.MultiValue = True
        Me.Hoten.Name = "Hoten"
        Me.Hoten.Visible = False
        '
        'Namsinh
        '
        Me.Namsinh.AllowNull = True
        Me.Namsinh.Description = "Parameter1"
        Me.Namsinh.MultiValue = True
        Me.Namsinh.Name = "Namsinh"
        Me.Namsinh.Visible = False
        '
        'Gioitinh
        '
        Me.Gioitinh.AllowNull = True
        Me.Gioitinh.Description = "Parameter1"
        Me.Gioitinh.MultiValue = True
        Me.Gioitinh.Name = "Gioitinh"
        Me.Gioitinh.Visible = False
        '
        'Manhanvien
        '
        Me.Manhanvien.AllowNull = True
        Me.Manhanvien.Description = "Parameter1"
        Me.Manhanvien.MultiValue = True
        Me.Manhanvien.Name = "Manhanvien"
        Me.Manhanvien.Visible = False
        '
        'Bophan
        '
        Me.Bophan.AllowNull = True
        Me.Bophan.Description = "Parameter1"
        Me.Bophan.MultiValue = True
        Me.Bophan.Name = "Bophan"
        Me.Bophan.Visible = False
        '
        'Chucvu
        '
        Me.Chucvu.AllowNull = True
        Me.Chucvu.Description = "Parameter1"
        Me.Chucvu.MultiValue = True
        Me.Chucvu.Name = "Chucvu"
        Me.Chucvu.Visible = False
        '
        'Congty
        '
        Me.Congty.AllowNull = True
        Me.Congty.Description = "Parameter1"
        Me.Congty.MultiValue = True
        Me.Congty.Name = "Congty"
        Me.Congty.Visible = False
        '
        'Nghenghiep
        '
        Me.Nghenghiep.AllowNull = True
        Me.Nghenghiep.Description = "Parameter1"
        Me.Nghenghiep.Name = "Nghenghiep"
        Me.Nghenghiep.Visible = False
        '
        'Ngaykham
        '
        Me.Ngaykham.AllowNull = True
        Me.Ngaykham.Description = "Parameter1"
        Me.Ngaykham.Name = "Ngaykham"
        Me.Ngaykham.Visible = False
        '
        'RpNhan
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(4.0!, 9.0!, 10.41667!, 9.375!)
        Me.PageHeight = 200
        Me.PageWidth = 400
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Id, Me.Hoten, Me.Namsinh, Me.Gioitinh, Me.Manhanvien, Me.Bophan, Me.Chucvu, Me.Congty, Me.Nghenghiep, Me.Ngaykham})
        Me.Version = "22.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Id As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Hoten As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Namsinh As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Gioitinh As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Manhanvien As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Bophan As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Chucvu As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Congty As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Nghenghiep As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ngaykham As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
End Class
