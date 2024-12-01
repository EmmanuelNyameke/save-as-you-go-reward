<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRewards
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblTotalBalance = New Label()
        lblTotalTitle = New Label()
        lblReward = New Label()
        lblBalance = New Label()
        lblRewardTitle = New Label()
        lblBalanceTitle = New Label()
        btnWithdrawal = New Button()
        btnCheckBalance = New Button()
        txtDebit = New TextBox()
        lblDeblt = New Label()
        cboInterestRate = New ComboBox()
        txtStarterBalance = New TextBox()
        lblStarterBalance = New Label()
        lblHeading = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblTotalBalance)
        Panel1.Controls.Add(lblTotalTitle)
        Panel1.Controls.Add(lblReward)
        Panel1.Controls.Add(lblBalance)
        Panel1.Controls.Add(lblRewardTitle)
        Panel1.Controls.Add(lblBalanceTitle)
        Panel1.Controls.Add(btnWithdrawal)
        Panel1.Controls.Add(btnCheckBalance)
        Panel1.Controls.Add(txtDebit)
        Panel1.Controls.Add(lblDeblt)
        Panel1.Controls.Add(cboInterestRate)
        Panel1.Controls.Add(txtStarterBalance)
        Panel1.Controls.Add(lblStarterBalance)
        Panel1.Controls.Add(lblHeading)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(560, 530)
        Panel1.TabIndex = 0
        ' 
        ' lblTotalBalance
        ' 
        lblTotalBalance.AutoSize = True
        lblTotalBalance.Location = New Point(375, 498)
        lblTotalBalance.Name = "lblTotalBalance"
        lblTotalBalance.Size = New Size(73, 23)
        lblTotalBalance.TabIndex = 13
        lblTotalBalance.Text = "Label1"
        ' 
        ' lblTotalTitle
        ' 
        lblTotalTitle.AutoSize = True
        lblTotalTitle.Location = New Point(12, 498)
        lblTotalTitle.Name = "lblTotalTitle"
        lblTotalTitle.Size = New Size(284, 23)
        lblTotalTitle.TabIndex = 12
        lblTotalTitle.Text = "Total Balance with Interest: "
        ' 
        ' lblReward
        ' 
        lblReward.AutoSize = True
        lblReward.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        lblReward.Location = New Point(375, 457)
        lblReward.Name = "lblReward"
        lblReward.Size = New Size(73, 23)
        lblReward.TabIndex = 11
        lblReward.Text = "Label2"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        lblBalance.Location = New Point(375, 410)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(73, 23)
        lblBalance.TabIndex = 10
        lblBalance.Text = "Label1"
        ' 
        ' lblRewardTitle
        ' 
        lblRewardTitle.AutoSize = True
        lblRewardTitle.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        lblRewardTitle.Location = New Point(12, 457)
        lblRewardTitle.Name = "lblRewardTitle"
        lblRewardTitle.Size = New Size(366, 23)
        lblRewardTitle.TabIndex = 9
        lblRewardTitle.Text = "Balance in Vacation Reward Account:"
        ' 
        ' lblBalanceTitle
        ' 
        lblBalanceTitle.AutoSize = True
        lblBalanceTitle.Font = New Font("Tahoma", 14.25F, FontStyle.Bold)
        lblBalanceTitle.Location = New Point(12, 410)
        lblBalanceTitle.Name = "lblBalanceTitle"
        lblBalanceTitle.Size = New Size(278, 23)
        lblBalanceTitle.TabIndex = 8
        lblBalanceTitle.Text = "Balance in Savings Account:"
        ' 
        ' btnWithdrawal
        ' 
        btnWithdrawal.BackColor = Color.Gold
        btnWithdrawal.ForeColor = Color.White
        btnWithdrawal.Location = New Point(286, 339)
        btnWithdrawal.Name = "btnWithdrawal"
        btnWithdrawal.Size = New Size(178, 43)
        btnWithdrawal.TabIndex = 7
        btnWithdrawal.Text = "Withdraw"
        btnWithdrawal.UseVisualStyleBackColor = False
        ' 
        ' btnCheckBalance
        ' 
        btnCheckBalance.BackColor = Color.Gold
        btnCheckBalance.ForeColor = Color.White
        btnCheckBalance.Location = New Point(97, 339)
        btnCheckBalance.Name = "btnCheckBalance"
        btnCheckBalance.Size = New Size(178, 43)
        btnCheckBalance.TabIndex = 6
        btnCheckBalance.Text = "Check Balance"
        btnCheckBalance.UseVisualStyleBackColor = False
        ' 
        ' txtDebit
        ' 
        txtDebit.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDebit.Location = New Point(251, 279)
        txtDebit.Name = "txtDebit"
        txtDebit.Size = New Size(59, 33)
        txtDebit.TabIndex = 5
        txtDebit.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblDeblt
        ' 
        lblDeblt.AutoSize = True
        lblDeblt.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeblt.Location = New Point(107, 217)
        lblDeblt.Name = "lblDeblt"
        lblDeblt.Size = New Size(347, 50)
        lblDeblt.TabIndex = 4
        lblDeblt.Text = "Enter the Number of Debit Card " & vbCrLf & "Purchases and Bills Paid Online:"
        ' 
        ' cboInterestRate
        ' 
        cboInterestRate.FormattingEnabled = True
        cboInterestRate.Items.AddRange(New Object() {"0", "1% or more"})
        cboInterestRate.Location = New Point(161, 155)
        cboInterestRate.Name = "cboInterestRate"
        cboInterestRate.Size = New Size(239, 31)
        cboInterestRate.TabIndex = 3
        cboInterestRate.Text = "Monthly Interest Rate:"
        ' 
        ' txtStarterBalance
        ' 
        txtStarterBalance.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtStarterBalance.Location = New Point(239, 107)
        txtStarterBalance.Name = "txtStarterBalance"
        txtStarterBalance.Size = New Size(82, 33)
        txtStarterBalance.TabIndex = 2
        txtStarterBalance.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblStarterBalance
        ' 
        lblStarterBalance.AutoSize = True
        lblStarterBalance.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStarterBalance.Location = New Point(125, 70)
        lblStarterBalance.Name = "lblStarterBalance"
        lblStarterBalance.Size = New Size(310, 25)
        lblStarterBalance.TabIndex = 1
        lblStarterBalance.Text = "Enter Your Starting Balance:"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(70, 24)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(421, 39)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Save As You Go Rewards "
        ' 
        ' frmRewards
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.reward
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(831, 530)
        Controls.Add(Panel1)
        Name = "frmRewards"
        Text = "Save As You Go Rewards"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStarterBalance As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboInterestRate As ComboBox
    Friend WithEvents txtStarterBalance As TextBox
    Friend WithEvents txtDebit As TextBox
    Friend WithEvents lblDeblt As Label
    Friend WithEvents lblBalanceTitle As Label
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnCheckBalance As Button
    Friend WithEvents lblRewardTitle As Label
    Friend WithEvents lblReward As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblTotalBalance As Label
    Friend WithEvents lblTotalTitle As Label

End Class
