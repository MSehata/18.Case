<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnClose = New Button()
        btnCompute = New Button()
        lblGrade = New Label()
        lblResult = New Label()
        txtGrade = New TextBox()
        txtResult = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(355, 387)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(355, 318)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(94, 29)
        btnCompute.TabIndex = 1
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Location = New Point(203, 118)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(49, 20)
        lblGrade.TabIndex = 2
        lblGrade.Text = "Grade"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(203, 178)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(49, 20)
        lblResult.TabIndex = 3
        lblResult.Text = "Result"
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(401, 111)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(125, 27)
        txtGrade.TabIndex = 4
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(401, 171)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(125, 27)
        txtResult.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(154, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(529, 36)
        Label1.TabIndex = 2
        Label1.Text = "Enter a Grade(A, A-, B, C, ...)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtResult)
        Controls.Add(txtGrade)
        Controls.Add(lblResult)
        Controls.Add(Label1)
        Controls.Add(lblGrade)
        Controls.Add(btnCompute)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Grade using Case"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
End Class
