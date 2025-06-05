namespace MiniShop.Views
{
    partial class WeightsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonMakeWeight = new System.Windows.Forms.Button();
            this.numericUpDownQuantityProduct = new System.Windows.Forms.NumericUpDown();
            this.buttonPutOutProduct = new System.Windows.Forms.Button();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ВЕСЫ";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelWeight.Location = new System.Drawing.Point(22, 73);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(152, 29);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "labelWeight";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(113, 73);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(83, 16);
            this.labelProduct.TabIndex = 2;
            this.labelProduct.Text = "labelProduct";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(70, 350);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(68, 16);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "labelPrice";
            // 
            // buttonMakeWeight
            // 
            this.buttonMakeWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMakeWeight.Location = new System.Drawing.Point(305, 319);
            this.buttonMakeWeight.Name = "buttonMakeWeight";
            this.buttonMakeWeight.Size = new System.Drawing.Size(190, 47);
            this.buttonMakeWeight.TabIndex = 8;
            this.buttonMakeWeight.Text = "Взвесить";
            this.buttonMakeWeight.UseVisualStyleBackColor = false;
            // 
            // numericUpDownQuantityProduct
            // 
            this.numericUpDownQuantityProduct.Location = new System.Drawing.Point(305, 277);
            this.numericUpDownQuantityProduct.Name = "numericUpDownQuantityProduct";
            this.numericUpDownQuantityProduct.Size = new System.Drawing.Size(190, 22);
            this.numericUpDownQuantityProduct.TabIndex = 9;
            // 
            // buttonPutOutProduct
            // 
            this.buttonPutOutProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPutOutProduct.Location = new System.Drawing.Point(305, 381);
            this.buttonPutOutProduct.Name = "buttonPutOutProduct";
            this.buttonPutOutProduct.Size = new System.Drawing.Size(190, 47);
            this.buttonPutOutProduct.TabIndex = 7;
            this.buttonPutOutProduct.Text = "Убрать с весов";
            this.buttonPutOutProduct.UseVisualStyleBackColor = false;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddToCart.Location = new System.Drawing.Point(66, 381);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(190, 47);
            this.buttonAddToCart.TabIndex = 10;
            this.buttonAddToCart.Text = "Добавить в корзину";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.BackColor = System.Drawing.Color.White;
            this.labelTotalAmount.Location = new System.Drawing.Point(70, 294);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(113, 16);
            this.labelTotalAmount.TabIndex = 11;
            this.labelTotalAmount.Text = "labelTotalAmount";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelWeight);
            this.groupBox1.Location = new System.Drawing.Point(305, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 168);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Весы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(123, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Грамм";
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(66, 92);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(190, 164);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 13;
            this.pictureBoxProduct.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена руб.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Кол-во товара на весах";
            // 
            // WeightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.numericUpDownQuantityProduct);
            this.Controls.Add(this.buttonMakeWeight);
            this.Controls.Add(this.buttonPutOutProduct);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.label1);
            this.Name = "WeightsForm";
            this.Text = "WeightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonMakeWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantityProduct;
        private System.Windows.Forms.Button buttonPutOutProduct;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}