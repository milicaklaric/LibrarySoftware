namespace Forme
{
    partial class UCObnavljanjeClanarine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClan = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.rbIme = new System.Windows.Forms.RadioButton();
            this.rbPrezime = new System.Windows.Forms.RadioButton();
            this.rbClKarta = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvClanoviIzaberi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviIzaberi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odabir člana prema:";
            // 
            // txtClan
            // 
            this.txtClan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.txtClan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtClan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.txtClan.Location = new System.Drawing.Point(313, 60);
            this.txtClan.Name = "txtClan";
            this.txtClan.Size = new System.Drawing.Size(233, 20);
            this.txtClan.TabIndex = 9;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.FlatAppearance.BorderSize = 2;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.btnPretrazi.Location = new System.Drawing.Point(306, 113);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(110, 33);
            this.btnPretrazi.TabIndex = 10;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // rbIme
            // 
            this.rbIme.AutoSize = true;
            this.rbIme.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.rbIme.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.rbIme.Location = new System.Drawing.Point(39, 59);
            this.rbIme.Name = "rbIme";
            this.rbIme.Size = new System.Drawing.Size(72, 25);
            this.rbIme.TabIndex = 6;
            this.rbIme.TabStop = true;
            this.rbIme.Text = "Imenu";
            this.rbIme.UseVisualStyleBackColor = true;
            // 
            // rbPrezime
            // 
            this.rbPrezime.AutoSize = true;
            this.rbPrezime.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.rbPrezime.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.rbPrezime.Location = new System.Drawing.Point(39, 90);
            this.rbPrezime.Name = "rbPrezime";
            this.rbPrezime.Size = new System.Drawing.Size(102, 25);
            this.rbPrezime.TabIndex = 7;
            this.rbPrezime.TabStop = true;
            this.rbPrezime.Text = "Prezimenu";
            this.rbPrezime.UseVisualStyleBackColor = true;
            // 
            // rbClKarta
            // 
            this.rbClKarta.AutoSize = true;
            this.rbClKarta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.rbClKarta.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbClKarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.rbClKarta.Location = new System.Drawing.Point(39, 121);
            this.rbClKarta.Name = "rbClKarta";
            this.rbClKarta.Size = new System.Drawing.Size(159, 25);
            this.rbClKarta.TabIndex = 8;
            this.rbClKarta.TabStop = true;
            this.rbClKarta.Text = "Broju članske karte";
            this.rbClKarta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel1.Location = new System.Drawing.Point(306, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel2.Location = new System.Drawing.Point(306, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 2);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel3.Location = new System.Drawing.Point(552, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 23);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.panel4.Location = new System.Drawing.Point(306, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 23);
            this.panel4.TabIndex = 12;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.FlatAppearance.BorderSize = 2;
            this.btnIzaberi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzaberi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzaberi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.btnIzaberi.Location = new System.Drawing.Point(441, 113);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(112, 33);
            this.btnIzaberi.TabIndex = 11;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgvClanoviIzaberi
            // 
            this.dgvClanoviIzaberi.AllowUserToAddRows = false;
            this.dgvClanoviIzaberi.AllowUserToDeleteRows = false;
            this.dgvClanoviIzaberi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClanoviIzaberi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dgvClanoviIzaberi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClanoviIzaberi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClanoviIzaberi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClanoviIzaberi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClanoviIzaberi.EnableHeadersVisualStyles = false;
            this.dgvClanoviIzaberi.Location = new System.Drawing.Point(24, 175);
            this.dgvClanoviIzaberi.Name = "dgvClanoviIzaberi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClanoviIzaberi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClanoviIzaberi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClanoviIzaberi.Size = new System.Drawing.Size(529, 231);
            this.dgvClanoviIzaberi.TabIndex = 39;
            // 
            // UCObnavljanjeClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.dgvClanoviIzaberi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbClKarta);
            this.Controls.Add(this.rbPrezime);
            this.Controls.Add(this.rbIme);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtClan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.Name = "UCObnavljanjeClanarine";
            this.Size = new System.Drawing.Size(585, 430);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviIzaberi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClan;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.RadioButton rbIme;
        private System.Windows.Forms.RadioButton rbPrezime;
        private System.Windows.Forms.RadioButton rbClKarta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgvClanoviIzaberi;
    }
}
