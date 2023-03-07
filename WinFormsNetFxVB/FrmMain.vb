Friend Class FrmMain

	Private DgvTextBox As TextBox

	Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DataGridView1.Rows.Add(5)
	End Sub

	Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
		DgvTextBox = DirectCast(e.Control, TextBox)
		AddHandler DgvTextBox.KeyDown, AddressOf HandleTextInput
	End Sub

	Private Sub HandleTextInput(sender As Object, e As KeyEventArgs)
		If Not e.Control Then Return

		Select Case e.KeyCode
			Case Keys.C
				MessageBox.Show("Foo")
				TextBox1.Text = Clipboard.GetText
		End Select
		e.SuppressKeyPress = True
		e.Handled = True
	End Sub

	Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
		If DgvTextBox IsNot Nothing Then RemoveHandler DgvTextBox.KeyDown, AddressOf HandleTextInput
	End Sub

End Class