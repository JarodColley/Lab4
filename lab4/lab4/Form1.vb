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
        Dim car As Car                 'declares a Car class
        Dim carItem As ListViewItem    ' declares a ListViewItem class


    End Sub
    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the Make has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the Cars Make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the Model has been entered
        If txtModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the Cars Model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the Year has been Selected
        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please Select the Cars Year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If
        ' check if the Price has been entered
        If txtPrice.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the Cars Price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function
End Class
