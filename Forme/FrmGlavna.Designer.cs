using Domen;

namespace Forme
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.pMenu = new System.Windows.Forms.Panel();
            this.pSide = new System.Windows.Forms.Panel();
            this.btnVracanjeKnjige = new System.Windows.Forms.Button();
            this.btnPozajmljivanjeKnjige = new System.Windows.Forms.Button();
            this.btnBrisanjeKnjige = new System.Windows.Forms.Button();
            this.btnUnosKnjige = new System.Windows.Forms.Button();
            this.btnBrisanjeClana = new System.Windows.Forms.Button();
            this.btnObnovaClanarine = new System.Windows.Forms.Button();
            this.btnUnosClana = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.lblOdabran = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pBorder = new System.Windows.Forms.Panel();
            this.ucVracanjeKnjige1 = new Forme.UCVracanjeKnjige();
            this.ucPozajmljivanjeKnjige1 = new Forme.UCPozajmljivanjeKnjige();
            this.ucBrisanjeKnjige1 = new Forme.UCBrisanjeKnjige();
            this.ucUnosKnjige1 = new Forme.UCUnosKnjige();
            this.ucObrisiClana1 = new Forme.UCObrisiClana();
            this.ucObnavljanjeClanarine1 = new Forme.UCObnavljanjeClanarine();
            this.ucUnosClana1 = new Forme.UCUnosClana();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.pMenu.Controls.Add(this.pSide);
            this.pMenu.Controls.Add(this.btnVracanjeKnjige);
            this.pMenu.Controls.Add(this.btnPozajmljivanjeKnjige);
            this.pMenu.Controls.Add(this.btnBrisanjeKnjige);
            this.pMenu.Controls.Add(this.btnUnosKnjige);
            this.pMenu.Controls.Add(this.btnBrisanjeClana);
            this.pMenu.Controls.Add(this.btnObnovaClanarine);
            this.pMenu.Controls.Add(this.btnUnosClana);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(214, 500);
            this.pMenu.TabIndex = 27;
            // 
            // pSide
            // 
            this.pSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.pSide.Location = new System.Drawing.Point(205, 122);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(10, 46);
            this.pSide.TabIndex = 28;
            // 
            // btnVracanjeKnjige
            // 
            this.btnVracanjeKnjige.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnVracanjeKnjige.FlatAppearance.BorderSize = 0;
            this.btnVracanjeKnjige.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.btnVracanjeKnjige.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(53)))), ((int)(((byte)(22)))));
            this.btnVracanjeKnjige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVracanjeKnjige.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVracanjeKnjige.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVracanjeKnjige.Image = ((System.Drawing.Image)(resources.GetObject("btnVracanjeKnjige.Image")));
            this.btnVracanjeKnjige.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVracanjeKnjige.Location = new System.Drawing.Point(0, 434);
            this.btnVracanjeKnjige.Name = "btnVracanjeKnjige";
            this.btnVracanjeKnjige.Size = new System.Drawing.Size(214, 46);
            this.btnVracanjeKnjige.TabIndex = 7;
            this.btnVracanjeKnjige.Text = "Vracanje knjige   ";
            this.btnVracanjeKnjige.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVracanjeKnjige.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVracanjeKnjige.UseVisualStyleBackColor = true;
            this.btnVracanjeKnjige.Click += new System.EventHandler(this.btnVracanjeKnjige_Click);
            // 
            // btnPozajmljivanjeKnjige
            // 
            this.btnPozajmljivanjeKnjige.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnPozajmljivanjeKnjige.FlatAppearance.BorderSize = 0;
            this.btnPozajmljivanjeKnjige.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.btnPozajmljivanjeKnjige.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(53)))), ((int)(((byte)(22)))));
            this.btnPozajmljivanjeKnjige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPozajmljivanjeKnjige.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPozajmljivanjeKnjige.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPozajmljivanjeKnjige.Image = ((System.Drawing.Image)(resources.GetObject("btnPozajmljivanjeKnjige.Image")));
            this.btnPozajmljivanjeKnjige.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPozajmljivanjeKnjige.Location = new System.Drawing.Point(0, 382);
            this.btnPozajmljivanjeKnjige.Name = "btnPozajmljivanjeKnjige";
            this.btnPozajmljivanjeKnjige.Size = new System.Drawing.Size(214, 46);
            this.btnPozajmljivanjeKnjige.TabIndex = 6;
            this.btnPozajmljivanjeKnjige.Text = "Pozajmljivanje knjige    ";
            this.btnPozajmljivanjeKnjige.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPozajmljivanjeKnjige.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPozajmljivanjeKnjige.UseVisualStyleBackColor = true;
            this.btnPozajmljivanjeKnjige.Click += new System.EventHandler(this.btnPozajmljivanjeKnjige_Click);
            // 
            // btnBrisanjeKnjige
            // 
            this.btnBrisanjeKnjige.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnBrisanjeKnjige.FlatAppearance.BorderSize = 0;
            this.btnBrisanjeKnjige.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.btnBrisanjeKnjige.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(53)))), ((int)(((byte)(22)))));
            this.btnBrisanjeKnjige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisanjeKnjige.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisanjeKnjige.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrisanjeKnjige.Image = ((System.Drawing.Image)(resources.GetObject("btnBrisanjeKnjige.Image")));
            this.btnBrisanjeKnjige.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrisanjeKnjige.Location = new System.Drawing.Point(0, 330);
            this.btnBrisanjeKnjige.Name = "btnBrisanjeKnjige";
            this.btnBrisanjeKnjige.Size = new System.Drawing.Size(214, 46);
            this.btnBrisanjeKnjige.TabIndex = 5;
            this.btnBrisanjeKnjige.Text = "Brisanje knjige   ";
            this.btnBrisanjeKnjige.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrisanjeKnjige.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrisanjeKnjige.UseVisualStyleBackColor = true;
            this.btnBrisanjeKnjige.Click += new System.EventHandler(this.btnBrisanjeKnjige_Click);
            // 
            // btnUnosKnjige
            // 
            this.btnUnosKnjige.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnUnosKnjige.FlatAppearance.BorderSize = 0;
            this.btnUnosKnjige.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.btnUnosKnjige.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(53)))), ((int)(((byte)(22)))));
            this.btnUnosKnjige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosKnjige.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnosKnjige.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUnosKnjige.Image = ((System.Drawing.Image)(resources.GetObject("btnUnosKnjige.Image")));
            this.btnUnosKnjige.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnosKnjige.Location = new System.Drawing.Point(0, 278);
            this.btnUnosKnjige.Name = "btnUnosKnjige";
            this.btnUnosKnjige.Size = new System.Drawing.Size(214, 46);
            this.btnUnosKnjige.TabIndex = 4;
            this.btnUnosKnjige.Text = " Unos knjige   ";
            this.btnUnosKnjige.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnosKnjige.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnosKnjige.UseVisualStyleBackColor = true;
            this.btnUnosKnjige.Click += new System.EventHandler(this.btnUnosKnjige_Click);
            // 
            // btnBrisanjeClana
            // 
            this.btnBrisanjeClana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnBrisanjeClana.FlatAppearance.BorderSize = 0;
            this.btnBrisanjeClana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.btnBrisanjeClana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(53)))), ((int)(((byte)(22)))));
            this.btnBrisanjeClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisanjeClana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisanjeClana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrisanjeClana.Image = ((System.Drawing.Image)(resources.GetObject("btnBrisanjeClana.Image")));
            this.btnBrisanjeClana.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrisanjeClana.Location = new System.Drawing.Point(0, 226);
            this.btnBrisanjeClana.Name = "btnBrisanjeClana";
            this.btnBrisanjeClana.Size = new System.Drawing.Size(214, 46);
            this.btnBrisanjeClana.TabIndex = 3;
            this.btnBrisanjeClana.Text = "Brisanje clana   ";
            this.btnBrisanjeClana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrisanjeClana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrisanjeClana.UseVisualStyleBackColor = true;
            this.btnBrisanjeClana.Click += new System.EventHandler(this.btnBrisanjeClana_Click);
            // 
            // btnObnovaClanarine
            // 
            this.btnObnovaClanarine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnObnovaClanarine.FlatAppearance.BorderSize = 0;
            this.btnObnovaClanarine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.btnObnovaClanarine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(53)))), ((int)(((byte)(22)))));
            this.btnObnovaClanarine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObnovaClanarine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObnovaClanarine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnObnovaClanarine.Image = ((System.Drawing.Image)(resources.GetObject("btnObnovaClanarine.Image")));
            this.btnObnovaClanarine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObnovaClanarine.Location = new System.Drawing.Point(0, 174);
            this.btnObnovaClanarine.Name = "btnObnovaClanarine";
            this.btnObnovaClanarine.Size = new System.Drawing.Size(214, 46);
            this.btnObnovaClanarine.TabIndex = 2;
            this.btnObnovaClanarine.Text = "Obnova clanarine   ";
            this.btnObnovaClanarine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObnovaClanarine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObnovaClanarine.UseVisualStyleBackColor = true;
            this.btnObnovaClanarine.Click += new System.EventHandler(this.btnObnovaClanarine_Click);
            // 
            // btnUnosClana
            // 
            this.btnUnosClana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(87)))), ((int)(((byte)(46)))));
            this.btnUnosClana.FlatAppearance.BorderSize = 0;
            this.btnUnosClana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(34)))), ((int)(((byte)(0)))));
            this.btnUnosClana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(53)))), ((int)(((byte)(22)))));
            this.btnUnosClana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosClana.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnosClana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUnosClana.Image = ((System.Drawing.Image)(resources.GetObject("btnUnosClana.Image")));
            this.btnUnosClana.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnosClana.Location = new System.Drawing.Point(0, 122);
            this.btnUnosClana.Name = "btnUnosClana";
            this.btnUnosClana.Size = new System.Drawing.Size(214, 46);
            this.btnUnosClana.TabIndex = 1;
            this.btnUnosClana.Text = "Unos clana   ";
            this.btnUnosClana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnosClana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnosClana.UseVisualStyleBackColor = true;
            this.btnUnosClana.Click += new System.EventHandler(this.btnUnosClana_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.lblZaposleni);
            this.pHeader.Controls.Add(this.lblOdabran);
            this.pHeader.Controls.Add(this.btnExit);
            this.pHeader.Controls.Add(this.btnMinimize);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(214, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(601, 58);
            this.pHeader.TabIndex = 28;
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.AutoSize = true;
            this.lblZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaposleni.ForeColor = System.Drawing.Color.White;
            this.lblZaposleni.Location = new System.Drawing.Point(8, 39);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(0, 16);
            this.lblZaposleni.TabIndex = 30;
            // 
            // lblOdabran
            // 
            this.lblOdabran.AutoSize = true;
            this.lblOdabran.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdabran.ForeColor = System.Drawing.Color.Coral;
            this.lblOdabran.Location = new System.Drawing.Point(6, 9);
            this.lblOdabran.Name = "lblOdabran";
            this.lblOdabran.Size = new System.Drawing.Size(0, 26);
            this.lblOdabran.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Location = new System.Drawing.Point(575, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 24);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimize.Location = new System.Drawing.Point(546, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 24);
            this.btnMinimize.TabIndex = 28;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pBorder
            // 
            this.pBorder.BackColor = System.Drawing.Color.White;
            this.pBorder.Controls.Add(this.ucVracanjeKnjige1);
            this.pBorder.Controls.Add(this.ucPozajmljivanjeKnjige1);
            this.pBorder.Controls.Add(this.ucBrisanjeKnjige1);
            this.pBorder.Controls.Add(this.ucUnosKnjige1);
            this.pBorder.Controls.Add(this.ucObrisiClana1);
            this.pBorder.Controls.Add(this.ucObnavljanjeClanarine1);
            this.pBorder.Controls.Add(this.ucUnosClana1);
            this.pBorder.Location = new System.Drawing.Point(220, 63);
            this.pBorder.Name = "pBorder";
            this.pBorder.Size = new System.Drawing.Size(587, 432);
            this.pBorder.TabIndex = 29;
            // 
            // ucVracanjeKnjige1
            // 
            this.ucVracanjeKnjige1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucVracanjeKnjige1.Location = new System.Drawing.Point(1, 1);
            this.ucVracanjeKnjige1.Name = "ucVracanjeKnjige1";
            this.ucVracanjeKnjige1.Size = new System.Drawing.Size(585, 430);
            this.ucVracanjeKnjige1.TabIndex = 6;
            // 
            // ucPozajmljivanjeKnjige1
            // 
            this.ucPozajmljivanjeKnjige1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucPozajmljivanjeKnjige1.Location = new System.Drawing.Point(1, 1);
            this.ucPozajmljivanjeKnjige1.Name = "ucPozajmljivanjeKnjige1";
            this.ucPozajmljivanjeKnjige1.Size = new System.Drawing.Size(585, 430);
            this.ucPozajmljivanjeKnjige1.TabIndex = 5;
            // 
            // ucBrisanjeKnjige1
            // 
            this.ucBrisanjeKnjige1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucBrisanjeKnjige1.Location = new System.Drawing.Point(1, 1);
            this.ucBrisanjeKnjige1.Name = "ucBrisanjeKnjige1";
            this.ucBrisanjeKnjige1.Size = new System.Drawing.Size(585, 430);
            this.ucBrisanjeKnjige1.TabIndex = 4;
            // 
            // ucUnosKnjige1
            // 
            this.ucUnosKnjige1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucUnosKnjige1.Location = new System.Drawing.Point(1, 1);
            this.ucUnosKnjige1.Name = "ucUnosKnjige1";
            this.ucUnosKnjige1.Size = new System.Drawing.Size(585, 430);
            this.ucUnosKnjige1.TabIndex = 3;
            // 
            // ucObrisiClana1
            // 
            this.ucObrisiClana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucObrisiClana1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucObrisiClana1.Location = new System.Drawing.Point(1, 1);
            this.ucObrisiClana1.Name = "ucObrisiClana1";
            this.ucObrisiClana1.Size = new System.Drawing.Size(585, 430);
            this.ucObrisiClana1.TabIndex = 2;
            // 
            // ucObnavljanjeClanarine1
            // 
            this.ucObnavljanjeClanarine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucObnavljanjeClanarine1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucObnavljanjeClanarine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucObnavljanjeClanarine1.Location = new System.Drawing.Point(1, 1);
            this.ucObnavljanjeClanarine1.Name = "ucObnavljanjeClanarine1";
            this.ucObnavljanjeClanarine1.Size = new System.Drawing.Size(585, 430);
            this.ucObnavljanjeClanarine1.TabIndex = 1;
            // 
            // ucUnosClana1
            // 
            this.ucUnosClana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ucUnosClana1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ucUnosClana1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(147)))));
            this.ucUnosClana1.Location = new System.Drawing.Point(1, 1);
            this.ucUnosClana1.Name = "ucUnosClana1";
            this.ucUnosClana1.Size = new System.Drawing.Size(585, 430);
            this.ucUnosClana1.TabIndex = 0;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(815, 500);
            this.Controls.Add(this.pBorder);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGlavna";
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        

        #endregion
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnUnosClana;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVracanjeKnjige;
        private System.Windows.Forms.Button btnPozajmljivanjeKnjige;
        private System.Windows.Forms.Button btnBrisanjeKnjige;
        private System.Windows.Forms.Button btnUnosKnjige;
        private System.Windows.Forms.Button btnBrisanjeClana;
        private System.Windows.Forms.Button btnObnovaClanarine;
        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblOdabran;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pBorder;
        private System.Windows.Forms.Label lblZaposleni;
        private UCVracanjeKnjige ucVracanjeKnjige1;
        private UCPozajmljivanjeKnjige ucPozajmljivanjeKnjige1;
        private UCBrisanjeKnjige ucBrisanjeKnjige1;
        private UCUnosKnjige ucUnosKnjige1;
        private UCObrisiClana ucObrisiClana1;
        private UCObnavljanjeClanarine ucObnavljanjeClanarine1;
        private UCUnosClana ucUnosClana1;
    }
}