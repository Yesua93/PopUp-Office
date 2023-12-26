Imports System.DirectoryServices
Imports System.IO
Imports System.Linq.Expressions
Imports System.Reflection.Emit
Imports System.Reflection.Metadata
Imports System.Reflection.Metadata.Ecma335
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    'Variable para el tiempo que da antes de pulsar automáticamente el botón de continuar.
    Dim temp As Integer = 60
    Dim ruta2 As String = "C:\Program Files\Microsoft Office\root\Office16\WINWORD.exe"
    Dim temdect As Integer = 600

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim ruta As String = "setup.exe"
        If System.IO.File.Exists(ruta) Then
            '''Process.Start(ruta & " /configure configFLC_Uninstall.xml")
            Shell("setup.exe /configure configFLC_Uninstall.xml")
            tmrDetector.Enabled = True
            Me.WindowState = FormWindowState.Minimized
            '''Me.Close()
        Else
            If lblidioma.Text = "CAST" Then
                MessageBox.Show("No s'ha trobat l'arxiu d'instal·lació.")
            Else
                MessageBox.Show("No se ha encontrado el archivo de instalación.")
            End If
            End
        End If
        tmrTemp.Enabled = False
        pbrtemp.Visible = False
        lbltemp.Visible = False
        btnAceptar.Visible = False
        btnCancelar.Visible = False
        lblidioma.Visible = False
        Me.Height = btnpos.Top

        If lblidioma.Text = "CAST" Then
            lbltitulo.Text = "Instal·lació en curs."
            lbltext1.Text = "La instal·lació està en curs, si us plau, no tanqui aquesta finestra."
            lbltext2.Text = "La finestra es tancarà automàticament durant el procés."
            lbltext3.Text = ""
        Else
            lbltitulo.Text = "Instalación en curso."
            lbltext1.Text = "La instalación está en proceso, por favor, no cierre esta ventana."
            lbltext2.Text = "La ventana se cerrará automáticamente durante el proceso."
            lbltext3.Text = ""
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Al pulsar Cancelar, cierra el programa.
        Me.Close()
    End Sub
    Private Sub tmrTemp_Tick(sender As Object, e As EventArgs) Handles tmrTemp.Tick
        Me.BringToFront()
        Me.WindowState = FormWindowState.Normal
        'Pone el valor de la barra de progreso con el valor de temp.
        pbrtemp.Value = temp
        'Modifica el texto para indicar el tiempo restante (según idioma).
        If lblidioma.Text = "CAST" Then
            lbltemp.Text = "La instal·lació començarà automàticament en " & temp & " segons."
        Else
            lbltemp.Text = "La instalación empezará automáticamente en " & temp & " segundos."
        End If
        'Si el tiempo llega a 0, pulsa Aceptar y para el timer.
        If temp = 0 Then
            tmrTemp.Enabled = False
            btnAceptar.PerformClick()
        End If
        'Resta 1 a temp.
        temp = temp - 1
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Establece el valor máximo con la variable temp, para que tenga el tamaño el tiempo configurado
        Form2.Visible = False
        pbrtemp.Maximum = temp
        lbltemp.Text = "La instal·lació començarà automàticament en " & temp & " segons."
        Me.BringToFront()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub lblidioma_Click(sender As Object, e As EventArgs) Handles lblidioma.Click
        'Según se pulse la etiqueta, alterna entre idiomas.
        If lblidioma.Text = "CAST" Then
            lblidioma.Text = "CAT"
            'Idioma en castellano
            Me.Text = "Instalación de Office 365"
            lbltitulo.Text = "Aviso importante:"
            lbltext1.Text = "La instalación de Office 365 puede durar entre 30 y 60 minutos."
            lbltext2.Text = "Durante el proceso, no se podrá utilizar ninguna aplicación de la suite Office (Outlook, Word, etc.)."
            lbltext3.Text = "Si quiere seguir con la instalación, pulse el botón 'Continuar'. En caso contrario puede retomar la instalación cuando lo desee."
            btnAceptar.Text = "Continuar"
            btnCancelar.Text = "Cancelar"
            lbltemp.Text = "La instalación empezará automáticamente en " & temp & " segundos."
        Else
            lblidioma.Text = "CAST"
            'Idioma en català
            Me.Text = "Instal·lació d'Office 365"
            lbltitulo.Text = "Avís important:"
            lbltext1.Text = "La instal·lació d'Office 365 pot durar entre 30 i 60 minuts."
            lbltext2.Text = "En aquest temps, no es podrà utilitzar cap aplicació de la suite Office (Outlook, Word, etc.)."
            lbltext3.Text = "Si voleu seguir amb la instal·lació, premeu el botó 'Continuar'. En cas contrari podeu reprendre la instal·lació quan ho desitjeu."
            btnAceptar.Text = "Continuar"
            btnCancelar.Text = "Cancel·lar"
            lbltemp.Text = "La instal·lació començarà automàticament en " & temp & " segons."
        End If
    End Sub

    Private Sub tmrDetector_Tick(sender As Object, e As EventArgs) Handles tmrDetector.Tick
        If System.IO.File.Exists(ruta2) Then
            '''Aún no se ha desinstalado el Office

        Else
            '''Se ha desinstalado el Office
            '''
            temdect = temdect - 1
            If temdect = 0 Then
                Try
                    Dim ruta As String = "C:\temp\popupoffice.ini"
                    Dim escritor As StreamWriter
                    escritor = File.AppendText(ruta)
                    escritor.Write("Desinstalar")
                    escritor.Flush()
                    escritor.Close()
                    Me.Close()
                    End
                    'Si encuentra un error al crear el archivo, muestra un mensaje.
                Catch ex As Exception
                    If lblidioma.Text = "CAST" Then
                        MessageBox.Show("S'ha trobat un problema, contacti amb el servei de plataforma.")
                    Else
                        MessageBox.Show("Se ha encontrado un problema, contacte con el servicio de plataforma.")
                    End If
                End Try
                Me.Close()
            End If
        End If
    End Sub


End Class
