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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtArchivoXml = New System.Windows.Forms.TextBox()
        Me.TxtEmisor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnXmlPreliminar = New System.Windows.Forms.Button()
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
        Me.LblIgvPorcentaje = New System.Windows.Forms.Label()
        Me.TxtTipoOperacion = New System.Windows.Forms.TextBox()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.BtnArchivoXml = New System.Windows.Forms.Button()
        Me.btnEmisor = New System.Windows.Forms.Button()
        Me.TxtGravada = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtGratuita = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Notas = New System.Windows.Forms.TabPage()
        Me.dgvNotas = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bases = New System.Windows.Forms.TabPage()
        Me.DgvSumas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tributos = New System.Windows.Forms.TabPage()
        Me.DgvTributos = New System.Windows.Forms.DataGridView()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Forma = New System.Windows.Forms.TabPage()
        Me.DgvCondicion = New System.Windows.Forms.DataGridView()
        Me.Items = New System.Windows.Forms.TabPage()
        Me.DgvItems = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BtnXml = New System.Windows.Forms.Button()
        Me.colOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValorVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormaPagoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormaPagoMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormaPagoFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notas.SuspendLayout()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bases.SuspendLayout()
        CType(Me.DgvSumas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tributos.SuspendLayout()
        CType(Me.DgvTributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Forma.SuspendLayout()
        CType(Me.DgvCondicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Items.SuspendLayout()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
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
        'BtnXmlPreliminar
        '
        Me.BtnXmlPreliminar.Location = New System.Drawing.Point(3, 417)
        Me.BtnXmlPreliminar.Name = "BtnXmlPreliminar"
        Me.BtnXmlPreliminar.Size = New System.Drawing.Size(134, 23)
        Me.BtnXmlPreliminar.TabIndex = 19
        Me.BtnXmlPreliminar.Text = "Ver XML"
        Me.BtnXmlPreliminar.UseVisualStyleBackColor = True
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
        Me.TxtSubTotal.Size = New System.Drawing.Size(96, 20)
        Me.TxtSubTotal.TabIndex = 30
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(439, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Sub total"
        '
        'TxtIgvMonto
        '
        Me.TxtIgvMonto.Location = New System.Drawing.Point(491, 478)
        Me.TxtIgvMonto.Name = "TxtIgvMonto"
        Me.TxtIgvMonto.ReadOnly = True
        Me.TxtIgvMonto.Size = New System.Drawing.Size(96, 20)
        Me.TxtIgvMonto.TabIndex = 32
        Me.TxtIgvMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 482)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "I.G.V."
        '
        'TxtTotalFactura
        '
        Me.TxtTotalFactura.Location = New System.Drawing.Point(491, 499)
        Me.TxtTotalFactura.Name = "TxtTotalFactura"
        Me.TxtTotalFactura.ReadOnly = True
        Me.TxtTotalFactura.Size = New System.Drawing.Size(96, 20)
        Me.TxtTotalFactura.TabIndex = 34
        Me.TxtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total comprobante"
        '
        'LblIgvPorcentaje
        '
        Me.LblIgvPorcentaje.AutoSize = True
        Me.LblIgvPorcentaje.Location = New System.Drawing.Point(452, 482)
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
        'TxtGravada
        '
        Me.TxtGravada.Location = New System.Drawing.Point(491, 457)
        Me.TxtGravada.Name = "TxtGravada"
        Me.TxtGravada.ReadOnly = True
        Me.TxtGravada.Size = New System.Drawing.Size(96, 20)
        Me.TxtGravada.TabIndex = 43
        Me.TxtGravada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 461)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Op. Gravadas"
        '
        'TxtGratuita
        '
        Me.TxtGratuita.Location = New System.Drawing.Point(491, 436)
        Me.TxtGratuita.Name = "TxtGratuita"
        Me.TxtGratuita.ReadOnly = True
        Me.TxtGratuita.Size = New System.Drawing.Size(96, 20)
        Me.TxtGratuita.TabIndex = 45
        Me.TxtGratuita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(394, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Total Op. gratuitas"
        '
        'LblPrecio
        '
        Me.LblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblPrecio.Location = New System.Drawing.Point(3, 457)
        Me.LblPrecio.Multiline = True
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.ReadOnly = True
        Me.LblPrecio.Size = New System.Drawing.Size(383, 58)
        Me.LblPrecio.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Son:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 518)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Total comprobante"
        '
        'Notas
        '
        Me.Notas.Controls.Add(Me.dgvNotas)
        Me.Notas.Location = New System.Drawing.Point(4, 22)
        Me.Notas.Name = "Notas"
        Me.Notas.Padding = New System.Windows.Forms.Padding(3)
        Me.Notas.Size = New System.Drawing.Size(583, 260)
        Me.Notas.TabIndex = 5
        Me.Notas.Text = "Notas"
        Me.Notas.UseVisualStyleBackColor = True
        '
        'dgvNotas
        '
        Me.dgvNotas.AllowUserToAddRows = False
        Me.dgvNotas.AllowUserToDeleteRows = False
        Me.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNota})
        Me.dgvNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotas.Location = New System.Drawing.Point(3, 3)
        Me.dgvNotas.Name = "dgvNotas"
        Me.dgvNotas.ReadOnly = True
        Me.dgvNotas.Size = New System.Drawing.Size(577, 254)
        Me.dgvNotas.TabIndex = 0
        '
        'colId
        '
        Me.colId.DataPropertyName = "codigo"
        Me.colId.FillWeight = 20.0!
        Me.colId.HeaderText = "Código"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        '
        'colNota
        '
        Me.colNota.DataPropertyName = "nota"
        Me.colNota.FillWeight = 150.0!
        Me.colNota.HeaderText = "Notas"
        Me.colNota.Name = "colNota"
        Me.colNota.ReadOnly = True
        '
        'Bases
        '
        Me.Bases.Controls.Add(Me.DgvSumas)
        Me.Bases.Location = New System.Drawing.Point(4, 22)
        Me.Bases.Name = "Bases"
        Me.Bases.Padding = New System.Windows.Forms.Padding(3)
        Me.Bases.Size = New System.Drawing.Size(583, 260)
        Me.Bases.TabIndex = 4
        Me.Bases.Text = "Bases de calculo"
        Me.Bases.UseVisualStyleBackColor = True
        '
        'DgvSumas
        '
        Me.DgvSumas.AllowUserToAddRows = False
        Me.DgvSumas.AllowUserToDeleteRows = False
        Me.DgvSumas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSumas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSumas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DgvSumas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSumas.Location = New System.Drawing.Point(3, 3)
        Me.DgvSumas.Name = "DgvSumas"
        Me.DgvSumas.ReadOnly = True
        Me.DgvSumas.Size = New System.Drawing.Size(577, 254)
        Me.DgvSumas.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn1.FillWeight = 250.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "base"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "n2"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.HeaderText = "Base"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "monto"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "n2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Tributos
        '
        Me.Tributos.Controls.Add(Me.DgvTributos)
        Me.Tributos.Location = New System.Drawing.Point(4, 22)
        Me.Tributos.Name = "Tributos"
        Me.Tributos.Padding = New System.Windows.Forms.Padding(3)
        Me.Tributos.Size = New System.Drawing.Size(583, 260)
        Me.Tributos.TabIndex = 3
        Me.Tributos.Text = "Tributos"
        Me.Tributos.UseVisualStyleBackColor = True
        '
        'DgvTributos
        '
        Me.DgvTributos.AllowUserToAddRows = False
        Me.DgvTributos.AllowUserToDeleteRows = False
        Me.DgvTributos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTributos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre, Me.colBase, Me.colMonto})
        Me.DgvTributos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTributos.Location = New System.Drawing.Point(3, 3)
        Me.DgvTributos.Name = "DgvTributos"
        Me.DgvTributos.ReadOnly = True
        Me.DgvTributos.Size = New System.Drawing.Size(577, 254)
        Me.DgvTributos.TabIndex = 0
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "nombre"
        Me.colNombre.FillWeight = 250.0!
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colBase
        '
        Me.colBase.DataPropertyName = "base"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "n2"
        Me.colBase.DefaultCellStyle = DataGridViewCellStyle10
        Me.colBase.HeaderText = "Base"
        Me.colBase.Name = "colBase"
        Me.colBase.ReadOnly = True
        '
        'colMonto
        '
        Me.colMonto.DataPropertyName = "monto"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "n2"
        Me.colMonto.DefaultCellStyle = DataGridViewCellStyle11
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.ReadOnly = True
        '
        'Forma
        '
        Me.Forma.Controls.Add(Me.DgvCondicion)
        Me.Forma.Location = New System.Drawing.Point(4, 22)
        Me.Forma.Name = "Forma"
        Me.Forma.Padding = New System.Windows.Forms.Padding(3)
        Me.Forma.Size = New System.Drawing.Size(583, 260)
        Me.Forma.TabIndex = 2
        Me.Forma.Text = "Forma de pago"
        Me.Forma.UseVisualStyleBackColor = True
        '
        'DgvCondicion
        '
        Me.DgvCondicion.AllowUserToAddRows = False
        Me.DgvCondicion.AllowUserToDeleteRows = False
        Me.DgvCondicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCondicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCondicion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFormaPagoId, Me.colFormaPagoMonto, Me.colFormaPagoFecha})
        Me.DgvCondicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCondicion.Location = New System.Drawing.Point(3, 3)
        Me.DgvCondicion.Name = "DgvCondicion"
        Me.DgvCondicion.ReadOnly = True
        Me.DgvCondicion.Size = New System.Drawing.Size(577, 254)
        Me.DgvCondicion.TabIndex = 0
        '
        'Items
        '
        Me.Items.Controls.Add(Me.DgvItems)
        Me.Items.Location = New System.Drawing.Point(4, 22)
        Me.Items.Name = "Items"
        Me.Items.Padding = New System.Windows.Forms.Padding(3)
        Me.Items.Size = New System.Drawing.Size(583, 260)
        Me.Items.TabIndex = 0
        Me.Items.Text = "Items"
        Me.Items.UseVisualStyleBackColor = True
        '
        'DgvItems
        '
        Me.DgvItems.AllowUserToAddRows = False
        Me.DgvItems.AllowUserToDeleteRows = False
        Me.DgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOrden, Me.colCantidad, Me.colCodigo, Me.colDescripcion, Me.colUnitario, Me.colValorVenta, Me.colIgv, Me.ColPrecioVenta})
        Me.DgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItems.Location = New System.Drawing.Point(3, 3)
        Me.DgvItems.MultiSelect = False
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.ReadOnly = True
        Me.DgvItems.RowHeadersVisible = False
        Me.DgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItems.Size = New System.Drawing.Size(577, 254)
        Me.DgvItems.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Items)
        Me.TabControl1.Controls.Add(Me.Forma)
        Me.TabControl1.Controls.Add(Me.Tributos)
        Me.TabControl1.Controls.Add(Me.Bases)
        Me.TabControl1.Controls.Add(Me.Notas)
        Me.TabControl1.Location = New System.Drawing.Point(3, 126)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(591, 286)
        Me.TabControl1.TabIndex = 20
        '
        'BtnXml
        '
        Me.BtnXml.Image = CType(resources.GetObject("BtnXml.Image"), System.Drawing.Image)
        Me.BtnXml.Location = New System.Drawing.Point(565, 74)
        Me.BtnXml.Name = "BtnXml"
        Me.BtnXml.Size = New System.Drawing.Size(23, 23)
        Me.BtnXml.TabIndex = 48
        Me.BtnXml.UseVisualStyleBackColor = True
        '
        'colOrden
        '
        Me.colOrden.FillWeight = 25.0!
        Me.colOrden.HeaderText = "O#"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.ReadOnly = True
        '
        'colCantidad
        '
        Me.colCantidad.FillWeight = 50.0!
        Me.colCantidad.HeaderText = "Cant."
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.ReadOnly = True
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.FillWeight = 300.0!
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        '
        'colUnitario
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.colUnitario.DefaultCellStyle = DataGridViewCellStyle12
        Me.colUnitario.HeaderText = "Unitario"
        Me.colUnitario.Name = "colUnitario"
        Me.colUnitario.ReadOnly = True
        '
        'colValorVenta
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.colValorVenta.DefaultCellStyle = DataGridViewCellStyle13
        Me.colValorVenta.HeaderText = "ValorVenta"
        Me.colValorVenta.Name = "colValorVenta"
        Me.colValorVenta.ReadOnly = True
        '
        'colIgv
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.colIgv.DefaultCellStyle = DataGridViewCellStyle14
        Me.colIgv.HeaderText = "IGV"
        Me.colIgv.Name = "colIgv"
        Me.colIgv.ReadOnly = True
        Me.colIgv.Visible = False
        '
        'ColPrecioVenta
        '
        Me.ColPrecioVenta.HeaderText = "Venta"
        Me.ColPrecioVenta.Name = "ColPrecioVenta"
        Me.ColPrecioVenta.ReadOnly = True
        Me.ColPrecioVenta.Visible = False
        '
        'colFormaPagoId
        '
        Me.colFormaPagoId.DataPropertyName = "Id"
        Me.colFormaPagoId.HeaderText = "ID"
        Me.colFormaPagoId.Name = "colFormaPagoId"
        Me.colFormaPagoId.ReadOnly = True
        '
        'colFormaPagoMonto
        '
        Me.colFormaPagoMonto.DataPropertyName = "Monto"
        Me.colFormaPagoMonto.HeaderText = "Monto"
        Me.colFormaPagoMonto.Name = "colFormaPagoMonto"
        Me.colFormaPagoMonto.ReadOnly = True
        '
        'colFormaPagoFecha
        '
        Me.colFormaPagoFecha.DataPropertyName = "Fecha"
        Me.colFormaPagoFecha.HeaderText = "Fecha"
        Me.colFormaPagoFecha.Name = "colFormaPagoFecha"
        Me.colFormaPagoFecha.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 548)
        Me.Controls.Add(Me.BtnXml)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.TxtGratuita)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtGravada)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTipoOperacion)
        Me.Controls.Add(Me.LblIgvPorcentaje)
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
        Me.Controls.Add(Me.BtnXmlPreliminar)
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
        Me.Notas.ResumeLayout(False)
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bases.ResumeLayout(False)
        CType(Me.DgvSumas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tributos.ResumeLayout(False)
        CType(Me.DgvTributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Forma.ResumeLayout(False)
        CType(Me.DgvCondicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Items.ResumeLayout(False)
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtArchivoXml As TextBox
    Friend WithEvents TxtEmisor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnXmlPreliminar As Button
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
    Friend WithEvents LblIgvPorcentaje As Label
    Friend WithEvents TxtTipoOperacion As TextBox
    Friend WithEvents TxtGravada As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtGratuita As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LblPrecio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Notas As TabPage
    Friend WithEvents dgvNotas As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNota As DataGridViewTextBoxColumn
    Friend WithEvents Bases As TabPage
    Friend WithEvents DgvSumas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Tributos As TabPage
    Friend WithEvents DgvTributos As DataGridView
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colBase As DataGridViewTextBoxColumn
    Friend WithEvents colMonto As DataGridViewTextBoxColumn
    Friend WithEvents Forma As TabPage
    Friend WithEvents DgvCondicion As DataGridView
    Friend WithEvents Items As TabPage
    Friend WithEvents DgvItems As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BtnXml As Button
    Friend WithEvents colOrden As DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As DataGridViewTextBoxColumn
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents colUnitario As DataGridViewTextBoxColumn
    Friend WithEvents colValorVenta As DataGridViewTextBoxColumn
    Friend WithEvents colIgv As DataGridViewTextBoxColumn
    Friend WithEvents ColPrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents colFormaPagoId As DataGridViewTextBoxColumn
    Friend WithEvents colFormaPagoMonto As DataGridViewTextBoxColumn
    Friend WithEvents colFormaPagoFecha As DataGridViewTextBoxColumn
End Class
