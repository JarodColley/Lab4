Option Strict On
''' <summary>
''' Author name: Jarod Colley
''' Project name: Car Inventory
''' Date: 27-Feb-2019
''' Description: to make a car class and use it to list diffrent cars
''' </summary>

Public Class FrmMain
    Private carList As New SortedList                                ' collection of all the carList in the list
    Private currentCarIdentificationNumber As String = String.Empty ' current selected car identification number
    Private editMode As Boolean = False
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

    End Sub
End Class
