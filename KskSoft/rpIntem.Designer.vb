<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpIntem
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
        Dim Code39ExtendedGenerator1 As DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator = New DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrBarCode3 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrBarCode4 = New DevExpress.XtraReports.UI.XRBarCode()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 6.25!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 468.75!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode4, Me.XrBarCode3, Me.XrBarCode2, Me.XrBarCode1})
        Me.Detail.HeightF = 195.8333!
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        '
        'XrBarCode3
        '
        Me.XrBarCode3.LocationFloat = New DevExpress.Utils.PointFloat(242.0001!, 10.00001!)
        Me.XrBarCode3.Name = "XrBarCode3"
        Me.XrBarCode3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode3.SizeF = New System.Drawing.SizeF(189.5834!, 75.0!)
        Me.XrBarCode3.StylePriority.UseTextAlignment = False
        Me.XrBarCode3.Symbology = Code128Generator1
        Me.XrBarCode3.Text = "2222"
        Me.XrBarCode3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode2
        '
        Me.XrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(10.75002!, 100.625!)
        Me.XrBarCode2.Name = "XrBarCode2"
        Me.XrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode2.SizeF = New System.Drawing.SizeF(188.8333!, 74.99999!)
        Me.XrBarCode2.StylePriority.UseTextAlignment = False
        Code128Generator2.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
        Me.XrBarCode2.Symbology = Code128Generator2
        Me.XrBarCode2.Text = "c43c"
        Me.XrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode1
        '
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(189.5834!, 75.0!)
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = Code128Generator3
        Me.XrBarCode1.Text = "2222"
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrBarCode4
        '
        Me.XrBarCode4.AutoModule = True
        Me.XrBarCode4.LocationFloat = New DevExpress.Utils.PointFloat(199.5833!, 85.00001!)
        Me.XrBarCode4.Name = "XrBarCode4"
        Me.XrBarCode4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode4.SizeF = New System.Drawing.SizeF(192.7084!, 58.33334!)
        Code39ExtendedGenerator1.WideNarrowRatio = 3.0!
        Me.XrBarCode4.Symbology = Code39ExtendedGenerator1
        Me.XrBarCode4.Text = "2222"
        '
        'rpIntem
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(13.0!, 18.58329!, 6.25!, 468.75!)
        Me.PageHeight = 717
        Me.PageWidth = 504
        Me.PaperKind = System.Drawing.Printing.PaperKind.B6Jis
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "22.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode3 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode2 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrBarCode4 As DevExpress.XtraReports.UI.XRBarCode
End Class
