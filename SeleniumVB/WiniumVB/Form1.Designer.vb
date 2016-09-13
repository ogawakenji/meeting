<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.radioTest1 = New System.Windows.Forms.RadioButton()
        Me.radioTest2 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.chkTest1 = New System.Windows.Forms.CheckBox()
        Me.chkTest2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(22, 12)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(159, 22)
        Me.txtTest.TabIndex = 0
        '
        'radioTest1
        '
        Me.radioTest1.AutoSize = True
        Me.radioTest1.Location = New System.Drawing.Point(22, 54)
        Me.radioTest1.Name = "radioTest1"
        Me.radioTest1.Size = New System.Drawing.Size(71, 19)
        Me.radioTest1.TabIndex = 1
        Me.radioTest1.TabStop = True
        Me.radioTest1.Text = "ラジオ１"
        Me.radioTest1.UseVisualStyleBackColor = True
        '
        'radioTest2
        '
        Me.radioTest2.AutoSize = True
        Me.radioTest2.Location = New System.Drawing.Point(99, 54)
        Me.radioTest2.Name = "radioTest2"
        Me.radioTest2.Size = New System.Drawing.Size(71, 19)
        Me.radioTest2.TabIndex = 2
        Me.radioTest2.TabStop = True
        Me.radioTest2.Text = "ラジオ２"
        Me.radioTest2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ドロップ１", "ドロップ２", "ドロップ３", "ドロップ４"})
        Me.ComboBox1.Location = New System.Drawing.Point(22, 115)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(139, 23)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "ドロップ１"
        '
        'chkTest1
        '
        Me.chkTest1.AutoSize = True
        Me.chkTest1.Location = New System.Drawing.Point(22, 79)
        Me.chkTest1.Name = "chkTest1"
        Me.chkTest1.Size = New System.Drawing.Size(79, 19)
        Me.chkTest1.TabIndex = 4
        Me.chkTest1.Text = "チェック１"
        Me.chkTest1.UseVisualStyleBackColor = True
        '
        'chkTest2
        '
        Me.chkTest2.AutoSize = True
        Me.chkTest2.Location = New System.Drawing.Point(107, 79)
        Me.chkTest2.Name = "chkTest2"
        Me.chkTest2.Size = New System.Drawing.Size(79, 19)
        Me.chkTest2.TabIndex = 5
        Me.chkTest2.Text = "チェック２"
        Me.chkTest2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.chkTest2)
        Me.Controls.Add(Me.chkTest1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.radioTest2)
        Me.Controls.Add(Me.radioTest1)
        Me.Controls.Add(Me.txtTest)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTest As TextBox
    Friend WithEvents radioTest1 As RadioButton
    Friend WithEvents radioTest2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents chkTest1 As CheckBox
    Friend WithEvents chkTest2 As CheckBox
End Class
