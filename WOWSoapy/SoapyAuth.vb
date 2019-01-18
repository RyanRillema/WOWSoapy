Public Class SoapyAuth

    Public SoapyData As SoapyData
    Public sSessionSecret As String

    Public Sub New(oSoapyData As SoapyData)
        SoapyData = oSoapyData

        sSessionSecret = "US5qebyyVe6FHTi0kwa5hF6QJgVumrvm3D"

    End Sub

    Public Function getSecret() As String

        'curl -u {client_id}: {client_secret} -d grant_type=client_credentials https://us.battle.net/oauth/token

        Return sSessionSecret

    End Function

End Class
