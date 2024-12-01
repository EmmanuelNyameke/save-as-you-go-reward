' Program Name: Save As You Go Rewards
' Date: November 30, 2024
' Author: K Bola
' Purpose: This application allows bank customers to check their balance on their rewards account by requesting the number of transactions
Public Class frmRewards
    Dim decStarterBalance As Decimal
    Dim intNumberOfDebit As Integer
    Dim intSelectedRate As Integer
    Dim decFinalAmount As Decimal
    Dim dblInterestRate As Double
    Dim dblRate As Double = 0.01
    Dim intReward As Integer = 1
    Dim intTotalReward As Integer
    Dim decWithdrawalAmt As Decimal
    Dim decToTalBalance As Decimal
    Dim decTotalBalanceWithoutRate As Decimal
    Private Sub frmRewards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        lblBalance.Text = ""
        lblReward.Text = ""
        lblTotalBalance.Text = ""
    End Sub
    Private Function CalculateInterestPerMonth(decStarterBalance As Decimal, dblRate As Double) As Decimal
        Return decStarterBalance * dblRate
    End Function
    Private Function CalculateReward(intNumberOfDebit As Integer, intReward As Integer) As Integer
        Return intNumberOfDebit * intReward
    End Function
    Private Function FinalBalance(decTotalRate As Decimal, intTotalReward As Integer, decStarterBalance As Decimal) As Decimal
        Return decTotalRate + intTotalReward + decStarterBalance
    End Function
    Private Function FinalBalanceWithoutRate(decStarterBalance As Decimal, intTotalReward As Integer) As Decimal
        Return decStarterBalance + intTotalReward
    End Function
    Private Sub btnCheckBalance_Click(sender As Object, e As EventArgs) Handles btnCheckBalance.Click
        Try
            decStarterBalance = Convert.ToDecimal(txtStarterBalance.Text)
            intNumberOfDebit = Convert.ToInt32(txtDebit.Text)
            intSelectedRate = cboInterestRate.SelectedIndex
            dblInterestRate = CalculateInterestPerMonth(decStarterBalance, dblRate)
            If (decStarterBalance > 50 And intSelectedRate = 0 And intNumberOfDebit > 0) Then
                lblBalance.Text = decStarterBalance.ToString("C")
                intTotalReward = CalculateReward(intNumberOfDebit, intReward)
                lblReward.Text = intTotalReward.ToString("C")
                decFinalAmount = FinalBalanceWithoutRate(decStarterBalance, intTotalReward)
                lblTotalBalance.Text = decFinalAmount.ToString("C")
            ElseIf (decStarterBalance > 50 And intSelectedRate = 1 And intNumberOfDebit > 0) Then
                lblBalance.Text = decStarterBalance.ToString("C")
                intTotalReward = CalculateReward(intNumberOfDebit, intReward)
                lblReward.Text = intTotalReward.ToString("C")
                decFinalAmount = FinalBalance(decStarterBalance, dblInterestRate, intTotalReward)
                lblTotalBalance.Text = decFinalAmount.ToString("C")
            Else
                MsgBox("Starter Balance must be $50 and above", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Message")
            End If
        Catch ex As Exception
            MsgBox("Enter a Value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
        End Try
    End Sub
    Private Sub btnWithdrawal_Click(sender As Object, e As EventArgs) Handles btnWithdrawal.Click
        Dim strMessage As String = "How much are you withdrawing?"
        Dim strNegativeValue As String = "Error - Enter amount greater than zero."
        Dim strNumericError As String = "Error - Enter amount in figures."
        Dim decDeduction1 As Decimal
        Dim decDeduction2 As Decimal
        Dim decDeduct As Decimal
        Dim strInput As String
        Try
            dblInterestRate = CalculateInterestPerMonth(decStarterBalance, dblRate)
            intTotalReward = CalculateReward(intNumberOfDebit, intReward)
            decTotalBalanceWithoutRate = FinalBalanceWithoutRate(decStarterBalance, intTotalReward)
            decToTalBalance = FinalBalance(dblInterestRate, intTotalReward, decStarterBalance)
            intSelectedRate = cboInterestRate.SelectedIndex
            strInput = InputBox(strMessage, "Money Withdrawal", "")
            If (IsNumeric(strInput)) Then
                decWithdrawalAmt = Convert.ToDecimal(strInput)
                If (decWithdrawalAmt >= intTotalReward) Then
                    lblReward.Text = "$0.00"
                Else
                    decDeduct = decWithdrawalAmt - intTotalReward
                    lblReward.Text = decDeduct.ToString("C")
                End If
                If (decWithdrawalAmt <= decTotalBalanceWithoutRate And intSelectedRate = 0) Then
                    decDeduction1 = decTotalBalanceWithoutRate - decWithdrawalAmt - intTotalReward
                    decDeduction2 = decStarterBalance - decWithdrawalAmt
                    lblBalance.Text = decDeduction2.ToString("C")
                    lblTotalBalance.Text = decDeduction1.ToString("C")
                    MsgBox("You have successfully withdrawn " & decWithdrawalAmt.ToString("C"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Operation Successful")
                ElseIf (decWithdrawalAmt <= decToTalBalance And intSelectedRate = 1) Then
                    decDeduction1 = decToTalBalance - decWithdrawalAmt - intTotalReward
                    decDeduction2 = decStarterBalance - decWithdrawalAmt
                    lblBalance.Text = decDeduction2.ToString("C")
                    lblTotalBalance.Text = decDeduction1.ToString("C")
                    MsgBox("You have successfully withdrawn " & decWithdrawalAmt.ToString("C"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Operation Successful")
                Else
                    MsgBox("Insufficient Balance", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Not enough funds")
                End If
            Else
                strMessage = strNumericError
            End If
        Catch ex As Exception
            MsgBox(strNegativeValue, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
        End Try
    End Sub
End Class
