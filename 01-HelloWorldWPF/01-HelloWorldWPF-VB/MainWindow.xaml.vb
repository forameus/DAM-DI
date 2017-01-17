Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If Me.txtNombre.Text IsNot "" Then
            MessageBox.Show("Hola, " + Me.txtNombre.Text, "HOLA", MessageBoxButton.OK, MessageBoxImage.Information)
        Else
            txtNombre.Text = "Fernando"
        End If
    End Sub
End Class
