<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpTem
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Ma11 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.Ma33 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.Ma22 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.Ma1 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ma2 = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Ma3 = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 17.70833!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 5.208333!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Ma11, Me.Ma33, Me.Ma22})
        Me.Detail.HeightF = 89.58334!
        Me.Detail.Name = "Detail"
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        '
        'Ma11
        '
        Me.Ma11.AutoModule = True
        Me.Ma11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma1")})
        Me.Ma11.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Ma11.LocationFloat = New DevExpress.Utils.PointFloat(3.0!, 10.00001!)
        Me.Ma11.Name = "Ma11"
        Me.Ma11.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.Ma11.SizeF = New System.Drawing.SizeF(130.0!, 60.83333!)
        Me.Ma11.StylePriority.UseFont = False
        Me.Ma11.StylePriority.UseTextAlignment = False
        Code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.Ma11.Symbology = Code128Generator1
        Me.Ma11.Text = "123"
        Me.Ma11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'Ma33
        '
        Me.Ma33.AutoModule = True
        Me.Ma33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma3")})
        Me.Ma33.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Ma33.LocationFloat = New DevExpress.Utils.PointFloat(279.6667!, 10.00001!)
        Me.Ma33.Name = "Ma33"
        Me.Ma33.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.Ma33.SizeF = New System.Drawing.SizeF(130.0!, 60.83333!)
        Me.Ma33.StylePriority.UseFont = False
        Me.Ma33.StylePriority.UseTextAlignment = False
        Code128Generator2.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.Ma33.Symbology = Code128Generator2
        Me.Ma33.Text = "c"
        Me.Ma33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'Ma22
        '
        Me.Ma22.AutoModule = True
        Me.Ma22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Ma2")})
        Me.Ma22.Font = New DevExpress.Drawing.DXFont("Arial", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.Ma22.LocationFloat = New DevExpress.Utils.PointFloat(141.75!, 10.00001!)
        Me.Ma22.Name = "Ma22"
        Me.Ma22.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.Ma22.SizeF = New System.Drawing.SizeF(130.0!, 60.83333!)
        Me.Ma22.StylePriority.UseFont = False
        Me.Ma22.StylePriority.UseTextAlignment = False
        Code128Generator3.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.Ma22.Symbology = Code128Generator3
        Me.Ma22.Text = "3000"
        Me.Ma22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
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
        'rpTem
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0!, 0!, 17.70833!, 5.208333!)
        Me.PageHeight = 90
        Me.PageWidth = 420
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.Ma1, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.Ma2, DevExpress.XtraReports.Parameters.Orientation.Horizontal), New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.Ma3, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Ma1, Me.Ma2, Me.Ma3})
        Me.Version = "22.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Ma33 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents Ma22 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents Ma11 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents Ma1 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Ma2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Ma3 As DevExpress.XtraReports.Parameters.Parameter
End Class
