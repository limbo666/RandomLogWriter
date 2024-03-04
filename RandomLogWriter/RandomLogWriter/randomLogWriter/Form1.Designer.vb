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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        ChkInfo = New CheckBox()
        ChkWarning = New CheckBox()
        ChkError = New CheckBox()
        ChkCritical = New CheckBox()
        ChkFatal = New CheckBox()
        ChkCustom = New CheckBox()
        GroupBox1 = New GroupBox()
        TxtCustom = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        Button3 = New Button()
        txtpath = New TextBox()
        btnSelectfile = New Button()
        GroupBox3 = New GroupBox()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(25, 212)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 45)
        Button1.TabIndex = 0
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(16, 15)
        Label1.TabIndex = 1
        Label1.Text = "..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(16, 15)
        Label2.TabIndex = 2
        Label2.Text = "..."
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(25, 265)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 45)
        Button2.TabIndex = 3
        Button2.Text = "Write now"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ChkInfo
        ' 
        ChkInfo.AutoSize = True
        ChkInfo.Location = New Point(19, 23)
        ChkInfo.Name = "ChkInfo"
        ChkInfo.Size = New Size(47, 19)
        ChkInfo.TabIndex = 4
        ChkInfo.Text = "Info"
        ChkInfo.UseVisualStyleBackColor = True
        ' 
        ' ChkWarning
        ' 
        ChkWarning.AutoSize = True
        ChkWarning.Location = New Point(19, 48)
        ChkWarning.Name = "ChkWarning"
        ChkWarning.Size = New Size(71, 19)
        ChkWarning.TabIndex = 5
        ChkWarning.Text = "Warning"
        ChkWarning.UseVisualStyleBackColor = True
        ' 
        ' ChkError
        ' 
        ChkError.AutoSize = True
        ChkError.Location = New Point(19, 73)
        ChkError.Name = "ChkError"
        ChkError.Size = New Size(51, 19)
        ChkError.TabIndex = 6
        ChkError.Text = "Error"
        ChkError.UseVisualStyleBackColor = True
        ' 
        ' ChkCritical
        ' 
        ChkCritical.AutoSize = True
        ChkCritical.Location = New Point(19, 98)
        ChkCritical.Name = "ChkCritical"
        ChkCritical.Size = New Size(63, 19)
        ChkCritical.TabIndex = 7
        ChkCritical.Text = "Critical"
        ChkCritical.UseVisualStyleBackColor = True
        ' 
        ' ChkFatal
        ' 
        ChkFatal.AutoSize = True
        ChkFatal.Location = New Point(19, 123)
        ChkFatal.Name = "ChkFatal"
        ChkFatal.Size = New Size(51, 19)
        ChkFatal.TabIndex = 8
        ChkFatal.Text = "Fatal"
        ChkFatal.UseVisualStyleBackColor = True
        ' 
        ' ChkCustom
        ' 
        ChkCustom.AutoSize = True
        ChkCustom.Location = New Point(19, 148)
        ChkCustom.Name = "ChkCustom"
        ChkCustom.Size = New Size(68, 19)
        ChkCustom.TabIndex = 9
        ChkCustom.Text = "Custom"
        ChkCustom.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtCustom)
        GroupBox1.Controls.Add(ChkCustom)
        GroupBox1.Controls.Add(ChkFatal)
        GroupBox1.Controls.Add(ChkCritical)
        GroupBox1.Controls.Add(ChkError)
        GroupBox1.Controls.Add(ChkWarning)
        GroupBox1.Controls.Add(ChkInfo)
        GroupBox1.Location = New Point(155, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(329, 179)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Use these marks "
        ' 
        ' TxtCustom
        ' 
        TxtCustom.BorderStyle = BorderStyle.None
        TxtCustom.Location = New Point(93, 148)
        TxtCustom.Name = "TxtCustom"
        TxtCustom.Size = New Size(219, 16)
        TxtCustom.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 14
        Label3.Text = "Last log"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 13
        Label4.Text = "Last time"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(155, 204)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(329, 131)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Activity"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Log_Logo
        PictureBox1.Location = New Point(37, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(79, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(25, 393)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 25)
        Button3.TabIndex = 17
        Button3.Text = "About"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtpath
        ' 
        txtpath.BorderStyle = BorderStyle.None
        txtpath.Location = New Point(19, 22)
        txtpath.Name = "txtpath"
        txtpath.Size = New Size(293, 16)
        txtpath.TabIndex = 11
        ' 
        ' btnSelectfile
        ' 
        btnSelectfile.FlatStyle = FlatStyle.Flat
        btnSelectfile.Location = New Point(185, 52)
        btnSelectfile.Name = "btnSelectfile"
        btnSelectfile.Size = New Size(113, 25)
        btnSelectfile.TabIndex = 18
        btnSelectfile.Text = "Select existing"
        btnSelectfile.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Controls.Add(btnSelectfile)
        GroupBox3.Controls.Add(txtpath)
        GroupBox3.Location = New Point(155, 341)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(329, 91)
        GroupBox3.TabIndex = 19
        GroupBox3.TabStop = False
        GroupBox3.Text = "Target file"
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(53, 52)
        Button4.Name = "Button4"
        Button4.Size = New Size(113, 25)
        Button4.TabIndex = 19
        Button4.Text = "Create new"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 445)
        Controls.Add(GroupBox3)
        Controls.Add(Button3)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Random Log Writer"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ChkInfo As CheckBox
    Friend WithEvents ChkWarning As CheckBox
    Friend WithEvents ChkError As CheckBox
    Friend WithEvents ChkCritical As CheckBox
    Friend WithEvents ChkFatal As CheckBox
    Friend WithEvents ChkCustom As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCustom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtpath As TextBox
    Friend WithEvents btnSelectfile As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button

End Class
