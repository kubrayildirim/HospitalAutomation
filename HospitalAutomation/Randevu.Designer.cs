
namespace HospitalAutomation
{
	partial class Randevu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hOSPITALDataSet1 = new HospitalAutomation.HOSPITALDataSet1();
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hOSPITALDataSet = new HospitalAutomation.HOSPITALDataSet();
			this.departmentsTableAdapter = new HospitalAutomation.HOSPITALDataSetTableAdapters.DepartmentsTableAdapter();
			this.doctorsTableAdapter = new HospitalAutomation.HOSPITALDataSet1TableAdapters.DoctorsTableAdapter();
			this.button4 = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.SteelBlue;
			this.button3.Location = new System.Drawing.Point(288, 17);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(518, 34);
			this.button3.TabIndex = 41;
			this.button3.Text = "GETİR";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(288, 57);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(518, 257);
			this.dataGridView1.TabIndex = 38;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// doctorsBindingSource
			// 
			this.doctorsBindingSource.DataMember = "Doctors";
			this.doctorsBindingSource.DataSource = this.hOSPITALDataSet1;
			// 
			// hOSPITALDataSet1
			// 
			this.hOSPITALDataSet1.DataSetName = "HOSPITALDataSet1";
			this.hOSPITALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// departmentsBindingSource
			// 
			this.departmentsBindingSource.DataMember = "Departments";
			this.departmentsBindingSource.DataSource = this.hOSPITALDataSet;
			// 
			// hOSPITALDataSet
			// 
			this.hOSPITALDataSet.DataSetName = "HOSPITALDataSet";
			this.hOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// departmentsTableAdapter
			// 
			this.departmentsTableAdapter.ClearBeforeFill = true;
			// 
			// doctorsTableAdapter
			// 
			this.doctorsTableAdapter.ClearBeforeFill = true;
			// 
			// button4
			// 
			this.button4.ImageIndex = 3;
			this.button4.ImageList = this.ımageList1;
			this.button4.Location = new System.Drawing.Point(182, 24);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(38, 31);
			this.button4.TabIndex = 43;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "insert.png");
			this.ımageList1.Images.SetKeyName(1, "update.png");
			this.ımageList1.Images.SetKeyName(2, "delete.png");
			this.ımageList1.Images.SetKeyName(3, "search (2).png");
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(35, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 297);
			this.groupBox1.TabIndex = 46;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Yeni Randevu";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(98, 57);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(119, 20);
			this.textBox3.TabIndex = 59;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightBlue;
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.ımageList1;
			this.button2.Location = new System.Drawing.Point(170, 219);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 46);
			this.button2.TabIndex = 56;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 17);
			this.label6.TabIndex = 58;
			this.label6.Text = "HastaNo";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(99, 178);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(121, 20);
			this.textBox2.TabIndex = 57;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightBlue;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.ımageList1;
			this.button1.Location = new System.Drawing.Point(99, 219);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 46);
			this.button1.TabIndex = 55;
			this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(99, 147);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
			this.dateTimePicker1.TabIndex = 54;
			// 
			// comboBox2
			// 
			this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorsBindingSource, "DoctorLastname", true));
			this.comboBox2.DataSource = this.doctorsBindingSource;
			this.comboBox2.DisplayMember = "DoctorName";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(99, 112);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 53;
			this.comboBox2.ValueMember = "DoctorID";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.departmentsBindingSource;
			this.comboBox1.DisplayMember = "DepartmentName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(99, 83);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 52;
			this.comboBox1.ValueMember = "DepartmentName";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(99, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 20);
			this.textBox1.TabIndex = 51;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(2, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 17);
			this.label5.TabIndex = 50;
			this.label5.Text = "Randevu Saati";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(2, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 17);
			this.label4.TabIndex = 49;
			this.label4.Text = "Randevu Tarihi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(43, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 17);
			this.label3.TabIndex = 48;
			this.label3.Text = "Doktor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 47;
			this.label2.Text = "Poliklinik";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 17);
			this.label1.TabIndex = 46;
			this.label1.Text = "TC";
			// 
			// Randevu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 324);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Randevu";
			this.Text = "Randevu";
			this.Load += new System.EventHandler(this.Randevu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private HOSPITALDataSet hOSPITALDataSet;
		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private HOSPITALDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
		private HOSPITALDataSet1 hOSPITALDataSet1;
		private System.Windows.Forms.BindingSource doctorsBindingSource;
		private HOSPITALDataSet1TableAdapters.DoctorsTableAdapter doctorsTableAdapter;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList ımageList1;
	}
}