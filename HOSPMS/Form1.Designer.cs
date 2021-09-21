namespace HOSPMS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HMS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DocNameTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PassTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.HMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 89);
            this.panel1.TabIndex = 0;
            // 
            // HMS
            // 
            this.HMS.AutoSize = true;
            this.HMS.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HMS.ForeColor = System.Drawing.Color.White;
            this.HMS.Location = new System.Drawing.Point(85, 19);
            this.HMS.Name = "HMS";
            this.HMS.Size = new System.Drawing.Size(79, 40);
            this.HMS.TabIndex = 0;
            this.HMS.Text = "HMS";
            this.HMS.Click += new System.EventHandler(this.HMS_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocNameTb
            // 
            this.DocNameTb.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.DocNameTb.BorderColorIdle = System.Drawing.Color.Purple;
            this.DocNameTb.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.DocNameTb.BorderThickness = 3;
            this.DocNameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.DocNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocNameTb.ForeColor = System.Drawing.Color.Purple;
            this.DocNameTb.isPassword = false;
            this.DocNameTb.Location = new System.Drawing.Point(27, 127);
            this.DocNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.DocNameTb.MaxLength = 32767;
            this.DocNameTb.Name = "DocNameTb";
            this.DocNameTb.Size = new System.Drawing.Size(193, 35);
            this.DocNameTb.TabIndex = 2;
            this.DocNameTb.Text = "DocName";
            this.DocNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PassTb
            // 
            this.PassTb.BorderColorFocused = System.Drawing.Color.BlueViolet;
            this.PassTb.BorderColorIdle = System.Drawing.Color.Purple;
            this.PassTb.BorderColorMouseHover = System.Drawing.Color.BlueViolet;
            this.PassTb.BorderThickness = 3;
            this.PassTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassTb.ForeColor = System.Drawing.Color.Purple;
            this.PassTb.isPassword = true;
            this.PassTb.Location = new System.Drawing.Point(27, 189);
            this.PassTb.Margin = new System.Windows.Forms.Padding(4);
            this.PassTb.MaxLength = 32767;
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(193, 35);
            this.PassTb.TabIndex = 3;
            this.PassTb.Text = "DocPassword";
            this.PassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(108, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clear";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(236, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(271, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.DocNameTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HMS;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox DocNameTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox PassTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

