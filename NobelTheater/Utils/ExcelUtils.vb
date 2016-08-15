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

    ''' <summary>
    ''' Removes the "Auto Text Break" feature
    ''' </summary>
    Public Sub AutoTextBreakOff(ByVal selection As Range)
        With selection
            .HorizontalAlignment = Constants.xlGeneral
            .VerticalAlignment = Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Constants.xlContext
            .MergeCells = False
        End With
    End Sub

    ''' <summary>
    ''' Change Font Size
    ''' </summary>
    Public Sub ChangeFontSize(ByVal selection As Range, ByVal fontSize As Integer)
        selection.Font.Size = fontSize
    End Sub

    ''' <summary>
    ''' Changes alignment
    ''' </summary>
    Public Sub AlignRange(ByVal selection As Range, ByVal alignment As Constants)
        With selection
            .HorizontalAlignment = alignment
            .VerticalAlignment = alignment
        End With
    End Sub

    ''' <summary>
    ''' Receives a 2-Dimensional Array and inserts it's data in the worksheet
    ''' Note: This method is much faster than iterating through each excel row
    ''' </summary>
    Public Sub InsertDataBlock(ByRef worksheet As Worksheet, ByRef insertRange As String, ByVal data() As String)
        worksheet.Range(insertRange).Value = data
    End Sub

    ''' <summary>
    ''' Retrieves a String containing the cell value
    ''' May be used when you're not sure if the cell has something or not (Might throw an exception if it's nothing
    ''' </summary>
    Public Function GetCellValue(ByRef worksheet As Worksheet, ByRef range As String) As String
        Try
            If (worksheet.Range(range).Value Is Nothing) Then Return ""
            Return CStr(worksheet.Range(range).Value)
        Catch ex As Exception : Return ""
        End Try
    End Function

End Module
