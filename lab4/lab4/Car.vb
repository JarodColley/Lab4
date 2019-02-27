Option Strict On
Public Class Car

    'declaration of class variables
    Private Shared carCount As Integer
    Private carIdNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Double = 0.0
    Private newStatus As Boolean = False

    'default constructor 
    Public Sub New()
        carCount += 1
        carIdNumber = carCount
    End Sub

    'Parameterized constructor 
    Public Sub New(make As String, model As String, year As Integer, price As Double, isNew As Boolean)
        Me.New()

        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        newStatus = isNew
    End Sub



End Class
