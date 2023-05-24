namespace JuliaIB.Properties
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtDiscount = new TextBox();
            grpTax = new GroupBox();
            picCross = new PictureBox();
            picCheck = new PictureBox();
            rdoNotIncluded = new RadioButton();
            rdoIncluded = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpTax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCross).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCheck).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(44, 244);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(44, 344);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(44, 292);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 1;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(44, 396);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 1;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // grpTax
            // 
            grpTax.Controls.Add(picCross);
            grpTax.Controls.Add(picCheck);
            grpTax.Controls.Add(rdoNotIncluded);
            grpTax.Controls.Add(rdoIncluded);
            grpTax.Location = new Point(208, 244);
            grpTax.Name = "grpTax";
            grpTax.Size = new Size(240, 163);
            grpTax.TabIndex = 2;
            grpTax.TabStop = false;
            grpTax.Text = "Tax";
            // 
            // picCross
            // 
            picCross.Image = (Image)resources.GetObject("picCross.Image");
            picCross.Location = new Point(170, 86);
            picCross.Name = "picCross";
            picCross.Size = new Size(51, 58);
            picCross.SizeMode = PictureBoxSizeMode.StretchImage;
            picCross.TabIndex = 1;
            picCross.TabStop = false;
            picCross.Visible = false;
            // 
            // picCheck
            // 
            picCheck.Image = (Image)resources.GetObject("picCheck.Image");
            picCheck.Location = new Point(170, 22);
            picCheck.Name = "picCheck";
            picCheck.Size = new Size(51, 58);
            picCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            picCheck.TabIndex = 1;
            picCheck.TabStop = false;
            picCheck.Visible = false;
            // 
            // rdoNotIncluded
            // 
            rdoNotIncluded.AutoSize = true;
            rdoNotIncluded.Location = new Point(17, 98);
            rdoNotIncluded.Name = "rdoNotIncluded";
            rdoNotIncluded.Size = new Size(147, 19);
            rdoNotIncluded.TabIndex = 0;
            rdoNotIncluded.TabStop = true;
            rdoNotIncluded.Text = "Tax Not Included +16%";
            rdoNotIncluded.UseVisualStyleBackColor = true;
            rdoNotIncluded.CheckedChanged += rdoNotIncluded_CheckedChanged;
            // 
            // rdoIncluded
            // 
            rdoIncluded.AutoSize = true;
            rdoIncluded.Location = new Point(17, 42);
            rdoIncluded.Name = "rdoIncluded";
            rdoIncluded.Size = new Size(91, 19);
            rdoIncluded.TabIndex = 0;
            rdoIncluded.TabStop = true;
            rdoIncluded.Text = "Tax included";
            rdoIncluded.UseVisualStyleBackColor = true;
            rdoIncluded.CheckedChanged += rdoIncluded_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 226);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Material Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 274);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Material Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 326);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Material Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 378);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 4;
            label4.Text = "Discount";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.CadetBlue;
            btnCalculate.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(108, 442);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(211, 86);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // frmOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(460, 549);
            Controls.Add(btnCalculate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grpTax);
            Controls.Add(txtPrice);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Name = "frmOptions";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpTax.ResumeLayout(false);
            grpTax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCross).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtDiscount;
        private GroupBox grpTax;
        private PictureBox picCross;
        private PictureBox picCheck;
        private RadioButton rdoNotIncluded;
        private RadioButton rdoIncluded;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalculate;
    }
}