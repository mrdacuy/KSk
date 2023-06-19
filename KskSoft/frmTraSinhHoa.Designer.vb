<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraSinhHoa
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
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NIdSolieuhoso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NAST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NALT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGGT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NGlucose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCreatine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NCholesterol = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NTriglyceride = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NHDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NLDL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.NUric = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NProtein = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GridControl2.Size = New System.Drawing.Size(861, 357)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NIdSolieuhoso, Me.NAST, Me.NALT, Me.NGGT, Me.NGlucose, Me.NCreatine, Me.NUre, Me.NCholesterol, Me.NTriglyceride, Me.NHDL, Me.NLDL, Me.NUric, Me.NProtein})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'NIdSolieuhoso
        '
        Me.NIdSolieuhoso.Caption = "Id"
        Me.NIdSolieuhoso.FieldName = "IdSolieuhoso"
        Me.NIdSolieuhoso.Name = "NIdSolieuhoso"
        Me.NIdSolieuhoso.Visible = True
        Me.NIdSolieuhoso.VisibleIndex = 0
        '
        'NAST
        '
        Me.NAST.Caption = "AST "
        Me.NAST.FieldName = "AST"
        Me.NAST.Name = "NAST"
        Me.NAST.Visible = True
        Me.NAST.VisibleIndex = 1
        '
        'NALT
        '
        Me.NALT.Caption = "ALT "
        Me.NALT.FieldName = "ALT"
        Me.NALT.Name = "NALT"
        Me.NALT.Visible = True
        Me.NALT.VisibleIndex = 2
        '
        'NGGT
        '
        Me.NGGT.Caption = "GGT "
        Me.NGGT.FieldName = "GGT"
        Me.NGGT.Name = "NGGT"
        Me.NGGT.Visible = True
        Me.NGGT.VisibleIndex = 3
        '
        'NGlucose
        '
        Me.NGlucose.Caption = "Glucose "
        Me.NGlucose.FieldName = "Glucose"
        Me.NGlucose.Name = "NGlucose"
        Me.NGlucose.Visible = True
        Me.NGlucose.VisibleIndex = 4
        '
        'NCreatine
        '
        Me.NCreatine.Caption = "Creatine "
        Me.NCreatine.FieldName = "Creatine"
        Me.NCreatine.Name = "NCreatine"
        Me.NCreatine.Visible = True
        Me.NCreatine.VisibleIndex = 5
        '
        'NUre
        '
        Me.NUre.Caption = "Ure "
        Me.NUre.FieldName = "Ure"
        Me.NUre.Name = "NUre"
        Me.NUre.Visible = True
        Me.NUre.VisibleIndex = 6
        '
        'NCholesterol
        '
        Me.NCholesterol.Caption = "Cholesterol "
        Me.NCholesterol.FieldName = "Cholesterol"
        Me.NCholesterol.Name = "NCholesterol"
        Me.NCholesterol.Visible = True
        Me.NCholesterol.VisibleIndex = 7
        '
        'NTriglyceride
        '
        Me.NTriglyceride.Caption = "Triglyceride"
        Me.NTriglyceride.FieldName = "Triglyceride"
        Me.NTriglyceride.Name = "NTriglyceride"
        Me.NTriglyceride.Visible = True
        Me.NTriglyceride.VisibleIndex = 8
        '
        'NHDL
        '
        Me.NHDL.Caption = "HDL "
        Me.NHDL.FieldName = "HDL"
        Me.NHDL.Name = "NHDL"
        Me.NHDL.Visible = True
        Me.NHDL.VisibleIndex = 9
        '
        'NLDL
        '
        Me.NLDL.Caption = "LDL "
        Me.NLDL.FieldName = "LDL"
        Me.NLDL.Name = "NLDL"
        Me.NLDL.Visible = True
        Me.NLDL.VisibleIndex = 10
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'NUric
        '
        Me.NUric.Caption = "Uric"
        Me.NUric.FieldName = "Uric"
        Me.NUric.Name = "NUric"
        Me.NUric.Visible = True
        Me.NUric.VisibleIndex = 11
        '
        'NProtein
        '
        Me.NProtein.Caption = "Protein "
        Me.NProtein.FieldName = "Protein"
        Me.NProtein.Name = "NProtein"
        Me.NProtein.Visible = True
        Me.NProtein.VisibleIndex = 12
        '
        'frmTraSinhHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 357)
        Me.Controls.Add(Me.GridControl2)
        Me.Name = "frmTraSinhHoa"
        Me.Text = "frmTraSinhHoa"
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NIdSolieuhoso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NAST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NALT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGGT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NGlucose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCreatine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NCholesterol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NTriglyceride As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NHDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NLDL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUric As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NProtein As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
