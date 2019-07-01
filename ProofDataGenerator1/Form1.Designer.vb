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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = "\\6.1.1.220\library\AG Design Examples\AlphaGraphics\Logos\AG_Logos_Final\1_Color" &
    "_Logos\Black\With Tagline\AG_logo_tag_1C_RichBlack.png"
        Me.PictureBox1.Location = New System.Drawing.Point(355, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 141)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 18
        Me.ComboBox1.Items.AddRange(New Object() {"5 From the top", "5 From the bottom", "10 From the top", "10 From the bottom", "20 Random Records", "xx Random Records (Specify Amount)"})
        Me.ComboBox1.Location = New System.Drawing.Point(19, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(321, 26)
        Me.ComboBox1.TabIndex = 1
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.Location = New System.Drawing.Point(19, 72)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(138, 81)
        Me.Browse.TabIndex = 2
        Me.Browse.Text = "Browse to File"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Open Sans Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(202, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 81)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Generate Proof File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(19, 179)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(608, 424)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 615)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Proof Data Generator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Browse As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
End Class
