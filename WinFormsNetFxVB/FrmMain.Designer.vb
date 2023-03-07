<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
		Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
		Me.DataGridView1.TabIndex = 0
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(258, 12)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(297, 150)
		Me.TextBox1.TabIndex = 1
		'
		'Column1
		'
		Me.Column1.HeaderText = "Column1"
		Me.Column1.Name = "Column1"
		'
		'FrmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(567, 173)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "FrmMain"
		Me.Text = "Hauptformular"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
