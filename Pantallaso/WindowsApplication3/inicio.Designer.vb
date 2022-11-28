<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Boton_Turnos = New System.Windows.Forms.Button()
        Me.Boton_clientes = New System.Windows.Forms.Button()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.ErrorImage = CType(resources.GetObject("Logo.ErrorImage"), System.Drawing.Image)
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(156, 36)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(195, 181)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Boton_Turnos
        '
        Me.Boton_Turnos.BackColor = System.Drawing.Color.SteelBlue
        Me.Boton_Turnos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Boton_Turnos.Location = New System.Drawing.Point(12, 255)
        Me.Boton_Turnos.Name = "Boton_Turnos"
        Me.Boton_Turnos.Size = New System.Drawing.Size(102, 38)
        Me.Boton_Turnos.TabIndex = 1
        Me.Boton_Turnos.Text = "Turnos"
        Me.Boton_Turnos.UseVisualStyleBackColor = False
        '
        'Boton_clientes
        '
        Me.Boton_clientes.BackColor = System.Drawing.Color.SteelBlue
        Me.Boton_clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Boton_clientes.Location = New System.Drawing.Point(401, 255)
        Me.Boton_clientes.Name = "Boton_clientes"
        Me.Boton_clientes.Size = New System.Drawing.Size(102, 38)
        Me.Boton_clientes.TabIndex = 2
        Me.Boton_clientes.Text = "Clientes"
        Me.Boton_clientes.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(515, 347)
        Me.Controls.Add(Me.Boton_clientes)
        Me.Controls.Add(Me.Boton_Turnos)
        Me.Controls.Add(Me.Logo)
        Me.Name = "Form1"
        Me.Text = "Bienvenido"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Boton_Turnos As System.Windows.Forms.Button
    Friend WithEvents Boton_clientes As System.Windows.Forms.Button

End Class
