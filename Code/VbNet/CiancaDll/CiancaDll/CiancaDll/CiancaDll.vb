'Imports
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

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

End Class

Public Class Consulta

    'En esta región se concentran las consultas así como también las variables necesarias
    'para enviar los resultados a los cbo y datagrid necesarios.
    'La conexión a firebase se realiza desde aquí.

#Region "DATAMEMBERS"
    'Firebase
    Dim res As FirebaseResponse
    Dim dataDic As Dictionary(Of String, Datos)

    'Referente a los cbo
    Public cboUsrDS As New DataSet      'ComboBox Only USUARIOS
    Public cboMaqDS As New DataSet      'ComboBox Only INVENTARIO_AF

    'Referente a los dgv
    'Public dgvPedidosDS As New DataSet  'Datagrid Only PEDIDOS
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
    ''' Se encarga de obtener el número de serie de las maquinas en el nodo INVENTARIO_AF para
    ''' pasarlo a una tabla.
    ''' </summary>
    Public Sub getSerialMaq()


        'Conexión Firebase
        Dim con As New Conexion

        'Init Tabla, hardcode USR
        cboMaqDS.Tables.Add("MAQ")
        cboMaqDS.Tables("MAQ").Columns.Add("Serial", GetType(String))

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
                If String.IsNullOrEmpty(item.Value.Serie_af) Then
                Else
                    cboUsrDS.Tables("MAQ").Rows.Add(item.Value.Serie_af)
                End If
            Next

        Catch ex As Exception

            'USUARIO
            MsgBox(ex.ToString, MsgBoxStyle.Critical, con.strMsgTitle)

        End Try

    End Sub

#End Region
End Class