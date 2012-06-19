<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnDinner = New System.Windows.Forms.Button
        Me.lblDinnerTitle = New System.Windows.Forms.Label
        Me.lblDinner = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnDinner
        '
        Me.btnDinner.Location = New System.Drawing.Point(96, 111)
        Me.btnDinner.Name = "btnDinner"
        Me.btnDinner.Size = New System.Drawing.Size(99, 23)
        Me.btnDinner.TabIndex = 0
        Me.btnDinner.Text = "Pick My Dinner"
        Me.btnDinner.UseVisualStyleBackColor = True
        '
        'lblDinnerTitle
        '
        Me.lblDinnerTitle.AutoSize = True
        Me.lblDinnerTitle.Location = New System.Drawing.Point(111, 9)
        Me.lblDinnerTitle.Name = "lblDinnerTitle"
        Me.lblDinnerTitle.Size = New System.Drawing.Size(74, 13)
        Me.lblDinnerTitle.TabIndex = 1
        Me.lblDinnerTitle.Text = "Your dinner is:"
        Me.lblDinnerTitle.Visible = False
        '
        'lblDinner
        '
        Me.lblDinner.AutoSize = True
        Me.lblDinner.Location = New System.Drawing.Point(93, 53)
        Me.lblDinner.Name = "lblDinner"
        Me.lblDinner.Size = New System.Drawing.Size(16, 13)
        Me.lblDinner.TabIndex = 2
        Me.lblDinner.Text = "   "
        Me.lblDinner.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 148)
        Me.Controls.Add(Me.lblDinner)
        Me.Controls.Add(Me.lblDinnerTitle)
        Me.Controls.Add(Me.btnDinner)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Dinner Picker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDinner As System.Windows.Forms.Button
    Friend WithEvents lblDinnerTitle As System.Windows.Forms.Label
    Friend WithEvents lblDinner As System.Windows.Forms.Label

End Class
