namespace Segnapunti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homenamebtn = new System.Windows.Forms.Button();
            this.homeadd = new System.Windows.Forms.Button();
            this.txt_homeid = new System.Windows.Forms.TextBox();
            this.txt_homeatleta = new System.Windows.Forms.TextBox();
            this.homegrid = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homenametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.guestadd = new System.Windows.Forms.Button();
            this.txt_guestid = new System.Windows.Forms.TextBox();
            this.txt_guestatleta = new System.Windows.Forms.TextBox();
            this.guestgrid = new System.Windows.Forms.DataGridView();
            this.guestnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestatleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homeptlabel = new System.Windows.Forms.Label();
            this.guestptlabel = new System.Windows.Forms.Label();
            this.homeaddpt = new System.Windows.Forms.Button();
            this.homeremovept = new System.Windows.Forms.Button();
            this.guestremovept = new System.Windows.Forms.Button();
            this.guestaddpt = new System.Windows.Forms.Button();
            this.homeremovec = new System.Windows.Forms.Button();
            this.homeaddc = new System.Windows.Forms.Button();
            this.homeremoveto = new System.Windows.Forms.Button();
            this.homeaddto = new System.Windows.Forms.Button();
            this.guestremoveto = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.guestremovec = new System.Windows.Forms.Button();
            this.guestaddc = new System.Windows.Forms.Button();
            this.homeclabel = new System.Windows.Forms.Label();
            this.hometolabel = new System.Windows.Forms.Label();
            this.guesttolabel = new System.Windows.Forms.Label();
            this.guestclabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.homesetvinti = new System.Windows.Forms.Label();
            this.guestsetvinti = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.homedot = new System.Windows.Forms.Button();
            this.guestdot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.VolleyScore_notif = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homegrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestgrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homenamebtn);
            this.panel1.Controls.Add(this.homeadd);
            this.panel1.Controls.Add(this.txt_homeid);
            this.panel1.Controls.Add(this.txt_homeatleta);
            this.panel1.Controls.Add(this.homegrid);
            this.panel1.Controls.Add(this.homenametxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 604);
            this.panel1.TabIndex = 0;
            // 
            // homenamebtn
            // 
            this.homenamebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homenamebtn.Location = new System.Drawing.Point(278, 6);
            this.homenamebtn.Name = "homenamebtn";
            this.homenamebtn.Size = new System.Drawing.Size(56, 23);
            this.homenamebtn.TabIndex = 6;
            this.homenamebtn.Text = "OK";
            this.homenamebtn.UseVisualStyleBackColor = true;
            this.homenamebtn.Click += new System.EventHandler(this.homenamebtn_Click);
            // 
            // homeadd
            // 
            this.homeadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeadd.Location = new System.Drawing.Point(278, 565);
            this.homeadd.Name = "homeadd";
            this.homeadd.Size = new System.Drawing.Size(56, 23);
            this.homeadd.TabIndex = 1;
            this.homeadd.Text = "OK";
            this.homeadd.UseVisualStyleBackColor = true;
            this.homeadd.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_homeid
            // 
            this.txt_homeid.Location = new System.Drawing.Point(8, 565);
            this.txt_homeid.Name = "txt_homeid";
            this.txt_homeid.Size = new System.Drawing.Size(27, 20);
            this.txt_homeid.TabIndex = 5;
            // 
            // txt_homeatleta
            // 
            this.txt_homeatleta.Location = new System.Drawing.Point(41, 565);
            this.txt_homeatleta.Name = "txt_homeatleta";
            this.txt_homeatleta.Size = new System.Drawing.Size(231, 20);
            this.txt_homeatleta.TabIndex = 4;
            // 
            // homegrid
            // 
            this.homegrid.AllowUserToAddRows = false;
            this.homegrid.AllowUserToDeleteRows = false;
            this.homegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.atleta});
            this.homegrid.Location = new System.Drawing.Point(0, 47);
            this.homegrid.Name = "homegrid";
            this.homegrid.ReadOnly = true;
            this.homegrid.Size = new System.Drawing.Size(337, 500);
            this.homegrid.TabIndex = 3;
            this.homegrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.homegrid_RowsAdded);
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // atleta
            // 
            this.atleta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.atleta.HeaderText = "atleta";
            this.atleta.Name = "atleta";
            this.atleta.ReadOnly = true;
            // 
            // homenametxt
            // 
            this.homenametxt.Location = new System.Drawing.Point(121, 6);
            this.homenametxt.Name = "homenametxt";
            this.homenametxt.Size = new System.Drawing.Size(151, 20);
            this.homenametxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Squadra Casa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.guestadd);
            this.panel2.Controls.Add(this.txt_guestid);
            this.panel2.Controls.Add(this.txt_guestatleta);
            this.panel2.Controls.Add(this.guestgrid);
            this.panel2.Controls.Add(this.guestnametxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(836, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 604);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(278, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // guestadd
            // 
            this.guestadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestadd.Location = new System.Drawing.Point(278, 565);
            this.guestadd.Name = "guestadd";
            this.guestadd.Size = new System.Drawing.Size(56, 23);
            this.guestadd.TabIndex = 1;
            this.guestadd.Text = "OK";
            this.guestadd.UseVisualStyleBackColor = true;
            this.guestadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_guestid
            // 
            this.txt_guestid.Location = new System.Drawing.Point(8, 565);
            this.txt_guestid.Name = "txt_guestid";
            this.txt_guestid.Size = new System.Drawing.Size(27, 20);
            this.txt_guestid.TabIndex = 5;
            // 
            // txt_guestatleta
            // 
            this.txt_guestatleta.Location = new System.Drawing.Point(41, 565);
            this.txt_guestatleta.Name = "txt_guestatleta";
            this.txt_guestatleta.Size = new System.Drawing.Size(231, 20);
            this.txt_guestatleta.TabIndex = 4;
            // 
            // guestgrid
            // 
            this.guestgrid.AllowUserToAddRows = false;
            this.guestgrid.AllowUserToDeleteRows = false;
            this.guestgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestnum,
            this.guestatleta});
            this.guestgrid.Location = new System.Drawing.Point(0, 47);
            this.guestgrid.Name = "guestgrid";
            this.guestgrid.ReadOnly = true;
            this.guestgrid.Size = new System.Drawing.Size(337, 500);
            this.guestgrid.TabIndex = 3;
            // 
            // guestnum
            // 
            this.guestnum.HeaderText = "num";
            this.guestnum.Name = "guestnum";
            this.guestnum.ReadOnly = true;
            // 
            // guestatleta
            // 
            this.guestatleta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guestatleta.HeaderText = "atleta";
            this.guestatleta.Name = "guestatleta";
            this.guestatleta.ReadOnly = true;
            // 
            // guestnametxt
            // 
            this.guestnametxt.Location = new System.Drawing.Point(121, 6);
            this.guestnametxt.Name = "guestnametxt";
            this.guestnametxt.Size = new System.Drawing.Size(151, 20);
            this.guestnametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Squadra Ospite";
            // 
            // homeptlabel
            // 
            this.homeptlabel.AutoSize = true;
            this.homeptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeptlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.homeptlabel.Location = new System.Drawing.Point(3, 204);
            this.homeptlabel.Name = "homeptlabel";
            this.homeptlabel.Size = new System.Drawing.Size(26, 29);
            this.homeptlabel.TabIndex = 2;
            this.homeptlabel.Text = "0";
            // 
            // guestptlabel
            // 
            this.guestptlabel.AutoSize = true;
            this.guestptlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestptlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guestptlabel.Location = new System.Drawing.Point(422, 204);
            this.guestptlabel.Name = "guestptlabel";
            this.guestptlabel.Size = new System.Drawing.Size(26, 29);
            this.guestptlabel.TabIndex = 3;
            this.guestptlabel.Text = "0";
            // 
            // homeaddpt
            // 
            this.homeaddpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.homeaddpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeaddpt.FlatAppearance.BorderSize = 0;
            this.homeaddpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeaddpt.Location = new System.Drawing.Point(98, 162);
            this.homeaddpt.Name = "homeaddpt";
            this.homeaddpt.Size = new System.Drawing.Size(75, 75);
            this.homeaddpt.TabIndex = 4;
            this.homeaddpt.Text = "Pt +1";
            this.homeaddpt.UseVisualStyleBackColor = false;
            this.homeaddpt.Click += new System.EventHandler(this.homeaddpt_Click);
            // 
            // homeremovept
            // 
            this.homeremovept.BackColor = System.Drawing.Color.Red;
            this.homeremovept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeremovept.FlatAppearance.BorderSize = 0;
            this.homeremovept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeremovept.Location = new System.Drawing.Point(47, 162);
            this.homeremovept.Name = "homeremovept";
            this.homeremovept.Size = new System.Drawing.Size(45, 75);
            this.homeremovept.TabIndex = 5;
            this.homeremovept.Text = "-1";
            this.homeremovept.UseVisualStyleBackColor = false;
            this.homeremovept.Click += new System.EventHandler(this.homeremovept_Click);
            // 
            // guestremovept
            // 
            this.guestremovept.BackColor = System.Drawing.Color.Red;
            this.guestremovept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestremovept.FlatAppearance.BorderSize = 0;
            this.guestremovept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestremovept.Location = new System.Drawing.Point(370, 162);
            this.guestremovept.Name = "guestremovept";
            this.guestremovept.Size = new System.Drawing.Size(45, 75);
            this.guestremovept.TabIndex = 7;
            this.guestremovept.Text = "-1";
            this.guestremovept.UseVisualStyleBackColor = false;
            this.guestremovept.Click += new System.EventHandler(this.guestremovept_Click);
            // 
            // guestaddpt
            // 
            this.guestaddpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guestaddpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestaddpt.FlatAppearance.BorderSize = 0;
            this.guestaddpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestaddpt.Location = new System.Drawing.Point(289, 162);
            this.guestaddpt.Name = "guestaddpt";
            this.guestaddpt.Size = new System.Drawing.Size(75, 75);
            this.guestaddpt.TabIndex = 6;
            this.guestaddpt.Text = "Pt +1";
            this.guestaddpt.UseVisualStyleBackColor = false;
            this.guestaddpt.Click += new System.EventHandler(this.guestaddpt_Click);
            // 
            // homeremovec
            // 
            this.homeremovec.BackColor = System.Drawing.Color.Red;
            this.homeremovec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeremovec.FlatAppearance.BorderSize = 0;
            this.homeremovec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeremovec.Location = new System.Drawing.Point(0, 81);
            this.homeremovec.Name = "homeremovec";
            this.homeremovec.Size = new System.Drawing.Size(45, 75);
            this.homeremovec.TabIndex = 9;
            this.homeremovec.Text = "-1";
            this.homeremovec.UseVisualStyleBackColor = false;
            this.homeremovec.Click += new System.EventHandler(this.homeremovec_Click);
            // 
            // homeaddc
            // 
            this.homeaddc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.homeaddc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeaddc.FlatAppearance.BorderSize = 0;
            this.homeaddc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeaddc.Location = new System.Drawing.Point(51, 81);
            this.homeaddc.Name = "homeaddc";
            this.homeaddc.Size = new System.Drawing.Size(75, 75);
            this.homeaddc.TabIndex = 8;
            this.homeaddc.Text = "C + 1";
            this.homeaddc.UseVisualStyleBackColor = false;
            this.homeaddc.Click += new System.EventHandler(this.homeaddc_Click);
            // 
            // homeremoveto
            // 
            this.homeremoveto.BackColor = System.Drawing.Color.Red;
            this.homeremoveto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeremoveto.FlatAppearance.BorderSize = 0;
            this.homeremoveto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeremoveto.Location = new System.Drawing.Point(0, 0);
            this.homeremoveto.Name = "homeremoveto";
            this.homeremoveto.Size = new System.Drawing.Size(45, 75);
            this.homeremoveto.TabIndex = 11;
            this.homeremoveto.Text = "-1";
            this.homeremoveto.UseVisualStyleBackColor = false;
            this.homeremoveto.Click += new System.EventHandler(this.homeremoveto_Click);
            // 
            // homeaddto
            // 
            this.homeaddto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.homeaddto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeaddto.FlatAppearance.BorderSize = 0;
            this.homeaddto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeaddto.Location = new System.Drawing.Point(51, 0);
            this.homeaddto.Name = "homeaddto";
            this.homeaddto.Size = new System.Drawing.Size(75, 75);
            this.homeaddto.TabIndex = 10;
            this.homeaddto.Text = "TO +1";
            this.homeaddto.UseVisualStyleBackColor = false;
            this.homeaddto.Click += new System.EventHandler(this.homeaddto_Click);
            // 
            // guestremoveto
            // 
            this.guestremoveto.BackColor = System.Drawing.Color.Red;
            this.guestremoveto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestremoveto.FlatAppearance.BorderSize = 0;
            this.guestremoveto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestremoveto.Location = new System.Drawing.Point(334, 0);
            this.guestremoveto.Name = "guestremoveto";
            this.guestremoveto.Size = new System.Drawing.Size(45, 75);
            this.guestremoveto.TabIndex = 15;
            this.guestremoveto.Text = "-1";
            this.guestremoveto.UseVisualStyleBackColor = false;
            this.guestremoveto.Click += new System.EventHandler(this.guestremoveto_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(385, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 75);
            this.button14.TabIndex = 14;
            this.button14.Text = "TO +1";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // guestremovec
            // 
            this.guestremovec.BackColor = System.Drawing.Color.Red;
            this.guestremovec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestremovec.FlatAppearance.BorderSize = 0;
            this.guestremovec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestremovec.Location = new System.Drawing.Point(334, 81);
            this.guestremovec.Name = "guestremovec";
            this.guestremovec.Size = new System.Drawing.Size(45, 75);
            this.guestremovec.TabIndex = 13;
            this.guestremovec.Text = "-1";
            this.guestremovec.UseVisualStyleBackColor = false;
            this.guestremovec.Click += new System.EventHandler(this.guestremovec_Click);
            // 
            // guestaddc
            // 
            this.guestaddc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guestaddc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestaddc.FlatAppearance.BorderSize = 0;
            this.guestaddc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestaddc.Location = new System.Drawing.Point(385, 81);
            this.guestaddc.Name = "guestaddc";
            this.guestaddc.Size = new System.Drawing.Size(75, 75);
            this.guestaddc.TabIndex = 12;
            this.guestaddc.Text = "C +1";
            this.guestaddc.UseVisualStyleBackColor = false;
            this.guestaddc.Click += new System.EventHandler(this.guestaddc_Click);
            // 
            // homeclabel
            // 
            this.homeclabel.AutoSize = true;
            this.homeclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeclabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.homeclabel.Location = new System.Drawing.Point(132, 123);
            this.homeclabel.Name = "homeclabel";
            this.homeclabel.Size = new System.Drawing.Size(31, 33);
            this.homeclabel.TabIndex = 16;
            this.homeclabel.Text = "0";
            // 
            // hometolabel
            // 
            this.hometolabel.AutoSize = true;
            this.hometolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hometolabel.Location = new System.Drawing.Point(132, 42);
            this.hometolabel.Name = "hometolabel";
            this.hometolabel.Size = new System.Drawing.Size(31, 33);
            this.hometolabel.TabIndex = 17;
            this.hometolabel.Text = "0";
            // 
            // guesttolabel
            // 
            this.guesttolabel.AutoSize = true;
            this.guesttolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guesttolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guesttolabel.Location = new System.Drawing.Point(283, 42);
            this.guesttolabel.Name = "guesttolabel";
            this.guesttolabel.Size = new System.Drawing.Size(31, 33);
            this.guesttolabel.TabIndex = 19;
            this.guesttolabel.Text = "0";
            // 
            // guestclabel
            // 
            this.guestclabel.AutoSize = true;
            this.guestclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestclabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guestclabel.Location = new System.Drawing.Point(283, 123);
            this.guestclabel.Name = "guestclabel";
            this.guestclabel.Size = new System.Drawing.Size(31, 33);
            this.guestclabel.TabIndex = 18;
            this.guestclabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Set Vinti: ";
            // 
            // homesetvinti
            // 
            this.homesetvinti.AutoSize = true;
            this.homesetvinti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homesetvinti.Location = new System.Drawing.Point(434, 16);
            this.homesetvinti.Name = "homesetvinti";
            this.homesetvinti.Size = new System.Drawing.Size(19, 20);
            this.homesetvinti.TabIndex = 21;
            this.homesetvinti.Text = "0";
            // 
            // guestsetvinti
            // 
            this.guestsetvinti.AutoSize = true;
            this.guestsetvinti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsetvinti.Location = new System.Drawing.Point(811, 16);
            this.guestsetvinti.Name = "guestsetvinti";
            this.guestsetvinti.Size = new System.Drawing.Size(19, 20);
            this.guestsetvinti.TabIndex = 23;
            this.guestsetvinti.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(726, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Set Vinti: ";
            // 
            // homedot
            // 
            this.homedot.BackColor = System.Drawing.Color.Black;
            this.homedot.FlatAppearance.BorderSize = 0;
            this.homedot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homedot.Location = new System.Drawing.Point(179, 211);
            this.homedot.Name = "homedot";
            this.homedot.Size = new System.Drawing.Size(25, 26);
            this.homedot.TabIndex = 24;
            this.homedot.UseVisualStyleBackColor = false;
            this.homedot.Click += new System.EventHandler(this.homedot_Click);
            // 
            // guestdot
            // 
            this.guestdot.BackColor = System.Drawing.Color.Black;
            this.guestdot.FlatAppearance.BorderSize = 0;
            this.guestdot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestdot.Location = new System.Drawing.Point(258, 211);
            this.guestdot.Name = "guestdot";
            this.guestdot.Size = new System.Drawing.Size(25, 26);
            this.guestdot.TabIndex = 25;
            this.guestdot.UseVisualStyleBackColor = false;
            this.guestdot.Click += new System.EventHandler(this.guestdot_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(476, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 78);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.homeremoveto);
            this.panel3.Controls.Add(this.homeptlabel);
            this.panel3.Controls.Add(this.guestdot);
            this.panel3.Controls.Add(this.guestptlabel);
            this.panel3.Controls.Add(this.homedot);
            this.panel3.Controls.Add(this.homeaddpt);
            this.panel3.Controls.Add(this.homeremovept);
            this.panel3.Controls.Add(this.guestaddpt);
            this.panel3.Controls.Add(this.guestremovept);
            this.panel3.Controls.Add(this.homeaddc);
            this.panel3.Controls.Add(this.guesttolabel);
            this.panel3.Controls.Add(this.homeremovec);
            this.panel3.Controls.Add(this.guestclabel);
            this.panel3.Controls.Add(this.homeaddto);
            this.panel3.Controls.Add(this.hometolabel);
            this.panel3.Controls.Add(this.guestaddc);
            this.panel3.Controls.Add(this.homeclabel);
            this.panel3.Controls.Add(this.guestremovec);
            this.panel3.Controls.Add(this.guestremoveto);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Location = new System.Drawing.Point(365, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 245);
            this.panel3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Console di Gestione";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // help
            // 
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(356, 584);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(35, 32);
            this.help.TabIndex = 29;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // VolleyScore_notif
            // 
            this.VolleyScore_notif.BalloonTipTitle = "VolleyScore";
            this.VolleyScore_notif.Icon = ((System.Drawing.Icon)(resources.GetObject("VolleyScore_notif.Icon")));
            this.VolleyScore_notif.Text = "VolleyScore";
            this.VolleyScore_notif.Visible = true;
            this.VolleyScore_notif.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VolleyScore_notif_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guestsetvinti);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.homesetvinti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VolleyScore by Alfonso Maria Marzano";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homegrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestgrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homenamebtn;
        private System.Windows.Forms.Button homeadd;
        private System.Windows.Forms.TextBox txt_homeid;
        private System.Windows.Forms.TextBox txt_homeatleta;
        private System.Windows.Forms.DataGridView homegrid;
        private System.Windows.Forms.TextBox homenametxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button guestadd;
        private System.Windows.Forms.TextBox txt_guestid;
        private System.Windows.Forms.TextBox txt_guestatleta;
        private System.Windows.Forms.DataGridView guestgrid;
        private System.Windows.Forms.TextBox guestnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label homeptlabel;
        private System.Windows.Forms.Label guestptlabel;
        private System.Windows.Forms.Button homeaddpt;
        private System.Windows.Forms.Button homeremovept;
        private System.Windows.Forms.Button guestremovept;
        private System.Windows.Forms.Button guestaddpt;
        private System.Windows.Forms.Button homeremovec;
        private System.Windows.Forms.Button homeaddc;
        private System.Windows.Forms.Button homeremoveto;
        private System.Windows.Forms.Button homeaddto;
        private System.Windows.Forms.Button guestremoveto;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button guestremovec;
        private System.Windows.Forms.Button guestaddc;
        private System.Windows.Forms.Label homeclabel;
        private System.Windows.Forms.Label hometolabel;
        private System.Windows.Forms.Label guesttolabel;
        private System.Windows.Forms.Label guestclabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label homesetvinti;
        private System.Windows.Forms.Label guestsetvinti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button homedot;
        private System.Windows.Forms.Button guestdot;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn atleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestatleta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.NotifyIcon VolleyScore_notif;
    }
}

