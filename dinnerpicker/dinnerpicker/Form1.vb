'THIS PIECE OF SHIT IS RELEASED UNDER THE WTFPL
'This program is free software. It comes without any warranty, to
'* the extent permitted by applicable law. You can redistribute it
'* and/or modify it under the terms of the Do What The Fuck You Want
'* To Public License, Version 2, as published by Sam Hocevar. See
'* http://sam.zoy.org/wtfpl/COPYING for more details.
'....................../´¯/) 
'....................,/¯../ 
'.................../..../ 
'............./´¯/'...'/´¯¯`·¸ 
'........../'/.../..../......./¨¯\ 
'........('(...´...´.... ¯~/'...') 
'.........\.................'...../ 
'..........''...\.......... _.·´ 
'............\..............( 
'..............\.............\...




Public Class frmMain
    'when clicking this button, the code uses a ranomizing function to output what the user should eat.
    Private Sub btnDinner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDinner.Click
        'this the code what sets up some random number generators
        Dim rndDinner As Random
        Dim intDinner As Integer
        rndDinner = New Random
        intDinner = rndDinner.Next(1, 12)

        'this the code what links a number to a phrase and sets the label on the form to the phrase
        If intDinner = 1 Then
            lblDinner.Text = "veggie patty"
        ElseIf intDinner = 2 Then
            lblDinner.Text = "Sandwich of meat"
        ElseIf intDinner = 3 Then
            lblDinner.Text = "sandwich of jelly"
        ElseIf intDinner = 4 Then
            lblDinner.Text = "Eggs and Bacon"
        ElseIf intDinner = 5 Then
            lblDinner.Text = "Eggs and Sausages"
        ElseIf intDinner = 6 Then
            lblDinner.Text = "Chicken"
        ElseIf intDinner = 7 Then
            lblDinner.Text = "KD"
        ElseIf intDinner = 8 Then
            lblDinner.Text = "Ramen"
        ElseIf intDinner = 9 Then
            lblDinner.Text = "Pastaaa"
        ElseIf intDinner = 10 Then
            lblDinner.Text = "cereal"
        ElseIf intDinner = 11 Then
            lblDinner.Text = "pancakes"
        End If

        'sets the labels visible
        lblDinnerTitle.Visible = True
        lblDinner.Visible = True
    End Sub
End Class
