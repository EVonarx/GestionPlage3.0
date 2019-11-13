<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ajouter
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
        Me.Btn_Valider = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.TxtSaisie = New System.Windows.Forms.TextBox()
        Me.Lbl_Titre = New System.Windows.Forms.Label()
        Me.Lbl_Saisir1 = New System.Windows.Forms.Label()
        Me.Lbl_Saisir2 = New System.Windows.Forms.Label()
        Me.CB_Selection = New System.Windows.Forms.ComboBox()
        Me.Lbl_Saisir0 = New System.Windows.Forms.Label()
        Me.CB_Info = New System.Windows.Forms.ComboBox()
        Me.Lbl_InfoSupplementaire1 = New System.Windows.Forms.Label()
        Me.TxtBox_InfoSupplementaire1 = New System.Windows.Forms.TextBox()
        Me.Lbl_InfoSupplementaire2 = New System.Windows.Forms.Label()
        Me.TxtBox_InfoSupplementaire2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 736)
        Me.Panel2.TabIndex = 3
        '
        'Btn_Valider
        '
        Me.Btn_Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Valider.Location = New System.Drawing.Point(608, 572)
        Me.Btn_Valider.Name = "Btn_Valider"
        Me.Btn_Valider.Size = New System.Drawing.Size(142, 74)
        Me.Btn_Valider.TabIndex = 4
        Me.Btn_Valider.Text = "Valider"
        Me.Btn_Valider.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.Location = New System.Drawing.Point(433, 572)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(142, 74)
        Me.Btn_Annuler.TabIndex = 5
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'TxtSaisie
        '
        Me.TxtSaisie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaisie.Location = New System.Drawing.Point(599, 204)
        Me.TxtSaisie.Multiline = True
        Me.TxtSaisie.Name = "TxtSaisie"
        Me.TxtSaisie.Size = New System.Drawing.Size(273, 36)
        Me.TxtSaisie.TabIndex = 6
        '
        'Lbl_Titre
        '
        Me.Lbl_Titre.AutoSize = True
        Me.Lbl_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titre.Location = New System.Drawing.Point(456, 32)
        Me.Lbl_Titre.Name = "Lbl_Titre"
        Me.Lbl_Titre.Size = New System.Drawing.Size(119, 24)
        Me.Lbl_Titre.TabIndex = 7
        Me.Lbl_Titre.Text = "TexteDeTitre"
        '
        'Lbl_Saisir1
        '
        Me.Lbl_Saisir1.AutoSize = True
        Me.Lbl_Saisir1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Saisir1.Location = New System.Drawing.Point(250, 216)
        Me.Lbl_Saisir1.Name = "Lbl_Saisir1"
        Me.Lbl_Saisir1.Size = New System.Drawing.Size(138, 24)
        Me.Lbl_Saisir1.TabIndex = 8
        Me.Lbl_Saisir1.Text = "TexteDeLabel1"
        '
        'Lbl_Saisir2
        '
        Me.Lbl_Saisir2.AutoSize = True
        Me.Lbl_Saisir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Saisir2.Location = New System.Drawing.Point(259, 422)
        Me.Lbl_Saisir2.Name = "Lbl_Saisir2"
        Me.Lbl_Saisir2.Size = New System.Drawing.Size(138, 24)
        Me.Lbl_Saisir2.TabIndex = 10
        Me.Lbl_Saisir2.Text = "TexteDeLabel2"
        '
        'CB_Selection
        '
        Me.CB_Selection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Selection.FormattingEnabled = True
        Me.CB_Selection.Location = New System.Drawing.Point(600, 422)
        Me.CB_Selection.Name = "CB_Selection"
        Me.CB_Selection.Size = New System.Drawing.Size(272, 32)
        Me.CB_Selection.TabIndex = 11
        '
        'Lbl_Saisir0
        '
        Me.Lbl_Saisir0.AutoSize = True
        Me.Lbl_Saisir0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Saisir0.Location = New System.Drawing.Point(250, 113)
        Me.Lbl_Saisir0.Name = "Lbl_Saisir0"
        Me.Lbl_Saisir0.Size = New System.Drawing.Size(138, 24)
        Me.Lbl_Saisir0.TabIndex = 12
        Me.Lbl_Saisir0.Text = "TexteDeLabel0"
        '
        'CB_Info
        '
        Me.CB_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Info.FormattingEnabled = True
        Me.CB_Info.Location = New System.Drawing.Point(599, 105)
        Me.CB_Info.Name = "CB_Info"
        Me.CB_Info.Size = New System.Drawing.Size(272, 32)
        Me.CB_Info.TabIndex = 13
        '
        'Lbl_InfoSupplementaire1
        '
        Me.Lbl_InfoSupplementaire1.AutoSize = True
        Me.Lbl_InfoSupplementaire1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_InfoSupplementaire1.Location = New System.Drawing.Point(250, 296)
        Me.Lbl_InfoSupplementaire1.Name = "Lbl_InfoSupplementaire1"
        Me.Lbl_InfoSupplementaire1.Size = New System.Drawing.Size(111, 24)
        Me.Lbl_InfoSupplementaire1.TabIndex = 14
        Me.Lbl_InfoSupplementaire1.Text = "Code Postal"
        '
        'TxtBox_InfoSupplementaire1
        '
        Me.TxtBox_InfoSupplementaire1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_InfoSupplementaire1.Location = New System.Drawing.Point(602, 296)
        Me.TxtBox_InfoSupplementaire1.Name = "TxtBox_InfoSupplementaire1"
        Me.TxtBox_InfoSupplementaire1.Size = New System.Drawing.Size(270, 29)
        Me.TxtBox_InfoSupplementaire1.TabIndex = 15
        '
        'Lbl_InfoSupplementaire2
        '
        Me.Lbl_InfoSupplementaire2.AutoSize = True
        Me.Lbl_InfoSupplementaire2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_InfoSupplementaire2.Location = New System.Drawing.Point(250, 359)
        Me.Lbl_InfoSupplementaire2.Name = "Lbl_InfoSupplementaire2"
        Me.Lbl_InfoSupplementaire2.Size = New System.Drawing.Size(238, 24)
        Me.Lbl_InfoSupplementaire2.TabIndex = 16
        Me.Lbl_InfoSupplementaire2.Text = "Nombre de touristes par an"
        '
        'TxtBox_InfoSupplementaire2
        '
        Me.TxtBox_InfoSupplementaire2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox_InfoSupplementaire2.Location = New System.Drawing.Point(636, 359)
        Me.TxtBox_InfoSupplementaire2.Name = "TxtBox_InfoSupplementaire2"
        Me.TxtBox_InfoSupplementaire2.Size = New System.Drawing.Size(236, 29)
        Me.TxtBox_InfoSupplementaire2.TabIndex = 17
        '
        'Frm_Ajouter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 749)
        Me.Controls.Add(Me.TxtBox_InfoSupplementaire2)
        Me.Controls.Add(Me.Lbl_InfoSupplementaire2)
        Me.Controls.Add(Me.TxtBox_InfoSupplementaire1)
        Me.Controls.Add(Me.Lbl_InfoSupplementaire1)
        Me.Controls.Add(Me.CB_Info)
        Me.Controls.Add(Me.Lbl_Saisir0)
        Me.Controls.Add(Me.CB_Selection)
        Me.Controls.Add(Me.Lbl_Saisir2)
        Me.Controls.Add(Me.Lbl_Saisir1)
        Me.Controls.Add(Me.Lbl_Titre)
        Me.Controls.Add(Me.TxtSaisie)
        Me.Controls.Add(Me.Btn_Annuler)
        Me.Controls.Add(Me.Btn_Valider)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Ajouter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_Valider As Button
    Friend WithEvents Btn_Annuler As Button
    Friend WithEvents TxtSaisie As TextBox
    Friend WithEvents Lbl_Titre As Label
    Friend WithEvents Lbl_Saisir1 As Label
    Friend WithEvents Lbl_Saisir2 As Label
    Friend WithEvents CB_Selection As ComboBox
    Friend WithEvents Lbl_Saisir0 As Label
    Friend WithEvents CB_Info As ComboBox
    Friend WithEvents Lbl_InfoSupplementaire1 As Label
    Friend WithEvents TxtBox_InfoSupplementaire1 As TextBox
    Friend WithEvents Lbl_InfoSupplementaire2 As Label
    Friend WithEvents TxtBox_InfoSupplementaire2 As TextBox
End Class
