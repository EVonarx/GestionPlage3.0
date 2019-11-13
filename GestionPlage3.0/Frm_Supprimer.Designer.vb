<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Supprimer
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
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.CB_Selection = New System.Windows.Forms.ComboBox()
        Me.Lbl_Titre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Supprimer.Location = New System.Drawing.Point(432, 249)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(120, 67)
        Me.Btn_Supprimer.TabIndex = 1
        Me.Btn_Supprimer.Text = "Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.Location = New System.Drawing.Point(266, 249)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(120, 67)
        Me.Btn_Annuler.TabIndex = 2
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'CB_Selection
        '
        Me.CB_Selection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Selection.FormattingEnabled = True
        Me.CB_Selection.Location = New System.Drawing.Point(267, 119)
        Me.CB_Selection.Name = "CB_Selection"
        Me.CB_Selection.Size = New System.Drawing.Size(272, 32)
        Me.CB_Selection.TabIndex = 3
        '
        'Lbl_Titre
        '
        Me.Lbl_Titre.AutoSize = True
        Me.Lbl_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titre.Location = New System.Drawing.Point(262, 61)
        Me.Lbl_Titre.Name = "Lbl_Titre"
        Me.Lbl_Titre.Size = New System.Drawing.Size(277, 24)
        Me.Lbl_Titre.TabIndex = 4
        Me.Lbl_Titre.Text = "Choississez le nom à supprimer"
        '
        'Frm_Supprimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Titre)
        Me.Controls.Add(Me.CB_Selection)
        Me.Controls.Add(Me.Btn_Annuler)
        Me.Controls.Add(Me.Btn_Supprimer)
        Me.Name = "Frm_Supprimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Supprimer As Button
    Friend WithEvents Btn_Annuler As Button
    Friend WithEvents CB_Selection As ComboBox
    Friend WithEvents Lbl_Titre As Label
End Class
