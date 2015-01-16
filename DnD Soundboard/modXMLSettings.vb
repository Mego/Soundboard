Imports System.Xml
Imports System.IO
Imports System.Text

Public Module modXMLSettings

    Public Structure Setting
        Public Property Name As String
        Public Property Filename As String
    End Structure

    Public Settings As List(Of Setting)

    Public Sub SaveSettings()
        Dim writer As New System.Xml.Serialization.XmlSerializer(Settings.GetType)
        Dim file As New System.IO.StreamWriter("soundboard.xml")
        writer.Serialize(file, Settings)
        file.Close()
    End Sub

    Public Sub LoadSettings()
        Try
            Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(List(Of Setting)))
            Dim file As New StreamReader("soundboard.xml")
            Settings = CType(reader.Deserialize(file), List(Of Setting))
            file.Close()
        Catch ex As FileNotFoundException
            Settings = New List(Of Setting)
            Exit Sub
        End Try
    End Sub

End Module
