Imports System.IO
Public Class File_Generator

    Inherits System.ComponentModel.Component

    ' Declares the variables you will use to hold your thread objects.

    Public FGThread As System.Threading.Thread

    Public Count_Start_Input As Integer = 1
    Public Count_End_Input As Integer = 1
    Public Count_Step_Input As Integer = 1
    Public Count_String_Length_Input As Integer = 1
    Public Input_URL_Input As String = ""
    Public Save_File_Input As String = ""
    Public Result As String = ""

    Public Event FGComplete(ByVal Result As String)
    Public Event FGProgress(ByVal value As Integer)


#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region

    Private Sub error_handler(ByVal message As String)
        Try
            MsgBox("DAL Download List Generator 1.0 has trapped the following error: " & vbCrLf & message, MsgBoxStyle.Exclamation, "DAL Download List Generator 1.0")
        Catch ex As Exception
            MsgBox("DAL Download List Generator 1.0 has trapped the following error: " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "DAL Download List Generator 1.0")
        End Try
    End Sub

    Public Sub ChooseThreads(ByVal threadNumber As Integer)
        Try
            ' Determines which thread to start based on the value it receives.
            Select Case threadNumber
                Case 1
                    ' Sets the thread using the AddressOf the subroutine where
                    ' the thread will start.
                    FGThread = New System.Threading.Thread(AddressOf FGExecute)
                    ' Starts the thread.
                    FGThread.Start()
            End Select
        Catch ex As Exception
            error_handler(ex.Message)
        End Try
    End Sub

    Public Sub FGExecute()
        Try
            Dim save_file As String
            save_file = Save_File_Input


            Dim start_counter, end_counter, step_counter As Integer
            start_counter = Count_Start_Input
            end_counter = Count_End_Input
            step_counter = Count_Step_Input
            Dim url_text() As String
            url_text = Input_URL_Input.Trim().Split(";")

            Dim fil As File
            If (fil.Exists(save_file) = True) Then
                fil.Delete(save_file)
            End If
            Dim looper_counter As Integer = 0
            If (fil.Exists(save_file) = False) Then
                Dim filewriter As New StreamWriter(save_file, False, System.Text.Encoding.ASCII)
                filewriter.WriteLine("<filelist_index>")

                For j As Integer = 0 To url_text.Length - 1


                    Dim filen() As String
                    Dim urln() As String
                    filen = url_text(j).Trim().Substring(url_text(j).LastIndexOf("/") + 1).Split("@")
                    urln = url_text(j).Trim().Split("@")
                    Dim i As Integer = 0

                    Dim difference As Integer
                    difference = (end_counter - start_counter) + 1
                    Dim progresslooper As Integer
                    progresslooper = 1

                    Dim looper_string As String = ""
                    For looper As Integer = start_counter To end_counter Step step_counter
                        looper_counter = looper_counter + 1
                        filewriter.WriteLine("<fileinfo>")
                        filewriter.Write("<filename>")
                        For i = 0 To filen.Length - 1

                            filewriter.Write(filen(i))
                            If (i < (filen.Length - 1)) Then
                                looper_string = looper.ToString()
                                While looper_string.Length < Count_String_Length_Input
                                    looper_string = "0" & looper_string
                                End While
                                filewriter.Write(looper_string)
                            End If
                        Next
                        filewriter.WriteLine("</filename>")
                        filewriter.Write("<url>")
                        For i = 0 To urln.Length - 1

                            filewriter.Write(urln(i))
                            If (i < (urln.Length - 1)) Then
                                looper_string = looper.ToString()
                                While looper_string.Length < Count_String_Length_Input
                                    looper_string = "0" & looper_string
                                End While
                                filewriter.Write(looper_string)
                            End If
                        Next
                        filewriter.WriteLine("</url>")
                        filewriter.WriteLine("</fileinfo>")
                        RaiseEvent FGProgress((progresslooper / difference) * 100)
                        progresslooper = progresslooper + step_counter
                    Next

                Next
                filewriter.WriteLine("</filelist_index>")
                filewriter.Close()
            End If
            Result = "File successfully created. " & looper_counter & " file entries were added."
            RaiseEvent FGComplete(Result)
        Catch ex As Exception
            Result = "File generation failed. Error encountered."
            RaiseEvent FGComplete(Result)
        End Try
    End Sub







End Class
