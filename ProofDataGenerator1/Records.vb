
Imports System
Imports System.IO
Imports System.Text

Public Class Records


    Public Shared sw As StreamWriter = New StreamWriter(Form1.DirectoryName & "\" & Form1.Result & "_PROOF.txt") ' Affix Proof to end of filename

    Public Shared Sub FiveFromTop()



        sw.WriteLine(Form1.StringReader(0)) ' Get the Headers

        For x = 1 To 5

            sw.WriteLine(Form1.StringReader(x))
            Form1.ListView1.Text = Form1.StringReader(x)
        Next
        sw.Close()

        MsgBox("Proof Data Generated and Saved at: " & Form1.DirectoryName,, "COMPLETE")

    End Sub

    Public Shared Sub FiveFromBottom()

        sw.WriteLine(Form1.StringReader(0)) ' Get the Headers

        For x = (Form1.StringReader.Count() - 1) - 6 To (Form1.StringReader.Count() - 1)

            sw.WriteLine(Form1.StringReader(x))

        Next

        MsgBox("Proof Data Generated and Saved at: " & Form1.DirectoryName,, "COMPLETE")

    End Sub

    Public Shared Sub TenFromTop()

        sw.WriteLine(Form1.StringReader(0)) ' Get the Headers

        For x = 1 To 10

            sw.WriteLine(Form1.StringReader(x))

        Next
        sw.Close()
        MsgBox("Proof Data Generated and Saved at: " & Form1.DirectoryName,, "COMPLETE")



    End Sub

    Public Shared Sub TenFromBottom()

        sw.WriteLine(Form1.StringReader(0)) ' Get the Headers

        For x = (Form1.StringReader.Count() - 1) - 10 To (Form1.StringReader.Count() - 1)

            sw.WriteLine(Form1.StringReader(x))

        Next
        MsgBox("Proof Data Generated and Saved at: " & Form1.DirectoryName,, "COMPLETE")
        sw.Close()



    End Sub

    Public Shared Sub TwentyRandom()

        sw.WriteLine(Form1.StringReader(0)) ' Get the Headers

        Dim TempNumber As Integer
        Dim Random As New Random
        Dim myList As List(Of String) = Form1.StringReader.ToList()

        For i = 1 To 20

            TempNumber = Random.Next(0, myList.Count)
            myList.RemoveAt(TempNumber)
            sw.WriteLine(Form1.StringReader(TempNumber))

        Next i

        MsgBox("Proof Data Generated and Saved at: " & Form1.DirectoryName,, "COMPLETE")
        sw.Close()


    End Sub

    Public Shared Sub Specify()

        sw.WriteLine(Form1.StringReader(0)) ' Get the Headers

        Dim y As Integer
        y = InputBox("Enter Amount of Records", "Amount of Records")

        Dim TempNumber As Integer
        Dim Random As New Random
        Dim myList As List(Of String) = Form1.StringReader.ToList()

        For i = 1 To y

            TempNumber = Random.Next(0, myList.Count)
            myList.RemoveAt(TempNumber)
            sw.WriteLine(Form1.StringReader(TempNumber))

        Next i

        MsgBox("Proof Data Generated and Saved at: " & Form1.DirectoryName,, "COMPLETE")
        sw.Close()



    End Sub


End Class
