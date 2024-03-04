<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Log_Logo
        PictureBox1.Location = New Point(54, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 15)
        Label1.TabIndex = 1
        Label1.Text = "Random Log Writer"
        ' 
        ' Label2
        ' 
        Label2.AccessibleRole = AccessibleRole.TitleBar
        Label2.Location = New Point(-3, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 24)
        Label2.TabIndex = 2
        Label2.Text = "..."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(-3, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(238, 84)
        Label3.TabIndex = 3
        Label3.Text = "A Windows utility that creates " & vbCrLf & "randomized log file." & vbCrLf & "Random lines at random time with " & vbCrLf & "selectable level indications." & vbCrLf & "Also a write now button is availalble."
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(12, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(238, 39)
        Label4.TabIndex = 4
        Label4.Text = "Hand Water Pump" & vbCrLf & "© 2024" & vbCrLf
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(-15, 270)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(293, 69)
        Panel1.TabIndex = 5
        ' 
        ' FrmAbout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(232, 322)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmAbout"
        Text = "About"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
