<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnHalf = New System.Windows.Forms.Button()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(340, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Result"
        '
        'btnHalf
        '
        Me.btnHalf.Location = New System.Drawing.Point(132, 62)
        Me.btnHalf.Name = "btnHalf"
        Me.btnHalf.Size = New System.Drawing.Size(100, 23)
        Me.btnHalf.TabIndex = 8
        Me.btnHalf.Text = "a Half"
        Me.btnHalf.UseVisualStyleBackColor = True
        '
        'btnDouble
        '
        Me.btnDouble.Location = New System.Drawing.Point(26, 62)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(100, 23)
        Me.btnDouble.TabIndex = 7
        Me.btnDouble.Text = "Double"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(340, 36)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 6
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(26, 36)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(206, 20)
        Me.txtData.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 117)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnHalf)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents btnHalf As Button
    Private WithEvents btnDouble As Button
    Private WithEvents txtResult As TextBox
    Private WithEvents txtData As TextBox
End Class
