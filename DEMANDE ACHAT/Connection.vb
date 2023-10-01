Option Explicit On
Imports System.IO
Imports System.data
Imports System.Data.OleDb
Imports System.Text
Imports System.Data.SqlClient
Imports System.Xml
Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Objets100Lib
Module Connection
    Public sqlCon As OleDbConnection
    Public sqlConAppli As OleDbConnection
    Public strServer As String = Nothing
    Public strBase As String = Nothing
    Public strLogin As String = Nothing
    Public StrPassword As String = Nothing
    Public blserveur As Boolean = False
    Public fichierini As String = Nothing
    Public serveurSql As String = Nothing
    Public baseSql As String = Nothing
    Public baseAppli As String = Nothing
    Public userSql As String = Nothing
    Public pwdSql As String = Nothing
    Public cheminCpta As String = Nothing
    Public utilisateurCpta As String = Nothing
    Public motdepasseCpta As String = Nothing
    Public cheminGescom As String = Nothing
    Public utilisateurGescom As String = Nothing
    Public motdepasseGescom As String = Nothing
    Public BaseCpta2 As BSCPTAApplication3 = New BSCPTAApplication3
    Public Etape As String
    Public EtapeSuivant As String
    Public IndexEtapeC, NumRecherche As Integer
    Public DernierUser As String
    Public Souche As String
    Public ServeurSmtp, PortSmtp, UserSmtp, PwdSmtp, Ssl As String
    Public Function connexionSql(ByRef sqlcon As OleDbConnection, ByRef serveur As String, ByRef baseDonnees As String, ByRef user As String, ByRef pwd As String) As Boolean
        Try
            sqlcon = New OleDbConnection("Provider=SQLOLEDB; ;UID=" & user & ";Pwd=" & pwd & "; Initial Catalog=" & baseDonnees & "; Data Source=" & serveur & "")
            sqlCon.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function fermersql(ByRef sqlcon As OleDbConnection) As Boolean
        Try
            sqlCon = New OleDbConnection
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function LirefichierConfig()
        fichierini = My.Application.Info.DirectoryPath & "\ConnectAPI.Ini"
        Ssl = LireChaine(fichierini, "CONNEXION", "SSL")
        ServeurSmtp = LireChaine(fichierini, "CONNEXION", "SERVEURSMTP")
        PortSmtp = LireChaine(fichierini, "CONNEXION", "PORTSMTP")
        UserSmtp = LireChaine(fichierini, "CONNEXION", "USERSMTP")
        PwdSmtp = LireChaine(fichierini, "CONNEXION", "PWDSMTP")
        If PwdSmtp <> "" Then
            PwdSmtp = Base64Decode(PwdSmtp)
        End If
        serveurSql = LireChaine(fichierini, "CONNEXION", "SERVEUR SQL")
        baseSql = LireChaine(fichierini, "CONNEXION", "BASE SQL")
        baseAppli = LireChaine(fichierini, "CONNEXION", "BASE Application")
        userSql = LireChaine(fichierini, "CONNEXION", "USER SQL")
        pwdSql = LireChaine(fichierini, "CONNEXION", "PWD SQL")
        DernierUser = LireChaine(fichierini, "CONNEXION", "DERNIERUSER")
        If pwdSql <> "" Then
            pwdSql = Base64Decode(pwdSql)
        End If
        cheminCpta = LireChaine(fichierini, "CONNEXION", "CHEMIN BASE COMPTA")
        utilisateurCpta = LireChaine(fichierini, "CONNEXION", "USER COMPTA")
        motdepasseCpta = LireChaine(fichierini, "CONNEXION", "PWD COMPTA")
        If motdepasseCpta <> "" Then
            motdepasseCpta = Base64Decode(motdepasseCpta)
        End If
        cheminGescom = LireChaine(fichierini, "CONNEXION", "CHEMIN BASE GESCOM")
        utilisateurGescom = LireChaine(fichierini, "CONNEXION", "USER GESCOM")
        motdepasseGescom = LireChaine(fichierini, "CONNEXION", "PWD GESCOM")
        If motdepasseGescom <> "" Then
            motdepasseGescom = Base64Decode(motdepasseCpta)
        End If
        Souche = LireChaine(fichierini, "CONNEXION", "SOUCHE")
        LirefichierConfig = Nothing
    End Function
    Public Declare Ansi Function GetPrivateProfileString Lib "kernel32" _
                    Alias "GetPrivateProfileStringA" (ByVal K_Pouliyou As String, _
                    ByVal K_Pouliyou As String, ByVal K_Wande As String, _
                    ByVal K_Hamegni As String, ByVal K_Jamegni As Integer, _
                    ByVal K_Djantseu As String) As Long

    'Ecriture dans le fichier .ini
    Public Declare Ansi Function WritePrivateProfileString Lib "kernel32" _
            Alias "WritePrivateProfileStringA" (ByVal App_Section As String, ByVal App_Cle As String, ByVal App_Valeur As String, ByVal App_Path As String) As Boolean

    Function LireChaine(ByVal Kamen_Fichier_Ini As String, ByVal Pouliyou_Section As String, ByVal Djantcheu_Key As String) As String
        Dim X As Long
        Dim Ham_buffer As String

        Ham_buffer = Space(300)
        X = GetPrivateProfileString(Pouliyou_Section, Djantcheu_Key, "", Ham_buffer, Len(Ham_buffer), Kamen_Fichier_Ini)
        If Len(Trim(Strings.Left(Ham_buffer, 295))) > 0 Then
            LireChaine = Strings.Left(Trim(Strings.Left(Ham_buffer, 295)), Len(Trim(Strings.Left(Ham_buffer, 295))) - 1)
        Else
            LireChaine = Nothing
        End If
    End Function
    Public Function Base64Decode(ByVal Texte As String) As String
        Try
            If Texte.Length = 0 Then
                Return ""
            Else
                Return Encoding.ASCII.GetString(Convert.FromBase64String(Texte))
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Base64Encode(ByVal Texte As String) As String
        Try
            Dim texteBytes As Byte() = Encoding.ASCII.GetBytes(Texte)
            If texteBytes.Length = 0 Then
                Return ""
            Else
                Return Convert.ToBase64String(texteBytes)
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Function OuvreBaseCompta(ByRef BaseCpta As BSCPTAApplication3, ByVal CptaChemin As String, ByRef CptaUserName As String, Optional ByVal CptaPasswd As String = "") As Boolean
        Try
            If BaseCpta.IsOpen = False Then
                BaseCpta.Name = CptaChemin
                If CptaUserName <> "" Then
                    BaseCpta.Loggable.UserName = CptaUserName
                    BaseCpta.Loggable.UserPwd = CptaPasswd
                End If
                BaseCpta.Open()
                Return True
            ElseIf BaseCpta.IsOpen = True Then
                Return True
            End If
        Catch ex As Exception

            Return False
        End Try
    End Function
    Function FermeBaseCpta(ByRef BaseCpta As BSCPTAApplication3) As Boolean
        Try
            If BaseCpta.IsOpen = True Then
                BaseCpta.Close()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
