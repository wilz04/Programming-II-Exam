Public Class Info
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents lNombre As System.Windows.Forms.Label
    Friend WithEvents lIdentificacion As System.Windows.Forms.Label
    Friend WithEvents gbDatosDelUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbId As System.Windows.Forms.TextBox
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bTransferir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbCodigo As System.Windows.Forms.TextBox
    Friend WithEvents tbNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents tbIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents tbDescripcionPermiso As System.Windows.Forms.TextBox
    Friend WithEvents tbMontoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents tbSaldo As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaCuenta As System.Windows.Forms.TextBox
    Friend WithEvents tbDescripcionCuenta As System.Windows.Forms.TextBox
    Friend WithEvents tbMontoAbono As System.Windows.Forms.TextBox
    Friend WithEvents tbFechaAbono As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbNombre = New System.Windows.Forms.TextBox
        Me.tbId = New System.Windows.Forms.TextBox
        Me.lNombre = New System.Windows.Forms.Label
        Me.lIdentificacion = New System.Windows.Forms.Label
        Me.gbDatosDelUsuario = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbCodigo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbDescripcionPermiso = New System.Windows.Forms.TextBox
        Me.bTransferir = New System.Windows.Forms.Button
        Me.gbInfo = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbNombreCliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbIdCliente = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbMontoCuenta = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbSaldo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbFechaCuenta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbDescripcionCuenta = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbMontoAbono = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbFechaAbono = New System.Windows.Forms.TextBox
        Me.gbDatosDelUsuario.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(86, 24)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(130, 20)
        Me.tbNombre.TabIndex = 0
        Me.tbNombre.Text = "a"
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(86, 56)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(130, 20)
        Me.tbId.TabIndex = 1
        Me.tbId.Text = "a"
        '
        'lNombre
        '
        Me.lNombre.Location = New System.Drawing.Point(14, 24)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(72, 23)
        Me.lNombre.TabIndex = 2
        Me.lNombre.Text = "Nombre"
        '
        'lIdentificacion
        '
        Me.lIdentificacion.Location = New System.Drawing.Point(14, 56)
        Me.lIdentificacion.Name = "lIdentificacion"
        Me.lIdentificacion.Size = New System.Drawing.Size(72, 23)
        Me.lIdentificacion.TabIndex = 3
        Me.lIdentificacion.Text = "Identificacion"
        '
        'gbDatosDelUsuario
        '
        Me.gbDatosDelUsuario.Controls.Add(Me.GroupBox4)
        Me.gbDatosDelUsuario.Controls.Add(Me.lNombre)
        Me.gbDatosDelUsuario.Controls.Add(Me.tbNombre)
        Me.gbDatosDelUsuario.Controls.Add(Me.lIdentificacion)
        Me.gbDatosDelUsuario.Controls.Add(Me.tbId)
        Me.gbDatosDelUsuario.Controls.Add(Me.bTransferir)
        Me.gbDatosDelUsuario.Location = New System.Drawing.Point(11, 8)
        Me.gbDatosDelUsuario.Name = "gbDatosDelUsuario"
        Me.gbDatosDelUsuario.Size = New System.Drawing.Size(524, 136)
        Me.gbDatosDelUsuario.TabIndex = 4
        Me.gbDatosDelUsuario.TabStop = False
        Me.gbDatosDelUsuario.Text = "Datos del usuario"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.tbCodigo)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.tbDescripcionPermiso)
        Me.GroupBox4.Location = New System.Drawing.Point(256, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 80)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Permiso"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Codigo"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(83, 16)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(125, 20)
        Me.tbCodigo.TabIndex = 4
        Me.tbCodigo.Text = "a"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(11, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Descripcion"
        '
        'tbDescripcionPermiso
        '
        Me.tbDescripcionPermiso.Location = New System.Drawing.Point(83, 48)
        Me.tbDescripcionPermiso.Name = "tbDescripcionPermiso"
        Me.tbDescripcionPermiso.Size = New System.Drawing.Size(125, 20)
        Me.tbDescripcionPermiso.TabIndex = 5
        Me.tbDescripcionPermiso.Text = "a"
        '
        'bTransferir
        '
        Me.bTransferir.Location = New System.Drawing.Point(200, 96)
        Me.bTransferir.Name = "bTransferir"
        Me.bTransferir.Size = New System.Drawing.Size(125, 23)
        Me.bTransferir.TabIndex = 6
        Me.bTransferir.Text = "Transferir"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.Label1)
        Me.gbInfo.Controls.Add(Me.tbNombreCliente)
        Me.gbInfo.Controls.Add(Me.Label2)
        Me.gbInfo.Controls.Add(Me.tbIdCliente)
        Me.gbInfo.Controls.Add(Me.Button1)
        Me.gbInfo.Location = New System.Drawing.Point(16, 24)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(232, 112)
        Me.gbInfo.TabIndex = 5
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Datos"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.Location = New System.Drawing.Point(78, 24)
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(130, 20)
        Me.tbNombreCliente.TabIndex = 0
        Me.tbNombreCliente.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Identificacion"
        '
        'tbIdCliente
        '
        Me.tbIdCliente.Location = New System.Drawing.Point(78, 56)
        Me.tbIdCliente.Name = "tbIdCliente"
        Me.tbIdCliente.Size = New System.Drawing.Size(130, 20)
        Me.tbIdCliente.TabIndex = 1
        Me.tbIdCliente.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Transferir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbMontoCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbSaldo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbFechaCuenta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbDescripcionCuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 208)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Monto"
        '
        'tbMontoCuenta
        '
        Me.tbMontoCuenta.Location = New System.Drawing.Point(78, 88)
        Me.tbMontoCuenta.Name = "tbMontoCuenta"
        Me.tbMontoCuenta.Size = New System.Drawing.Size(130, 20)
        Me.tbMontoCuenta.TabIndex = 4
        Me.tbMontoCuenta.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Saldo"
        '
        'tbSaldo
        '
        Me.tbSaldo.Location = New System.Drawing.Point(78, 120)
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.Size = New System.Drawing.Size(130, 20)
        Me.tbSaldo.TabIndex = 5
        Me.tbSaldo.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'tbFechaCuenta
        '
        Me.tbFechaCuenta.Location = New System.Drawing.Point(78, 24)
        Me.tbFechaCuenta.Name = "tbFechaCuenta"
        Me.tbFechaCuenta.Size = New System.Drawing.Size(130, 20)
        Me.tbFechaCuenta.TabIndex = 0
        Me.tbFechaCuenta.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripcion"
        '
        'tbDescripcionCuenta
        '
        Me.tbDescripcionCuenta.Location = New System.Drawing.Point(78, 56)
        Me.tbDescripcionCuenta.Name = "tbDescripcionCuenta"
        Me.tbDescripcionCuenta.Size = New System.Drawing.Size(130, 20)
        Me.tbDescripcionCuenta.TabIndex = 1
        Me.tbDescripcionCuenta.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbInfo)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 256)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.tbMontoAbono)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tbFechaAbono)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 89)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Abono"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Monto"
        '
        'tbMontoAbono
        '
        Me.tbMontoAbono.Location = New System.Drawing.Point(78, 24)
        Me.tbMontoAbono.Name = "tbMontoAbono"
        Me.tbMontoAbono.Size = New System.Drawing.Size(130, 20)
        Me.tbMontoAbono.TabIndex = 0
        Me.tbMontoAbono.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Fecha"
        '
        'tbFechaAbono
        '
        Me.tbFechaAbono.Location = New System.Drawing.Point(78, 56)
        Me.tbFechaAbono.Name = "tbFechaAbono"
        Me.tbFechaAbono.Size = New System.Drawing.Size(130, 20)
        Me.tbFechaAbono.TabIndex = 1
        Me.tbFechaAbono.Text = ""
        '
        'Info
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(546, 418)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbDatosDelUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Info"
        Me.Text = "050004 - wcf - e1"
        Me.gbDatosDelUsuario.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.gbInfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Const x = 10
    Const y = 2

    Dim nombreCliente As String
    Dim idCliente As String

    Dim autorizacion As Boolean

    Dim cliente As New cliente

    Private Sub FormOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autorizacion = False

        cliente.id = "identificacion del cliente"
        cliente.nombre = "nombre del cliente"
        cliente.Abono("monto del abono", "fecha del abono")
        cliente.Cuenta("fecha de la cuenta", "descripcion de la cuenta", "monto de la cuenta", "saldo de la cuenta")
    End Sub

    Private Sub bTInfoUOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTransferir.Click
        If tbNombre.Text = "a" And tbId.Text = "a" And tbCodigo.Text = "a" And tbDescripcionPermiso.Text = "a" Then
            autorizacion = True
            MsgBox("Autorizacion concedida")
        Else
            autorizacion = False
            MsgBox("Autorizacion cancelada")
        End If
    End Sub

    Private Sub bTInfoCOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim j As Integer
        If autorizacion = True Then
            nombreCliente = tbNombreCliente.Text
            idCliente = tbIdCliente.Text
            'For i = 0 To x
            'If cliente.nombre = nombreCliente Then
            tbMontoAbono.Text = "b"
            tbFechaAbono.Text = "b"
            tbFechaCuenta.Text = "b"
            tbDescripcionCuenta.Text = "b"
            tbMontoCuenta.Text = "b"
            tbSaldo.Text = "b"
            'End If
            'Next
        End If
    End Sub
End Class
