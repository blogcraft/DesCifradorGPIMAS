<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesCifrador
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesCifrador))
        Me.TxtEntrada = New System.Windows.Forms.TextBox
        Me.TxtSalida = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TtBtnCifrar = New System.Windows.Forms.ToolStripButton
        Me.TtBtnDesCifrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.TxtNegocio = New System.Windows.Forms.ToolStripTextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtEntrada
        '
        Me.TxtEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEntrada.Location = New System.Drawing.Point(110, 32)
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(339, 20)
        Me.TxtEntrada.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TxtEntrada, "Ingrese el Texto a Cifrar/DesCifrar")
        '
        'TxtSalida
        '
        Me.TxtSalida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSalida.Location = New System.Drawing.Point(110, 58)
        Me.TxtSalida.Name = "TxtSalida"
        Me.TxtSalida.ReadOnly = True
        Me.TxtSalida.Size = New System.Drawing.Size(339, 20)
        Me.TxtSalida.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Texto de Entrada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Resultado:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 96)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(461, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(29, 17)
        Me.ToolStripStatusLabel1.Text = "Listo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TtBtnCifrar, Me.TtBtnDesCifrar, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.TxtNegocio})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(461, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TtBtnCifrar
        '
        Me.TtBtnCifrar.Image = CType(resources.GetObject("TtBtnCifrar.Image"), System.Drawing.Image)
        Me.TtBtnCifrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TtBtnCifrar.Name = "TtBtnCifrar"
        Me.TtBtnCifrar.Size = New System.Drawing.Size(54, 22)
        Me.TtBtnCifrar.Text = "Cifrar"
        Me.TtBtnCifrar.ToolTipText = "Cifrar Texto de Entrada"
        '
        'TtBtnDesCifrar
        '
        Me.TtBtnDesCifrar.Image = CType(resources.GetObject("TtBtnDesCifrar.Image"), System.Drawing.Image)
        Me.TtBtnDesCifrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TtBtnDesCifrar.Name = "TtBtnDesCifrar"
        Me.TtBtnDesCifrar.Size = New System.Drawing.Size(72, 22)
        Me.TtBtnDesCifrar.Text = "DesCifrar"
        Me.TtBtnDesCifrar.ToolTipText = "DesCifrar Texto de Entrada"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "Negocio:"
        '
        'TxtNegocio
        '
        Me.TxtNegocio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNegocio.ForeColor = System.Drawing.Color.Silver
        Me.TxtNegocio.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtNegocio.Name = "TxtNegocio"
        Me.TxtNegocio.Size = New System.Drawing.Size(100, 23)
        Me.TxtNegocio.Text = "Default"
        Me.TxtNegocio.ToolTipText = "Ingresar Negocio"
        '
        'DesCifrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 118)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSalida)
        Me.Controls.Add(Me.TxtEntrada)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 145)
        Me.MinimumSize = New System.Drawing.Size(300, 145)
        Me.Name = "DesCifrador"
        Me.Text = "DesCifrador GPI+"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtEntrada As System.Windows.Forms.TextBox
    Friend WithEvents TxtSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TtBtnCifrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TtBtnDesCifrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TxtNegocio As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
