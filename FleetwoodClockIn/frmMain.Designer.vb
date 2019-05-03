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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClockIn = New System.Windows.Forms.Button()
        Me.btnClockOut = New System.Windows.Forms.Button()
        Me.tmrBackground = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 48.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1045, 112)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fleetwood Area School District"
        '
        'btnClockIn
        '
        Me.btnClockIn.BackColor = System.Drawing.Color.MistyRose
        Me.btnClockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClockIn.Location = New System.Drawing.Point(224, 464)
        Me.btnClockIn.Name = "btnClockIn"
        Me.btnClockIn.Size = New System.Drawing.Size(306, 152)
        Me.btnClockIn.TabIndex = 1
        Me.btnClockIn.Text = "Sign In"
        Me.btnClockIn.UseVisualStyleBackColor = False
        '
        'btnClockOut
        '
        Me.btnClockOut.BackColor = System.Drawing.Color.MistyRose
        Me.btnClockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClockOut.Location = New System.Drawing.Point(828, 464)
        Me.btnClockOut.Name = "btnClockOut"
        Me.btnClockOut.Size = New System.Drawing.Size(306, 152)
        Me.btnClockOut.TabIndex = 2
        Me.btnClockOut.Text = "Sign Out"
        Me.btnClockOut.UseVisualStyleBackColor = False
        '
        'tmrBackground
        '
        Me.tmrBackground.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Rockwell", 18.0!)
        Me.lblTime.Location = New System.Drawing.Point(618, 133)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(142, 27)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "00:00:00 XX"
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnClockOut)
        Me.Controls.Add(Me.btnClockIn)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClockIn As Button
    Friend WithEvents btnClockOut As Button
    Friend WithEvents tmrBackground As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrClock As Timer
End Class
