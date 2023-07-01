<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongtinphanmem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNgay = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ngày kết hạn :"
        '
        'txtNgay
        '
        Me.txtNgay.AutoSize = True
        Me.txtNgay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNgay.Location = New System.Drawing.Point(157, 42)
        Me.txtNgay.Name = "txtNgay"
        Me.txtNgay.Size = New System.Drawing.Size(45, 19)
        Me.txtNgay.TabIndex = 1
        Me.txtNgay.Text = "Ngày"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(144, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "THÔNG TIN PHẦN MỀM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bản quyền thuộc Xe Quang Lưu Động Bs Trung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(405, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Chi tiết liên hệ : NGUYỄN ĐẮC UY - SĐT : 0866212828"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        'Me.SimpleButton1.ImageOptions.SvgImage = Global.NDSoftSA.My.Resources.Resources.security_key
        Me.SimpleButton1.Location = New System.Drawing.Point(175, 133)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(121, 32)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Nhập Key"
        '
        'frmThongtinphanmem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 177)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNgay)
        Me.Controls.Add(Me.Label1)
        Me.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LookAndFeel.SkinName = "DevExpress Style"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(497, 209)
        Me.MinimumSize = New System.Drawing.Size(497, 209)
        Me.Name = "frmThongtinphanmem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNgay As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
