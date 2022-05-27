<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Problema4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreLaAplcaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SobreLaAplcaciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Problema1ToolStripMenuItem, Me.Problema2ToolStripMenuItem, Me.Problema3ToolStripMenuItem, Me.Problema4ToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'Problema1ToolStripMenuItem
        '
        Me.Problema1ToolStripMenuItem.Name = "Problema1ToolStripMenuItem"
        Me.Problema1ToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.Problema1ToolStripMenuItem.Text = "Problema 1"
        '
        'Problema2ToolStripMenuItem
        '
        Me.Problema2ToolStripMenuItem.Name = "Problema2ToolStripMenuItem"
        Me.Problema2ToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.Problema2ToolStripMenuItem.Text = "Problema 2"
        '
        'Problema3ToolStripMenuItem
        '
        Me.Problema3ToolStripMenuItem.Name = "Problema3ToolStripMenuItem"
        Me.Problema3ToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.Problema3ToolStripMenuItem.Text = "Problema 3"
        '
        'Problema4ToolStripMenuItem
        '
        Me.Problema4ToolStripMenuItem.Name = "Problema4ToolStripMenuItem"
        Me.Problema4ToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.Problema4ToolStripMenuItem.Text = "Problema 4"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'SobreLaAplcaciónToolStripMenuItem
        '
        Me.SobreLaAplcaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersiónToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.SobreLaAplcaciónToolStripMenuItem.Name = "SobreLaAplcaciónToolStripMenuItem"
        Me.SobreLaAplcaciónToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.SobreLaAplcaciónToolStripMenuItem.Text = "Sobre la aplcación"
        '
        'VersiónToolStripMenuItem
        '
        Me.VersiónToolStripMenuItem.Name = "VersiónToolStripMenuItem"
        Me.VersiónToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.VersiónToolStripMenuItem.Text = "Versión"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lab2_Herr_Prog_Xoan_Teira.My.Resources.Resources.Logo_Empresa_GOD
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Problema4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreLaAplcaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
End Class
