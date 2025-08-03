<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.account = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.Label()
        Me.about = New System.Windows.Forms.Label()
        Me.cart = New System.Windows.Forms.Label()
        Me.pawn = New System.Windows.Forms.Label()
        Me.buy = New System.Windows.Forms.Label()
        Me.home = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 416)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(4)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(800, 34)
        Me.AxWindowsMediaPlayer1.TabIndex = 23
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox5.Location = New System.Drawing.Point(984, 512)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(83, 32)
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Location = New System.Drawing.Point(984, 522)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 32)
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(0, 512)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(80, 32)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(0, 522)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 32)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.FDMS_Proposal.My.Resources.Resources.toyo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 122)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1067, 390)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
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
        Me.Panel1.TabIndex = 17
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pawn Shop"
        Me.TopMost = True
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents account As Label
    Friend WithEvents help As Label
    Friend WithEvents about As Label
    Friend WithEvents cart As Label
    Friend WithEvents pawn As Label
    Friend WithEvents buy As Label
    Friend WithEvents home As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
