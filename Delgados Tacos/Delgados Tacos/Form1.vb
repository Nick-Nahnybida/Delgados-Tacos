Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The following variables are for the number of items ordered.
        ' Dim taco, burrito, chimichanga, superBurrito, drink, tacoBowl, churro, sopoPeia, refriedBeans,
        ' nachos As Double
        ' The following variables are for the price of each item. 
        Dim tacoPrice, burritoPrice, chimichangaPrice, superBurritoPrice, drinkPrice, tacobowlPrice,
            churroPrice, sopoPrice, refriedPrice, nachosPrice As Double
        Dim totalPrice, totalPricewithTax, taxRate As Double
        taxRate = 0.075.ToString("C")

        ' Below is the total price for each item
        Dim tacoTotal, burritoTotal, chimichangaTotal, superBurritoTotal, drinkTotal, tacoBowlTotal, churroTotal,
            sopoTotal, refriedTotal, nachoTotal As Double

        tacoPrice = 0.99
        burritoPrice = 1.5
        chimichangaPrice = 2.5
        superBurritoPrice = 5.0
        drinkPrice = 2.25
        tacobowlPrice = 6.1
        churroPrice = 1.0
        sopoPrice = 0.5
        refriedPrice = 1.25
        nachosPrice = 2.5

        tacoTotal = CDbl(txtTaco.Text) * tacoPrice
        burritoTotal = CDbl(txtBurrito.Text) * burritoPrice
        chimichangaTotal = CDbl(txtChimichanga.Text) * chimichangaPrice
        superBurritoTotal = CDbl(txtSuperBurrito.Text) * superBurritoPrice
        drinkTotal = CDbl(txtDrink.Text) * drinkPrice
        tacoBowlTotal = CDbl(txtTacoBowl.Text) * tacobowlPrice
        churroTotal = CDbl(txtChurro.Text) * churroPrice
        sopoTotal = CDbl(txtSopo.Text) * sopoPrice
        refriedTotal = CDbl(txtRefried.Text) * refriedPrice
        nachoTotal = CDbl(txtNachos.Text) * nachosPrice

        totalPrice = tacoTotal + burritoTotal + chimichangaTotal + superBurritoTotal + drinkTotal +
            tacoBowlTotal + churroTotal + sopoTotal + refriedTotal + nachoTotal
        lblTotalPrice.Text = CDbl(totalPrice)
        totalPricewithTax = (totalPrice * taxRate) + totalPrice
        lblTotalPriceTax.Text = CDbl(totalPricewithTax)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTaco.Clear()
        txtBurrito.Clear()
        txtChimichanga.Clear()
        txtSuperBurrito.Clear()
        txtDrink.Clear()
        txtTacoBowl.Clear()
        txtChurro.Clear()
        txtSopo.Clear()
        txtRefried.Clear()
        txtNachos.Clear()
        lblTotalPrice.Text = ""
        lblTotalPriceTax.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTaco.Text = "0"
        txtBurrito.Text = "0"
        txtChimichanga.Text = "0"
        txtSuperBurrito.Text = "0"
        txtDrink.Text = "0"
        txtTacoBowl.Text = "0"
        txtChurro.Text = "0"
        txtSopo.Text = "0"
        txtRefried.Text = "0"
        txtNachos.Text = "0"
    End Sub
End Class
