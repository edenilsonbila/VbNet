<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmwb))
        Me.wbem = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wbem
        '
        Me.wbem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbem.Location = New System.Drawing.Point(0, 0)
        Me.wbem.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbem.Name = "wbem"
        Me.wbem.Size = New System.Drawing.Size(1008, 682)
        Me.wbem.TabIndex = 0
        '
        'frmwb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1008, 682)
        Me.Controls.Add(Me.wbem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmwb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emergência"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbem As System.Windows.Forms.WebBrowser
End Class
