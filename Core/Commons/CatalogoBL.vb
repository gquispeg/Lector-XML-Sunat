Imports Entidades.Commons

Namespace Commons
    Public Class CatalogoBL
        ''' <summary>
        ''' Retornar Nombre segun el código de 
        ''' </summary>
        ''' <param name="catalogo">Numero de catalogo</param>
        ''' <param name="codigo">Codigo a buscar</param>
        ''' <returns></returns>
        Public Function Obtener(catalogo As String, codigo As String) As String
            Dim origen = ListarCatalogo(catalogo)
            Dim listado = From encontrado In origen
                          Where encontrado.Codigo = codigo

            If listado.Count = 0 Then
                Throw New Exception($"No se encontró el código {codigo} en el catalogo {catalogo}")
            End If

            Return listado(0).Nombre
        End Function

        Private Function ListarCatalogo(codigo As String) As List(Of Catalogo)
            Dim listado As List(Of Catalogo) = Nothing
            Select Case codigo
                Case "01" : listado = Catalogo01()
                Case "02" : listado = Catalogo02()
                Case "03" : listado = Catalogo03()
                Case "04" : listado = Catalogo04()
                Case "05" : listado = Catalogo05()
                Case "06" : listado = Catalogo06()
                Case "07" : listado = Catalogo07()
                Case "08" : listado = Catalogo08()
                Case "09" : listado = Catalogo09()
                Case "10" : listado = Catalogo10()
                Case "11" : listado = Catalogo11()
                Case "12" : listado = Catalogo12()
                Case "13" : listado = Catalogo13()
                Case "14" : listado = Catalogo14()
                Case "15" : listado = Catalogo15()
                Case "16" : listado = Catalogo16()
                Case "17" : listado = Catalogo17()
                Case "18" : listado = Catalogo18()
                Case "19" : listado = Catalogo19()
                Case "20" : listado = Catalogo20()
                Case "21" : listado = Catalogo21()
                Case "22" : listado = Catalogo22()
                Case "23" : listado = Catalogo23()
                Case "24" : listado = Catalogo24()
                Case "25" : listado = Catalogo25()
                Case "26" : listado = Catalogo26()
                Case "27" : listado = Catalogo27()
                Case "51" : listado = Catalogo51()
                Case "52" : listado = Catalogo52()
                Case "53" : listado = Catalogo53()
                Case "54" : listado = Catalogo54()
                Case "55" : listado = Catalogo55()
                Case "56" : listado = Catalogo56()
                Case "57" : listado = Catalogo57()
                Case "58" : listado = Catalogo58()
                Case "59" : listado = Catalogo59()
            End Select

            Return listado
        End Function

        ''' <summary>
        ''' Tipo de documentos
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo01() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Factura"),
                New Catalogo("03", "Boleta de venta"),
                New Catalogo("04", "Liquidación de compra"),
                New Catalogo("05", "Boletos de Transporte Aéreo que emiten las Compañías de Aviación Comercial por el servicio de transporte aéreo regular de pasajeros, emitido de manera manual, mecanizada o por medios electrónicos (BME)"),
                New Catalogo("06", "Carta de porte aéreo"),
                New Catalogo("07", "Nota de crédito"),
                New Catalogo("08", "Nota de débito"),
                New Catalogo("09", "Guía de remisión remitente"),
                New Catalogo("11", "Póliza emitida por las Bolsas de Valores"),
                New Catalogo("12", "Ticket de máquina registradora"),
                New Catalogo("13", "Documento emitido por bancos, instituciones financieras, crediticias y de seguros que se encuentren bajo el control de la Superintendencia de Banca y Seguros"),
                New Catalogo("14", "Recibo servicios públicos"),
                New Catalogo("15", "Boletos emitidos por el servicio de transporte terrestre regular urbano de pasajeros y el ferroviario público de pasajeros prestado en vía férrea local"),
                New Catalogo("16", "Boleto de viaje emitido por las empresas de transporte público interprovincial de pasajeros"),
                New Catalogo("18", "Documentos emitidos por las AFP"),
                New Catalogo("19", "Boleto por atracciones y espectáculos públicos"),
                New Catalogo("20", "Comprobante de retención"),
                New Catalogo("21", "Conocimiento de embarque por el servicio de transporte de carga marítima"),
                New Catalogo("23", "Pólizas de Adjudicación por remate o adjudicación de bienes"),
                New Catalogo("24", "Certificado de pago de regalías emitidas por PERUPETRO S.A."),
                New Catalogo("28", "Etiquetas por el pago de la Tarifa Unificada de Uso de Aeropuerto – TUUA"),
                New Catalogo("29", "Documentos emitidos por la COFOPRI"),
                New Catalogo("30", "Documentos emitidos por las empresas que desempeñan el rol adquirente en los sistemas de pago mediante tarjetas de crédito y débito, emitidas por bancos e instituciones financieras o crediticias, domiciliados o no en el país"),
                New Catalogo("31", "Guía de remisión transportista"),
                New Catalogo("32", "Documentos emitidos por recaudadoras de la Garantía de Red Principal"),
                New Catalogo("34", "Documento del Operador"),
                New Catalogo("35", "Documento del Partícipe"),
                New Catalogo("36", "Recibo de Distribución de Gas Natural"),
                New Catalogo("37", "Documentos que emitan los concesionarios del servicio de revisiones técnicas"),
                New Catalogo("40", "Comprobante de Percepción"),
                New Catalogo("41", "Comprobante de Percepción – Venta interna ( físico - formato impreso)"),
                New Catalogo("42", "Documentos emitidos por los adq. en los sistemas de pago por tarj. de crédito emitidas por ellas mismas"),
                New Catalogo("43", "Boleto de compañías de aviación transporte aéreo no regular"),
                New Catalogo("45", "Documentos emitidos por centros educativos y culturales, universidades, asociaciones y fundaciones"),
                New Catalogo("55", "BVME para transporte ferroviario de pasajeros"),
                New Catalogo("56", "Comprobante de pago SEAE"),
                New Catalogo("71", "Guía de remisión remitente complementaria"),
                New Catalogo("72", "Guía de remisión transportista complementaria"),
                New Catalogo("87", "Nota de crédito especial"),
                New Catalogo("88", "Nota de débito especial"),
                New Catalogo("RC", "Resumen diario"),
                New Catalogo("RA", "Comunicación de baja"),
                New Catalogo("RR", "Resumen de reversión")
            }
        End Function

        ''' <summary>
        ''' Monedas
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo02() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("PEN", "Soles"),
                New Catalogo("USD", "Dolares"),
                New Catalogo("XEU", "Euros")
            }
        End Function

        ''' <summary>
        ''' Unidades de medida
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo03() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("NIU", "Unidad"),
                New Catalogo("ZZ", "Servicio")
            }
        End Function

        ''' <summary>
        ''' Codigo de paises
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo04() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("PER", "Pérú")
            }
        End Function

        ''' <summary>
        ''' Tributos y otros conceptor
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo05() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1000", "IGV"),
                New Catalogo("2000", "ISC"),
                New Catalogo("7152", "ICBPER"),
                New Catalogo("9996", "GRA"),
                New Catalogo("9997", "EXO"),
                New Catalogo("9998", "INA"),
                New Catalogo("9999", "OTROS")
            }
        End Function

        ''' <summary>
        ''' Tipo de documentos de identidad
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo06() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("0", "DOC.TRIB.NO.DOM.SIN.RUC"),
                New Catalogo("1", "DNI"),
                New Catalogo("4", "Carnet de extranjería"),
                New Catalogo("6", "RUC"),
                New Catalogo("7", "Pasaporte"),
                New Catalogo("A", "Cédula Diplomática de identidad"),
                New Catalogo("B", "DOC.IDENT.PAIS.RESIDENCIA-NO.D"),
                New Catalogo("C", "Tax Identification Number - TIN – Doc Trib PP.NN"),
                New Catalogo("D", "Identification Number - IN – Doc Trib PP. JJ"),
                New Catalogo("E", "TAM- Tarjeta Andina de Migración ")
            }
        End Function

        ''' <summary>
        ''' Tipo de afectación del IGV
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo07() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("10", "Gravado - Operación Onerosa"),
                New Catalogo("11", "Gravado – Retiro por premio"),
                New Catalogo("12", "Gravado – Retiro por donación"),
                New Catalogo("13", "Gravado – Retiro "),
                New Catalogo("14", "Gravado – Retiro por publicidad"),
                New Catalogo("15", "Gravado – Bonificaciones"),
                New Catalogo("16", "Gravado – Retiro por entrega a trabajadores"),
                New Catalogo("17", "Gravado - IVAP"),
                New Catalogo("20", "Exonerado - Operación Onerosa"),
                New Catalogo("21", "Exonerado - Transferencia gratuita"),
                New Catalogo("30", "Inafecto - Operación Onerosa"),
                New Catalogo("31", "Inafecto – Retiro por Bonificación"),
                New Catalogo("32", "Inafecto – Retiro"),
                New Catalogo("33", "Inafecto – Retiro por Muestras Médicas"),
                New Catalogo("34", "Inafecto - Retiro por Convenio Colectivo"),
                New Catalogo("35", "Inafecto – Retiro por premio"),
                New Catalogo("36", "Inafecto - Retiro por publicidad"),
                New Catalogo("37", "Inafecto - Transferencia gratuita"),
                New Catalogo("40", "Exportación de Bienes o Servicios")
            }
        End Function

        ''' <summary>
        ''' Tipos del sistema del calculo ISC
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo08() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Sistema al valor (Apéndice IV, lit. A – T.U.O IGV e ISC)"),
                New Catalogo("02", "Aplicación del Monto Fijo ( Sistema específico, bienes en el apéndice III, Apéndice IV, lit. B – T.U.O IGV e ISC)"),
                New Catalogo("03", "Sistema de Precios de Venta al Público (Apéndice IV, lit. C – T.U.O IGV e ISC)")
            }
        End Function

        ''' <summary>
        ''' Tipo de nota de crédito electrónica
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo09() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Anulación de la operación"),
                New Catalogo("02", "Anulación por error en el RUC"),
                New Catalogo("03", "Corrección por error en la descripción"),
                New Catalogo("04", "Descuento global"),
                New Catalogo("05", "Descuento por ítem"),
                New Catalogo("06", "Devolución total"),
                New Catalogo("07", "Devolución por ítem"),
                New Catalogo("08", "Bonificación"),
                New Catalogo("09", "Disminución en el valor"),
                New Catalogo("10", "Otros Conceptos "),
                New Catalogo("11", "Ajustes de operaciones de exportación"),
                New Catalogo("12", "Ajustes afectos al IVAP")
            }
        End Function

        ''' <summary>
        ''' Tipo de notas de debito
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo10() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Intereses por mora"),
                New Catalogo("02", "Aumento en el valor"),
                New Catalogo("03", "Penalidades/ otros conceptos "),
                New Catalogo("11", "Ajustes de operaciones de exportación"),
                New Catalogo("12", "Ajustes afectos al IVAP")
            }
        End Function

        ''' <summary>
        ''' Códigos de tipo de valor de venta (Resumen diario de boletas y notas)
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo11() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Gravado"),
                New Catalogo("02", "Exonerado"),
                New Catalogo("03", "Inafecto"),
                New Catalogo("04", "Exportación"),
                New Catalogo("05", "Gratuitas")
            }
        End Function

        ''' <summary>
        ''' Código de documentos relacionados tributarios
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo12() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Factura – emitida para corregir error en el RUC"),
                New Catalogo("02", "Factura – emitida por anticipos"),
                New Catalogo("03", "Boleta de Venta – emitida por anticipos"),
                New Catalogo("04", "Ticket de Salida - ENAPU "),
                New Catalogo("05", "Código SCOP"),
                New Catalogo("06", "Factura electrónica remitente"),
                New Catalogo("07", "Guia de remisión remitente"),
                New Catalogo("08", "Declaración de salida del depósito franco "),
                New Catalogo("09", "Declaración simplificada de importación "),
                New Catalogo("10", "Liquidación de compra - emitida por anticipos"),
                New Catalogo("99", "Otros")
            }
        End Function

        ''' <summary>
        ''' Ubigeo
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo13() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("010101", "CHACHAPOYAS - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010102", "ASUNCION - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010103", "BALSAS - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010104", "CHETO - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010105", "CHILIQUIN - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010106", "CHUQUIBAMBA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010107", "GRANADA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010108", "HUANCAS - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010109", "LA JALCA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010110", "LEIMEBAMBA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010111", "LEVANTO - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010112", "MAGDALENA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010113", "MARISCAL CASTILLA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010114", "MOLINOPAMPA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010115", "MONTEVIDEO - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010116", "OLLEROS - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010117", "QUINJALCA - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010118", "SAN FRANCISCO DE DAGUAS - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010119", "SAN ISIDRO DE MAINO - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010120", "SOLOCO - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010121", "SONCHE - CHACHAPOYAS - AMAZONAS"),
                New Catalogo("010201", "BAGUA - BAGUA - AMAZONAS"),
                New Catalogo("010202", "ARAMANGO - BAGUA - AMAZONAS"),
                New Catalogo("010203", "COPALLIN - BAGUA - AMAZONAS"),
                New Catalogo("010204", "EL PARCO - BAGUA - AMAZONAS"),
                New Catalogo("010205", "IMAZA - BAGUA - AMAZONAS"),
                New Catalogo("010206", "LA PECA - BAGUA - AMAZONAS"),
                New Catalogo("010301", "JUMBILLA - BONGARA - AMAZONAS"),
                New Catalogo("010302", "CHISQUILLA - BONGARA - AMAZONAS"),
                New Catalogo("010303", "CHURUJA - BONGARA - AMAZONAS"),
                New Catalogo("010304", "COROSHA - BONGARA - AMAZONAS"),
                New Catalogo("010305", "CUISPES - BONGARA - AMAZONAS"),
                New Catalogo("010306", "FLORIDA - BONGARA - AMAZONAS"),
                New Catalogo("010307", "JAZAN - BONGARA - AMAZONAS"),
                New Catalogo("010308", "RECTA - BONGARA - AMAZONAS"),
                New Catalogo("010309", "SAN CARLOS - BONGARA - AMAZONAS"),
                New Catalogo("010310", "SHIPASBAMBA - BONGARA - AMAZONAS"),
                New Catalogo("010311", "VALERA - BONGARA - AMAZONAS"),
                New Catalogo("010312", "YAMBRASBAMBA - BONGARA - AMAZONAS"),
                New Catalogo("010401", "NIEVA - CONDORCANQUI - AMAZONAS"),
                New Catalogo("010402", "EL CENEPA - CONDORCANQUI - AMAZONAS"),
                New Catalogo("010403", "RIO SANTIAGO - CONDORCANQUI - AMAZONAS"),
                New Catalogo("010501", "LAMUD - LUYA - AMAZONAS"),
                New Catalogo("010502", "CAMPORREDONDO - LUYA - AMAZONAS"),
                New Catalogo("010503", "COCABAMBA - LUYA - AMAZONAS"),
                New Catalogo("010504", "COLCAMAR - LUYA - AMAZONAS"),
                New Catalogo("010505", "CONILA - LUYA - AMAZONAS"),
                New Catalogo("010506", "INGUILPATA - LUYA - AMAZONAS"),
                New Catalogo("010507", "LONGUITA - LUYA - AMAZONAS"),
                New Catalogo("010508", "LONYA CHICO - LUYA - AMAZONAS"),
                New Catalogo("010509", "LUYA - LUYA - AMAZONAS"),
                New Catalogo("010510", "LUYA VIEJO - LUYA - AMAZONAS"),
                New Catalogo("010511", "MARIA - LUYA - AMAZONAS"),
                New Catalogo("010512", "OCALLI - LUYA - AMAZONAS"),
                New Catalogo("010513", "OCUMAL - LUYA - AMAZONAS"),
                New Catalogo("010514", "PISUQUIA - LUYA - AMAZONAS"),
                New Catalogo("010515", "PROVIDENCIA - LUYA - AMAZONAS"),
                New Catalogo("010516", "SAN CRISTOBAL - LUYA - AMAZONAS"),
                New Catalogo("010517", "SAN FRANCISCO DEL YESO - LUYA - AMAZONAS"),
                New Catalogo("010518", "SAN JERONIMO - LUYA - AMAZONAS"),
                New Catalogo("010519", "SAN JUAN DE LOPECANCHA - LUYA - AMAZONAS"),
                New Catalogo("010520", "SANTA CATALINA - LUYA - AMAZONAS"),
                New Catalogo("010521", "SANTO TOMAS - LUYA - AMAZONAS"),
                New Catalogo("010522", "TINGO - LUYA - AMAZONAS"),
                New Catalogo("010523", "TRITA - LUYA - AMAZONAS"),
                New Catalogo("010601", "SAN NICOLAS - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010602", "CHIRIMOTO - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010603", "COCHAMAL - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010604", "HUAMBO - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010605", "LIMABAMBA - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010606", "LONGAR - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010607", "MARISCAL BENAVIDES - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010608", "MILPUC - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010609", "OMIA - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010610", "SANTA ROSA - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010611", "TOTORA - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010612", "VISTA ALEGRE - RODRIGUEZ DE MENDOZA - AMAZONAS"),
                New Catalogo("010701", "BAGUA GRANDE - UTCUBAMBA - AMAZONAS"),
                New Catalogo("010702", "CAJARURO - UTCUBAMBA - AMAZONAS"),
                New Catalogo("010703", "CUMBA - UTCUBAMBA - AMAZONAS"),
                New Catalogo("010704", "EL MILAGRO - UTCUBAMBA - AMAZONAS"),
                New Catalogo("010705", "JAMALCA - UTCUBAMBA - AMAZONAS"),
                New Catalogo("010706", "LONYA GRANDE - UTCUBAMBA - AMAZONAS"),
                New Catalogo("010707", "YAMON - UTCUBAMBA - AMAZONAS"),
                New Catalogo("020101", "HUARAZ - HUARAZ - ANCASH"),
                New Catalogo("020102", "COCHABAMBA - HUARAZ - ANCASH"),
                New Catalogo("020103", "COLCABAMBA - HUARAZ - ANCASH"),
                New Catalogo("020104", "HUANCHAY - HUARAZ - ANCASH"),
                New Catalogo("020105", "INDEPENDENCIA - HUARAZ - ANCASH"),
                New Catalogo("020106", "JANGAS - HUARAZ - ANCASH"),
                New Catalogo("020107", "LA LIBERTAD - HUARAZ - ANCASH"),
                New Catalogo("020108", "OLLEROS - HUARAZ - ANCASH"),
                New Catalogo("020109", "PAMPAS GRANDE - HUARAZ - ANCASH"),
                New Catalogo("020110", "PARIACOTO - HUARAZ - ANCASH"),
                New Catalogo("020111", "PIRA - HUARAZ - ANCASH"),
                New Catalogo("020112", "TARICA - HUARAZ - ANCASH"),
                New Catalogo("020201", "AIJA - AIJA - ANCASH"),
                New Catalogo("020202", "CORIS - AIJA - ANCASH"),
                New Catalogo("020203", "HUACLLAN - AIJA - ANCASH"),
                New Catalogo("020204", "LA MERCED - AIJA - ANCASH"),
                New Catalogo("020205", "SUCCHA - AIJA - ANCASH"),
                New Catalogo("020301", "LLAMELLIN - ANTONIO RAYMONDI - ANCASH"),
                New Catalogo("020302", "ACZO - ANTONIO RAYMONDI - ANCASH"),
                New Catalogo("020303", "CHACCHO - ANTONIO RAYMONDI - ANCASH"),
                New Catalogo("020304", "CHINGAS - ANTONIO RAYMONDI - ANCASH"),
                New Catalogo("020305", "MIRGAS - ANTONIO RAYMONDI - ANCASH"),
                New Catalogo("020306", "SAN JUAN DE RONTOY - ANTONIO RAYMONDI - ANCASH"),
                New Catalogo("020401", "CHACAS - ASUNCION - ANCASH"),
                New Catalogo("020402", "ACOCHACA - ASUNCION - ANCASH"),
                New Catalogo("020501", "CHIQUIAN - BOLOGNESI - ANCASH"),
                New Catalogo("020502", "ABELARDO PARDO LEZAMETA - BOLOGNESI - ANCASH"),
                New Catalogo("020503", "ANTONIO RAYMONDI - BOLOGNESI - ANCASH"),
                New Catalogo("020504", "AQUIA - BOLOGNESI - ANCASH"),
                New Catalogo("020505", "CAJACAY - BOLOGNESI - ANCASH"),
                New Catalogo("020506", "CANIS - BOLOGNESI - ANCASH"),
                New Catalogo("020507", "COLQUIOC - BOLOGNESI - ANCASH"),
                New Catalogo("020508", "HUALLANCA - BOLOGNESI - ANCASH"),
                New Catalogo("020509", "HUASTA - BOLOGNESI - ANCASH"),
                New Catalogo("020510", "HUAYLLACAYAN - BOLOGNESI - ANCASH"),
                New Catalogo("020511", "LA PRIMAVERA - BOLOGNESI - ANCASH"),
                New Catalogo("020512", "MANGAS - BOLOGNESI - ANCASH"),
                New Catalogo("020513", "PACLLON - BOLOGNESI - ANCASH"),
                New Catalogo("020514", "SAN MIGUEL DE CORPANQUI - BOLOGNESI - ANCASH"),
                New Catalogo("020515", "TICLLOS - BOLOGNESI - ANCASH"),
                New Catalogo("020601", "CARHUAZ - CARHUAZ - ANCASH"),
                New Catalogo("020602", "ACOPAMPA - CARHUAZ - ANCASH"),
                New Catalogo("020603", "AMASHCA - CARHUAZ - ANCASH"),
                New Catalogo("020604", "ANTA - CARHUAZ - ANCASH"),
                New Catalogo("020605", "ATAQUERO - CARHUAZ - ANCASH"),
                New Catalogo("020606", "MARCARA - CARHUAZ - ANCASH"),
                New Catalogo("020607", "PARIAHUANCA - CARHUAZ - ANCASH"),
                New Catalogo("020608", "SAN MIGUEL DE ACO - CARHUAZ - ANCASH"),
                New Catalogo("020609", "SHILLA - CARHUAZ - ANCASH"),
                New Catalogo("020610", "TINCO - CARHUAZ - ANCASH"),
                New Catalogo("020611", "YUNGAR - CARHUAZ - ANCASH"),
                New Catalogo("020701", "SAN LUIS - CARLOS FERMIN FITZCARRALD - ANCASH"),
                New Catalogo("020702", "SAN NICOLAS - CARLOS FERMIN FITZCARRALD - ANCASH"),
                New Catalogo("020703", "YAUYA - CARLOS FERMIN FITZCARRALD - ANCASH"),
                New Catalogo("020801", "CASMA - CASMA - ANCASH"),
                New Catalogo("020802", "BUENA VISTA ALTA - CASMA - ANCASH"),
                New Catalogo("020803", "COMANDANTE NOEL - CASMA - ANCASH"),
                New Catalogo("020804", "YAUTAN - CASMA - ANCASH"),
                New Catalogo("020901", "CORONGO - CORONGO - ANCASH"),
                New Catalogo("020902", "ACO - CORONGO - ANCASH"),
                New Catalogo("020903", "BAMBAS - CORONGO - ANCASH"),
                New Catalogo("020904", "CUSCA - CORONGO - ANCASH"),
                New Catalogo("020905", "LA PAMPA - CORONGO - ANCASH"),
                New Catalogo("020906", "YANAC - CORONGO - ANCASH"),
                New Catalogo("020907", "YUPAN - CORONGO - ANCASH"),
                New Catalogo("021001", "HUARI - HUARI - ANCASH"),
                New Catalogo("021002", "ANRA - HUARI - ANCASH"),
                New Catalogo("021003", "CAJAY - HUARI - ANCASH"),
                New Catalogo("021004", "CHAVIN DE HUANTAR - HUARI - ANCASH"),
                New Catalogo("021005", "HUACACHI - HUARI - ANCASH"),
                New Catalogo("021006", "HUACCHIS - HUARI - ANCASH"),
                New Catalogo("021007", "HUACHIS - HUARI - ANCASH"),
                New Catalogo("021008", "HUANTAR - HUARI - ANCASH"),
                New Catalogo("021009", "MASIN - HUARI - ANCASH"),
                New Catalogo("021010", "PAUCAS - HUARI - ANCASH"),
                New Catalogo("021011", "PONTO - HUARI - ANCASH"),
                New Catalogo("021012", "RAHUAPAMPA - HUARI - ANCASH"),
                New Catalogo("021013", "RAPAYAN - HUARI - ANCASH"),
                New Catalogo("021014", "SAN MARCOS - HUARI - ANCASH"),
                New Catalogo("021015", "SAN PEDRO DE CHANA - HUARI - ANCASH"),
                New Catalogo("021016", "UCO - HUARI - ANCASH"),
                New Catalogo("021101", "HUARMEY - HUARMEY - ANCASH"),
                New Catalogo("021102", "COCHAPETI - HUARMEY - ANCASH"),
                New Catalogo("021103", "CULEBRAS - HUARMEY - ANCASH"),
                New Catalogo("021104", "HUAYAN - HUARMEY - ANCASH"),
                New Catalogo("021105", "MALVAS - HUARMEY - ANCASH"),
                New Catalogo("021201", "CARAZ - HUAYLAS - ANCASH"),
                New Catalogo("021202", "HUALLANCA - HUAYLAS - ANCASH"),
                New Catalogo("021203", "HUATA - HUAYLAS - ANCASH"),
                New Catalogo("021204", "HUAYLAS - HUAYLAS - ANCASH"),
                New Catalogo("021205", "MATO - HUAYLAS - ANCASH"),
                New Catalogo("021206", "PAMPAROMAS - HUAYLAS - ANCASH"),
                New Catalogo("021207", "PUEBLO LIBRE - HUAYLAS - ANCASH"),
                New Catalogo("021208", "SANTA CRUZ - HUAYLAS - ANCASH"),
                New Catalogo("021209", "SANTO TORIBIO - HUAYLAS - ANCASH"),
                New Catalogo("021210", "YURACMARCA - HUAYLAS - ANCASH"),
                New Catalogo("021301", "PISCOBAMBA - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021302", "CASCA - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021303", "ELEAZAR GUZMAN BARRON - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021304", "FIDEL OLIVAS ESCUDERO - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021305", "LLAMA - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021306", "LLUMPA - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021307", "LUCMA - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021308", "MUSGA - MARISCAL LUZURIAGA - ANCASH"),
                New Catalogo("021401", "OCROS - OCROS - ANCASH"),
                New Catalogo("021402", "ACAS - OCROS - ANCASH"),
                New Catalogo("021403", "CAJAMARQUILLA - OCROS - ANCASH"),
                New Catalogo("021404", "CARHUAPAMPA - OCROS - ANCASH"),
                New Catalogo("021405", "COCHAS - OCROS - ANCASH"),
                New Catalogo("021406", "CONGAS - OCROS - ANCASH"),
                New Catalogo("021407", "LLIPA - OCROS - ANCASH"),
                New Catalogo("021408", "SAN CRISTOBAL DE RAJAN - OCROS - ANCASH"),
                New Catalogo("021409", "SAN PEDRO - OCROS - ANCASH"),
                New Catalogo("021410", "SANTIAGO DE CHILCAS - OCROS - ANCASH"),
                New Catalogo("021501", "CABANA - PALLASCA - ANCASH"),
                New Catalogo("021502", "BOLOGNESI - PALLASCA - ANCASH"),
                New Catalogo("021503", "CONCHUCOS - PALLASCA - ANCASH"),
                New Catalogo("021504", "HUACASCHUQUE - PALLASCA - ANCASH"),
                New Catalogo("021505", "HUANDOVAL - PALLASCA - ANCASH"),
                New Catalogo("021506", "LACABAMBA - PALLASCA - ANCASH"),
                New Catalogo("021507", "LLAPO - PALLASCA - ANCASH"),
                New Catalogo("021508", "PALLASCA - PALLASCA - ANCASH"),
                New Catalogo("021509", "PAMPAS - PALLASCA - ANCASH"),
                New Catalogo("021510", "SANTA ROSA - PALLASCA - ANCASH"),
                New Catalogo("021511", "TAUCA - PALLASCA - ANCASH"),
                New Catalogo("021601", "POMABAMBA - POMABAMBA - ANCASH"),
                New Catalogo("021602", "HUAYLLAN - POMABAMBA - ANCASH"),
                New Catalogo("021603", "PAROBAMBA - POMABAMBA - ANCASH"),
                New Catalogo("021604", "QUINUABAMBA - POMABAMBA - ANCASH"),
                New Catalogo("021701", "RECUAY - RECUAY - ANCASH"),
                New Catalogo("021702", "CATAC - RECUAY - ANCASH"),
                New Catalogo("021703", "COTAPARACO - RECUAY - ANCASH"),
                New Catalogo("021704", "HUAYLLAPAMPA - RECUAY - ANCASH"),
                New Catalogo("021705", "LLACLLIN - RECUAY - ANCASH"),
                New Catalogo("021706", "MARCA - RECUAY - ANCASH"),
                New Catalogo("021707", "PAMPAS CHICO - RECUAY - ANCASH"),
                New Catalogo("021708", "PARARIN - RECUAY - ANCASH"),
                New Catalogo("021709", "TAPACOCHA - RECUAY - ANCASH"),
                New Catalogo("021710", "TICAPAMPA - RECUAY - ANCASH"),
                New Catalogo("021801", "CHIMBOTE - SANTA - ANCASH"),
                New Catalogo("021802", "CACERES DEL PERU - SANTA - ANCASH"),
                New Catalogo("021803", "COISHCO - SANTA - ANCASH"),
                New Catalogo("021804", "MACATE - SANTA - ANCASH"),
                New Catalogo("021805", "MORO - SANTA - ANCASH"),
                New Catalogo("021806", "NEPEÑA - SANTA - ANCASH"),
                New Catalogo("021807", "SAMANCO - SANTA - ANCASH"),
                New Catalogo("021808", "SANTA - SANTA - ANCASH"),
                New Catalogo("021809", "NUEVO CHIMBOTE - SANTA - ANCASH"),
                New Catalogo("021901", "SIHUAS - SIHUAS - ANCASH"),
                New Catalogo("021902", "ACOBAMBA - SIHUAS - ANCASH"),
                New Catalogo("021903", "ALFONSO UGARTE - SIHUAS - ANCASH"),
                New Catalogo("021904", "CASHAPAMPA - SIHUAS - ANCASH"),
                New Catalogo("021905", "CHINGALPO - SIHUAS - ANCASH"),
                New Catalogo("021906", "HUAYLLABAMBA - SIHUAS - ANCASH"),
                New Catalogo("021907", "QUICHES - SIHUAS - ANCASH"),
                New Catalogo("021908", "RAGASH - SIHUAS - ANCASH"),
                New Catalogo("021909", "SAN JUAN - SIHUAS - ANCASH"),
                New Catalogo("021910", "SICSIBAMBA - SIHUAS - ANCASH"),
                New Catalogo("022001", "YUNGAY - YUNGAY - ANCASH"),
                New Catalogo("022002", "CASCAPARA - YUNGAY - ANCASH"),
                New Catalogo("022003", "MANCOS - YUNGAY - ANCASH"),
                New Catalogo("022004", "MATACOTO - YUNGAY - ANCASH"),
                New Catalogo("022005", "QUILLO - YUNGAY - ANCASH"),
                New Catalogo("022006", "RANRAHIRCA - YUNGAY - ANCASH"),
                New Catalogo("022007", "SHUPLUY - YUNGAY - ANCASH"),
                New Catalogo("022008", "YANAMA - YUNGAY - ANCASH"),
                New Catalogo("030101", "ABANCAY - ABANCAY - APURIMAC"),
                New Catalogo("030102", "CHACOCHE - ABANCAY - APURIMAC"),
                New Catalogo("030103", "CIRCA - ABANCAY - APURIMAC"),
                New Catalogo("030104", "CURAHUASI - ABANCAY - APURIMAC"),
                New Catalogo("030105", "HUANIPACA - ABANCAY - APURIMAC"),
                New Catalogo("030106", "LAMBRAMA - ABANCAY - APURIMAC"),
                New Catalogo("030107", "PICHIRHUA - ABANCAY - APURIMAC"),
                New Catalogo("030108", "SAN PEDRO DE CACHORA - ABANCAY - APURIMAC"),
                New Catalogo("030109", "TAMBURCO - ABANCAY - APURIMAC"),
                New Catalogo("030201", "ANDAHUAYLAS - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030202", "ANDARAPA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030203", "CHIARA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030204", "HUANCARAMA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030205", "HUANCARAY - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030206", "HUAYANA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030207", "KISHUARA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030208", "PACOBAMBA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030209", "PACUCHA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030210", "PAMPACHIRI - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030211", "POMACOCHA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030212", "SAN ANTONIO DE CACHI - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030213", "SAN JERONIMO - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030214", "SAN MIGUEL DE CHACCRAMPA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030215", "SANTA MARIA DE CHICMO - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030216", "TALAVERA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030217", "TUMAY HUARACA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030218", "TURPO - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030219", "KAQUIABAMBA - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030220", "JOSE MARIA ARGUEDAS - ANDAHUAYLAS - APURIMAC"),
                New Catalogo("030301", "ANTABAMBA - ANTABAMBA - APURIMAC"),
                New Catalogo("030302", "EL ORO - ANTABAMBA - APURIMAC"),
                New Catalogo("030303", "HUAQUIRCA - ANTABAMBA - APURIMAC"),
                New Catalogo("030304", "JUAN ESPINOZA MEDRANO - ANTABAMBA - APURIMAC"),
                New Catalogo("030305", "OROPESA - ANTABAMBA - APURIMAC"),
                New Catalogo("030306", "PACHACONAS - ANTABAMBA - APURIMAC"),
                New Catalogo("030307", "SABAINO - ANTABAMBA - APURIMAC"),
                New Catalogo("030401", "CHALHUANCA - AYMARAES - APURIMAC"),
                New Catalogo("030402", "CAPAYA - AYMARAES - APURIMAC"),
                New Catalogo("030403", "CARAYBAMBA - AYMARAES - APURIMAC"),
                New Catalogo("030404", "CHAPIMARCA - AYMARAES - APURIMAC"),
                New Catalogo("030405", "COLCABAMBA - AYMARAES - APURIMAC"),
                New Catalogo("030406", "COTARUSE - AYMARAES - APURIMAC"),
                New Catalogo("030407", "IHUAYLLO - AYMARAES - APURIMAC"),
                New Catalogo("030408", "JUSTO APU SAHUARAURA - AYMARAES - APURIMAC"),
                New Catalogo("030409", "LUCRE - AYMARAES - APURIMAC"),
                New Catalogo("030410", "POCOHUANCA - AYMARAES - APURIMAC"),
                New Catalogo("030411", "SAN JUAN DE CHACÑA - AYMARAES - APURIMAC"),
                New Catalogo("030412", "SAÑAYCA - AYMARAES - APURIMAC"),
                New Catalogo("030413", "SORAYA - AYMARAES - APURIMAC"),
                New Catalogo("030414", "TAPAIRIHUA - AYMARAES - APURIMAC"),
                New Catalogo("030415", "TINTAY - AYMARAES - APURIMAC"),
                New Catalogo("030416", "TORAYA - AYMARAES - APURIMAC"),
                New Catalogo("030417", "YANACA - AYMARAES - APURIMAC"),
                New Catalogo("030501", "TAMBOBAMBA - COTABAMBAS - APURIMAC"),
                New Catalogo("030502", "COTABAMBAS - COTABAMBAS - APURIMAC"),
                New Catalogo("030503", "COYLLURQUI - COTABAMBAS - APURIMAC"),
                New Catalogo("030504", "HAQUIRA - COTABAMBAS - APURIMAC"),
                New Catalogo("030505", "MARA - COTABAMBAS - APURIMAC"),
                New Catalogo("030506", "CHALLHUAHUACHO - COTABAMBAS - APURIMAC"),
                New Catalogo("030601", "CHINCHEROS - CHINCHEROS - APURIMAC"),
                New Catalogo("030602", "ANCO_HUALLO - CHINCHEROS - APURIMAC"),
                New Catalogo("030603", "COCHARCAS - CHINCHEROS - APURIMAC"),
                New Catalogo("030604", "HUACCANA - CHINCHEROS - APURIMAC"),
                New Catalogo("030605", "OCOBAMBA - CHINCHEROS - APURIMAC"),
                New Catalogo("030606", "ONGOY - CHINCHEROS - APURIMAC"),
                New Catalogo("030607", "URANMARCA - CHINCHEROS - APURIMAC"),
                New Catalogo("030608", "RANRACANCHA - CHINCHEROS - APURIMAC"),
                New Catalogo("030609", "ROCCHACC - CHINCHEROS - APURIMAC"),
                New Catalogo("030610", "EL PORVENIR - CHINCHEROS - APURIMAC"),
                New Catalogo("030611", "LOS CHANKAS - CHINCHEROS - APURIMAC"),
                New Catalogo("030701", "CHUQUIBAMBILLA - GRAU - APURIMAC"),
                New Catalogo("030702", "CURPAHUASI - GRAU - APURIMAC"),
                New Catalogo("030703", "GAMARRA - GRAU - APURIMAC"),
                New Catalogo("030704", "HUAYLLATI - GRAU - APURIMAC"),
                New Catalogo("030705", "MAMARA - GRAU - APURIMAC"),
                New Catalogo("030706", "MICAELA BASTIDAS - GRAU - APURIMAC"),
                New Catalogo("030707", "PATAYPAMPA - GRAU - APURIMAC"),
                New Catalogo("030708", "PROGRESO - GRAU - APURIMAC"),
                New Catalogo("030709", "SAN ANTONIO - GRAU - APURIMAC"),
                New Catalogo("030710", "SANTA ROSA - GRAU - APURIMAC"),
                New Catalogo("030711", "TURPAY - GRAU - APURIMAC"),
                New Catalogo("030712", "VILCABAMBA - GRAU - APURIMAC"),
                New Catalogo("030713", "VIRUNDO - GRAU - APURIMAC"),
                New Catalogo("030714", "CURASCO - GRAU - APURIMAC"),
                New Catalogo("040101", "AREQUIPA - AREQUIPA - AREQUIPA"),
                New Catalogo("040102", "ALTO SELVA ALEGRE - AREQUIPA - AREQUIPA"),
                New Catalogo("040103", "CAYMA - AREQUIPA - AREQUIPA"),
                New Catalogo("040104", "CERRO COLORADO - AREQUIPA - AREQUIPA"),
                New Catalogo("040105", "CHARACATO - AREQUIPA - AREQUIPA"),
                New Catalogo("040106", "CHIGUATA - AREQUIPA - AREQUIPA"),
                New Catalogo("040107", "JACOBO HUNTER - AREQUIPA - AREQUIPA"),
                New Catalogo("040108", "LA JOYA - AREQUIPA - AREQUIPA"),
                New Catalogo("040109", "MARIANO MELGAR - AREQUIPA - AREQUIPA"),
                New Catalogo("040110", "MIRAFLORES - AREQUIPA - AREQUIPA"),
                New Catalogo("040111", "MOLLEBAYA - AREQUIPA - AREQUIPA"),
                New Catalogo("040112", "PAUCARPATA - AREQUIPA - AREQUIPA"),
                New Catalogo("040113", "POCSI - AREQUIPA - AREQUIPA"),
                New Catalogo("040114", "POLOBAYA - AREQUIPA - AREQUIPA"),
                New Catalogo("040115", "QUEQUEÑA - AREQUIPA - AREQUIPA"),
                New Catalogo("040116", "SABANDIA - AREQUIPA - AREQUIPA"),
                New Catalogo("040117", "SACHACA - AREQUIPA - AREQUIPA"),
                New Catalogo("040118", "SAN JUAN DE SIGUAS - AREQUIPA - AREQUIPA"),
                New Catalogo("040119", "SAN JUAN DE TARUCANI - AREQUIPA - AREQUIPA"),
                New Catalogo("040120", "SANTA ISABEL DE SIGUAS - AREQUIPA - AREQUIPA"),
                New Catalogo("040121", "SANTA RITA DE SIGUAS - AREQUIPA - AREQUIPA"),
                New Catalogo("040122", "SOCABAYA - AREQUIPA - AREQUIPA"),
                New Catalogo("040123", "TIABAYA - AREQUIPA - AREQUIPA"),
                New Catalogo("040124", "UCHUMAYO - AREQUIPA - AREQUIPA"),
                New Catalogo("040125", "VITOR - AREQUIPA - AREQUIPA"),
                New Catalogo("040126", "YANAHUARA - AREQUIPA - AREQUIPA"),
                New Catalogo("040127", "YARABAMBA - AREQUIPA - AREQUIPA"),
                New Catalogo("040128", "YURA - AREQUIPA - AREQUIPA"),
                New Catalogo("040129", "JOSE LUIS BUSTAMANTE Y RIVERO - AREQUIPA - AREQUIPA"),
                New Catalogo("040201", "CAMANA - CAMANA - AREQUIPA"),
                New Catalogo("040202", "JOSE MARIA QUIMPER - CAMANA - AREQUIPA"),
                New Catalogo("040203", "MARIANO NICOLAS VALCARCEL - CAMANA - AREQUIPA"),
                New Catalogo("040204", "MARISCAL CACERES - CAMANA - AREQUIPA"),
                New Catalogo("040205", "NICOLAS DE PIEROLA - CAMANA - AREQUIPA"),
                New Catalogo("040206", "OCOÑA - CAMANA - AREQUIPA"),
                New Catalogo("040207", "QUILCA - CAMANA - AREQUIPA"),
                New Catalogo("040208", "SAMUEL PASTOR - CAMANA - AREQUIPA"),
                New Catalogo("040301", "CARAVELI - CARAVELI - AREQUIPA"),
                New Catalogo("040302", "ACARI - CARAVELI - AREQUIPA"),
                New Catalogo("040303", "ATICO - CARAVELI - AREQUIPA"),
                New Catalogo("040304", "ATIQUIPA - CARAVELI - AREQUIPA"),
                New Catalogo("040305", "BELLA UNION - CARAVELI - AREQUIPA"),
                New Catalogo("040306", "CAHUACHO - CARAVELI - AREQUIPA"),
                New Catalogo("040307", "CHALA - CARAVELI - AREQUIPA"),
                New Catalogo("040308", "CHAPARRA - CARAVELI - AREQUIPA"),
                New Catalogo("040309", "HUANUHUANU - CARAVELI - AREQUIPA"),
                New Catalogo("040310", "JAQUI - CARAVELI - AREQUIPA"),
                New Catalogo("040311", "LOMAS - CARAVELI - AREQUIPA"),
                New Catalogo("040312", "QUICACHA - CARAVELI - AREQUIPA"),
                New Catalogo("040313", "YAUCA - CARAVELI - AREQUIPA"),
                New Catalogo("040401", "APLAO - CASTILLA - AREQUIPA"),
                New Catalogo("040402", "ANDAGUA - CASTILLA - AREQUIPA"),
                New Catalogo("040403", "AYO - CASTILLA - AREQUIPA"),
                New Catalogo("040404", "CHACHAS - CASTILLA - AREQUIPA"),
                New Catalogo("040405", "CHILCAYMARCA - CASTILLA - AREQUIPA"),
                New Catalogo("040406", "CHOCO - CASTILLA - AREQUIPA"),
                New Catalogo("040407", "HUANCARQUI - CASTILLA - AREQUIPA"),
                New Catalogo("040408", "MACHAGUAY - CASTILLA - AREQUIPA"),
                New Catalogo("040409", "ORCOPAMPA - CASTILLA - AREQUIPA"),
                New Catalogo("040410", "PAMPACOLCA - CASTILLA - AREQUIPA"),
                New Catalogo("040411", "TIPAN - CASTILLA - AREQUIPA"),
                New Catalogo("040412", "UÑON - CASTILLA - AREQUIPA"),
                New Catalogo("040413", "URACA - CASTILLA - AREQUIPA"),
                New Catalogo("040414", "VIRACO - CASTILLA - AREQUIPA"),
                New Catalogo("040501", "CHIVAY - CAYLLOMA - AREQUIPA"),
                New Catalogo("040502", "ACHOMA - CAYLLOMA - AREQUIPA"),
                New Catalogo("040503", "CABANACONDE - CAYLLOMA - AREQUIPA"),
                New Catalogo("040504", "CALLALLI - CAYLLOMA - AREQUIPA"),
                New Catalogo("040505", "CAYLLOMA - CAYLLOMA - AREQUIPA"),
                New Catalogo("040506", "COPORAQUE - CAYLLOMA - AREQUIPA"),
                New Catalogo("040507", "HUAMBO - CAYLLOMA - AREQUIPA"),
                New Catalogo("040508", "HUANCA - CAYLLOMA - AREQUIPA"),
                New Catalogo("040509", "ICHUPAMPA - CAYLLOMA - AREQUIPA"),
                New Catalogo("040510", "LARI - CAYLLOMA - AREQUIPA"),
                New Catalogo("040511", "LLUTA - CAYLLOMA - AREQUIPA"),
                New Catalogo("040512", "MACA - CAYLLOMA - AREQUIPA"),
                New Catalogo("040513", "MADRIGAL - CAYLLOMA - AREQUIPA"),
                New Catalogo("040514", "SAN ANTONIO DE CHUCA - CAYLLOMA - AREQUIPA"),
                New Catalogo("040515", "SIBAYO - CAYLLOMA - AREQUIPA"),
                New Catalogo("040516", "TAPAY - CAYLLOMA - AREQUIPA"),
                New Catalogo("040517", "TISCO - CAYLLOMA - AREQUIPA"),
                New Catalogo("040518", "TUTI - CAYLLOMA - AREQUIPA"),
                New Catalogo("040519", "YANQUE - CAYLLOMA - AREQUIPA"),
                New Catalogo("040520", "MAJES - CAYLLOMA - AREQUIPA"),
                New Catalogo("040601", "CHUQUIBAMBA - CONDESUYOS - AREQUIPA"),
                New Catalogo("040602", "ANDARAY - CONDESUYOS - AREQUIPA"),
                New Catalogo("040603", "CAYARANI - CONDESUYOS - AREQUIPA"),
                New Catalogo("040604", "CHICHAS - CONDESUYOS - AREQUIPA"),
                New Catalogo("040605", "IRAY - CONDESUYOS - AREQUIPA"),
                New Catalogo("040606", "RIO GRANDE - CONDESUYOS - AREQUIPA"),
                New Catalogo("040607", "SALAMANCA - CONDESUYOS - AREQUIPA"),
                New Catalogo("040608", "YANAQUIHUA - CONDESUYOS - AREQUIPA"),
                New Catalogo("040701", "MOLLENDO - ISLAY - AREQUIPA"),
                New Catalogo("040702", "COCACHACRA - ISLAY - AREQUIPA"),
                New Catalogo("040703", "DEAN VALDIVIA - ISLAY - AREQUIPA"),
                New Catalogo("040704", "ISLAY - ISLAY - AREQUIPA"),
                New Catalogo("040705", "MEJIA - ISLAY - AREQUIPA"),
                New Catalogo("040706", "PUNTA DE BOMBON - ISLAY - AREQUIPA"),
                New Catalogo("040801", "COTAHUASI - LA UNION - AREQUIPA"),
                New Catalogo("040802", "ALCA - LA UNION - AREQUIPA"),
                New Catalogo("040803", "CHARCANA - LA UNION - AREQUIPA"),
                New Catalogo("040804", "HUAYNACOTAS - LA UNION - AREQUIPA"),
                New Catalogo("040805", "PAMPAMARCA - LA UNION - AREQUIPA"),
                New Catalogo("040806", "PUYCA - LA UNION - AREQUIPA"),
                New Catalogo("040807", "QUECHUALLA - LA UNION - AREQUIPA"),
                New Catalogo("040808", "SAYLA - LA UNION - AREQUIPA"),
                New Catalogo("040809", "TAURIA - LA UNION - AREQUIPA"),
                New Catalogo("040810", "TOMEPAMPA - LA UNION - AREQUIPA"),
                New Catalogo("040811", "TORO - LA UNION - AREQUIPA"),
                New Catalogo("050101", "AYACUCHO - HUAMANGA - AYACUCHO"),
                New Catalogo("050102", "ACOCRO - HUAMANGA - AYACUCHO"),
                New Catalogo("050103", "ACOS VINCHOS - HUAMANGA - AYACUCHO"),
                New Catalogo("050104", "CARMEN ALTO - HUAMANGA - AYACUCHO"),
                New Catalogo("050105", "CHIARA - HUAMANGA - AYACUCHO")
            }
        End Function

        ''' <summary>
        ''' Código de otros conceptos tributarios
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo14() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1000", "Total valor de venta - operaciones exportadas"),
                New Catalogo("1001", "Total valor de venta - operaciones gravadas"),
                New Catalogo("1002", "Total valor de venta - operaciones inafectas"),
                New Catalogo("1003", "Total valor de venta - operaciones exoneradas"),
                New Catalogo("1004", "Total valor de venta – Operaciones gratuitas"),
                New Catalogo("1005", "Sub total de venta"),
                New Catalogo("2001", "Percepciones"),
                New Catalogo("2002", "Retenciones"),
                New Catalogo("2003", "Detracciones"),
                New Catalogo("2004", "Bonificaciones"),
                New Catalogo("2005", "Total descuentos"),
                New Catalogo("3001", "FISE (Ley 29852) Fondo Inclusión Social Energético")
            }
        End Function

        ''' <summary>
        ''' Códigos de elementos adicionales en la factura y boleta electrónica
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo15() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1000", "Monto en Letras"),
                New Catalogo("1002", "Leyenda: TRANSFERENCIA GRATUITA DE UN BIEN Y/O SERVICIO PRESTADO GRATUITAMENTE"),
                New Catalogo("2000", "Leyenda: COMPROBANTE DE PERCEPCIÓN"),
                New Catalogo("2001", "Leyenda: BIENES TRANSFERIDOS EN LA AMAZONÍA REGIÓN SELVAPARA SER CONSUMIDOS EN LA MISMA"),
                New Catalogo("2002", "Leyenda: SERVICIOS PRESTADOS EN LA AMAZONÍA  REGIÓN SELVA PARA SER CONSUMIDOS EN LA MISMA"),
                New Catalogo("2003", "Leyenda: CONTRATOS DE CONSTRUCCIÓN EJECUTADOS  EN LA AMAZONÍA REGIÓN SELVA"),
                New Catalogo("2004", "Leyenda: Agencia de Viaje - Paquete turístico"),
                New Catalogo("2005", "Leyenda: Venta realizada por emisor itinerante"),
                New Catalogo("2006", "Leyenda: Operación sujeta a detracción"),
                New Catalogo("2007", "Leyenda: Operación sujeta a IVAP"),
                New Catalogo("2010", "Restitución Simplificado de Derechos Arancelarios"),
                New Catalogo("3000", "Detracciones: CODIGO DE BB Y SS SUJETOS A DETRACCION"),
                New Catalogo("3001", "Detracciones: NUMERO DE CTA EN EL BN"),
                New Catalogo("3002", "Detracciones: Recursos Hidrobiológicos-Nombre y matrícula de la embarcación"),
                New Catalogo("3003", "Detracciones: Recursos Hidrobiológicos-Tipo y cantidad de especie vendida"),
                New Catalogo("3004", "Detracciones: Recursos Hidrobiológicos -Lugar de descarga"),
                New Catalogo("3005", "Detracciones: Recursos Hidrobiológicos -Fecha de descarga"),
                New Catalogo("3006", "Detracciones: Transporte Bienes vía terrestre – Numero Registro MTC"),
                New Catalogo("3007", "Detracciones: Transporte Bienes vía terrestre – configuración vehicular"),
                New Catalogo("3008", "Detracciones: Transporte Bienes vía terrestre – punto de origen"),
                New Catalogo("3009", "Detracciones: Transporte Bienes vía terrestre – punto destino"),
                New Catalogo("3010", "Detracciones: Transporte Bienes vía terrestre – valor referencial preliminar"),
                New Catalogo("4000", "Beneficio hospedajes: Código País de emisión del pasaporte"),
                New Catalogo("4001", "Beneficio hospedajes: Código País de residencia del sujeto no domiciliado"),
                New Catalogo("4002", "Beneficio Hospedajes: Fecha de ingreso al país "),
                New Catalogo("4003", "Beneficio Hospedajes: Fecha de ingreso al establecimiento"),
                New Catalogo("4004", "Beneficio Hospedajes: Fecha de salida del establecimiento"),
                New Catalogo("4005", "Beneficio Hospedajes: Número de días de permanencia"),
                New Catalogo("4006", "Beneficio Hospedajes: Fecha de consumo "),
                New Catalogo("4007", "Beneficio Hospedajes: Paquete turístico - Nombres y Apellidos del Huésped "),
                New Catalogo("4008", "Beneficio Hospedajes: Paquete turístico – Tipo documento identidad del huésped  "),
                New Catalogo("4009", "Beneficio Hospedajes: Paquete turístico – Numero de documento identidad de huésped "),
                New Catalogo("5000", "Proveedores Estado: Número de Expediente"),
                New Catalogo("5001", "Proveedores Estado : Código de unidad ejecutora"),
                New Catalogo("5002", "Proveedores Estado : N° de proceso de selección"),
                New Catalogo("5003", "Proveedores Estado : N° de contrato"),
                New Catalogo("6000", "Comercialización de Oro :  Código Unico Concesión Minera"),
                New Catalogo("6001", "Comercialización de Oro :  N° declaración compromiso"),
                New Catalogo("6002", "Comercialización de Oro :  N° Reg. Especial .Comerci. Oro"),
                New Catalogo("6003", "Comercialización de Oro :  N° Resolución que autoriza Planta de Beneficio"),
                New Catalogo("6004", "Comercialización de Oro : Ley Mineral (% concent. oro)"),
                New Catalogo("6005", "Comercialización de Oro : Naturaleza del mineral"),
                New Catalogo("6006", "Comercialización de Oro : Nombre del derecho minero"),
                New Catalogo("7000", "Primera venta de mercancia identificable entre usuarios de la zona comercial"),
                New Catalogo("7001", "Venta exonerada del IGV-ISC-IPM. Prohibida la venta fuera de la zona comercial de Tacna")
            }
        End Function

        ''' <summary>
        ''' Código de tipo de precio de venta unitario
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo16() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Precio unitario (incluye el IGV)"),
                New Catalogo("02", "Valor referencial unitario en operaciones no onerosas (Gratuitas)"),
                New Catalogo("03", "Tarifas reguladas")
            }
        End Function

        ''' <summary>
        ''' Código de tipo de operación
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo17() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Venta lnterna"),
                New Catalogo("02", "Exportación de bienes"),
                New Catalogo("03", "No Domiciliados"),
                New Catalogo("04", "Venta Interna – Anticipos"),
                New Catalogo("05", "Venta Itinerante "),
                New Catalogo("06", "Factura Guía"),
                New Catalogo("07", "Venta Arroz Pilado"),
                New Catalogo("08", "Factura - Comprobante de Percepción"),
                New Catalogo("10", "Factura - Guía remitente"),
                New Catalogo("11", "Factura - Guía transportista"),
                New Catalogo("12", "Boleta de venta – Comprobante de Percepción."),
                New Catalogo("13", "Gasto Deducible Persona Natural"),
                New Catalogo("14", "Exportación de servicios – prestación de servicios de hospedaje No Dom"),
                New Catalogo("15", "Exportación de servicios – Transporte de navieras"),
                New Catalogo("16", "Exportación de servicios – servicios  a naves y aeronaves de bandera extranjera"),
                New Catalogo("17", "Exportación de servicios – RES"),
                New Catalogo("18", "Exportación de servicios  - Servicios que conformen un Paquete Turístico"),
                New Catalogo("19", "Exportación de servicios – Servicios complementarios al transporte de carga"),
                New Catalogo("20", "Exportación de servicios – Suministro de energía eléctrica a favor de sujetos domiciliados en ZED"),
                New Catalogo("21", "Exportación de servicios – Prestación servicios realizados parcialmente en el extranjero")
            }
        End Function

        ''' <summary>
        ''' Código de modalidad de transporte
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo18() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Transporte público"),
                New Catalogo("02", "Transporte privado")
            }
        End Function

        ''' <summary>
        ''' Código de estado del ítem (resumen diario)
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo19() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1", " Adicionar"),
                New Catalogo("2", " Modificar"),
                New Catalogo("3", " Anulado")
            }
        End Function

        ''' <summary>
        ''' Código de motivo de traslado
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo20() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Venta"),
                New Catalogo("02", "Compra"),
                New Catalogo("04", "Traslado entre establecimientos de la misma empresa"),
                New Catalogo("08", "Importación"),
                New Catalogo("09", "Exportación"),
                New Catalogo("13", "Otros"),
                New Catalogo("14", "Venta sujeta a confirmación del comprador"),
                New Catalogo("18", "Traslado emisor itinerante CP"),
                New Catalogo("19", "Traslado a zona primaria")
            }
        End Function

        ''' <summary>
        ''' Código de documentos relacionados (sólo guía de remisión electrónica)
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo21() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Numeración DAM"),
                New Catalogo("02", "Número de orden de entrega"),
                New Catalogo("03", "Número SCOP"),
                New Catalogo("04", "Número de manifiesto de carga"),
                New Catalogo("05", "Número de constancia de detracción"),
                New Catalogo("06", "Otros")
            }
        End Function

        ''' <summary>
        ''' Código de regimen de percepciones
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo22() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Percepción Venta Interna"),
                New Catalogo("02", "Percepción a la adquisición de combustible"),
                New Catalogo("03", "Percepción realizada al agente de percepción con tasa especial")
            }
        End Function

        ''' <summary>
        ''' Código de regimen de retenciones
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo23() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("01", "Tasa 3%"),
                New Catalogo("02", "Tasa 6%")
            }
        End Function

        ''' <summary>
        ''' Código de tarifa de servicios públicos
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo24() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("L001", "AT"),
                New Catalogo("L002", "MT2"),
                New Catalogo("L003", "MT3"),
                New Catalogo("L004", "MT4"),
                New Catalogo("L005", "BT2"),
                New Catalogo("L006", "BT3"),
                New Catalogo("L007", "BT4"),
                New Catalogo("L008", "BT5A"),
                New Catalogo("L009", "BT5B NO RESIDENCIAL"),
                New Catalogo("L010", "BT6"),
                New Catalogo("L011", "BT5C-AP"),
                New Catalogo("L012", "BT5D"),
                New Catalogo("L013", "BT5E"),
                New Catalogo("L014", "BT7"),
                New Catalogo("L015", "BT8"),
                New Catalogo("A011", "COMERCIAL"),
                New Catalogo("A012", "INDUSTRIAL"),
                New Catalogo("A014", "DOMÉSTICO"),
                New Catalogo("A015", "SOCIAL")
            }
        End Function

        ''' <summary>
        ''' Código de producto SUNAT
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo25() As List(Of Catalogo)
            Return New List(Of Catalogo)
        End Function

        ''' <summary>
        ''' Tipo de préstamo (créditos hipotecarios) 
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo26() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("0", "Sin información"),
                New Catalogo("1", "Si es construcción /adquisición"),
                New Catalogo("2", "Si es para refacción, remodelación, ampliación, mejoramiento o subdivisión de vivienda propia")
            }
        End Function

        ''' <summary>
        ''' Indicador de primera vivienda
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo27() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("0", "Sin indicador"),
                New Catalogo("1", "Calificado para crédito Mi Vivienda / Techo Propio"),
                New Catalogo("2", "Libre disposición de la AFP"),
                New Catalogo("3", "Calificado como primera vivienda de acuerdo a la información proporcionada por el cliente (para créditos otorgados a partir del 01.01.2013)")
            }
        End Function

        ''' <summary>
        ''' Código de tipo de operación
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo51() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("0101", "Venta interna"),
                New Catalogo("0112", "Venta Interna - Sustenta Gastos Deducibles Persona Natural"),
                New Catalogo("0113", "Venta Interna-NRUS"),
                New Catalogo("0200", "Exportación de Bienes"),
                New Catalogo("0201", "Exportación de Servicios – Prestación servicios realizados íntegramente en el país"),
                New Catalogo("0202", "Exportación de Servicios – Prestación de servicios de hospedaje No Domiciliado"),
                New Catalogo("0203", "Exportación de Servicios – Transporte de navieras"),
                New Catalogo("0204", "Exportación de Servicios – Servicios  a naves y aeronaves de bandera extranjera"),
                New Catalogo("0205", "Exportación de Servicios  - Servicios que conformen un Paquete Turístico"),
                New Catalogo("0206", "Exportación de Servicios – Servicios complementarios al transporte de carga"),
                New Catalogo("0207", "Exportación de Servicios – Suministro de energía eléctrica a favor de sujetos domiciliados en ZED"),
                New Catalogo("0208", "Exportación de Servicios – Prestación servicios realizados parcialmente en el extranjero"),
                New Catalogo("0301", "Operaciones con Carta de porte aéreo (emitidas en el ámbito nacional)"),
                New Catalogo("0302", "Operaciones de Transporte ferroviario de pasajeros"),
                New Catalogo("0303", "Operaciones de Pago de regalía petrolera"),
                New Catalogo("0401", "Ventas no domiciliados que no califican como exportación"),
                New Catalogo("1001", "Operación Sujeta a Detracción"),
                New Catalogo("1002", "Operación Sujeta a Detracción- Recursos Hidrobiológicos"),
                New Catalogo("1003", "Operación Sujeta a Detracción- Servicios de Transporte Pasajeros"),
                New Catalogo("1004", "Operación Sujeta a Detracción- Servicios de Transporte Carga"),
                New Catalogo("2001", "Operación Sujeta a Percepción")
            }
        End Function

        ''' <summary>
        ''' Códigos de leyendas
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo52() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1000", "Monto en Letras"),
                New Catalogo("1002", "Leyenda: TRANSFERENCIA GRATUITA DE UN BIEN Y/O SERVICIO PRESTADO GRATUITAMENTE"),
                New Catalogo("2000", "Leyenda: COMPROBANTE DE PERCEPCIÓN"),
                New Catalogo("2001", "Leyenda: BIENES TRANSFERIDOS EN LA AMAZONÍA REGIÓN SELVA PARA SER CONSUMIDOS EN LA MISMA"),
                New Catalogo("2002", "Leyenda: SERVICIOS PRESTADOS EN LA AMAZONÍA  REGIÓN SELVA PARA SER CONSUMIDOS EN LA MISMA"),
                New Catalogo("2003", "Leyenda: CONTRATOS DE CONSTRUCCIÓN EJECUTADOS  EN LA AMAZONÍA REGIÓN SELVA"),
                New Catalogo("2004", "Leyenda: Agencia de Viaje - Paquete turístico"),
                New Catalogo("2005", "Leyenda: Venta realizada por emisor itinerante"),
                New Catalogo("2006", "Leyenda: Operación sujeta a detracción"),
                New Catalogo("2007", "Leyenda: Operación sujeta al IVAP"),
                New Catalogo("2008", "Leyenda: VENTA EXONERADA DEL IGV-ISC-IPM. PROHIBIDA LA VENTA FUERA DE LA ZONA COMERCIAL DE TACNA"),
                New Catalogo("2009", "Leyenda: PRIMERA VENTA DE MERCANCÍA IDENTIFICABLE ENTRE USUARIOS DE LA ZONA COMERCIAL"),
                New Catalogo("2010", "Restitucion Simplificado de Derechos Arancelarios"),
                New Catalogo("2011", "Leyenda: EXPORTACION DE SERVICIOS - DECRETO LEGISLATIVO Nº 919")
            }
        End Function

        ''' <summary>
        ''' Códigos de cargos o descuentos
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo53() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("00", "Descuentos que afectan la base imponible del IGV/IVAP"),
                New Catalogo("01", "Descuentos que no afectan la base imponible del IGV/IVAP"),
                New Catalogo("02", "Descuentos globales que afectan la base imponible del IGV/IVAP"),
                New Catalogo("03", "Descuentos globales que no afectan la base imponible del IGV/IVAP"),
                New Catalogo("04", "Descuentos globales por anticipos gravados que afectan la base imponible del IGV/IVAP "),
                New Catalogo("05", "Descuentos globales por anticipos exonerados"),
                New Catalogo("06", "Descuentos globales por anticipos inafectos"),
                New Catalogo("45", "FISE"),
                New Catalogo("46", "Recargo al consumo y/o propinas"),
                New Catalogo("47", "Cargos que afectan la base imponible del IGV/IVAP"),
                New Catalogo("48", "Cargos que no afectan la base imponible del IGV/IVAP"),
                New Catalogo("49", "Cargos globales que afectan la base imponible del IGV/IVAP"),
                New Catalogo("50", "Cargos globales que no afectan la base imponible del IGV/IVAP"),
                New Catalogo("51", "Percepción venta interna"),
                New Catalogo("52", "Percepción a la adquisición de combustible"),
                New Catalogo("53", "Percepción realizada al agente de percepción con tasa especial")
            }
        End Function

        ''' <summary>
        ''' Códigos de bienes y servicios sujetos a detracciones
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo54() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("001", "Azúcar y melaza de caña"),
                New Catalogo("002", "Arroz"),
                New Catalogo("003", "Alcohol etílico"),
                New Catalogo("004", "Recursos hidrobiológicos"),
                New Catalogo("005", "Maíz amarillo duro"),
                New Catalogo("007", "Caña de azúcar"),
                New Catalogo("008", "Madera"),
                New Catalogo("009", "Arena y piedra."),
                New Catalogo("010", "Residuos, subproductos, desechos, recortes y desperdicios"),
                New Catalogo("011", "Bienes gravados con el IGV, o renuncia a la exoneración"),
                New Catalogo("012", "Intermediación laboral y tercerización"),
                New Catalogo("013", "Animales vivos"),
                New Catalogo("014", "Carnes y despojos comestibles"),
                New Catalogo("015", "Abonos, cueros y pieles de origen animal"),
                New Catalogo("016", "Aceite de pescado"),
                New Catalogo("017", "Harina, polvo y 'pellets' de pescado, crustáceos, moluscos y demás invertebrados acuáticos"),
                New Catalogo("019", "Arrendamiento de bienes muebles"),
                New Catalogo("020", "Mantenimiento y reparación de bienes muebles"),
                New Catalogo("021", "Movimiento de carga"),
                New Catalogo("022", "Otros servicios empresariales"),
                New Catalogo("023", "Leche"),
                New Catalogo("024", "Comisión mercantil"),
                New Catalogo("025", "Fabricación de bienes por encargo"),
                New Catalogo("026", "Servicio de transporte de personas"),
                New Catalogo("027", "Servicio de transporte de carga"),
                New Catalogo("028", "Transporte de pasajeros"),
                New Catalogo("030", "Contratos de construcción"),
                New Catalogo("031", "Oro gravado con el IGV"),
                New Catalogo("034", "Minerales metálicos no auríferos"),
                New Catalogo("035", "Bienes exonerados del IGV"),
                New Catalogo("036", "Oro y demás minerales metálicos exonerados del IGV"),
                New Catalogo("037", "Demás servicios gravados con el IGV"),
                New Catalogo("039", "Minerales no metálicos"),
                New Catalogo("040", "Bien inmueble gravado con IGV")
            }
        End Function

        ''' <summary>
        ''' Código de identificación del concepto tributario
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo55() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("3001", "Detracciones: Recursos Hidrobiológicos-Matrícula de la embarcación"),
                New Catalogo("3002", "Detracciones: Recursos Hidrobiológicos-Nombre de la embarcación"),
                New Catalogo("3003", "Detracciones: Recursos Hidrobiológicos-Tipo de especie vendida"),
                New Catalogo("3004", "Detracciones: Recursos Hidrobiológicos-Lugar de descarga"),
                New Catalogo("3005", "Detracciones: Recursos Hidrobiológicos-Fecha de descarga"),
                New Catalogo("3006", "Detracciones: Recursos Hidrobiológicos-Cantidad de especie vendida"),
                New Catalogo("3050", "Transportre Terreste - Número de asiento"),
                New Catalogo("3051", "Transporte Terrestre - Información de manifiesto de pasajeros"),
                New Catalogo("3052", "Transporte Terrestre - Número de documento de identidad del pasajero"),
                New Catalogo("3053", "Transporte Terrestre - Tipo de documento de identidad del pasajero"),
                New Catalogo("3054", "Transporte Terrestre - Nombres y apellidos del pasajero"),
                New Catalogo("3055", "Transporte Terrestre - Ciudad o lugar de destino - Ubigeo"),
                New Catalogo("3056", "Transporte Terrestre - Ciudad o lugar de destino - Dirección detallada"),
                New Catalogo("3057", "Transporte Terrestre - Ciudad o lugar de origen - Ubigeo"),
                New Catalogo("3058", "Transporte Terrestre - Ciudad o lugar de origen - Dirección detallada"),
                New Catalogo("3059", "Transporte Terrestre - Fecha de inicio programado"),
                New Catalogo("3060", "Transporte Terrestre - Hora de inicio programado"),
                New Catalogo("4000", "Beneficio Hospedajes-Paquete turístico: Código de país de emisión del pasaporte"),
                New Catalogo("4001", "Beneficio Hospedajes: Código de país de residencia del sujeto no domiciliado"),
                New Catalogo("4002", "Beneficio Hospedajes: Fecha de ingreso al país"),
                New Catalogo("4003", "Beneficio Hospedajes: Fecha de Ingreso al Establecimiento"),
                New Catalogo("4004", "Beneficio Hospedajes: Fecha de Salida del Establecimiento"),
                New Catalogo("4005", "Beneficio Hospedajes: Número de Días de Permanencia"),
                New Catalogo("4006", "Beneficio Hospedajes: Fecha de Consumo "),
                New Catalogo("4007", "Beneficio Hospedajes-Paquete turístico: Nombres y apellidos del huesped "),
                New Catalogo("4008", "Beneficio Hospedajes-Paquete turístico: Tipo de documento de identidad del huesped "),
                New Catalogo("4009", "Beneficio Hospedajes-Paquete turístico: Número de documento de identidad del huesped "),
                New Catalogo("4030", "Carta Porte Aéreo:  Lugar de origen - Código de ubigeo"),
                New Catalogo("4031", "Carta Porte Aéreo:  Lugar de origen - Dirección detallada"),
                New Catalogo("4032", "Carta Porte Aéreo:  Lugar de destino - Código de ubigeo"),
                New Catalogo("4033", "Carta Porte Aéreo:  Lugar de destino - Dirección detallada"),
                New Catalogo("4040", "BVME transporte ferroviario: Pasajero - Apellidos y Nombres"),
                New Catalogo("4041", "BVME transporte ferroviario: Pasajero - Tipo de documento de identidad"),
                New Catalogo("4042", "BVME transporte ferroviario: Servicio transporte: Ciudad o lugar de origen - Código de ubigeo"),
                New Catalogo("4043", "BVME transporte ferroviario: Servicio transporte: Ciudad o lugar de origen - Dirección detallada"),
                New Catalogo("4044", "BVME transporte ferroviario: Servicio transporte: Ciudad o lugar de destino - Código de ubigeo"),
                New Catalogo("4045", "BVME transporte ferroviario: Servicio transporte: Ciudad o lugar de destino - Dirección detallada"),
                New Catalogo("4046", "BVME transporte ferroviario: Servicio transporte:Número de asiento"),
                New Catalogo("4047", "BVME transporte ferroviario: Servicio transporte: Hora programada de inicio de viaje"),
                New Catalogo("4048", "BVME transporte ferroviario: Servicio transporte: Fecha programada de inicio de viaje"),
                New Catalogo("4049", "BVME transporte ferroviario: Pasajero - Número de documento de identidad"),
                New Catalogo("4060", "Regalía Petrolera: Decreto Supremo de aprobación del contrato"),
                New Catalogo("4061", "Regalía Petrolera: Area de contrato (Lote)"),
                New Catalogo("4062", "Regalía Petrolera: Periodo de pago - Fecha de inicio"),
                New Catalogo("4063", "Regalía Petrolera: Periodo de pago - Fecha de fin"),
                New Catalogo("4064", "Regalía Petrolera: Fecha de Pago"),
                New Catalogo("5000", "Proveedores Estado: Número de Expediente"),
                New Catalogo("5001", "Proveedores Estado: Código de Unidad Ejecutora"),
                New Catalogo("5002", "Proveedores Estado: N° de Proceso de Selección"),
                New Catalogo("5003", "Proveedores Estado: N° de Contrato"),
                New Catalogo("5010", "Numero de Placa"),
                New Catalogo("5011", "Categoria"),
                New Catalogo("5012", "Marca"),
                New Catalogo("5013", "Modelo"),
                New Catalogo("5014", "Color"),
                New Catalogo("5015", "Motor"),
                New Catalogo("5016", "Combustible"),
                New Catalogo("5017", "Form. Rodante"),
                New Catalogo("5018", "VIN"),
                New Catalogo("5019", "Serie/Chasis"),
                New Catalogo("5020", "Año fabricacion"),
                New Catalogo("5021", "Año modelo"),
                New Catalogo("5022", "Version"),
                New Catalogo("5023", "Ejes"),
                New Catalogo("5024", "Asientos"),
                New Catalogo("5025", "Pasajeros"),
                New Catalogo("5026", "Ruedas"),
                New Catalogo("5027", "Carroceria"),
                New Catalogo("5028", "Potencia"),
                New Catalogo("5029", "Cilindros"),
                New Catalogo("5030", "Ciliindrada"),
                New Catalogo("5031", "Peso Bruto"),
                New Catalogo("5032", "Peso Neto"),
                New Catalogo("5033", "Carga Util"),
                New Catalogo("5034", "Longitud"),
                New Catalogo("5035", "Altura"),
                New Catalogo("5036", "Ancho"),
                New Catalogo("5060", "Gas Natural - Lectura Anterior"),
                New Catalogo("5061", "Gas Natural - Lectura Actual"),
                New Catalogo("5062", "Gas Natural - Volumen consumido a Condiciones de lectura"),
                New Catalogo("5063", "Gas Natural - Factor de correccion del volumen"),
                New Catalogo("5064", "Gas Natural - Volumen a condiciones Estandares"),
                New Catalogo("5065", "Gas Natural - Volumen facturado"),
                New Catalogo("5066", "Gas Natural - Poder Calorifico Superior Promedio del Gas"),
                New Catalogo("6000", "Comercialización de Oro:  Código Unico Concesión Minera"),
                New Catalogo("6001", "Comercialización de Oro:  N° declaración compromiso"),
                New Catalogo("6002", "Comercialización de Oro:  N° Reg. Especial .Comerci. Oro"),
                New Catalogo("6003", "Comercialización de Oro:  N° Resolución que autoriza Planta de Beneficio"),
                New Catalogo("6004", "Comercialización de Oro: Ley Mineral (% concent. oro)"),
                New Catalogo("7000", "Gastos Art. 37 Renta:  Número de Placa"),
                New Catalogo("7001", "Créditos Hipotecarios: Tipo de préstamo"),
                New Catalogo("7002", "Créditos Hipotecarios: Indicador de Primera Vivienda"),
                New Catalogo("7003", "Créditos Hipotecarios: Partida Registral"),
                New Catalogo("7004", "Créditos Hipotecarios: Número de contrato"),
                New Catalogo("7005", "Créditos Hipotecarios: Fecha de otorgamiento del crédito"),
                New Catalogo("7006", "Créditos Hipotecarios: Dirección del predio - Código de ubigeo"),
                New Catalogo("7007", "Créditos Hipotecarios: Dirección del predio - Dirección completa"),
                New Catalogo("7008", "Créditos Hipotecarios: Dirección del predio - Urbanización"),
                New Catalogo("7009", "Créditos Hipotecarios: Dirección del predio - Provincia"),
                New Catalogo("7010", "Créditos Hipotecarios: Dirección del predio - Distrito"),
                New Catalogo("7011", "Créditos Hipotecarios: Dirección del predio - Departamento"),
                New Catalogo("7012", "Créditos Hipotecarios: Monto del principal"),
                New Catalogo("7020", "Subpartida nacional"),
                New Catalogo("7021", "Numero de declaracion aduanera (DAM)")
            }
        End Function

        ''' <summary>
        ''' Código de tipo de servicio público
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo56() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1", "Energía eléctrica"),
                New Catalogo("2", "Agua"),
                New Catalogo("3", "Cable"),
                New Catalogo("4", "Internet"),
                New Catalogo("5", "Otros servicios regulados por OSIPTEL")
            }
        End Function

        ''' <summary>
        ''' Código de tipo de servicio públicos - telecomunicaciones
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo57() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1", "Servicios Portadores"),
                New Catalogo("2", "Teleservicios o Servicios Finales"),
                New Catalogo("3", "Servicios de Difusión"),
                New Catalogo("4", "Servicios de valor añadido")
            }
        End Function

        ''' <summary>
        ''' Código de tipo de medidor (recibo de luz)
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo58() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("1", "Trifásico"),
                New Catalogo("2", "Monofásico")
            }
        End Function

        ''' <summary>
        ''' Medios de Pago
        ''' </summary>
        ''' <returns></returns>
        Private Function Catalogo59() As List(Of Catalogo)
            Return New List(Of Catalogo) From {
                New Catalogo("001", "Depósito en cuenta"),
                New Catalogo("002", "Giro"),
                New Catalogo("003", "Transferencia de fondos"),
                New Catalogo("004", "Orden de pago"),
                New Catalogo("005", "Tarjeta de débito"),
                New Catalogo("006", "Tarjeta de crédito emitida en el país por una empresa del sistema financiero "),
                New Catalogo("007", "Cheques con la cláusula de 'NO NEGOCIABLE', 'INTRANSFERIBLES', 'NO A LA ORDEN' u otra equivalente, a que se refiere el inciso g) del artículo 5° de la ley"),
                New Catalogo("008", "Efectivo, por operaciones en las que no existe obligación de utilizar medio de pago"),
                New Catalogo("009", "Efectivo, en los demás casos"),
                New Catalogo("010", "Medios de pago usados en comercio exterior "),
                New Catalogo("011", "Documentos emitidos por las EDPYMES y las cooperativas de ahorro y crédito no autorizadas a captar depósitos del público"),
                New Catalogo("012", "Tarjeta de crédito emitida en el país o en el exterior por una empresa no perteneciente al sistema financiero, cuyo objeto principal sea la emisión y administración de tarjetas de crédito"),
                New Catalogo("013", "Tarjetas de crédito emitidas en el exterior por empresas bancarias o financieras no domiciliadas"),
                New Catalogo("101", "Transferencias – Comercio exterior"),
                New Catalogo("102", "Cheques bancarios - Comercio exterior"),
                New Catalogo("103", "Orden de pago simple - Comercio exterior"),
                New Catalogo("104", "Orden de pago documentario - Comercio exterior"),
                New Catalogo("105", "Remesa simple - Comercio exterior"),
                New Catalogo("106", "Remesa documentaria - Comercio exterior"),
                New Catalogo("107", "Carta de crédito simple - Comercio exterior"),
                New Catalogo("108", "Carta de crédito documentario - Comercio exterior"),
                New Catalogo("999", "Otros medios de pago")
            }
        End Function
    End Class
End Namespace