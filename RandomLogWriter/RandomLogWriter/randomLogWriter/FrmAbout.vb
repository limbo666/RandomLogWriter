Public Class FrmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top + (Form1.Height - Me.Height) / 2
        Me.Left = Form1.Top + (Form1.Width - Me.Width) / 2
        Label2.Text = Application.ProductVersion
    End Sub
End Class