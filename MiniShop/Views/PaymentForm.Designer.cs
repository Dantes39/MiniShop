namespace MiniShop.Views
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioCard = new System.Windows.Forms.RadioButton();
            this.radioBonus = new System.Windows.Forms.RadioButton();
            this.labelCashBalance = new System.Windows.Forms.Label();
            this.labelCardBalance = new System.Windows.Forms.Label();
            this.labelBonusBalance = new System.Windows.Forms.Label();
            this.textBoxCashAmount = new System.Windows.Forms.TextBox();
            this.textBoxCardAmount = new System.Windows.Forms.TextBox();
            this.textBoxBonusAmount = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.buttonCashMax = new System.Windows.Forms.Button();
            this.buttonCardMax = new System.Windows.Forms.Button();
            this.buttonBonusMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(50, 30);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(116, 16);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "Сумма к оплате: ";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(50, 60);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(104, 20);
            this.radioCash.TabIndex = 1;
            this.radioCash.Text = "Наличными";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioCard
            // 
            this.radioCard.AutoSize = true;
            this.radioCard.Location = new System.Drawing.Point(50, 90);
            this.radioCard.Name = "radioCard";
            this.radioCard.Size = new System.Drawing.Size(75, 20);
            this.radioCard.TabIndex = 2;
            this.radioCard.Text = "Картой";
            this.radioCard.UseVisualStyleBackColor = true;
            // 
            // radioBonus
            // 
            this.radioBonus.AutoSize = true;
            this.radioBonus.Location = new System.Drawing.Point(50, 120);
            this.radioBonus.Name = "radioBonus";
            this.radioBonus.Size = new System.Drawing.Size(93, 20);
            this.radioBonus.TabIndex = 3;
            this.radioBonus.Text = "Бонусами";
            this.radioBonus.UseVisualStyleBackColor = true;
            // 
            // labelCashBalance
            // 
            this.labelCashBalance.AutoSize = true;
            this.labelCashBalance.Location = new System.Drawing.Point(160, 60);
            this.labelCashBalance.Name = "labelCashBalance";
            this.labelCashBalance.Size = new System.Drawing.Size(75, 16);
            this.labelCashBalance.TabIndex = 4;
            this.labelCashBalance.Text = "Баланс: 0₽";
            // 
            // labelCardBalance
            // 
            this.labelCardBalance.AutoSize = true;
            this.labelCardBalance.Location = new System.Drawing.Point(160, 90);
            this.labelCardBalance.Name = "labelCardBalance";
            this.labelCardBalance.Size = new System.Drawing.Size(75, 16);
            this.labelCardBalance.TabIndex = 5;
            this.labelCardBalance.Text = "Баланс: 0₽";
            // 
            // labelBonusBalance
            // 
            this.labelBonusBalance.AutoSize = true;
            this.labelBonusBalance.Location = new System.Drawing.Point(160, 120);
            this.labelBonusBalance.Name = "labelBonusBalance";
            this.labelBonusBalance.Size = new System.Drawing.Size(68, 16);
            this.labelBonusBalance.TabIndex = 6;
            this.labelBonusBalance.Text = "Баланс: 0";
            // 
            // textBoxCashAmount
            // 
            this.textBoxCashAmount.Location = new System.Drawing.Point(320, 60);
            this.textBoxCashAmount.Name = "textBoxCashAmount";
            this.textBoxCashAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCashAmount.TabIndex = 7;
            this.textBoxCashAmount.Text = "0";
            // 
            // textBoxCardAmount
            // 
            this.textBoxCardAmount.Location = new System.Drawing.Point(320, 90);
            this.textBoxCardAmount.Name = "textBoxCardAmount";
            this.textBoxCardAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxCardAmount.TabIndex = 8;
            this.textBoxCardAmount.Text = "0";
            // 
            // textBoxBonusAmount
            // 
            this.textBoxBonusAmount.Location = new System.Drawing.Point(320, 120);
            this.textBoxBonusAmount.Name = "textBoxBonusAmount";
            this.textBoxBonusAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxBonusAmount.TabIndex = 9;
            this.textBoxBonusAmount.Text = "0";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(50, 160);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(196, 30);
            this.buttonPay.TabIndex = 10;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(270, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(220, 30);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(50, 200);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(81, 16);
            this.labelRemaining.TabIndex = 12;
            this.labelRemaining.Text = "Остаток: 0₽";
            // 
            // buttonCashMax
            // 
            this.buttonCashMax.Location = new System.Drawing.Point(430, 60);
            this.buttonCashMax.Name = "buttonCashMax";
            this.buttonCashMax.Size = new System.Drawing.Size(60, 22);
            this.buttonCashMax.TabIndex = 13;
            this.buttonCashMax.Text = "MAX";
            this.buttonCashMax.UseVisualStyleBackColor = true;
            // 
            // buttonCardMax
            // 
            this.buttonCardMax.Location = new System.Drawing.Point(430, 90);
            this.buttonCardMax.Name = "buttonCardMax";
            this.buttonCardMax.Size = new System.Drawing.Size(60, 22);
            this.buttonCardMax.TabIndex = 14;
            this.buttonCardMax.Text = "MAX";
            this.buttonCardMax.UseVisualStyleBackColor = true;
            // 
            // buttonBonusMax
            // 
            this.buttonBonusMax.Location = new System.Drawing.Point(430, 120);
            this.buttonBonusMax.Name = "buttonBonusMax";
            this.buttonBonusMax.Size = new System.Drawing.Size(60, 22);
            this.buttonBonusMax.TabIndex = 15;
            this.buttonBonusMax.Text = "MAX";
            this.buttonBonusMax.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 316);
            this.Controls.Add(this.buttonBonusMax);
            this.Controls.Add(this.buttonCardMax);
            this.Controls.Add(this.buttonCashMax);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxBonusAmount);
            this.Controls.Add(this.textBoxCardAmount);
            this.Controls.Add(this.textBoxCashAmount);
            this.Controls.Add(this.labelBonusBalance);
            this.Controls.Add(this.labelCardBalance);
            this.Controls.Add(this.labelCashBalance);
            this.Controls.Add(this.radioBonus);
            this.Controls.Add(this.radioCard);
            this.Controls.Add(this.radioCash);
            this.Controls.Add(this.labelTotalAmount);
            this.Name = "PaymentForm";
            this.Text = "Оплата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.RadioButton radioCard;
        private System.Windows.Forms.RadioButton radioBonus;
        private System.Windows.Forms.Label labelCashBalance;
        private System.Windows.Forms.Label labelCardBalance;
        private System.Windows.Forms.Label labelBonusBalance;
        private System.Windows.Forms.TextBox textBoxCashAmount;
        private System.Windows.Forms.TextBox textBoxCardAmount;
        private System.Windows.Forms.TextBox textBoxBonusAmount;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Button buttonCashMax;
        private System.Windows.Forms.Button buttonCardMax;
        private System.Windows.Forms.Button buttonBonusMax;
    }
}