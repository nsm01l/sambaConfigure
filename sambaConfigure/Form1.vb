Public Class Form1

    ' 初期設定
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' 基本
        lineBreak.SelectedIndex = 0
        browsable.SelectedIndex = 1
        writable.SelectedIndex = 1
        guestOK.SelectedIndex = 2
    End Sub

    ' OK が押された
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Dim cnf As SambaTan = New SambaTan(lineBreak.SelectedIndex,
                                           share.Text, path.Text, comment.Text, browsable.Text, writable.Text, guestOK.Text,
                                           createMask.Text, forceCreateMask.Text, directoryMask.Text, forceDirectoryMask.Text,
                                           forceUser.Text, forceGroup.Text, inheritParents.Text,
                                           validUsers, writeList, readList, hostsAllow, hostsDeny)
        Dim newLine As String
        With lineBreak
            If (.SelectedIndex = 0) Then
                newLine = vbCrLf
            ElseIf (.SelectedIndex = 1) Then
                newLine = vbLf
            Else
                newLine = vbLf
            End If
        End With

        ' ユーザー名読み取り
        Dim users() As String
        Dim userSize As Integer = userNames.Rows.Count
        If (userNames.Rows(userSize - 1).IsNewRow) Then
            userSize -= 1
        End If
        users = New String(userSize - 1) {}
        With userNames
            For i As Integer = userSize - 1 To 0 Step -1
                If (.Rows(i).Cells(0).Value Is Nothing) Then
                    users(i) = ""
                Else
                    users(i) = .Rows(i).Cells(0).Value.ToString.Trim
                End If
            Next i
        End With

        ' データ生成
        Dim str As String = ""
        With cnf
            For i As Integer = 0 To userSize - 1
                str &= .createSetting(users(i)) & .newLine
            Next i
        End With
        TextBox4.Text = str
    End Sub

    ' 保存ボタンが押された
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox4.Text, False)
            Catch ex As Exception
                MsgBox("Write fail!")
            End Try
        End If
    End Sub

    Private Sub すべて選択ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox4.SelectAll()
    End Sub
End Class
