<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Start
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.Btn_CreerSupprimer = New System.Windows.Forms.Button()
        Me.Btn_NatureTerrain = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btn_Quitter)
        Me.Panel1.Controls.Add(Me.Btn_CreerSupprimer)
        Me.Panel1.Controls.Add(Me.Btn_NatureTerrain)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 650)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Quitter.Location = New System.Drawing.Point(18, 515)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(164, 83)
        Me.Btn_Quitter.TabIndex = 4
        Me.Btn_Quitter.Text = "Quitter"
        Me.Btn_Quitter.UseVisualStyleBackColor = True
        '
        'Btn_CreerSupprimer
        '
        Me.Btn_CreerSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreerSupprimer.Location = New System.Drawing.Point(18, 402)
        Me.Btn_CreerSupprimer.Name = "Btn_CreerSupprimer"
        Me.Btn_CreerSupprimer.Size = New System.Drawing.Size(164, 87)
        Me.Btn_CreerSupprimer.TabIndex = 3
        Me.Btn_CreerSupprimer.Text = "Créer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Supprimer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Associer"
        Me.Btn_CreerSupprimer.UseVisualStyleBackColor = True
        '
        'Btn_NatureTerrain
        '
        Me.Btn_NatureTerrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NatureTerrain.Location = New System.Drawing.Point(18, 244)
        Me.Btn_NatureTerrain.Name = "Btn_NatureTerrain"
        Me.Btn_NatureTerrain.Size = New System.Drawing.Size(164, 83)
        Me.Btn_NatureTerrain.TabIndex = 2
        Me.Btn_NatureTerrain.Text = "Natures terrain"
        Me.Btn_NatureTerrain.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(18, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 78)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Plages"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 82)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Responsables"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 124)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "       APPLICATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GESTION DES PLAGES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       VERSION 3.0 "
        '
        'Frm_Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 661)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion Plage 3.0"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_NatureTerrain As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Btn_CreerSupprimer As Button
    Friend WithEvents Btn_Quitter As Button
    Friend WithEvents Label1 As Label
End Class
