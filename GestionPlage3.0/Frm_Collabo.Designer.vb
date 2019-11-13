<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Collabo
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Region = New System.Windows.Forms.TextBox()
        Me.CB_Name = New System.Windows.Forms.ComboBox()
        Me.Txt_Donnees = New System.Windows.Forms.TextBox()
        Me.Btn_Retour = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(302, -100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(30, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 83)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Natures terrain"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(30, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 78)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Plages"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 82)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Responsables"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 650)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "est responsable de la région :"
        '
        'Txt_Region
        '
        Me.Txt_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Region.Location = New System.Drawing.Point(461, 130)
        Me.Txt_Region.Multiline = True
        Me.Txt_Region.Name = "Txt_Region"
        Me.Txt_Region.Size = New System.Drawing.Size(299, 41)
        Me.Txt_Region.TabIndex = 5
        '
        'CB_Name
        '
        Me.CB_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Name.FormattingEnabled = True
        Me.CB_Name.Location = New System.Drawing.Point(243, 49)
        Me.CB_Name.Name = "CB_Name"
        Me.CB_Name.Size = New System.Drawing.Size(283, 32)
        Me.CB_Name.TabIndex = 4
        '
        'Txt_Donnees
        '
        Me.Txt_Donnees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Donnees.Location = New System.Drawing.Point(203, 220)
        Me.Txt_Donnees.Multiline = True
        Me.Txt_Donnees.Name = "Txt_Donnees"
        Me.Txt_Donnees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Donnees.Size = New System.Drawing.Size(748, 317)
        Me.Txt_Donnees.TabIndex = 7
        '
        'Btn_Retour
        '
        Me.Btn_Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Retour.Location = New System.Drawing.Point(581, 578)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(129, 55)
        Me.Btn_Retour.TabIndex = 10
        Me.Btn_Retour.Text = "Retour Menu"
        Me.Btn_Retour.UseVisualStyleBackColor = True
        '
        'Frm_Collabo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 749)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Controls.Add(Me.Txt_Donnees)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Region)
        Me.Controls.Add(Me.CB_Name)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Collabo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion Plage 3.0"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Region As TextBox
    Friend WithEvents CB_Name As ComboBox
    Friend WithEvents DEPARTEMENTBindingSource As BindingSource
    Friend WithEvents VILLEBindingSource As BindingSource
    Friend WithEvents PLAGEBindingSource As BindingSource
    Friend WithEvents Txt_Donnees As TextBox
    Friend WithEvents Btn_Retour As Button
End Class
