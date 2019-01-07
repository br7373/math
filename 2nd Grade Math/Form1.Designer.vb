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
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.txtEquals = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSubtract = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbLevel2 = New System.Windows.Forms.RadioButton()
        Me.rdbLevel1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbSubtract = New System.Windows.Forms.RadioButton()
        Me.rdbAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(21, 43)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(42, 20)
        Me.txtBox1.TabIndex = 0
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(121, 43)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(42, 20)
        Me.txtBox2.TabIndex = 1
        '
        'txtEquals
        '
        Me.txtEquals.Location = New System.Drawing.Point(223, 43)
        Me.txtEquals.Name = "txtEquals"
        Me.txtEquals.Size = New System.Drawing.Size(42, 20)
        Me.txtEquals.TabIndex = 2
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(308, 33)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 38)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check Answer"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSubtract)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblAdd)
        Me.GroupBox1.Controls.Add(Me.txtBox2)
        Me.GroupBox1.Controls.Add(Me.btnCheck)
        Me.GroupBox1.Controls.Add(Me.txtBox1)
        Me.GroupBox1.Controls.Add(Me.txtEquals)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblSubtract
        '
        Me.lblSubtract.AutoSize = True
        Me.lblSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtract.Location = New System.Drawing.Point(78, 39)
        Me.lblSubtract.Name = "lblSubtract"
        Me.lblSubtract.Size = New System.Drawing.Size(19, 25)
        Me.lblSubtract.TabIndex = 6
        Me.lblSubtract.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "="
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(78, 39)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(24, 25)
        Me.lblAdd.TabIndex = 4
        Me.lblAdd.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbLevel2)
        Me.GroupBox2.Controls.Add(Me.rdbLevel1)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 77)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Level"
        '
        'rdbLevel2
        '
        Me.rdbLevel2.AutoSize = True
        Me.rdbLevel2.Location = New System.Drawing.Point(21, 43)
        Me.rdbLevel2.Name = "rdbLevel2"
        Me.rdbLevel2.Size = New System.Drawing.Size(102, 17)
        Me.rdbLevel2.TabIndex = 1
        Me.rdbLevel2.TabStop = True
        Me.rdbLevel2.Text = "Level 2 (10-100)"
        Me.rdbLevel2.UseVisualStyleBackColor = True
        '
        'rdbLevel1
        '
        Me.rdbLevel1.AutoSize = True
        Me.rdbLevel1.Location = New System.Drawing.Point(21, 20)
        Me.rdbLevel1.Name = "rdbLevel1"
        Me.rdbLevel1.Size = New System.Drawing.Size(90, 17)
        Me.rdbLevel1.TabIndex = 0
        Me.rdbLevel1.TabStop = True
        Me.rdbLevel1.Text = "Level 1 (1-10)"
        Me.rdbLevel1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbSubtract)
        Me.GroupBox3.Controls.Add(Me.rdbAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(189, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 77)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operation"
        '
        'rdbSubtract
        '
        Me.rdbSubtract.AutoSize = True
        Me.rdbSubtract.Location = New System.Drawing.Point(15, 43)
        Me.rdbSubtract.Name = "rdbSubtract"
        Me.rdbSubtract.Size = New System.Drawing.Size(79, 17)
        Me.rdbSubtract.TabIndex = 2
        Me.rdbSubtract.TabStop = True
        Me.rdbSubtract.Text = "Subtraction"
        Me.rdbSubtract.UseVisualStyleBackColor = True
        '
        'rdbAdd
        '
        Me.rdbAdd.AutoSize = True
        Me.rdbAdd.Location = New System.Drawing.Point(15, 20)
        Me.rdbAdd.Name = "rdbAdd"
        Me.rdbAdd.Size = New System.Drawing.Size(63, 17)
        Me.rdbAdd.TabIndex = 1
        Me.rdbAdd.TabStop = True
        Me.rdbAdd.Text = "Addition"
        Me.rdbAdd.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblIncorrect)
        Me.GroupBox4.Controls.Add(Me.lblCorrect)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(347, 183)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(129, 61)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.Location = New System.Drawing.Point(80, 29)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(10, 13)
        Me.lblIncorrect.TabIndex = 3
        Me.lblIncorrect.Text = "."
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Location = New System.Drawing.Point(22, 29)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(10, 13)
        Me.lblCorrect.TabIndex = 2
        Me.lblCorrect.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Incorrect"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Correct"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(401, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(537, 326)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Second Grade Math"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents txtEquals As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSubtract As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbLevel2 As RadioButton
    Friend WithEvents rdbLevel1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbSubtract As RadioButton
    Friend WithEvents rdbAdd As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents lblCorrect As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
End Class
