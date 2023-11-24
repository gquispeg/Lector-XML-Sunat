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
        Me.TxtSignature = New System.Windows.Forms.TextBox()
        Me.TxtCanonical = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUbl = New System.Windows.Forms.TextBox()
        Me.TxtHash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEstructura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtMetodoHash = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTransform = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtFirmaEmisor = New System.Windows.Forms.TextBox()
        Me.LblFirmaEmisor = New System.Windows.Forms.Label()
        Me.TxtCertificadoEmisor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtEmisor = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtSignature
        '
        Me.TxtSignature.Location = New System.Drawing.Point(79, 48)
        Me.TxtSignature.Name = "TxtSignature"
        Me.TxtSignature.ReadOnly = True
        Me.TxtSignature.Size = New System.Drawing.Size(455, 20)
        Me.TxtSignature.TabIndex = 98
        '
        'TxtCanonical
        '
        Me.TxtCanonical.Location = New System.Drawing.Point(79, 25)
        Me.TxtCanonical.Name = "TxtCanonical"
        Me.TxtCanonical.ReadOnly = True
        Me.TxtCanonical.Size = New System.Drawing.Size(455, 20)
        Me.TxtCanonical.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Signature"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Canonical"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 47)
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
        Me.TxtHash.Location = New System.Drawing.Point(79, 45)
        Me.TxtHash.Name = "TxtHash"
        Me.TxtHash.ReadOnly = True
        Me.TxtHash.Size = New System.Drawing.Size(391, 20)
        Me.TxtHash.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 22)
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
        Me.GroupBox1.Controls.Add(Me.TxtMetodoHash)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtTransform)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtSignature)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtCanonical)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 128)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algoritmos"
        '
        'TxtMetodoHash
        '
        Me.TxtMetodoHash.Location = New System.Drawing.Point(79, 92)
        Me.TxtMetodoHash.Name = "TxtMetodoHash"
        Me.TxtMetodoHash.ReadOnly = True
        Me.TxtMetodoHash.Size = New System.Drawing.Size(455, 20)
        Me.TxtMetodoHash.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Met. Hash"
        '
        'TxtTransform
        '
        Me.TxtTransform.Location = New System.Drawing.Point(79, 70)
        Me.TxtTransform.Name = "TxtTransform"
        Me.TxtTransform.ReadOnly = True
        Me.TxtTransform.Size = New System.Drawing.Size(455, 20)
        Me.TxtTransform.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Transform"
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Size = New System.Drawing.Size(542, 84)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Xml"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Tipo"
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(309, 20)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(56, 20)
        Me.TxtTipo.TabIndex = 105
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtFirmaEmisor)
        Me.GroupBox4.Controls.Add(Me.LblFirmaEmisor)
        Me.GroupBox4.Controls.Add(Me.TxtCertificadoEmisor)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtEmisor)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 248)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(542, 104)
        Me.GroupBox4.TabIndex = 105
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Firmas emisor"
        '
        'TxtFirmaEmisor
        '
        Me.TxtFirmaEmisor.Location = New System.Drawing.Point(79, 68)
        Me.TxtFirmaEmisor.Name = "TxtFirmaEmisor"
        Me.TxtFirmaEmisor.ReadOnly = True
        Me.TxtFirmaEmisor.Size = New System.Drawing.Size(455, 20)
        Me.TxtFirmaEmisor.TabIndex = 100
        '
        'LblFirmaEmisor
        '
        Me.LblFirmaEmisor.AutoSize = True
        Me.LblFirmaEmisor.Location = New System.Drawing.Point(40, 71)
        Me.LblFirmaEmisor.Name = "LblFirmaEmisor"
        Me.LblFirmaEmisor.Size = New System.Drawing.Size(32, 13)
        Me.LblFirmaEmisor.TabIndex = 99
        Me.LblFirmaEmisor.Text = "Firma"
        '
        'TxtCertificadoEmisor
        '
        Me.TxtCertificadoEmisor.Location = New System.Drawing.Point(79, 46)
        Me.TxtCertificadoEmisor.Name = "TxtCertificadoEmisor"
        Me.TxtCertificadoEmisor.ReadOnly = True
        Me.TxtCertificadoEmisor.Size = New System.Drawing.Size(455, 20)
        Me.TxtCertificadoEmisor.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(34, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Emisor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Certificado"
        '
        'TxtEmisor
        '
        Me.TxtEmisor.Location = New System.Drawing.Point(79, 23)
        Me.TxtEmisor.Name = "TxtEmisor"
        Me.TxtEmisor.ReadOnly = True
        Me.TxtEmisor.Size = New System.Drawing.Size(455, 20)
        Me.TxtEmisor.TabIndex = 96
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Location = New System.Drawing.Point(475, 369)
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
        Me.ClientSize = New System.Drawing.Size(588, 419)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox4)
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtSignature As TextBox
    Friend WithEvents TxtCanonical As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUbl As TextBox
    Friend WithEvents TxtHash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEstructura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtMetodoHash As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTransform As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtFirmaEmisor As TextBox
    Friend WithEvents LblFirmaEmisor As Label
    Friend WithEvents TxtCertificadoEmisor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtEmisor As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTipo As TextBox
End Class
