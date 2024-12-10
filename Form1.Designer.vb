<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Txt_ISBN = New TextBox()
        Txt_titre = New TextBox()
        Txt_auteur = New TextBox()
        btn_ajouter = New Button()
        btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(135, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 36)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(135, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 33)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(135, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 33)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' Txt_ISBN
        ' 
        Txt_ISBN.Location = New Point(285, 63)
        Txt_ISBN.Name = "Txt_ISBN"
        Txt_ISBN.Size = New Size(125, 27)
        Txt_ISBN.TabIndex = 3
        ' 
        ' Txt_titre
        ' 
        Txt_titre.Location = New Point(285, 149)
        Txt_titre.Name = "Txt_titre"
        Txt_titre.Size = New Size(125, 27)
        Txt_titre.TabIndex = 4
        ' 
        ' Txt_auteur
        ' 
        Txt_auteur.Location = New Point(285, 250)
        Txt_auteur.Name = "Txt_auteur"
        Txt_auteur.Size = New Size(125, 27)
        Txt_auteur.TabIndex = 5
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ajouter.Location = New Point(135, 348)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(139, 46)
        btn_ajouter.TabIndex = 6
        btn_ajouter.Text = "Ajouter"
        btn_ajouter.UseVisualStyleBackColor = True
        ' 
        ' btn_afficher
        ' 
        btn_afficher.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_afficher.Location = New Point(362, 348)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(143, 44)
        btn_afficher.TabIndex = 7
        btn_afficher.Text = "Afficher"
        btn_afficher.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(630, 462)
        Controls.Add(btn_afficher)
        Controls.Add(btn_ajouter)
        Controls.Add(Txt_auteur)
        Controls.Add(Txt_titre)
        Controls.Add(Txt_ISBN)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_ISBN As TextBox
    Friend WithEvents Txt_titre As TextBox
    Friend WithEvents Txt_auteur As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button

End Class
