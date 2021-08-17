Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Threading.Thread.Sleep(250)

        Dim cikti As System.Drawing.Graphics
        Dim resim As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim boyut As Size = New Size(resim.Width, resim.Height)

        cikti = System.Drawing.Graphics.FromImage(resim)
        cikti.CopyFromScreen(New Point(0, 0), New Point(0, 0), boyut)

        PictureBox1.Image = resim

        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            Dim img As Image = PictureBox1.Image
            Dim bmp As Bitmap = New Bitmap(img.Width, img.Height)
            Dim cikti As Graphics = Graphics.FromImage(bmp)

            cikti.DrawImageUnscaled(img, New Point(0, 0))
            cikti.Dispose()

            FolderBrowserDialog1.ShowDialog()
            Dim yol As String = FolderBrowserDialog1.SelectedPath
            Dim dosyaadi As String = "\\taken_screenshot"

            bmp.Save(yol & dosyaadi & ".jpg", Imaging.ImageFormat.Jpeg)
            bmp.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/Atalayagiz")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label10.Click, Label12.Click, Label11.Click

    End Sub
End Class
