Imports System.Threading

Public Class TrdWowSoapy

    Public SoapyData As SoapyData
    Public trdWowSoapy As Thread
    Public bRunning As Boolean
    Public bGetData, bOutputData As Boolean
    Public bGetDataSuccess, bOutputDataSuccess As Boolean

    Public Sub New(SetSoapyData As SoapyData)
        SoapyData = SetSoapyData
        trdWowSoapy = New Thread(AddressOf ThreadTask)
        trdWowSoapy.IsBackground = True

    End Sub

    Public Sub GetData()
        bGetData = True
    End Sub

    Public Sub OutputData()
        bOutputData = True
    End Sub

    Public Sub StartThread()
        bRunning = True

        trdWowSoapy.Start()

    End Sub

    Public Sub StopThread()
        trdWowSoapy.Abort()
        bRunning = False
    End Sub

    Public Function IsRunning() As Boolean
        Return bRunning
    End Function

    Private Sub ThreadTask()

        Do
            If bGetData Then

                SoapyData.SoapyIO.LoadAllChars()
                bGetDataSuccess = True
                bGetData = False

            End If

            If bGetDataSuccess And bOutputData Then

                SoapyData.SoapyIO.OutputAllChars_CSV()
                bOutputDataSuccess = True
                bOutputData = False

            End If

            Thread.Sleep(100)
        Loop

    End Sub

End Class
