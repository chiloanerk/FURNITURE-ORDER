'Relebogile Chiloane
'Student Number 10427473
'ICT2611 Assignment 4 Project 1 - Furniture Order
Public Class Form1
  'Here i set the global variables for the constants
  Const Chair As Double = 350
  Const Sofa As Double = 925
  Const TaxRate = 0.05
  Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
	Dim invoiceNum As String
	Dim custName, address, cityState As String
	custName = txtCustName.Text
	address = txtAddress.Text
	cityState = txtCityState.Text
	Dim reorderedName As String
	Dim numChairs As Integer = CInt(txtChairs.Text)
	Dim numSofas As Integer = CInt(txtSofas.Text)
	Dim price, salesTax, totalPrice As Double


	'This will generate the invoice number, taking the first two letters
	'from the customer name input and the last four digits of the zip code
	invoiceNum = ComputeInvoice(custName, cityState)
	lstResults.Items.Add("Invoice Number: " & invoiceNum)
	lstResults.Items.Add("")

	'Here's the code for the reordering of the first and last names
	reorderedName = ComputeNameOrder(custName)
	lstResults.Items.Add("Name: " & reorderedName)

	'Display the address and city
	lstResults.Items.Add("Address: " & address)
	lstResults.Items.Add("City: " & cityState)
	lstResults.Items.Add("")

	'Display the number of chairs and sofas
	lstResults.Items.Add("Number of Chairs: " & numChairs)
	lstResults.Items.Add("Number of Sofas: " & numSofas)
	lstResults.Items.Add("")

	'Code for calculating the amounts due
	totalPrice = ComputeAmounts(Chair, Sofa, TaxRate, price, salesTax, numChairs, numSofas)
	'Display the amounts
	lstResults.Items.Add("         Price:   " & price.ToString("C"))
	lstResults.Items.Add("   Sales Tax:   " & salesTax.ToString("C"))
	lstResults.Items.Add("                     ------------")
	lstResults.Items.Add("Total Price:   " & totalPrice.ToString("C"))

  End Sub

  'Function for calculating total amount
  Function ComputeAmounts(ByRef Chair As Double, ByRef Sofa As Double, ByRef TaxRate As Double, price As Double, salesTax As Double, numChairs As Integer, numSofas As Integer) As Double
	price = numChairs * Chair + numSofas * Sofa
	salesTax = price * TaxRate
	Return price + salesTax
  End Function

  'Function for the reordering of the customer names
  Function ComputeNameOrder(custName As String)
	Dim firstName, lastName As String
	Dim commaSpace As Integer
	commaSpace = custName.IndexOf(", ")
	firstName = custName.Substring(commaSpace + 1)
	lastName = custName.Substring(0, commaSpace)
	Return firstName & " " & lastName
  End Function

  'Function for the generation of the invoice number
  Function ComputeInvoice(custName As String, cityState As String) As String
	Dim firstTwoLetters As String
	Dim lastFourDigits As String
	firstTwoLetters = custName.Substring(0, 2)
	lastFourDigits = cityState.Substring(cityState.Length - 4)
	Return firstTwoLetters.ToUpper & lastFourDigits
  End Function

  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
	'Clear all the text boxes and the list box
	txtCustName.Clear()
	txtAddress.Clear()
	txtCityState.Clear()
	txtChairs.Clear()
	txtSofas.Clear()
	lstResults.Items.Clear()
  End Sub

  Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
	Me.Close()
  End Sub

End Class
