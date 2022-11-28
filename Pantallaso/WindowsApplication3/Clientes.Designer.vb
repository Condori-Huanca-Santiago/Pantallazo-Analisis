<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Boton_Confirmar3 = New System.Windows.Forms.TabControl()
        Me.Agregar = New System.Windows.Forms.TabPage()
        Me.Boton_Confirmar1 = New System.Windows.Forms.Button()
        Me.Nombre_T1 = New System.Windows.Forms.TextBox()
        Me.Obra_social_l1 = New System.Windows.Forms.Label()
        Me.Direccion_l1 = New System.Windows.Forms.Label()
        Me.Telefono_L1 = New System.Windows.Forms.Label()
        Me.DNI_L1 = New System.Windows.Forms.Label()
        Me.Apellido_l1 = New System.Windows.Forms.Label()
        Me.Nombre_l1 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.TabPage()
        Me.Boton_Confirmar2 = New System.Windows.Forms.Button()
        Me.ID_Paciente_T1 = New System.Windows.Forms.TextBox()
        Me.ID_Paciente_l1 = New System.Windows.Forms.Label()
        Me.Obra_social_T2 = New System.Windows.Forms.TextBox()
        Me.Direccion_T2 = New System.Windows.Forms.TextBox()
        Me.Telefono_T2 = New System.Windows.Forms.TextBox()
        Me.DNI_T2 = New System.Windows.Forms.TextBox()
        Me.Apellido_T2 = New System.Windows.Forms.TextBox()
        Me.Nombre_T2 = New System.Windows.Forms.TextBox()
        Me.Obra_social_l2 = New System.Windows.Forms.Label()
        Me.Direccion_l2 = New System.Windows.Forms.Label()
        Me.Telefono_L2 = New System.Windows.Forms.Label()
        Me.DNI_L2 = New System.Windows.Forms.Label()
        Me.Apellido_l2 = New System.Windows.Forms.Label()
        Me.Nombre_l2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ID_Paciente_T2 = New System.Windows.Forms.TextBox()
        Me.ID_Paciente_l2 = New System.Windows.Forms.Label()
        Me.Obra_social_T3 = New System.Windows.Forms.TextBox()
        Me.Direccion_T3 = New System.Windows.Forms.TextBox()
        Me.Telefono_T3 = New System.Windows.Forms.TextBox()
        Me.DNI_T3 = New System.Windows.Forms.TextBox()
        Me.Apellido_T3 = New System.Windows.Forms.TextBox()
        Me.Nombre_T3 = New System.Windows.Forms.TextBox()
        Me.Obra_social_l3 = New System.Windows.Forms.Label()
        Me.Direccion_l3 = New System.Windows.Forms.Label()
        Me.Telefono_L3 = New System.Windows.Forms.Label()
        Me.DNI_L3 = New System.Windows.Forms.Label()
        Me.Apellido_l3 = New System.Windows.Forms.Label()
        Me.Nombre_l3 = New System.Windows.Forms.Label()
        Me.Ej1 = New System.Windows.Forms.PictureBox()
        Me.Apellido_T1 = New System.Windows.Forms.TextBox()
        Me.DNI_T1 = New System.Windows.Forms.TextBox()
        Me.Telefono_T1 = New System.Windows.Forms.TextBox()
        Me.Direccion_T1 = New System.Windows.Forms.TextBox()
        Me.Obra_social_T1 = New System.Windows.Forms.TextBox()
        Me.Boton_Confirmar3.SuspendLayout()
        Me.Agregar.SuspendLayout()
        Me.Eliminar.SuspendLayout()
        Me.Buscar.SuspendLayout()
        CType(Me.Ej1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boton_Confirmar3
        '
        Me.Boton_Confirmar3.Controls.Add(Me.Agregar)
        Me.Boton_Confirmar3.Controls.Add(Me.Eliminar)
        Me.Boton_Confirmar3.Controls.Add(Me.Buscar)
        Me.Boton_Confirmar3.Location = New System.Drawing.Point(488, 4)
        Me.Boton_Confirmar3.Name = "Boton_Confirmar3"
        Me.Boton_Confirmar3.SelectedIndex = 0
        Me.Boton_Confirmar3.Size = New System.Drawing.Size(270, 332)
        Me.Boton_Confirmar3.TabIndex = 1
        '
        'Agregar
        '
        Me.Agregar.Controls.Add(Me.Boton_Confirmar1)
        Me.Agregar.Controls.Add(Me.Obra_social_T1)
        Me.Agregar.Controls.Add(Me.Direccion_T1)
        Me.Agregar.Controls.Add(Me.Telefono_T1)
        Me.Agregar.Controls.Add(Me.DNI_T1)
        Me.Agregar.Controls.Add(Me.Apellido_T1)
        Me.Agregar.Controls.Add(Me.Nombre_T1)
        Me.Agregar.Controls.Add(Me.Obra_social_l1)
        Me.Agregar.Controls.Add(Me.Direccion_l1)
        Me.Agregar.Controls.Add(Me.Telefono_L1)
        Me.Agregar.Controls.Add(Me.DNI_L1)
        Me.Agregar.Controls.Add(Me.Apellido_l1)
        Me.Agregar.Controls.Add(Me.Nombre_l1)
        Me.Agregar.Location = New System.Drawing.Point(4, 22)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Padding = New System.Windows.Forms.Padding(3)
        Me.Agregar.Size = New System.Drawing.Size(262, 306)
        Me.Agregar.TabIndex = 0
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Boton_Confirmar1
        '
        Me.Boton_Confirmar1.Location = New System.Drawing.Point(180, 271)
        Me.Boton_Confirmar1.Name = "Boton_Confirmar1"
        Me.Boton_Confirmar1.Size = New System.Drawing.Size(75, 23)
        Me.Boton_Confirmar1.TabIndex = 38
        Me.Boton_Confirmar1.Text = "&Confirmar"
        Me.Boton_Confirmar1.UseVisualStyleBackColor = True
        '
        'Nombre_T1
        '
        Me.Nombre_T1.Location = New System.Drawing.Point(118, 3)
        Me.Nombre_T1.Name = "Nombre_T1"
        Me.Nombre_T1.Size = New System.Drawing.Size(137, 20)
        Me.Nombre_T1.TabIndex = 32
        '
        'Obra_social_l1
        '
        Me.Obra_social_l1.AutoSize = True
        Me.Obra_social_l1.Location = New System.Drawing.Point(11, 178)
        Me.Obra_social_l1.Name = "Obra_social_l1"
        Me.Obra_social_l1.Size = New System.Drawing.Size(60, 13)
        Me.Obra_social_l1.TabIndex = 31
        Me.Obra_social_l1.Text = "Obra social"
        '
        'Direccion_l1
        '
        Me.Direccion_l1.AutoSize = True
        Me.Direccion_l1.Location = New System.Drawing.Point(11, 141)
        Me.Direccion_l1.Name = "Direccion_l1"
        Me.Direccion_l1.Size = New System.Drawing.Size(52, 13)
        Me.Direccion_l1.TabIndex = 30
        Me.Direccion_l1.Text = "Direccion"
        '
        'Telefono_L1
        '
        Me.Telefono_L1.AutoSize = True
        Me.Telefono_L1.Location = New System.Drawing.Point(11, 105)
        Me.Telefono_L1.Name = "Telefono_L1"
        Me.Telefono_L1.Size = New System.Drawing.Size(49, 13)
        Me.Telefono_L1.TabIndex = 29
        Me.Telefono_L1.Text = "Telefono"
        '
        'DNI_L1
        '
        Me.DNI_L1.AutoSize = True
        Me.DNI_L1.Location = New System.Drawing.Point(10, 72)
        Me.DNI_L1.Name = "DNI_L1"
        Me.DNI_L1.Size = New System.Drawing.Size(26, 13)
        Me.DNI_L1.TabIndex = 28
        Me.DNI_L1.Text = "DNI"
        '
        'Apellido_l1
        '
        Me.Apellido_l1.AutoSize = True
        Me.Apellido_l1.Location = New System.Drawing.Point(11, 40)
        Me.Apellido_l1.Name = "Apellido_l1"
        Me.Apellido_l1.Size = New System.Drawing.Size(44, 13)
        Me.Apellido_l1.TabIndex = 27
        Me.Apellido_l1.Text = "Apellido"
        '
        'Nombre_l1
        '
        Me.Nombre_l1.AutoSize = True
        Me.Nombre_l1.Location = New System.Drawing.Point(11, 9)
        Me.Nombre_l1.Name = "Nombre_l1"
        Me.Nombre_l1.Size = New System.Drawing.Size(44, 13)
        Me.Nombre_l1.TabIndex = 26
        Me.Nombre_l1.Text = "Nombre"
        '
        'Eliminar
        '
        Me.Eliminar.Controls.Add(Me.Boton_Confirmar2)
        Me.Eliminar.Controls.Add(Me.ID_Paciente_T1)
        Me.Eliminar.Controls.Add(Me.ID_Paciente_l1)
        Me.Eliminar.Controls.Add(Me.Obra_social_T2)
        Me.Eliminar.Controls.Add(Me.Direccion_T2)
        Me.Eliminar.Controls.Add(Me.Telefono_T2)
        Me.Eliminar.Controls.Add(Me.DNI_T2)
        Me.Eliminar.Controls.Add(Me.Apellido_T2)
        Me.Eliminar.Controls.Add(Me.Nombre_T2)
        Me.Eliminar.Controls.Add(Me.Obra_social_l2)
        Me.Eliminar.Controls.Add(Me.Direccion_l2)
        Me.Eliminar.Controls.Add(Me.Telefono_L2)
        Me.Eliminar.Controls.Add(Me.DNI_L2)
        Me.Eliminar.Controls.Add(Me.Apellido_l2)
        Me.Eliminar.Controls.Add(Me.Nombre_l2)
        Me.Eliminar.Controls.Add(Me.Button1)
        Me.Eliminar.Controls.Add(Me.TextBox7)
        Me.Eliminar.Controls.Add(Me.Label7)
        Me.Eliminar.Location = New System.Drawing.Point(4, 22)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(262, 306)
        Me.Eliminar.TabIndex = 2
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Boton_Confirmar2
        '
        Me.Boton_Confirmar2.Location = New System.Drawing.Point(180, 271)
        Me.Boton_Confirmar2.Name = "Boton_Confirmar2"
        Me.Boton_Confirmar2.Size = New System.Drawing.Size(75, 23)
        Me.Boton_Confirmar2.TabIndex = 39
        Me.Boton_Confirmar2.Text = "&Confirmar"
        Me.Boton_Confirmar2.UseVisualStyleBackColor = True
        '
        'ID_Paciente_T1
        '
        Me.ID_Paciente_T1.Location = New System.Drawing.Point(118, 3)
        Me.ID_Paciente_T1.Name = "ID_Paciente_T1"
        Me.ID_Paciente_T1.Size = New System.Drawing.Size(137, 20)
        Me.ID_Paciente_T1.TabIndex = 25
        '
        'ID_Paciente_l1
        '
        Me.ID_Paciente_l1.AutoSize = True
        Me.ID_Paciente_l1.Location = New System.Drawing.Point(10, 6)
        Me.ID_Paciente_l1.Name = "ID_Paciente_l1"
        Me.ID_Paciente_l1.Size = New System.Drawing.Size(61, 13)
        Me.ID_Paciente_l1.TabIndex = 24
        Me.ID_Paciente_l1.Text = "Id Paciente"
        '
        'Obra_social_T2
        '
        Me.Obra_social_T2.Location = New System.Drawing.Point(118, 198)
        Me.Obra_social_T2.Name = "Obra_social_T2"
        Me.Obra_social_T2.Size = New System.Drawing.Size(137, 20)
        Me.Obra_social_T2.TabIndex = 23
        '
        'Direccion_T2
        '
        Me.Direccion_T2.Location = New System.Drawing.Point(118, 161)
        Me.Direccion_T2.Name = "Direccion_T2"
        Me.Direccion_T2.Size = New System.Drawing.Size(137, 20)
        Me.Direccion_T2.TabIndex = 22
        '
        'Telefono_T2
        '
        Me.Telefono_T2.Location = New System.Drawing.Point(118, 125)
        Me.Telefono_T2.Name = "Telefono_T2"
        Me.Telefono_T2.Size = New System.Drawing.Size(137, 20)
        Me.Telefono_T2.TabIndex = 21
        '
        'DNI_T2
        '
        Me.DNI_T2.Location = New System.Drawing.Point(118, 92)
        Me.DNI_T2.Name = "DNI_T2"
        Me.DNI_T2.Size = New System.Drawing.Size(137, 20)
        Me.DNI_T2.TabIndex = 20
        '
        'Apellido_T2
        '
        Me.Apellido_T2.Location = New System.Drawing.Point(118, 60)
        Me.Apellido_T2.Name = "Apellido_T2"
        Me.Apellido_T2.Size = New System.Drawing.Size(137, 20)
        Me.Apellido_T2.TabIndex = 19
        '
        'Nombre_T2
        '
        Me.Nombre_T2.Location = New System.Drawing.Point(118, 29)
        Me.Nombre_T2.Name = "Nombre_T2"
        Me.Nombre_T2.Size = New System.Drawing.Size(137, 20)
        Me.Nombre_T2.TabIndex = 18
        '
        'Obra_social_l2
        '
        Me.Obra_social_l2.AutoSize = True
        Me.Obra_social_l2.Location = New System.Drawing.Point(10, 201)
        Me.Obra_social_l2.Name = "Obra_social_l2"
        Me.Obra_social_l2.Size = New System.Drawing.Size(60, 13)
        Me.Obra_social_l2.TabIndex = 17
        Me.Obra_social_l2.Text = "Obra social"
        '
        'Direccion_l2
        '
        Me.Direccion_l2.AutoSize = True
        Me.Direccion_l2.Location = New System.Drawing.Point(10, 164)
        Me.Direccion_l2.Name = "Direccion_l2"
        Me.Direccion_l2.Size = New System.Drawing.Size(52, 13)
        Me.Direccion_l2.TabIndex = 16
        Me.Direccion_l2.Text = "Direccion"
        '
        'Telefono_L2
        '
        Me.Telefono_L2.AutoSize = True
        Me.Telefono_L2.Location = New System.Drawing.Point(10, 128)
        Me.Telefono_L2.Name = "Telefono_L2"
        Me.Telefono_L2.Size = New System.Drawing.Size(49, 13)
        Me.Telefono_L2.TabIndex = 15
        Me.Telefono_L2.Text = "Telefono"
        '
        'DNI_L2
        '
        Me.DNI_L2.AutoSize = True
        Me.DNI_L2.Location = New System.Drawing.Point(10, 95)
        Me.DNI_L2.Name = "DNI_L2"
        Me.DNI_L2.Size = New System.Drawing.Size(26, 13)
        Me.DNI_L2.TabIndex = 14
        Me.DNI_L2.Text = "DNI"
        '
        'Apellido_l2
        '
        Me.Apellido_l2.AutoSize = True
        Me.Apellido_l2.Location = New System.Drawing.Point(10, 63)
        Me.Apellido_l2.Name = "Apellido_l2"
        Me.Apellido_l2.Size = New System.Drawing.Size(44, 13)
        Me.Apellido_l2.TabIndex = 13
        Me.Apellido_l2.Text = "Apellido"
        '
        'Nombre_l2
        '
        Me.Nombre_l2.AutoSize = True
        Me.Nombre_l2.Location = New System.Drawing.Point(10, 32)
        Me.Nombre_l2.Name = "Nombre_l2"
        Me.Nombre_l2.Size = New System.Drawing.Size(44, 13)
        Me.Nombre_l2.TabIndex = 12
        Me.Nombre_l2.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(444, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(444, 22)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(163, 20)
        Me.TextBox7.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(388, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Buscar"
        '
        'Buscar
        '
        Me.Buscar.Controls.Add(Me.Button4)
        Me.Buscar.Controls.Add(Me.ID_Paciente_T2)
        Me.Buscar.Controls.Add(Me.ID_Paciente_l2)
        Me.Buscar.Controls.Add(Me.Obra_social_T3)
        Me.Buscar.Controls.Add(Me.Direccion_T3)
        Me.Buscar.Controls.Add(Me.Telefono_T3)
        Me.Buscar.Controls.Add(Me.DNI_T3)
        Me.Buscar.Controls.Add(Me.Apellido_T3)
        Me.Buscar.Controls.Add(Me.Nombre_T3)
        Me.Buscar.Controls.Add(Me.Obra_social_l3)
        Me.Buscar.Controls.Add(Me.Direccion_l3)
        Me.Buscar.Controls.Add(Me.Telefono_L3)
        Me.Buscar.Controls.Add(Me.DNI_L3)
        Me.Buscar.Controls.Add(Me.Apellido_l3)
        Me.Buscar.Controls.Add(Me.Nombre_l3)
        Me.Buscar.Location = New System.Drawing.Point(4, 22)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(262, 306)
        Me.Buscar.TabIndex = 3
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(180, 271)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "&Confirmar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ID_Paciente_T2
        '
        Me.ID_Paciente_T2.Location = New System.Drawing.Point(118, 3)
        Me.ID_Paciente_T2.Name = "ID_Paciente_T2"
        Me.ID_Paciente_T2.Size = New System.Drawing.Size(137, 20)
        Me.ID_Paciente_T2.TabIndex = 39
        '
        'ID_Paciente_l2
        '
        Me.ID_Paciente_l2.AutoSize = True
        Me.ID_Paciente_l2.Location = New System.Drawing.Point(10, 6)
        Me.ID_Paciente_l2.Name = "ID_Paciente_l2"
        Me.ID_Paciente_l2.Size = New System.Drawing.Size(61, 13)
        Me.ID_Paciente_l2.TabIndex = 38
        Me.ID_Paciente_l2.Text = "Id Paciente"
        '
        'Obra_social_T3
        '
        Me.Obra_social_T3.Location = New System.Drawing.Point(118, 198)
        Me.Obra_social_T3.Name = "Obra_social_T3"
        Me.Obra_social_T3.Size = New System.Drawing.Size(137, 20)
        Me.Obra_social_T3.TabIndex = 37
        '
        'Direccion_T3
        '
        Me.Direccion_T3.Location = New System.Drawing.Point(118, 161)
        Me.Direccion_T3.Name = "Direccion_T3"
        Me.Direccion_T3.Size = New System.Drawing.Size(137, 20)
        Me.Direccion_T3.TabIndex = 36
        '
        'Telefono_T3
        '
        Me.Telefono_T3.Location = New System.Drawing.Point(118, 125)
        Me.Telefono_T3.Name = "Telefono_T3"
        Me.Telefono_T3.Size = New System.Drawing.Size(137, 20)
        Me.Telefono_T3.TabIndex = 35
        '
        'DNI_T3
        '
        Me.DNI_T3.Location = New System.Drawing.Point(118, 92)
        Me.DNI_T3.Name = "DNI_T3"
        Me.DNI_T3.Size = New System.Drawing.Size(137, 20)
        Me.DNI_T3.TabIndex = 34
        '
        'Apellido_T3
        '
        Me.Apellido_T3.Location = New System.Drawing.Point(118, 60)
        Me.Apellido_T3.Name = "Apellido_T3"
        Me.Apellido_T3.Size = New System.Drawing.Size(137, 20)
        Me.Apellido_T3.TabIndex = 33
        '
        'Nombre_T3
        '
        Me.Nombre_T3.Location = New System.Drawing.Point(118, 29)
        Me.Nombre_T3.Name = "Nombre_T3"
        Me.Nombre_T3.Size = New System.Drawing.Size(137, 20)
        Me.Nombre_T3.TabIndex = 32
        '
        'Obra_social_l3
        '
        Me.Obra_social_l3.AutoSize = True
        Me.Obra_social_l3.Location = New System.Drawing.Point(10, 201)
        Me.Obra_social_l3.Name = "Obra_social_l3"
        Me.Obra_social_l3.Size = New System.Drawing.Size(60, 13)
        Me.Obra_social_l3.TabIndex = 31
        Me.Obra_social_l3.Text = "Obra social"
        '
        'Direccion_l3
        '
        Me.Direccion_l3.AutoSize = True
        Me.Direccion_l3.Location = New System.Drawing.Point(10, 164)
        Me.Direccion_l3.Name = "Direccion_l3"
        Me.Direccion_l3.Size = New System.Drawing.Size(52, 13)
        Me.Direccion_l3.TabIndex = 30
        Me.Direccion_l3.Text = "Direccion"
        '
        'Telefono_L3
        '
        Me.Telefono_L3.AutoSize = True
        Me.Telefono_L3.Location = New System.Drawing.Point(10, 128)
        Me.Telefono_L3.Name = "Telefono_L3"
        Me.Telefono_L3.Size = New System.Drawing.Size(49, 13)
        Me.Telefono_L3.TabIndex = 29
        Me.Telefono_L3.Text = "Telefono"
        '
        'DNI_L3
        '
        Me.DNI_L3.AutoSize = True
        Me.DNI_L3.Location = New System.Drawing.Point(10, 95)
        Me.DNI_L3.Name = "DNI_L3"
        Me.DNI_L3.Size = New System.Drawing.Size(26, 13)
        Me.DNI_L3.TabIndex = 28
        Me.DNI_L3.Text = "DNI"
        '
        'Apellido_l3
        '
        Me.Apellido_l3.AutoSize = True
        Me.Apellido_l3.Location = New System.Drawing.Point(10, 63)
        Me.Apellido_l3.Name = "Apellido_l3"
        Me.Apellido_l3.Size = New System.Drawing.Size(44, 13)
        Me.Apellido_l3.TabIndex = 27
        Me.Apellido_l3.Text = "Apellido"
        '
        'Nombre_l3
        '
        Me.Nombre_l3.AutoSize = True
        Me.Nombre_l3.Location = New System.Drawing.Point(10, 32)
        Me.Nombre_l3.Name = "Nombre_l3"
        Me.Nombre_l3.Size = New System.Drawing.Size(44, 13)
        Me.Nombre_l3.TabIndex = 26
        Me.Nombre_l3.Text = "Nombre"
        '
        'Ej1
        '
        Me.Ej1.Image = CType(resources.GetObject("Ej1.Image"), System.Drawing.Image)
        Me.Ej1.Location = New System.Drawing.Point(2, 4)
        Me.Ej1.Name = "Ej1"
        Me.Ej1.Size = New System.Drawing.Size(480, 237)
        Me.Ej1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ej1.TabIndex = 3
        Me.Ej1.TabStop = False
        '
        'Apellido_T1
        '
        Me.Apellido_T1.Location = New System.Drawing.Point(118, 33)
        Me.Apellido_T1.Name = "Apellido_T1"
        Me.Apellido_T1.Size = New System.Drawing.Size(137, 20)
        Me.Apellido_T1.TabIndex = 33
        '
        'DNI_T1
        '
        Me.DNI_T1.Location = New System.Drawing.Point(118, 65)
        Me.DNI_T1.Name = "DNI_T1"
        Me.DNI_T1.Size = New System.Drawing.Size(137, 20)
        Me.DNI_T1.TabIndex = 34
        '
        'Telefono_T1
        '
        Me.Telefono_T1.Location = New System.Drawing.Point(118, 98)
        Me.Telefono_T1.Name = "Telefono_T1"
        Me.Telefono_T1.Size = New System.Drawing.Size(137, 20)
        Me.Telefono_T1.TabIndex = 35
        '
        'Direccion_T1
        '
        Me.Direccion_T1.Location = New System.Drawing.Point(118, 134)
        Me.Direccion_T1.Name = "Direccion_T1"
        Me.Direccion_T1.Size = New System.Drawing.Size(137, 20)
        Me.Direccion_T1.TabIndex = 36
        '
        'Obra_social_T1
        '
        Me.Obra_social_T1.Location = New System.Drawing.Point(118, 171)
        Me.Obra_social_T1.Name = "Obra_social_T1"
        Me.Obra_social_T1.Size = New System.Drawing.Size(137, 20)
        Me.Obra_social_T1.TabIndex = 37
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(757, 326)
        Me.Controls.Add(Me.Ej1)
        Me.Controls.Add(Me.Boton_Confirmar3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Clientes"
        Me.Text = "Form3"
        Me.Boton_Confirmar3.ResumeLayout(False)
        Me.Agregar.ResumeLayout(False)
        Me.Agregar.PerformLayout()
        Me.Eliminar.ResumeLayout(False)
        Me.Eliminar.PerformLayout()
        Me.Buscar.ResumeLayout(False)
        Me.Buscar.PerformLayout()
        CType(Me.Ej1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Boton_Confirmar3 As System.Windows.Forms.TabControl
    Friend WithEvents Agregar As System.Windows.Forms.TabPage
    Friend WithEvents Eliminar As System.Windows.Forms.TabPage
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Buscar As System.Windows.Forms.TabPage
    Friend WithEvents Obra_social_T2 As System.Windows.Forms.TextBox
    Friend WithEvents Direccion_T2 As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_T2 As System.Windows.Forms.TextBox
    Friend WithEvents DNI_T2 As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_T2 As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_T2 As System.Windows.Forms.TextBox
    Friend WithEvents Obra_social_l2 As System.Windows.Forms.Label
    Friend WithEvents Direccion_l2 As System.Windows.Forms.Label
    Friend WithEvents Telefono_L2 As System.Windows.Forms.Label
    Friend WithEvents DNI_L2 As System.Windows.Forms.Label
    Friend WithEvents Apellido_l2 As System.Windows.Forms.Label
    Friend WithEvents Nombre_l2 As System.Windows.Forms.Label
    Friend WithEvents ID_Paciente_T1 As System.Windows.Forms.TextBox
    Friend WithEvents ID_Paciente_l1 As System.Windows.Forms.Label
    Friend WithEvents Boton_Confirmar1 As System.Windows.Forms.Button
    Friend WithEvents Nombre_T1 As System.Windows.Forms.TextBox
    Friend WithEvents Obra_social_l1 As System.Windows.Forms.Label
    Friend WithEvents Direccion_l1 As System.Windows.Forms.Label
    Friend WithEvents Telefono_L1 As System.Windows.Forms.Label
    Friend WithEvents DNI_L1 As System.Windows.Forms.Label
    Friend WithEvents Apellido_l1 As System.Windows.Forms.Label
    Friend WithEvents Nombre_l1 As System.Windows.Forms.Label
    Friend WithEvents Boton_Confirmar2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ID_Paciente_T2 As System.Windows.Forms.TextBox
    Friend WithEvents ID_Paciente_l2 As System.Windows.Forms.Label
    Friend WithEvents Obra_social_T3 As System.Windows.Forms.TextBox
    Friend WithEvents Direccion_T3 As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_T3 As System.Windows.Forms.TextBox
    Friend WithEvents DNI_T3 As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_T3 As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_T3 As System.Windows.Forms.TextBox
    Friend WithEvents Obra_social_l3 As System.Windows.Forms.Label
    Friend WithEvents Direccion_l3 As System.Windows.Forms.Label
    Friend WithEvents Telefono_L3 As System.Windows.Forms.Label
    Friend WithEvents DNI_L3 As System.Windows.Forms.Label
    Friend WithEvents Apellido_l3 As System.Windows.Forms.Label
    Friend WithEvents Nombre_l3 As System.Windows.Forms.Label
    Friend WithEvents Ej1 As System.Windows.Forms.PictureBox
    Friend WithEvents Obra_social_T1 As System.Windows.Forms.TextBox
    Friend WithEvents Direccion_T1 As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_T1 As System.Windows.Forms.TextBox
    Friend WithEvents DNI_T1 As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_T1 As System.Windows.Forms.TextBox
End Class
