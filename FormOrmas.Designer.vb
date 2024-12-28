<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrmas
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
        Me.OrmasLKSDataSet = New Lks_IT.OrmasLKSDataSet()
        Me.OrmaslkskecamatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ormas_lks_kecamatanTableAdapter = New Lks_IT.OrmasLKSDataSetTableAdapters.ormas_lks_kecamatanTableAdapter()
        Me.OrmaslksuserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ormas_lks_userTableAdapter = New Lks_IT.OrmasLKSDataSetTableAdapters.ormas_lks_userTableAdapter()
        Me.dataGridOrmas = New System.Windows.Forms.DataGridView()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.cmbKecamatan = New System.Windows.Forms.ComboBox()
        Me.cmbKelurahan = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSuratPermohonan = New System.Windows.Forms.TextBox()
        Me.txtNoHPKetua = New System.Windows.Forms.TextBox()
        Me.txtNamaKetua = New System.Windows.Forms.TextBox()
        Me.txtNamaOrmas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddKecamatan = New System.Windows.Forms.Button()
        Me.btnAddKelurahan = New System.Windows.Forms.Button()
        Me.txtNamaKecamatan = New System.Windows.Forms.TextBox()
        Me.txtNamaKelurahan = New System.Windows.Forms.TextBox()
        CType(Me.OrmasLKSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrmaslkskecamatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrmaslksuserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridOrmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrmasLKSDataSet
        '
        Me.OrmasLKSDataSet.DataSetName = "OrmasLKSDataSet"
        Me.OrmasLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrmaslkskecamatanBindingSource
        '
        Me.OrmaslkskecamatanBindingSource.DataMember = "ormas_lks_kecamatan"
        Me.OrmaslkskecamatanBindingSource.DataSource = Me.OrmasLKSDataSet
        '
        'Ormas_lks_kecamatanTableAdapter
        '
        Me.Ormas_lks_kecamatanTableAdapter.ClearBeforeFill = True
        '
        'OrmaslksuserBindingSource
        '
        Me.OrmaslksuserBindingSource.DataMember = "ormas_lks_user"
        Me.OrmaslksuserBindingSource.DataSource = Me.OrmasLKSDataSet
        '
        'Ormas_lks_userTableAdapter
        '
        Me.Ormas_lks_userTableAdapter.ClearBeforeFill = True
        '
        'dataGridOrmas
        '
        Me.dataGridOrmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridOrmas.Location = New System.Drawing.Point(98, 309)
        Me.dataGridOrmas.Name = "dataGridOrmas"
        Me.dataGridOrmas.Size = New System.Drawing.Size(697, 237)
        Me.dataGridOrmas.TabIndex = 0
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(284, 180)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(382, 20)
        Me.txtAlamat.TabIndex = 1
        '
        'cmbKecamatan
        '
        Me.cmbKecamatan.FormattingEnabled = True
        Me.cmbKecamatan.Location = New System.Drawing.Point(284, 206)
        Me.cmbKecamatan.Name = "cmbKecamatan"
        Me.cmbKecamatan.Size = New System.Drawing.Size(121, 21)
        Me.cmbKecamatan.TabIndex = 2
        '
        'cmbKelurahan
        '
        Me.cmbKelurahan.FormattingEnabled = True
        Me.cmbKelurahan.Location = New System.Drawing.Point(284, 233)
        Me.cmbKelurahan.Name = "cmbKelurahan"
        Me.cmbKelurahan.Size = New System.Drawing.Size(121, 21)
        Me.cmbKelurahan.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(133, 280)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Tambah Data"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(302, 280)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit Data"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(458, 280)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Hapus Data"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(601, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Simpan Perubahan"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSuratPermohonan
        '
        Me.txtSuratPermohonan.Location = New System.Drawing.Point(284, 154)
        Me.txtSuratPermohonan.Name = "txtSuratPermohonan"
        Me.txtSuratPermohonan.Size = New System.Drawing.Size(382, 20)
        Me.txtSuratPermohonan.TabIndex = 1
        '
        'txtNoHPKetua
        '
        Me.txtNoHPKetua.Location = New System.Drawing.Point(284, 128)
        Me.txtNoHPKetua.Name = "txtNoHPKetua"
        Me.txtNoHPKetua.Size = New System.Drawing.Size(382, 20)
        Me.txtNoHPKetua.TabIndex = 1
        '
        'txtNamaKetua
        '
        Me.txtNamaKetua.Location = New System.Drawing.Point(284, 102)
        Me.txtNamaKetua.Name = "txtNamaKetua"
        Me.txtNamaKetua.Size = New System.Drawing.Size(382, 20)
        Me.txtNamaKetua.TabIndex = 1
        '
        'txtNamaOrmas
        '
        Me.txtNamaOrmas.Location = New System.Drawing.Point(284, 76)
        Me.txtNamaOrmas.Name = "txtNamaOrmas"
        Me.txtNamaOrmas.Size = New System.Drawing.Size(382, 20)
        Me.txtNamaOrmas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Ormas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Ketua"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nomor HP Ketua"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Surat Permohonan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat Kesekretariatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Kecamatan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Kelurahan"
        '
        'btnAddKecamatan
        '
        Me.btnAddKecamatan.Location = New System.Drawing.Point(570, 206)
        Me.btnAddKecamatan.Name = "btnAddKecamatan"
        Me.btnAddKecamatan.Size = New System.Drawing.Size(156, 23)
        Me.btnAddKecamatan.TabIndex = 3
        Me.btnAddKecamatan.Text = "Tambah Kecamatan"
        Me.btnAddKecamatan.UseVisualStyleBackColor = True
        '
        'btnAddKelurahan
        '
        Me.btnAddKelurahan.Location = New System.Drawing.Point(570, 235)
        Me.btnAddKelurahan.Name = "btnAddKelurahan"
        Me.btnAddKelurahan.Size = New System.Drawing.Size(156, 23)
        Me.btnAddKelurahan.TabIndex = 3
        Me.btnAddKelurahan.Text = "Tambah Kelurahan"
        Me.btnAddKelurahan.UseVisualStyleBackColor = True
        '
        'txtNamaKecamatan
        '
        Me.txtNamaKecamatan.Location = New System.Drawing.Point(426, 209)
        Me.txtNamaKecamatan.Name = "txtNamaKecamatan"
        Me.txtNamaKecamatan.Size = New System.Drawing.Size(119, 20)
        Me.txtNamaKecamatan.TabIndex = 1
        '
        'txtNamaKelurahan
        '
        Me.txtNamaKelurahan.Location = New System.Drawing.Point(426, 235)
        Me.txtNamaKelurahan.Name = "txtNamaKelurahan"
        Me.txtNamaKelurahan.Size = New System.Drawing.Size(119, 20)
        Me.txtNamaKelurahan.TabIndex = 1
        '
        'FormOrmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 558)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddKelurahan)
        Me.Controls.Add(Me.btnAddKecamatan)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbKelurahan)
        Me.Controls.Add(Me.cmbKecamatan)
        Me.Controls.Add(Me.txtNamaOrmas)
        Me.Controls.Add(Me.txtNamaKetua)
        Me.Controls.Add(Me.txtNoHPKetua)
        Me.Controls.Add(Me.txtSuratPermohonan)
        Me.Controls.Add(Me.txtNamaKelurahan)
        Me.Controls.Add(Me.txtNamaKecamatan)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.dataGridOrmas)
        Me.Name = "FormOrmas"
        Me.Text = "FormOrmas"
        CType(Me.OrmasLKSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrmaslkskecamatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrmaslksuserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridOrmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrmasLKSDataSet As OrmasLKSDataSet
    Friend WithEvents OrmaslkskecamatanBindingSource As BindingSource
    Friend WithEvents Ormas_lks_kecamatanTableAdapter As OrmasLKSDataSetTableAdapters.ormas_lks_kecamatanTableAdapter
    Friend WithEvents OrmaslksuserBindingSource As BindingSource
    Friend WithEvents Ormas_lks_userTableAdapter As OrmasLKSDataSetTableAdapters.ormas_lks_userTableAdapter
    Friend WithEvents dataGridOrmas As DataGridView
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cmbKecamatan As ComboBox
    Friend WithEvents cmbKelurahan As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSuratPermohonan As TextBox
    Friend WithEvents txtNoHPKetua As TextBox
    Friend WithEvents txtNamaKetua As TextBox
    Friend WithEvents txtNamaOrmas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddKecamatan As Button
    Friend WithEvents btnAddKelurahan As Button
    Friend WithEvents txtNamaKecamatan As TextBox
    Friend WithEvents txtNamaKelurahan As TextBox
End Class
