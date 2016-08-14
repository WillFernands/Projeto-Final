Option Strict On
Option Explicit On

Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Module ExcelUtils
    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr

    ''' <summary>
    ''' Open a Windows Explorer window (Path must be a folder)
    ''' </summary>
    Public Function FindDataRow(ByRef worksheet As Worksheet, ByVal str As String, _
                                Optional ByVal afterCell As String = "", _
                                Optional ByVal direction As XlSearchDirection = XlSearchDirection.xlNext) As Integer
        Try
            worksheet.AutoFilterMode = False
            If (String.IsNullOrWhiteSpace(afterCell)) Then : Return worksheet.Cells.Find(str).Row
            Else : Return worksheet.Cells.Find(str, worksheet.Range(afterCell), SearchDirection:=direction).Row
            End If
        Catch ex As NullReferenceException : Return 0
        End Try
    End Function

    ''' <summary>
    ''' Open a Windows Explorer window (Path must be a folder)
    ''' </summary>
    Public Sub FinalizeExcelApp(ByVal excelApp As Application)
        Try
            excelApp.Caption = "ToDispose"
            excelApp.DisplayAlerts = False
            Dim iHandle As IntPtr = IntPtr.Zero
            If (CInt(excelApp.Version) > 9) Then : iHandle = New IntPtr(excelApp.Parent.Hwnd)
            Else : iHandle = FindWindow(Nothing, excelApp.Caption)
            End If
            excelApp.Workbooks.Close()
            excelApp.Quit()
            Marshal.FinalReleaseComObject(excelApp)
            excelApp = Nothing
            Dim proc As Process = Process.GetProcessById(GetProcessID(iHandle))
            proc.Kill()
        Catch ex As Exception
        End Try
    End Sub
End Module
