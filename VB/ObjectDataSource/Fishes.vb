Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.DataAccess.ObjectBinding

Namespace ObjectDataSource

    <DisplayName("Fishes")>
    <HighlightedClass>
    Public Class Fishes
        Inherits List(Of Fish)

        <HighlightedMember>
        Public Sub New(ByVal filePath As String)
            Dim path As String = TryCast(AppDomain.CurrentDomain.GetData("DataDirectory"), String)
            If Not String.IsNullOrEmpty(path) Then filePath = IO.Path.Combine(path, filePath)
            If File.Exists(filePath) Then
                Using stream As Stream = File.OpenRead(filePath)
                    LoadFrom(stream)
                End Using
            End If
        End Sub

        Public Sub New(ByVal stream As Stream)
            LoadFrom(stream)
        End Sub

        Private Sub LoadFrom(ByVal stream As Stream)
            Dim input As TextReader = New StreamReader(stream)
            Dim line As String
            Dim id As Integer = 0
            While Not Equals((CSharpImpl.__Assign(line, input.ReadLine())), Nothing)
                Dim items As String() = line.Split("|"c)
                If items.Length = 4 Then
                    Threading.Interlocked.Increment(id)
                    Dim fishItem As Fish = New Fish(items(0), items(1), items(2), items(3), id)
                    Add(fishItem)
                End If
            End While

            input.Close()
        End Sub

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Public Class Fish

        Private idField As Integer

        Private categoryField As String = "Undefined"

        Private commonNameField As String = "Undefined"

        Private speciesNameField As String = "Undefined"

        Private notesField As String = "Undefined"

        <DisplayName("Fish Category")>
        Public Property Category As String
            Get
                Return categoryField
            End Get

            Set(ByVal value As String)
                categoryField = value
            End Set
        End Property

        <DisplayName("Fish Common Name")>
        Public Property CommonName As String
            Get
                Return commonNameField
            End Get

            Set(ByVal value As String)
                commonNameField = value
            End Set
        End Property

        <DisplayName("Fish Species Name")>
        Public Property SpeciesName As String
            Get
                Return speciesNameField
            End Get

            Set(ByVal value As String)
                speciesNameField = value
            End Set
        End Property

        <DisplayName("Fish Notes")>
        Public Property Notes As String
            Get
                Return notesField
            End Get

            Set(ByVal value As String)
                notesField = value
            End Set
        End Property

        <DisplayName("Fish ID")>
        Public Property ID As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                idField = value
            End Set
        End Property

        Public Sub New(ByVal category As String, ByVal commonName As String, ByVal speciesName As String, ByVal notes As String, ByVal id As Integer)
            categoryField = category
            commonNameField = commonName
            speciesNameField = speciesName
            notesField = notes
            idField = id
        End Sub
    End Class
End Namespace
