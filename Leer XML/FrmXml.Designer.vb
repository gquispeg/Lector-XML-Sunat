<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXml
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUbl = New System.Windows.Forms.TextBox()
        Me.TxtHash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEstructura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCertificado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSignature = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtNombreTipo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Hash"
        '
        'txtUbl
        '
        Me.txtUbl.Location = New System.Drawing.Point(79, 20)
        Me.txtUbl.Name = "txtUbl"
        Me.txtUbl.ReadOnly = True
        Me.txtUbl.Size = New System.Drawing.Size(56, 20)
        Me.txtUbl.TabIndex = 85
        '
        'TxtHash
        '
        Me.TxtHash.Location = New System.Drawing.Point(79, 73)
        Me.TxtHash.Name = "TxtHash"
        Me.TxtHash.ReadOnly = True
        Me.TxtHash.Size = New System.Drawing.Size(391, 20)
        Me.TxtHash.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "UBL"
        '
        'TxtEstructura
        '
        Me.TxtEstructura.Location = New System.Drawing.Point(202, 20)
        Me.TxtEstructura.Name = "TxtEstructura"
        Me.TxtEstructura.ReadOnly = True
        Me.TxtEstructura.Size = New System.Drawing.Size(56, 20)
        Me.TxtEstructura.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Estructura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCertificado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtSignature)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 196)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algoritmos"
        '
        'TxtCertificado
        '
        Me.TxtCertificado.Location = New System.Drawing.Point(79, 100)
        Me.TxtCertificado.Multiline = True
        Me.TxtCertificado.Name = "TxtCertificado"
        Me.TxtCertificado.ReadOnly = True
        Me.TxtCertificado.Size = New System.Drawing.Size(455, 75)
        Me.TxtCertificado.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Certificado"
        '
        'TxtSignature
        '
        Me.TxtSignature.Location = New System.Drawing.Point(79, 19)
        Me.TxtSignature.Multiline = True
        Me.TxtSignature.Name = "TxtSignature"
        Me.TxtSignature.ReadOnly = True
        Me.TxtSignature.Size = New System.Drawing.Size(455, 75)
        Me.TxtSignature.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Signature"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtNombreTipo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtTipo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtHash)
        Me.GroupBox2.Controls.Add(Me.txtUbl)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtEstructura)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 115)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Xml"
        '
        'TxtNombreTipo
        '
        Me.TxtNombreTipo.Location = New System.Drawing.Point(139, 46)
        Me.TxtNombreTipo.Name = "TxtNombreTipo"
        Me.TxtNombreTipo.ReadOnly = True
        Me.TxtNombreTipo.Size = New System.Drawing.Size(331, 20)
        Me.TxtNombreTipo.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Tipo"
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(79, 46)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(56, 20)
        Me.TxtTipo.TabIndex = 105
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Location = New System.Drawing.Point(475, 347)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(89, 23)
        Me.BtnSalir.TabIndex = 113
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmXml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 389)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmXml"
        Me.ShowInTaskbar = False
        Me.Text = "Detalle XML"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUbl As TextBox
    Friend WithEvents TxtHash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEstructura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCertificado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSignature As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents TxtNombreTipo As TextBox
End Class
