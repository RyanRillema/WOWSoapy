Public Class SoapyConst

    'General
    Public Version As String = "0.2.0"

    'Headings
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

    Public ColourClassDeathKnight As Color = Color.FromArgb(196, 30, 59)
    Public ColourClassDemonHunter As Color = Color.FromArgb(163, 48, 201)
    Public ColourClassDruid As Color = Color.FromArgb(255, 125, 10)
    Public ColourClassHunter As Color = Color.FromArgb(171, 212, 115)
    Public ColourClassMage As Color = Color.FromArgb(105, 204, 240)
    Public ColourClassMonk As Color = Color.FromArgb(0, 255, 150)
    Public ColourClassPaladin As Color = Color.FromArgb(245, 140, 186)
    Public ColourClassPriest As Color = Color.FromArgb(255, 255, 255)
    Public ColourClassRogue As Color = Color.FromArgb(255, 245, 105)
    Public ColourClassShaman As Color = Color.FromArgb(0, 112, 222)
    Public ColourClassWarlock As Color = Color.FromArgb(148, 130, 201)
    Public ColourClassWarrior As Color = Color.FromArgb(199, 156, 110)

    'http:// <region> + .battle.net/static-render/ + <region> + / + <the string you got from API as thumbnail>

    Public Sub New()
        SetConst()
    End Sub

    Public Function GetBagNotes(sName As String, sRealm As String) As String
        Dim sBagNotes As String

        sBagNotes = ""

        Select Case sRealm
            Case LightCased
                Select Case sName
                    Case ""
                        sBagNotes = ""
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
                    Case "Frozenstar"
                        sBagNotes = "Excess Herbs, Herb fractions"
                    Case "Momonk"
                        sBagNotes = "Enchanting items"
                End Select

            Case MazigrosCased
                Select Case sName
                    Case ""
                        sBagNotes = ""
                    Case "Splifshot"
                        sBagNotes = "Inscription items"
                    Case "Loneshot"
                        sBagNotes = "Legion Herbs?"
                End Select

        End Select

        Return sBagNotes
    End Function

    Public Function GetRealesNotes(Optional sVersion As String = "All") As String
        Dim sNotes As String = ""

        'Check all
        Select Case sVersion
            Case "0.1.1", "All"
                sNotes = sNotes & "/n" & "Intital Release"
            Case "0.2.0", "All"
                sNotes = sNotes & "/n" & "Add details form functionality. Added to Git source control"
        End Select

        Return sNotes
    End Function

    Public Function GetVersion() As String
        Return "Version: " & Version
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

