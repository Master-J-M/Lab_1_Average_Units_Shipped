'Title: Lab 1 - Average Units Shipped
'For: NETD2202
'By: Joshua Morand(100662245)
'Date : Jan.24th 2018
'Description: Takes user input For amount of items sold per day for a week. Application will validate input and calculate/output the average units shipped for that week.
Public Class frmMain
    Dim dayNumber As Integer = 1    'variable to hold the day number, will be used as the index for the array
    Dim totalUnits As Integer = 0   'variable which holds the amount of units sold and is manipulated to show the average units sold
    Dim sum(6) As Integer           'array to hold how many units were sold for each day
    Dim input As Integer            'variable to hold the user input
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click          'event for when the enter button is clicked
        If Integer.TryParse(userInput.Text, input) Then                                          'trys to parse the user input to an integer variable
            If (input < 0 Or input > 1000) Then                                                  'if the parse was sucessfull then test if it is out of range
                MessageBox.Show("Value must be from 0-1000", "Out of range")                     'display an out of range error message box
            Else                                                                                 'if the input is in range then..
                sum(dayNumber - 1) = input                                                       'add the input to the array
                txtOutput.Text += input & vbCrLf                                                 'add the input to the text box showing units sold
                dayNumber += 1                                                                   'add one to the day number
                update()                                                                         'calls the update function
                If (dayNumber - 1 >= 7) Then                                                     'if there have been 7 inputs then..
                    dayNumber -= 1                                                               'subtract 1 from day number so it still outputs as day 7
                    btnEnter.Enabled = False                                                     'disable the enter button
                    userInput.ReadOnly = True                                                    'make the user input read only
                    For i = 0 To sum.Length - 1                                                  'Loop through the entire array and..
                        totalUnits += sum(i)                                                     'add the value in the array to the total units integer
                    Next i                                                                       'increase the count by one to access the next index of the array
                    txtFinalOutput.Text = "Average Units Sold: " & Math.Round(totalUnits / 7, 2) 'calculate, round, and output the average units sold
                    update()                                                                     'calls the update function
                End If
            End If
        Else                                                                                     'if the user input fails to parse then..
            MessageBox.Show("Value must be a whole number", "Failed to Parse")                   'display an error message box stating that the input must be a whole number
        End If
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load      'event for when the form loads
        update()                                                                        'calls the update function
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click 'event for when the exit button is clicked
        dayNumber = 1                                                                   'resets the day number back to 1
        totalUnits = 0                                                                  'resets the total units back to 0
        txtOutput.Text = ""                                                             'clears the output box showing units sold
        txtFinalOutput.Text = ""                                                        'clears the output box showing the average units sold
        btnEnter.Enabled = True                                                         're-enables the enter button
        userInput.ReadOnly = False                                                      'makes the user input box writeable 
        userInput.Focus()                                                               'focuses the text input onto the user input
        update()                                                                        'calls the update function
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click  'event for when the exit button is clicked
        Application.Exit()                                                             'closes the application
    End Sub

    Sub update()                                            'function that will update the day number and clear the user input
        userInput.Text = ""                                 'clears the user input text box
        lblDayNumber.Text = "Day: " & dayNumber.ToString    'updates the day number
    End Sub
End Class
