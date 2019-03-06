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


        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' 
            lblResult.Text = "It worked!"

            ' if the current customer identification number has a no value
            ' then this is not an existing item from the listview
            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new car object using the parameterized constructor
                car = New Car(cmbMake.Text, txtModel.Text, Convert.ToInt32(cmbYear.Text), Convert.ToInt32(txtPrice.Text), chkNew.Checked)

                ' add the customer to the customerList collection
                ' using the identification number as the key
                ' which will make the customer object easier to
                ' find in the customerList collection later
                carList.Add(car.Id.ToString(), car)

            Else
                ' if the current customer identification number has a value
                ' then the user has selected something from the list view
                ' so the data in the customer object in the customerList collection
                ' must be updated

                ' so get the customer from the custmers collection
                ' using the selected key
                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                ' update the data in the specific object
                ' from the controls
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = Convert.ToInt32(cmbYear.Text)
                car.Price = Convert.ToInt32(txtPrice.Text)
                car.Status = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwCustomers.Items.Clear()
            ' loop through the customerList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the customer from the list
                car = CType(carEntry.Value, Car)

                ' assign the values to the checked control
                ' and the subitems
                carItem.Checked = car.Status
                carItem.SubItems.Add(car.Id.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString())
                carItem.SubItems.Add(car.Price.ToString())



                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCustomers.Items.Add(carItem)

            Next carEntry


            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

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
