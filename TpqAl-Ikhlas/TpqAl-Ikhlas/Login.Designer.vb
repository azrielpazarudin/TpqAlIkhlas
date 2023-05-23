<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MinimizeBtn = New System.Windows.Forms.Button()
        Me.MaximizeBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.cancelBtnShape = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.loginBtnShape = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.userNameBuffer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.saveDataIdCB = New System.Windows.Forms.CheckBox()
        Me.panelTop.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.DarkGreen
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Controls.Add(Me.Panel4)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(397, 48)
        Me.panelTop.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TPQ AL-IKHLAS v.1.0"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MinimizeBtn)
        Me.Panel4.Controls.Add(Me.MaximizeBtn)
        Me.Panel4.Controls.Add(Me.CloseBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(292, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(105, 48)
        Me.Panel4.TabIndex = 0
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.BackColor = System.Drawing.Color.Yellow
        Me.MinimizeBtn.FlatAppearance.BorderSize = 0
        Me.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeBtn.Location = New System.Drawing.Point(14, 12)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(18, 18)
        Me.MinimizeBtn.TabIndex = 5
        Me.MinimizeBtn.UseVisualStyleBackColor = False
        '
        'MaximizeBtn
        '
        Me.MaximizeBtn.BackColor = System.Drawing.Color.Lime
        Me.MaximizeBtn.FlatAppearance.BorderSize = 0
        Me.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeBtn.Location = New System.Drawing.Point(44, 12)
        Me.MaximizeBtn.Name = "MaximizeBtn"
        Me.MaximizeBtn.Size = New System.Drawing.Size(18, 18)
        Me.MaximizeBtn.TabIndex = 6
        Me.MaximizeBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CloseBtn.Location = New System.Drawing.Point(75, 12)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(18, 18)
        Me.CloseBtn.TabIndex = 7
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.cancelBtnShape, Me.loginBtnShape, Me.LineShape4, Me.LineShape2, Me.RectangleShape2, Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(397, 461)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'cancelBtnShape
        '
        Me.cancelBtnShape.BackColor = System.Drawing.Color.Black
        Me.cancelBtnShape.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.cancelBtnShape.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.cancelBtnShape.CornerRadius = 12
        Me.cancelBtnShape.Location = New System.Drawing.Point(76, 348)
        Me.cancelBtnShape.Name = "cancelBtnShape"
        Me.cancelBtnShape.Size = New System.Drawing.Size(210, 40)
        Me.cancelBtnShape.Tag = ""
        '
        'loginBtnShape
        '
        Me.loginBtnShape.BackColor = System.Drawing.Color.Black
        Me.loginBtnShape.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.loginBtnShape.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.loginBtnShape.CornerRadius = 12
        Me.loginBtnShape.Location = New System.Drawing.Point(77, 302)
        Me.loginBtnShape.Name = "loginBtnShape"
        Me.loginBtnShape.Size = New System.Drawing.Size(210, 40)
        Me.loginBtnShape.Tag = ""
        '
        'LineShape4
        '
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 76
        Me.LineShape4.X2 = 286
        Me.LineShape4.Y1 = 274
        Me.LineShape4.Y2 = 274
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 78
        Me.LineShape2.X2 = 288
        Me.LineShape2.Y1 = 215
        Me.LineShape2.Y2 = 215
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.LightGreen
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 8
        Me.RectangleShape2.Location = New System.Drawing.Point(62, 65)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(244, 337)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape3.BorderWidth = 4
        Me.RectangleShape3.CornerRadius = 8
        Me.RectangleShape3.Location = New System.Drawing.Point(108, 136)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(236, 300)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DarkGreen
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 8
        Me.RectangleShape1.Location = New System.Drawing.Point(79, 100)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(249, 319)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGreen
        Me.Label2.Font = New System.Drawing.Font("Swis721 Blk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 22)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Font = New System.Drawing.Font("Swis721 Blk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 22)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGreen
        Me.Label5.Font = New System.Drawing.Font("Swis721 Blk BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Log In Page"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.LightGreen
        Me.username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(80, 195)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(210, 16)
        Me.username.TabIndex = 1
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.LightGreen
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Font = New System.Drawing.Font("Swis721 Blk BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(79, 255)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(210, 15)
        Me.password.TabIndex = 2
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Black
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtn.Location = New System.Drawing.Point(90, 306)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.loginBtn.Size = New System.Drawing.Size(188, 32)
        Me.loginBtn.TabIndex = 3
        Me.loginBtn.Text = "Login"
        Me.loginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Black
        Me.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cancelBtn.FlatAppearance.BorderSize = 0
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelBtn.Location = New System.Drawing.Point(90, 351)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cancelBtn.Size = New System.Drawing.Size(188, 32)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'userNameBuffer
        '
        Me.userNameBuffer.AutoSize = True
        Me.userNameBuffer.Location = New System.Drawing.Point(251, 424)
        Me.userNameBuffer.Name = "userNameBuffer"
        Me.userNameBuffer.Size = New System.Drawing.Size(0, 13)
        Me.userNameBuffer.TabIndex = 42
        Me.userNameBuffer.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.Font = New System.Drawing.Font("Swis721 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Save Login Data ?"
        '
        'saveDataIdCB
        '
        Me.saveDataIdCB.AutoSize = True
        Me.saveDataIdCB.BackColor = System.Drawing.Color.LightGreen
        Me.saveDataIdCB.Location = New System.Drawing.Point(240, 281)
        Me.saveDataIdCB.Name = "saveDataIdCB"
        Me.saveDataIdCB.Size = New System.Drawing.Size(15, 14)
        Me.saveDataIdCB.TabIndex = 45
        Me.saveDataIdCB.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(397, 461)
        Me.Controls.Add(Me.saveDataIdCB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.userNameBuffer)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MinimizeBtn As System.Windows.Forms.Button
    Friend WithEvents MaximizeBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents loginBtnShape As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtnShape As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents userNameBuffer As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents saveDataIdCB As System.Windows.Forms.CheckBox

End Class
