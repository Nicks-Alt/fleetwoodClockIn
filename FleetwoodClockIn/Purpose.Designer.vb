<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purpose
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radCollegeCareer = New System.Windows.Forms.RadioButton()
        Me.radSocialEmotional = New System.Windows.Forms.RadioButton()
        Me.radAcademic = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(195, 71)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Location = New System.Drawing.Point(195, 42)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radCollegeCareer)
        Me.GroupBox1.Controls.Add(Me.radSocialEmotional)
        Me.GroupBox1.Controls.Add(Me.radAcademic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 122)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Purpose for visit"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(14, 94)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 4
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.radOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radCollegeCareer
        '
        Me.radCollegeCareer.AutoSize = True
        Me.radCollegeCareer.Location = New System.Drawing.Point(14, 71)
        Me.radCollegeCareer.Name = "radCollegeCareer"
        Me.radCollegeCareer.Size = New System.Drawing.Size(96, 17)
        Me.radCollegeCareer.TabIndex = 3
        Me.radCollegeCareer.TabStop = True
        Me.radCollegeCareer.Text = "College/Career"
        Me.radCollegeCareer.UseVisualStyleBackColor = True
        '
        'radSocialEmotional
        '
        Me.radSocialEmotional.AutoSize = True
        Me.radSocialEmotional.Location = New System.Drawing.Point(14, 48)
        Me.radSocialEmotional.Name = "radSocialEmotional"
        Me.radSocialEmotional.Size = New System.Drawing.Size(105, 17)
        Me.radSocialEmotional.TabIndex = 2
        Me.radSocialEmotional.TabStop = True
        Me.radSocialEmotional.Text = "Social/Emotional"
        Me.radSocialEmotional.UseVisualStyleBackColor = True
        '
        'radAcademic
        '
        Me.radAcademic.AutoSize = True
        Me.radAcademic.Location = New System.Drawing.Point(14, 25)
        Me.radAcademic.Name = "radAcademic"
        Me.radAcademic.Size = New System.Drawing.Size(72, 17)
        Me.radAcademic.TabIndex = 1
        Me.radAcademic.TabStop = True
        Me.radAcademic.Text = "Academic"
        Me.radAcademic.UseVisualStyleBackColor = True
        '
        'Purpose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 139)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Purpose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purpose"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radCollegeCareer As RadioButton
    Friend WithEvents radSocialEmotional As RadioButton
    Friend WithEvents radAcademic As RadioButton
    Friend WithEvents radOther As RadioButton
End Class
