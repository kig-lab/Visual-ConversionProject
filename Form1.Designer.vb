<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        ComboBaseCurrency = New ComboBox()
        BtnConvert = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtAmount = New TextBox()
        ComboTargetCurrency = New ComboBox()
        Label4 = New Label()
        TxtResult = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' ComboBaseCurrency
        ' 
        ComboBaseCurrency.FormattingEnabled = True
        ComboBaseCurrency.Items.AddRange(New Object() {"Swiss Franc", "Euros", "Kenya Shillings"})
        ComboBaseCurrency.Location = New Point(340, 70)
        ComboBaseCurrency.Name = "ComboBaseCurrency"
        ComboBaseCurrency.Size = New Size(146, 23)
        ComboBaseCurrency.TabIndex = 0
        ' 
        ' BtnConvert
        ' 
        BtnConvert.BackColor = Color.DodgerBlue
        BtnConvert.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnConvert.Location = New Point(166, 255)
        BtnConvert.Name = "BtnConvert"
        BtnConvert.Size = New Size(144, 41)
        BtnConvert.TabIndex = 1
        BtnConvert.Text = "Convert"
        BtnConvert.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(180, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 2
        Label1.Text = "Base Currency"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(180, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 20)
        Label2.TabIndex = 3
        Label2.Text = "Choose Currency"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(181, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 4
        Label3.Text = "Enter Amount"
        ' 
        ' TxtAmount
        ' 
        TxtAmount.Location = New Point(340, 171)
        TxtAmount.Name = "TxtAmount"
        TxtAmount.Size = New Size(100, 23)
        TxtAmount.TabIndex = 6
        ' 
        ' ComboTargetCurrency
        ' 
        ComboTargetCurrency.FormattingEnabled = True
        ComboTargetCurrency.Location = New Point(340, 119)
        ComboTargetCurrency.Name = "ComboTargetCurrency"
        ComboTargetCurrency.Size = New Size(121, 23)
        ComboTargetCurrency.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(414, 266)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 21)
        Label4.TabIndex = 8
        Label4.Text = "Result"
        ' 
        ' TxtResult
        ' 
        TxtResult.Location = New Point(485, 263)
        TxtResult.Name = "TxtResult"
        TxtResult.Size = New Size(100, 23)
        TxtResult.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(239, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 21)
        Label5.TabIndex = 10
        Label5.Text = "THE FLIPRATE SYSTEM"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(TxtResult)
        Controls.Add(Label4)
        Controls.Add(ComboTargetCurrency)
        Controls.Add(TxtAmount)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnConvert)
        Controls.Add(ComboBaseCurrency)
        Name = "Form1"
        Text = "FlipRate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBaseCurrency As ComboBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents ComboTargetCurrency As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtResult As TextBox
    Friend WithEvents Label5 As Label

End Class
