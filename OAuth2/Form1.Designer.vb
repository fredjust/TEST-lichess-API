<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMakeBotMove = New System.Windows.Forms.Button()
        Me.txtMove = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.btnGetGames = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGameId = New System.Windows.Forms.TextBox()
        Me.txtGames = New System.Windows.Forms.TextBox()
        Me.btnMakeBoardMove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMakeBotMove
        '
        Me.btnMakeBotMove.Location = New System.Drawing.Point(182, 178)
        Me.btnMakeBotMove.Name = "btnMakeBotMove"
        Me.btnMakeBotMove.Size = New System.Drawing.Size(108, 23)
        Me.btnMakeBotMove.TabIndex = 0
        Me.btnMakeBotMove.Text = "Make a Bot Move"
        Me.btnMakeBotMove.UseVisualStyleBackColor = True
        '
        'txtMove
        '
        Me.txtMove.Location = New System.Drawing.Point(76, 180)
        Me.txtMove.Name = "txtMove"
        Me.txtMove.Size = New System.Drawing.Size(100, 20)
        Me.txtMove.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Token"
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(56, 36)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(161, 20)
        Me.txtToken.TabIndex = 3
        '
        'btnGetGames
        '
        Me.btnGetGames.Location = New System.Drawing.Point(223, 34)
        Me.btnGetGames.Name = "btnGetGames"
        Me.btnGetGames.Size = New System.Drawing.Size(75, 23)
        Me.btnGetGames.TabIndex = 4
        Me.btnGetGames.Text = "Get Games"
        Me.btnGetGames.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Game Id :"
        '
        'txtGameId
        '
        Me.txtGameId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGameId.Location = New System.Drawing.Point(360, 59)
        Me.txtGameId.Name = "txtGameId"
        Me.txtGameId.Size = New System.Drawing.Size(100, 13)
        Me.txtGameId.TabIndex = 6
        '
        'txtGames
        '
        Me.txtGames.Location = New System.Drawing.Point(304, 36)
        Me.txtGames.Name = "txtGames"
        Me.txtGames.Size = New System.Drawing.Size(608, 20)
        Me.txtGames.TabIndex = 7
        '
        'btnMakeBoardMove
        '
        Me.btnMakeBoardMove.Location = New System.Drawing.Point(182, 207)
        Me.btnMakeBoardMove.Name = "btnMakeBoardMove"
        Me.btnMakeBoardMove.Size = New System.Drawing.Size(108, 23)
        Me.btnMakeBoardMove.TabIndex = 8
        Me.btnMakeBoardMove.Text = "BOARD Move"
        Me.btnMakeBoardMove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 408)
        Me.Controls.Add(Me.btnMakeBoardMove)
        Me.Controls.Add(Me.txtGames)
        Me.Controls.Add(Me.txtGameId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGetGames)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMove)
        Me.Controls.Add(Me.btnMakeBotMove)
        Me.Name = "Form1"
        Me.Text = "API Lichess TEST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMakeBotMove As Button
    Friend WithEvents txtMove As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtToken As TextBox
    Friend WithEvents btnGetGames As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGameId As TextBox
    Friend WithEvents txtGames As TextBox
    Friend WithEvents btnMakeBoardMove As Button
End Class
