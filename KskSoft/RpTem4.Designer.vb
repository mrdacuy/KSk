<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RpTem4
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim Code128Generator2 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim Code128Generator3 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim Code128Generator4 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrBarCode4 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode3 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.Ma1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ma2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ma3 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ma4 = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 7.291667!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 6.25!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode4, Me.XrBarCode3, Me.XrBarCode2, Me.XrBarCode1})
        Me.Detail.HeightF = 37.5!
        Me.Detail.Name = "Detail"
        '
        'XrBarCode4
        '
        Me.XrBarCode4.AutoModule = True
        Me.XrBarCode4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma4")})
        Me.XrBarCode4.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!)
        Me.XrBarCode4.LocationFloat = New DevExpress.Utils.PointFloat(296.25!, 0!)
        Me.XrBarCode4.Name = "XrBarCode4"
        Me.XrBarCode4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode4.SizeF = New System.Drawing.SizeF(93.75003!, 35.83333!)
        Me.XrBarCode4.StylePriority.UseFont = False
        Me.XrBarCode4.StylePriority.UseTextAlignment = False
        Code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode4.Symbology = Code128Generator1
        Me.XrBarCode4.Text = "44"
        Me.XrBarCode4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode3
        '
        Me.XrBarCode3.AutoModule = True
        Me.XrBarCode3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma3")})
        Me.XrBarCode3.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrBarCode3.LocationFloat = New DevExpress.Utils.PointFloat(197.4999!, 0!)
        Me.XrBarCode3.Name = "XrBarCode3"
        Me.XrBarCode3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode3.SizeF = New System.Drawing.SizeF(93.75!, 35.83333!)
        Me.XrBarCode3.StylePriority.UseFont = False
        Me.XrBarCode3.StylePriority.UseTextAlignment = False
        Code128Generator2.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode3.Symbology = Code128Generator2
        Me.XrBarCode3.Text = "33"
        Me.XrBarCode3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode2
        '
        Me.XrBarCode2.AutoModule = True
        Me.XrBarCode2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma2")})
        Me.XrBarCode2.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(98.75!, 0!)
        Me.XrBarCode2.Name = "XrBarCode2"
        Me.XrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode2.SizeF = New System.Drawing.SizeF(93.74998!, 35.83333!)
        Me.XrBarCode2.StylePriority.UseFont = False
        Me.XrBarCode2.StylePriority.UseTextAlignment = False
        Code128Generator3.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode2.Symbology = Code128Generator3
        Me.XrBarCode2.Text = "22"
        Me.XrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma1")})
        Me.XrBarCode1.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(93.75!, 35.83333!)
        Me.XrBarCode1.StylePriority.UseFont = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Code128Generator4.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode1.Symbology = Code128Generator4
        Me.XrBarCode1.Text = "11"
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'Ma1
        '
        Me.Ma1.AllowNull = True
        Me.Ma1.Description = "Parameter1"
        Me.Ma1.MultiValue = True
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
        Me.Ma3.MultiValue = True
        Me.Ma3.Name = "Ma3"
        Me.Ma3.Visible = False
        '
        'Ma4
        '
        Me.Ma4.AllowNull = True
        Me.Ma4.Description = "Parameter1"
        Me.Ma4.MultiValue = True
        Me.Ma4.Name = "Ma4"
        Me.Ma4.Visible = False
        '
        'RpTem4
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(11.0!, 6.0!, 7.291667!, 6.25!)
        Me.PageHeight = 50
        Me.PageWidth = 421
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Ma1, Me.Ma2, Me.Ma3, Me.Ma4})
        Me.Version = "22.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrBarCode4 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode3 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode2 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents Ma1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Ma2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Ma3 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Ma4 As DevExpress.XtraReports.Parameters.Parameter
End Class
