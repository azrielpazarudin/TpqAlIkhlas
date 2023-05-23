<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JadPel_admin
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
        Me.pilihMapelCB = New System.Windows.Forms.ComboBox()
        Me.MataPelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TpqAlikhlasDataSet7 = New WindowsApplication1.tpqAlikhlasDataSet7()
        Me.TpqAlikhlasDataSet2 = New WindowsApplication1.tpqAlikhlasDataSet2()
        Me.TpqAlikhlasDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pilihMapelTB = New System.Windows.Forms.Label()
        Me.MataPelajaranTableAdapter = New WindowsApplication1.tpqAlikhlasDataSet7TableAdapters.mataPelajaranTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeKelasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeJadpelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeMatpelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JadwalPelajaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TpqAlikhlasDataSet10 = New WindowsApplication1.tpqAlikhlasDataSet10()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.JadwalPelajaranTableAdapter = New WindowsApplication1.tpqAlikhlasDataSet10TableAdapters.jadwalPelajaranTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        CType(Me.MataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JadwalPelajaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpqAlikhlasDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pilihMapelCB
        '
        Me.pilihMapelCB.DataSource = Me.MataPelajaranBindingSource
        Me.pilihMapelCB.DisplayMember = "namaMatpel"
        Me.pilihMapelCB.Font = New System.Drawing.Font("Swis721 Blk BT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pilihMapelCB.FormattingEnabled = True
        Me.pilihMapelCB.Location = New System.Drawing.Point(364, 210)
        Me.pilihMapelCB.Name = "pilihMapelCB"
        Me.pilihMapelCB.Size = New System.Drawing.Size(0, 37)
        Me.pilihMapelCB.TabIndex = 54
        Me.pilihMapelCB.ValueMember = "namaMatpel"
        '
        'MataPelajaranBindingSource
        '
        Me.MataPelajaranBindingSource.DataMember = "mataPelajaran"
        Me.MataPelajaranBindingSource.DataSource = Me.TpqAlikhlasDataSet7
        '
        'TpqAlikhlasDataSet7
        '
        Me.TpqAlikhlasDataSet7.DataSetName = "tpqAlikhlasDataSet7"
        Me.TpqAlikhlasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TpqAlikhlasDataSet2
        '
        Me.TpqAlikhlasDataSet2.DataSetName = "tpqAlikhlasDataSet2"
        Me.TpqAlikhlasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TpqAlikhlasDataSet2BindingSource
        '
        Me.TpqAlikhlasDataSet2BindingSource.DataSource = Me.TpqAlikhlasDataSet2
        Me.TpqAlikhlasDataSet2BindingSource.Position = 0
        '
        'pilihMapelTB
        '
        Me.pilihMapelTB.AutoSize = True
        Me.pilihMapelTB.Font = New System.Drawing.Font("Swis721 Blk BT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pilihMapelTB.ForeColor = System.Drawing.Color.Black
        Me.pilihMapelTB.Location = New System.Drawing.Point(397, 139)
        Me.pilihMapelTB.Name = "pilihMapelTB"
        Me.pilihMapelTB.Size = New System.Drawing.Size(0, 35)
        Me.pilihMapelTB.TabIndex = 55
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeKelasDataGridViewTextBoxColumn, Me.KodeJadpelDataGridViewTextBoxColumn, Me.KodeMatpelDataGridViewTextBoxColumn, Me.NiyDataGridViewTextBoxColumn, Me.HariDataGridViewTextBoxColumn, Me.JamDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JadwalPelajaranBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(33, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(556, 317)
        Me.DataGridView1.TabIndex = 56
        '
        'KodeKelasDataGridViewTextBoxColumn
        '
        Me.KodeKelasDataGridViewTextBoxColumn.DataPropertyName = "kodeKelas"
        Me.KodeKelasDataGridViewTextBoxColumn.HeaderText = "kodeKelas"
        Me.KodeKelasDataGridViewTextBoxColumn.Name = "KodeKelasDataGridViewTextBoxColumn"
        '
        'KodeJadpelDataGridViewTextBoxColumn
        '
        Me.KodeJadpelDataGridViewTextBoxColumn.DataPropertyName = "kodeJadpel"
        Me.KodeJadpelDataGridViewTextBoxColumn.HeaderText = "kodeJadpel"
        Me.KodeJadpelDataGridViewTextBoxColumn.Name = "KodeJadpelDataGridViewTextBoxColumn"
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
        Me.JadwalPelajaranBindingSource.DataSource = Me.TpqAlikhlasDataSet10
        '
        'TpqAlikhlasDataSet10
        '
        Me.TpqAlikhlasDataSet10.DataSetName = "tpqAlikhlasDataSet10"
        Me.TpqAlikhlasDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(33, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 56)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pencarian Data"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.DarkGreen
        Me.Button6.Image = Global.WindowsApplication1.My.Resources.Resources.images__2__removebg_preview
        Me.Button6.Location = New System.Drawing.Point(161, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 43)
        Me.Button6.TabIndex = 13
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(230, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 25)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Jadwal Pelajaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 25)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "TPQ Al-Ikhlas"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(513, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 47)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'JadwalPelajaranTableAdapter
        '
        Me.JadwalPelajaranTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Swis721 Blk BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TPQ AL-IKHLAS v.1.0"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.DarkGreen
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(622, 48)
        Me.panelTop.TabIndex = 53
        '
        'JadPel_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(622, 521)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pilihMapelCB)
        Me.Controls.Add(Me.pilihMapelTB)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "JadPel_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JadPel_admin"
        CType(Me.MataPelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JadwalPelajaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpqAlikhlasDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pilihMapelCB As System.Windows.Forms.ComboBox
    Friend WithEvents MataPelajaranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TpqAlikhlasDataSet7 As WindowsApplication1.tpqAlikhlasDataSet7
    Friend WithEvents TpqAlikhlasDataSet2 As WindowsApplication1.tpqAlikhlasDataSet2
    Friend WithEvents TpqAlikhlasDataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pilihMapelTB As System.Windows.Forms.Label
    Friend WithEvents MataPelajaranTableAdapter As WindowsApplication1.tpqAlikhlasDataSet7TableAdapters.mataPelajaranTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TpqAlikhlasDataSet10 As WindowsApplication1.tpqAlikhlasDataSet10
    Friend WithEvents JadwalPelajaranBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JadwalPelajaranTableAdapter As WindowsApplication1.tpqAlikhlasDataSet10TableAdapters.jadwalPelajaranTableAdapter
    Friend WithEvents KodeKelasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeJadpelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeMatpelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NiyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HariDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelTop As System.Windows.Forms.Panel
End Class
