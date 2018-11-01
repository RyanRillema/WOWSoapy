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
        lbLevel.Text = CurrChar.Level
        lbItemLevel.Text = ""
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
            lbFishingVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Fishing").Rank
            lbCookingBC.Text = CurrChar.getSecondaryProfession(CurrChar, "Outland", "Cooking").Rank
            lbFishingBC.Text = CurrChar.getSecondaryProfession(CurrChar, "Outland", "Fishing").Rank
            lbCookingFT.Text = CurrChar.getSecondaryProfession(CurrChar, "Northrend", "Cooking").Rank
            lbFishingFT.Text = CurrChar.getSecondaryProfession(CurrChar, "Northrend", "Fishing").Rank
            lbCookingCata.Text = CurrChar.getSecondaryProfession(CurrChar, "Cataclysm", "Cooking").Rank
            lbFishingCata.Text = CurrChar.getSecondaryProfession(CurrChar, "Cataclysm", "Fishing").Rank
            lbCookingPanda.Text = CurrChar.getSecondaryProfession(CurrChar, "Pandaria", "Cooking").Rank
            lbFishingPanda.Text = CurrChar.getSecondaryProfession(CurrChar, "Pandaria", "Fishing").Rank
            lbCookingDraenor.Text = CurrChar.getSecondaryProfession(CurrChar, "Draenor", "Cooking").Rank
            lbFishingDraenor.Text = CurrChar.getSecondaryProfession(CurrChar, "Draenor", "Fishing").Rank
            lbCookingLegion.Text = CurrChar.getSecondaryProfession(CurrChar, "Legion", "Cooking").Rank
            lbFishingLegion.Text = CurrChar.getSecondaryProfession(CurrChar, "Legion", "Fishing").Rank
            lbCookingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Kul Tiran", "Cooking").Rank
            lbFishingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Kul Tiran", "Fishing").Rank
            lbArchaelogyVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Archaeology").Rank

        Catch
        End Try

    End Sub

    Private Sub SetLabelColour(ByRef oLblLabel As Label)

        oLblLabel.ForeColor = Color.Blue

    End Sub

    Private Sub SetLabelColourByValue(ByRef oLblLabel As Label, iMaxValue As Integer)

        Dim iSegments = iMaxValue / 25
        Dim iLabelValue = oLblLabel.Text

        Select Case iLabelValue
            Case 0
                oLblLabel.ForeColor = Color.Red

            'Case < iSegments / 3 * 25

            Case iMaxValue
                oLblLabel.ForeColor = Color.Green

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