<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Associer
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
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.CB_Selection1 = New System.Windows.Forms.ComboBox()
        Me.Lbl_Selection = New System.Windows.Forms.Label()
        Me.CB_Selection2 = New System.Windows.Forms.ComboBox()
        Me.TxtBox_Info = New System.Windows.Forms.TextBox()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_OK
        '
        Me.Btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OK.Location = New System.Drawing.Point(428, 450)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(140, 64)
        Me.Btn_OK.TabIndex = 3
        Me.Btn_OK.Text = "OK"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.Location = New System.Drawing.Point(211, 450)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(140, 64)
        Me.Btn_Annuler.TabIndex = 4
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'CB_Selection1
        '
        Me.CB_Selection1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Selection1.FormattingEnabled = True
        Me.CB_Selection1.Location = New System.Drawing.Point(49, 165)
        Me.CB_Selection1.Name = "CB_Selection1"
        Me.CB_Selection1.Size = New System.Drawing.Size(293, 37)
        Me.CB_Selection1.TabIndex = 5
        '
        'Lbl_Selection
        '
        Me.Lbl_Selection.AutoSize = True
        Me.Lbl_Selection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Selection.Location = New System.Drawing.Point(206, 98)
        Me.Lbl_Selection.Name = "Lbl_Selection"
        Me.Lbl_Selection.Size = New System.Drawing.Size(329, 25)
        Me.Lbl_Selection.TabIndex = 6
        Me.Lbl_Selection.Text = "Associez Responsable et Région"
        '
        'CB_Selection2
        '
        Me.CB_Selection2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Selection2.FormattingEnabled = True
        Me.CB_Selection2.Location = New System.Drawing.Point(392, 165)
        Me.CB_Selection2.Name = "CB_Selection2"
        Me.CB_Selection2.Size = New System.Drawing.Size(293, 37)
        Me.CB_Selection2.TabIndex = 7
        '
        'TxtBox_Info
        '
        Me.TxtBox_Info.Location = New System.Drawing.Point(144, 319)
        Me.TxtBox_Info.Multiline = True
        Me.TxtBox_Info.Name = "TxtBox_Info"
        Me.TxtBox_Info.Size = New System.Drawing.Size(463, 74)
        Me.TxtBox_Info.TabIndex = 8
        '
        'Lbl_Info
        '
        Me.Lbl_Info.AutoSize = True
        Me.Lbl_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Info.Location = New System.Drawing.Point(139, 268)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(132, 29)
        Me.Lbl_Info.TabIndex = 9
        Me.Lbl_Info.Text = "Information"
        '
        'Frm_Associer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 711)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.TxtBox_Info)
        Me.Controls.Add(Me.CB_Selection2)
        Me.Controls.Add(Me.Lbl_Selection)
        Me.Controls.Add(Me.CB_Selection1)
        Me.Controls.Add(Me.Btn_Annuler)
        Me.Controls.Add(Me.Btn_OK)
        Me.Name = "Frm_Associer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_OK As Button
    Friend WithEvents Btn_Annuler As Button
    Friend WithEvents CB_Selection1 As ComboBox
    Friend WithEvents Lbl_Selection As Label
    Friend WithEvents CB_Selection2 As ComboBox
    Friend WithEvents TxtBox_Info As TextBox
    Friend WithEvents Lbl_Info As Label
End Class
