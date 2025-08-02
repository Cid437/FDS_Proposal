<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FCart
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.account = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.Label()
        Me.about = New System.Windows.Forms.Label()
        Me.cart = New System.Windows.Forms.Label()
        Me.Pawn = New System.Windows.Forms.Label()
        Me.buy = New System.Windows.Forms.Label()
        Me.home = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Pawn)
        Me.Panel1.Controls.Add(Me.buy)
        Me.Panel1.Controls.Add(Me.home)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        'Pawn
        '
        Me.Pawn.AutoSize = True
        Me.Pawn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pawn.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pawn.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Pawn.Location = New System.Drawing.Point(863, 89)
        Me.Pawn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Pawn.Name = "Pawn"
        Me.Pawn.Size = New System.Drawing.Size(71, 28)
        Me.Pawn.TabIndex = 2
        Me.Pawn.Text = "Pawn"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(413, 181)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(533, 201)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(461, 338)
        Me.DataGridView1.TabIndex = 6
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button24.Font = New System.Drawing.Font("Lucida Fax", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button24.Location = New System.Drawing.Point(21, 231)
        Me.Button24.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(121, 33)
        Me.Button24.TabIndex = 19
        Me.Button24.Text = "Search ID: -->"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(21, 272)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 33)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(20, 320)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 54)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Set amount to buy:"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 236)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 22)
        Me.TextBox1.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(165, 325)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(79, 22)
        Me.TextBox3.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(369, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(346, 40)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Whats in my Cart?"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(21, 475)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 33)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Clear all"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(21, 405)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 33)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Buy!"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(344, 240)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 22)
        Me.TextBox2.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(273, 246)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(277, 287)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Price:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(344, 281)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(165, 22)
        Me.TextBox4.TabIndex = 35
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(285, 379)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(221, 59)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Refresh/Recheck Cart"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FDMS_Proposal.My.Resources.Resources.dagat
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FCart"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents account As Label
    Friend WithEvents help As Label
    Friend WithEvents about As Label
    Friend WithEvents cart As Label
    Friend WithEvents Pawn As Label
    Friend WithEvents buy As Label
    Friend WithEvents home As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button24 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button5 As Button
End Class
