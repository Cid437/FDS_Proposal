<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.account = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.Label()
        Me.about = New System.Windows.Forms.Label()
        Me.cart = New System.Windows.Forms.Label()
        Me.pawn = New System.Windows.Forms.Label()
        Me.buy = New System.Windows.Forms.Label()
        Me.home = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BackgroundImage = Global.FDMS_Proposal.My.Resources.Resources.DC_Header
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.account)
        Me.Panel1.Controls.Add(Me.help)
        Me.Panel1.Controls.Add(Me.about)
        Me.Panel1.Controls.Add(Me.cart)
        Me.Panel1.Controls.Add(Me.pawn)
        Me.Panel1.Controls.Add(Me.buy)
        Me.Panel1.Controls.Add(Me.home)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 123)
        Me.Panel1.TabIndex = 3
        '
        'account
        '
        Me.account.AutoSize = True
        Me.account.BackColor = System.Drawing.Color.Transparent
        Me.account.Cursor = System.Windows.Forms.Cursors.Hand
        Me.account.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.account.Location = New System.Drawing.Point(949, 5)
        Me.account.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(83, 23)
        Me.account.TabIndex = 4
        Me.account.Text = "Account"
        '
        'help
        '
        Me.help.AutoSize = True
        Me.help.Cursor = System.Windows.Forms.Cursors.Help
        Me.help.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.help.Location = New System.Drawing.Point(824, 44)
        Me.help.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(63, 28)
        Me.help.TabIndex = 3
        Me.help.Text = "Help"
        '
        'about
        '
        Me.about.AutoSize = True
        Me.about.Cursor = System.Windows.Forms.Cursors.Help
        Me.about.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.about.Location = New System.Drawing.Point(144, 44)
        Me.about.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(109, 28)
        Me.about.TabIndex = 1
        Me.about.Text = "About us"
        '
        'cart
        '
        Me.cart.AutoSize = True
        Me.cart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cart.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cart.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cart.Location = New System.Drawing.Point(639, 89)
        Me.cart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cart.Name = "cart"
        Me.cart.Size = New System.Drawing.Size(59, 28)
        Me.cart.TabIndex = 1
        Me.cart.Text = "Cart"
        '
        'pawn
        '
        Me.pawn.AutoSize = True
        Me.pawn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pawn.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pawn.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.pawn.Location = New System.Drawing.Point(863, 89)
        Me.pawn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pawn.Name = "pawn"
        Me.pawn.Size = New System.Drawing.Size(71, 28)
        Me.pawn.TabIndex = 2
        Me.pawn.Text = "Pawn"
        '
        'buy
        '
        Me.buy.AutoSize = True
        Me.buy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buy.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buy.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.buy.Location = New System.Drawing.Point(392, 89)
        Me.buy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.buy.Name = "buy"
        Me.buy.Size = New System.Drawing.Size(54, 28)
        Me.buy.TabIndex = 1
        Me.buy.Text = "Buy"
        '
        'home
        '
        Me.home.AutoSize = True
        Me.home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.home.Location = New System.Drawing.Point(140, 90)
        Me.home.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(77, 28)
        Me.home.TabIndex = 0
        Me.home.Text = "Home"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Fax", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(593, 209)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 37)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Fax", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(593, 272)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(356, 37)
        Me.TextBox2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(591, 363)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(776, 363)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Sign-up"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(589, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(589, 252)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.FDMS_Proposal.My.Resources.Resources.mata_sara
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(907, 275)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "?"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.FDMS_Proposal.My.Resources.Resources.mata_bukas
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(907, 275)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 32)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "?"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FDMS_Proposal.My.Resources.Resources.Pawn___Trade
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents account As Label
    Friend WithEvents help As Label
    Friend WithEvents about As Label
    Friend WithEvents cart As Label
    Friend WithEvents pawn As Label
    Friend WithEvents buy As Label
    Friend WithEvents home As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
