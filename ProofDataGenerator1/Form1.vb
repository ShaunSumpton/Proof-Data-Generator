
Imports System
Imports System.IO
Imports System.Text


Public Class Form1

    Public StringReader() As String
    Public myStream As FileStream
    Public DirectoryName As String
    Public Result As String
    Public Btn1Click As Boolean



    Public Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click

        Dim fileReader As System.IO.StreamReader
        Dim openFileDialog1 As New OpenFileDialog()

        Btn1Click = True
        openFileDialog1.InitialDirectory = "Z:\"
        openFileDialog1.Filter = "Text Files|*.txt" '"txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then

                    fileReader =
                    My.Computer.FileSystem.OpenTextFileReader(myStream.Name)


                    StringReader = File.ReadAllLines(myStream.Name)

                End If
            Catch Ex As Exception

                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.

                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            DirectoryName = Path.GetDirectoryName(myStream.Name)
            Result = Path.GetFileNameWithoutExtension(myStream.Name)

            If ComboBox1.Text <> "" Then
                Select Case ComboBox1.Text

                    Case "5 From the top"

                        Records.FiveFromTop()


                    Case "5 From the bottom"

                        Records.FiveFromBottom()

                    Case "10 From the top"

                        Records.TenFromTop()


                    Case "10 From the bottom"

                        Records.TenFromBottom()


                    Case "20 Random Records"

                        Records.TwentyRandom()

                    Case "xx Random Records (Specify Amount)"

                        Records.Specify()
                End Select
            Else
                MsgBox("No proof type selected",, "ERROR!")
            End If
        Catch
            MsgBox("Make Sure you Select the data file First", MsgBoxStyle.Critical, "ERROR!")
        End Try
        Me.Close()
    End Sub

End Class

