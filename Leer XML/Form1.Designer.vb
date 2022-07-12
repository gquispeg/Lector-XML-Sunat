<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtArchivoXml = New System.Windows.Forms.TextBox()
        Me.TxtEmisor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvItems = New System.Windows.Forms.DataGridView()
        Me.colOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValorVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnXml = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDocumentoTipo = New System.Windows.Forms.TextBox()
        Me.TxtDocumentoNumero = New System.Windows.Forms.TextBox()
        Me.TxtEmision = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIgvMonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotalFactura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblIgvPorcentaje = New System.Windows.Forms.Label()
        Me.TxtTipoOperacion = New System.Windows.Forms.TextBox()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.BtnArchivoXml = New System.Windows.Forms.Button()
        Me.btnEmisor = New System.Windows.Forms.Button()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta Archivo XML"
        '
        'TxtArchivoXml
        '
        Me.TxtArchivoXml.Location = New System.Drawing.Point(119, 6)
        Me.TxtArchivoXml.Name = "TxtArchivoXml"
        Me.TxtArchivoXml.ReadOnly = True
        Me.TxtArchivoXml.Size = New System.Drawing.Size(442, 20)
        Me.TxtArchivoXml.TabIndex = 2
        '
        'TxtEmisor
        '
        Me.TxtEmisor.Location = New System.Drawing.Point(119, 29)
        Me.TxtEmisor.Name = "TxtEmisor"
        Me.TxtEmisor.ReadOnly = True
        Me.TxtEmisor.Size = New System.Drawing.Size(442, 20)
        Me.TxtEmisor.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Emisor"
        '
        'DgvItems
        '
        Me.DgvItems.AllowUserToAddRows = False
        Me.DgvItems.AllowUserToDeleteRows = False
        Me.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOrden, Me.colCantidad, Me.colCodigo, Me.colDescripcion, Me.colUnitario, Me.colPrecioUnitario, Me.colValorVenta})
        Me.DgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItems.Location = New System.Drawing.Point(3, 3)
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.ReadOnly = True
        Me.DgvItems.Size = New System.Drawing.Size(577, 254)
        Me.DgvItems.TabIndex = 12
        '
        'colOrden
        '
        Me.colOrden.DataPropertyName = "orden"
        Me.colOrden.FillWeight = 25.0!
        Me.colOrden.HeaderText = "O#"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.ReadOnly = True
        Me.colOrden.Width = 25
        '
        'colCantidad
        '
        Me.colCantidad.DataPropertyName = "Cantidad"
        Me.colCantidad.FillWeight = 50.0!
        Me.colCantidad.HeaderText = "Cant."
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.ReadOnly = True
        Me.colCantidad.Width = 50
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "CodigoProducto"
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.DataPropertyName = "Descripcion"
        Me.colDescripcion.FillWeight = 300.0!
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        Me.colDescripcion.Width = 300
        '
        'colUnitario
        '
        Me.colUnitario.DataPropertyName = "ValorUnitario"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colUnitario.DefaultCellStyle = DataGridViewCellStyle1
        Me.colUnitario.HeaderText = "Unitario"
        Me.colUnitario.Name = "colUnitario"
        Me.colUnitario.ReadOnly = True
        '
        'colPrecioUnitario
        '
        Me.colPrecioUnitario.DataPropertyName = "ValorVentaPorItem"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colPrecioUnitario.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPrecioUnitario.HeaderText = "P.unitario"
        Me.colPrecioUnitario.Name = "colPrecioUnitario"
        Me.colPrecioUnitario.ReadOnly = True
        '
        'colValorVenta
        '
        Me.colValorVenta.DataPropertyName = "ValorReferencialUnitarioPorItemNoOnerosa"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colValorVenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.colValorVenta.HeaderText = "ValorVenta"
        Me.colValorVenta.Name = "colValorVenta"
        Me.colValorVenta.ReadOnly = True
        '
        'BtnXml
        '
        Me.BtnXml.Location = New System.Drawing.Point(3, 417)
        Me.BtnXml.Name = "BtnXml"
        Me.BtnXml.Size = New System.Drawing.Size(134, 23)
        Me.BtnXml.TabIndex = 19
        Me.BtnXml.Text = "Ver XML"
        Me.BtnXml.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 126)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 286)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvItems)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(583, 260)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Items"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(583, 260)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tributos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(583, 260)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cuotas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(76, 55)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(39, 13)
        Me.lblRazonSocial.TabIndex = 5
        Me.lblRazonSocial.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(119, 52)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(442, 20)
        Me.TxtCliente.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Documento"
        '
        'TxtDocumentoTipo
        '
        Me.TxtDocumentoTipo.Location = New System.Drawing.Point(119, 75)
        Me.TxtDocumentoTipo.Name = "TxtDocumentoTipo"
        Me.TxtDocumentoTipo.ReadOnly = True
        Me.TxtDocumentoTipo.Size = New System.Drawing.Size(116, 20)
        Me.TxtDocumentoTipo.TabIndex = 8
        '
        'TxtDocumentoNumero
        '
        Me.TxtDocumentoNumero.Location = New System.Drawing.Point(238, 75)
        Me.TxtDocumentoNumero.Name = "TxtDocumentoNumero"
        Me.TxtDocumentoNumero.ReadOnly = True
        Me.TxtDocumentoNumero.Size = New System.Drawing.Size(98, 20)
        Me.TxtDocumentoNumero.TabIndex = 26
        '
        'TxtEmision
        '
        Me.TxtEmision.Location = New System.Drawing.Point(119, 98)
        Me.TxtEmision.Name = "TxtEmision"
        Me.TxtEmision.ReadOnly = True
        Me.TxtEmision.Size = New System.Drawing.Size(77, 20)
        Me.TxtEmision.TabIndex = 28
        Me.TxtEmision.Text = "//"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Emisión"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(491, 414)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(97, 20)
        Me.TxtSubTotal.TabIndex = 30
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(440, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Sub total"
        '
        'TxtIgvMonto
        '
        Me.TxtIgvMonto.Location = New System.Drawing.Point(491, 436)
        Me.TxtIgvMonto.Name = "TxtIgvMonto"
        Me.TxtIgvMonto.ReadOnly = True
        Me.TxtIgvMonto.Size = New System.Drawing.Size(97, 20)
        Me.TxtIgvMonto.TabIndex = 32
        Me.TxtIgvMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "I.G.V."
        '
        'TxtTotalFactura
        '
        Me.TxtTotalFactura.Location = New System.Drawing.Point(491, 458)
        Me.TxtTotalFactura.Name = "TxtTotalFactura"
        Me.TxtTotalFactura.ReadOnly = True
        Me.TxtTotalFactura.Size = New System.Drawing.Size(97, 20)
        Me.TxtTotalFactura.TabIndex = 34
        Me.TxtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total comprobante"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Son:"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(50, 461)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(43, 13)
        Me.LblPrecio.TabIndex = 38
        Me.LblPrecio.Text = "Emisión"
        '
        'LblIgvPorcentaje
        '
        Me.LblIgvPorcentaje.AutoSize = True
        Me.LblIgvPorcentaje.Location = New System.Drawing.Point(453, 439)
        Me.LblIgvPorcentaje.Name = "LblIgvPorcentaje"
        Me.LblIgvPorcentaje.Size = New System.Drawing.Size(27, 13)
        Me.LblIgvPorcentaje.TabIndex = 40
        Me.LblIgvPorcentaje.Text = "19%"
        '
        'TxtTipoOperacion
        '
        Me.TxtTipoOperacion.Location = New System.Drawing.Point(339, 75)
        Me.TxtTipoOperacion.Name = "TxtTipoOperacion"
        Me.TxtTipoOperacion.ReadOnly = True
        Me.TxtTipoOperacion.Size = New System.Drawing.Size(222, 20)
        Me.TxtTipoOperacion.TabIndex = 41
        '
        'btnCliente
        '
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.Location = New System.Drawing.Point(565, 51)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(23, 23)
        Me.btnCliente.TabIndex = 25
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'BtnArchivoXml
        '
        Me.BtnArchivoXml.Image = Global.Leer_XML.My.Resources.Resources.btnAbrir
        Me.BtnArchivoXml.Location = New System.Drawing.Point(565, 5)
        Me.BtnArchivoXml.Name = "BtnArchivoXml"
        Me.BtnArchivoXml.Size = New System.Drawing.Size(23, 23)
        Me.BtnArchivoXml.TabIndex = 24
        Me.BtnArchivoXml.UseVisualStyleBackColor = True
        '
        'btnEmisor
        '
        Me.btnEmisor.Image = CType(resources.GetObject("btnEmisor.Image"), System.Drawing.Image)
        Me.btnEmisor.Location = New System.Drawing.Point(565, 28)
        Me.btnEmisor.Name = "btnEmisor"
        Me.btnEmisor.Size = New System.Drawing.Size(23, 23)
        Me.btnEmisor.TabIndex = 23
        Me.btnEmisor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 489)
        Me.Controls.Add(Me.TxtTipoOperacion)
        Me.Controls.Add(Me.LblIgvPorcentaje)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTotalFactura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtIgvMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEmision)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDocumentoNumero)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.BtnArchivoXml)
        Me.Controls.Add(Me.btnEmisor)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnXml)
        Me.Controls.Add(Me.TxtDocumentoTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.TxtEmisor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtArchivoXml)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtArchivoXml As TextBox
    Friend WithEvents TxtEmisor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvItems As DataGridView
    Friend WithEvents BtnXml As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents btnEmisor As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents BtnArchivoXml As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDocumentoTipo As TextBox
    Friend WithEvents TxtDocumentoNumero As TextBox
    Friend WithEvents TxtEmision As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIgvMonto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalFactura As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblIgvPorcentaje As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TxtTipoOperacion As TextBox
    Friend WithEvents colOrden As DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As DataGridViewTextBoxColumn
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents colUnitario As DataGridViewTextBoxColumn
    Friend WithEvents colPrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents colValorVenta As DataGridViewTextBoxColumn
End Class
