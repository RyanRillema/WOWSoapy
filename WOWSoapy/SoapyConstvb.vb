Public Class SoapyConst
    Public HeadingCount As Integer = 23
    Public Headings(36) As String

    'Realms
    Public LightCased = New String("Lightbringer")
    Public MazigrosCased = New String("Mazrigos")
    Public NagrandCased = New String("Nagrand")
    Public KilroggCased = New String("Kilrogg")
    Public RuneCased = New String("Runetotem")
    Public BloodCased = New String("Bloodhoof")
    Public ChamberCased = New String("Chamber of Aspects")
    Public QuelCased = New String("Quel 'thalas")

    'Colour
    Public ColourLevelZero As Color = Color.Red
    Public ColourLevelLow As Color = Color.OrangeRed
    Public ColourLevelMedium As Color = Color.SpringGreen
    Public ColourLevelHigh As Color = Color.YellowGreen
    Public ColourLevelFull As Color = Color.Green

    Public Sub New()
        SetConst()
    End Sub

    Public Function GetBagNotes(sName As String, sRealm As String) As String
        Dim sBagNotes As String

        sBagNotes = ""

        Select Case sRealm
            Case Lightcased
                Select Case sName
                    Case "Ryanhunter"
                        sBagNotes = "Pet items"
                    Case "Shroomhunter"
                        sBagNotes = "Excess Ore, Excess Stone, Anvils"
                    Case "Beardsly"
                        sBagNotes = ""
                    Case "Ragmor"
                        sBagNotes = "Lockboxes, Grinding Stones, Draenor Gear"
                    Case "Moonlock"
                        sBagNotes = "Excess cloth, Bolts of cloth"
                    Case "Softshadow"
                        sBagNotes = "Excess Leather, Leather Hide, Scales"
                    Case "Momonk"
                        sBagNotes = "Enchanting items"
                End Select

            Case MazigrosCased
                Select Case sName
                    Case "Splifshot"
                        sBagNotes = "Inscription items"
                    Case "Greyly"
                        sBagNotes = "Test 2"
                    Case "Shroomhunter"
                        sBagNotes = "Test"
                End Select

        End Select

        Return sBagNotes
    End Function

    Private Sub SetConst()
        Headings(1) = "Name"
        Headings(2) = "Level"
        Headings(3) = "Class"
        Headings(4) = "Race"
        Headings(5) = "Prof 1"
        Headings(6) = "Prof 2"
        Headings(7) = "Leg"
        Headings(8) = "Dran"
        Headings(9) = "Pand"
        Headings(10) = "Cata"
        Headings(11) = "Nort"
        Headings(12) = "Out"
        Headings(13) = "Base"
        Headings(14) = "Leg"
        Headings(15) = "Dran"
        Headings(16) = "Pand"
        Headings(17) = "Cata"
        Headings(18) = "Nort"
        Headings(19) = "Out"
        Headings(20) = "Base"
        Headings(21) = "Fishing"
        Headings(22) = "Cooking"
        Headings(23) = "Archeology"
    End Sub

End Class

