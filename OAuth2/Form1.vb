'Imports System
'Imports System.Threading.Tasks
Imports System.Text
Imports System.Net
Imports System.IO
'Imports Newtonsoft.Json




Public Class Form1

    Const Token As String = "PAST TOKEN HERE"

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim origResponse As HttpWebResponse


    '    Dim origRequest As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://lichess.org/api/account/playing"), HttpWebRequest)
    '    origRequest.Headers.Add("Authorization", "Bearer TOKEN")
    '    origRequest.AllowAutoRedirect = False
    '    origRequest.Method = "GET"
    '    Try
    '        origResponse = DirectCast(origRequest.GetResponse(), HttpWebResponse)
    '        Dim Stream As Stream = origResponse.GetResponseStream()
    '        Dim sr As New StreamReader(Stream, Encoding.GetEncoding("utf-8"))
    '        Dim str As String = sr.ReadToEnd()
    '        MessageBox.Show(str)
    '        Clipboard.SetText(str)
    '    Catch ex As WebException
    '        MsgBox(ex.ToString)

    '    End Try
    'End Sub



    Private Function MakeBotMove(idGame As String, uciMove As String, token As String) As Boolean
        Dim origResponse As HttpWebResponse


        Dim origRequest As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://lichess.org/api/bot/game/" & idGame & "/move/" & uciMove), HttpWebRequest)
        origRequest.Headers.Add("Authorization", "Bearer " & token)
        origRequest.AllowAutoRedirect = False
        origRequest.Method = "POST"
        Try
            origResponse = DirectCast(origRequest.GetResponse(), HttpWebResponse)
            Dim Stream As Stream = origResponse.GetResponseStream()
            Dim sr As New StreamReader(Stream, Encoding.GetEncoding("utf-8"))
            Dim str As String = sr.ReadToEnd()
            Return True
            'MessageBox.Show(str)
            'Clipboard.SetText(str)
        Catch ex As WebException

            'MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Private Function MakeBoardMove(idGame As String, uciMove As String, token As String) As Boolean
        Dim origResponse As HttpWebResponse


        Dim origRequest As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://lichess.org/api/board/game/" & idGame & "/move/" & uciMove), HttpWebRequest)
        origRequest.Headers.Add("Authorization", "Bearer " & token)
        origRequest.AllowAutoRedirect = False
        origRequest.Method = "POST"
        Try
            origResponse = DirectCast(origRequest.GetResponse(), HttpWebResponse)
            Dim Stream As Stream = origResponse.GetResponseStream()
            Dim sr As New StreamReader(Stream, Encoding.GetEncoding("utf-8"))
            Dim str As String = sr.ReadToEnd()
            Return True
            'MessageBox.Show(str)
            'Clipboard.SetText(str)
        Catch ex As WebException

            'MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Private Function GetOngoingGame(token As String) As String
        Dim origResponse As HttpWebResponse


        Dim origRequest As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://lichess.org/api/account/playing"), HttpWebRequest)
        origRequest.Headers.Add("Authorization", "Bearer " & token)
        origRequest.AllowAutoRedirect = False
        origRequest.Method = "GET"
        Try
            origResponse = DirectCast(origRequest.GetResponse(), HttpWebResponse)
            Dim Stream As Stream = origResponse.GetResponseStream()
            Dim sr As New StreamReader(Stream, Encoding.GetEncoding("utf-8"))
            Dim str As String = sr.ReadToEnd()
            Return str
            'MessageBox.Show(str)
            'Clipboard.SetText(str)
        Catch ex As WebException

            'MsgBox(ex.ToString)
            Return ""
        End Try
    End Function

    Private Sub BtnGetProfile_Click(sender As Object, e As EventArgs) Handles btnGetGames.Click
        txtGames.Text = GetOngoingGame(txtToken.Text)
        txtGameId.Text = GetJSONdata(txtGames.Text, "gameId")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtToken.Text = Token

    End Sub



    'renvoie la valeur d'une variable a partir de son nom dans une chaine JSON
    Private Function GetJSONdata(ByVal strJSON As String, ByVal data_name As String, Optional ByVal RemoveCote As Boolean = True) As String
        Dim idStart As Integer
        Dim idEnd As Integer
        Dim Str_tempo As String

        If data_name = "" Then Return ""

        idStart = strJSON.IndexOf("""" & data_name & """:")

        If idStart = -1 Then Return ""

        idStart = idStart + data_name.Length + 3

        idEnd = strJSON.IndexOf(",", idStart)

        'si c'est la dernière variable de la chaine il n'y a pas de , après mais une }
        If idEnd = -1 Then
            idEnd = strJSON.IndexOf("}", idStart)
        End If

        Str_tempo = strJSON.Substring(idStart, idEnd - idStart)

        'on supprime les doubles cotes
        If RemoveCote And Str_tempo.IndexOf("""") = 0 Then
            Str_tempo = Str_tempo.Substring(1, Str_tempo.Length - 2)
        End If

        Return Str_tempo

    End Function

    Private Sub BtnMakeBotMove_Click(sender As Object, e As EventArgs) Handles btnMakeBotMove.Click
        MakeBotMove(txtGameId.Text, txtMove.Text, txtToken.Text)
    End Sub

    Private Sub BtnMakeBoardMove_Click(sender As Object, e As EventArgs) Handles btnMakeBoardMove.Click
        MakeBoardMove(txtGameId.Text, txtMove.Text, txtToken.Text)
    End Sub
End Class
