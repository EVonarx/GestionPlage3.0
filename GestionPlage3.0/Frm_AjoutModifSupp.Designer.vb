<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AjoutModifSupp
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
        Me.Btn_CreerResponsable = New System.Windows.Forms.Button()
        Me.Btn_CreerRegion = New System.Windows.Forms.Button()
        Me.Btn_CreerDepartement = New System.Windows.Forms.Button()
        Me.Btn_CreerVille = New System.Windows.Forms.Button()
        Me.Btn_CreerPlage = New System.Windows.Forms.Button()
        Me.Btn_CreerNature = New System.Windows.Forms.Button()
        Me.Btn_AssocierResponsableRegion = New System.Windows.Forms.Button()
        Me.Btn_RetourMenu = New System.Windows.Forms.Button()
        Me.Btn_SuppResp = New System.Windows.Forms.Button()
        Me.Btn_SuppRegion = New System.Windows.Forms.Button()
        Me.Btn_SuppDepart = New System.Windows.Forms.Button()
        Me.Btn_SuppVille = New System.Windows.Forms.Button()
        Me.Btn_SuppPlage = New System.Windows.Forms.Button()
        Me.Btn_SuppNatTerrain = New System.Windows.Forms.Button()
        Me.Btn_AssocierPlageNatureTerrain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_CreerResponsable
        '
        Me.Btn_CreerResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreerResponsable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CreerResponsable.Location = New System.Drawing.Point(51, 12)
        Me.Btn_CreerResponsable.Name = "Btn_CreerResponsable"
        Me.Btn_CreerResponsable.Size = New System.Drawing.Size(140, 51)
        Me.Btn_CreerResponsable.TabIndex = 9
        Me.Btn_CreerResponsable.Text = "Créer Responsable"
        Me.Btn_CreerResponsable.UseVisualStyleBackColor = True
        '
        'Btn_CreerRegion
        '
        Me.Btn_CreerRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreerRegion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CreerRegion.Location = New System.Drawing.Point(51, 75)
        Me.Btn_CreerRegion.Name = "Btn_CreerRegion"
        Me.Btn_CreerRegion.Size = New System.Drawing.Size(140, 56)
        Me.Btn_CreerRegion.TabIndex = 10
        Me.Btn_CreerRegion.Text = "Créer Région"
        Me.Btn_CreerRegion.UseVisualStyleBackColor = True
        '
        'Btn_CreerDepartement
        '
        Me.Btn_CreerDepartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreerDepartement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CreerDepartement.Location = New System.Drawing.Point(51, 149)
        Me.Btn_CreerDepartement.Name = "Btn_CreerDepartement"
        Me.Btn_CreerDepartement.Size = New System.Drawing.Size(140, 56)
        Me.Btn_CreerDepartement.TabIndex = 11
        Me.Btn_CreerDepartement.Text = "Créer Département"
        Me.Btn_CreerDepartement.UseVisualStyleBackColor = True
        '
        'Btn_CreerVille
        '
        Me.Btn_CreerVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreerVille.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CreerVille.Location = New System.Drawing.Point(51, 223)
        Me.Btn_CreerVille.Name = "Btn_CreerVille"
        Me.Btn_CreerVille.Size = New System.Drawing.Size(140, 56)
        Me.Btn_CreerVille.TabIndex = 12
        Me.Btn_CreerVille.Text = "Créer Ville"
        Me.Btn_CreerVille.UseVisualStyleBackColor = True
        '
        'Btn_CreerPlage
        '
        Me.Btn_CreerPlage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreerPlage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CreerPlage.Location = New System.Drawing.Point(51, 302)
        Me.Btn_CreerPlage.Name = "Btn_CreerPlage"
        Me.Btn_CreerPlage.Size = New System.Drawing.Size(140, 56)
        Me.Btn_CreerPlage.TabIndex = 13
        Me.Btn_CreerPlage.Text = "Créer Plage"
        Me.Btn_CreerPlage.UseVisualStyleBackColor = True
        '
        'Btn_CreerNature
        '
        Me.Btn_CreerNature.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreerNature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_CreerNature.Location = New System.Drawing.Point(51, 372)
        Me.Btn_CreerNature.Name = "Btn_CreerNature"
        Me.Btn_CreerNature.Size = New System.Drawing.Size(140, 56)
        Me.Btn_CreerNature.TabIndex = 14
        Me.Btn_CreerNature.Text = "Créer Nature Terrain"
        Me.Btn_CreerNature.UseVisualStyleBackColor = True
        '
        'Btn_AssocierResponsableRegion
        '
        Me.Btn_AssocierResponsableRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AssocierResponsableRegion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_AssocierResponsableRegion.Location = New System.Drawing.Point(216, 29)
        Me.Btn_AssocierResponsableRegion.Name = "Btn_AssocierResponsableRegion"
        Me.Btn_AssocierResponsableRegion.Size = New System.Drawing.Size(132, 92)
        Me.Btn_AssocierResponsableRegion.TabIndex = 15
        Me.Btn_AssocierResponsableRegion.Text = "Associer Responsable/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Region"
        Me.Btn_AssocierResponsableRegion.UseVisualStyleBackColor = True
        '
        'Btn_RetourMenu
        '
        Me.Btn_RetourMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RetourMenu.Location = New System.Drawing.Point(697, 198)
        Me.Btn_RetourMenu.Name = "Btn_RetourMenu"
        Me.Btn_RetourMenu.Size = New System.Drawing.Size(152, 57)
        Me.Btn_RetourMenu.TabIndex = 21
        Me.Btn_RetourMenu.Text = "Retour Menu"
        Me.Btn_RetourMenu.UseVisualStyleBackColor = True
        '
        'Btn_SuppResp
        '
        Me.Btn_SuppResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SuppResp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SuppResp.Location = New System.Drawing.Point(471, 377)
        Me.Btn_SuppResp.Name = "Btn_SuppResp"
        Me.Btn_SuppResp.Size = New System.Drawing.Size(140, 51)
        Me.Btn_SuppResp.TabIndex = 22
        Me.Btn_SuppResp.Text = "Supprimer Responsable"
        Me.Btn_SuppResp.UseVisualStyleBackColor = True
        '
        'Btn_SuppRegion
        '
        Me.Btn_SuppRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SuppRegion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SuppRegion.Location = New System.Drawing.Point(471, 305)
        Me.Btn_SuppRegion.Name = "Btn_SuppRegion"
        Me.Btn_SuppRegion.Size = New System.Drawing.Size(140, 51)
        Me.Btn_SuppRegion.TabIndex = 23
        Me.Btn_SuppRegion.Text = "Supprimer Région"
        Me.Btn_SuppRegion.UseVisualStyleBackColor = True
        '
        'Btn_SuppDepart
        '
        Me.Btn_SuppDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SuppDepart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SuppDepart.Location = New System.Drawing.Point(471, 223)
        Me.Btn_SuppDepart.Name = "Btn_SuppDepart"
        Me.Btn_SuppDepart.Size = New System.Drawing.Size(140, 51)
        Me.Btn_SuppDepart.TabIndex = 24
        Me.Btn_SuppDepart.Text = "Supprimer Département"
        Me.Btn_SuppDepart.UseVisualStyleBackColor = True
        '
        'Btn_SuppVille
        '
        Me.Btn_SuppVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SuppVille.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SuppVille.Location = New System.Drawing.Point(471, 154)
        Me.Btn_SuppVille.Name = "Btn_SuppVille"
        Me.Btn_SuppVille.Size = New System.Drawing.Size(140, 51)
        Me.Btn_SuppVille.TabIndex = 25
        Me.Btn_SuppVille.Text = "Supprimer Ville"
        Me.Btn_SuppVille.UseVisualStyleBackColor = True
        '
        'Btn_SuppPlage
        '
        Me.Btn_SuppPlage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SuppPlage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SuppPlage.Location = New System.Drawing.Point(471, 80)
        Me.Btn_SuppPlage.Name = "Btn_SuppPlage"
        Me.Btn_SuppPlage.Size = New System.Drawing.Size(140, 51)
        Me.Btn_SuppPlage.TabIndex = 26
        Me.Btn_SuppPlage.Text = "Supprimer Plage"
        Me.Btn_SuppPlage.UseVisualStyleBackColor = True
        '
        'Btn_SuppNatTerrain
        '
        Me.Btn_SuppNatTerrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SuppNatTerrain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_SuppNatTerrain.Location = New System.Drawing.Point(471, 12)
        Me.Btn_SuppNatTerrain.Name = "Btn_SuppNatTerrain"
        Me.Btn_SuppNatTerrain.Size = New System.Drawing.Size(140, 51)
        Me.Btn_SuppNatTerrain.TabIndex = 27
        Me.Btn_SuppNatTerrain.Text = "Supprimer Nature Terrain"
        Me.Btn_SuppNatTerrain.UseVisualStyleBackColor = True
        '
        'Btn_AssocierPlageNatureTerrain
        '
        Me.Btn_AssocierPlageNatureTerrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AssocierPlageNatureTerrain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_AssocierPlageNatureTerrain.Location = New System.Drawing.Point(216, 332)
        Me.Btn_AssocierPlageNatureTerrain.Name = "Btn_AssocierPlageNatureTerrain"
        Me.Btn_AssocierPlageNatureTerrain.Size = New System.Drawing.Size(140, 75)
        Me.Btn_AssocierPlageNatureTerrain.TabIndex = 28
        Me.Btn_AssocierPlageNatureTerrain.Text = "Associer Plage/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nature terrain"
        Me.Btn_AssocierPlageNatureTerrain.UseVisualStyleBackColor = True
        '
        'Frm_AjoutModifSupp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.Btn_AssocierPlageNatureTerrain)
        Me.Controls.Add(Me.Btn_SuppNatTerrain)
        Me.Controls.Add(Me.Btn_SuppPlage)
        Me.Controls.Add(Me.Btn_SuppVille)
        Me.Controls.Add(Me.Btn_SuppDepart)
        Me.Controls.Add(Me.Btn_SuppRegion)
        Me.Controls.Add(Me.Btn_SuppResp)
        Me.Controls.Add(Me.Btn_RetourMenu)
        Me.Controls.Add(Me.Btn_AssocierResponsableRegion)
        Me.Controls.Add(Me.Btn_CreerNature)
        Me.Controls.Add(Me.Btn_CreerPlage)
        Me.Controls.Add(Me.Btn_CreerVille)
        Me.Controls.Add(Me.Btn_CreerDepartement)
        Me.Controls.Add(Me.Btn_CreerRegion)
        Me.Controls.Add(Me.Btn_CreerResponsable)
        Me.Name = "Frm_AjoutModifSupp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion Plage 3.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_CreerResponsable As Button
    Friend WithEvents Btn_CreerRegion As Button
    Friend WithEvents Btn_CreerDepartement As Button
    Friend WithEvents Btn_CreerVille As Button
    Friend WithEvents Btn_CreerPlage As Button
    Friend WithEvents Btn_CreerNature As Button
    Friend WithEvents Btn_AssocierResponsableRegion As Button
    Friend WithEvents Btn_RetourMenu As Button
    Friend WithEvents Btn_SuppResp As Button
    Friend WithEvents Btn_SuppRegion As Button
    Friend WithEvents Btn_SuppDepart As Button
    Friend WithEvents Btn_SuppVille As Button
    Friend WithEvents Btn_SuppPlage As Button
    Friend WithEvents Btn_SuppNatTerrain As Button
    Friend WithEvents Btn_AssocierPlageNatureTerrain As Button
End Class
