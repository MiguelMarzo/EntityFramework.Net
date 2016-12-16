<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCampeones
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
        Me.btnCampeonatosPelotari = New System.Windows.Forms.Button()
        Me.dgvCampeonatos = New System.Windows.Forms.DataGridView()
        Me.txtPelotari = New System.Windows.Forms.TextBox()
        Me.btnAltaCampeonato = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnCampeonatosProvincia = New System.Windows.Forms.Button()
        Me.txtNombreProvincia = New System.Windows.Forms.TextBox()
        CType(Me.dgvCampeonatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCampeonatosPelotari
        '
        Me.btnCampeonatosPelotari.Location = New System.Drawing.Point(43, 36)
        Me.btnCampeonatosPelotari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCampeonatosPelotari.Name = "btnCampeonatosPelotari"
        Me.btnCampeonatosPelotari.Size = New System.Drawing.Size(335, 28)
        Me.btnCampeonatosPelotari.TabIndex = 0
        Me.btnCampeonatosPelotari.Text = "Campeonatos de Pelotari"
        Me.btnCampeonatosPelotari.UseVisualStyleBackColor = True
        '
        'dgvCampeonatos
        '
        Me.dgvCampeonatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCampeonatos.Location = New System.Drawing.Point(29, 124)
        Me.dgvCampeonatos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCampeonatos.Name = "dgvCampeonatos"
        Me.dgvCampeonatos.Size = New System.Drawing.Size(1008, 276)
        Me.dgvCampeonatos.TabIndex = 1
        '
        'txtPelotari
        '
        Me.txtPelotari.Location = New System.Drawing.Point(453, 36)
        Me.txtPelotari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPelotari.Name = "txtPelotari"
        Me.txtPelotari.Size = New System.Drawing.Size(397, 22)
        Me.txtPelotari.TabIndex = 2
        '
        'btnAltaCampeonato
        '
        Me.btnAltaCampeonato.Location = New System.Drawing.Point(203, 427)
        Me.btnAltaCampeonato.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAltaCampeonato.Name = "btnAltaCampeonato"
        Me.btnAltaCampeonato.Size = New System.Drawing.Size(199, 31)
        Me.btnAltaCampeonato.TabIndex = 4
        Me.btnAltaCampeonato.Text = "&Alta nuevo campeonato"
        Me.btnAltaCampeonato.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(520, 427)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(172, 31)
        Me.btnFinalizar.TabIndex = 14
        Me.btnFinalizar.Text = "&Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnCampeonatosProvincia
        '
        Me.btnCampeonatosProvincia.Location = New System.Drawing.Point(43, 71)
        Me.btnCampeonatosProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCampeonatosProvincia.Name = "btnCampeonatosProvincia"
        Me.btnCampeonatosProvincia.Size = New System.Drawing.Size(403, 28)
        Me.btnCampeonatosProvincia.TabIndex = 15
        Me.btnCampeonatosProvincia.Text = "Campeonatos en que ha ganado algún pelotari de provincia"
        Me.btnCampeonatosProvincia.UseVisualStyleBackColor = True
        '
        'txtNombreProvincia
        '
        Me.txtNombreProvincia.Location = New System.Drawing.Point(453, 75)
        Me.txtNombreProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProvincia.Name = "txtNombreProvincia"
        Me.txtNombreProvincia.Size = New System.Drawing.Size(397, 22)
        Me.txtNombreProvincia.TabIndex = 16
        '
        'frmCampeones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 478)
        Me.Controls.Add(Me.txtNombreProvincia)
        Me.Controls.Add(Me.btnCampeonatosProvincia)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnAltaCampeonato)
        Me.Controls.Add(Me.txtPelotari)
        Me.Controls.Add(Me.dgvCampeonatos)
        Me.Controls.Add(Me.btnCampeonatosPelotari)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCampeones"
        Me.Text = "Pelotaris en campeonatos"
        CType(Me.dgvCampeonatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCampeonatosPelotari As Button
    Friend WithEvents dgvCampeonatos As DataGridView
    Friend WithEvents txtPelotari As TextBox
    Friend WithEvents btnAltaCampeonato As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnCampeonatosProvincia As Button
    Friend WithEvents txtNombreProvincia As TextBox
End Class
