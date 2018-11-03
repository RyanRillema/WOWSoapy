Public Class Details
    Dim CurrPos As Integer
    Dim CurrChar As CharDetails
    Dim oSoapyData As SoapyData

    Public Sub New(oSetSoapyData As SoapyData)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oSoapyData = oSetSoapyData

    End Sub

    Public Sub ShowForm(iChar As Integer)
        CurrPos = iChar
        Me.Show()
        RefreshForm()
    End Sub

    Public Sub HideForm()
        Me.Hide()
    End Sub

    Private Sub RefreshForm()
        CurrChar = oSoapyData.Chars(CurrPos)
        RefreshGeneral()
        RefreshNotes()
        RefreshProfs()
    End Sub

    Private Sub RefreshGeneral()
        lbName.Text = CurrChar.Name
        lbRealm.Text = CurrChar.Realm
        lbClass.Text = oSoapyData.SoapyIO.GetClassName(CurrChar.CharClass)
        SetLabelColourByClass(lbClass, oSoapyData.SoapyIO.GetClassName(CurrChar.CharClass))
        lbLevel.Text = CurrChar.Level
        lbItemLevel.Text = ""
        pbPic.ImageLocation = oSoapyData.SoapyIO.getImagePath(CurrChar)
    End Sub

    Private Sub RefreshNotes()
        lbBagNotes.Text = CurrChar.BagNotes
    End Sub

    Private Sub RefreshProfs()
        Dim NameA, NameB, NameTemp As String

        Try
            NameTemp = CurrChar.Professions.Primary(0).Name
            NameA = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)
            'Temp fix - We need to find a better way to do this
            If NameA.IndexOf(" ") <> 0 Then
                NameA = NameA.Substring(NameA.IndexOf(" ") + 1)
            End If
            NameTemp = CurrChar.Professions.Primary(CurrChar.Professions.Primary.Count - 1).Name
            NameTemp = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)
            'More temp fixes :(
            If NameTemp = NameA Then
                NameTemp = CurrChar.Professions.Primary(CurrChar.Professions.Primary.Count - 2).Name
                NameTemp = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)
            End If
            If NameTemp = NameA Then
                NameTemp = CurrChar.Professions.Primary(CurrChar.Professions.Primary.Count - 3).Name
                NameTemp = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)
            End If
            NameB = NameTemp.Substring(NameTemp.IndexOf(" ") + 1)
            If NameB.IndexOf(" ") <> 0 Then
                NameB = NameB.Substring(NameB.IndexOf(" ") + 1)
            End If

            'Headings
            lbProf1Name.Text = NameA
            SetLabelColour(lbProf1Name)
            lbProf2Name.Text = NameB

            lbProf1Vanilla.Text = CurrChar.getPrimaryProfession(CurrChar, "", NameA).Rank
            SetLabelColourByValue(lbProf1Vanilla, 300)
            lbProf2Vanilla.Text = CurrChar.getPrimaryProfession(CurrChar, "", NameB).Rank
            SetLabelColourByValue(lbProf2Vanilla, 300)
            lbProf1BC.Text = CurrChar.getPrimaryProfession(CurrChar, "Outland", NameA).Rank
            SetLabelColourByValue(lbProf1BC, 75)
            lbProf2BC.Text = CurrChar.getPrimaryProfession(CurrChar, "Outland", NameB).Rank
            SetLabelColourByValue(lbProf2BC, 75)
            lbProf1FT.Text = CurrChar.getPrimaryProfession(CurrChar, "Northrend", NameA).Rank
            SetLabelColourByValue(lbProf1FT, 75)
            lbProf2FT.Text = CurrChar.getPrimaryProfession(CurrChar, "Northrend", NameB).Rank
            SetLabelColourByValue(lbProf2FT, 75)
            lbProf1Cata.Text = CurrChar.getPrimaryProfession(CurrChar, "Cataclysm", NameA).Rank
            SetLabelColourByValue(lbProf1Cata, 75)
            lbProf2Cata.Text = CurrChar.getPrimaryProfession(CurrChar, "Cataclysm", NameB).Rank
            SetLabelColourByValue(lbProf2Cata, 75)
            lbProf1Panda.Text = CurrChar.getPrimaryProfession(CurrChar, "Pandaria", NameA).Rank
            SetLabelColourByValue(lbProf1Panda, 75)
            lbProf2Panda.Text = CurrChar.getPrimaryProfession(CurrChar, "Pandaria", NameB).Rank
            SetLabelColourByValue(lbProf2Panda, 75)
            lbProf1Draenor.Text = CurrChar.getPrimaryProfession(CurrChar, "Draenor", NameA).Rank
            SetLabelColourByValue(lbProf1Draenor, 100)
            lbProf2Draenor.Text = CurrChar.getPrimaryProfession(CurrChar, "Draenor", NameB).Rank
            SetLabelColourByValue(lbProf2Draenor, 100)
            lbProf1Legion.Text = CurrChar.getPrimaryProfession(CurrChar, "Legion", NameA).Rank
            SetLabelColourByValue(lbProf1Legion, 100)
            lbProf2Legion.Text = CurrChar.getPrimaryProfession(CurrChar, "Legion", NameB).Rank
            SetLabelColourByValue(lbProf2Legion, 100)
            lbProf1Azeroth.Text = CurrChar.getPrimaryProfession(CurrChar, "Kul Tiran", NameA).Rank
            SetLabelColourByValue(lbProf1Azeroth, 150)
            lbProf2Azeroth.Text = CurrChar.getPrimaryProfession(CurrChar, "Kul Tiran", NameB).Rank
            SetLabelColourByValue(lbProf2Azeroth, 150)

            lbCookingVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Cooking").Rank
            SetLabelColourByValue(lbCookingVanilla, 300)
            lbFishingVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Fishing").Rank
            SetLabelColourByValue(lbFishingVanilla, 300)
            lbCookingBC.Text = CurrChar.getSecondaryProfession(CurrChar, "Outland", "Cooking").Rank
            SetLabelColourByValue(lbCookingBC, 75)
            lbFishingBC.Text = CurrChar.getSecondaryProfession(CurrChar, "Outland", "Fishing").Rank
            SetLabelColourByValue(lbFishingBC, 75)
            lbCookingFT.Text = CurrChar.getSecondaryProfession(CurrChar, "Northrend", "Cooking").Rank
            SetLabelColourByValue(lbCookingFT, 75)
            lbFishingFT.Text = CurrChar.getSecondaryProfession(CurrChar, "Northrend", "Fishing").Rank
            SetLabelColourByValue(lbFishingFT, 75)
            lbCookingCata.Text = CurrChar.getSecondaryProfession(CurrChar, "Cataclysm", "Cooking").Rank
            SetLabelColourByValue(lbCookingCata, 75)
            lbFishingCata.Text = CurrChar.getSecondaryProfession(CurrChar, "Cataclysm", "Fishing").Rank
            SetLabelColourByValue(lbFishingCata, 75)
            lbCookingPanda.Text = CurrChar.getSecondaryProfession(CurrChar, "Pandaria", "Cooking").Rank
            SetLabelColourByValue(lbCookingPanda, 75)
            lbFishingPanda.Text = CurrChar.getSecondaryProfession(CurrChar, "Pandaria", "Fishing").Rank
            SetLabelColourByValue(lbFishingPanda, 75)
            lbCookingDraenor.Text = CurrChar.getSecondaryProfession(CurrChar, "Draenor", "Cooking").Rank
            SetLabelColourByValue(lbCookingDraenor, 100)
            lbFishingDraenor.Text = CurrChar.getSecondaryProfession(CurrChar, "Draenor", "Fishing").Rank
            SetLabelColourByValue(lbFishingDraenor, 100)
            lbCookingLegion.Text = CurrChar.getSecondaryProfession(CurrChar, "Legion", "Cooking").Rank
            SetLabelColourByValue(lbCookingLegion, 100)
            lbFishingLegion.Text = CurrChar.getSecondaryProfession(CurrChar, "Legion", "Fishing").Rank
            SetLabelColourByValue(lbFishingLegion, 100)
            lbCookingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Kul Tiran", "Cooking").Rank
            SetLabelColourByValue(lbCookingAzeroth, 150)
            lbFishingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Kul Tiran", "Fishing").Rank
            SetLabelColourByValue(lbFishingAzeroth, 150)
            lbArchaelogyVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Archaeology").Rank
            SetLabelColourByValue(lbArchaelogyVanilla, 950)

        Catch
        End Try

    End Sub

    Private Sub SetLabelColour(ByRef oLblLabel As Label)

        oLblLabel.ForeColor = Color.Blue

    End Sub

    Private Sub SetLabelColourByValue(ByRef oLblLabel As Label, iMaxValue As Integer)

        Dim iSegments As Integer = iMaxValue / 25
        Dim iLabelValue As Integer = oLblLabel.Text

        Select Case iLabelValue
            Case 0
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourLevelZero

            Case <= 10 * iSegments
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourLevelLow

            Case <= 15 * iSegments
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourLevelMedium

            Case < 25 * iSegments
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourLevelHigh

            Case iMaxValue
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourLevelFull

            Case Else
                oLblLabel.ForeColor = Color.Black

        End Select

    End Sub

    Private Sub SetLabelColourByClass(ByRef oLblLabel As Label, sClass As String)

        Select Case sClass
            Case "Death Knight"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassDeathKnight
            Case "Demon Hunter"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassDemonHunter
            Case "Druid"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassDruid
            Case "Hunter"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassHunter
            Case "Mage"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassMage
            Case "Monk"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassMonk
            Case "Paladin"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassPaladin
            Case "Priest"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassPriest
            Case "Rogue"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassRogue
            Case "Shaman"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassShaman
            Case "Warlock"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassWarlock
            Case "Warrior"
                oLblLabel.ForeColor = oSoapyData.SoapyConst.ColourClassWarrior
            Case Else
                oLblLabel.ForeColor = Color.Black
        End Select

    End Sub

    'Button functions
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        HideForm()
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        If CurrPos < oSoapyData.CharCount Then
            CurrPos = CurrPos + 1
            RefreshForm()
        End If
    End Sub

    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        If CurrPos > 1 Then
            CurrPos = CurrPos - 1
            RefreshForm()
        End If
    End Sub

End Class