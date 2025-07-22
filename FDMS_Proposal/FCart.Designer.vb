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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BackgroundImage = Global.FDMS_Proposal.My.Resources.Resources.DC_Header
        Me.Panel1.Controls.Add(Me.account)
        Me.Panel1.Controls.Add(Me.help)
        Me.Panel1.Controls.Add(Me.about)
        Me.Panel1.Controls.Add(Me.cart)
        Me.Panel1.Controls.Add(Me.Pawn)
        Me.Panel1.Controls.Add(Me.buy)
        Me.Panel1.Controls.Add(Me.home)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 3
        '
        'account
        '
        Me.account.AutoSize = True
        Me.account.BackColor = System.Drawing.Color.Transparent
        Me.account.Cursor = System.Windows.Forms.Cursors.Hand
        Me.account.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.account.Location = New System.Drawing.Point(712, 4)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(70, 19)
        Me.account.TabIndex = 4
        Me.account.Text = "Account"
        '
        'help
        '
        Me.help.AutoSize = True
        Me.help.Cursor = System.Windows.Forms.Cursors.Help
        Me.help.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.help.Location = New System.Drawing.Point(618, 36)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(51, 22)
        Me.help.TabIndex = 3
        Me.help.Text = "Help"
        '
        'about
        '
        Me.about.AutoSize = True
        Me.about.Cursor = System.Windows.Forms.Cursors.Help
        Me.about.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.about.Location = New System.Drawing.Point(108, 36)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(86, 22)
        Me.about.TabIndex = 1
        Me.about.Text = "About us"
        '
        'cart
        '
        Me.cart.AutoSize = True
        Me.cart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cart.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cart.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.cart.Location = New System.Drawing.Point(479, 72)
        Me.cart.Name = "cart"
        Me.cart.Size = New System.Drawing.Size(47, 22)
        Me.cart.TabIndex = 1
        Me.cart.Text = "Cart"
        '
        'Pawn
        '
        Me.Pawn.AutoSize = True
        Me.Pawn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pawn.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pawn.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Pawn.Location = New System.Drawing.Point(647, 72)
        Me.Pawn.Name = "Pawn"
        Me.Pawn.Size = New System.Drawing.Size(57, 22)
        Me.Pawn.TabIndex = 2
        Me.Pawn.Text = "Pawn"
        '
        'buy
        '
        Me.buy.AutoSize = True
        Me.buy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buy.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buy.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.buy.Location = New System.Drawing.Point(294, 72)
        Me.buy.Name = "buy"
        Me.buy.Size = New System.Drawing.Size(42, 22)
        Me.buy.TabIndex = 1
        Me.buy.Text = "Buy"
        '
        'home
        '
        Me.home.AutoSize = True
        Me.home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.home.Location = New System.Drawing.Point(105, 73)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(62, 22)
        Me.home.TabIndex = 0
        Me.home.Text = "Home"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(251, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Whats in my Cart?"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(400, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(346, 239)
        Me.DataGridView1.TabIndex = 6
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button24.Font = New System.Drawing.Font("Lucida Fax", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button24.Location = New System.Drawing.Point(81, 205)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(141, 27)
        Me.Button24.TabIndex = 19
        Me.Button24.Text = "Search"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(81, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 27)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(81, 341)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 27)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Amount"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 176)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 20)
        Me.TextBox1.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(81, 245)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 20)
        Me.TextBox2.TabIndex = 23
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(81, 312)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(165, 20)
        Me.TextBox3.TabIndex = 24
        '
        'FCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FDMS_Proposal.My.Resources.Resources.dagat
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button24 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
