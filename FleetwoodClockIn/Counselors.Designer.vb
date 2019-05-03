<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Counselors
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radHawkins = New System.Windows.Forms.RadioButton()
        Me.radSaunders = New System.Windows.Forms.RadioButton()
        Me.radEngelhardt = New System.Windows.Forms.RadioButton()
        Me.radMoyer = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radHawkins)
        Me.GroupBox1.Controls.Add(Me.radSaunders)
        Me.GroupBox1.Controls.Add(Me.radEngelhardt)
        Me.GroupBox1.Controls.Add(Me.radMoyer)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Counselor"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(14, 117)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 5
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radHawkins
        '
        Me.radHawkins.AutoSize = True
        Me.radHawkins.Location = New System.Drawing.Point(14, 94)
        Me.radHawkins.Name = "radHawkins"
        Me.radHawkins.Size = New System.Drawing.Size(89, 17)
        Me.radHawkins.TabIndex = 4
        Me.radHawkins.TabStop = True
        Me.radHawkins.Text = "Mrs. Hawkins"
        Me.radHawkins.UseVisualStyleBackColor = True
        '
        'radSaunders
        '
        Me.radSaunders.AutoSize = True
        Me.radSaunders.Location = New System.Drawing.Point(14, 71)
        Me.radSaunders.Name = "radSaunders"
        Me.radSaunders.Size = New System.Drawing.Size(93, 17)
        Me.radSaunders.TabIndex = 3
        Me.radSaunders.TabStop = True
        Me.radSaunders.Text = "Mrs. Saunders"
        Me.radSaunders.UseVisualStyleBackColor = True
        '
        'radEngelhardt
        '
        Me.radEngelhardt.AutoSize = True
        Me.radEngelhardt.Location = New System.Drawing.Point(14, 48)
        Me.radEngelhardt.Name = "radEngelhardt"
        Me.radEngelhardt.Size = New System.Drawing.Size(94, 17)
        Me.radEngelhardt.TabIndex = 2
        Me.radEngelhardt.TabStop = True
        Me.radEngelhardt.Text = "Mr. Engelhardt"
        Me.radEngelhardt.UseVisualStyleBackColor = True
        '
        'radMoyer
        '
        Me.radMoyer.AutoSize = True
        Me.radMoyer.Location = New System.Drawing.Point(14, 25)
        Me.radMoyer.Name = "radMoyer"
        Me.radMoyer.Size = New System.Drawing.Size(74, 17)
        Me.radMoyer.TabIndex = 1
        Me.radMoyer.TabStop = True
        Me.radMoyer.Text = "Ms. Moyer"
        Me.radMoyer.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(200, 48)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(200, 77)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Counselors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(304, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Counselors"
        Me.Text = "Counselors"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOther As RadioButton
    Friend WithEvents radHawkins As RadioButton
    Friend WithEvents radSaunders As RadioButton
    Friend WithEvents radEngelhardt As RadioButton
    Friend WithEvents radMoyer As RadioButton
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
