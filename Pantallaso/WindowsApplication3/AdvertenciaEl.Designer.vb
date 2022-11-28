<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvertenciaEl
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
        Me.Boton = New System.Windows.Forms.Button()
        Me.AdverT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(88, 121)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 0
        Me.Boton.Text = "&OK"
        Me.Boton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Boton.UseVisualStyleBackColor = True
        '
        'AdverT
        '
        Me.AdverT.AutoSize = True
        Me.AdverT.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.AdverT.Location = New System.Drawing.Point(23, 38)
        Me.AdverT.Name = "AdverT"
        Me.AdverT.Size = New System.Drawing.Size(206, 14)
        Me.AdverT.TabIndex = 1
        Me.AdverT.Text = "Tiene que colocar almenos 2 condiciones"
        '
        'AdvertenciaEl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 169)
        Me.Controls.Add(Me.AdverT)
        Me.Controls.Add(Me.Boton)
        Me.Name = "AdvertenciaEl"
        Me.Text = "Advertencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Boton As System.Windows.Forms.Button
    Friend WithEvents AdverT As System.Windows.Forms.Label
End Class
