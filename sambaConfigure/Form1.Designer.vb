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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.userNames = New System.Windows.Forms.DataGridView()
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lineBreak = New System.Windows.Forms.ComboBox()
        Me.guestOK = New System.Windows.Forms.ComboBox()
        Me.writable = New System.Windows.Forms.ComboBox()
        Me.browsable = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comment = New System.Windows.Forms.TextBox()
        Me.path = New System.Windows.Forms.TextBox()
        Me.share = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.inheritParents = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.forceGroup = New System.Windows.Forms.TextBox()
        Me.forceUser = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.forceDirectoryMask = New System.Windows.Forms.TextBox()
        Me.directoryMask = New System.Windows.Forms.TextBox()
        Me.forceCreateMask = New System.Windows.Forms.TextBox()
        Me.createMask = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.readList = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.writeList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.validUsers = New System.Windows.Forms.DataGridView()
        Me.userName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.hostsDeny = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hostsAllow = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.userNames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.readList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.writeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.hostsDeny, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hostsAllow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userNames
        '
        Me.userNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userNames.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user})
        Me.userNames.Location = New System.Drawing.Point(12, 12)
        Me.userNames.Name = "userNames"
        Me.userNames.RowTemplate.Height = 21
        Me.userNames.Size = New System.Drawing.Size(171, 252)
        Me.userNames.TabIndex = 0
        '
        'user
        '
        Me.user.HeaderText = "ユーザー名"
        Me.user.Name = "user"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(189, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(551, 252)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.lineBreak)
        Me.TabPage1.Controls.Add(Me.guestOK)
        Me.TabPage1.Controls.Add(Me.writable)
        Me.TabPage1.Controls.Add(Me.browsable)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.comment)
        Me.TabPage1.Controls.Add(Me.path)
        Me.TabPage1.Controls.Add(Me.share)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(543, 226)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "基本"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(331, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(196, 24)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "キーワード ""%u%"" で現在のユーザー名に" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "置換します。"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 12)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "改行コード"
        '
        'lineBreak
        '
        Me.lineBreak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lineBreak.FormattingEnabled = True
        Me.lineBreak.Items.AddRange(New Object() {"Windows", "Unix & Linux", "Mac (9 以前)"})
        Me.lineBreak.Location = New System.Drawing.Point(100, 6)
        Me.lineBreak.Name = "lineBreak"
        Me.lineBreak.Size = New System.Drawing.Size(100, 20)
        Me.lineBreak.TabIndex = 1
        '
        'guestOK
        '
        Me.guestOK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.guestOK.FormattingEnabled = True
        Me.guestOK.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.guestOK.Location = New System.Drawing.Point(100, 176)
        Me.guestOK.Name = "guestOK"
        Me.guestOK.Size = New System.Drawing.Size(100, 20)
        Me.guestOK.TabIndex = 13
        '
        'writable
        '
        Me.writable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.writable.FormattingEnabled = True
        Me.writable.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.writable.Location = New System.Drawing.Point(100, 150)
        Me.writable.Name = "writable"
        Me.writable.Size = New System.Drawing.Size(100, 20)
        Me.writable.TabIndex = 11
        '
        'browsable
        '
        Me.browsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.browsable.FormattingEnabled = True
        Me.browsable.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.browsable.Location = New System.Drawing.Point(100, 124)
        Me.browsable.Name = "browsable"
        Me.browsable.Size = New System.Drawing.Size(100, 20)
        Me.browsable.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "guest ok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "書き込み可能"
        '
        'comment
        '
        Me.comment.Location = New System.Drawing.Point(100, 89)
        Me.comment.Name = "comment"
        Me.comment.Size = New System.Drawing.Size(215, 19)
        Me.comment.TabIndex = 7
        Me.comment.Text = "%u% 's directory"
        '
        'path
        '
        Me.path.Location = New System.Drawing.Point(100, 64)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(215, 19)
        Me.path.TabIndex = 5
        Me.path.Text = "/var/samba/%u%"
        '
        'share
        '
        Me.share.Location = New System.Drawing.Point(100, 39)
        Me.share.Name = "share"
        Me.share.Size = New System.Drawing.Size(215, 19)
        Me.share.TabIndex = 3
        Me.share.Text = "%u%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "説明文"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "共有フォルダ公開"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "共有フォルダパス"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "共有フォルダ名"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.inheritParents)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.forceGroup)
        Me.TabPage2.Controls.Add(Me.forceUser)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.forceDirectoryMask)
        Me.TabPage2.Controls.Add(Me.directoryMask)
        Me.TabPage2.Controls.Add(Me.forceCreateMask)
        Me.TabPage2.Controls.Add(Me.createMask)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(543, 226)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "パーミッション"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'inheritParents
        '
        Me.inheritParents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inheritParents.FormattingEnabled = True
        Me.inheritParents.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.inheritParents.Location = New System.Drawing.Point(109, 192)
        Me.inheritParents.Name = "inheritParents"
        Me.inheritParents.Size = New System.Drawing.Size(98, 20)
        Me.inheritParents.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 195)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 12)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Inherit Parents"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(249, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(242, 48)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "force create mask と force directory mask は" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "キーワード ""%mask%"" が使用できます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "これは、それぞれ cre" &
    "ate mask と directroy mask" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "と同一の値を設定するという意味です。"
        '
        'forceGroup
        '
        Me.forceGroup.Location = New System.Drawing.Point(107, 158)
        Me.forceGroup.Name = "forceGroup"
        Me.forceGroup.Size = New System.Drawing.Size(100, 19)
        Me.forceGroup.TabIndex = 11
        '
        'forceUser
        '
        Me.forceUser.Location = New System.Drawing.Point(107, 133)
        Me.forceUser.Name = "forceUser"
        Me.forceUser.Size = New System.Drawing.Size(100, 19)
        Me.forceUser.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 12)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "force group"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 12)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "force user"
        '
        'forceDirectoryMask
        '
        Me.forceDirectoryMask.Location = New System.Drawing.Point(123, 96)
        Me.forceDirectoryMask.Name = "forceDirectoryMask"
        Me.forceDirectoryMask.Size = New System.Drawing.Size(100, 19)
        Me.forceDirectoryMask.TabIndex = 7
        Me.forceDirectoryMask.Text = "%mask%"
        '
        'directoryMask
        '
        Me.directoryMask.Location = New System.Drawing.Point(123, 71)
        Me.directoryMask.Name = "directoryMask"
        Me.directoryMask.Size = New System.Drawing.Size(100, 19)
        Me.directoryMask.TabIndex = 5
        '
        'forceCreateMask
        '
        Me.forceCreateMask.Location = New System.Drawing.Point(107, 35)
        Me.forceCreateMask.Name = "forceCreateMask"
        Me.forceCreateMask.Size = New System.Drawing.Size(100, 19)
        Me.forceCreateMask.TabIndex = 3
        Me.forceCreateMask.Text = "%mask%"
        '
        'createMask
        '
        Me.createMask.Location = New System.Drawing.Point(107, 10)
        Me.createMask.Name = "createMask"
        Me.createMask.Size = New System.Drawing.Size(100, 19)
        Me.createMask.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 12)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "force directory mode"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 12)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "directory mode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "force create mode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "create mode"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.readList)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.writeList)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.validUsers)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(543, 226)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ユーザー・グループ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'readList
        '
        Me.readList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.readList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2})
        Me.readList.Location = New System.Drawing.Point(364, 18)
        Me.readList.Name = "readList"
        Me.readList.RowTemplate.Height = 21
        Me.readList.Size = New System.Drawing.Size(172, 200)
        Me.readList.TabIndex = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "ユーザー名"
        Me.Column2.Name = "Column2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(362, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 12)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "read list"
        '
        'writeList
        '
        Me.writeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.writeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.writeList.Location = New System.Drawing.Point(186, 18)
        Me.writeList.Name = "writeList"
        Me.writeList.RowTemplate.Height = 21
        Me.writeList.Size = New System.Drawing.Size(172, 200)
        Me.writeList.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "ユーザー名"
        Me.Column1.Name = "Column1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(184, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 12)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "write list"
        '
        'validUsers
        '
        Me.validUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.validUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userName})
        Me.validUsers.Location = New System.Drawing.Point(8, 18)
        Me.validUsers.Name = "validUsers"
        Me.validUsers.RowTemplate.Height = 21
        Me.validUsers.Size = New System.Drawing.Size(172, 200)
        Me.validUsers.TabIndex = 1
        '
        'userName
        '
        Me.userName.HeaderText = "ユーザー名"
        Me.userName.Name = "userName"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 12)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "valid users"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.hostsDeny)
        Me.TabPage4.Controls.Add(Me.hostsAllow)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(543, 226)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ネットワーク"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'hostsDeny
        '
        Me.hostsDeny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hostsDeny.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6})
        Me.hostsDeny.Location = New System.Drawing.Point(280, 18)
        Me.hostsDeny.Name = "hostsDeny"
        Me.hostsDeny.RowTemplate.Height = 21
        Me.hostsDeny.Size = New System.Drawing.Size(257, 202)
        Me.hostsDeny.TabIndex = 3
        '
        'Column5
        '
        Me.Column5.HeaderText = "host"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "subnet"
        Me.Column6.Name = "Column6"
        '
        'hostsAllow
        '
        Me.hostsAllow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hostsAllow.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4})
        Me.hostsAllow.Location = New System.Drawing.Point(6, 18)
        Me.hostsAllow.Name = "hostsAllow"
        Me.hostsAllow.RowTemplate.Height = 21
        Me.hostsAllow.Size = New System.Drawing.Size(257, 202)
        Me.hostsAllow.TabIndex = 1
        '
        'Column3
        '
        Me.Column3.HeaderText = "host"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "subnet"
        Me.Column4.Name = "Column4"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(278, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 12)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "hosts deny"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 12)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "hosts allow"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Location = New System.Drawing.Point(12, 270)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(551, 135)
        Me.TextBox4.TabIndex = 2
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(583, 270)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 34)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "gen"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(583, 338)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 41)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "*.txt|*.txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 417)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.userNames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Samba Configure"
        CType(Me.userNames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.readList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.writeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.hostsDeny, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hostsAllow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userNames As System.Windows.Forms.DataGridView
    Friend WithEvents user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents guestOK As System.Windows.Forms.ComboBox
    Friend WithEvents writable As System.Windows.Forms.ComboBox
    Friend WithEvents browsable As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents comment As System.Windows.Forms.TextBox
    Friend WithEvents path As System.Windows.Forms.TextBox
    Friend WithEvents share As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents forceDirectoryMask As System.Windows.Forms.TextBox
    Friend WithEvents directoryMask As System.Windows.Forms.TextBox
    Friend WithEvents forceCreateMask As System.Windows.Forms.TextBox
    Friend WithEvents createMask As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lineBreak As System.Windows.Forms.ComboBox
    Friend WithEvents readList As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents writeList As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents validUsers As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents forceGroup As System.Windows.Forms.TextBox
    Friend WithEvents forceUser As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents hostsDeny As System.Windows.Forms.DataGridView
    Friend WithEvents hostsAllow As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents inheritParents As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label

End Class
