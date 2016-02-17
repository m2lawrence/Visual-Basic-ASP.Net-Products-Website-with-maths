
Partial Class _Default2
    Inherits System.Web.UI.Page

    'Page load function:
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not IsPostBack Then

            'Page H1 Title:
            Session("Header") = "Welcome to Truecan Ltd"

            'Tell customer to select a product:
            lblProduct.Text = "Select Product:"
            'Label:
            lblQuantity.Text = "Select Quantity:"
            'The user can't select the same product twice because this page is only displayed ever once:

        End If

    End Sub

    '========== DDL Products which populates the DDL Quantity ======================
    Protected Sub DDLProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLProducts.SelectedIndexChanged
        If DDLProducts.SelectedValue = "" Then
            lblErrorProduct.Text = "No item is selected."
            Exit Sub
        Else
            lblErrorProduct.Text = ""
        End If

        Dim intQTY, index As Integer
        intQTY = 0

        If DDLProducts.SelectedValue.Length = 8 Then
            intQTY = Val(DDLProducts.SelectedValue.Substring(7, 1))
        Else
            intQTY = Val(DDLProducts.SelectedValue.Substring(7, 2))
        End If

        DDLQuantity.Items.Clear()
        For index = intQTY To 169
            DDLQuantity.Items.Add(index.ToString)
        Next

    End Sub

    'ADD BUTTON CLICKED HERE MAKES THE DROP DOWN LIST SELECTION POPULATE A TEXT BOX:
    Protected Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click

        '=== Boolean value of true or false testing: 
        If txtBoxProductCode.Text = DDLProducts.SelectedValue Then
            Exit Sub

        ElseIf txtBoxProductCode2.Text = DDLProducts.SelectedValue Then
            Exit Sub

        ElseIf txtBoxProductCode3.Text = DDLProducts.SelectedValue Then
            Exit Sub

        ElseIf txtBoxProductCode4.Text = DDLProducts.SelectedValue Then
            Exit Sub

        ElseIf txtBoxProductCode5.Text = DDLProducts.SelectedValue Then
            Exit Sub

        Else

            'If loops here to check if the rows of text boxes are empty or not.
            'If the first text box in the 1st row is empty, then populate the row:
            If txtBoxProductCode.Text = "" Then

                '===first row of text boxes====================================================
                If DDLProducts.SelectedValue = "" Then
                    lblErrorProduct.Text = "No product is selected."
                    Exit Sub
                Else
                    'Over write the Text Box:
                    'txtBoxProduct.Text = DDLProducts.SelectedItem.Text
                    'txtBoxQuantity.Text = DDLQuantity.SelectedItem.Text
                    'Makes the error label blank:
                    lblErrorProduct.Text = ""

                    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    txtBoxProductCode.Text = DDLProducts.SelectedValue
                    txtBoxDescription.Text = DDLProducts.SelectedItem.Text

                    Dim ProductPrice As Double
                    'Changing my variable here, before I use it:

                    If DDLProducts.SelectedValue = "178936-9" Then
                        ProductPrice = 1.26
                    End If
                    If DDLProducts.SelectedValue = "100982-6" Then
                        ProductPrice = 3.76
                    End If
                    If DDLProducts.SelectedValue = "100027-2" Then
                        ProductPrice = 2.45
                    End If
                    If DDLProducts.SelectedValue = "187221-15" Then
                        ProductPrice = 0.93
                    End If
                    If DDLProducts.SelectedValue = "100901-4" Then
                        ProductPrice = 1.98
                    End If
                    If DDLProducts.SelectedValue = "100229-18" Then
                        ProductPrice = 2.47
                    End If
                    If DDLProducts.SelectedValue = "100656-20" Then
                        ProductPrice = 5.32
                    End If
                    'Quantity selected text box:
                    txtBoxQuantity1.Text = DDLQuantity.Text
                    'Total:
                    txtBoxTotal.Text = ProductPrice * CDbl(txtBoxQuantity1.Text)

                    'Set my variable here:
                    txtBoxPrice.Text = ProductPrice

                    '====== Grand Total recalculation for the Add and Clear buttons: ======== 
                    'Declare variables here once as memory names:
                    Dim num1 As Double
                    Dim num2 As Double
                    Dim num3 As Double
                    Dim num4 As Double
                    Dim num5 As Double
                    Dim result As Double

                    If txtBoxTotal.Text = "" Then
                        '----
                    Else
                        num1 = txtBoxTotal.Text
                    End If
                    '-----------------------
                    If txtBoxTotal2.Text = "" Then
                        '----
                    Else
                        num2 = txtBoxTotal2.Text
                    End If
                    '-----------------------
                    If txtBoxTotal3.Text = "" Then
                        '----
                    Else
                        num3 = txtBoxTotal3.Text
                    End If
                    '-----------------------
                    If txtBoxTotal4.Text = "" Then
                        '----
                    Else
                        num4 = txtBoxTotal4.Text
                    End If
                    '-----------------------
                    If txtBoxTotal5.Text = "" Then
                        '----
                    Else
                        num5 = txtBoxTotal5.Text
                    End If

                    result = num1 + num2 + num3 + num4 + num5

                    txtBoxGrandTotal.Text = result

                    '===========================================================================

                    'Then exit "ALL OF THE If Statements" here, so you don't fill up the other boxes:
                    Exit Sub

                    'Exit the first If Statement here to go onto the 2nd one:
                End If
                '=======================================================
            End If

            'If the first text box in the 2nd row is empty, then populate the row:
            If txtBoxProductCode2.Text = "" Then
                '===second row of text boxes====================================================
                If DDLProducts.SelectedValue = "" Then
                    lblErrorProduct.Text = "No product is selected."
                    Exit Sub
                Else
                    'Over write the Text Box:
                    'txtBoxProduct.Text = DDLProducts.SelectedItem.Text
                    'txtBoxQuantity.Text = DDLQuantity.SelectedItem.Text
                    'Makes the error label blank:
                    lblErrorProduct.Text = ""

                    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    txtBoxProductCode2.Text = DDLProducts.SelectedValue
                    txtBoxDescription2.Text = DDLProducts.SelectedItem.Text

                    Dim ProductPrice As Double
                    'Changing my variable here, before I use it:

                    If DDLProducts.SelectedValue = "178936-9" Then
                        ProductPrice = 1.26
                    End If
                    If DDLProducts.SelectedValue = "100982-6" Then
                        ProductPrice = 3.76
                    End If
                    If DDLProducts.SelectedValue = "100027-2" Then
                        ProductPrice = 2.45
                    End If
                    If DDLProducts.SelectedValue = "187221-15" Then
                        ProductPrice = 0.93
                    End If
                    If DDLProducts.SelectedValue = "100901-4" Then
                        ProductPrice = 1.98
                    End If
                    If DDLProducts.SelectedValue = "100229-18" Then
                        ProductPrice = 2.47
                    End If
                    If DDLProducts.SelectedValue = "100656-20" Then
                        ProductPrice = 5.32
                    End If
                    'Quantity selected text box:
                    txtBoxQuantity2.Text = DDLQuantity.Text
                    'Total:
                    txtBoxTotal2.Text = ProductPrice * CDbl(txtBoxQuantity2.Text)

                    'Set my variable here:
                    txtBoxPrice2.Text = ProductPrice

                    '====== Grand Total recalculation for the Add and Clear buttons: ======== 
                    'Declare variables here:
                    Dim num1 As Double
                    Dim num2 As Double
                    Dim num3 As Double
                    Dim num4 As Double
                    Dim num5 As Double
                    Dim result As Double

                    If txtBoxTotal.Text = "" Then
                        '----
                    Else
                        num1 = txtBoxTotal.Text
                    End If
                    '-----------------------
                    If txtBoxTotal2.Text = "" Then
                        '----
                    Else
                        num2 = txtBoxTotal2.Text
                    End If
                    '-----------------------
                    If txtBoxTotal3.Text = "" Then
                        '----
                    Else
                        num3 = txtBoxTotal3.Text
                    End If
                    '-----------------------
                    If txtBoxTotal4.Text = "" Then
                        '----
                    Else
                        num4 = txtBoxTotal4.Text
                    End If
                    '-----------------------
                    If txtBoxTotal5.Text = "" Then
                        '----
                    Else
                        num5 = txtBoxTotal5.Text
                    End If

                    result = num1 + num2 + num3 + num4 + num5

                    txtBoxGrandTotal.Text = result

                    '===========================================================================
                    'Then exit the If Statement here, so you don't fill up the other boxes:
                    Exit Sub

                End If
                '=======================================================
            End If


            'If the first text box in the 3rd row is empty, then populate the row:
            If txtBoxProductCode3.Text = "" Then
                '===3rd row of text boxes====================================================
                If DDLProducts.SelectedValue = "" Then
                    lblErrorProduct.Text = "No product is selected."
                    Exit Sub
                Else
                    'Over write the Text Box:
                    'txtBoxProduct.Text = DDLProducts.SelectedItem.Text
                    'txtBoxQuantity.Text = DDLQuantity.SelectedItem.Text
                    'Makes the error label blank:
                    lblErrorProduct.Text = ""

                    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    txtBoxProductCode3.Text = DDLProducts.SelectedValue
                    txtBoxDescription3.Text = DDLProducts.SelectedItem.Text

                    Dim ProductPrice As Double
                    'Changing my variable here, before I use it:

                    If DDLProducts.SelectedValue = "178936-9" Then
                        ProductPrice = 1.26
                    End If
                    If DDLProducts.SelectedValue = "100982-6" Then
                        ProductPrice = 3.76
                    End If
                    If DDLProducts.SelectedValue = "100027-2" Then
                        ProductPrice = 2.45
                    End If
                    If DDLProducts.SelectedValue = "187221-15" Then
                        ProductPrice = 0.93
                    End If
                    If DDLProducts.SelectedValue = "100901-4" Then
                        ProductPrice = 1.98
                    End If
                    If DDLProducts.SelectedValue = "100229-18" Then
                        ProductPrice = 2.47
                    End If
                    If DDLProducts.SelectedValue = "100656-20" Then
                        ProductPrice = 5.32
                    End If
                    'Quantity selected text box:
                    txtBoxQuantity3.Text = DDLQuantity.Text
                    'Total:
                    txtBoxTotal3.Text = ProductPrice * CDbl(txtBoxQuantity3.Text)

                    'Set my variable here:
                    txtBoxPrice3.Text = ProductPrice

                    '====== Grand Total recalculation for the Add and Clear buttons: ======== 
                    'Declare variables here:
                    Dim num1 As Double
                    Dim num2 As Double
                    Dim num3 As Double
                    Dim num4 As Double
                    Dim num5 As Double
                    Dim result As Double

                    If txtBoxTotal.Text = "" Then
                        '----
                    Else
                        num1 = txtBoxTotal.Text
                    End If
                    '-----------------------
                    If txtBoxTotal2.Text = "" Then
                        '----
                    Else
                        num2 = txtBoxTotal2.Text
                    End If
                    '-----------------------
                    If txtBoxTotal3.Text = "" Then
                        '----
                    Else
                        num3 = txtBoxTotal3.Text
                    End If
                    '-----------------------
                    If txtBoxTotal4.Text = "" Then
                        '----
                    Else
                        num4 = txtBoxTotal4.Text
                    End If
                    '-----------------------
                    If txtBoxTotal5.Text = "" Then
                        '----
                    Else
                        num5 = txtBoxTotal5.Text
                    End If

                    result = num1 + num2 + num3 + num4 + num5

                    txtBoxGrandTotal.Text = result

                    '===========================================================================

                    'Then exit "ALL OF THE If Statements" here, so you don't fill up the other boxes:
                    Exit Sub

                End If
                '=======================================================
            End If


            'If the first text box in the 4th row is empty, then populate the row:
            If txtBoxProductCode4.Text = "" Then
                '===4th row of text boxes====================================================
                If DDLProducts.SelectedValue = "" Then
                    lblErrorProduct.Text = "No product is selected."
                    Exit Sub
                Else
                    'Over write the Text Box:
                    'txtBoxProduct.Text = DDLProducts.SelectedItem.Text
                    'txtBoxQuantity.Text = DDLQuantity.SelectedItem.Text
                    'Makes the error label blank:
                    lblErrorProduct.Text = ""

                    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    txtBoxProductCode4.Text = DDLProducts.SelectedValue
                    txtBoxDescription4.Text = DDLProducts.SelectedItem.Text

                    Dim ProductPrice As Double
                    'Changing my variable here, before I use it:

                    If DDLProducts.SelectedValue = "178936-9" Then
                        ProductPrice = 1.26
                    End If
                    If DDLProducts.SelectedValue = "100982-6" Then
                        ProductPrice = 3.76
                    End If
                    If DDLProducts.SelectedValue = "100027-2" Then
                        ProductPrice = 2.45
                    End If
                    If DDLProducts.SelectedValue = "187221-15" Then
                        ProductPrice = 0.93
                    End If
                    If DDLProducts.SelectedValue = "100901-4" Then
                        ProductPrice = 1.98
                    End If
                    If DDLProducts.SelectedValue = "100229-18" Then
                        ProductPrice = 2.47
                    End If
                    If DDLProducts.SelectedValue = "100656-20" Then
                        ProductPrice = 5.32
                    End If
                    'Quantity selected text box:
                    txtBoxQuantity4.Text = DDLQuantity.Text
                    'Total:
                    txtBoxTotal4.Text = ProductPrice * CDbl(txtBoxQuantity4.Text)

                    'Set my variable here:
                    txtBoxPrice4.Text = ProductPrice

                    '====== Grand Total recalculation for the Add and Clear buttons: ======== 
                    'Declare variables here:
                    Dim num1 As Double
                    Dim num2 As Double
                    Dim num3 As Double
                    Dim num4 As Double
                    Dim num5 As Double
                    Dim result As Double

                    If txtBoxTotal.Text = "" Then
                        '----
                    Else
                        num1 = txtBoxTotal.Text
                    End If
                    '-----------------------
                    If txtBoxTotal2.Text = "" Then
                        '----
                    Else
                        num2 = txtBoxTotal2.Text
                    End If
                    '-----------------------
                    If txtBoxTotal3.Text = "" Then
                        '----
                    Else
                        num3 = txtBoxTotal3.Text
                    End If
                    '-----------------------
                    If txtBoxTotal4.Text = "" Then
                        '----
                    Else
                        num4 = txtBoxTotal4.Text
                    End If
                    '-----------------------
                    If txtBoxTotal5.Text = "" Then
                        '----
                    Else
                        num5 = txtBoxTotal5.Text
                    End If

                    result = num1 + num2 + num3 + num4 + num5

                    txtBoxGrandTotal.Text = result

                    '===========================================================================

                    'Then exit "ALL OF THE If Statements" here, so you don't fill up the other boxes:
                    Exit Sub

                End If
                '=======================================================
            End If

            'If the first text box in the 5th row is empty, then populate the row:
            If txtBoxProductCode5.Text = "" Then
                '===5th row of text boxes====================================================
                If DDLProducts.SelectedValue = "" Then
                    lblErrorProduct.Text = "No product is selected."
                    Exit Sub
                Else
                    'Over write the Text Box:
                    'txtBoxProduct.Text = DDLProducts.SelectedItem.Text
                    'txtBoxQuantity.Text = DDLQuantity.SelectedItem.Text
                    'Makes the error label blank:
                    lblErrorProduct.Text = ""

                    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    txtBoxProductCode5.Text = DDLProducts.SelectedValue
                    txtBoxDescription5.Text = DDLProducts.SelectedItem.Text

                    Dim ProductPrice As Double
                    'Changing my variable here, before I use it:

                    If DDLProducts.SelectedValue = "178936-9" Then
                        ProductPrice = 1.26
                    End If
                    If DDLProducts.SelectedValue = "100982-6" Then
                        ProductPrice = 3.76
                    End If
                    If DDLProducts.SelectedValue = "100027-2" Then
                        ProductPrice = 2.45
                    End If
                    If DDLProducts.SelectedValue = "187221-15" Then
                        ProductPrice = 0.93
                    End If
                    If DDLProducts.SelectedValue = "100901-4" Then
                        ProductPrice = 1.98
                    End If
                    If DDLProducts.SelectedValue = "100229-18" Then
                        ProductPrice = 2.47
                    End If
                    If DDLProducts.SelectedValue = "100656-20" Then
                        ProductPrice = 5.32
                    End If
                    'Quantity selected text box:
                    txtBoxQuantity5.Text = DDLQuantity.Text
                    'Total:
                    txtBoxTotal5.Text = ProductPrice * CDbl(txtBoxQuantity5.Text)

                    'Set my variable here:
                    txtBoxPrice5.Text = ProductPrice

                    '====== Grand Total recalculation for the Add and Clear buttons: ======== 
                    'Declare variables here:
                    Dim num1 As Double
                    Dim num2 As Double
                    Dim num3 As Double
                    Dim num4 As Double
                    Dim num5 As Double
                    Dim result As Double

                    If txtBoxTotal.Text = "" Then
                        '----
                    Else
                        num1 = txtBoxTotal.Text
                    End If
                    '-----------------------
                    If txtBoxTotal2.Text = "" Then
                        '----
                    Else
                        num2 = txtBoxTotal2.Text
                    End If
                    '-----------------------
                    If txtBoxTotal3.Text = "" Then
                        '----
                    Else
                        num3 = txtBoxTotal3.Text
                    End If
                    '-----------------------
                    If txtBoxTotal4.Text = "" Then
                        '----
                    Else
                        num4 = txtBoxTotal4.Text
                    End If
                    '-----------------------
                    If txtBoxTotal5.Text = "" Then
                        '----
                    Else
                        num5 = txtBoxTotal5.Text
                    End If

                    result = num1 + num2 + num3 + num4 + num5

                    txtBoxGrandTotal.Text = result

                    '===========================================================================

                    'Then exit "ALL OF THE If Statements" here, so you don't fill up the other boxes:
                    Exit Sub

                    '=======================================================

                End If

            End If

        End If 'Close the Add Button Boolean value here. 

    End Sub

    '----------------------------- CLEAR BUTTON 1 ------------------------------------------
    Protected Sub butClear1_Click(sender As Object, e As EventArgs) Handles butClear1.Click
        'clears all the buttons textBoxes here:
        txtBoxProductCode.Text = ""
        txtBoxDescription.Text = ""
        txtBoxPrice.Text = ""
        txtBoxQuantity1.Text = ""
        txtBoxTotal.Text = ""

        '====== Grand Total recalculation for the Add and Clear buttons: ======== 
        'Declare variables here:
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim result As Double

        If txtBoxTotal.Text = "" Then
            '----
        Else
            num1 = txtBoxTotal.Text
        End If
        '-----------------------
        If txtBoxTotal2.Text = "" Then
            '----
        Else
            num2 = txtBoxTotal2.Text
        End If
        '-----------------------
        If txtBoxTotal3.Text = "" Then
            '----
        Else
            num3 = txtBoxTotal3.Text
        End If
        '-----------------------
        If txtBoxTotal4.Text = "" Then
            '----
        Else
            num4 = txtBoxTotal4.Text
        End If
        '-----------------------
        If txtBoxTotal5.Text = "" Then
            '----
        Else
            num5 = txtBoxTotal5.Text
        End If

        result = num1 + num2 + num3 + num4 + num5

        txtBoxGrandTotal.Text = result

        '===========================================================================

    End Sub

    '----------------------------- CLEAR BUTTON 2 ------------------------------------------
    Protected Sub butClear2_Click(sender As Object, e As EventArgs) Handles butClear2.Click
        'clears all the buttons textBoxes here:
        txtBoxProductCode2.Text = ""
        txtBoxDescription2.Text = ""
        txtBoxPrice2.Text = ""
        txtBoxQuantity2.Text = ""
        txtBoxTotal2.Text = ""

        '====== Grand Total recalculation for the Add and Clear buttons: ======== 
        'Declare variables here:
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim result As Double

        If txtBoxTotal.Text = "" Then
            '----
        Else
            num1 = txtBoxTotal.Text
        End If
        '-----------------------
        If txtBoxTotal2.Text = "" Then
            '----
        Else
            num2 = txtBoxTotal2.Text
        End If
        '-----------------------
        If txtBoxTotal3.Text = "" Then
            '----
        Else
            num3 = txtBoxTotal3.Text
        End If
        '-----------------------
        If txtBoxTotal4.Text = "" Then
            '----
        Else
            num4 = txtBoxTotal4.Text
        End If
        '-----------------------
        If txtBoxTotal5.Text = "" Then
            '----
        Else
            num5 = txtBoxTotal5.Text
        End If

        result = num1 + num2 + num3 + num4 + num5

        txtBoxGrandTotal.Text = result

        '===========================================================================
    End Sub

    '----------------------------- CLEAR BUTTON 3 ------------------------------------------
    Protected Sub butClear3_Click(sender As Object, e As EventArgs) Handles butClear3.Click
        'clears all the buttons textBoxes here:
        txtBoxProductCode3.Text = ""
        txtBoxDescription3.Text = ""
        txtBoxPrice3.Text = ""
        txtBoxQuantity3.Text = ""
        txtBoxTotal3.Text = ""

        '====== Grand Total recalculation for the Add and Clear buttons: ======== 
        'Declare variables here:
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim result As Double

        If txtBoxTotal.Text = "" Then
            '----
        Else
            num1 = txtBoxTotal.Text
        End If
        '-----------------------
        If txtBoxTotal2.Text = "" Then
            '----
        Else
            num2 = txtBoxTotal2.Text
        End If
        '-----------------------
        If txtBoxTotal3.Text = "" Then
            '----
        Else
            num3 = txtBoxTotal3.Text
        End If
        '-----------------------
        If txtBoxTotal4.Text = "" Then
            '----
        Else
            num4 = txtBoxTotal4.Text
        End If
        '-----------------------
        If txtBoxTotal5.Text = "" Then
            '----
        Else
            num5 = txtBoxTotal5.Text
        End If

        result = num1 + num2 + num3 + num4 + num5

        txtBoxGrandTotal.Text = result

        '===========================================================================
    End Sub

    '----------------------------- CLEAR BUTTON 4 ------------------------------------------
    Protected Sub butClear4_Click(sender As Object, e As EventArgs) Handles butClear4.Click
        'clears all the buttons textBoxes here:
        txtBoxProductCode4.Text = ""
        txtBoxDescription4.Text = ""
        txtBoxPrice4.Text = ""
        txtBoxQuantity4.Text = ""
        txtBoxTotal4.Text = ""

        '====== Grand Total recalculation for the Add and Clear buttons: ======== 
        'Declare variables here:
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim result As Double

        If txtBoxTotal.Text = "" Then
            '----
        Else
            num1 = txtBoxTotal.Text
        End If
        '-----------------------
        If txtBoxTotal2.Text = "" Then
            '----
        Else
            num2 = txtBoxTotal2.Text
        End If
        '-----------------------
        If txtBoxTotal3.Text = "" Then
            '----
        Else
            num3 = txtBoxTotal3.Text
        End If
        '-----------------------
        If txtBoxTotal4.Text = "" Then
            '----
        Else
            num4 = txtBoxTotal4.Text
        End If
        '-----------------------
        If txtBoxTotal5.Text = "" Then
            '----
        Else
            num5 = txtBoxTotal5.Text
        End If

        result = num1 + num2 + num3 + num4 + num5

        txtBoxGrandTotal.Text = result

        '===========================================================================
    End Sub

    '----------------------------- CLEAR BUTTON 5 ------------------------------------------
    Protected Sub butClear5_Click(sender As Object, e As EventArgs) Handles butClear5.Click
        'clears all the buttons textBoxes here:
        txtBoxProductCode5.Text = ""
        txtBoxDescription5.Text = ""
        txtBoxPrice5.Text = ""
        txtBoxQuantity5.Text = ""
        txtBoxTotal5.Text = ""

        '====== Grand Total recalculation for the Add and Clear buttons: ======== 
        'Declare variables here:
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        Dim result As Double

        If txtBoxTotal.Text = "" Then
            '----
        Else
            num1 = txtBoxTotal.Text
        End If
        '-----------------------
        If txtBoxTotal2.Text = "" Then
            '----
        Else
            num2 = txtBoxTotal2.Text
        End If
        '-----------------------
        If txtBoxTotal3.Text = "" Then
            '----
        Else
            num3 = txtBoxTotal3.Text
        End If
        '-----------------------
        If txtBoxTotal4.Text = "" Then
            '----
        Else
            num4 = txtBoxTotal4.Text
        End If
        '-----------------------
        If txtBoxTotal5.Text = "" Then
            '----
        Else
            num5 = txtBoxTotal5.Text
        End If

        result = num1 + num2 + num3 + num4 + num5

        txtBoxGrandTotal.Text = result

        '===========================================================================
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        '=== my table! ===================================================
        Dim i As Integer

        'declares a row:
        For i = 0 To 5
            'instance (copy of) of a class
            Dim rowNew As New TableRow()
            'instance (copy of) of a class

            Dim celNew1 As New TableCell()
            Dim celNew2 As New TableCell()
            Dim celNew3 As New TableCell()
            Dim celNew4 As New TableCell()
            Dim celNew5 As New TableCell()

            'row loop
            If i = 0 Then
                'set the cell value:
                celNew1.Text = "Product Code: "

                'set the cell value:
                celNew2.Text = " Description: "

                'set the cell value:
                celNew3.Text = " Box Price: "

                'set the cell value:
                celNew4.Text = " Box Quantity: "

                'set the cell value:
                celNew5.Text = " Box Total: "
            End If

            'row loop
            If i = 1 Then
                'set the cell value:
                celNew1.Text = (txtBoxProductCode.Text)

                'set the cell value:
                celNew2.Text = (txtBoxDescription.Text)

                'set the cell value:
                celNew3.Text = (txtBoxPrice.Text)

                'set the cell value:
                celNew4.Text = (txtBoxQuantity1.Text)

                'set the cell value:
                celNew5.Text = (txtBoxTotal.Text)
            End If

            'row loop
            If i = 2 Then
                'set the cell value:
                celNew1.Text = (txtBoxProductCode2.Text)

                'set the cell value:
                celNew2.Text = (txtBoxDescription2.Text)

                'set the cell value:
                celNew3.Text = (txtBoxPrice2.Text)

                'set the cell value:
                celNew4.Text = (txtBoxQuantity2.Text)

                'set the cell value:
                celNew5.Text = (txtBoxTotal2.Text)
            End If

            'row loop
            If i = 3 Then
                'set the cell value:
                celNew1.Text = (txtBoxProductCode3.Text)

                'set the cell value:
                celNew2.Text = (txtBoxDescription3.Text)

                'set the cell value:
                celNew3.Text = (txtBoxPrice3.Text)

                'set the cell value:
                celNew4.Text = (txtBoxQuantity3.Text)

                'set the cell value:
                celNew5.Text = (txtBoxTotal3.Text)
            End If

            'row loop
            If i = 4 Then
                'set the cell value:
                celNew1.Text = (txtBoxProductCode4.Text)

                'set the cell value:
                celNew2.Text = (txtBoxDescription4.Text)

                'set the cell value:
                celNew3.Text = (txtBoxPrice4.Text)

                'set the cell value:
                celNew4.Text = (txtBoxQuantity4.Text)

                'set the cell value:
                celNew5.Text = (txtBoxTotal4.Text)
            End If

            'row loop
            If i = 5 Then
                'set the cell value:
                celNew1.Text = (txtBoxProductCode5.Text)

                'set the cell value:
                celNew2.Text = (txtBoxDescription5.Text)

                'set the cell value:
                celNew3.Text = (txtBoxPrice5.Text)

                'set the cell value:
                celNew4.Text = (txtBoxQuantity5.Text)

                'set the cell value:
                celNew5.Text = (txtBoxTotal5.Text)
            End If
            '--------------------------------------------------------

            'ADD THE 5 CELLS TO THE ONE ROW:
            rowNew.Cells.Add(celNew1)
            rowNew.Cells.Add(celNew2)
            rowNew.Cells.Add(celNew3)
            rowNew.Cells.Add(celNew4)
            rowNew.Cells.Add(celNew5)

            'If 1 doesn't equal <> 2 then do it, ie if the first cell isn't equal to blank, then add the row:
            If celNew1.Text <> "" Then
                'adds the instance of the row class to the table:
                Table1.Rows.Add(rowNew)
            End If

        Next
    End Sub
End Class