<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsoleForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ethernetSettingGroupBox = New System.Windows.Forms.GroupBox()
        Me.loadSET_Button = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PortNo8TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PortNo7TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PortNo6TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PortNo5TextBox = New System.Windows.Forms.TextBox()
        Me.PortNo2TextBox = New System.Windows.Forms.TextBox()
        Me.PortNo4TextBox = New System.Windows.Forms.TextBox()
        Me.PortNo3TextBox = New System.Windows.Forms.TextBox()
        Me.PortNo1TextBox = New System.Windows.Forms.TextBox()
        Me.usePortAdderssTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.portBaseTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.portCountTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ipAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ipAddressLabel = New System.Windows.Forms.Label()
        Me.dataGroupBox = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.connectGroupBox = New System.Windows.Forms.GroupBox()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.openButton = New System.Windows.Forms.Button()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ethernetSettingGroupBox.SuspendLayout()
        Me.dataGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.connectGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ethernetSettingGroupBox
        '
        Me.ethernetSettingGroupBox.Controls.Add(Me.loadSET_Button)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label11)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo8TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label10)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label9)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label8)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo7TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label7)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label6)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label5)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo6TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label4)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo5TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo2TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo4TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo3TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.PortNo1TextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.usePortAdderssTextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label3)
        Me.ethernetSettingGroupBox.Controls.Add(Me.portBaseTextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label2)
        Me.ethernetSettingGroupBox.Controls.Add(Me.portCountTextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.Label1)
        Me.ethernetSettingGroupBox.Controls.Add(Me.ipAddressTextBox)
        Me.ethernetSettingGroupBox.Controls.Add(Me.ipAddressLabel)
        Me.ethernetSettingGroupBox.Location = New System.Drawing.Point(12, 43)
        Me.ethernetSettingGroupBox.Name = "ethernetSettingGroupBox"
        Me.ethernetSettingGroupBox.Size = New System.Drawing.Size(218, 383)
        Me.ethernetSettingGroupBox.TabIndex = 1
        Me.ethernetSettingGroupBox.TabStop = False
        Me.ethernetSettingGroupBox.Text = "Ethernet"
        '
        'loadSET_Button
        '
        Me.loadSET_Button.Location = New System.Drawing.Point(18, 333)
        Me.loadSET_Button.Name = "loadSET_Button"
        Me.loadSET_Button.Size = New System.Drawing.Size(75, 23)
        Me.loadSET_Button.TabIndex = 6
        Me.loadSET_Button.Text = "载入配置"
        Me.loadSET_Button.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 12)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "PortNo8"
        '
        'PortNo8TextBox
        '
        Me.PortNo8TextBox.Location = New System.Drawing.Point(72, 293)
        Me.PortNo8TextBox.Name = "PortNo8TextBox"
        Me.PortNo8TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo8TextBox.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 12)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "PortNo7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 12)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "PortNo6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 12)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "PortNo5"
        '
        'PortNo7TextBox
        '
        Me.PortNo7TextBox.Location = New System.Drawing.Point(72, 272)
        Me.PortNo7TextBox.Name = "PortNo7TextBox"
        Me.PortNo7TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo7TextBox.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "PortNo4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "PortNo3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "PortNo2"
        '
        'PortNo6TextBox
        '
        Me.PortNo6TextBox.Location = New System.Drawing.Point(72, 251)
        Me.PortNo6TextBox.Name = "PortNo6TextBox"
        Me.PortNo6TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo6TextBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PortNo1"
        '
        'PortNo5TextBox
        '
        Me.PortNo5TextBox.Location = New System.Drawing.Point(72, 230)
        Me.PortNo5TextBox.Name = "PortNo5TextBox"
        Me.PortNo5TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo5TextBox.TabIndex = 18
        '
        'PortNo2TextBox
        '
        Me.PortNo2TextBox.Location = New System.Drawing.Point(72, 161)
        Me.PortNo2TextBox.Name = "PortNo2TextBox"
        Me.PortNo2TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo2TextBox.TabIndex = 13
        '
        'PortNo4TextBox
        '
        Me.PortNo4TextBox.Location = New System.Drawing.Point(72, 203)
        Me.PortNo4TextBox.Name = "PortNo4TextBox"
        Me.PortNo4TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo4TextBox.TabIndex = 15
        '
        'PortNo3TextBox
        '
        Me.PortNo3TextBox.Location = New System.Drawing.Point(72, 182)
        Me.PortNo3TextBox.Name = "PortNo3TextBox"
        Me.PortNo3TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo3TextBox.TabIndex = 14
        '
        'PortNo1TextBox
        '
        Me.PortNo1TextBox.Location = New System.Drawing.Point(72, 140)
        Me.PortNo1TextBox.Name = "PortNo1TextBox"
        Me.PortNo1TextBox.Size = New System.Drawing.Size(48, 21)
        Me.PortNo1TextBox.TabIndex = 10
        '
        'usePortAdderssTextBox
        '
        Me.usePortAdderssTextBox.Location = New System.Drawing.Point(88, 98)
        Me.usePortAdderssTextBox.Name = "usePortAdderssTextBox"
        Me.usePortAdderssTextBox.Size = New System.Drawing.Size(92, 21)
        Me.usePortAdderssTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "UsePort" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adderss"
        '
        'portBaseTextBox
        '
        Me.portBaseTextBox.Location = New System.Drawing.Point(88, 77)
        Me.portBaseTextBox.Name = "portBaseTextBox"
        Me.portBaseTextBox.Size = New System.Drawing.Size(92, 21)
        Me.portBaseTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PortBase"
        '
        'portCountTextBox
        '
        Me.portCountTextBox.Location = New System.Drawing.Point(88, 56)
        Me.portCountTextBox.Name = "portCountTextBox"
        Me.portCountTextBox.Size = New System.Drawing.Size(92, 21)
        Me.portCountTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PortCount"
        '
        'ipAddressTextBox
        '
        Me.ipAddressTextBox.Location = New System.Drawing.Point(88, 13)
        Me.ipAddressTextBox.Name = "ipAddressTextBox"
        Me.ipAddressTextBox.Size = New System.Drawing.Size(92, 21)
        Me.ipAddressTextBox.TabIndex = 1
        '
        'ipAddressLabel
        '
        Me.ipAddressLabel.AutoSize = True
        Me.ipAddressLabel.Location = New System.Drawing.Point(16, 17)
        Me.ipAddressLabel.Name = "ipAddressLabel"
        Me.ipAddressLabel.Size = New System.Drawing.Size(65, 12)
        Me.ipAddressLabel.TabIndex = 0
        Me.ipAddressLabel.Text = "IP Address"
        '
        'dataGroupBox
        '
        Me.dataGroupBox.Controls.Add(Me.DataGridView1)
        Me.dataGroupBox.Enabled = False
        Me.dataGroupBox.Location = New System.Drawing.Point(265, 43)
        Me.dataGroupBox.Name = "dataGroupBox"
        Me.dataGroupBox.Size = New System.Drawing.Size(435, 518)
        Me.dataGroupBox.TabIndex = 4
        Me.dataGroupBox.TabStop = False
        Me.dataGroupBox.Text = "Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Address, Me.Add_Name, Me.Value})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(391, 468)
        Me.DataGridView1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "停止"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(105, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "保存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'connectGroupBox
        '
        Me.connectGroupBox.Controls.Add(Me.closeButton)
        Me.connectGroupBox.Controls.Add(Me.Button2)
        Me.connectGroupBox.Controls.Add(Me.openButton)
        Me.connectGroupBox.Controls.Add(Me.Button1)
        Me.connectGroupBox.Location = New System.Drawing.Point(12, 444)
        Me.connectGroupBox.Name = "connectGroupBox"
        Me.connectGroupBox.Size = New System.Drawing.Size(218, 117)
        Me.connectGroupBox.TabIndex = 5
        Me.connectGroupBox.TabStop = False
        Me.connectGroupBox.Text = "Connect"
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(22, 62)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(71, 36)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'openButton
        '
        Me.openButton.Location = New System.Drawing.Point(22, 20)
        Me.openButton.Name = "openButton"
        Me.openButton.Size = New System.Drawing.Size(71, 36)
        Me.openButton.TabIndex = 0
        Me.openButton.Text = "Open"
        Me.openButton.UseVisualStyleBackColor = True
        '
        'Address
        '
        Me.Address.HeaderText = "地址"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'Add_Name
        '
        Me.Add_Name.HeaderText = "名称"
        Me.Add_Name.Name = "Add_Name"
        Me.Add_Name.ReadOnly = True
        '
        'Value
        '
        Me.Value.HeaderText = "值"
        Me.Value.Name = "Value"
        Me.Value.ReadOnly = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ConsoleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 573)
        Me.Controls.Add(Me.connectGroupBox)
        Me.Controls.Add(Me.dataGroupBox)
        Me.Controls.Add(Me.ethernetSettingGroupBox)
        Me.Name = "ConsoleForm"
        Me.Text = "ConsoleForm"
        Me.ethernetSettingGroupBox.ResumeLayout(False)
        Me.ethernetSettingGroupBox.PerformLayout()
        Me.dataGroupBox.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.connectGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ethernetSettingGroupBox As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PortNo8TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PortNo7TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PortNo6TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PortNo5TextBox As TextBox
    Friend WithEvents PortNo2TextBox As TextBox
    Friend WithEvents PortNo4TextBox As TextBox
    Friend WithEvents PortNo3TextBox As TextBox
    Friend WithEvents PortNo1TextBox As TextBox
    Friend WithEvents usePortAdderssTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents portBaseTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents portCountTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ipAddressTextBox As TextBox
    Friend WithEvents ipAddressLabel As Label
    Friend WithEvents dataGroupBox As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents connectGroupBox As GroupBox
    Friend WithEvents closeButton As Button
    Friend WithEvents openButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents loadSET_Button As Button
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Add_Name As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
