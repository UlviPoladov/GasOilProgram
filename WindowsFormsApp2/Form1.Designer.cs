namespace WindowsFormsApp2
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
            this.totalPriceGrp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buyBtr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fantapricelbl = new System.Windows.Forms.Label();
            this.spritepricelbl = new System.Windows.Forms.Label();
            this.redbullpricelbl = new System.Windows.Forms.Label();
            this.snickerspricelbl = new System.Windows.Forms.Label();
            this.coffepricelbl = new System.Windows.Forms.Label();
            this.fantaupdown = new System.Windows.Forms.NumericUpDown();
            this.spriteupdown = new System.Windows.Forms.NumericUpDown();
            this.redbullupdown = new System.Windows.Forms.NumericUpDown();
            this.snickersupdown = new System.Windows.Forms.NumericUpDown();
            this.CoffeUpDown = new System.Windows.Forms.NumericUpDown();
            this.fantaBox = new System.Windows.Forms.CheckBox();
            this.spriteBox = new System.Windows.Forms.CheckBox();
            this.redbullBox = new System.Windows.Forms.CheckBox();
            this.snickersBox = new System.Windows.Forms.CheckBox();
            this.CoffeeBox = new System.Windows.Forms.CheckBox();
            this.kafeTotal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autogroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.oilpricelabel = new System.Windows.Forms.Label();
            this.litrmaskedbox = new System.Windows.Forms.MaskedTextBox();
            this.pricemaskedbox = new System.Windows.Forms.MaskedTextBox();
            this.oillbl = new System.Windows.Forms.Label();
            this.fuellbl = new System.Windows.Forms.Label();
            this.fuelSelectBox = new System.Windows.Forms.ComboBox();
            this.benzinTotal = new System.Windows.Forms.GroupBox();
            this.benzinTotalLb = new System.Windows.Forms.Label();
            this.borderlbl = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceGrp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fantaupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbullupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snickersupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeUpDown)).BeginInit();
            this.kafeTotal.SuspendLayout();
            this.autogroupbox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.benzinTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // totalPriceGrp
            // 
            this.totalPriceGrp.Controls.Add(this.pictureBox4);
            this.totalPriceGrp.Controls.Add(this.label3);
            this.totalPriceGrp.Controls.Add(this.buyBtr);
            this.totalPriceGrp.Location = new System.Drawing.Point(2, 360);
            this.totalPriceGrp.Name = "totalPriceGrp";
            this.totalPriceGrp.Size = new System.Drawing.Size(424, 100);
            this.totalPriceGrp.TabIndex = 5;
            this.totalPriceGrp.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "0.00";
            // 
            // buyBtr
            // 
            this.buyBtr.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtr.Location = new System.Drawing.Point(281, 22);
            this.buyBtr.Name = "buyBtr";
            this.buyBtr.Size = new System.Drawing.Size(101, 54);
            this.buyBtr.TabIndex = 0;
            this.buyBtr.Text = "Buy ";
            this.buyBtr.UseVisualStyleBackColor = true;
            this.buyBtr.Click += new System.EventHandler(this.buyBtr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fantapricelbl);
            this.groupBox1.Controls.Add(this.spritepricelbl);
            this.groupBox1.Controls.Add(this.redbullpricelbl);
            this.groupBox1.Controls.Add(this.snickerspricelbl);
            this.groupBox1.Controls.Add(this.coffepricelbl);
            this.groupBox1.Controls.Add(this.fantaupdown);
            this.groupBox1.Controls.Add(this.spriteupdown);
            this.groupBox1.Controls.Add(this.redbullupdown);
            this.groupBox1.Controls.Add(this.snickersupdown);
            this.groupBox1.Controls.Add(this.CoffeUpDown);
            this.groupBox1.Controls.Add(this.fantaBox);
            this.groupBox1.Controls.Add(this.spriteBox);
            this.groupBox1.Controls.Add(this.redbullBox);
            this.groupBox1.Controls.Add(this.snickersBox);
            this.groupBox1.Controls.Add(this.CoffeeBox);
            this.groupBox1.Controls.Add(this.kafeTotal);
            this.groupBox1.Location = new System.Drawing.Point(217, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 299);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // fantapricelbl
            // 
            this.fantapricelbl.AutoSize = true;
            this.fantapricelbl.Location = new System.Drawing.Point(110, 166);
            this.fantapricelbl.Name = "fantapricelbl";
            this.fantapricelbl.Size = new System.Drawing.Size(28, 13);
            this.fantapricelbl.TabIndex = 16;
            this.fantapricelbl.Text = "1.20";
            // 
            // spritepricelbl
            // 
            this.spritepricelbl.AutoSize = true;
            this.spritepricelbl.Location = new System.Drawing.Point(110, 135);
            this.spritepricelbl.Name = "spritepricelbl";
            this.spritepricelbl.Size = new System.Drawing.Size(22, 13);
            this.spritepricelbl.TabIndex = 15;
            this.spritepricelbl.Text = "1.0";
            // 
            // redbullpricelbl
            // 
            this.redbullpricelbl.AutoSize = true;
            this.redbullpricelbl.Location = new System.Drawing.Point(110, 98);
            this.redbullpricelbl.Name = "redbullpricelbl";
            this.redbullpricelbl.Size = new System.Drawing.Size(28, 13);
            this.redbullpricelbl.TabIndex = 14;
            this.redbullpricelbl.Text = "3.80";
            // 
            // snickerspricelbl
            // 
            this.snickerspricelbl.AutoSize = true;
            this.snickerspricelbl.Location = new System.Drawing.Point(110, 61);
            this.snickerspricelbl.Name = "snickerspricelbl";
            this.snickerspricelbl.Size = new System.Drawing.Size(28, 13);
            this.snickerspricelbl.TabIndex = 13;
            this.snickerspricelbl.Text = "1.50";
            // 
            // coffepricelbl
            // 
            this.coffepricelbl.AutoSize = true;
            this.coffepricelbl.Location = new System.Drawing.Point(110, 25);
            this.coffepricelbl.Name = "coffepricelbl";
            this.coffepricelbl.Size = new System.Drawing.Size(28, 13);
            this.coffepricelbl.TabIndex = 12;
            this.coffepricelbl.Text = "2.50";
            // 
            // fantaupdown
            // 
            this.fantaupdown.Location = new System.Drawing.Point(163, 163);
            this.fantaupdown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.fantaupdown.Name = "fantaupdown";
            this.fantaupdown.Size = new System.Drawing.Size(40, 20);
            this.fantaupdown.TabIndex = 11;
            this.fantaupdown.ValueChanged += new System.EventHandler(this.fantaupdown_ValueChanged);
            // 
            // spriteupdown
            // 
            this.spriteupdown.Location = new System.Drawing.Point(163, 127);
            this.spriteupdown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spriteupdown.Name = "spriteupdown";
            this.spriteupdown.Size = new System.Drawing.Size(40, 20);
            this.spriteupdown.TabIndex = 10;
            this.spriteupdown.ValueChanged += new System.EventHandler(this.spriteupdown_ValueChanged);
            // 
            // redbullupdown
            // 
            this.redbullupdown.Location = new System.Drawing.Point(163, 91);
            this.redbullupdown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.redbullupdown.Name = "redbullupdown";
            this.redbullupdown.Size = new System.Drawing.Size(40, 20);
            this.redbullupdown.TabIndex = 9;
            this.redbullupdown.ValueChanged += new System.EventHandler(this.redbullupdown_ValueChanged);
            // 
            // snickersupdown
            // 
            this.snickersupdown.Location = new System.Drawing.Point(163, 55);
            this.snickersupdown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.snickersupdown.Name = "snickersupdown";
            this.snickersupdown.Size = new System.Drawing.Size(40, 20);
            this.snickersupdown.TabIndex = 8;
            this.snickersupdown.ValueChanged += new System.EventHandler(this.snickersupdown_ValueChanged);
            // 
            // CoffeUpDown
            // 
            this.CoffeUpDown.Location = new System.Drawing.Point(163, 19);
            this.CoffeUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CoffeUpDown.Name = "CoffeUpDown";
            this.CoffeUpDown.Size = new System.Drawing.Size(40, 20);
            this.CoffeUpDown.TabIndex = 2;
            this.CoffeUpDown.ValueChanged += new System.EventHandler(this.CoffeUpDown_ValueChanged);
            // 
            // fantaBox
            // 
            this.fantaBox.AutoSize = true;
            this.fantaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantaBox.Location = new System.Drawing.Point(16, 162);
            this.fantaBox.Name = "fantaBox";
            this.fantaBox.Size = new System.Drawing.Size(70, 24);
            this.fantaBox.TabIndex = 7;
            this.fantaBox.Text = "Fanta";
            this.fantaBox.UseVisualStyleBackColor = true;
            // 
            // spriteBox
            // 
            this.spriteBox.AutoSize = true;
            this.spriteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spriteBox.Location = new System.Drawing.Point(16, 127);
            this.spriteBox.Name = "spriteBox";
            this.spriteBox.Size = new System.Drawing.Size(70, 24);
            this.spriteBox.TabIndex = 6;
            this.spriteBox.Text = "Sprite";
            this.spriteBox.UseVisualStyleBackColor = true;
            // 
            // redbullBox
            // 
            this.redbullBox.AutoSize = true;
            this.redbullBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redbullBox.Location = new System.Drawing.Point(16, 91);
            this.redbullBox.Name = "redbullBox";
            this.redbullBox.Size = new System.Drawing.Size(82, 24);
            this.redbullBox.TabIndex = 5;
            this.redbullBox.Text = "Redbull";
            this.redbullBox.UseVisualStyleBackColor = true;
            // 
            // snickersBox
            // 
            this.snickersBox.AutoSize = true;
            this.snickersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snickersBox.Location = new System.Drawing.Point(16, 55);
            this.snickersBox.Name = "snickersBox";
            this.snickersBox.Size = new System.Drawing.Size(89, 24);
            this.snickersBox.TabIndex = 4;
            this.snickersBox.Text = "Snickers";
            this.snickersBox.UseVisualStyleBackColor = true;
            // 
            // CoffeeBox
            // 
            this.CoffeeBox.AutoSize = true;
            this.CoffeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeBox.Location = new System.Drawing.Point(16, 19);
            this.CoffeeBox.Name = "CoffeeBox";
            this.CoffeeBox.Size = new System.Drawing.Size(76, 24);
            this.CoffeeBox.TabIndex = 3;
            this.CoffeeBox.Text = "Coffee";
            this.CoffeeBox.UseVisualStyleBackColor = true;
            // 
            // kafeTotal
            // 
            this.kafeTotal.Controls.Add(this.label2);
            this.kafeTotal.Location = new System.Drawing.Point(6, 206);
            this.kafeTotal.Name = "kafeTotal";
            this.kafeTotal.Size = new System.Drawing.Size(197, 87);
            this.kafeTotal.TabIndex = 2;
            this.kafeTotal.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "0.00";
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // autogroupbox
            // 
            this.autogroupbox.Controls.Add(this.pictureBox2);
            this.autogroupbox.Controls.Add(this.groupBox3);
            this.autogroupbox.Controls.Add(this.oilpricelabel);
            this.autogroupbox.Controls.Add(this.litrmaskedbox);
            this.autogroupbox.Controls.Add(this.pricemaskedbox);
            this.autogroupbox.Controls.Add(this.oillbl);
            this.autogroupbox.Controls.Add(this.fuellbl);
            this.autogroupbox.Controls.Add(this.fuelSelectBox);
            this.autogroupbox.Controls.Add(this.benzinTotal);
            this.autogroupbox.Location = new System.Drawing.Point(2, 51);
            this.autogroupbox.Name = "autogroupbox";
            this.autogroupbox.Size = new System.Drawing.Size(198, 299);
            this.autogroupbox.TabIndex = 3;
            this.autogroupbox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioButton2);
            this.groupBox3.Controls.Add(this.RadioButton1);
            this.groupBox3.Location = new System.Drawing.Point(0, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 92);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioButton2.CheckedState.BorderThickness = 0;
            this.RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioButton2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioButton2.CheckedState.InnerOffset = -4;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RadioButton2.Location = new System.Drawing.Point(6, 48);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(56, 28);
            this.RadioButton2.TabIndex = 6;
            this.RadioButton2.Text = "Litr";
            this.RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton2.UncheckedState.BorderThickness = 2;
            this.RadioButton2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioButton1.CheckedState.BorderThickness = 0;
            this.RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioButton1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioButton1.CheckedState.InnerOffset = -4;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RadioButton1.Location = new System.Drawing.Point(6, 17);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(76, 28);
            this.RadioButton1.TabIndex = 7;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Price";
            this.RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton1.UncheckedState.BorderThickness = 2;
            this.RadioButton1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // oilpricelabel
            // 
            this.oilpricelabel.AutoSize = true;
            this.oilpricelabel.Location = new System.Drawing.Point(109, 77);
            this.oilpricelabel.Name = "oilpricelabel";
            this.oilpricelabel.Size = new System.Drawing.Size(0, 13);
            this.oilpricelabel.TabIndex = 17;
            // 
            // litrmaskedbox
            // 
            this.litrmaskedbox.Location = new System.Drawing.Point(96, 166);
            this.litrmaskedbox.Mask = "000";
            this.litrmaskedbox.Name = "litrmaskedbox";
            this.litrmaskedbox.Size = new System.Drawing.Size(86, 20);
            this.litrmaskedbox.TabIndex = 7;
            this.litrmaskedbox.ValidatingType = typeof(int);
            this.litrmaskedbox.TextChanged += new System.EventHandler(this.litrmaskedbox_TextChanged);
            // 
            // pricemaskedbox
            // 
            this.pricemaskedbox.Location = new System.Drawing.Point(96, 134);
            this.pricemaskedbox.Mask = "000";
            this.pricemaskedbox.Name = "pricemaskedbox";
            this.pricemaskedbox.Size = new System.Drawing.Size(86, 20);
            this.pricemaskedbox.TabIndex = 6;
            this.pricemaskedbox.ValidatingType = typeof(int);
            this.pricemaskedbox.TextChanged += new System.EventHandler(this.pricemaskedbox_TextChanged);
            // 
            // oillbl
            // 
            this.oillbl.AutoSize = true;
            this.oillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.oillbl.Location = new System.Drawing.Point(6, 74);
            this.oillbl.Name = "oillbl";
            this.oillbl.Size = new System.Drawing.Size(90, 24);
            this.oillbl.TabIndex = 4;
            this.oillbl.Text = "Oil Price";
            // 
            // fuellbl
            // 
            this.fuellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.fuellbl.Location = new System.Drawing.Point(108, 8);
            this.fuellbl.Name = "fuellbl";
            this.fuellbl.Size = new System.Drawing.Size(53, 21);
            this.fuellbl.TabIndex = 2;
            this.fuellbl.Text = "Fuel";
            // 
            // fuelSelectBox
            // 
            this.fuelSelectBox.FormattingEnabled = true;
            this.fuelSelectBox.Items.AddRange(new object[] {
            "Diesel",
            "AI-92",
            "AI-95",
            "AI-98"});
            this.fuelSelectBox.Location = new System.Drawing.Point(67, 32);
            this.fuelSelectBox.Name = "fuelSelectBox";
            this.fuelSelectBox.Size = new System.Drawing.Size(121, 21);
            this.fuelSelectBox.TabIndex = 3;
            this.fuelSelectBox.SelectedIndexChanged += new System.EventHandler(this.benzinSelectBox_SelectedIndexChanged);
            // 
            // benzinTotal
            // 
            this.benzinTotal.Controls.Add(this.benzinTotalLb);
            this.benzinTotal.Location = new System.Drawing.Point(6, 206);
            this.benzinTotal.Name = "benzinTotal";
            this.benzinTotal.Size = new System.Drawing.Size(182, 87);
            this.benzinTotal.TabIndex = 1;
            this.benzinTotal.TabStop = false;
            // 
            // benzinTotalLb
            // 
            this.benzinTotalLb.AutoSize = true;
            this.benzinTotalLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benzinTotalLb.Location = new System.Drawing.Point(68, 26);
            this.benzinTotalLb.Name = "benzinTotalLb";
            this.benzinTotalLb.Size = new System.Drawing.Size(35, 37);
            this.benzinTotalLb.TabIndex = 2;
            this.benzinTotalLb.Text = "0";
            this.benzinTotalLb.TextChanged += new System.EventHandler(this.benzinTotalLb_TextChanged);
            // 
            // borderlbl
            // 
            this.borderlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.borderlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.borderlbl.Location = new System.Drawing.Point(-1, -1);
            this.borderlbl.Name = "borderlbl";
            this.borderlbl.Size = new System.Drawing.Size(445, 38);
            this.borderlbl.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(380, -1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(46, 38);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(325, -1);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(46, 38);
            this.guna2Button2.TabIndex = 8;
            this.guna2Button2.Text = "-";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icons8_fuel_60;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.icons8_money_48;
            this.pictureBox4.Location = new System.Drawing.Point(2, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.icons8_fuel_94;
            this.pictureBox2.Location = new System.Drawing.Point(21, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(229, 467);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(120, 28);
            this.guna2RatingStar1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "RATING GAS OIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2RatingStar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.borderlbl);
            this.Controls.Add(this.totalPriceGrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autogroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.totalPriceGrp.ResumeLayout(false);
            this.totalPriceGrp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fantaupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redbullupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snickersupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeUpDown)).EndInit();
            this.kafeTotal.ResumeLayout(false);
            this.kafeTotal.PerformLayout();
            this.autogroupbox.ResumeLayout(false);
            this.autogroupbox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.benzinTotal.ResumeLayout(false);
            this.benzinTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox totalPriceGrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buyBtr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown fantaupdown;
        private System.Windows.Forms.NumericUpDown spriteupdown;
        private System.Windows.Forms.NumericUpDown redbullupdown;
        private System.Windows.Forms.NumericUpDown snickersupdown;
        private System.Windows.Forms.NumericUpDown CoffeUpDown;
        private System.Windows.Forms.CheckBox fantaBox;
        private System.Windows.Forms.CheckBox spriteBox;
        private System.Windows.Forms.CheckBox redbullBox;
        private System.Windows.Forms.CheckBox snickersBox;
        private System.Windows.Forms.CheckBox CoffeeBox;
        private System.Windows.Forms.GroupBox kafeTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox autogroupbox;
        private System.Windows.Forms.Label oillbl;
        private System.Windows.Forms.Label fuellbl;
        private System.Windows.Forms.ComboBox fuelSelectBox;
        private System.Windows.Forms.GroupBox benzinTotal;
        private System.Windows.Forms.Label benzinTotalLb;
        private System.Windows.Forms.Label fantapricelbl;
        private System.Windows.Forms.Label spritepricelbl;
        private System.Windows.Forms.Label redbullpricelbl;
        private System.Windows.Forms.Label snickerspricelbl;
        private System.Windows.Forms.Label coffepricelbl;
        private System.Windows.Forms.MaskedTextBox litrmaskedbox;
        private System.Windows.Forms.MaskedTextBox pricemaskedbox;
        private System.Windows.Forms.Label oilpricelabel;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton RadioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label borderlbl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Label label1;
    }
}

