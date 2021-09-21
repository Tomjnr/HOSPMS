namespace HOSPMS
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HMS = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PatPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatGender = new System.Windows.Forms.ComboBox();
            this.PatBlood = new System.Windows.Forms.ComboBox();
            this.MajorTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 111);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "PATIENT";
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(141, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 32);
            this.button3.TabIndex = 18;
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
            this.button2.Location = new System.Drawing.Point(64, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 32);
            this.button2.TabIndex = 17;
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
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatPhone
            // 
            this.PatPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PatPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PatPhone.BackColor = System.Drawing.SystemColors.Control;
            this.PatPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PatPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatPhone.HintForeColor = System.Drawing.Color.Empty;
            this.PatPhone.HintText = "";
            this.PatPhone.isPassword = false;
            this.PatPhone.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatPhone.LineIdleColor = System.Drawing.Color.Purple;
            this.PatPhone.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatPhone.LineThickness = 3;
            this.PatPhone.Location = new System.Drawing.Point(13, 272);
            this.PatPhone.Margin = new System.Windows.Forms.Padding(4);
            this.PatPhone.MaxLength = 32767;
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(171, 33);
            this.PatPhone.TabIndex = 14;
            this.PatPhone.Text = "PatientPhone";
            this.PatPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatAddress
            // 
            this.PatAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PatAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PatAddress.BackColor = System.Drawing.SystemColors.Control;
            this.PatAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PatAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatAddress.HintForeColor = System.Drawing.Color.Empty;
            this.PatAddress.HintText = "";
            this.PatAddress.isPassword = false;
            this.PatAddress.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatAddress.LineIdleColor = System.Drawing.Color.Purple;
            this.PatAddress.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatAddress.LineThickness = 3;
            this.PatAddress.Location = new System.Drawing.Point(13, 231);
            this.PatAddress.Margin = new System.Windows.Forms.Padding(4);
            this.PatAddress.MaxLength = 32767;
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(171, 33);
            this.PatAddress.TabIndex = 13;
            this.PatAddress.Text = "PatientAdress";
            this.PatAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatName
            // 
            this.PatName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PatName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PatName.BackColor = System.Drawing.SystemColors.Control;
            this.PatName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatName.HintForeColor = System.Drawing.Color.Empty;
            this.PatName.HintText = "";
            this.PatName.isPassword = false;
            this.PatName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatName.LineIdleColor = System.Drawing.Color.Purple;
            this.PatName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatName.LineThickness = 3;
            this.PatName.Location = new System.Drawing.Point(13, 190);
            this.PatName.Margin = new System.Windows.Forms.Padding(4);
            this.PatName.MaxLength = 32767;
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(171, 33);
            this.PatName.TabIndex = 12;
            this.PatName.Text = "PatientName";
            this.PatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatId
            // 
            this.PatId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PatId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PatId.BackColor = System.Drawing.SystemColors.Control;
            this.PatId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PatId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatId.HintForeColor = System.Drawing.Color.Empty;
            this.PatId.HintText = "";
            this.PatId.isPassword = false;
            this.PatId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatId.LineIdleColor = System.Drawing.Color.Purple;
            this.PatId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatId.LineThickness = 3;
            this.PatId.Location = new System.Drawing.Point(13, 149);
            this.PatId.Margin = new System.Windows.Forms.Padding(4);
            this.PatId.MaxLength = 32767;
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(171, 33);
            this.PatId.TabIndex = 11;
            this.PatId.Text = "PatientId";
            this.PatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatAge
            // 
            this.PatAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PatAge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PatAge.BackColor = System.Drawing.SystemColors.Control;
            this.PatAge.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PatAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatAge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatAge.HintForeColor = System.Drawing.Color.Empty;
            this.PatAge.HintText = "";
            this.PatAge.isPassword = false;
            this.PatAge.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatAge.LineIdleColor = System.Drawing.Color.Purple;
            this.PatAge.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatAge.LineThickness = 3;
            this.PatAge.Location = new System.Drawing.Point(13, 313);
            this.PatAge.Margin = new System.Windows.Forms.Padding(4);
            this.PatAge.MaxLength = 32767;
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(171, 33);
            this.PatAge.TabIndex = 20;
            this.PatAge.Text = "PatientAge";
            this.PatAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatGender
            // 
            this.PatGender.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatGender.FormattingEnabled = true;
            this.PatGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatGender.Location = new System.Drawing.Point(13, 353);
            this.PatGender.Name = "PatGender";
            this.PatGender.Size = new System.Drawing.Size(171, 23);
            this.PatGender.TabIndex = 21;
            this.PatGender.Text = "Gender";
            this.PatGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PatBlood
            // 
            this.PatBlood.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatBlood.FormattingEnabled = true;
            this.PatBlood.Items.AddRange(new object[] {
            "O-",
            "A+",
            "B+",
            "AB+",
            "AB-",
            "B-",
            "A-",
            "O-"});
            this.PatBlood.Location = new System.Drawing.Point(13, 382);
            this.PatBlood.Name = "PatBlood";
            this.PatBlood.Size = new System.Drawing.Size(171, 23);
            this.PatBlood.TabIndex = 22;
            this.PatBlood.Text = "BloodGroup";
            // 
            // MajorTb
            // 
            this.MajorTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MajorTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MajorTb.BackColor = System.Drawing.SystemColors.Control;
            this.MajorTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MajorTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MajorTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MajorTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MajorTb.HintForeColor = System.Drawing.Color.Empty;
            this.MajorTb.HintText = "";
            this.MajorTb.isPassword = false;
            this.MajorTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.MajorTb.LineIdleColor = System.Drawing.Color.Purple;
            this.MajorTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.MajorTb.LineThickness = 3;
            this.MajorTb.Location = new System.Drawing.Point(13, 412);
            this.MajorTb.Margin = new System.Windows.Forms.Padding(4);
            this.MajorTb.MaxLength = 32767;
            this.MajorTb.Name = "MajorTb";
            this.MajorTb.Size = new System.Drawing.Size(171, 33);
            this.MajorTb.TabIndex = 23;
            this.MajorTb.Text = "MajorDisease";
            this.MajorTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(67, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 32);
            this.button4.TabIndex = 24;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(414, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "PATIENTS LIST";
            // 
            // PatientDGV
            // 
            this.PatientDGV.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.PatientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PatientDGV.ColumnHeadersHeight = 40;
            this.PatientDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.PatientDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.PatientDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PatientDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PatientDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.PatientDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.PatientDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.PatientDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.PatientDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.PatientDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientDGV.CurrentTheme.Name = null;
            this.PatientDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.PatientDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.PatientDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.PatientDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.PatientDGV.EnableHeadersVisualStyles = false;
            this.PatientDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.PatientDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.PatientDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.PatientDGV.HeaderForeColor = System.Drawing.Color.White;
            this.PatientDGV.Location = new System.Drawing.Point(212, 190);
            this.PatientDGV.Name = "PatientDGV";
            this.PatientDGV.RowHeadersVisible = false;
            this.PatientDGV.RowTemplate.Height = 40;
            this.PatientDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientDGV.Size = new System.Drawing.Size(560, 305);
            this.PatientDGV.TabIndex = 26;
            this.PatientDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.PatientDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientDGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(749, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 546);
            this.Controls.Add(this.PatientDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MajorTb);
            this.Controls.Add(this.PatBlood);
            this.Controls.Add(this.PatGender);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HMS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatAge;
        private System.Windows.Forms.ComboBox PatGender;
        private System.Windows.Forms.ComboBox PatBlood;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MajorTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDataGridView PatientDGV;
        private System.Windows.Forms.Label label4;
    }
}