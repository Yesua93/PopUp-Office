<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnAceptar = New Button()
        btnCancelar = New Button()
        lbltitulo = New Label()
        lbltext1 = New Label()
        pbrtemp = New ProgressBar()
        lbltemp = New Label()
        tmrTemp = New Timer(components)
        lbltext2 = New Label()
        lbltext3 = New Label()
        lblidioma = New Label()
        tmrDetector = New Timer(components)
        btnpos = New Button()
        SuspendLayout()
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAceptar.Location = New Point(31, 216)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(177, 60)
        btnAceptar.TabIndex = 0
        btnAceptar.Text = "Continuar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Location = New Point(224, 216)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(177, 60)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancel·lar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lbltitulo
        ' 
        lbltitulo.AutoSize = True
        lbltitulo.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbltitulo.Location = New Point(15, 12)
        lbltitulo.Name = "lbltitulo"
        lbltitulo.Size = New Size(180, 32)
        lbltitulo.TabIndex = 2
        lbltitulo.Text = "Avís important:"
        ' 
        ' lbltext1
        ' 
        lbltext1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltext1.Location = New Point(29, 51)
        lbltext1.Name = "lbltext1"
        lbltext1.Size = New Size(374, 50)
        lbltext1.TabIndex = 4
        lbltext1.Text = "La instal·lació d'Office 365 pot durar entre 30 i 60 minuts."
        ' 
        ' pbrtemp
        ' 
        pbrtemp.Location = New Point(29, 303)
        pbrtemp.MarqueeAnimationSpeed = 10
        pbrtemp.Maximum = 30
        pbrtemp.Name = "pbrtemp"
        pbrtemp.Size = New Size(374, 11)
        pbrtemp.Style = ProgressBarStyle.Continuous
        pbrtemp.TabIndex = 5
        ' 
        ' lbltemp
        ' 
        lbltemp.BackColor = Color.Transparent
        lbltemp.Location = New Point(29, 287)
        lbltemp.Name = "lbltemp"
        lbltemp.Size = New Size(374, 15)
        lbltemp.TabIndex = 6
        lbltemp.Text = "La instal·lació començarà automàticament en 60 segons."
        lbltemp.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' tmrTemp
        ' 
        tmrTemp.Enabled = True
        tmrTemp.Interval = 1000
        ' 
        ' lbltext2
        ' 
        lbltext2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltext2.Location = New Point(29, 95)
        lbltext2.Name = "lbltext2"
        lbltext2.Size = New Size(374, 55)
        lbltext2.TabIndex = 7
        lbltext2.Text = "En aquest temps, no es podrà utilitzar cap aplicació de la suite Office (Outlook, Word, etc.)."
        ' 
        ' lbltext3
        ' 
        lbltext3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltext3.Location = New Point(29, 141)
        lbltext3.Name = "lbltext3"
        lbltext3.Size = New Size(374, 63)
        lbltext3.TabIndex = 8
        lbltext3.Text = "Si voleu seguir amb la instal·lació, premeu el botó 'Continuar'. En cas contrari podeu reprendre la instal·lació quan ho desitjeu."
        ' 
        ' lblidioma
        ' 
        lblidioma.AutoSize = True
        lblidioma.Cursor = Cursors.Hand
        lblidioma.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblidioma.ForeColor = SystemColors.HotTrack
        lblidioma.Location = New Point(370, 7)
        lblidioma.Name = "lblidioma"
        lblidioma.Size = New Size(44, 19)
        lblidioma.TabIndex = 9
        lblidioma.Text = "CAST"
        lblidioma.TextAlign = ContentAlignment.TopRight
        ' 
        ' tmrDetector
        ' 
        tmrDetector.Interval = 1000
        ' 
        ' btnpos
        ' 
        btnpos.Location = New Point(2, 199)
        btnpos.Name = "btnpos"
        btnpos.Size = New Size(23, 21)
        btnpos.TabIndex = 10
        btnpos.UseVisualStyleBackColor = True
        btnpos.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancelar
        ClientSize = New Size(427, 326)
        Controls.Add(btnpos)
        Controls.Add(lblidioma)
        Controls.Add(lbltext3)
        Controls.Add(lbltext2)
        Controls.Add(lbltemp)
        Controls.Add(pbrtemp)
        Controls.Add(lbltext1)
        Controls.Add(lbltitulo)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Instal·lació d'Office 365"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents lbltext1 As Label
    Friend WithEvents pbrtemp As ProgressBar
    Friend WithEvents lbltemp As Label
    Friend WithEvents tmrTemp As Timer
    Friend WithEvents lbltext2 As Label
    Friend WithEvents lbltext3 As Label
    Friend WithEvents lblidioma As Label
    Friend WithEvents tmrDetector As Timer
    Friend WithEvents btnpos As Button
End Class
