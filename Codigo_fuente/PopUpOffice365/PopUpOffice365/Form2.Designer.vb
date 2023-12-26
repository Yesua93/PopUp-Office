<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        tmrcarga = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 15)
        Label1.TabIndex = 0
        Label1.Text = "Espereu mentre carrega l'instal·lador d'office 365."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 15)
        Label2.TabIndex = 1
        Label2.Text = "Esperad mientras cargamos el instalador de Office 365."
        ' 
        ' tmrcarga
        ' 
        tmrcarga.Enabled = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(316, 78)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Location = New Point(0, 10000)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        Text = "Office 365"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrcarga As Timer
End Class
