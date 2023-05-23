<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jadpel_Santri
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
        Me.components = New System.ComponentModel.Container()
        Me.MataPelajaranTableAdapter = New WindowsApplication1.tpqAlikhlasDataSet7TableAdapters.mataPelajaranTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeMatpelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JadwalPelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TpqAlikhlasDataSet11 = New WindowsApplication1.tpqAlikhlasDataSet11()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pilihMapelTB = New System.Windows.Forms.Label()
        Me.TpqAlikhlasDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TpqAlikhlasDataSet2 = New WindowsApplication1.tpqAlikhlasDataSet2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TpqAlikhlasDataSet7 = New WindowsApplication1.tpqAlikhlasDataSet7()
        Me.MataPelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pilihMapelCB = New System.Windows.Forms.ComboBox()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MinimizeBtn = New System.Windows.Forms.Button()
        Me.MaximizeBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.JadwalPelajaranTableAdapter = New WindowsApplication1.tpqAlikhlasDataSet11TableAdapters.jadwalPelajaranTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JadwalPelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MataPelajaranTableAdapter
        '
        Me.MataPelajaranTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeMatpelDataGridViewTextBoxColumn, Me.NiyDataGridViewTextBoxColumn, Me.HariDataGridViewTextBoxColumn, Me.JamDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JadwalPelajaranBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(47, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(521, 345)
        Me.DataGridView1.TabIndex = 65
        '
        'KodeMatpelDataGridViewTextBoxColumn
        '
        Me.KodeMatpelDataGridViewTextBoxColumn.DataPropertyName = "kodeMatpel"
        Me.KodeMatpelDataGridViewTextBoxColumn.HeaderText = "kodeMatpel"
        Me.KodeMatpelDataGridViewTextBoxColumn.Name = "KodeMatpelDataGridViewTextBoxColumn"
        '
        'NiyDataGridViewTextBoxColumn
        '
        Me.NiyDataGridViewTextBoxColumn.DataPropertyName = "niy"
        Me.NiyDataGridViewTextBoxColumn.HeaderText = "niy"
        Me.NiyDataGridViewTextBoxColumn.Name = "NiyDataGridViewTextBoxColumn"
        '
        'HariDataGridViewTextBoxColumn
        '
        Me.HariDataGridViewTextBoxColumn.DataPropertyName = "hari"
        Me.HariDataGridViewTextBoxColumn.HeaderText = "hari"
        Me.HariDataGridViewTextBoxColumn.Name = "HariDataGridViewTextBoxColumn"
        '
        'JamDataGridViewTextBoxColumn
        '
        Me.JamDataGridViewTextBoxColumn.DataPropertyName = "jam"
        Me.JamDataGridViewTextBoxColumn.HeaderText = "jam"
        Me.JamDataGridViewTextBoxColumn.Name = "JamDataGridViewTextBoxColumn"
        '
        'JadwalPelajaranBindingSource
        '
        Me.JadwalPelajaranBindingSource.DataMember = "jadwalPelajaran"
        Me.JadwalPelajaranBindingSource.DataSource = Me.TpqAlikhlasDataSet11
        '
        'TpqAlikhlasDataSet11
        '
        Me.TpqAlikhlasDataSet11.DataSetName = "tpqAlikhlasDataSet11"
        Me.TpqAlikhlasDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(275, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 47)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, -38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 25)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Jadwal Pelajaran"
        '
        'pilihMapelTB
        '
        Me.pilihMapelTB.AutoSize = True
        Me.pilihMapelTB.Font = New System.Drawing.Font("Swis721 Blk BT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pilihMapelTB.ForeColor = System.Drawing.Color.Black
        Me.pilihMapelTB.Location = New System.Drawing.Point(102, 50)
        Me.pilihMapelTB.Name = "pilihMapelTB"
        Me.pilihMapelTB.Size = New System.Drawing.Size(0, 35)
        Me.pilihMapelTB.TabIndex = 64
        '
        'TpqAlikhlasDataSet2BindingSource
        '
        Me.TpqAlikhlasDataSet2BindingSource.DataSource = Me.TpqAlikhlasDataSet2
        Me.TpqAlikhlasDataSet2BindingSource.Position = 0
        '
        'TpqAlikhlasDataSet2
        '
        Me.TpqAlikhlasDataSet2.DataSetName = "tpqAlikhlasDataSet2"
        Me.TpqAlikhlasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(209, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 25)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Jadwal Pelajaran"
        '
        'TpqAlikhlasDataSet7
        '
        Me.TpqAlikhlasDataSet7.DataSetName = "tpqAlikhlasDataSet7"
        Me.TpqAlikhlasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MataPelajaranBindingSource
        '
        Me.MataPelajaranBindingSource.DataMember = "mataPelajaran"
        Me.MataPelajaranBindingSource.DataSource = Me.TpqAlikhlasDataSet7
        '
        'pilihMapelCB
        '
        Me.pilihMapelCB.DataSource = Me.MataPelajaranBindingSource
        Me.pilihMapelCB.DisplayMember = "namaMatpel"
        Me.pilihMapelCB.Font = New System.Drawing.Font("Swis721 Blk BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pilihMapelCB.FormattingEnabled = True
        Me.pilihMapelCB.Location = New System.Drawing.Point(69, 121)
        Me.pilihMapelCB.Name = "pilihMapelCB"
        Me.pilihMapelCB.Size = New System.Drawing.Size(0, 37)
        Me.pilihMapelCB.TabIndex = 63
        Me.pilihMapelCB.ValueMember = "namaMatpel"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.DarkGreen
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Controls.Add(Me.Panel4)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(622, 48)
        Me.panelTop.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TPQ AL-IKHLAS v.1.0"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MinimizeBtn)
        Me.Panel4.Controls.Add(Me.MaximizeBtn)
        Me.Panel4.Controls.Add(Me.CloseBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(517, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(105, 48)
        Me.Panel4.TabIndex = 0
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.BackColor = System.Drawing.Color.Yellow
        Me.MinimizeBtn.FlatAppearance.BorderSize = 0
        Me.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeBtn.Location = New System.Drawing.Point(14, 12)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(18, 18)
        Me.MinimizeBtn.TabIndex = 1
        Me.MinimizeBtn.UseVisualStyleBackColor = False
        '
        'MaximizeBtn
        '
        Me.MaximizeBtn.BackColor = System.Drawing.Color.Lime
        Me.MaximizeBtn.FlatAppearance.BorderSize = 0
        Me.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeBtn.Location = New System.Drawing.Point(44, 12)
        Me.MaximizeBtn.Name = "MaximizeBtn"
        Me.MaximizeBtn.Size = New System.Drawing.Size(18, 18)
        Me.MaximizeBtn.TabIndex = 2
        Me.MaximizeBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CloseBtn.Location = New System.Drawing.Point(75, 12)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(18, 18)
        Me.CloseBtn.TabIndex = 0
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'JadwalPelajaranTableAdapter
        '
        Me.JadwalPelajaranTableAdapter.ClearBeforeFill = True
        '
        'Jadpel_Santri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(622, 521)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pilihMapelTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pilihMapelCB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Jadpel_Santri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jadpel_Santri"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JadwalPelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MataPelajaranTableAdapter As WindowsApplication1.tpqAlikhlasDataSet7TableAdapters.mataPelajaranTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pilihMapelTB As System.Windows.Forms.Label
    Friend WithEvents TpqAlikhlasDataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TpqAlikhlasDataSet2 As WindowsApplication1.tpqAlikhlasDataSet2
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TpqAlikhlasDataSet7 As WindowsApplication1.tpqAlikhlasDataSet7
    Friend WithEvents MataPelajaranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pilihMapelCB As System.Windows.Forms.ComboBox
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MinimizeBtn As System.Windows.Forms.Button
    Friend WithEvents MaximizeBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents TpqAlikhlasDataSet11 As WindowsApplication1.tpqAlikhlasDataSet11
    Friend WithEvents JadwalPelajaranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JadwalPelajaranTableAdapter As WindowsApplication1.tpqAlikhlasDataSet11TableAdapters.jadwalPelajaranTableAdapter
    Friend WithEvents KodeMatpelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NiyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
