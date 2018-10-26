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
        RefreshProfs()
    End Sub

    Private Sub RefreshGeneral()
        lbName.Text = CurrChar.Name
        lbRealm.Text = CurrChar.Realm
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
            lbProf2Name.Text = NameB

            lbProf1Vanilla.Text = CurrChar.getPrimaryProfession(CurrChar, "", NameA).Rank
            lbProf2Vanilla.Text = CurrChar.getPrimaryProfession(CurrChar, "", NameB).Rank
            lbProf1BC.Text = CurrChar.getPrimaryProfession(CurrChar, "Outland", NameA).Rank
            lbProf2BC.Text = CurrChar.getPrimaryProfession(CurrChar, "Outland", NameB).Rank
            lbProf1FT.Text = CurrChar.getPrimaryProfession(CurrChar, "Northrend", NameA).Rank
            lbProf2FT.Text = CurrChar.getPrimaryProfession(CurrChar, "Northrend", NameB).Rank
            lbProf1Cata.Text = CurrChar.getPrimaryProfession(CurrChar, "Cataclysm", NameA).Rank
            lbProf2Cata.Text = CurrChar.getPrimaryProfession(CurrChar, "Cataclysm", NameB).Rank
            lbProf1Panda.Text = CurrChar.getPrimaryProfession(CurrChar, "Pandaria", NameA).Rank
            lbProf2Panda.Text = CurrChar.getPrimaryProfession(CurrChar, "Pandaria", NameB).Rank
            lbProf1Draenor.Text = CurrChar.getPrimaryProfession(CurrChar, "Draenor", NameA).Rank
            lbProf2Draenor.Text = CurrChar.getPrimaryProfession(CurrChar, "Draenor", NameB).Rank
            lbProf1Legion.Text = CurrChar.getPrimaryProfession(CurrChar, "Legion", NameA).Rank
            lbProf2Legion.Text = CurrChar.getPrimaryProfession(CurrChar, "Legion", NameB).Rank
            lbProf1Azeroth.Text = CurrChar.getPrimaryProfession(CurrChar, "Azeroth", NameA).Rank
            lbProf2Azeroth.Text = CurrChar.getPrimaryProfession(CurrChar, "Azeroth", NameB).Rank

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
            lbCookingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Azeroth", "Cooking").Rank
            lbFishingAzeroth.Text = CurrChar.getSecondaryProfession(CurrChar, "Azeroth", "Fishing").Rank
            lbArchaelogyVanilla.Text = CurrChar.getSecondaryProfession(CurrChar, "", "Archaeology").Rank

        Catch
        End Try

    End Sub

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