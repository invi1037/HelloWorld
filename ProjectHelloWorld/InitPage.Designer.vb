<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_InitPage
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_HelloWorld = New System.Windows.Forms.Label()
        Me.Btn_Press = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_HelloWorld
        '
        Me.Lbl_HelloWorld.AutoSize = True
        Me.Lbl_HelloWorld.Location = New System.Drawing.Point(278, 85)
        Me.Lbl_HelloWorld.Name = "Lbl_HelloWorld"
        Me.Lbl_HelloWorld.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_HelloWorld.TabIndex = 0
        Me.Lbl_HelloWorld.Text = "Hello World"
        '
        'Btn_Press
        '
        Me.Btn_Press.Location = New System.Drawing.Point(281, 115)
        Me.Btn_Press.Name = "Btn_Press"
        Me.Btn_Press.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Press.TabIndex = 1
        Me.Btn_Press.Text = "Press"
        Me.Btn_Press.UseVisualStyleBackColor = True
        '
        'Fr_InitPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 282)
        Me.Controls.Add(Me.Btn_Press)
        Me.Controls.Add(Me.Lbl_HelloWorld)
        Me.Name = "Fr_InitPage"
        Me.Text = "Página de Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_HelloWorld As Label
    Friend WithEvents Btn_Press As Button
End Class
