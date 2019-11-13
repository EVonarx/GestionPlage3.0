<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.TxtPasswd = New System.Windows.Forms.TextBox()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 650)
        Me.Panel2.TabIndex = 3
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.Location = New System.Drawing.Point(431, 248)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(62, 24)
        Me.LblLogin.TabIndex = 4
        Me.LblLogin.Text = "Login"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(431, 325)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(100, 24)
        Me.LblPassword.TabIndex = 5
        Me.LblPassword.Text = "Password"
        '
        'TxtLogin
        '
        Me.TxtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLogin.Location = New System.Drawing.Point(571, 248)
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(189, 29)
        Me.TxtLogin.TabIndex = 6
        '
        'TxtPasswd
        '
        Me.TxtPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswd.Location = New System.Drawing.Point(571, 320)
        Me.TxtPasswd.Name = "TxtPasswd"
        Me.TxtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswd.Size = New System.Drawing.Size(189, 29)
        Me.TxtPasswd.TabIndex = 7
        Me.TxtPasswd.UseSystemPasswordChar = True
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.Location = New System.Drawing.Point(349, 75)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(217, 31)
        Me.LblTitre.TabIndex = 8
        Me.LblTitre.Text = "Authentification"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(775, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 55)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(431, 399)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(366, 48)
        Me.LblError.TabIndex = 10
        Me.LblError.Text = "Erreur d'authentification " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Veuillez saisir vos identifiants correctement"
        Me.LblError.Visible = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 749)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.TxtPasswd)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Login"
        Me.Text = "Frm_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblLogin As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents TxtPasswd As TextBox
    Friend WithEvents LblTitre As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LblError As Label
End Class
