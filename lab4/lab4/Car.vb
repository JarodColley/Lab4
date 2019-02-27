Option Strict On
Public Class Car

    'declaration of class variables
    Private Shared carCount As Integer 'holds the number of car objects
    Private carIdNumber As Integer = 0 'holds the id number of the cars 
    Private carMake As String = String.Empty 'holds the cars make
    Private carModel As String = String.Empty 'holds the cars model
    Private carYear As Integer = 0 ' holds the year of the car
    Private carPrice As Double = 0.0 'holds the price of the car
    Private newStatus As Boolean = False 'set to true if the car is new

    ''' <summary>
    ''' Constructor - Default - creates a new Car object
    ''' </summary>
    Public Sub New()
        carCount += 1
        carIdNumber = carCount
    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new Car object
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="isNew"></param>
    Public Sub New(make As String, model As String, year As Integer, price As Double, isNew As Boolean)
        Me.New()

        carMake = make
        carModel = model
        carYear = year
        carPrice = price
        newStatus = isNew
    End Sub

    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of Cars that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' Id ReadOnly Property - Gets the id number of the Car object
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Id() As Integer
        Get
            Return carIdNumber
        End Get
    End Property

    ''' <summary>
    ''' Status Property - >Gets and Sets the new status of a car
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property Status() As Boolean
        Get
            Return newStatus
        End Get
        Set(ByVal value As Boolean)
            newStatus = value
        End Set
    End Property

    ''' <summary>
    ''' carPrice Property - >Gets and Sets the Price of a Car
    ''' </summary>
    ''' <returns>Double</returns>
    Public Property Price() As Double
        Get
            Return carPrice
        End Get
        Set(ByVal value As Double)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Year Property - >Gets and Sets the year of a car
    ''' </summary>
    ''' <returns>integer</returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(ByVal value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Model Property - >Gets and Sets the model of a car
    ''' </summary>
    ''' <returns>string</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property
    ''' <summary>
    ''' Make Property - >Gets and Sets the Make of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' getCarData provides all the cars data in a string formate
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetCarData() As String
        Return "my Car is " & carMake & " " & carModel & " " & carYear & " " & carPrice & ", " & IIf(newStatus = True, "I am a VIP", "I am not a VIP").ToString()
    End Function
End Class
