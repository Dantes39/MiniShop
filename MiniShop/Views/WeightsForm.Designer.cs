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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Весы";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(320, 157);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(79, 16);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "labelWeight";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(130, 264);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(83, 16);
            this.labelProduct.TabIndex = 2;
            this.labelProduct.Text = "labelProduct";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(331, 315);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(68, 16);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "labelPrice";
            // 
            // buttonMakeWeight
            // 
            this.buttonMakeWeight.Location = new System.Drawing.Point(287, 382);
            this.buttonMakeWeight.Name = "buttonMakeWeight";
            this.buttonMakeWeight.Size = new System.Drawing.Size(158, 23);
            this.buttonMakeWeight.TabIndex = 8;
            this.buttonMakeWeight.Text = "buttonMakeWeight";
            this.buttonMakeWeight.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantityProduct
            // 
            this.numericUpDownQuantityProduct.Location = new System.Drawing.Point(543, 201);
            this.numericUpDownQuantityProduct.Name = "numericUpDownQuantityProduct";
            this.numericUpDownQuantityProduct.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownQuantityProduct.TabIndex = 9;
            // 
            // buttonPutOutProduct
            // 
            this.buttonPutOutProduct.Location = new System.Drawing.Point(499, 308);
            this.buttonPutOutProduct.Name = "buttonPutOutProduct";
            this.buttonPutOutProduct.Size = new System.Drawing.Size(183, 23);
            this.buttonPutOutProduct.TabIndex = 7;
            this.buttonPutOutProduct.Text = "buttonPutOutProduct";
            this.buttonPutOutProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(499, 382);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(133, 23);
            this.buttonAddToCart.TabIndex = 10;
            this.buttonAddToCart.Text = "buttonAddToCart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(543, 157);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(113, 16);
            this.labelTotalAmount.TabIndex = 11;
            this.labelTotalAmount.Text = "labelTotalAmount";
            // 
            // WeightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.numericUpDownQuantityProduct);
            this.Controls.Add(this.buttonMakeWeight);
            this.Controls.Add(this.buttonPutOutProduct);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.label1);
            this.Name = "WeightsForm";
            this.Text = "WeightsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantityProduct)).EndInit();
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
    }
}