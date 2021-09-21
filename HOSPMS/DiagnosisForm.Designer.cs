namespace HOSPMS
{
    partial class DiagnosisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.MedicineTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.DiagnosisTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HMS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SymtomsTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatientNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DiagId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.diagsummary = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MedicineLbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PatientnameLbl = new System.Windows.Forms.Label();
            this.DiagnosisDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(323, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "DIAGNOSIS LIST";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(171, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 32);
            this.button4.TabIndex = 39;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MedicineTb
            // 
            this.MedicineTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MedicineTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MedicineTb.BackColor = System.Drawing.SystemColors.Control;
            this.MedicineTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MedicineTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicineTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MedicineTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedicineTb.HintForeColor = System.Drawing.Color.Empty;
            this.MedicineTb.HintText = "";
            this.MedicineTb.isPassword = false;
            this.MedicineTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.MedicineTb.LineIdleColor = System.Drawing.Color.Purple;
            this.MedicineTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.MedicineTb.LineThickness = 3;
            this.MedicineTb.Location = new System.Drawing.Point(221, 204);
            this.MedicineTb.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineTb.MaxLength = 32767;
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(171, 33);
            this.MedicineTb.TabIndex = 38;
            this.MedicineTb.Text = "Medicines";
            this.MedicineTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Location = new System.Drawing.Point(13, 173);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(171, 23);
            this.PatientIdCb.TabIndex = 36;
            this.PatientIdCb.Text = "PatientId";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DiagnosisTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DiagnosisTb.BackColor = System.Drawing.SystemColors.Control;
            this.DiagnosisTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DiagnosisTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagnosisTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DiagnosisTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiagnosisTb.HintForeColor = System.Drawing.Color.Empty;
            this.DiagnosisTb.HintText = "";
            this.DiagnosisTb.isPassword = false;
            this.DiagnosisTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DiagnosisTb.LineIdleColor = System.Drawing.Color.Purple;
            this.DiagnosisTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DiagnosisTb.LineThickness = 3;
            this.DiagnosisTb.Location = new System.Drawing.Point(221, 163);
            this.DiagnosisTb.Margin = new System.Windows.Forms.Padding(4);
            this.DiagnosisTb.MaxLength = 32767;
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(171, 33);
            this.DiagnosisTb.TabIndex = 35;
            this.DiagnosisTb.Text = "Diagnosis";
            this.DiagnosisTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DiagnosisTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 111);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(735, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(277, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIAGNOSIS ";
            // 
            // HMS
            // 
            this.HMS.AutoSize = true;
            this.HMS.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HMS.ForeColor = System.Drawing.Color.White;
            this.HMS.Location = new System.Drawing.Point(180, 27);
            this.HMS.Name = "HMS";
            this.HMS.Size = new System.Drawing.Size(464, 40);
            this.HMS.TabIndex = 1;
            this.HMS.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIAGNOSIS SUMMARY";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(261, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 32);
            this.button3.TabIndex = 34;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(171, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 32);
            this.button2.TabIndex = 33;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(87, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SymtomsTb
            // 
            this.SymtomsTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SymtomsTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SymtomsTb.BackColor = System.Drawing.SystemColors.Control;
            this.SymtomsTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SymtomsTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SymtomsTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SymtomsTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SymtomsTb.HintForeColor = System.Drawing.Color.Empty;
            this.SymtomsTb.HintText = "";
            this.SymtomsTb.isPassword = false;
            this.SymtomsTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.SymtomsTb.LineIdleColor = System.Drawing.Color.Purple;
            this.SymtomsTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.SymtomsTb.LineThickness = 3;
            this.SymtomsTb.Location = new System.Drawing.Point(222, 122);
            this.SymtomsTb.Margin = new System.Windows.Forms.Padding(4);
            this.SymtomsTb.MaxLength = 32767;
            this.SymtomsTb.Name = "SymtomsTb";
            this.SymtomsTb.Size = new System.Drawing.Size(171, 33);
            this.SymtomsTb.TabIndex = 30;
            this.SymtomsTb.Text = "Symptoms";
            this.SymtomsTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatientNameTb
            // 
            this.PatientNameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PatientNameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PatientNameTb.BackColor = System.Drawing.SystemColors.Control;
            this.PatientNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PatientNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientNameTb.Enabled = false;
            this.PatientNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatientNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatientNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.PatientNameTb.HintText = "";
            this.PatientNameTb.isPassword = false;
            this.PatientNameTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatientNameTb.LineIdleColor = System.Drawing.Color.Purple;
            this.PatientNameTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatientNameTb.LineThickness = 3;
            this.PatientNameTb.Location = new System.Drawing.Point(12, 204);
            this.PatientNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.PatientNameTb.MaxLength = 32767;
            this.PatientNameTb.Name = "PatientNameTb";
            this.PatientNameTb.Size = new System.Drawing.Size(171, 33);
            this.PatientNameTb.TabIndex = 29;
            this.PatientNameTb.Text = "PatientName";
            this.PatientNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PatientNameTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // DiagId
            // 
            this.DiagId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DiagId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DiagId.BackColor = System.Drawing.SystemColors.Control;
            this.DiagId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DiagId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DiagId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiagId.HintForeColor = System.Drawing.Color.Empty;
            this.DiagId.HintText = "";
            this.DiagId.isPassword = false;
            this.DiagId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DiagId.LineIdleColor = System.Drawing.Color.Purple;
            this.DiagId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DiagId.LineThickness = 3;
            this.DiagId.Location = new System.Drawing.Point(13, 123);
            this.DiagId.Margin = new System.Windows.Forms.Padding(4);
            this.DiagId.MaxLength = 32767;
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(171, 33);
            this.DiagId.TabIndex = 27;
            this.DiagId.Text = "DiagnosisId";
            this.DiagId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DiagId.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // diagsummary
            // 
            this.diagsummary.Controls.Add(this.label10);
            this.diagsummary.Controls.Add(this.Diagnosislbl);
            this.diagsummary.Controls.Add(this.label8);
            this.diagsummary.Controls.Add(this.MedicineLbl);
            this.diagsummary.Controls.Add(this.Symptomslbl);
            this.diagsummary.Controls.Add(this.label5);
            this.diagsummary.Controls.Add(this.PatientnameLbl);
            this.diagsummary.Controls.Add(this.label1);
            this.diagsummary.Location = new System.Drawing.Point(414, 123);
            this.diagsummary.Name = "diagsummary";
            this.diagsummary.Size = new System.Drawing.Size(358, 271);
            this.diagsummary.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(108, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "ByMurimaTom";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.Enabled = false;
            this.Diagnosislbl.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosislbl.ForeColor = System.Drawing.Color.Black;
            this.Diagnosislbl.Location = new System.Drawing.Point(164, 65);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(83, 20);
            this.Diagnosislbl.TabIndex = 7;
            this.Diagnosislbl.Text = "Diagnosis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(59, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "HospitalManagementSystem";
            // 
            // MedicineLbl
            // 
            this.MedicineLbl.AutoSize = true;
            this.MedicineLbl.Enabled = false;
            this.MedicineLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineLbl.ForeColor = System.Drawing.Color.Black;
            this.MedicineLbl.Location = new System.Drawing.Point(164, 133);
            this.MedicineLbl.Name = "MedicineLbl";
            this.MedicineLbl.Size = new System.Drawing.Size(85, 20);
            this.MedicineLbl.TabIndex = 5;
            this.MedicineLbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.Enabled = false;
            this.Symptomslbl.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symptomslbl.ForeColor = System.Drawing.Color.Black;
            this.Symptomslbl.Location = new System.Drawing.Point(3, 133);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(87, 20);
            this.Symptomslbl.TabIndex = 4;
            this.Symptomslbl.Text = "Symptoms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(272, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PatientnameLbl
            // 
            this.PatientnameLbl.AutoSize = true;
            this.PatientnameLbl.Enabled = false;
            this.PatientnameLbl.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientnameLbl.ForeColor = System.Drawing.Color.Black;
            this.PatientnameLbl.Location = new System.Drawing.Point(3, 65);
            this.PatientnameLbl.Name = "PatientnameLbl";
            this.PatientnameLbl.Size = new System.Drawing.Size(106, 20);
            this.PatientnameLbl.TabIndex = 2;
            this.PatientnameLbl.Text = "PatientName";
            // 
            // DiagnosisDGV
            // 
            this.DiagnosisDGV.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DiagnosisDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DiagnosisDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisDGV.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DiagnosisDGV.ColumnHeadersHeight = 40;
            this.DiagnosisDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DiagnosisDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DiagnosisDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DiagnosisDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DiagnosisDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DiagnosisDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DiagnosisDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DiagnosisDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DiagnosisDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DiagnosisDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisDGV.CurrentTheme.Name = null;
            this.DiagnosisDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DiagnosisDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DiagnosisDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DiagnosisDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiagnosisDGV.EnableHeadersVisualStyles = false;
            this.DiagnosisDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DiagnosisDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DiagnosisDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.DiagnosisDGV.HeaderForeColor = System.Drawing.Color.White;
            this.DiagnosisDGV.Location = new System.Drawing.Point(12, 432);
            this.DiagnosisDGV.Name = "DiagnosisDGV";
            this.DiagnosisDGV.RowHeadersVisible = false;
            this.DiagnosisDGV.RowTemplate.Height = 40;
            this.DiagnosisDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiagnosisDGV.Size = new System.Drawing.Size(760, 200);
            this.DiagnosisDGV.TabIndex = 42;
            this.DiagnosisDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DiagnosisDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisDGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Purple;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(557, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 26);
            this.button5.TabIndex = 43;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 644);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DiagnosisDGV);
            this.Controls.Add(this.diagsummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SymtomsTb);
            this.Controls.Add(this.PatientNameTb);
            this.Controls.Add(this.DiagId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.diagsummary.ResumeLayout(false);
            this.diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedicineTb;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DiagnosisTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HMS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SymtomsTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatientNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DiagId;
        private System.Windows.Forms.Panel diagsummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MedicineLbl;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PatientnameLbl;
        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuDataGridView DiagnosisDGV;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label4;
    }
}