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
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDocumentoTipo = New System.Windows.Forms.TextBox()
        Me.TxtDocumentoNumero = New System.Windows.Forms.TextBox()
        Me.TxtFechaEmision = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIgvMonto = New System.Windows.Forms.TextBox()
        Me.TxtTotalFactura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTipoOperacion = New System.Windows.Forms.TextBox()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.BtnArchivoXml = New System.Windows.Forms.Button()
        Me.btnEmisor = New System.Windows.Forms.Button()
        Me.TxtGravada = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtGratuita = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtHoraEmision = New System.Windows.Forms.TextBox()
        Me.TxtVencimiento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtMoneda = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtOtros = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtInafecto = New System.Windows.Forms.TextBox()
        Me.TxtExonerado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvItems = New System.Windows.Forms.DataGridView()
        Me.colOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColValorUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGravado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInafecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColExonerado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGratuito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvLeyenda = New System.Windows.Forms.DataGridView()
        Me.ColLeyendaCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLeyendaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDetraccionesMonto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnDetracciones = New System.Windows.Forms.Button()
        Me.TxtDetraccionesPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvLeyenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta Archivo XML"
        '
        'TxtArchivoXml
        '
        Me.TxtArchivoXml.Location = New System.Drawing.Point(119, 8)
        Me.TxtArchivoXml.Name = "TxtArchivoXml"
        Me.TxtArchivoXml.ReadOnly = True
        Me.TxtArchivoXml.Size = New System.Drawing.Size(345, 20)
        Me.TxtArchivoXml.TabIndex = 2
        '
        'TxtEmisor
        '
        Me.TxtEmisor.Location = New System.Drawing.Point(71, 20)
        Me.TxtEmisor.Name = "TxtEmisor"
        Me.TxtEmisor.ReadOnly = True
        Me.TxtEmisor.Size = New System.Drawing.Size(377, 20)
        Me.TxtEmisor.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Emisor"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(28, 46)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(39, 13)
        Me.lblRazonSocial.TabIndex = 5
        Me.lblRazonSocial.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(71, 43)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(377, 20)
        Me.TxtCliente.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Documento"
        '
        'TxtDocumentoTipo
        '
        Me.TxtDocumentoTipo.Location = New System.Drawing.Point(80, 19)
        Me.TxtDocumentoTipo.Name = "TxtDocumentoTipo"
        Me.TxtDocumentoTipo.ReadOnly = True
        Me.TxtDocumentoTipo.Size = New System.Drawing.Size(131, 20)
        Me.TxtDocumentoTipo.TabIndex = 8
        '
        'TxtDocumentoNumero
        '
        Me.TxtDocumentoNumero.Location = New System.Drawing.Point(215, 19)
        Me.TxtDocumentoNumero.Name = "TxtDocumentoNumero"
        Me.TxtDocumentoNumero.ReadOnly = True
        Me.TxtDocumentoNumero.Size = New System.Drawing.Size(137, 20)
        Me.TxtDocumentoNumero.TabIndex = 26
        '
        'TxtFechaEmision
        '
        Me.TxtFechaEmision.Location = New System.Drawing.Point(80, 41)
        Me.TxtFechaEmision.Name = "TxtFechaEmision"
        Me.TxtFechaEmision.ReadOnly = True
        Me.TxtFechaEmision.Size = New System.Drawing.Size(70, 20)
        Me.TxtFechaEmision.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Emisión"
        '
        'TxtIgvMonto
        '
        Me.TxtIgvMonto.Location = New System.Drawing.Point(768, 517)
        Me.TxtIgvMonto.Name = "TxtIgvMonto"
        Me.TxtIgvMonto.ReadOnly = True
        Me.TxtIgvMonto.Size = New System.Drawing.Size(96, 20)
        Me.TxtIgvMonto.TabIndex = 32
        Me.TxtIgvMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalFactura
        '
        Me.TxtTotalFactura.Location = New System.Drawing.Point(768, 559)
        Me.TxtTotalFactura.Name = "TxtTotalFactura"
        Me.TxtTotalFactura.ReadOnly = True
        Me.TxtTotalFactura.Size = New System.Drawing.Size(96, 20)
        Me.TxtTotalFactura.TabIndex = 34
        Me.TxtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(668, 562)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total comprobante"
        '
        'TxtTipoOperacion
        '
        Me.TxtTipoOperacion.Location = New System.Drawing.Point(71, 65)
        Me.TxtTipoOperacion.Name = "TxtTipoOperacion"
        Me.TxtTipoOperacion.ReadOnly = True
        Me.TxtTipoOperacion.Size = New System.Drawing.Size(377, 20)
        Me.TxtTipoOperacion.TabIndex = 41
        '
        'btnCliente
        '
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.Location = New System.Drawing.Point(450, 41)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(23, 23)
        Me.btnCliente.TabIndex = 25
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'BtnArchivoXml
        '
        Me.BtnArchivoXml.Image = Global.Leer_XML.My.Resources.Resources.btnAbrir
        Me.BtnArchivoXml.Location = New System.Drawing.Point(466, 7)
        Me.BtnArchivoXml.Name = "BtnArchivoXml"
        Me.BtnArchivoXml.Size = New System.Drawing.Size(23, 23)
        Me.BtnArchivoXml.TabIndex = 24
        Me.BtnArchivoXml.UseVisualStyleBackColor = True
        '
        'btnEmisor
        '
        Me.btnEmisor.Image = CType(resources.GetObject("btnEmisor.Image"), System.Drawing.Image)
        Me.btnEmisor.Location = New System.Drawing.Point(450, 18)
        Me.btnEmisor.Name = "btnEmisor"
        Me.btnEmisor.Size = New System.Drawing.Size(23, 23)
        Me.btnEmisor.TabIndex = 23
        Me.btnEmisor.UseVisualStyleBackColor = True
        '
        'TxtGravada
        '
        Me.TxtGravada.Location = New System.Drawing.Point(768, 433)
        Me.TxtGravada.Name = "TxtGravada"
        Me.TxtGravada.ReadOnly = True
        Me.TxtGravada.Size = New System.Drawing.Size(96, 20)
        Me.TxtGravada.TabIndex = 43
        Me.TxtGravada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(691, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Op. Gravadas"
        '
        'TxtGratuita
        '
        Me.TxtGratuita.Location = New System.Drawing.Point(768, 496)
        Me.TxtGratuita.Name = "TxtGratuita"
        Me.TxtGratuita.ReadOnly = True
        Me.TxtGratuita.Size = New System.Drawing.Size(96, 20)
        Me.TxtGratuita.TabIndex = 45
        Me.TxtGratuita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(695, 499)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Total gratuito"
        '
        'TxtHoraEmision
        '
        Me.TxtHoraEmision.Location = New System.Drawing.Point(152, 41)
        Me.TxtHoraEmision.Name = "TxtHoraEmision"
        Me.TxtHoraEmision.ReadOnly = True
        Me.TxtHoraEmision.Size = New System.Drawing.Size(59, 20)
        Me.TxtHoraEmision.TabIndex = 49
        '
        'TxtVencimiento
        '
        Me.TxtVencimiento.Location = New System.Drawing.Point(269, 41)
        Me.TxtVencimiento.Name = "TxtVencimiento"
        Me.TxtVencimiento.ReadOnly = True
        Me.TxtVencimiento.Size = New System.Drawing.Size(83, 20)
        Me.TxtVencimiento.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(231, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Vcto."
        '
        'TxtMoneda
        '
        Me.TxtMoneda.Location = New System.Drawing.Point(80, 63)
        Me.TxtMoneda.Name = "TxtMoneda"
        Me.TxtMoneda.ReadOnly = True
        Me.TxtMoneda.Size = New System.Drawing.Size(131, 20)
        Me.TxtMoneda.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Moneda"
        '
        'TxtOtros
        '
        Me.TxtOtros.Location = New System.Drawing.Point(768, 538)
        Me.TxtOtros.Name = "TxtOtros"
        Me.TxtOtros.ReadOnly = True
        Me.TxtOtros.Size = New System.Drawing.Size(96, 20)
        Me.TxtOtros.TabIndex = 55
        Me.TxtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(697, 542)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Otros cargos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(698, 458)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Op. Inafecto"
        '
        'TxtInafecto
        '
        Me.TxtInafecto.Location = New System.Drawing.Point(768, 454)
        Me.TxtInafecto.Name = "TxtInafecto"
        Me.TxtInafecto.ReadOnly = True
        Me.TxtInafecto.Size = New System.Drawing.Size(96, 20)
        Me.TxtInafecto.TabIndex = 55
        Me.TxtInafecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtExonerado
        '
        Me.TxtExonerado.Location = New System.Drawing.Point(768, 475)
        Me.TxtExonerado.Name = "TxtExonerado"
        Me.TxtExonerado.ReadOnly = True
        Me.TxtExonerado.Size = New System.Drawing.Size(96, 20)
        Me.TxtExonerado.TabIndex = 57
        Me.TxtExonerado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(686, 479)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Op. Exonerado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(730, 521)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "I.G.V."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtEmisor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblRazonSocial)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Controls.Add(Me.btnEmisor)
        Me.GroupBox1.Controls.Add(Me.btnCliente)
        Me.GroupBox1.Controls.Add(Me.TxtTipoOperacion)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 95)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entidades del documento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Operacion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtVencimiento)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtHoraEmision)
        Me.GroupBox2.Controls.Add(Me.TxtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtDocumentoNumero)
        Me.GroupBox2.Controls.Add(Me.TxtDocumentoTipo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtMoneda)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(502, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 95)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documento"
        '
        'DgvItems
        '
        Me.DgvItems.AllowUserToAddRows = False
        Me.DgvItems.AllowUserToDeleteRows = False
        Me.DgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOrden, Me.colCantidad, Me.ColMedida, Me.colDescripcion, Me.ColValorUnitario, Me.ColGravado, Me.ColInafecto, Me.ColExonerado, Me.ColGratuito, Me.ColIgv, Me.ColTotal})
        Me.DgvItems.Location = New System.Drawing.Point(16, 135)
        Me.DgvItems.MultiSelect = False
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.ReadOnly = True
        Me.DgvItems.RowHeadersVisible = False
        Me.DgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItems.Size = New System.Drawing.Size(849, 292)
        Me.DgvItems.TabIndex = 12
        '
        'colOrden
        '
        Me.colOrden.FillWeight = 25.0!
        Me.colOrden.HeaderText = "#"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.ReadOnly = True
        '
        'colCantidad
        '
        Me.colCantidad.FillWeight = 80.0!
        Me.colCantidad.HeaderText = "Cant."
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.ReadOnly = True
        '
        'ColMedida
        '
        Me.ColMedida.HeaderText = "UM"
        Me.ColMedida.Name = "ColMedida"
        Me.ColMedida.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.FillWeight = 300.0!
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        '
        'ColValorUnitario
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ColValorUnitario.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColValorUnitario.HeaderText = "Unitario"
        Me.ColValorUnitario.Name = "ColValorUnitario"
        Me.ColValorUnitario.ReadOnly = True
        '
        'ColGravado
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "n2"
        Me.ColGravado.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColGravado.HeaderText = "Gravado"
        Me.ColGravado.Name = "ColGravado"
        Me.ColGravado.ReadOnly = True
        '
        'ColInafecto
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "n2"
        Me.ColInafecto.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColInafecto.HeaderText = "Inafecto"
        Me.ColInafecto.Name = "ColInafecto"
        Me.ColInafecto.ReadOnly = True
        '
        'ColExonerado
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "n2"
        Me.ColExonerado.DefaultCellStyle = DataGridViewCellStyle11
        Me.ColExonerado.HeaderText = "Exonerado"
        Me.ColExonerado.Name = "ColExonerado"
        Me.ColExonerado.ReadOnly = True
        '
        'ColGratuito
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "n2"
        Me.ColGratuito.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColGratuito.HeaderText = "Gratuito"
        Me.ColGratuito.Name = "ColGratuito"
        Me.ColGratuito.ReadOnly = True
        '
        'ColIgv
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "n2"
        Me.ColIgv.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColIgv.HeaderText = "IGV"
        Me.ColIgv.Name = "ColIgv"
        Me.ColIgv.ReadOnly = True
        '
        'ColTotal
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "n2"
        Me.ColTotal.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColTotal.HeaderText = "Total"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.ReadOnly = True
        '
        'DgvLeyenda
        '
        Me.DgvLeyenda.AllowUserToAddRows = False
        Me.DgvLeyenda.AllowUserToDeleteRows = False
        Me.DgvLeyenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLeyenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLeyenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColLeyendaCodigo, Me.ColLeyendaDescripcion})
        Me.DgvLeyenda.Location = New System.Drawing.Point(16, 458)
        Me.DgvLeyenda.Name = "DgvLeyenda"
        Me.DgvLeyenda.ReadOnly = True
        Me.DgvLeyenda.RowHeadersVisible = False
        Me.DgvLeyenda.Size = New System.Drawing.Size(411, 121)
        Me.DgvLeyenda.TabIndex = 60
        '
        'ColLeyendaCodigo
        '
        Me.ColLeyendaCodigo.DataPropertyName = "codigo"
        Me.ColLeyendaCodigo.FillWeight = 50.0!
        Me.ColLeyendaCodigo.HeaderText = "Codigo"
        Me.ColLeyendaCodigo.Name = "ColLeyendaCodigo"
        Me.ColLeyendaCodigo.ReadOnly = True
        '
        'ColLeyendaDescripcion
        '
        Me.ColLeyendaDescripcion.DataPropertyName = "descripcion"
        Me.ColLeyendaDescripcion.FillWeight = 300.0!
        Me.ColLeyendaDescripcion.HeaderText = "Descripcion"
        Me.ColLeyendaDescripcion.Name = "ColLeyendaDescripcion"
        Me.ColLeyendaDescripcion.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 437)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Leyendas"
        '
        'TxtDetraccionesMonto
        '
        Me.TxtDetraccionesMonto.Location = New System.Drawing.Point(563, 454)
        Me.TxtDetraccionesMonto.Name = "TxtDetraccionesMonto"
        Me.TxtDetraccionesMonto.ReadOnly = True
        Me.TxtDetraccionesMonto.Size = New System.Drawing.Size(60, 20)
        Me.TxtDetraccionesMonto.TabIndex = 63
        Me.TxtDetraccionesMonto.Text = " "
        Me.TxtDetraccionesMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(443, 458)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Detracciones"
        '
        'BtnDetracciones
        '
        Me.BtnDetracciones.Image = CType(resources.GetObject("BtnDetracciones.Image"), System.Drawing.Image)
        Me.BtnDetracciones.Location = New System.Drawing.Point(624, 453)
        Me.BtnDetracciones.Name = "BtnDetracciones"
        Me.BtnDetracciones.Size = New System.Drawing.Size(23, 23)
        Me.BtnDetracciones.TabIndex = 64
        Me.BtnDetracciones.UseVisualStyleBackColor = True
        '
        'TxtDetraccionesPorcentaje
        '
        Me.TxtDetraccionesPorcentaje.Location = New System.Drawing.Point(516, 454)
        Me.TxtDetraccionesPorcentaje.Name = "TxtDetraccionesPorcentaje"
        Me.TxtDetraccionesPorcentaje.ReadOnly = True
        Me.TxtDetraccionesPorcentaje.Size = New System.Drawing.Size(32, 20)
        Me.TxtDetraccionesPorcentaje.TabIndex = 65
        Me.TxtDetraccionesPorcentaje.Text = " "
        Me.TxtDetraccionesPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(548, 458)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 593)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtDetraccionesPorcentaje)
        Me.Controls.Add(Me.BtnDetracciones)
        Me.Controls.Add(Me.TxtDetraccionesMonto)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DgvLeyenda)
        Me.Controls.Add(Me.DgvItems)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtExonerado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtInafecto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtOtros)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtGratuita)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtGravada)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTotalFactura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtIgvMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnArchivoXml)
        Me.Controls.Add(Me.TxtArchivoXml)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvLeyenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtArchivoXml As TextBox
    Friend WithEvents TxtEmisor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents btnEmisor As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents BtnArchivoXml As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDocumentoTipo As TextBox
    Friend WithEvents TxtDocumentoNumero As TextBox
    Friend WithEvents TxtFechaEmision As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIgvMonto As TextBox
    Friend WithEvents TxtTotalFactura As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTipoOperacion As TextBox
    Friend WithEvents TxtGravada As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtGratuita As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtHoraEmision As TextBox
    Friend WithEvents TxtVencimiento As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtMoneda As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtOtros As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtInafecto As TextBox
    Friend WithEvents TxtExonerado As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvItems As DataGridView
    Friend WithEvents colOrden As DataGridViewTextBoxColumn
    Friend WithEvents colCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColMedida As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColValorUnitario As DataGridViewTextBoxColumn
    Friend WithEvents ColGravado As DataGridViewTextBoxColumn
    Friend WithEvents ColInafecto As DataGridViewTextBoxColumn
    Friend WithEvents ColExonerado As DataGridViewTextBoxColumn
    Friend WithEvents ColGratuito As DataGridViewTextBoxColumn
    Friend WithEvents ColIgv As DataGridViewTextBoxColumn
    Friend WithEvents ColTotal As DataGridViewTextBoxColumn
    Friend WithEvents DgvLeyenda As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents ColLeyendaCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColLeyendaDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents TxtDetraccionesMonto As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnDetracciones As Button
    Friend WithEvents TxtDetraccionesPorcentaje As TextBox
    Friend WithEvents Label16 As Label
End Class
