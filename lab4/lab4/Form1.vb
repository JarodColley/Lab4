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
                car = New Car(cmbMake.Text, txtModel.Text, Convert.ToInt32(cmbYear.Text), Convert.ToDouble(txtPrice.Text), chkNew.Checked)

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
                car.Price = Convert.ToDouble(txtPrice.Text)
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
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()

        cmbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cmbYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        lblResult.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub
    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        Dim userInputPrice As Double


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
        ElseIf Double.TryParse(txtPrice.Text, userInputPrice) = False Then
            ' If not set the error message
            outputMessage += "Please enter a number for Cars Price." & vbCrLf

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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'calls the reset Sub
        Reset()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the form
        Me.Close()
    End Sub
    ''' <summary>
    ''' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCustomers.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If
    End Sub
    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCustomers.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the car identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Get the car identification number 
        currentCarIdentificationNumber = lvwCustomers.Items(lvwCustomers.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the customer identification number to get the customer from the collection object
        Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

        ' set the controls on the form
        cmbMake.Text = car.Make                             ' get the make and set it into the combo box
        txtModel.Text = car.Model                           ' get the cars model and set it in the text box
        cmbYear.Text = car.Year.ToString()                  ' get the cars year and sets it into the combo box
        txtPrice.Text = car.Price.ToString()                ' get the cars Price and sets it into the text box
        chkNew.Checked = car.Status                         ' get the status and sets checkbox 

        lblResult.Text = car.GetCarData()


    End Sub

End Class
