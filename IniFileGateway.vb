Imports System
Imports System.Text
Imports System.Runtime.InteropServices

Public Class IniFileGateway

    Private _fileName As String

    Private Declare Function WritePrivateProfileString _
            Lib "KERNEL32.DLL" Alias "WritePrivateProfileStringA" ( _
            ByVal lpAppName As String, _
            ByVal lpKeyName As String, _
            ByVal lpString As String, _
            ByVal lpFileName As String) As Integer

    Private Declare Function GetPrivateProfileString _
            Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" ( _
            ByVal lpAppName As String, _
            ByVal lpKeyName As String, _
            ByVal lpDefault As String, _
            ByVal lpReturnedString As String, _
            ByVal nSize As Integer, _
            ByVal lpFileName As String) As Integer

    Private Declare Function GetPrivateProfileInt _
            Lib "kernel32" Alias "GetPrivateProfileIntA" ( _
            ByVal lpApplicationName As String, _
            ByVal lpKeyName As String, _
            ByVal nDefault As Integer, _
            ByVal lpFileName As String) As Integer

    Public Sub New(ByVal filename As String)
        _fileName = filename
    End Sub

    ''' <summary>
    ''' GetIniString
    ''' </summary>
    ''' <param name="apName"> セクション名 </param>
    ''' <param name="keyName"> キー名 </param>
    ''' <param name="defaults"> デフォルト値 </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetIniString(ByVal apName As String, ByVal keyName As String, ByVal defaults As String) As String
        Dim strResult As String = Space(255)

        Call GetPrivateProfileString(apName, keyName, defaults, strResult, Len(strResult), (_fileName))
        Return Microsoft.VisualBasic.Left(strResult, InStr(strResult, Chr(0)) - 1)
    End Function

    ''' <summary>
    ''' GetIniInteger
    ''' </summary>
    ''' <param name="apName"> セクション名 </param>
    ''' <param name="keyName"> キー名 </param>
    ''' <param name="defaults"> デフォルト値 </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetIniInteger(ByVal apName As String, ByVal keyName As String, ByVal defaults As Integer) As Integer
        Return GetPrivateProfileInt(apName, keyName, defaults, (_fileName))
    End Function

    ''' <summary>
    ''' SetIniString
    ''' </summary>
    ''' <param name="apName"> セクション名 </param>
    ''' <param name="KeyName"> キー名 </param>
    ''' <param name="param"> 書込む値 </param>
    ''' <remarks></remarks>
    Public Sub SetIniString(ByVal apName As String, ByVal KeyName As String, ByVal param As String)
        Call WritePrivateProfileString(apName, KeyName, param, (_fileName))
    End Sub

End Class
