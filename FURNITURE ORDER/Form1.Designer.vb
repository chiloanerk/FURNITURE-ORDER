<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtCustName = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtCityState = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtChairs = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtSofas = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lstResults = New System.Windows.Forms.ListBox()
		Me.btnCompute = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnQuit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(12, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(95, 36)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Customer name (Last, First):"
		'
		'txtCustName
		'
		Me.txtCustName.Location = New System.Drawing.Point(113, 27)
		Me.txtCustName.Name = "txtCustName"
		Me.txtCustName.Size = New System.Drawing.Size(194, 23)
		Me.txtCustName.TabIndex = 1
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(113, 83)
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(194, 23)
		Me.txtAddress.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(46, 86)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(52, 15)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Address:"
		'
		'txtCityState
		'
		Me.txtCityState.Location = New System.Drawing.Point(113, 139)
		Me.txtCityState.Name = "txtCityState"
		Me.txtCityState.Size = New System.Drawing.Size(194, 23)
		Me.txtCityState.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 142)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(86, 15)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "City, State, Zip:"
		'
		'txtChairs
		'
		Me.txtChairs.Location = New System.Drawing.Point(113, 210)
		Me.txtChairs.Name = "txtChairs"
		Me.txtChairs.Size = New System.Drawing.Size(53, 23)
		Me.txtChairs.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(21, 210)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(86, 36)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Number of chairs ordered:"
		'
		'txtSofas
		'
		Me.txtSofas.Location = New System.Drawing.Point(113, 282)
		Me.txtSofas.Name = "txtSofas"
		Me.txtSofas.Size = New System.Drawing.Size(53, 23)
		Me.txtSofas.TabIndex = 9
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(21, 279)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(86, 36)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Number of sofas ordered:"
		'
		'lstResults
		'
		Me.lstResults.FormattingEnabled = True
		Me.lstResults.ItemHeight = 15
		Me.lstResults.Location = New System.Drawing.Point(342, 12)
		Me.lstResults.Name = "lstResults"
		Me.lstResults.Size = New System.Drawing.Size(179, 304)
		Me.lstResults.TabIndex = 10
		'
		'btnCompute
		'
		Me.btnCompute.Location = New System.Drawing.Point(21, 344)
		Me.btnCompute.Name = "btnCompute"
		Me.btnCompute.Size = New System.Drawing.Size(126, 42)
		Me.btnCompute.TabIndex = 11
		Me.btnCompute.Text = "Process Order"
		Me.btnCompute.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(210, 344)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(126, 42)
		Me.btnClear.TabIndex = 12
		Me.btnClear.Text = "Clear Order Form"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnQuit
		'
		Me.btnQuit.Location = New System.Drawing.Point(395, 344)
		Me.btnQuit.Name = "btnQuit"
		Me.btnQuit.Size = New System.Drawing.Size(126, 42)
		Me.btnQuit.TabIndex = 13
		Me.btnQuit.Text = "Quit"
		Me.btnQuit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(547, 398)
		Me.Controls.Add(Me.btnQuit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCompute)
		Me.Controls.Add(Me.lstResults)
		Me.Controls.Add(Me.txtSofas)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtChairs)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtCityState)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtCustName)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Furniture Order"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtCustName As TextBox
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtCityState As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtChairs As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtSofas As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents lstResults As ListBox
	Friend WithEvents btnCompute As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnQuit As Button
End Class
