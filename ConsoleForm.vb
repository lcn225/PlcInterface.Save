Imports System.IO



Public Class ConsoleForm

    Private _IniFileAccess As IniFileGateway

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles loadSET_Button.Click
        Dim FileName As String
        Dim filestream1 As System.IO.FileStream
        Dim chrstream1 As System.IO.StreamReader

        OpenFileDialog1.InitialDirectory = "E:\"
        OpenFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件|*.*"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.Title = "打开文件窗口"
        OpenFileDialog1.AddExtension() = False
        OpenFileDialog1.CheckPathExists() = True
        OpenFileDialog1.ValidateNames() = True
        OpenFileDialog1.ShowHelp() = True

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            FileName = OpenFileDialog1.FileName
            If FileName <> "" Then
                filestream1 = File.Open(FileName, IO.FileMode.Open, FileAccess.Read)
                chrstream1 = New System.IO.StreamReader(filestream1)
                'TextBox1.AppendText(chrstream1.ReadToEnd)
            End If
        End If

    End Sub


End Class
