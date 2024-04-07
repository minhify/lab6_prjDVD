namespace lab6_prjDVD
{
    partial class frmDVDLibrary
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDVDTitle = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbLang = new System.Windows.Forms.Label();
            this.lbDVDTitle = new System.Windows.Forms.Label();
            this.lbDVDNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.nrPrice = new System.Windows.Forms.NumericUpDown();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.tbDVDNumber = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(385, 462);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 459);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 38);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 459);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 38);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbDVDTitle
            // 
            this.tbDVDTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDVDTitle.Location = new System.Drawing.Point(158, 139);
            this.tbDVDTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDVDTitle.Name = "tbDVDTitle";
            this.tbDVDTitle.Size = new System.Drawing.Size(361, 27);
            this.tbDVDTitle.TabIndex = 22;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(26, 261);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(48, 20);
            this.lbPrice.TabIndex = 21;
            this.lbPrice.Text = "Price";
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Location = new System.Drawing.Point(25, 200);
            this.lbLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(82, 20);
            this.lbLang.TabIndex = 20;
            this.lbLang.Text = "Language";
            // 
            // lbDVDTitle
            // 
            this.lbDVDTitle.AutoSize = true;
            this.lbDVDTitle.Location = new System.Drawing.Point(26, 145);
            this.lbDVDTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDVDTitle.Name = "lbDVDTitle";
            this.lbDVDTitle.Size = new System.Drawing.Size(83, 20);
            this.lbDVDTitle.TabIndex = 19;
            this.lbDVDTitle.Text = "DVD Title";
            // 
            // lbDVDNumber
            // 
            this.lbDVDNumber.AutoSize = true;
            this.lbDVDNumber.Location = new System.Drawing.Point(25, 91);
            this.lbDVDNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDVDNumber.Name = "lbDVDNumber";
            this.lbDVDNumber.Size = new System.Drawing.Size(110, 20);
            this.lbDVDNumber.TabIndex = 18;
            this.lbDVDNumber.Text = "DVD Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Location = new System.Drawing.Point(157, 314);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sub title";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(135, 54);
            this.rbNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(51, 24);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(34, 54);
            this.rbYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(58, 24);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // nrPrice
            // 
            this.nrPrice.Location = new System.Drawing.Point(158, 254);
            this.nrPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nrPrice.Name = "nrPrice";
            this.nrPrice.Size = new System.Drawing.Size(226, 27);
            this.nrPrice.TabIndex = 16;
            this.nrPrice.ValueChanged += new System.EventHandler(this.nrPrice_ValueChanged);
            // 
            // cbLang
            // 
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Items.AddRange(new object[] {
            "English",
            "Spanish",
            ""});
            this.cbLang.Location = new System.Drawing.Point(157, 198);
            this.cbLang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(225, 28);
            this.cbLang.TabIndex = 15;
            this.cbLang.SelectedIndexChanged += new System.EventHandler(this.cbLang_SelectedIndexChanged);
            // 
            // tbDVDNumber
            // 
            this.tbDVDNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDVDNumber.Location = new System.Drawing.Point(158, 89);
            this.tbDVDNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDVDNumber.Name = "tbDVDNumber";
            this.tbDVDNumber.Size = new System.Drawing.Size(361, 27);
            this.tbDVDNumber.TabIndex = 14;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(169, 26);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 36);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "DVD Catalog";
            // 
            // frmDVDLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 510);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDVDTitle);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbLang);
            this.Controls.Add(this.lbDVDTitle);
            this.Controls.Add(this.lbDVDNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nrPrice);
            this.Controls.Add(this.cbLang);
            this.Controls.Add(this.tbDVDNumber);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDVDLibrary";
            this.Text = "DVD Library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDVDTitle;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbLang;
        private System.Windows.Forms.Label lbDVDTitle;
        private System.Windows.Forms.Label lbDVDNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.NumericUpDown nrPrice;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.TextBox tbDVDNumber;
        private System.Windows.Forms.Label lbTitle;
    }
}

