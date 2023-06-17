<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.crvFechasReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'dtpInicio
        '
        Me.dtpInicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpInicio.Location = New System.Drawing.Point(61, 42)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(405, 20)
        Me.dtpInicio.TabIndex = 0
        '
        'dtpFinal
        '
        Me.dtpFinal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFinal.Location = New System.Drawing.Point(61, 79)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(405, 20)
        Me.dtpFinal.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Location = New System.Drawing.Point(498, 42)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(114, 57)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Ejecutar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'crvFechasReporte
        '
        Me.crvFechasReporte.ActiveViewIndex = -1
        Me.crvFechasReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvFechasReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvFechasReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvFechasReporte.Location = New System.Drawing.Point(61, 163)
        Me.crvFechasReporte.Name = "crvFechasReporte"
        Me.crvFechasReporte.ShowCloseButton = False
        Me.crvFechasReporte.ShowGroupTreeButton = False
        Me.crvFechasReporte.ShowLogo = False
        Me.crvFechasReporte.ShowParameterPanelButton = False
        Me.crvFechasReporte.Size = New System.Drawing.Size(594, 407)
        Me.crvFechasReporte.TabIndex = 3
        Me.crvFechasReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 582)
        Me.Controls.Add(Me.crvFechasReporte)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents crvFechasReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
