namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userInputText = new System.Windows.Forms.TextBox();
            this.calculationResultText = new System.Windows.Forms.Label();
            this.Minus = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.OpenPunc = new System.Windows.Forms.Button();
            this.ClosePunc = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInputText
            // 
            this.userInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.userInputText.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userInputText.Location = new System.Drawing.Point(-1, 12);
            this.userInputText.Margin = new System.Windows.Forms.Padding(0);
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(398, 30);
            this.userInputText.TabIndex = 0;
            // 
            // calculationResultText
            // 
            this.calculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculationResultText.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationResultText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calculationResultText.Location = new System.Drawing.Point(-1, 42);
            this.calculationResultText.Margin = new System.Windows.Forms.Padding(0);
            this.calculationResultText.Name = "calculationResultText";
            this.calculationResultText.Size = new System.Drawing.Size(398, 52);
            this.calculationResultText.TabIndex = 1;
            this.calculationResultText.Text = "0";
            this.calculationResultText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calculationResultText.Click += new System.EventHandler(this.Result_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minus.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Minus.Location = new System.Drawing.Point(294, 200);
            this.Minus.Margin = new System.Windows.Forms.Padding(0);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(101, 50);
            this.Minus.TabIndex = 19;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multi
            // 
            this.Multi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Multi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multi.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Multi.Location = new System.Drawing.Point(294, 100);
            this.Multi.Margin = new System.Windows.Forms.Padding(0);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(101, 50);
            this.Multi.TabIndex = 7;
            this.Multi.Text = "X";
            this.Multi.UseVisualStyleBackColor = false;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Divide.Location = new System.Drawing.Point(294, 150);
            this.Divide.Margin = new System.Windows.Forms.Padding(0);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(101, 50);
            this.Divide.TabIndex = 11;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Plus.Location = new System.Drawing.Point(294, 250);
            this.Plus.Margin = new System.Windows.Forms.Padding(0);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(101, 52);
            this.Plus.TabIndex = 15;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Equal.Location = new System.Drawing.Point(196, 250);
            this.Equal.Margin = new System.Windows.Forms.Padding(0);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(98, 52);
            this.Equal.TabIndex = 18;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Percentage
            // 
            this.Percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Percentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Percentage.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Percentage.Location = new System.Drawing.Point(196, 0);
            this.Percentage.Margin = new System.Windows.Forms.Padding(0);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(98, 50);
            this.Percentage.TabIndex = 4;
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = false;
            this.Percentage.Click += new System.EventHandler(this.Percentage_Click);
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Del.Location = new System.Drawing.Point(98, 0);
            this.Del.Margin = new System.Windows.Forms.Padding(0);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(98, 50);
            this.Del.TabIndex = 2;
            this.Del.Text = "Del";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CE.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CE.Location = new System.Drawing.Point(0, 0);
            this.CE.Margin = new System.Windows.Forms.Padding(0);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(98, 50);
            this.CE.TabIndex = 0;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seven.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Seven.Location = new System.Drawing.Point(0, 100);
            this.Seven.Margin = new System.Windows.Forms.Padding(0);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(98, 50);
            this.Seven.TabIndex = 4;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Eight.Location = new System.Drawing.Point(98, 100);
            this.Eight.Margin = new System.Windows.Forms.Padding(0);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(98, 50);
            this.Eight.TabIndex = 5;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nine.Location = new System.Drawing.Point(196, 100);
            this.Nine.Margin = new System.Windows.Forms.Padding(0);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(98, 50);
            this.Nine.TabIndex = 6;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Four.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Four.Location = new System.Drawing.Point(0, 150);
            this.Four.Margin = new System.Windows.Forms.Padding(0);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(98, 50);
            this.Four.TabIndex = 8;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Five.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Five.Location = new System.Drawing.Point(98, 150);
            this.Five.Margin = new System.Windows.Forms.Padding(0);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(98, 50);
            this.Five.TabIndex = 9;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Six.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Six.Location = new System.Drawing.Point(196, 150);
            this.Six.Margin = new System.Windows.Forms.Padding(0);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(98, 50);
            this.Six.TabIndex = 10;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.One.Dock = System.Windows.Forms.DockStyle.Fill;
            this.One.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.One.Location = new System.Drawing.Point(0, 200);
            this.One.Margin = new System.Windows.Forms.Padding(0);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(98, 50);
            this.One.TabIndex = 12;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Two.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Two.Location = new System.Drawing.Point(98, 200);
            this.Two.Margin = new System.Windows.Forms.Padding(0);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(98, 50);
            this.Two.TabIndex = 13;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Three.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Three.Location = new System.Drawing.Point(196, 200);
            this.Three.Margin = new System.Windows.Forms.Padding(0);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(98, 50);
            this.Three.TabIndex = 14;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dot.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dot.Location = new System.Drawing.Point(0, 250);
            this.Dot.Margin = new System.Windows.Forms.Padding(0);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(98, 52);
            this.Dot.TabIndex = 16;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zero.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Zero.Location = new System.Drawing.Point(98, 250);
            this.Zero.Margin = new System.Windows.Forms.Padding(0);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(98, 52);
            this.Zero.TabIndex = 17;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // OpenPunc
            // 
            this.OpenPunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OpenPunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenPunc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenPunc.Location = new System.Drawing.Point(294, 0);
            this.OpenPunc.Margin = new System.Windows.Forms.Padding(0);
            this.OpenPunc.Name = "OpenPunc";
            this.OpenPunc.Size = new System.Drawing.Size(101, 50);
            this.OpenPunc.TabIndex = 21;
            this.OpenPunc.Text = "(";
            this.OpenPunc.UseVisualStyleBackColor = false;
            this.OpenPunc.Click += new System.EventHandler(this.OpenPunc_Click);
            // 
            // ClosePunc
            // 
            this.ClosePunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClosePunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClosePunc.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosePunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClosePunc.Location = new System.Drawing.Point(294, 50);
            this.ClosePunc.Margin = new System.Windows.Forms.Padding(0);
            this.ClosePunc.Name = "ClosePunc";
            this.ClosePunc.Size = new System.Drawing.Size(101, 50);
            this.ClosePunc.TabIndex = 22;
            this.ClosePunc.Text = ")";
            this.ClosePunc.UseVisualStyleBackColor = false;
            this.ClosePunc.Click += new System.EventHandler(this.ClosePunc_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.ColumnCount = 4;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsPanel.Controls.Add(this.button3, 2, 1);
            this.buttonsPanel.Controls.Add(this.button2, 1, 1);
            this.buttonsPanel.Controls.Add(this.button1, 0, 1);
            this.buttonsPanel.Controls.Add(this.ClosePunc, 3, 1);
            this.buttonsPanel.Controls.Add(this.Plus, 3, 5);
            this.buttonsPanel.Controls.Add(this.Multi, 3, 2);
            this.buttonsPanel.Controls.Add(this.Minus, 3, 4);
            this.buttonsPanel.Controls.Add(this.Divide, 3, 3);
            this.buttonsPanel.Controls.Add(this.Equal, 2, 5);
            this.buttonsPanel.Controls.Add(this.Dot, 0, 5);
            this.buttonsPanel.Controls.Add(this.Zero, 1, 5);
            this.buttonsPanel.Controls.Add(this.One, 0, 4);
            this.buttonsPanel.Controls.Add(this.Two, 1, 4);
            this.buttonsPanel.Controls.Add(this.Three, 2, 4);
            this.buttonsPanel.Controls.Add(this.Four, 0, 3);
            this.buttonsPanel.Controls.Add(this.Five, 1, 3);
            this.buttonsPanel.Controls.Add(this.Six, 2, 3);
            this.buttonsPanel.Controls.Add(this.Seven, 0, 2);
            this.buttonsPanel.Controls.Add(this.Eight, 1, 2);
            this.buttonsPanel.Controls.Add(this.Nine, 2, 2);
            this.buttonsPanel.Controls.Add(this.OpenPunc, 3, 0);
            this.buttonsPanel.Controls.Add(this.Percentage, 2, 0);
            this.buttonsPanel.Controls.Add(this.Del, 1, 0);
            this.buttonsPanel.Controls.Add(this.CE, 0, 0);
            this.buttonsPanel.Location = new System.Drawing.Point(2, 94);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 6;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56315F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56315F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56315F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56315F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56315F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18427F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsPanel.Size = new System.Drawing.Size(395, 302);
            this.buttonsPanel.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(196, 50);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 50);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(98, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 50);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 50);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.Equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CancelButton = this.CE;
            this.ClientSize = new System.Drawing.Size(398, 396);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.calculationResultText);
            this.Controls.Add(this.userInputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(285, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator - Made by HAKAM";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputText;
        private System.Windows.Forms.Label calculationResultText;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Percentage;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button OpenPunc;
        private System.Windows.Forms.Button ClosePunc;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

