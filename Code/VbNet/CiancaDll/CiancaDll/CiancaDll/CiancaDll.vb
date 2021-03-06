﻿'Imports
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO

Public Class Conexion

#Region "DATAMEMBERS"

    '''
    ''' En esta región se declaran variables de la clase, las cuales se les
    ''' llama Data Members.
    '''
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "m1oG9kp8oKN5EltOgGJ9j9l7zjohtNAk3Q7QHHE3",
        .BasePath = "https://appadmin-ubicamatic.firebaseio.com/"
        }

    Public firebase As IFirebaseClient

    Public strMsgTitle As String = "Empacadora Cianca - 2020 (C)"

#End Region

#Region "SHARED_FUNCTIONS"

    ''' En esta región se implementan las funciones compartidas de la clase,
    ''' si la función no es compartida o pública, esta no podrá ser usada por
    ''' la aplicación que la llame aunque esté correctamente importada.
    Public Function Con_Global() As Boolean
        ' Se encarga de realizar la conexión con la base de datos.
        ' Regresa el estado de la conexión como Boolean.

        'Variables locales
        Dim estado As Boolean = False

        Try
            firebase = New FireSharp.FirebaseClient(fcon)
            estado = True
        Catch ex As Exception
            MsgBox("Error de conexión internet", MsgBoxStyle.Critical, strMsgTitle)
            estado = False
        End Try

        'Resultado de la conexión
        Return estado
    End Function

#End Region

End Class

Public Class Datos

    'En esta región se concentran todos los datos, variables de todas las
    'Tablas de firebase, por cada nombre clave deberá existir una variable con su Set y Get.

#Region "USUARIOS"

#Region "DATAMEMBERS"
    Private _Apellidos As String
    Private _MailUsr As String
    Private _NombreUsr As String
    Private _Pass As String
    Private _Unidad As String
    Private _Token As String
#End Region

#Region "PROPIEDADES"
    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(value As String)
            _Apellidos = value
        End Set
    End Property

    Public Property MailUsr As String
        Get
            Return _MailUsr
        End Get
        Set(value As String)
            _MailUsr = value
        End Set
    End Property

    Public Property NombreUsr As String
        Get
            Return _NombreUsr
        End Get
        Set(value As String)
            _NombreUsr = value
        End Set
    End Property

    Public Property Pass As String
        Get
            Return _Pass
        End Get
        Set(value As String)
            _Pass = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(value As String)
            _Unidad = value
        End Set
    End Property

    Public Property Token As String
        Get
            Return _Token
        End Get
        Set(value As String)
            _Token = value
        End Set
    End Property
#End Region

#End Region

#Region "CLIENTES"

#Region "DATAMEMBERS"
    Private _Colonia As String
    Private _Dir As String
    Private _Estado As String
    Private _LastV As String
    Private _Lat As String
    Private _Lon As String
    Private _Mail As String
    Private _Municipio As String
    Private _Nombre As String
    Private _Rfc As String
    Private _Tel As String
#End Region

#Region "PROPIEDADES"
    Public Property Colonia As String
        Get
            Return _Colonia
        End Get
        Set(value As String)
            _Colonia = value
        End Set
    End Property

    Public Property Dir As String
        Get
            Return _Dir
        End Get
        Set(value As String)
            _Dir = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    Public Property LastV As String
        Get
            Return _LastV
        End Get
        Set(value As String)
            _LastV = value
        End Set
    End Property

    Public Property Lat As String
        Get
            Return _Lat
        End Get
        Set(value As String)
            _Lat = value
        End Set
    End Property

    Public Property Lon As String
        Get
            Return _Lon
        End Get
        Set(value As String)
            _Lon = value
        End Set
    End Property

    Public Property Mail As String
        Get
            Return _Mail
        End Get
        Set(value As String)
            _Mail = value
        End Set
    End Property

    Public Property Municipio As String
        Get
            Return _Municipio
        End Get
        Set(value As String)
            _Municipio = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Rfc As String
        Get
            Return _Rfc
        End Get
        Set(value As String)
            _Rfc = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return _Tel
        End Get
        Set(value As String)
            _Tel = value
        End Set
    End Property
#End Region

#End Region

#Region "PROVEEDORES"

#Region "DATAMEMBERS"

    Private _Col_P As String
    Private _Dir_P As String
    Private _Edo_P As String
    Private _Mail_P As String
    Private _Muni_P As String
    Private _Nom_P As String
    Private _Rfc_P As String
    Private _Tel_P As String
    Private _Tipo_P As String

#End Region

#Region "PROPIEDADES"

    Public Property Col_P As String
        Get
            Return _Col_P
        End Get
        Set(value As String)
            _Col_P = value
        End Set
    End Property

    Public Property Dir_P As String
        Get
            Return _Dir_P
        End Get
        Set(value As String)
            _Dir_P = value
        End Set
    End Property

    Public Property Edo_P As String
        Get
            Return _Edo_P
        End Get
        Set(value As String)
            _Edo_P = value
        End Set
    End Property

    Public Property Mail_P As String
        Get
            Return _Mail_P
        End Get
        Set(value As String)
            _Mail_P = value
        End Set
    End Property

    Public Property Muni_P As String
        Get
            Return _Muni_P
        End Get
        Set(value As String)
            _Muni_P = value
        End Set
    End Property

    Public Property Nom_P As String
        Get
            Return _Nom_P
        End Get
        Set(value As String)
            _Nom_P = value
        End Set
    End Property

    Public Property Rfc_P As String
        Get
            Return _Rfc_P
        End Get
        Set(value As String)
            _Rfc_P = value
        End Set
    End Property

    Public Property Tel_P As String
        Get
            Return _Tel_P
        End Get
        Set(value As String)
            _Tel_P = value
        End Set
    End Property

    Public Property Tipo_P As String
        Get
            Return _Tipo_P
        End Get
        Set(value As String)
            _Tipo_P = value
        End Set
    End Property

#End Region

#End Region

#Region "AUTOS"

#Region "DATAMEMBERS"
    Private _Camara_Fri As String
    Private _Capacidad As String
    Private _Foto_Autos As String
    Private _Gps_Autos As String
    Private _Marca As String
    Private _Modelo As String
    Private _Motor As String
    Private _Placas As String
    Private _Seguro_Autos As String
    Private _Ubi_Autos As String
    Private _Verif As String
    Private _Year_Autos As String
#End Region

#Region "PROPIEDADES"

    Public Property Camara_Fri As String
        Get
            Return _Camara_Fri
        End Get
        Set(value As String)
            _Camara_Fri = value
        End Set
    End Property

    Public Property Capacidad As String
        Get
            Return _Capacidad
        End Get
        Set(value As String)
            _Capacidad = value
        End Set
    End Property

    Public Property Foto_Autos As String
        Get
            Return _Foto_Autos
        End Get
        Set(value As String)
            _Foto_Autos = value
        End Set
    End Property

    Public Property Gps_Autos As String
        Get
            Return _Gps_Autos
        End Get
        Set(value As String)
            _Gps_Autos = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _Modelo
        End Get
        Set(value As String)
            _Modelo = value
        End Set
    End Property

    Public Property Motor As String
        Get
            Return _Motor
        End Get
        Set(value As String)
            _Motor = value
        End Set
    End Property

    Public Property Placas As String
        Get
            Return _Placas
        End Get
        Set(value As String)
            _Placas = value
        End Set
    End Property

    Public Property Seguro_Autos As String
        Get
            Return _Seguro_Autos
        End Get
        Set(value As String)
            _Seguro_Autos = value
        End Set
    End Property

    Public Property Ubi_Autos As String
        Get
            Return _Ubi_Autos
        End Get
        Set(value As String)
            _Ubi_Autos = value
        End Set
    End Property

    Public Property Verif As String
        Get
            Return _Verif
        End Get
        Set(value As String)
            _Verif = value
        End Set
    End Property

    Public Property Year_Autos As String
        Get
            Return _Year_Autos
        End Get
        Set(value As String)
            _Year_Autos = value
        End Set
    End Property

#End Region

#End Region

#Region "MAQUINARIA"

#Region "DATAMEMBERS"

    Private _Area_af As String
    Private _Catego_af As String
    Private _Desc_af As String
    Private _Id_af As String
    Private _Marca_af As String
    Private _Modelo_af As String
    Private _Pic_af As String
    Private _Precio_af As String
    Private _Serie_af As String
    Private _YearA_af As String
    Private _Year_af As String

#End Region

#Region "PROPIEDADES"

    Public Property Area_af As String
        Get
            Return _Area_af
        End Get
        Set(value As String)
            _Area_af = value
        End Set
    End Property

    Public Property Catego_af As String
        Get
            Return _Catego_af
        End Get
        Set(value As String)
            _Catego_af = value
        End Set
    End Property

    Public Property Desc_af As String
        Get
            Return _Desc_af
        End Get
        Set(value As String)
            _Desc_af = value
        End Set
    End Property

    Public Property Id_af As String
        Get
            Return _Id_af
        End Get
        Set(value As String)
            _Id_af = value
        End Set
    End Property

    Public Property Marca_af As String
        Get
            Return _Marca_af
        End Get
        Set(value As String)
            _Marca_af = value
        End Set
    End Property

    Public Property Modelo_af As String
        Get
            Return _Modelo_af
        End Get
        Set(value As String)
            _Modelo_af = value
        End Set
    End Property

    Public Property Pic_af As String
        Get
            Return _Pic_af
        End Get
        Set(value As String)
            _Pic_af = value
        End Set
    End Property

    Public Property Precio_af As String
        Get
            Return _Precio_af
        End Get
        Set(value As String)
            _Precio_af = value
        End Set
    End Property

    Public Property Serie_af As String
        Get
            Return _Serie_af
        End Get
        Set(value As String)
            _Serie_af = value
        End Set
    End Property

    Public Property YearA_af As String
        Get
            Return _YearA_af
        End Get
        Set(value As String)
            _YearA_af = value
        End Set
    End Property

    Public Property Year_af As String
        Get
            Return _Year_af
        End Get
        Set(value As String)
            _Year_af = value
        End Set
    End Property

#End Region

#End Region

#Region "MANTOMAQ"

#Region "DATAMEMBERS"

    Private _Apll_mtom As String
    Private _AreaAf_mtom As String
    Private _Cantidad_mtom As String
    Private _DescAf_mtom As String
    Private _FechaE_mtom As String
    Private _FechaF_mtom As String
    Private _FotoAf_mtom As String
    Private _HoraE_mtom As String
    Private _HoraF_mtom As String
    Private _IdAf_mtom As String
    Private _Id_mtom As String
    Private _MarcaAf_mtom As String
    Private _ModeloAf_mtom As String
    Private _Nombre_mtom As String
    Private _Recomen_mtom As String
    Private _SerAf_mtom As String
    Private _Tareas_mtom As String
    Private _TokenUsr_mtom As String
    Private _DescFalla_mtom As String
    Private _NoParte_mtom As String

#End Region

#Region "PROPIEDADES"

    Public Property Apll_mtom As String
        Get
            Return _Apll_mtom
        End Get
        Set(value As String)
            _Apll_mtom = value
        End Set
    End Property

    Public Property AreaAf_mtom As String
        Get
            Return _AreaAf_mtom
        End Get
        Set(value As String)
            _AreaAf_mtom = value
        End Set
    End Property

    Public Property Cantidad_mtom As String
        Get
            Return _Cantidad_mtom
        End Get
        Set(value As String)
            _Cantidad_mtom = value
        End Set
    End Property

    Public Property DescAf_mtom As String
        Get
            Return _DescAf_mtom
        End Get
        Set(value As String)
            _DescAf_mtom = value
        End Set
    End Property

    Public Property FechaE_mtom As String
        Get
            Return _FechaE_mtom
        End Get
        Set(value As String)
            _FechaE_mtom = value
        End Set
    End Property

    Public Property FechaF_mtom As String
        Get
            Return _FechaF_mtom
        End Get
        Set(value As String)
            _FechaF_mtom = value
        End Set
    End Property

    Public Property FotoAf_mtom As String
        Get
            Return _FotoAf_mtom
        End Get
        Set(value As String)
            _FotoAf_mtom = value
        End Set
    End Property

    Public Property HoraE_mtom As String
        Get
            Return _HoraE_mtom
        End Get
        Set(value As String)
            _HoraE_mtom = value
        End Set
    End Property

    Public Property HoraF_mtom As String
        Get
            Return _HoraF_mtom
        End Get
        Set(value As String)
            _HoraF_mtom = value
        End Set
    End Property

    Public Property IdAf_mtom As String
        Get
            Return _IdAf_mtom
        End Get
        Set(value As String)
            _IdAf_mtom = value
        End Set
    End Property

    Public Property Id_mtom As String
        Get
            Return _Id_mtom
        End Get
        Set(value As String)
            _Id_mtom = value
        End Set
    End Property

    Public Property MarcaAf_mtom As String
        Get
            Return _MarcaAf_mtom
        End Get
        Set(value As String)
            _MarcaAf_mtom = value
        End Set
    End Property

    Public Property ModeloAf_mtom As String
        Get
            Return _ModeloAf_mtom
        End Get
        Set(value As String)
            _ModeloAf_mtom = value
        End Set
    End Property

    Public Property Nombre_mtom As String
        Get
            Return _Nombre_mtom
        End Get
        Set(value As String)
            _Nombre_mtom = value
        End Set
    End Property

    Public Property Recomen_mtom As String
        Get
            Return _Recomen_mtom
        End Get
        Set(value As String)
            _Recomen_mtom = value
        End Set
    End Property

    Public Property SerAf_mtom As String
        Get
            Return _SerAf_mtom
        End Get
        Set(value As String)
            _SerAf_mtom = value
        End Set
    End Property

    Public Property Tareas_mtom As String
        Get
            Return _Tareas_mtom
        End Get
        Set(value As String)
            _Tareas_mtom = value
        End Set
    End Property

    Public Property TokenUsr_mtom As String
        Get
            Return _TokenUsr_mtom
        End Get
        Set(value As String)
            _TokenUsr_mtom = value
        End Set
    End Property

    Public Property DescFalla_mtom As String
        Get
            Return _DescFalla_mtom
        End Get
        Set(value As String)
            _DescFalla_mtom = value
        End Set
    End Property

    Public Property NoParte_mtom As String
        Get
            Return _NoParte_mtom
        End Get
        Set(value As String)
            _NoParte_mtom = value
        End Set
    End Property

#End Region

#End Region

#Region "MANTOAUTO"

#Region "DATAMEMBERS"

    Private _Id_mto As String
    Private _Placa_mto As String
    Private _Marca_mto As String
    Private _Modelo_mto As String
    Private _Year_mto As String
    Private _Rfc_mto As String
    Private _Nom_mto As String
    Private _Tel_mto As String
    Private _Mail_mto As String
    Private _Fac_mto As String
    Private _Monto_mto As String
    Private _Fecha_mto As String
    Private _Servicio_mto As String
    Private _Llantas_mto As String
    Private _Bateria_mto As String
    Private _Bujias_mto As String
    Private _SerElec_mto As String
    Private _Motor_mto As String
    Private _Radiador_mto As String
    Private _Inyeccion_mto As String
    Private _Frenos_mto As String
    Private _Frio_mto As String
    Private _Desc_mto As String

#End Region

#Region "PROPIEDADES"

    Public Property Id_mto As String
        Get
            Return _Id_mto
        End Get
        Set(value As String)
            _Id_mto = value
        End Set
    End Property

    Public Property Placa_mto As String
        Get
            Return _Placa_mto
        End Get
        Set(value As String)
            _Placa_mto = value
        End Set
    End Property

    Public Property Marca_mto As String
        Get
            Return _Marca_mto
        End Get
        Set(value As String)
            _Marca_mto = value
        End Set
    End Property

    Public Property Modelo_mto As String
        Get
            Return _Modelo_mto
        End Get
        Set(value As String)
            _Modelo_mto = value
        End Set
    End Property

    Public Property Year_mto As String
        Get
            Return _Year_mto
        End Get
        Set(value As String)
            _Year_mto = value
        End Set
    End Property

    Public Property Rfc_mto As String
        Get
            Return _Rfc_mto
        End Get
        Set(value As String)
            _Rfc_mto = value
        End Set
    End Property

    Public Property Nom_mto As String
        Get
            Return _Nom_mto
        End Get
        Set(value As String)
            _Nom_mto = value
        End Set
    End Property

    Public Property Tel_mto As String
        Get
            Return _Tel_mto
        End Get
        Set(value As String)
            _Tel_mto = value
        End Set
    End Property

    Public Property Mail_mto As String
        Get
            Return _Mail_mto
        End Get
        Set(value As String)
            _Mail_mto = value
        End Set
    End Property

    Public Property Fac_mto As String
        Get
            Return _Fac_mto
        End Get
        Set(value As String)
            _Fac_mto = value
        End Set
    End Property

    Public Property Monto_mto As String
        Get
            Return _Monto_mto
        End Get
        Set(value As String)
            _Monto_mto = value
        End Set
    End Property

    Public Property Fecha_mto As String
        Get
            Return _Fecha_mto
        End Get
        Set(value As String)
            _Fecha_mto = value
        End Set
    End Property

    Public Property Servicio_mto As String
        Get
            Return _Servicio_mto
        End Get
        Set(value As String)
            _Servicio_mto = value
        End Set
    End Property

    Public Property Llantas_mto As String
        Get
            Return _Llantas_mto
        End Get
        Set(value As String)
            _Llantas_mto = value
        End Set
    End Property

    Public Property Bateria_mto As String
        Get
            Return _Bateria_mto
        End Get
        Set(value As String)
            _Bateria_mto = value
        End Set
    End Property

    Public Property Bujias_mto As String
        Get
            Return _Bujias_mto
        End Get
        Set(value As String)
            _Bujias_mto = value
        End Set
    End Property

    Public Property SerElec_mto As String
        Get
            Return _SerElec_mto
        End Get
        Set(value As String)
            _SerElec_mto = value
        End Set
    End Property

    Public Property Motor_mto As String
        Get
            Return _Motor_mto
        End Get
        Set(value As String)
            _Motor_mto = value
        End Set
    End Property

    Public Property Radiador_mto As String
        Get
            Return _Radiador_mto
        End Get
        Set(value As String)
            _Radiador_mto = value
        End Set
    End Property

    Public Property Inyeccion_mto As String
        Get
            Return _Inyeccion_mto
        End Get
        Set(value As String)
            _Inyeccion_mto = value
        End Set
    End Property

    Public Property Frenos_mto As String
        Get
            Return _Frenos_mto
        End Get
        Set(value As String)
            _Frenos_mto = value
        End Set
    End Property

    Public Property Frio_mto As String
        Get
            Return _Frio_mto
        End Get
        Set(value As String)
            _Frio_mto = value
        End Set
    End Property

    Public Property Desc_mto As String
        Get
            Return _Desc_mto
        End Get
        Set(value As String)
            _Desc_mto = value
        End Set
    End Property

#End Region

#End Region

#Region "INCIDENCIAS"

#Region "DATAMEMBERS"

    Private _Foto_Inci As String
    Private _Serie_Inci As String
    Private _Desc_Inci As String
    Private _Cont_Inci As String

#End Region

#Region "PROPIEDADES"

    Public Property Foto_Inci As String
        Get
            Return _Foto_Inci
        End Get
        Set(value As String)
            _Foto_Inci = value
        End Set
    End Property

    Public Property Serie_Inci As String
        Get
            Return _Serie_Inci
        End Get
        Set(value As String)
            _Serie_Inci = value
        End Set
    End Property

    Public Property Desc_Inci As String
        Get
            Return _Desc_Inci
        End Get
        Set(value As String)
            _Desc_Inci = value
        End Set
    End Property

    Public Property Cont_Inci As String
        Get
            Return _Cont_Inci
        End Get
        Set(value As String)
            _Cont_Inci = value
        End Set
    End Property

#End Region

#End Region

#Region "OPCIONES DE MANTENIMIENTO Y REFACCIONES"

#Region "DATAMEMBERS"

    Private _FallasMaq As String
    Private _RefaMaq As String

#End Region

#Region "PROPIEDADES"

    Public Property FallasMaq As String
        Get
            Return _FallasMaq
        End Get
        Set(value As String)
            _FallasMaq = value
        End Set
    End Property

    Public Property RefaMaq As String
        Get
            Return _RefaMaq
        End Get
        Set(value As String)
            _RefaMaq = value
        End Set
    End Property

#End Region

#End Region

End Class

Public Class Consulta

    'En esta región se concentran las consultas así como también las variables necesarias
    'para enviar los resultados a los cbo y datagrid necesarios.
    'La conexión a firebase se realiza desde aquí.

#Region "DATAMEMBERS"
    'Firebase
    Dim res As FirebaseResponse
    Dim dataDic As Dictionary(Of String, Datos)
    Dim inciDic As Dictionary(Of String, Datos)
    Dim tokenUsr As String
    Dim unidadUsr As String
    Dim dataMaq As Datos                'Datos de la maquinaria en INVENTARIO_AF
    Dim dataRpoMaq As Datos             'Reportes de mantenimiento para maquinaria en MANTOMAQ
    Dim dataRpoAuto As Datos            'Reportes de mantenimiento para vehículos en MANTOAUTO
    Dim dataAut As Datos                'Datos de un vehículo en AUTOS
    Dim dataPrv As Datos                'Datos de un proveedor en PROVEEDORES
    Dim datosInci As Datos              'Diccionario para guardar los reportes de incidencias y contarlos.
    Dim resFallas As Datos              'Datos de la tabla OPTMTOMAQ
    Dim resRefas As Datos               'Datos de la tabla OPTMTOMAQ

    'Referente a los cbo
    Public cboUsrDS As New DataSet      'ComboBox Only USUARIOS
    Public cboMaqDS As New DataSet      'ComboBox Only INVENTARIO_AF
    Public cboMtoMaqDs As New DataSet   'Combobox Only MANTOMAQ
    Public cboOptFallDs As New DataSet  'Combobox Only OPTMTOMAQ/Fallas
    Public cboOptRefaDs As New DataSet  'Combobox Only OPTMTOMAQ/Refas
    Public cboPlacasDS As New DataSet   'Combobox Only AUTOS
    Public cboRfcProvDS As New DataSet  'Combobox Only PROVEEDORES
    Public cboNomProvDS As New DataSet  'Combobox Only PROVEEDORES
    Public cboMtoAutoDs As New DataSet  'Combobox Only MANTOMAQ

    'Referente a los dgv
    Public dgvMaqRepDS As New DataSet     'Datagrid Only MANTOMAQ
    Public dgvMaqRepSerDS As New DataSet  'Datagrid Only MANTOMAQ
    Public dgvMaqRepInciDS As New DataSet 'Datagrid Only MANTOMAQ
    Public dgvAutoRepNoDS As New DataSet  'Datagrid Only MANTOAUTO

#End Region

#Region "USUARIOS"

    ''' <summary>
    ''' Se encarga de obtener el nombre y apellido del usuario y pasarlo a una tabla
    ''' </summary>
    Public Sub getNomApllUsr()

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboUsrDS.Tables.Add("USR")
        cboUsrDS.Tables("USR").Columns.Add("NomApll", GetType(String))

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("USUARIOS/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Nombre) Then
                Else
                    cboUsrDS.Tables("USR").Rows.Add(item.Value.Nombre + "," + item.Value.Apellidos)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Consulta el nodo USUARIOS/
    ''' Recibe el resultado como un diccionario
    ''' Recorre el diccionario en búsqueda del nombre y apellidos recibidos como parámetros
    ''' Cuando valida el resultado captura el token de usuario
    ''' Devuelve el token como cadena
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns>token de usuario como String</returns>
    Public Function getUsrData(ByVal data As Datos) As String

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("USUARIOS/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Nombre) Then

                    'Validamos que el nombre y apellidos correspondan a los recibidos como parámetro
                ElseIf (data.Nombre = item.Value.Nombre And data.Apellidos = item.Value.Apellidos) Then

                    'Captura del token de usuario
                    tokenUsr = item.Value.Token

                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Return
        Return tokenUsr

    End Function

    ''' <summary>
    ''' Consulta el nodo USUARIOS/
    ''' Recibe el resultado como un diccionario
    ''' Recorre el diccionario en búsqueda del nombre y apellidos recibidos como parámetros
    ''' Cuando valida el resultado captura el departamento del usuario
    ''' Devuelve el departamento como cadena
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns>unidad / departamento del usuario como String</returns>
    Public Function getUsrUnidad(ByVal data As Datos) As String

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("USUARIOS/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Nombre) Then

                    'Validamos que el nombre y apellidos correspondan a los recibidos como parámetro
                ElseIf (data.Nombre = item.Value.Nombre And data.Apellidos = item.Value.Apellidos) Then

                    'Captura del token de usuario
                    unidadUsr = item.Value.Unidad

                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Return
        Return unidadUsr

    End Function

#End Region

#Region "MAQUINARIA"

    ''' <summary>
    ''' Se encarga de obtener el número de serie de las maquinas en el nodo INVENTARIO_AF para
    ''' pasarlo a una tabla.
    ''' </summary>
    Public Sub getSerialMaq()

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboMaqDS.Tables.Add("MAQ")
        cboMaqDS.Tables("MAQ").Columns.Add("Serie", GetType(String))

        'Manejo de excepciones
        Try
            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("INVENTARIO_AF/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Id_af) Then
                Else
                    cboMaqDS.Tables("MAQ").Rows.Add(item.Value.Id_af)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Consulta el nodo INVENTARIO_AF/
    ''' Recibe el resultado como Datos
    ''' Devuelve un objeto del tipo datos
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function getMaqData(ByVal data As Datos) As Datos

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("INVENTARIO_AF/" + data.Id_af)

            'Resultado
            dataMaq = res.ResultAs(Of Datos)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado
        Return dataMaq

    End Function

#End Region

#Region "AUTOS"

    ''' <summary>
    ''' Se encarga de obtener el número de placas de los autos en el nodo AUTOS
    ''' para llenar el cbo necesario.
    ''' </summary>
    Public Sub getPlacas()

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboPlacasDS.Tables.Add("PLACAS")
        cboPlacasDS.Tables("PLACAS").Columns.Add("Placas", GetType(String))

        'Manejo de excepciones
        Try
            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("AUTOS/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Placas) Then
                Else
                    cboPlacasDS.Tables("PLACAS").Rows.Add(item.Value.Placas)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Consulta el nodo AUTOS/
    ''' Recibe el resultado como Datos
    ''' Devuelve un objeto del tipo datos
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function getAutosData(ByVal data As Datos) As Datos

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("AUTOS/" + data.Placas)

            'Resultado
            dataAut = res.ResultAs(Of Datos)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado
        Return dataAut

    End Function

#End Region

#Region "PROVEEDORES"

    ''' <summary>
    ''' Se encarga de obtener el rfc del proveedor del nodo PROVEEDORES y pasarlo
    ''' al cbo necesario.
    ''' </summary>
    Public Sub getRfcProv()

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboRfcProvDS.Tables.Add("RFC")
        cboRfcProvDS.Tables("RFC").Columns.Add("Rfc_P", GetType(String))

        'Manejo de excepciones
        Try
            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("PROVEEDORES/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Rfc_P) Then
                Else
                    cboRfcProvDS.Tables("RFC").Rows.Add(item.Value.Rfc_P)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Se encarga de obtener el nombre del proveedor del nodo PROVEEDORES y pasarlo
    ''' al cbo necesario.
    ''' </summary>
    Public Sub getNomProv()

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboNomProvDS.Tables.Add("NOMPROV")
        cboNomProvDS.Tables("NOMPROV").Columns.Add("Nom_P", GetType(String))

        'Manejo de excepciones
        Try
            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("PROVEEDORES/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Nom_P) Then
                Else
                    cboNomProvDS.Tables("NOMPROV").Rows.Add(item.Value.Nom_P)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Consulta el nodo PROVEEDORES/
    ''' Recibe el resultado como Datos
    ''' Devuelve un objeto del tipo datos
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function getProvData(ByVal data As Datos) As Datos

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("PROVEEDORES/" + data.Rfc_P)

            'Resultado
            dataPrv = res.ResultAs(Of Datos)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado
        Return dataPrv

    End Function

    ''' <summary>
    ''' Consulta el nodo PROVEEDORES/
    ''' Recibe el resultado como Datos
    ''' Devuelve un objeto del tipo datos
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function getProvDataNom(ByVal data As Datos) As Datos

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("PROVEEDORES/" + data.Nom_P)

            'Resultado
            dataPrv = res.ResultAs(Of Datos)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado
        Return dataPrv

    End Function

#End Region

#Region "MANTOMAQ"

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Recibe la respuesta como diccionario y la guarda en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    Public Sub getMtoMaqRepor()

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboMtoMaqDs.Tables.Add("MTOMAQ")
        cboMtoMaqDs.Tables("MTOMAQ").Columns.Add("Reporte", GetType(String))

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("MANTOMAQ/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Id_mtom) Then
                Else
                    cboMtoMaqDs.Tables("MTOMAQ").Rows.Add(item.Value.Id_mtom)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Recibe la respuesta como diccionario y valida que se encuentre en el rango de periodo recibido como parámetro
    ''' Si es así guarda los datos en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    Public Sub getMaqRepFromPeriod(ByVal inicio As Date, ByVal fin As Date)

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode MAQREP
        dgvMaqRepDS.Tables.Add("MAQREP")
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("FOTO", GetType(Byte()))
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("SERIE", GetType(String))
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("DESCRIPCION", GetType(String))
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("FECHAFALLA", GetType(String))
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("RESPONSABLE", GetType(String))
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("RECURSOS", GetType(String))
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("ACCIONES", GetType(String))
        dgvMaqRepDS.Tables("MAQREP").Columns.Add("RECOMENDACIONES", GetType(String))

        'Excepción
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("MANTOMAQ/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic

                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Id_mtom) Then

                    'Validamos el rango de periódo
                ElseIf (item.Value.FechaF_mtom >= inicio And item.Value.FechaF_mtom <= fin) Then

                    'Pasamos el dato a una variable local
                    Dim p As String = item.Value.FotoAf_mtom

                    ' Convert Base64 String to byte[]
                    Dim imageBytes As Byte() = Convert.FromBase64String(p)

                    'Agregamos el arreglo byte para la foto y los demás datos
                    dgvMaqRepDS.Tables("MAQREP").Rows.Add(imageBytes, item.Value.SerAf_mtom, item.Value.DescAf_mtom, item.Value.FechaF_mtom + " " + item.Value.HoraF_mtom, item.Value.Nombre_mtom + " " + item.Value.Apll_mtom, item.Value.Cantidad_mtom, item.Value.Tareas_mtom, item.Value.Recomen_mtom)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Recibe la respuesta como diccionario y valida que se concuerde con el serial recibido como parámetro
    ''' Si es así guarda los datos en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    ''' <param name="dat"></param>
    Public Sub getMaqRepFromSerial(ByVal dat As Datos, ByVal inicio As Date, ByVal fin As Date)

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode MAQREP
        dgvMaqRepSerDS.Tables.Add("MAQREPSER")
        dgvMaqRepSerDS.Tables("MAQREPSER").Columns.Add("FOTO", GetType(Byte()))
        dgvMaqRepSerDS.Tables("MAQREPSER").Columns.Add("SERIE", GetType(String))
        dgvMaqRepSerDS.Tables("MAQREPSER").Columns.Add("DESCRIPCION", GetType(String))
        dgvMaqRepSerDS.Tables("MAQREPSER").Columns.Add("INCIDENCIAS", GetType(Integer))

        'Locales
        Dim incidencias As Integer = 0
        Dim p As String = ""
        Dim imageBytes As Byte()
        Dim serial As String = ""
        Dim desc As String = ""

        'Excepción
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("MANTOMAQ/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic

                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Id_mtom) Then

                    'Validamos el serial y el rango de periódo
                ElseIf (dat.IdAf_mtom = item.Value.IdAf_mtom And item.Value.FechaF_mtom >= inicio And item.Value.FechaF_mtom <= fin) Then

                    'Pasamos el dato a una variable local
                    p = item.Value.FotoAf_mtom

                    ' Convert Base64 String to byte[]
                    imageBytes = Convert.FromBase64String(p)

                    'Serial
                    serial = item.Value.SerAf_mtom

                    'Descripción
                    desc = item.Value.DescAf_mtom

                    'Incidencias
                    incidencias += 1

                End If

            Next

            'Agregamos el arreglo byte para la foto y los demás datos
            dgvMaqRepSerDS.Tables("MAQREPSER").Rows.Add(imageBytes, serial, desc, incidencias)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Recibe la respuesta como diccionario y valida que se concuerde con el serial recibido como parámetro
    ''' Si es así guarda los datos en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    Public Sub GetMaqRepInci(ByVal inicio As Date, ByVal fin As Date)

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode MAQREP
        dgvMaqRepInciDS.Tables.Add("MAQREPINCI")
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("FOTO", GetType(Byte()))
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("SERIE", GetType(String))
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("DESCRIPCION", GetType(String))
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("INCIDENCIAS", GetType(Integer))

        'Locales
        Dim incidencias As Integer = 0
        Dim photo As String = ""
        Dim imageBytes As Byte()
        Dim serial As String = ""
        Dim desc As String = ""

        'Excepción
        Try

            'Firebase conection
            con.Con_Global()

            'Rutina para recorrer los 20 números internos, este método tendrá que ser corregido
            For i = 1 To 20

                'Query Firebase
                res = con.firebase.Get("MANTOMAQ/")

                'Diccionario para almacenar las respuestas
                dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

                'Rutina para recorrer los elementos
                For Each item In dataDic

                    'Obtenemos el número de control interno
                    Dim interno() As String = (item.Value.Id_mtom).Split("-")
                    Dim internoInt As Integer = Integer.Parse(interno(0))

                    'Validamos que no sea null
                    If String.IsNullOrEmpty(item.Value.Id_mtom) Then

                        'Validamos el serial y el rango de periódo
                    ElseIf (item.Value.FechaF_mtom >= inicio And item.Value.FechaF_mtom <= fin And internoInt = i) Then

                        'Pasamos el dato a una variable local
                        photo = item.Value.FotoAf_mtom

                        ' Convert Base64 String to byte[]
                        imageBytes = Convert.FromBase64String(photo)

                        'Serial
                        serial = item.Value.SerAf_mtom

                        'Descripción
                        desc = item.Value.DescAf_mtom

                        'Incidencias
                        incidencias += 1

                    End If

                Next

                'Valida que existan incidencias
                If (incidencias > 0) Then

                    'Agregamos el arreglo byte para la foto y los demás datos
                    dgvMaqRepInciDS.Tables("MAQREPINCI").Rows.Add(imageBytes, serial, desc, incidencias)

                End If

                'Reset de incidencias
                incidencias = 0

            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo MANTOMAQ/
    ''' Recibe la respuesta como diccionario y valida que se concuerde con el serial recibido como parámetro
    ''' Si es así guarda los datos en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    ''' <param name="inicio"></param>
    ''' <param name="fin"></param>
    Public Sub ReporMaqInci(ByVal inicio As Date, ByVal fin As Date)

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode MAQREP
        dgvMaqRepInciDS.Tables.Add("MAQREPINCI")
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("FOTO", GetType(Byte()))
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("SERIE", GetType(String))
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("DESCRIPCION", GetType(String))
        dgvMaqRepInciDS.Tables("MAQREPINCI").Columns.Add("INCIDENCIAS", GetType(Integer))

        'Locales
        Dim incidencias As Integer = 0
        Dim photo As String = ""
        Dim imageBytes As Byte()
        Dim serial As String = ""
        Dim desc As String = ""

        'Instance del diccionario para incidencias necesario para agregar datos
        inciDic = New Dictionary(Of String, Datos)


        'Excepción
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("MANTOMAQ/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer el resultado
            For Each item In dataDic

                'Captura del número de control interno
                Dim interno() As String = (item.Value.Id_mtom).Split("-")
                Dim internoStr As String = interno(0)

                'Captura de los datos necesarios
                photo = item.Value.FotoAf_mtom
                serial = item.Value.SerAf_mtom
                desc = item.Value.DescAf_mtom

                'Validamos el periódo recibido
                If (item.Value.FechaF_mtom >= inicio And item.Value.FechaF_mtom <= fin) Then

                    'Instance para el objeto de la clase datos, uno por cada item. Necesario para agregar datos
                    datosInci = New Datos

                    'Validamos que no exitsta la llave en el diccionario incidencias
                    If inciDic.ContainsKey(internoStr) Then

                        'Actualizamos el contador de incidencias
                        incidencias = Integer.Parse(inciDic.Item(internoStr).Cont_Inci)
                        incidencias += 1
                        inciDic.Item(internoStr).Cont_Inci = incidencias.ToString

                    Else

                        'Agregamos los datos al diccionario
                        datosInci.Foto_Inci = photo
                        datosInci.Serie_Inci = serial
                        datosInci.Desc_Inci = desc
                        datosInci.Cont_Inci = "1"
                        inciDic.Add(internoStr, datosInci)

                    End If

                End If

            Next

            'Rutina para recorrer el diccionario de incidencias
            Dim kvp As KeyValuePair(Of String, Datos)

            For Each kvp In inciDic

                ' Convert Base64 String to byte[]
                imageBytes = Convert.FromBase64String(kvp.Value.Foto_Inci)

                'Agregamos el arreglo byte para la foto y los demás datos
                dgvMaqRepInciDS.Tables("MAQREPINCI").Rows.Add(imageBytes, kvp.Value.Serie_Inci, kvp.Value.Desc_Inci, CInt(kvp.Value.Cont_Inci))

            Next


        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Consulta el nodo MANTOMAQ/Id_mtom
    ''' Recibe el resultado como Datos
    ''' Devuelve un objeto del tipo datos
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function getMtoMaq(ByVal data As Datos) As Datos

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("MANTOMAQ/" + data.Id_mtom)

            'Resultado
            dataRpoMaq = res.ResultAs(Of Datos)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado
        Return dataRpoMaq

    End Function

#End Region

#Region "MANTOAUTO"

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo MANTOAUTO/
    ''' Recibe la respuesta como diccionario y la guarda en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    Public Sub getMtoAutoRepor()

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboMtoAutoDs.Tables.Add("MTOAUTO")
        cboMtoAutoDs.Tables("MTOAUTO").Columns.Add("Reporte", GetType(String))

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("MANTOAUTO/")

            'Diccionario para almacenar las respuestas
            dataDic = res.ResultAs(Of Dictionary(Of String, Datos))

            'Rutina para recorrer los elementos
            For Each item In dataDic
                'Validamos que no sea null
                If String.IsNullOrEmpty(item.Value.Id_mto) Then
                Else
                    cboMtoAutoDs.Tables("MTOAUTO").Rows.Add(item.Value.Id_mto)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo MANTOAUTO/
    ''' Recibe la respuesta como diccionario y valida que se concuerde con el serial recibido como parámetro
    ''' Si es así guarda los datos en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    Public Sub getAutoRep(ByVal dat As Datos)

        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode MAQREP
        dgvAutoRepNoDS.Tables.Add("AUTOREP")
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("MARCA", GetType(String))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("MODELO", GetType(String))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("PLACA", GetType(String))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("FECHA", GetType(String))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("PROVEEDOR", GetType(String))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("No. FACTURA", GetType(String))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("MONTO", GetType(Decimal))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("BATERIA", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("BUJIAS", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("FRENOS", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("CAM. FRIO", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("INYECCION", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("LLANTAS", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("MOTOR", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("RADIADOR", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("ELECTRICO", GetType(Boolean))
        dgvAutoRepNoDS.Tables("AUTOREP").Columns.Add("SERVICIO", GetType(Boolean))

        'Locales

        'Excepción
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("MANTOAUTO/" + dat.Id_mto)

            'Diccionario para almacenar las respuestas
            dataAut = res.ResultAs(Of Datos)

            'Captura
            Dim marca As String = dataAut.Marca_mto
            Dim modelo As String = dataAut.Modelo_mto
            Dim placa As String = dataAut.Placa_mto
            Dim fecha As String = dataAut.Fecha_mto
            Dim prov As String = dataAut.Nom_mto
            Dim fact As String = dataAut.Fac_mto
            Dim montoStr As String = dataAut.Monto_mto
            montoStr = montoStr.Replace("$", "")
            montoStr = montoStr.Replace(",", "")
            Dim monto As Decimal = Decimal.Parse(montoStr)
            Dim bat As Boolean = Boolean.Parse(dataAut.Bateria_mto)
            Dim buj As Boolean = Boolean.Parse(dataAut.Bujias_mto)
            Dim fre As Boolean = Boolean.Parse(dataAut.Frenos_mto)
            Dim fri As Boolean = Boolean.Parse(dataAut.Frio_mto)
            Dim gas As Boolean = Boolean.Parse(dataAut.Inyeccion_mto)
            Dim lln As Boolean = Boolean.Parse(dataAut.Llantas_mto)
            Dim mtr As Boolean = Boolean.Parse(dataAut.Motor_mto)
            Dim rad As Boolean = Boolean.Parse(dataAut.Radiador_mto)
            Dim ele As Boolean = Boolean.Parse(dataAut.SerElec_mto)
            Dim ser As Boolean = Boolean.Parse(dataAut.Servicio_mto)

            'Agregamos el arreglo byte para la foto y los demás datos
            dgvAutoRepNoDS.Tables("AUTOREP").Rows.Add(marca, modelo, placa, fecha, prov, fact, monto, bat, buj, fre, fri, gas, lln, mtr, rad, ele, ser)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Consulta el nodo MANTOAUTO/Id_mto
    ''' Recibe el resultado como Datos
    ''' Devuelve un objeto del tipo datos
    ''' </summary>
    ''' <param name="data"></param>
    ''' <returns></returns>
    Public Function getMtoAuto(ByVal data As Datos) As Datos

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("MANTOAUTO/" + data.Id_mto)

            'Resultado
            dataRpoAuto = res.ResultAs(Of Datos)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado
        Return dataRpoAuto

    End Function

#End Region

#Region "OPCIONES FALLAS Y REFACCIONES"

    ''' <summary>
    ''' Crea una tabla dentro de un dataset
    ''' Se encarga de consultar el nodo OPTMTOMAQ/Fallas
    ''' Recibe la respuesta como diccionario y la guarda en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' Se encarga de consultar el nodo OPTMTOMAQ/Refas
    ''' Recibe la respuesta como diccionario y la guarda en un dataset
    ''' El dataset es accesible gracias a DATAMEMBERS
    ''' </summary>
    Public Sub FillFallasRefas()

        'Locales
        Dim arrFallas() As String
        Dim arrRefas() As String

        'Conexión Firebase
        Dim con As New Conexion
        Dim con2 As New Conexion

        'Init Tabla, hardcode FALLAS y REFAS
        cboOptFallDs.Tables.Add("FALLAS")
        cboOptFallDs.Tables("FALLAS").Columns.Add("FallasMaq", GetType(String))
        cboOptRefaDs.Tables.Add("REFAS")
        cboOptRefaDs.Tables("REFAS").Columns.Add("RefaMaq", GetType(String))

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Get("OPTMTOMAQ/Fallas")

            'Resultado
            resFallas = res.ResultAs(Of Datos)

            'Captura de la lista de fallas
            Dim strFallas As String = resFallas.FallasMaq
            arrFallas = strFallas.Split(",")

            'Rutina para recorrer el arreglo
            For i = 0 To arrFallas.Length - 1

                'Agregamos los items separados en el Data Set
                cboOptFallDs.Tables("FALLAS").Rows.Add(arrFallas(i))

            Next

            'Firebase conection
            con2.Con_Global()

            'Query Firebase
            res = con2.firebase.Get("OPTMTOMAQ/Refas")

            'Resultado
            resRefas = res.ResultAs(Of Datos)

            'Captura de la lista de fallas
            Dim strRefas As String = resRefas.RefaMaq
            arrRefas = strRefas.Split(",")

            'Rutina para recorrer el arreglo
            For i = 0 To arrRefas.Length - 1

                'Agregamos los items separados en el Data Set
                cboOptRefaDs.Tables("REFAS").Rows.Add(arrRefas(i))

            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Consulta el nodo OPTMTOMAQ/
    ''' Recibe el resultado como Datos
    ''' Evalúa si existe la falla comparando con el parámetro recibido
    ''' Cambia el estado de la bandera y la devuelve.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetFallas(ByVal falla As String) As Boolean
        'Locales
        Dim estado As Boolean = False
        Dim arrFallas() As String

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("OPTMTOMAQ/Fallas")

            'Resultado
            resFallas = res.ResultAs(Of Datos)

            'Captura de la lista de fallas
            Dim strFallas As String = resFallas.FallasMaq
            arrFallas = strFallas.Split(",")

            'Rutina para recorrer el arreglo
            For i = 0 To arrFallas.Length - 1

                'Evaluación del parámetro recibido contra el contenido del arreglo
                If (falla = arrFallas(i)) Then

                    'Cambio del estado de la bandera y salida de la rutina
                    estado = True
                    Exit For

                End If

            Next


        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado de la evaluación
        Return estado

    End Function

    ''' <summary>
    ''' Consulta el nodo OPTMTOMAQ/Fallas
    ''' Guarda el resultado como una cadena
    ''' Devuelve la cadena
    ''' </summary>
    ''' <returns></returns>
    Public Function GetListaFallas() As String

        'Locales
        Dim lista As String = ""

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("OPTMTOMAQ/Fallas")

            'Resultado
            resFallas = res.ResultAs(Of Datos)

            'Captura de la lista de fallas
            lista = resFallas.FallasMaq

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado de la evaluación
        Return lista

    End Function

    ''' <summary>
    ''' Consulta el nodo OPTMTOMAQ/
    ''' Recibe el resultado como Datos
    ''' Evalúa si existe la falla comparando con el parámetro recibido
    ''' Cambia el estado de la bandera y la devuelve.
    ''' </summary>
    ''' <param name="refa"></param>
    ''' <returns></returns>
    Public Function GetRefas(ByVal refa As String) As Boolean

        'Locales
        Dim estado As Boolean = False
        Dim arrRefas() As String

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("OPTMTOMAQ/Refas")

            'Resultado
            resFallas = res.ResultAs(Of Datos)

            'Captura de la lista de fallas
            Dim strRefas As String = resFallas.RefaMaq
            arrRefas = strRefas.Split(",")

            'Rutina para recorrer el arreglo
            For i = 0 To arrRefas.Length - 1

                'Evaluación del parámetro recibido contra el contenido del arreglo
                If (refa = arrRefas(i)) Then

                    'Cambio del estado de la bandera y salida de la rutina
                    estado = True
                    Exit For

                End If

            Next


        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado de la evaluación
        Return estado

    End Function

    ''' <summary>
    ''' Consulta el nodo OPTMTOMAQ/Refas
    ''' Guarda el resultado como una cadena
    ''' Devuelve la cadena
    ''' </summary>
    ''' <returns></returns>
    Public Function GetListaRefas() As String

        'Locales
        Dim lista As String = ""

        'Conexión Firebase
        Dim con As New Conexion

        'Excepción controlada
        Try

            'Firebase conection
            con.Con_Global()

            'Query firebase
            res = con.firebase.Get("OPTMTOMAQ/Refas")

            'Resultado
            resRefas = res.ResultAs(Of Datos)

            'Captura de la lista de fallas
            lista = resRefas.RefaMaq

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

        'Devuelve el resultado de la evaluación
        Return lista

    End Function

#End Region

End Class

Public Class Insertar

    ' En esta región se encuentran las funciones para agregar datos a las tablas.

#Region "DATAMEMBERS"

    'Firebase
    Dim res As FirebaseResponse

    Public strMsgTitle As String = "Empacadora Cianca - 2020 (C)"
#End Region

#Region "MANTOMAQ"

    ''' <summary>
    ''' Recibe los datos necesarios como parámetros
    ''' Agrega los datos en el nodo MANTOMAQ/id_mtom
    ''' </summary>
    ''' <param name="datos"></param>
    Public Sub AddMANTOMAQ(ByVal datos As Datos)

        'Conexión Firebase
        Dim con As New Conexion

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Update(Of Datos)("MANTOMAQ/" + datos.Id_mtom, datos)

            'Usuario
            MsgBox("Registro agregado...", MsgBoxStyle.Information, strMsgTitle)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

    ''' <summary>
    ''' Recibe los datos necesarios como parámetros.
    ''' Agrega los datos en el nodo OPTMTOMAQ/.
    ''' </summary>
    ''' <param name="datos"></param>
    Public Sub AddOPTMTOMAQ(ByVal datos As Datos)
        'Locales
        Dim flgFalla As Boolean
        Dim verifica As New Consulta
        Dim fallas As New Datos
        Dim refas As New Datos
        Dim lista As String

        'Conexión Firebase
        Dim con As New Conexion

        'Valida que la dedscripción de la falla no sea repetida
        flgFalla = verifica.GetFallas(datos.DescFalla_mtom)
        If (flgFalla) Then
        Else

            'Agrega la falla a la lista
            Try

                'Captura la lista existente en firebase
                lista = verifica.GetListaFallas()
                lista += "," & datos.DescFalla_mtom
                fallas.FallasMaq = lista

                'Firebase conection
                con.Con_Global()

                'Query Firebase
                res = con.firebase.Update(Of Datos)("OPTMTOMAQ/Fallas", fallas)

                'Usuario
                'MsgBox("Lista agregada...", MsgBoxStyle.Information, strMsgTitle)

            Catch ex As Exception

                'USUARIO
                MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

            End Try

        End If

        'Valida que la dedscripción de la falla no sea repetida
        flgFalla = verifica.GetRefas(datos.NoParte_mtom)
        If (flgFalla) Then
        Else

            'Agrega la falla a la lista
            Try

                'Captura la lista existente en firebase
                lista = verifica.GetListaRefas()
                lista += "," & datos.NoParte_mtom
                refas.RefaMaq = lista

                'Firebase conection
                con.Con_Global()

                'Query Firebase
                res = con.firebase.Update(Of Datos)("OPTMTOMAQ/Refas", refas)

                'Usuario
                'MsgBox("Refacción agregada...", MsgBoxStyle.Information, strMsgTitle)

            Catch ex As Exception

                'USUARIO
                MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

            End Try

        End If

    End Sub

#End Region

#Region "MANTOAUTO"

    ''' <summary>
    '''  Recibe los datos necesarios como parámetros
    ''' Agrega los datos en el nodo MANTOAUTO/placas-fecha-rfc
    ''' </summary>
    ''' <param name="datos"></param>
    Public Sub AddMANTOAUTO(ByVal datos As Datos)

        'Conexión Firebase
        Dim con As New Conexion

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Update(Of Datos)("MANTOAUTO/" + datos.Id_mto, datos)

            'Usuario
            MsgBox("Registro agregado...", MsgBoxStyle.Information, strMsgTitle)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

#End Region

End Class

Public Class Borrar

    'En esta región se encuentran las funciones y rutinas para borrar datos de Firebase

#Region "DATAMEMBERS"

    'Firebase
    Dim res As FirebaseResponse

#End Region

#Region "MANTOMAQ"

    ''' <summary>
    ''' Recibe los datos necesarios como parámetros
    ''' Borra los datos en el nodo MANTOMAQ/id_mtom
    ''' </summary>
    ''' <param name="datos"></param>
    Public Sub DelMANTOMAQ(ByVal datos As Datos)

        'Conexión Firebase
        Dim con As New Conexion

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Delete("MANTOMAQ/" + datos.Id_mtom)

            'Usuario
            MsgBox("Registro " + datos.Id_mtom + " borrado", MsgBoxStyle.Critical, con.strMsgTitle)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

#End Region

#Region "MANTOAUTO"

    ''' <summary>
    ''' Recibe los datos necesarios como parámetros
    ''' Borra los datos en el nodo MANTOAUTO/id_mto
    ''' </summary>
    ''' <param name="datos"></param>
    Public Sub DelMANTOAUTO(ByVal datos As Datos)

        'Conexión Firebase
        Dim con As New Conexion

        'Manejo de excepciones
        Try

            'Firebase conection
            con.Con_Global()

            'Query Firebase
            res = con.firebase.Delete("MANTOAUTO/" + datos.Id_mto)

            'Usuario
            MsgBox("Registro " + datos.Id_mto + " borrado", MsgBoxStyle.Critical, con.strMsgTitle)

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

#End Region

End Class
