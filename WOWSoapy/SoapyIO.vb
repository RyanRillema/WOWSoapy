Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class SoapyIO

    Public SoapyData As SoapyData
    Public iCharCount As Integer
    Public bLookupData As Boolean
    Public serializer As JsonSerializer
    Public SoapReader As StreamReader
    Public dataStream As Stream
    Public request As WebRequest
    Public response As WebResponse
    Public OutputStream As StreamWriter
    Public TestData(100, 2) As String

    Public Sub New(SetSoapyData As SoapyData)
        SoapyData = SetSoapyData
    End Sub

    'Import functions
    Public Sub LoadAllChars()
        Dim iLoop As Integer

        If Not bLookupData Then
            LoadLookupData()
        End If

        iCharCount = 1

        Test_PopulateMyData()

        For iLoop = 1 To 100

            If TestData(iLoop, 1) <> "" Then

                If GetCharData(SoapyData.Chars(iCharCount), TestData(iLoop, 1), TestData(iLoop, 2)) Then
                    iCharCount = iCharCount + 1
                End If

            End If

        Next

        'SoapyData.SortCharArrayByLevel()

        If iCharCount < 100 Then

        End If

    End Sub

    Private Function GetCharData(ByRef CharDetails As CharDetails, Name As String, Realm As String) As Boolean
        ' Create a request for the URL. 
        Dim responseFromServer As String
        Dim ReturnValue As Boolean

        Try

            request = WebRequest.Create("https://eu.api.battle.net/wow/character/" & Realm & "/" & Name & "?fields=professions&locale=en_GB&apikey=yx3b77qkavurjuvyjyyeyvr6t9hhpr9m")

            ' If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials
            ' Get the response.
            response = request.GetResponse()

            dataStream = response.GetResponseStream()

            ' Open the stream using a StreamReader for easy access.
            SoapReader = New StreamReader(dataStream)
            ' Read the content.
            responseFromServer = SoapReader.ReadToEnd()

            CharDetails = JsonConvert.DeserializeObject(Of CharDetails)(responseFromServer)

            ReturnValue = True

        Catch

        End Try

        ' Clean up the streams and the response.
        response.Close()

        Return ReturnValue

    End Function

    Public Sub LoadLookupData()

        LoadRaceData()
        LoadClassData()

        bLookupData = True

    End Sub

    Private Sub LoadRaceData()
        Dim responseFromServer As String

        Try

            request = WebRequest.Create("https://us.api.battle.net/wow/data/character/races?locale=en_US&apikey=yx3b77qkavurjuvyjyyeyvr6t9hhpr9m")

            ' If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials
            ' Get the response.
            response = request.GetResponse()

            dataStream = response.GetResponseStream()

            ' Open the stream using a StreamReader for easy access.
            SoapReader = New StreamReader(dataStream)
            ' Read the content.
            responseFromServer = SoapReader.ReadToEnd()

            SoapyData.Races = JsonConvert.DeserializeObject(Of Races)(responseFromServer)

        Catch

        End Try

        ' Clean up the streams and the response.
        response.Close()

    End Sub

    Private Sub LoadClassData()
        Dim responseFromServer As String

        Try

            request = WebRequest.Create("https://us.api.battle.net/wow/data/character/classes?locale=en_US&apikey=yx3b77qkavurjuvyjyyeyvr6t9hhpr9m")

            ' If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials
            ' Get the response.
            response = request.GetResponse()

            dataStream = response.GetResponseStream()

            ' Open the stream using a StreamReader for easy access.
            SoapReader = New StreamReader(dataStream)
            ' Read the content.
            responseFromServer = SoapReader.ReadToEnd()

            SoapyData.Classes = JsonConvert.DeserializeObject(Of Classes)(responseFromServer)

        Catch

        End Try

        ' Clean up the streams and the response.
        response.Close()

    End Sub

    'Output functions
    Public Sub OutputAllChars_CSV()
        Dim iCharLoop As Integer
        Dim Realm = New String("")

        OpenOutputStreams()

        OutputHeadings(SoapyData.SoapyConst.Headings)

        For iCharLoop = 1 To iCharCount

            If Not IsNothing(SoapyData.Chars(iCharLoop)) Then

                If Realm <> SoapyData.Chars(iCharLoop).Realm Then

                    Realm = SoapyData.Chars(iCharLoop).Realm

                    OutputRealm(Realm)

                End If

                OutputChar_CSV(SoapyData.Chars(iCharLoop))

            End If

        Next

        CloseOutputStream()

    End Sub

    Private Sub OutputChar_CSV(CharDetails As CharDetails)
        Dim OutputLine As String

        ' Basic details (Name, Level, Achievement Points, Class, Race
        OutputLine = CharDetails.Name & "," & CharDetails.Level & "," & GetClassName(CharDetails.CharClass) & "," & GetRaceName(CharDetails.Race)

        Try
            'Professions are only valid once chosen in game

            'Primary professions (Prof1 Name, Prof1 Value, prof2 Name, prof2 Value)
            OutputChar_CSV_PrimaryProfs(OutputLine, CharDetails)

            'Secondary professions (Arch, Fish, Cook)
            OutputChar_CSV_SecondaryProfs(OutputLine, CharDetails)

        Catch

        End Try

        OutputStream.WriteLine(OutputLine)

    End Sub

    Private Sub OutputChar_CSV_PrimaryProfs(ByRef OutputLine As String, CharDetails As CharDetails)
        Dim NameA, NameB, NameTemp As String

        NameTemp = CharDetails.Professions.Primary(0).Name
        NameA = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)
        NameTemp = CharDetails.Professions.Primary(CharDetails.Professions.Primary.Count - 1).Name
        NameB = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)

        'Temp fix
        If NameA = NameB Then
            NameTemp = CharDetails.Professions.Primary(CharDetails.Professions.Primary.Count - 2).Name
            NameB = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)
        End If

        OutputLine = OutputLine & "," & NameA & "," & NameB
        OutputLine = OutputLine & "," & CharDetails.getPrimaryProfession(CharDetails, "Legion", NameA).Rank
        OutputLine = OutputLine & "," & CharDetails.getPrimaryProfession(CharDetails, "Draenor", NameA).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Pandaria", NameA).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Cataclysm", NameA).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Northrend", NameA).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Outland", NameA).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "", NameA).Rank

        OutputLine = OutputLine & "," & CharDetails.getPrimaryProfession(CharDetails, "Legion", NameB).Rank
        OutputLine = OutputLine & "," & CharDetails.getPrimaryProfession(CharDetails, "Draenor", NameB).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Pandaria", NameB).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Cataclysm", NameB).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Northrend", NameB).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "Outland", NameB).Rank & ","
        OutputLine = OutputLine & CharDetails.getPrimaryProfession(CharDetails, "", NameB).Rank

    End Sub

    Private Sub OutputChar_CSV_SecondaryProfs(ByRef OutputLine As String, CharDetails As CharDetails)

        OutputLine = OutputLine & "," & CharDetails.getSecondaryProfession(CharDetails, "", "Fishing").Rank
        OutputLine = OutputLine & "," & CharDetails.getSecondaryProfession(CharDetails, "", "Cooking").Rank
        OutputLine = OutputLine & "," & CharDetails.getSecondaryProfession(CharDetails, "", "Archaeology").Rank

    End Sub

    Private Function GetClassName(Index As Integer)
        Dim iLoop As Integer
        Dim ReturnName = New String("")

        For iLoop = 0 To SoapyData.Classes.Classes.Length - 1
            If SoapyData.Classes.Classes(iLoop).Id = Index Then
                ReturnName = SoapyData.Classes.Classes(iLoop).Name
            End If
        Next

        Return ReturnName
    End Function

    Private Function GetRaceName(Index As Integer)
        Dim iLoop As Integer
        Dim ReturnName = New String("")

        For iLoop = 0 To SoapyData.Races.Races.Length - 1
            If SoapyData.Races.Races(iLoop).Id = Index Then
                ReturnName = SoapyData.Races.Races(iLoop).Name
            End If
        Next

        Return ReturnName
    End Function

    Private Sub OutputHeadings(Headings() As String)
        Dim iLoop As Integer
        Dim OutputLine = New String("")

        For iLoop = 1 To SoapyData.SoapyConst.HeadingCount

            OutputLine = OutputLine & Headings(iLoop)

            If iLoop <> SoapyData.SoapyConst.HeadingCount Then

                OutputLine = OutputLine & ","

            End If

        Next

        OutputStream.WriteLine(OutputLine)

    End Sub

    Private Sub OutputRealm(Realm As String)

        OutputStream.WriteLine(Realm)

    End Sub

    Private Sub OpenOutputStreams()
        OutputStream = New StreamWriter("C:\FTPTemp\Test.csv")
    End Sub

    Private Sub CloseOutputStream()
        OutputStream.Close()
    End Sub

    'TEST
    Public Sub Test_PopulateMyData()
        Dim Light = New String("lightbringer")
        Dim Mazigros = New String("mazrigos")
        Dim Nagrand = New String("nagrand")
        Dim Kilrogg = New String("kilrogg")
        Dim Rune = New String("runetotem")
        Dim Blood = New String("bloodhoof")
        Dim Chamber = New String("chamber of aspects")
        Dim Quel = New String("quel 'thalas")

        Dim Count As Integer

        'Lightbringer
        Count += 1
        TestData(Count, 1) = "ryanhunter"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "greyly"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "shroomhunter"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "ragmor"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "moonlock"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "softshadow"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "frozenstar"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "momonk"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "shamrone"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "steelsaint"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "valkorn"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "zilidan"
        TestData(Count, 2) = Light
        Count += 1
        TestData(Count, 1) = "leaflet"
        TestData(Count, 2) = Light

        'Mazigros
        Count += 1
        TestData(Count, 1) = "ryui"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "loneshot"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "superjock"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "splifshot"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "blackfrost"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "greensly"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "greylocks"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "solidsaint"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "softleaf"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "foxyshot"
        TestData(Count, 2) = Mazigros
        Count += 1
        TestData(Count, 1) = "lunertic"
        TestData(Count, 2) = Mazigros

        'Nagrand
        Count += 1
        TestData(Count, 1) = "leafygreens"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "longshot"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "blazeshadow"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "furryshot"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "thehuntsmen"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "fireshot"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "shadowhuntin"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "stormywaters"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "blueshot"
        TestData(Count, 2) = Nagrand
        Count += 1
        TestData(Count, 1) = "fuzzyshot"
        TestData(Count, 2) = Nagrand

        'Kilrogg
        Count += 1
        TestData(Count, 1) = "becky"
        TestData(Count, 2) = Kilrogg
        Count += 1
        TestData(Count, 1) = "stilwaters"
        TestData(Count, 2) = Kilrogg
        Count += 1
        TestData(Count, 1) = "cory"
        TestData(Count, 2) = Kilrogg
        Count += 1
        TestData(Count, 1) = "heartshot"
        TestData(Count, 2) = Kilrogg
        Count += 1
        TestData(Count, 1) = "leafshadow"
        TestData(Count, 2) = Kilrogg
        Count += 1
        TestData(Count, 1) = "fuzzles"
        TestData(Count, 2) = Kilrogg
        Count += 1
        TestData(Count, 1) = "roughshot"
        TestData(Count, 2) = Kilrogg

        'Runetotem
        Count += 1
        TestData(Count, 1) = "loneshot"
        TestData(Count, 2) = Rune
        Count += 1
        TestData(Count, 1) = "fuzzles"
        TestData(Count, 2) = Rune

        SoapyData.CharCount = Count

    End Sub

End Class
