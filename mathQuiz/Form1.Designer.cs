namespace mathQuiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.son4 = new System.Windows.Forms.NumericUpDown();
            this.son3 = new System.Windows.Forms.NumericUpDown();
            this.son2 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.say42 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.say41 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.say32 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.say31 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.say22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.say21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.say12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.say11 = new System.Windows.Forms.Label();
            this.son1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.say13 = new System.Windows.Forms.Label();
            this.say23 = new System.Windows.Forms.Label();
            this.say33 = new System.Windows.Forms.Label();
            this.say43 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.trueA = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.son4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.son3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.son2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.son1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(546, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(72, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "START!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.son4, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.son3, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.son2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.say42, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label18, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.say41, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.say32, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.say31, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.say22, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.say21, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.say12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.say11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.son1, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 500);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // son4
            // 
            this.son4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.son4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.son4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.son4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.son4.Location = new System.Drawing.Point(501, 421);
            this.son4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.son4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.son4.Name = "son4";
            this.son4.Size = new System.Drawing.Size(119, 30);
            this.son4.TabIndex = 22;
            this.son4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // son3
            // 
            this.son3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.son3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.son3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.son3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.son3.Location = new System.Drawing.Point(501, 296);
            this.son3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.son3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.son3.Name = "son3";
            this.son3.Size = new System.Drawing.Size(119, 30);
            this.son3.TabIndex = 21;
            this.son3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // son2
            // 
            this.son2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.son2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.son2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.son2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.son2.Location = new System.Drawing.Point(501, 172);
            this.son2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.son2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.son2.Name = "son2";
            this.son2.Size = new System.Drawing.Size(119, 30);
            this.son2.TabIndex = 20;
            this.son2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(410, 409);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 54);
            this.label20.TabIndex = 18;
            this.label20.Text = "=";
            // 
            // say42
            // 
            this.say42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say42.AutoSize = true;
            this.say42.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say42.Location = new System.Drawing.Point(286, 409);
            this.say42.Name = "say42";
            this.say42.Size = new System.Drawing.Size(49, 54);
            this.say42.TabIndex = 17;
            this.say42.Text = "?";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(162, 409);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 54);
            this.label18.TabIndex = 16;
            this.label18.Text = "÷";
            // 
            // say41
            // 
            this.say41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say41.AutoSize = true;
            this.say41.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say41.Location = new System.Drawing.Point(38, 409);
            this.say41.Name = "say41";
            this.say41.Size = new System.Drawing.Size(49, 54);
            this.say41.TabIndex = 15;
            this.say41.Text = "?";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(410, 284);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 54);
            this.label15.TabIndex = 13;
            this.label15.Text = "=";
            // 
            // say32
            // 
            this.say32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say32.AutoSize = true;
            this.say32.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say32.Location = new System.Drawing.Point(286, 284);
            this.say32.Name = "say32";
            this.say32.Size = new System.Drawing.Size(49, 54);
            this.say32.TabIndex = 12;
            this.say32.Text = "?";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(163, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 54);
            this.label13.TabIndex = 11;
            this.label13.Text = "x";
            // 
            // say31
            // 
            this.say31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say31.AutoSize = true;
            this.say31.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say31.Location = new System.Drawing.Point(38, 284);
            this.say31.Name = "say31";
            this.say31.Size = new System.Drawing.Size(49, 54);
            this.say31.TabIndex = 10;
            this.say31.Text = "?";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(410, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 54);
            this.label10.TabIndex = 8;
            this.label10.Text = "=";
            // 
            // say22
            // 
            this.say22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say22.AutoSize = true;
            this.say22.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say22.Location = new System.Drawing.Point(286, 160);
            this.say22.Name = "say22";
            this.say22.Size = new System.Drawing.Size(49, 54);
            this.say22.TabIndex = 7;
            this.say22.Text = "?";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(167, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 54);
            this.label8.TabIndex = 6;
            this.label8.Text = "-";
            // 
            // say21
            // 
            this.say21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say21.AutoSize = true;
            this.say21.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say21.Location = new System.Drawing.Point(38, 160);
            this.say21.Name = "say21";
            this.say21.Size = new System.Drawing.Size(49, 54);
            this.say21.TabIndex = 5;
            this.say21.Text = "?";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(410, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 54);
            this.label5.TabIndex = 3;
            this.label5.Text = "=";
            // 
            // say12
            // 
            this.say12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say12.AutoSize = true;
            this.say12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say12.Location = new System.Drawing.Point(286, 36);
            this.say12.Name = "say12";
            this.say12.Size = new System.Drawing.Size(49, 54);
            this.say12.TabIndex = 2;
            this.say12.Text = "?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(162, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "+";
            // 
            // say11
            // 
            this.say11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.say11.AutoSize = true;
            this.say11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.say11.Location = new System.Drawing.Point(38, 36);
            this.say11.Name = "say11";
            this.say11.Size = new System.Drawing.Size(49, 54);
            this.say11.TabIndex = 0;
            this.say11.Text = "?";
            // 
            // son1
            // 
            this.son1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.son1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.son1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.son1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.son1.Location = new System.Drawing.Point(501, 48);
            this.son1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.son1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.son1.Name = "son1";
            this.son1.Size = new System.Drawing.Size(119, 30);
            this.son1.TabIndex = 19;
            this.son1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(362, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Check it!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // say13
            // 
            this.say13.AutoSize = true;
            this.say13.Location = new System.Drawing.Point(698, 159);
            this.say13.Name = "say13";
            this.say13.Size = new System.Drawing.Size(50, 16);
            this.say13.TabIndex = 5;
            this.say13.Tag = "";
            this.say13.Text = "answer";
            this.say13.Visible = false;
            // 
            // say23
            // 
            this.say23.AutoSize = true;
            this.say23.Location = new System.Drawing.Point(698, 283);
            this.say23.Name = "say23";
            this.say23.Size = new System.Drawing.Size(50, 16);
            this.say23.TabIndex = 6;
            this.say23.Tag = "";
            this.say23.Text = "answer";
            this.say23.Visible = false;
            // 
            // say33
            // 
            this.say33.AutoSize = true;
            this.say33.Location = new System.Drawing.Point(698, 407);
            this.say33.Name = "say33";
            this.say33.Size = new System.Drawing.Size(50, 16);
            this.say33.TabIndex = 7;
            this.say33.Tag = "";
            this.say33.Text = "answer";
            this.say33.Visible = false;
            // 
            // say43
            // 
            this.say43.AutoSize = true;
            this.say43.Location = new System.Drawing.Point(698, 532);
            this.say43.Name = "say43";
            this.say43.Size = new System.Drawing.Size(50, 16);
            this.say43.TabIndex = 8;
            this.say43.Tag = "";
            this.say43.Text = "answer";
            this.say43.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(546, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Restart!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trueA
            // 
            this.trueA.AutoSize = true;
            this.trueA.Location = new System.Drawing.Point(693, 102);
            this.trueA.Name = "trueA";
            this.trueA.Size = new System.Drawing.Size(61, 32);
            this.trueA.TabIndex = 10;
            this.trueA.Text = "Correct \r\nAnswers:";
            this.trueA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.trueA.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 642);
            this.Controls.Add(this.trueA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.say43);
            this.Controls.Add(this.say33);
            this.Controls.Add(this.say23);
            this.Controls.Add(this.say13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.son4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.son3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.son2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.son1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label say11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label say42;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label say41;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label say32;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label say31;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label say22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label say21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label say12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown son1;
        private System.Windows.Forms.NumericUpDown son4;
        private System.Windows.Forms.NumericUpDown son3;
        private System.Windows.Forms.NumericUpDown son2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label say13;
        private System.Windows.Forms.Label say23;
        private System.Windows.Forms.Label say33;
        private System.Windows.Forms.Label say43;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label trueA;
    }
}