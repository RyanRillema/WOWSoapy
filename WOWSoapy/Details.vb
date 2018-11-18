Public Class Details
    Dim CurrPos As Integer
    Dim CurrChar As CharDetails
    Dim oSoapyData As SoapyData
    Dim oCharFilter As CharFilter

    Public Sub New(oSetSoapyData As SoapyData)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oSoapyData = oSetSoapyData
        oCharFilter = New CharFilter

        oCharFilter.iMinLevel = 101

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
        oSoapyData.SoapyConst.SetLabelColourByClass(lbClass, oSoapyData.SoapyIO.GetClassName(CurrChar.CharClass))
        lbLevel.Text = CurrChar.Level
        lbItemLevel.Text = ""
        pbPic.ImageLocation = oSoapyData.SoapyIO.getImagePath(CurrChar)
        lbCount.Text = oSoapyData.CharCount & " / " & oSoapyData.AttemptedCharCount
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
            oSoapyData.SoapyConst.SetLabelColour(lbProf1Name)
            lbProf2Name.Text = NameB

            lbProf1Vanilla.Text = CurrChar.getPrimaryProfession(CurrChar, "", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1Vanilla, 300)
            lbProf2Vanilla.Text = CurrChar.getPrimaryProfession(CurrChar, "", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2Vanilla, 300)
            lbProf1BC.Text = CurrChar.getPrimaryProfession(CurrChar, "Outland", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1BC, 75)
            lbProf2BC.Text = CurrChar.getPrimaryProfession(CurrChar, "Outland", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2BC, 75)
            lbProf1FT.Text = CurrChar.getPrimaryProfession(CurrChar, "Northrend", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1FT, 75)
            lbProf2FT.Text = CurrChar.getPrimaryProfession(CurrChar, "Northrend", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2FT, 75)
            lbProf1Cata.Text = CurrChar.getPrimaryProfession(CurrChar, "Cataclysm", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1Cata, 75)
            lbProf2Cata.Text = CurrChar.getPrimaryProfession(CurrChar, "Cataclysm", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2Cata, 75)
            lbProf1Panda.Text = CurrChar.getPrimaryProfession(CurrChar, "Pandaria", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1Panda, 75)
            lbProf2Panda.Text = CurrChar.getPrimaryProfession(CurrChar, "Pandaria", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2Panda, 75)
            lbProf1Draenor.Text = CurrChar.getPrimaryProfession(CurrChar, "Draenor", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1Draenor, 100)
            lbProf2Draenor.Text = CurrChar.getPrimaryProfession(CurrChar, "Draenor", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2Draenor, 100)
            lbProf1Legion.Text = CurrChar.getPrimaryProfession(CurrChar, "Legion", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1Legion, 100)
            lbProf2Legion.Text = CurrChar.getPrimaryProfession(CurrChar, "Legion", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2Legion, 100)
            lbProf1Azeroth.Text = CurrChar.getPrimaryProfession(CurrChar, "Kul Tiran", NameA).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf1Azeroth, 150)
            lbProf2Azeroth.Text = CurrChar.getPrimaryProfession(CurrChar, "Kul Tiran", NameB).Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbProf2Azeroth, 150)

            lbCookingVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingVanilla, 300)
            lbFishingVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingVanilla, 300)
            lbCookingBC.Text = CurrChar.getSecondaryProfession(CurrChar, "Outland", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingBC, 75)
            lbFishingBC.Text = CurrChar.getSecondaryProfession(CurrChar, "Outland", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingBC, 75)
            lbCookingFT.Text = CurrChar.getSecondaryProfession(CurrChar, "Northrend", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingFT, 75)
            lbFishingFT.Text = CurrChar.getSecondaryProfession(CurrChar, "Northrend", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingFT, 75)
            lbCookingCata.Text = CurrChar.getSecondaryProfession(CurrChar, "Cataclysm", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingCata, 75)
            lbFishingCata.Text = CurrChar.getSecondaryProfession(CurrChar, "Cataclysm", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingCata, 75)
            lbCookingPanda.Text = CurrChar.getSecondaryProfession(CurrChar, "Pandaria", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingPanda, 75)
            lbFishingPanda.Text = CurrChar.getSecondaryProfession(CurrChar, "Pandaria", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingPanda, 75)
            lbCookingDraenor.Text = CurrChar.getSecondaryProfession(CurrChar, "Draenor", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingDraenor, 100)
            lbFishingDraenor.Text = CurrChar.getSecondaryProfession(CurrChar, "Draenor", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingDraenor, 100)
            lbCookingLegion.Text = CurrChar.getSecondaryProfession(CurrChar, "Legion", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingLegion, 100)
            lbFishingLegion.Text = CurrChar.getSecondaryProfession(CurrChar, "Legion", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingLegion, 100)
            lbCookingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Kul Tiran", "Cooking").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbCookingAzeroth, 150)
            lbFishingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Kul Tiran", "Fishing").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbFishingAzeroth, 150)
            lbArchaelogyVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Archaeology").Rank
            oSoapyData.SoapyConst.SetLabelColourByValue(lbArchaelogyVanilla, 950)

        Catch
        End Try

    End Sub

    'Private functions
    Private Sub NextChar()
        Dim bNextFound As Boolean

        Try

            While (Not bNextFound) And (CurrPos < oSoapyData.AttemptedCharCount)

                CurrPos = CurrPos + 1
                bNextFound = oCharFilter.MatchesFilter(oSoapyData.Chars(CurrPos))

            End While

            RefreshForm()

        Catch ex As Exception

        End Try
    End Sub

    'Button functions
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        HideForm()
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        NextChar()
    End Sub

    Private Sub cmdPrevious_Click(sender As Object, e As EventArgs) Handles cmdPrevious.Click
        If CurrPos > 1 Then
            CurrPos = CurrPos - 1
            RefreshForm()
        End If
    End Sub

End Class