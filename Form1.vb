Public Class Form1
    'Conversion rates relative to USD (example)
    Dim exchangeRates As New Dictionary(Of String, Double) From {
        {"USD", 1.0},
        {"KES", 128.5},
        {"EURO", 0.93},
        {"GBP", 0.79},
        {"JPY", 150.2}
        }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add Currencies to both combo boxes
        Dim currencies = {"USD", "KES", "EURO", "GBP", "JPY"}

        ComboBaseCurrency.Items.AddRange(currencies)
        ComboTargetCurrency.Items.AddRange(currencies)

        'Placeholder text(not added as an item)
        ComboBaseCurrency.Text = "Select Base Currency.."
        ComboTargetCurrency.Text = "Select Target Currency.."
    End Sub


    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        'Validate inputs
        If Not exchangeRates.ContainsKey(ComboBaseCurrency.Text) Then
            MessageBox.Show("Please select a valid base currency.")
            Return

        End If
        If Not exchangeRates.ContainsKey(ComboTargetCurrency.Text) Then
            MessageBox.Show("Please select a valid target currency.")
            Return
        End If
        If Not IsNumeric(TxtAmount.Text) Then
            MessageBox.Show("Please enter a valid numeric amount.")
        End If

        'Perform conversion
        Dim amount As Double = Val(TxtAmount.Text)
        Dim baseRate As Double = exchangeRates(ComboBaseCurrency.Text)
        Dim targetRate As Double = exchangeRates(ComboTargetCurrency.Text)
        Dim result As Double = amount * (targetRate / baseRate)

        'Display result
        TxtResult.Text = $"Result: {Math.Round(result, 2)} {ComboTargetCurrency.Text}"

    End Sub


End Class
