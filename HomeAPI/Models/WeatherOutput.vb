<DataContract()>
Public Class WeatherOutput
    <DataMember()> Public Property IDX() As Integer
    <DataMember()> Public Property Barometer() As Nullable(Of Integer)
    <DataMember()> Public Property BatteryLevel() As Nullable(Of Integer)
    <DataMember()> Public Property DewPoint() As Nullable(Of Decimal)
    <DataMember()> Public Property ForcastURL() As String
    <DataMember()> Public Property Humidity() As Nullable(Of Decimal)
    <DataMember()> Public Property HumidityDesc() As String
    <DataMember()> Public Property Name() As String
    <DataMember()> Public Property Temp() As Nullable(Of Decimal)

End Class
