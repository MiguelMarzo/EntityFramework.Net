<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaCampeonato
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtCampeon = New System.Windows.Forms.TextBox()
        Me.txtSubCampeon = New System.Windows.Forms.TextBox()
        Me.txtTantosSubCampeon = New System.Windows.Forms.TextBox()
        Me.txtFronton = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pelotari campeon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pelotari subcampeon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(491, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tantos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 171)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Frontón"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(183, 36)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(79, 22)
        Me.txtAño.TabIndex = 6
        '
        'txtCampeon
        '
        Me.txtCampeon.Location = New System.Drawing.Point(183, 74)
        Me.txtCampeon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCampeon.Name = "txtCampeon"
        Me.txtCampeon.Size = New System.Drawing.Size(303, 22)
        Me.txtCampeon.TabIndex = 7
        '
        'txtSubCampeon
        '
        Me.txtSubCampeon.Location = New System.Drawing.Point(183, 117)
        Me.txtSubCampeon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubCampeon.Name = "txtSubCampeon"
        Me.txtSubCampeon.Size = New System.Drawing.Size(303, 22)
        Me.txtSubCampeon.TabIndex = 9
        '
        'txtTantosSubCampeon
        '
        Me.txtTantosSubCampeon.Location = New System.Drawing.Point(552, 112)
        Me.txtTantosSubCampeon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTantosSubCampeon.Name = "txtTantosSubCampeon"
        Me.txtTantosSubCampeon.Size = New System.Drawing.Size(64, 22)
        Me.txtTantosSubCampeon.TabIndex = 10
        '
        'txtFronton
        '
        Me.txtFronton.Location = New System.Drawing.Point(183, 171)
        Me.txtFronton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFronton.Name = "txtFronton"
        Me.txtFronton.Size = New System.Drawing.Size(299, 22)
        Me.txtFronton.TabIndex = 11
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(161, 244)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(159, 38)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(385, 244)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(159, 38)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmAltaCampeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 321)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtFronton)
        Me.Controls.Add(Me.txtTantosSubCampeon)
        Me.Controls.Add(Me.txtSubCampeon)
        Me.Controls.Add(Me.txtCampeon)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAltaCampeonato"
        Me.Text = "Campeonatos de manomanistas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtCampeon As TextBox
    Friend WithEvents txtSubCampeon As TextBox
    Friend WithEvents txtTantosSubCampeon As TextBox
    Friend WithEvents txtFronton As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnVolver As Button
End Class
