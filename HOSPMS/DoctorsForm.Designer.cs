namespace HOSPMS
{
    partial class DoctorsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HMS = new System.Windows.Forms.Label();
            this.DocId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocExp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DoctorDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDGV)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOCTOR";
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
            // DocId
            // 
            this.DocId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DocId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DocId.BackColor = System.Drawing.SystemColors.Control;
            this.DocId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DocId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocId.HintForeColor = System.Drawing.Color.Empty;
            this.DocId.HintText = "";
            this.DocId.isPassword = false;
            this.DocId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocId.LineIdleColor = System.Drawing.Color.Purple;
            this.DocId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocId.LineThickness = 3;
            this.DocId.Location = new System.Drawing.Point(13, 180);
            this.DocId.Margin = new System.Windows.Forms.Padding(4);
            this.DocId.MaxLength = 32767;
            this.DocId.Name = "DocId";
            this.DocId.Size = new System.Drawing.Size(171, 33);
            this.DocId.TabIndex = 1;
            this.DocId.Text = "DoctorId";
            this.DocId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DocName
            // 
            this.DocName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DocName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DocName.BackColor = System.Drawing.SystemColors.Control;
            this.DocName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DocName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocName.HintForeColor = System.Drawing.Color.Empty;
            this.DocName.HintText = "";
            this.DocName.isPassword = false;
            this.DocName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocName.LineIdleColor = System.Drawing.Color.Purple;
            this.DocName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocName.LineThickness = 3;
            this.DocName.Location = new System.Drawing.Point(13, 221);
            this.DocName.Margin = new System.Windows.Forms.Padding(4);
            this.DocName.MaxLength = 32767;
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(171, 33);
            this.DocName.TabIndex = 2;
            this.DocName.Text = "DoctorName";
            this.DocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DocExp
            // 
            this.DocExp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DocExp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DocExp.BackColor = System.Drawing.SystemColors.Control;
            this.DocExp.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DocExp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocExp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocExp.HintForeColor = System.Drawing.Color.Empty;
            this.DocExp.HintText = "";
            this.DocExp.isPassword = false;
            this.DocExp.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocExp.LineIdleColor = System.Drawing.Color.Purple;
            this.DocExp.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocExp.LineThickness = 3;
            this.DocExp.Location = new System.Drawing.Point(13, 262);
            this.DocExp.Margin = new System.Windows.Forms.Padding(4);
            this.DocExp.MaxLength = 32767;
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(171, 33);
            this.DocExp.TabIndex = 3;
            this.DocExp.Text = "DoctorYearofexperience";
            this.DocExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DocPass
            // 
            this.DocPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.DocPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.DocPass.BackColor = System.Drawing.SystemColors.Control;
            this.DocPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DocPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocPass.HintForeColor = System.Drawing.Color.Empty;
            this.DocPass.HintText = "";
            this.DocPass.isPassword = false;
            this.DocPass.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocPass.LineIdleColor = System.Drawing.Color.Purple;
            this.DocPass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocPass.LineThickness = 3;
            this.DocPass.Location = new System.Drawing.Point(13, 303);
            this.DocPass.Margin = new System.Windows.Forms.Padding(4);
            this.DocPass.MaxLength = 32767;
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(171, 33);
            this.DocPass.TabIndex = 4;
            this.DocPass.Text = "Password";
            this.DocPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DocPass.OnValueChanged += new System.EventHandler(this.DocPass_OnValueChanged);
            // 
            // DoctorDGV
            // 
            this.DoctorDGV.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DoctorDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorDGV.BackgroundColor = System.Drawing.Color.White;
            this.DoctorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorDGV.ColumnHeadersHeight = 40;
            this.DoctorDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DoctorDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DoctorDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DoctorDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DoctorDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DoctorDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DoctorDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DoctorDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DoctorDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DoctorDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorDGV.CurrentTheme.Name = null;
            this.DoctorDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DoctorDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DoctorDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DoctorDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DoctorDGV.EnableHeadersVisualStyles = false;
            this.DoctorDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DoctorDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DoctorDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.DoctorDGV.HeaderForeColor = System.Drawing.Color.White;
            this.DoctorDGV.Location = new System.Drawing.Point(282, 180);
            this.DoctorDGV.Name = "DoctorDGV";
            this.DoctorDGV.RowHeadersVisible = false;
            this.DoctorDGV.RowTemplate.Height = 40;
            this.DoctorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorDGV.Size = new System.Drawing.Size(477, 305);
            this.DoctorDGV.TabIndex = 5;
            this.DoctorDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DoctorDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorDGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(96, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(186, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(96, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 546);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorDGV);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.DocId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsForm";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HMS;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocExp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocPass;
        private Bunifu.UI.WinForms.BunifuDataGridView DoctorDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
    }
}