Imports System.IO

Public Class ExportHandler
    Shared _filepath As String

    Public Shared Sub SaveAsVB(ByVal _saveDialog As SaveFileDialog, ByVal _title As String, ByVal _filesave As TextBox)
        Try
            _saveDialog = New SaveFileDialog
            _saveDialog.Title = _title

            _saveDialog.FileName = "Untitled"
            _saveDialog.Filter = "Text Files (.txt)|*.txt|Visual Basic (.vb)|*.vb"

            With _saveDialog
                .AddExtension = True
                .CheckPathExists = True
                .CheckFileExists = True
                .OverwritePrompt = True
                .ValidateNames = False
                .DefaultExt = "txt"
                .ShowHelp = True

                If _saveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(.FileName, _filesave.Text, False)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
