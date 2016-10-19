<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtQues = New System.Windows.Forms.TextBox()
        Me.rdb1 = New System.Windows.Forms.RadioButton()
        Me.rdb2 = New System.Windows.Forms.RadioButton()
        Me.rdb3 = New System.Windows.Forms.RadioButton()
        Me.rdb4 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtQues
        '
        Me.txtQues.Location = New System.Drawing.Point(44, 40)
        Me.txtQues.Multiline = True
        Me.txtQues.Name = "txtQues"
        Me.txtQues.Size = New System.Drawing.Size(412, 126)
        Me.txtQues.TabIndex = 0
        '
        'rdb1
        '
        Me.rdb1.AutoSize = True
        Me.rdb1.Location = New System.Drawing.Point(72, 186)
        Me.rdb1.Name = "rdb1"
        Me.rdb1.Size = New System.Drawing.Size(14, 13)
        Me.rdb1.TabIndex = 1
        Me.rdb1.TabStop = True
        Me.rdb1.UseVisualStyleBackColor = True
        '
        'rdb2
        '
        Me.rdb2.AutoSize = True
        Me.rdb2.Location = New System.Drawing.Point(72, 209)
        Me.rdb2.Name = "rdb2"
        Me.rdb2.Size = New System.Drawing.Size(14, 13)
        Me.rdb2.TabIndex = 2
        Me.rdb2.TabStop = True
        Me.rdb2.UseVisualStyleBackColor = True
        '
        'rdb3
        '
        Me.rdb3.AutoSize = True
        Me.rdb3.Location = New System.Drawing.Point(72, 232)
        Me.rdb3.Name = "rdb3"
        Me.rdb3.Size = New System.Drawing.Size(14, 13)
        Me.rdb3.TabIndex = 3
        Me.rdb3.TabStop = True
        Me.rdb3.UseVisualStyleBackColor = True
        '
        'rdb4
        '
        Me.rdb4.AutoSize = True
        Me.rdb4.Location = New System.Drawing.Point(72, 255)
        Me.rdb4.Name = "rdb4"
        Me.rdb4.Size = New System.Drawing.Size(14, 13)
        Me.rdb4.TabIndex = 4
        Me.rdb4.TabStop = True
        Me.rdb4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(462, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Prev"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(416, 13)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 13)
        Me.lblScore.TabIndex = 10
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(47, 13)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg.TabIndex = 11
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(11, 311)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Reset Quiz"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(525, 344)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdb4)
        Me.Controls.Add(Me.rdb3)
        Me.Controls.Add(Me.rdb2)
        Me.Controls.Add(Me.rdb1)
        Me.Controls.Add(Me.txtQues)
        Me.Name = "Form1"
        Me.Text = "The Ultimate Triva Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQues As TextBox
    Friend WithEvents rdb1 As RadioButton
    Friend WithEvents rdb2 As RadioButton
    Friend WithEvents rdb3 As RadioButton
    Friend WithEvents rdb4 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents Button4 As Button
End Class
