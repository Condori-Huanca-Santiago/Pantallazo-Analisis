<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turnos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Agregar = New System.Windows.Forms.TabPage()
        Me.Confirmar_Boton1 = New System.Windows.Forms.Button()
        Me.Tipo_T1 = New System.Windows.Forms.TextBox()
        Me.Horario_T1 = New System.Windows.Forms.TextBox()
        Me.Fecha_T1 = New System.Windows.Forms.TextBox()
        Me.ID_Paciente_T1 = New System.Windows.Forms.TextBox()
        Me.TipoL1 = New System.Windows.Forms.Label()
        Me.HorarioL1 = New System.Windows.Forms.Label()
        Me.FechaL1 = New System.Windows.Forms.Label()
        Me.ID_PacienteL1 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.TabPage()
        Me.Confirmar_Boton2 = New System.Windows.Forms.Button()
        Me.Tipo_T2 = New System.Windows.Forms.TextBox()
        Me.Horario_T2 = New System.Windows.Forms.TextBox()
        Me.Fecha_T2 = New System.Windows.Forms.TextBox()
        Me.ID_paciente_T2 = New System.Windows.Forms.TextBox()
        Me.ID_Turno_T1 = New System.Windows.Forms.TextBox()
        Me.TipoL2 = New System.Windows.Forms.Label()
        Me.HorarioL2 = New System.Windows.Forms.Label()
        Me.FechaL2 = New System.Windows.Forms.Label()
        Me.ID_PacienteL2 = New System.Windows.Forms.Label()
        Me.ID_TurnoL1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.TabPage()
        Me.Confirmar_Boton3 = New System.Windows.Forms.Button()
        Me.Tipo_T3 = New System.Windows.Forms.TextBox()
        Me.Horario_T3 = New System.Windows.Forms.TextBox()
        Me.Fecha_T3 = New System.Windows.Forms.TextBox()
        Me.ID_Paciente_T3 = New System.Windows.Forms.TextBox()
        Me.ID_Turno_T2 = New System.Windows.Forms.TextBox()
        Me.TipoL3 = New System.Windows.Forms.Label()
        Me.HorarioL3 = New System.Windows.Forms.Label()
        Me.FechaL3 = New System.Windows.Forms.Label()
        Me.ID_PacienteL3 = New System.Windows.Forms.Label()
        Me.ID_TurnoL2 = New System.Windows.Forms.Label()
        Me.Ej1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.Agregar.SuspendLayout()
        Me.Eliminar.SuspendLayout()
        Me.Buscar.SuspendLayout()
        CType(Me.Ej1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Agregar)
        Me.TabControl1.Controls.Add(Me.Eliminar)
        Me.TabControl1.Controls.Add(Me.Buscar)
        Me.TabControl1.Location = New System.Drawing.Point(487, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(270, 332)
        Me.TabControl1.TabIndex = 1
        '
        'Agregar
        '
        Me.Agregar.Controls.Add(Me.Confirmar_Boton1)
        Me.Agregar.Controls.Add(Me.Tipo_T1)
        Me.Agregar.Controls.Add(Me.Horario_T1)
        Me.Agregar.Controls.Add(Me.Fecha_T1)
        Me.Agregar.Controls.Add(Me.ID_Paciente_T1)
        Me.Agregar.Controls.Add(Me.TipoL1)
        Me.Agregar.Controls.Add(Me.HorarioL1)
        Me.Agregar.Controls.Add(Me.FechaL1)
        Me.Agregar.Controls.Add(Me.ID_PacienteL1)
        Me.Agregar.Location = New System.Drawing.Point(4, 22)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Padding = New System.Windows.Forms.Padding(3)
        Me.Agregar.Size = New System.Drawing.Size(262, 306)
        Me.Agregar.TabIndex = 0
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Confirmar_Boton1
        '
        Me.Confirmar_Boton1.Location = New System.Drawing.Point(180, 270)
        Me.Confirmar_Boton1.Name = "Confirmar_Boton1"
        Me.Confirmar_Boton1.Size = New System.Drawing.Size(75, 23)
        Me.Confirmar_Boton1.TabIndex = 11
        Me.Confirmar_Boton1.Text = "&Confirmar"
        Me.Confirmar_Boton1.UseVisualStyleBackColor = True
        '
        'Tipo_T1
        '
        Me.Tipo_T1.Location = New System.Drawing.Point(118, 104)
        Me.Tipo_T1.Name = "Tipo_T1"
        Me.Tipo_T1.Size = New System.Drawing.Size(137, 20)
        Me.Tipo_T1.TabIndex = 10
        '
        'Horario_T1
        '
        Me.Horario_T1.Location = New System.Drawing.Point(118, 68)
        Me.Horario_T1.Name = "Horario_T1"
        Me.Horario_T1.Size = New System.Drawing.Size(137, 20)
        Me.Horario_T1.TabIndex = 9
        '
        'Fecha_T1
        '
        Me.Fecha_T1.Location = New System.Drawing.Point(118, 35)
        Me.Fecha_T1.Name = "Fecha_T1"
        Me.Fecha_T1.Size = New System.Drawing.Size(137, 20)
        Me.Fecha_T1.TabIndex = 8
        '
        'ID_Paciente_T1
        '
        Me.ID_Paciente_T1.Location = New System.Drawing.Point(118, 3)
        Me.ID_Paciente_T1.Name = "ID_Paciente_T1"
        Me.ID_Paciente_T1.Size = New System.Drawing.Size(137, 20)
        Me.ID_Paciente_T1.TabIndex = 7
        '
        'TipoL1
        '
        Me.TipoL1.AutoSize = True
        Me.TipoL1.Location = New System.Drawing.Point(6, 107)
        Me.TipoL1.Name = "TipoL1"
        Me.TipoL1.Size = New System.Drawing.Size(28, 13)
        Me.TipoL1.TabIndex = 4
        Me.TipoL1.Text = "Tipo"
        '
        'HorarioL1
        '
        Me.HorarioL1.AutoSize = True
        Me.HorarioL1.Location = New System.Drawing.Point(6, 71)
        Me.HorarioL1.Name = "HorarioL1"
        Me.HorarioL1.Size = New System.Drawing.Size(41, 13)
        Me.HorarioL1.TabIndex = 3
        Me.HorarioL1.Text = "Horario"
        '
        'FechaL1
        '
        Me.FechaL1.AutoSize = True
        Me.FechaL1.Location = New System.Drawing.Point(6, 38)
        Me.FechaL1.Name = "FechaL1"
        Me.FechaL1.Size = New System.Drawing.Size(37, 13)
        Me.FechaL1.TabIndex = 2
        Me.FechaL1.Text = "Fecha"
        '
        'ID_PacienteL1
        '
        Me.ID_PacienteL1.AutoSize = True
        Me.ID_PacienteL1.Location = New System.Drawing.Point(6, 6)
        Me.ID_PacienteL1.Name = "ID_PacienteL1"
        Me.ID_PacienteL1.Size = New System.Drawing.Size(62, 13)
        Me.ID_PacienteL1.TabIndex = 1
        Me.ID_PacienteL1.Text = "ID paciente"
        '
        'Eliminar
        '
        Me.Eliminar.Controls.Add(Me.Confirmar_Boton2)
        Me.Eliminar.Controls.Add(Me.Tipo_T2)
        Me.Eliminar.Controls.Add(Me.Horario_T2)
        Me.Eliminar.Controls.Add(Me.Fecha_T2)
        Me.Eliminar.Controls.Add(Me.ID_paciente_T2)
        Me.Eliminar.Controls.Add(Me.ID_Turno_T1)
        Me.Eliminar.Controls.Add(Me.TipoL2)
        Me.Eliminar.Controls.Add(Me.HorarioL2)
        Me.Eliminar.Controls.Add(Me.FechaL2)
        Me.Eliminar.Controls.Add(Me.ID_PacienteL2)
        Me.Eliminar.Controls.Add(Me.ID_TurnoL1)
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
        'Confirmar_Boton2
        '
        Me.Confirmar_Boton2.Location = New System.Drawing.Point(180, 270)
        Me.Confirmar_Boton2.Name = "Confirmar_Boton2"
        Me.Confirmar_Boton2.Size = New System.Drawing.Size(75, 23)
        Me.Confirmar_Boton2.TabIndex = 21
        Me.Confirmar_Boton2.Text = "&Confirmar"
        Me.Confirmar_Boton2.UseVisualStyleBackColor = True
        '
        'Tipo_T2
        '
        Me.Tipo_T2.Location = New System.Drawing.Point(118, 139)
        Me.Tipo_T2.Name = "Tipo_T2"
        Me.Tipo_T2.Size = New System.Drawing.Size(137, 20)
        Me.Tipo_T2.TabIndex = 20
        '
        'Horario_T2
        '
        Me.Horario_T2.Location = New System.Drawing.Point(118, 103)
        Me.Horario_T2.Name = "Horario_T2"
        Me.Horario_T2.Size = New System.Drawing.Size(137, 20)
        Me.Horario_T2.TabIndex = 19
        '
        'Fecha_T2
        '
        Me.Fecha_T2.Location = New System.Drawing.Point(118, 66)
        Me.Fecha_T2.Name = "Fecha_T2"
        Me.Fecha_T2.Size = New System.Drawing.Size(137, 20)
        Me.Fecha_T2.TabIndex = 18
        '
        'ID_paciente_T2
        '
        Me.ID_paciente_T2.Location = New System.Drawing.Point(118, 34)
        Me.ID_paciente_T2.Name = "ID_paciente_T2"
        Me.ID_paciente_T2.Size = New System.Drawing.Size(137, 20)
        Me.ID_paciente_T2.TabIndex = 17
        '
        'ID_Turno_T1
        '
        Me.ID_Turno_T1.Location = New System.Drawing.Point(118, 3)
        Me.ID_Turno_T1.Name = "ID_Turno_T1"
        Me.ID_Turno_T1.Size = New System.Drawing.Size(137, 20)
        Me.ID_Turno_T1.TabIndex = 16
        '
        'TipoL2
        '
        Me.TipoL2.AutoSize = True
        Me.TipoL2.Location = New System.Drawing.Point(6, 142)
        Me.TipoL2.Name = "TipoL2"
        Me.TipoL2.Size = New System.Drawing.Size(28, 13)
        Me.TipoL2.TabIndex = 15
        Me.TipoL2.Text = "Tipo"
        '
        'HorarioL2
        '
        Me.HorarioL2.AutoSize = True
        Me.HorarioL2.Location = New System.Drawing.Point(6, 106)
        Me.HorarioL2.Name = "HorarioL2"
        Me.HorarioL2.Size = New System.Drawing.Size(41, 13)
        Me.HorarioL2.TabIndex = 14
        Me.HorarioL2.Text = "Horario"
        '
        'FechaL2
        '
        Me.FechaL2.AutoSize = True
        Me.FechaL2.Location = New System.Drawing.Point(6, 69)
        Me.FechaL2.Name = "FechaL2"
        Me.FechaL2.Size = New System.Drawing.Size(37, 13)
        Me.FechaL2.TabIndex = 13
        Me.FechaL2.Text = "Fecha"
        '
        'ID_PacienteL2
        '
        Me.ID_PacienteL2.AutoSize = True
        Me.ID_PacienteL2.Location = New System.Drawing.Point(6, 37)
        Me.ID_PacienteL2.Name = "ID_PacienteL2"
        Me.ID_PacienteL2.Size = New System.Drawing.Size(62, 13)
        Me.ID_PacienteL2.TabIndex = 12
        Me.ID_PacienteL2.Text = "ID paciente"
        '
        'ID_TurnoL1
        '
        Me.ID_TurnoL1.AutoSize = True
        Me.ID_TurnoL1.Location = New System.Drawing.Point(6, 6)
        Me.ID_TurnoL1.Name = "ID_TurnoL1"
        Me.ID_TurnoL1.Size = New System.Drawing.Size(43, 13)
        Me.ID_TurnoL1.TabIndex = 11
        Me.ID_TurnoL1.Text = "Id turno"
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
        Me.Buscar.Controls.Add(Me.Confirmar_Boton3)
        Me.Buscar.Controls.Add(Me.Tipo_T3)
        Me.Buscar.Controls.Add(Me.Horario_T3)
        Me.Buscar.Controls.Add(Me.Fecha_T3)
        Me.Buscar.Controls.Add(Me.ID_Paciente_T3)
        Me.Buscar.Controls.Add(Me.ID_Turno_T2)
        Me.Buscar.Controls.Add(Me.TipoL3)
        Me.Buscar.Controls.Add(Me.HorarioL3)
        Me.Buscar.Controls.Add(Me.FechaL3)
        Me.Buscar.Controls.Add(Me.ID_PacienteL3)
        Me.Buscar.Controls.Add(Me.ID_TurnoL2)
        Me.Buscar.Location = New System.Drawing.Point(4, 22)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(262, 306)
        Me.Buscar.TabIndex = 3
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Confirmar_Boton3
        '
        Me.Confirmar_Boton3.Location = New System.Drawing.Point(180, 270)
        Me.Confirmar_Boton3.Name = "Confirmar_Boton3"
        Me.Confirmar_Boton3.Size = New System.Drawing.Size(75, 23)
        Me.Confirmar_Boton3.TabIndex = 21
        Me.Confirmar_Boton3.Text = "&Confirmar"
        Me.Confirmar_Boton3.UseVisualStyleBackColor = True
        '
        'Tipo_T3
        '
        Me.Tipo_T3.Location = New System.Drawing.Point(118, 139)
        Me.Tipo_T3.Name = "Tipo_T3"
        Me.Tipo_T3.Size = New System.Drawing.Size(137, 20)
        Me.Tipo_T3.TabIndex = 20
        '
        'Horario_T3
        '
        Me.Horario_T3.Location = New System.Drawing.Point(118, 103)
        Me.Horario_T3.Name = "Horario_T3"
        Me.Horario_T3.Size = New System.Drawing.Size(137, 20)
        Me.Horario_T3.TabIndex = 19
        '
        'Fecha_T3
        '
        Me.Fecha_T3.Location = New System.Drawing.Point(118, 66)
        Me.Fecha_T3.Name = "Fecha_T3"
        Me.Fecha_T3.Size = New System.Drawing.Size(137, 20)
        Me.Fecha_T3.TabIndex = 18
        '
        'ID_Paciente_T3
        '
        Me.ID_Paciente_T3.Location = New System.Drawing.Point(118, 34)
        Me.ID_Paciente_T3.Name = "ID_Paciente_T3"
        Me.ID_Paciente_T3.Size = New System.Drawing.Size(137, 20)
        Me.ID_Paciente_T3.TabIndex = 17
        '
        'ID_Turno_T2
        '
        Me.ID_Turno_T2.Location = New System.Drawing.Point(118, 3)
        Me.ID_Turno_T2.Name = "ID_Turno_T2"
        Me.ID_Turno_T2.Size = New System.Drawing.Size(137, 20)
        Me.ID_Turno_T2.TabIndex = 16
        '
        'TipoL3
        '
        Me.TipoL3.AutoSize = True
        Me.TipoL3.Location = New System.Drawing.Point(6, 142)
        Me.TipoL3.Name = "TipoL3"
        Me.TipoL3.Size = New System.Drawing.Size(28, 13)
        Me.TipoL3.TabIndex = 15
        Me.TipoL3.Text = "Tipo"
        '
        'HorarioL3
        '
        Me.HorarioL3.AutoSize = True
        Me.HorarioL3.Location = New System.Drawing.Point(6, 106)
        Me.HorarioL3.Name = "HorarioL3"
        Me.HorarioL3.Size = New System.Drawing.Size(41, 13)
        Me.HorarioL3.TabIndex = 14
        Me.HorarioL3.Text = "Horario"
        '
        'FechaL3
        '
        Me.FechaL3.AutoSize = True
        Me.FechaL3.Location = New System.Drawing.Point(6, 69)
        Me.FechaL3.Name = "FechaL3"
        Me.FechaL3.Size = New System.Drawing.Size(37, 13)
        Me.FechaL3.TabIndex = 13
        Me.FechaL3.Text = "Fecha"
        '
        'ID_PacienteL3
        '
        Me.ID_PacienteL3.AutoSize = True
        Me.ID_PacienteL3.Location = New System.Drawing.Point(6, 37)
        Me.ID_PacienteL3.Name = "ID_PacienteL3"
        Me.ID_PacienteL3.Size = New System.Drawing.Size(62, 13)
        Me.ID_PacienteL3.TabIndex = 12
        Me.ID_PacienteL3.Text = "ID paciente"
        '
        'ID_TurnoL2
        '
        Me.ID_TurnoL2.AutoSize = True
        Me.ID_TurnoL2.Location = New System.Drawing.Point(6, 6)
        Me.ID_TurnoL2.Name = "ID_TurnoL2"
        Me.ID_TurnoL2.Size = New System.Drawing.Size(43, 13)
        Me.ID_TurnoL2.TabIndex = 11
        Me.ID_TurnoL2.Text = "Id turno"
        '
        'Ej1
        '
        Me.Ej1.Image = CType(resources.GetObject("Ej1.Image"), System.Drawing.Image)
        Me.Ej1.Location = New System.Drawing.Point(1, 3)
        Me.Ej1.Name = "Ej1"
        Me.Ej1.Size = New System.Drawing.Size(480, 237)
        Me.Ej1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ej1.TabIndex = 2
        Me.Ej1.TabStop = False
        '
        'Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(756, 325)
        Me.Controls.Add(Me.Ej1)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Turnos"
        Me.Text = "Form3"
        Me.TabControl1.ResumeLayout(False)
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Agregar As System.Windows.Forms.TabPage
    Friend WithEvents Eliminar As System.Windows.Forms.TabPage
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Buscar As System.Windows.Forms.TabPage
    Friend WithEvents Tipo_T1 As System.Windows.Forms.TextBox
    Friend WithEvents Horario_T1 As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_T1 As System.Windows.Forms.TextBox
    Friend WithEvents ID_Paciente_T1 As System.Windows.Forms.TextBox
    Friend WithEvents TipoL1 As System.Windows.Forms.Label
    Friend WithEvents HorarioL1 As System.Windows.Forms.Label
    Friend WithEvents FechaL1 As System.Windows.Forms.Label
    Friend WithEvents ID_PacienteL1 As System.Windows.Forms.Label
    Friend WithEvents Tipo_T2 As System.Windows.Forms.TextBox
    Friend WithEvents Horario_T2 As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_T2 As System.Windows.Forms.TextBox
    Friend WithEvents ID_paciente_T2 As System.Windows.Forms.TextBox
    Friend WithEvents ID_Turno_T1 As System.Windows.Forms.TextBox
    Friend WithEvents TipoL2 As System.Windows.Forms.Label
    Friend WithEvents HorarioL2 As System.Windows.Forms.Label
    Friend WithEvents FechaL2 As System.Windows.Forms.Label
    Friend WithEvents ID_PacienteL2 As System.Windows.Forms.Label
    Friend WithEvents ID_TurnoL1 As System.Windows.Forms.Label
    Friend WithEvents Tipo_T3 As System.Windows.Forms.TextBox
    Friend WithEvents Horario_T3 As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_T3 As System.Windows.Forms.TextBox
    Friend WithEvents ID_Paciente_T3 As System.Windows.Forms.TextBox
    Friend WithEvents ID_Turno_T2 As System.Windows.Forms.TextBox
    Friend WithEvents TipoL3 As System.Windows.Forms.Label
    Friend WithEvents HorarioL3 As System.Windows.Forms.Label
    Friend WithEvents FechaL3 As System.Windows.Forms.Label
    Friend WithEvents ID_PacienteL3 As System.Windows.Forms.Label
    Friend WithEvents ID_TurnoL2 As System.Windows.Forms.Label
    Friend WithEvents Confirmar_Boton1 As System.Windows.Forms.Button
    Friend WithEvents Confirmar_Boton2 As System.Windows.Forms.Button
    Friend WithEvents Confirmar_Boton3 As System.Windows.Forms.Button
    Friend WithEvents Ej1 As System.Windows.Forms.PictureBox
End Class
