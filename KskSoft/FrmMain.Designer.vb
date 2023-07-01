<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Maincontrainer = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.mUCcONGTY = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.BtnThemCongTy = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.lbltieude = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Maincontrainer
        '
        Me.Maincontrainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Maincontrainer.Location = New System.Drawing.Point(258, 30)
        Me.Maincontrainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Maincontrainer.Name = "Maincontrainer"
        Me.Maincontrainer.Size = New System.Drawing.Size(1191, 772)
        Me.Maincontrainer.TabIndex = 2
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.AccordionControl1.Appearance.AccordionControl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccordionControl1.Appearance.AccordionControl.Options.UseBackColor = True
        Me.AccordionControl1.Appearance.AccordionControl.Options.UseFont = True
        Me.AccordionControl1.Appearance.Item.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccordionControl1.Appearance.Item.Normal.Options.UseFont = True
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1, Me.mUCcONGTY})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 30)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.Size = New System.Drawing.Size(258, 772)
        Me.AccordionControl1.TabIndex = 3
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement2, Me.AccordionControlElement3, Me.AccordionControlElement4, Me.AccordionControlElement5})
        Me.AccordionControlElement1.Expanded = True
        Me.AccordionControlElement1.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "DANH MỤC TIẾP NHẬN"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "THU NHẬN HỒ SƠ"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement3.Text = "IN GIẤY KSK"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "IN BARCODE TEM 3"
        '
        'AccordionControlElement5
        '
        Me.AccordionControlElement5.ImageOptions.SvgImage = CType(resources.GetObject("AccordionControlElement5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.AccordionControlElement5.Name = "AccordionControlElement5"
        Me.AccordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement5.Text = "IN BARCODE TEM 4"
        '
        'mUCcONGTY
        '
        Me.mUCcONGTY.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.BtnThemCongTy})
        Me.mUCcONGTY.Expanded = True
        Me.mUCcONGTY.ImageOptions.SvgImage = CType(resources.GetObject("mUCcONGTY.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.mUCcONGTY.Name = "mUCcONGTY"
        Me.mUCcONGTY.Text = "DANH MỤC CÔNG TY"
        '
        'BtnThemCongTy
        '
        Me.BtnThemCongTy.ImageOptions.SvgImage = CType(resources.GetObject("BtnThemCongTy.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnThemCongTy.Name = "BtnThemCongTy"
        Me.BtnThemCongTy.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.BtnThemCongTy.Text = "THÊM CÔNG TY"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.lbltieude})
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1449, 30)
        Me.FluentDesignFormControl1.TabIndex = 4
        Me.FluentDesignFormControl1.TabStop = False
        Me.FluentDesignFormControl1.TitleItemLinks.Add(Me.lbltieude)
        '
        'lbltieude
        '
        Me.lbltieude.Caption = ".."
        Me.lbltieude.Id = 0
        Me.lbltieude.Name = "lbltieude"
        Me.lbltieude.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1449, 802)
        Me.ControlContainer = Me.Maincontrainer
        Me.Controls.Add(Me.Maincontrainer)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMain"
        Me.NavigationControl = Me.AccordionControl1
        Me.Text = "PHẦN MỀM HỖ TRỢ KSK ĐỊNH KỲ"
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Maincontrainer As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents lbltieude As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents mUCcONGTY As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents BtnThemCongTy As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement
End Class
