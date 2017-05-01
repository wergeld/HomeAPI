Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class WeatherController
        Inherits ApiController

        ''' <summary>
        ''' Gets the weather datas for the requested sensor
        ''' </summary>
        ''' <param name="inpt"></param>
        ''' <returns></returns>
        <HttpPost>
        <ActionName("weather")>
        Public Function GetWeather(ByVal inpt As WeatherInput) As List(Of WeatherOutput)
            Dim webRequest As HttpWebRequest = DirectCast(System.Net.WebRequest.Create(UrlString), HttpWebRequest)
            webRequest.Method = "POST"
            webRequest.ContentType = "application/x-www-form-urlencoded"

            webRequest.Credentials = New NetworkCredential(username, password)

            Dim response As HttpWebResponse = DirectCast(webRequest.GetResponse(), HttpWebResponse)

        End Function

    End Class
End Namespace