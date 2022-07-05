<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.TxtSubEntity = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtDistrito = New System.Windows.Forms.TextBox()
        Me.TxtUbigeo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Location = New System.Drawing.Point(410, 234)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(89, 23)
        Me.BtnSalir.TabIndex = 82
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(108, 198)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.ReadOnly = True
        Me.TxtPais.Size = New System.Drawing.Size(149, 20)
        Me.TxtPais.TabIndex = 81
        '
        'TxtSubEntity
        '
        Me.TxtSubEntity.Location = New System.Drawing.Point(356, 174)
        Me.TxtSubEntity.Name = "TxtSubEntity"
        Me.TxtSubEntity.ReadOnly = True
        Me.TxtSubEntity.Size = New System.Drawing.Size(143, 20)
        Me.TxtSubEntity.TabIndex = 80
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(108, 174)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.ReadOnly = True
        Me.TxtCiudad.Size = New System.Drawing.Size(149, 20)
        Me.TxtCiudad.TabIndex = 79
        '
        'TxtDistrito
        '
        Me.TxtDistrito.Location = New System.Drawing.Point(308, 151)
        Me.TxtDistrito.Name = "TxtDistrito"
        Me.TxtDistrito.ReadOnly = True
        Me.TxtDistrito.Size = New System.Drawing.Size(191, 20)
        Me.TxtDistrito.TabIndex = 78
        '
        'TxtUbigeo
        '
        Me.TxtUbigeo.Location = New System.Drawing.Point(108, 151)
        Me.TxtUbigeo.Name = "TxtUbigeo"
        Me.TxtUbigeo.ReadOnly = True
        Me.TxtUbigeo.Size = New System.Drawing.Size(149, 20)
        Me.TxtUbigeo.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Pais"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Dirección"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(263, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "CountrySubentity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Ciudad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Distrito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Ubigeo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Razón social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(305, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "N°"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(350, 47)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.ReadOnly = True
        Me.TxtNumero.Size = New System.Drawing.Size(149, 20)
        Me.TxtNumero.TabIndex = 68
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(108, 93)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(391, 54)
        Me.TxtDireccion.TabIndex = 67
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(108, 47)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(194, 20)
        Me.TxtTipo.TabIndex = 66
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(108, 70)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.ReadOnly = True
        Me.TxtRazonSocial.Size = New System.Drawing.Size(391, 20)
        Me.TxtRazonSocial.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Tipo documento"
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(518, 295)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TxtPais)
        Me.Controls.Add(Me.TxtSubEntity)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.TxtDistrito)
        Me.Controls.Add(Me.TxtUbigeo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos de cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents TxtSubEntity As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtDistrito As TextBox
    Friend WithEvents TxtUbigeo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents Label2 As Label
End Class
