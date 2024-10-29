Public Class SambaTan
    Private _newLine As String = ""

    Private _share As String = ""
    Private _path As String = ""
    Private _comment As String = ""
    Private _browsable As String = ""
    Private _writable As String = ""
    Private _guestOk As String = ""

    Private _createMask As String = ""
    Private _forceCreateMask As String = ""
    Private _directoryMask As String = ""
    Private _forceDirectoryMask As String = ""
    Private _forceUser As String = ""
    Private _forceGroup As String = ""
    Private _inheritParents As String = ""

    Private _validUsers() As String = Nothing
    Private _writeList() As String = Nothing
    Private _readList() As String = Nothing

    Private _hostsAllow() As String = Nothing
    Private _hostsDeny() As String = Nothing

    Enum NewLines
        windows = 0
        unix = 1
        mac = 2
    End Enum

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="newLine"></param>
    ''' <param name="share"></param>
    ''' <param name="path"></param>
    ''' <param name="comment"></param>
    ''' <param name="browsable"></param>
    ''' <param name="writable"></param>
    ''' <param name="guestOk"></param>
    Public Sub New(ByVal newLine As NewLines,
                   ByVal share As String, ByVal path As String, ByVal comment As String,
                   ByVal browsable As String, ByVal writable As String, ByVal guestOk As String)
        If (newLine = NewLines.windows) Then
            Me._newLine = vbCrLf
        ElseIf (newLine = NewLines.unix) Then
            Me._newLine = vbLf
        Else
            Me._newLine = vbCr
        End If

        Me._share = share
        Me._path = path
        Me._comment = comment
        Me._browsable = browsable
        Me._writable = writable
        Me._guestOk = guestOk
    End Sub

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="newLine"></param>
    ''' <param name="share"></param>
    ''' <param name="path"></param>
    ''' <param name="comment"></param>
    ''' <param name="browsable"></param>
    ''' <param name="writable"></param>
    ''' <param name="guestOk"></param>
    ''' <param name="createMask"></param>
    ''' <param name="forceCreateMask"></param>
    ''' <param name="directoryMask"></param>
    ''' <param name="forceDirectoryMask"></param>
    ''' <param name="forceUser"></param>
    ''' <param name="forceGroup"></param>
    ''' <param name="inheritParents"></param>
    Public Sub New(ByVal newLine As NewLines,
                   ByVal share As String, ByVal path As String, ByVal comment As String,
                   ByVal browsable As String, ByVal writable As String, ByVal guestOk As String,
                   ByVal createMask As String, ByVal forceCreateMask As String,
                   ByVal directoryMask As String, ByVal forceDirectoryMask As String,
                   ByVal forceUser As String, ByVal forceGroup As String, ByVal inheritParents As String)
        Me.New(newLine, share, path, comment, browsable, writable, guestOk)

        Me._createMask = validPermission(createMask)
        Me._forceCreateMask = forceCreateMask
        Me._directoryMask = validPermission(directoryMask)
        Me._forceDirectoryMask = forceDirectoryMask
        Me._forceUser = validUser(forceUser)
        Me._forceGroup = validUser(forceGroup)
        Me._inheritParents = inheritParents
    End Sub

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="newLine"></param>
    ''' <param name="share"></param>
    ''' <param name="path"></param>
    ''' <param name="comment"></param>
    ''' <param name="browsable"></param>
    ''' <param name="writable"></param>
    ''' <param name="guestOk"></param>
    ''' <param name="createMask"></param>
    ''' <param name="forceCreateMask"></param>
    ''' <param name="directoryMask"></param>
    ''' <param name="forceDirectoryMask"></param>
    ''' <param name="forceUser"></param>
    ''' <param name="forceGroup"></param>
    ''' <param name="inheritParents"></param>
    ''' <param name="validUsers"></param>
    ''' <param name="writeList"></param>
    ''' <param name="readList"></param>
    Public Sub New(ByVal newLine As NewLines,
                   ByVal share As String, ByVal path As String, ByVal comment As String,
                   ByVal browsable As String, ByVal writable As String, ByVal guestOk As String,
                   ByVal createMask As String, ByVal forceCreateMask As String,
                   ByVal directoryMask As String, ByVal forceDirectoryMask As String,
                   ByVal forceUser As String, ByVal forceGroup As String, ByVal inheritParents As String,
                   ByVal validUsers As DataGridView, ByVal writeList As DataGridView, ByVal readList As DataGridView)
        Me.New(newLine, share, path, comment, browsable, writable, guestOk,
            createMask, forceCreateMask, directoryMask, forceDirectoryMask, forceUser, forceGroup, inheritParents)

        _validUsers = importUser(validUsers)
        _writeList = importUser(writeList)
        _readList = importUser(readList)
    End Sub

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="newLine"></param>
    ''' <param name="share"></param>
    ''' <param name="path"></param>
    ''' <param name="comment"></param>
    ''' <param name="browsable"></param>
    ''' <param name="writable"></param>
    ''' <param name="guestOk"></param>
    ''' <param name="createMask"></param>
    ''' <param name="forceCreateMask"></param>
    ''' <param name="directoryMask"></param>
    ''' <param name="forceDirectoryMask"></param>
    ''' <param name="forceUser"></param>
    ''' <param name="forceGroup"></param>
    ''' <param name="inhertParents"></param>
    ''' <param name="validUsers"></param>
    ''' <param name="writeList"></param>
    ''' <param name="readList"></param>
    ''' <param name="hostsAllow"></param>
    ''' <param name="hostsDeny"></param>
    Public Sub New(ByVal newLine As NewLines,
                   ByVal share As String, ByVal path As String, ByVal comment As String,
                   ByVal browsable As String, ByVal writable As String, ByVal guestOk As String,
                   ByVal createMask As String, ByVal forceCreateMask As String,
                   ByVal directoryMask As String, ByVal forceDirectoryMask As String,
                   ByVal forceUser As String, ByVal forceGroup As String, ByVal inhertParents As String,
                   ByVal validUsers As DataGridView, ByVal writeList As DataGridView, ByVal readList As DataGridView,
                   ByVal hostsAllow As DataGridView, ByVal hostsDeny As DataGridView)
        Me.New(newLine, share, path, comment, browsable, writable, guestOk,
               createMask, forceCreateMask, directoryMask, forceDirectoryMask, forceUser, forceGroup, inhertParents,
               validUsers, writeList, readList)
        _hostsAllow = importNetwork(hostsAllow)
        _hostsDeny = importNetwork(hostsDeny)
    End Sub

    ' =======================================
    ' プロパティー
    ' =======================================
    Public ReadOnly Property share() As String
        Get
            Return Me._share
        End Get
    End Property

    Public ReadOnly Property path() As String
        Get
            Return Me._path
        End Get
    End Property

    Public ReadOnly Property comment() As String
        Get
            Return Me._comment
        End Get
    End Property

    Public ReadOnly Property browsable() As String
        Get
            Return Me._browsable
        End Get
    End Property

    Public ReadOnly Property writable() As String
        Get
            Return Me._writable
        End Get
    End Property

    Public ReadOnly Property guestOk() As String
        Get
            Return Me._guestOk
        End Get
    End Property

    Public ReadOnly Property createMask() As String
        Get
            Return Me._createMask
        End Get
    End Property

    Public ReadOnly Property forceCreateMask() As String
        Get
            Return Me._forceCreateMask
        End Get
    End Property

    Public ReadOnly Property directoryMask() As String
        Get
            Return Me._directoryMask
        End Get
    End Property

    Public ReadOnly Property forceDirectoryMask() As String
        Get
            Return Me._forceDirectoryMask
        End Get
    End Property

    Public ReadOnly Property forceUser() As String
        Get
            Return Me._forceUser
        End Get
    End Property

    Public ReadOnly Property forceGroup() As String
        Get
            Return Me._forceGroup
        End Get
    End Property

    Public ReadOnly Property inheritParents() As String
        Get
            Return Me._inheritParents
        End Get
    End Property

    Public ReadOnly Property newLine() As String
        Get
            Return Me._newLine
        End Get
    End Property

    ''' <summary>
    ''' valid users の数をカウント
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property validUsersCount() As Integer
        Get
            If (Me._validUsers Is Nothing) Then
                Return 0
            Else
                Return Me._validUsers.Length
            End If
        End Get
    End Property

    ''' <summary>
    ''' write list の数をカウント
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property writeListCount() As Integer
        Get
            If (Me._writeList Is Nothing) Then
                Return 0
            Else
                Return Me._writeList.Length
            End If
        End Get
    End Property

    ''' <summary>
    ''' read list の数をカウント
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property readListCount() As Integer
        Get
            If (Me._readList Is Nothing) Then
                Return 0
            Else
                Return Me._readList.Length
            End If
        End Get
    End Property

    ''' <summary>
    ''' Valid Users のリストを得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public ReadOnly Property validUsersList(ByVal user As String) As String
        Get
            Return createList(_validUsers, user)
        End Get
    End Property

    ''' <summary>
    ''' Write List のリストを得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public ReadOnly Property writeListList(ByVal user As String) As String
        Get
            Return createList(_writeList, user)
        End Get
    End Property

    ''' <summary>
    ''' Read List のリストを得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public ReadOnly Property readListList(ByVal user As String) As String
        Get
            Return createList(_readList, user)
        End Get
    End Property

    ''' <summary>
    ''' hostsAllow の数を得る
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property hostsAllowCount() As Integer
        Get
            If (_hostsAllow Is Nothing) Then
                Return 0
            Else
                Return _hostsAllow.Length
            End If
        End Get
    End Property

    ''' <summary>
    ''' hostsDeny の数を得る
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property hostsDenyCount() As Integer
        Get
            If (_hostsDeny Is Nothing) Then
                Return 0
            Else
                Return _hostsDeny.Length
            End If
        End Get
    End Property

    ''' <summary>
    ''' hostsAllow のリストを得る
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property hostsAllow() As String
        Get
            Return createHostsList(_hostsAllow)
        End Get
    End Property

    ''' <summary>
    ''' hostsDeny のリストを得る
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property hostsDeny() As String
        Get
            Return createHostsList(_hostsDeny)
        End Get
    End Property

    ' =======================================
    ' メソッド
    ' =======================================

    ''' <summary>
    ''' 共有フォルダ名称を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getShare(ByVal user As String) As String
        Return fmtString(Me._share, user)
    End Function

    ''' <summary>
    ''' ディレクトリ名称を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getPath(ByVal user As String) As String
        Return fmtString(Me._path, user)
    End Function

    ''' <summary>
    ''' コメントを得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getComment(ByVal user As String) As String
        Return fmtString(Me._comment, user)
    End Function

    ''' <summary>
    ''' 表示可能を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getBrowsable() As String
        Return writeOrNothing("browsable", Me._browsable)
    End Function

    ''' <summary>
    ''' 書き込み可能を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getWritable() As String
        Return writeOrNothing("writable", Me._writable)
    End Function

    ''' <summary>
    ''' 読み込み制限を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getReadOnly() As String
        If (Me._writable.Length = "") Then
            Return ""
        Else
            If (String.Compare(Me._writable, "Yes") = 0) Then
                Return "read only = No"
            Else
                Return "read only = Yes"
            End If
        End If
    End Function

    ''' <summary>
    ''' guest ok を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getGuestOk() As String
        Return writeOrNothing("guest ok", Me._guestOk)
    End Function

    ''' <summary>
    ''' create mask を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getCreateMask() As String
        Return writeOrNothing("create mode", Me._createMask)
    End Function

    ''' <summary>
    ''' force create mask を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getForceCreateMask() As String
        Return writeOrNothing("force create mode", maskString(Me._forceCreateMask, Me._createMask))
    End Function

    ''' <summary>
    ''' directory mask を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getDirectoryMask() As String
        Return writeOrNothing("directory mode", Me._directoryMask)
    End Function

    ''' <summary>
    ''' force directory mask を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getForceDirectoryMask() As String
        Return writeOrNothing("force directory mode", maskString(Me._forceDirectoryMask, Me._directoryMask))
    End Function

    ''' <summary>
    ''' force user を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getForceUser(ByVal user As String) As String
        Return writeOrNothing("force user", fmtString(Me._forceUser, user))
    End Function

    ''' <summary>
    ''' force group を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getForceGroup(ByVal user As String) As String
        Return writeOrNothing("force group", fmtString(Me._forceGroup, user))
    End Function

    ''' <summary>
    ''' inherit Parents を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getInheritParents() As String
        Return writeOrNothing("inherit parents", Me._inheritParents)
    End Function

    ''' <summary>
    ''' valid Users を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getValidUsers(ByVal user As String) As String
        Dim users As String = validUsersList(user)
        If (users.Length) = 0 Then
            Return ""
        Else
            Return "valid users = " & users
        End If
    End Function

    ''' <summary>
    ''' write user を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getWriteUser(ByVal user As String) As String
        Dim users As String = writeListList(user)
        If (users.Length = 0) Then
            Return ""
        Else
            Return "write user = " & users
        End If
    End Function

    ''' <summary>
    ''' read user を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function getReadUser(ByVal user As String) As String
        Dim users As String = readListList(user)
        If (users.Length = 0) Then
            Return ""
        Else
            Return "read user = " & users
        End If
    End Function

    ''' <summary>
    ''' hosts allow を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getHostsAllow() As String
        Dim hosts As String = hostsAllow()
        If (hosts.Length = 0) Then
            Return ""
        Else
            Return "hosts allow = " & hosts
        End If
    End Function

    ''' <summary>
    ''' hosts deny を得る
    ''' </summary>
    ''' <returns></returns>
    Public Function getHostsDeny() As String
        Dim hosts As String = hostsDeny()
        If (hosts.Length = 0) Then
            Return ""
        Else
            Return "hosts deny = " & hosts
        End If
    End Function

    ''' <summary>
    ''' ユーザー設定を得る
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function createSetting(ByVal user As String) As String
        Dim tabs As String = "   "

        Dim t As String = ""
        Dim dt As String    ' 文字列パーツ
        ' 共有フォルダ名
        t &= "[" & getShare(user) & "]" & _newLine
        ' ディレクトリパス
        t &= tabs & "path = " & getPath(user) & _newLine
        ' 説明文
        t &= tabs & "comment = " & getComment(user) & _newLine
        ' フォルダ名を表示
        dt = getBrowsable() ' browsable
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        ' 書き込み可能
        dt = getWritable()  ' writable
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        ' guest ok
        dt = getGuestOk()   ' guest ok
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If

        t &= _newLine
        ' ファイル処理
        dt = getCreateMask()    ' create mask
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        dt = getForceCreateMask()   ' force create mask
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        ' ディレクトリー処理
        dt = getDirectoryMask() ' directory mask
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        dt = getForceDirectoryMask()    ' force directory mask
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        ' force user
        dt = getForceUser(user) ' force user
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        ' force group
        dt = getForceGroup(user)    ' force group
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        ' inherit parents
        dt = getInheritParents()
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If

        t &= _newLine
        ' 許可するユーザー
        dt = getValidUsers(user)    ' valid users
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        dt = getWriteUser(user) ' write list
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        dt = getReadUser(user)  ' read list
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If

        t &= newLine
        ' 許可するホスト
        dt = getHostsAllow()
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If
        dt = getHostsDeny()
        If (dt.Length > 0) Then
            t &= tabs & dt & _newLine
        End If

        Return t
    End Function

    ' =======================================
    ' private メソッド
    ' =======================================

    ''' <summary>
    ''' 置換可能文字列 変換メソッド
    ''' </summary>
    ''' <param name="fmt"></param>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Private Function fmtString(ByVal fmt As String, ByVal user As String) As String
        If (fmt.IndexOf("%u%") >= 0) Then
            Return fmt.Replace("%u%", user)
        Else
            Return fmt.Replace("%u%", "")
        End If
    End Function

    ''' <summary>
    ''' 置換可能文字列 変換メソッド (マスク)
    ''' </summary>
    ''' <param name="fmt"></param>
    ''' <param name="mask"></param>
    ''' <returns></returns>
    Private Function maskString(ByVal fmt As String, ByVal mask As String) As String
        If (String.Compare(fmt, "%mask%") = 0) Then
            Return mask
        Else
            Return fmt
        End If
    End Function

    ''' <summary>
    ''' 記入・無記入 変換メソッド
    ''' </summary>
    ''' <param name="param"></param>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Private Function writeOrNothing(ByVal param As String, ByVal value As String) As String
        If (value.Length = 0) Then
            Return ""
        Else
            Return param & " = " & value
        End If
    End Function

    ''' <summary>
    ''' ユーザー、グループの対処
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Private Function validUser(ByVal user As String) As String
        Return user.Trim()
    End Function

    ''' <summary>
    ''' パーミッションの対処
    ''' </summary>
    ''' <param name="p"></param>
    ''' <returns></returns>
    Private Function validPermission(ByVal p As String) As String
        Dim pp = p.Trim()
        Dim pSize As Integer = pp.Length
        If (pSize = 3 Or pSize = 4) Then
            For i As Integer = pSize - 1 To 0 Step -1
                Dim c As Integer = Asc(pp.Chars(i))
                If (c < 48 Or c > 55) Then
                    Return ""   ' 数値がおかしい (0-7) の範囲でない
                End If
            Next i
            Return pp
        Else
            Return ""   ' 桁数が足りないエラー
        End If
    End Function

    ''' <summary>
    ''' DataGridView から取り込む (ただし 1 列目にあるとする)
    ''' </summary>
    ''' <param name="d"></param>
    ''' <returns></returns>
    Private Function importUser(ByVal d As DataGridView) As String()
        Dim s() As String
        With d
            ' 列数取得
            If (.Columns.Count < 1) Then
                Return Nothing  ' 列がないよ
            End If
            ' 行数取得
            Dim size As Integer = .Rows.Count
            If (size > 0) Then
                If (.Rows(size - 1).IsNewRow) Then
                    size -= 1
                End If
            End If
            If (size = 0) Then
                Return Nothing    ' データがないよ
            End If

            ' データ挿入
            s = New String(size - 1) {}
            For i As Integer = size - 1 To 0 Step -1
                If (.Rows(i).Cells(0).Value Is Nothing) Then
                    s(i) = ""
                Else
                    s(i) = .Rows(i).Cells(0).Value.ToString.Trim()
                End If
            Next i
        End With
        Return s
    End Function

    ''' <summary>
    ''' 文字列型配列から取り込む
    ''' </summary>
    ''' <param name="d"></param>
    ''' <returns></returns>
    Private Function importUser(ByVal d() As String) As String()
        Dim s() As String
        Dim size As Integer = d.Length
        If (size = 0) Then
            Return Nothing
        End If
        s = New String(size - 1) {}
        For i As Integer = size - 1 To 0 Step -1
            s(i) = d(i).Trim
        Next i
        Return s
    End Function

    ''' <summary>
    ''' ユーザーリストを作る
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Private Function createList(ByVal s() As String, ByVal user As String) As String
        If (s Is Nothing) Then
            Return ""
        End If
        Dim r As String = ""
        Dim size As Integer = s.Length
        For i As Integer = 0 To size - 1
            r &= fmtString(s(i), user) & " "
        Next i
        Return r.Substring(0, r.Length - 1)
    End Function

    ''' <summary>
    ''' ネットワークリストを得る
    ''' </summary>
    ''' <param name="d"></param>
    ''' <returns></returns>
    Private Function importNetwork(ByVal d As DataGridView) As String()
        Dim s() As String
        With d
            If (.Columns.Count < 2) Then
                Return Nothing  ' 列がないよ
            End If

            Dim rowSize As Integer = .Rows.Count
            If (rowSize > 0) Then
                If (.Rows(rowSize - 1).IsNewRow) Then
                    rowSize -= 1
                End If
            End If
            If (rowSize = 0) Then
                Return Nothing  ' 行がないよ
            End If

            ' データ作成
            s = New String(rowSize - 1) {}
            For i As Integer = rowSize - 1 To 0 Step -1
                If (.Rows(i).Cells(0).Value Is Nothing) Then
                    Continue For    ' 1 列目が空なら無視
                Else
                    If (.Rows(i).Cells(1).Value Is Nothing) Then
                        s(i) = .Rows(i).Cells(0).Value.ToString.Trim()
                    Else
                        s(i) = .Rows(i).Cells(0).Value.ToString.Trim() & "/" & .Rows(i).Cells(1).Value.ToString.Trim()
                    End If
                End If
            Next i
        End With
        Return s
    End Function

    ''' <summary>
    ''' ホストのリストを得る
    ''' </summary>
    ''' <param name="s"></param>
    ''' <returns></returns>
    Private Function createHostsList(ByVal s() As String) As String
        If (s Is Nothing) Then
            Return ""   ' データがないよ
        End If

        Dim r As String = ""
        Dim size As Integer = s.Length
        For i As Integer = 0 To size - 1
            If (s(i).Length > 0) Then
                r &= s(i) & " "
            End If
        Next i
        Return r.Substring(0, r.Length - 1)
    End Function
End Class
