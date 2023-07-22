<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Rptem3
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Code128Generator3 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim Code128Generator2 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode3 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.Ma1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ma2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ma3 = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 22.91667!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 5.208333!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode3, Me.XrBarCode2, Me.XrBarCode1})
        Me.Detail.HeightF = 88.54166!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 0, 0, 100.0!)
        Me.Detail.StylePriority.UsePadding = False
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma1")})
        Me.XrBarCode1.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 10.00001!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(116.8333!, 69.58332!)
        Me.XrBarCode1.StylePriority.UseFont = False
        Me.XrBarCode1.StylePriority.UsePadding = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Code128Generator3.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode1.Symbology = Code128Generator3
        Me.XrBarCode1.Text = "1111"
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode2
        '
        Me.XrBarCode2.AutoModule = True
        Me.XrBarCode2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma2")})
        Me.XrBarCode2.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(145.3334!, 10.00001!)
        Me.XrBarCode2.Name = "XrBarCode2"
        Me.XrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrBarCode2.SizeF = New System.Drawing.SizeF(116.8334!, 69.58332!)
        Me.XrBarCode2.StylePriority.UseFont = False
        Me.XrBarCode2.StylePriority.UsePadding = False
        Me.XrBarCode2.StylePriority.UseTextAlignment = False
        Code128Generator2.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode2.Symbology = Code128Generator2
        Me.XrBarCode2.Text = "1111"
        Me.XrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode3
        '
        Me.XrBarCode3.AutoModule = True
        Me.XrBarCode3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma3")})
        Me.XrBarCode3.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrBarCode3.LocationFloat = New DevExpress.Utils.PointFloat(285.1667!, 8.95834!)
        Me.XrBarCode3.Name = "XrBarCode3"
        Me.XrBarCode3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrBarCode3.SizeF = New System.Drawing.SizeF(116.8333!, 69.58332!)
        Me.XrBarCode3.StylePriority.UseFont = False
        Me.XrBarCode3.StylePriority.UsePadding = False
        Me.XrBarCode3.StylePriority.UseTextAlignment = False
        Code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode3.Symbology = Code128Generator1
        Me.XrBarCode3.Text = "1111"
        Me.XrBarCode3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'Ma1
        '
        Me.Ma1.AllowNull = True
        Me.Ma1.Description = "Parameter1"
        Me.Ma1.Name = "Ma1"
        Me.Ma1.Visible = False
        '
        'Ma2
        '
        Me.Ma2.AllowNull = True
        Me.Ma2.Description = "Parameter1"
        Me.Ma2.MultiValue = True
        Me.Ma2.Name = "Ma2"
        Me.Ma2.Visible = False
        '
        'Ma3
        '
        Me.Ma3.AllowNull = True
        Me.Ma3.Description = "Parameter1"
        Me.Ma3.Name = "Ma3"
        Me.Ma3.Visible = False
        '
        'Rptem3
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(5.0!, 8.0!, 22.91667!, 5.208333!)
        Me.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 0, 0, 100.0!)
        Me.PageHeight = 100
        Me.PageWidth = 415
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Ma1, Me.Ma2, Me.Ma3})
        Me.Version = "22.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode3 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode2 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents Ma1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Ma2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Ma3 As DevExpress.XtraReports.Parameters.Parameter
End Class
