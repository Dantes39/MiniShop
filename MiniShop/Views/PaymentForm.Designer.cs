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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(49, 60);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(116, 16);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "Сумма к оплате: ";
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Location = new System.Drawing.Point(52, 89);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(104, 20);
            this.radioCash.TabIndex = 1;
            this.radioCash.Text = "Наличными";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioCard
            // 
            this.radioCard.AutoSize = true;
            this.radioCard.Location = new System.Drawing.Point(52, 119);
            this.radioCard.Name = "radioCard";
            this.radioCard.Size = new System.Drawing.Size(75, 20);
            this.radioCard.TabIndex = 2;
            this.radioCard.Text = "Картой";
            this.radioCard.UseVisualStyleBackColor = true;
            // 
            // radioBonus
            // 
            this.radioBonus.AutoSize = true;
            this.radioBonus.Location = new System.Drawing.Point(52, 149);
            this.radioBonus.Name = "radioBonus";
            this.radioBonus.Size = new System.Drawing.Size(93, 20);
            this.radioBonus.TabIndex = 3;
            this.radioBonus.Text = "Бонусами";
            this.radioBonus.UseVisualStyleBackColor = true;
            // 
            // labelCashBalance
            // 
            this.labelCashBalance.AutoSize = true;
            this.labelCashBalance.Location = new System.Drawing.Point(173, 89);
            this.labelCashBalance.Name = "labelCashBalance";
            this.labelCashBalance.Size = new System.Drawing.Size(75, 16);
            this.labelCashBalance.TabIndex = 4;
            this.labelCashBalance.Text = "Баланс: 0₽";
            // 
            // labelCardBalance
            // 
            this.labelCardBalance.AutoSize = true;
            this.labelCardBalance.Location = new System.Drawing.Point(173, 119);
            this.labelCardBalance.Name = "labelCardBalance";
            this.labelCardBalance.Size = new System.Drawing.Size(75, 16);
            this.labelCardBalance.TabIndex = 5;
            this.labelCardBalance.Text = "Баланс: 0₽";
            // 
            // labelBonusBalance
            // 
            this.labelBonusBalance.AutoSize = true;
            this.labelBonusBalance.Location = new System.Drawing.Point(173, 149);
            this.labelBonusBalance.Name = "labelBonusBalance";
            this.labelBonusBalance.Size = new System.Drawing.Size(68, 16);
            this.labelBonusBalance.TabIndex = 6;
            this.labelBonusBalance.Text = "Баланс: 0";
            // 
            // textBoxCashAmount
            // 
            this.textBoxCashAmount.Location = new System.Drawing.Point(277, 88);
            this.textBoxCashAmount.Name = "textBoxCashAmount";
            this.textBoxCashAmount.Size = new System.Drawing.Size(126, 22);
            this.textBoxCashAmount.TabIndex = 7;
            this.textBoxCashAmount.Text = "0";
            // 
            // textBoxCardAmount
            // 
            this.textBoxCardAmount.Location = new System.Drawing.Point(277, 118);
            this.textBoxCardAmount.Name = "textBoxCardAmount";
            this.textBoxCardAmount.Size = new System.Drawing.Size(126, 22);
            this.textBoxCardAmount.TabIndex = 8;
            this.textBoxCardAmount.Text = "0";
            // 
            // textBoxBonusAmount
            // 
            this.textBoxBonusAmount.Location = new System.Drawing.Point(277, 148);
            this.textBoxBonusAmount.Name = "textBoxBonusAmount";
            this.textBoxBonusAmount.Size = new System.Drawing.Size(126, 22);
            this.textBoxBonusAmount.TabIndex = 9;
            this.textBoxBonusAmount.Text = "0";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPay.Location = new System.Drawing.Point(52, 189);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(196, 30);
            this.buttonPay.TabIndex = 10;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancel.Location = new System.Drawing.Point(277, 189);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(196, 30);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(52, 229);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(81, 16);
            this.labelRemaining.TabIndex = 12;
            this.labelRemaining.Text = "Остаток: 0₽";
            // 
            // buttonCashMax
            // 
            this.buttonCashMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCashMax.Location = new System.Drawing.Point(413, 88);
            this.buttonCashMax.Name = "buttonCashMax";
            this.buttonCashMax.Size = new System.Drawing.Size(60, 22);
            this.buttonCashMax.TabIndex = 13;
            this.buttonCashMax.Text = "MAX";
            this.buttonCashMax.UseVisualStyleBackColor = false;
            // 
            // buttonCardMax
            // 
            this.buttonCardMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCardMax.Location = new System.Drawing.Point(413, 118);
            this.buttonCardMax.Name = "buttonCardMax";
            this.buttonCardMax.Size = new System.Drawing.Size(60, 22);
            this.buttonCardMax.TabIndex = 14;
            this.buttonCardMax.Text = "MAX";
            this.buttonCardMax.UseVisualStyleBackColor = false;
            // 
            // buttonBonusMax
            // 
            this.buttonBonusMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBonusMax.Location = new System.Drawing.Point(413, 148);
            this.buttonBonusMax.Name = "buttonBonusMax";
            this.buttonBonusMax.Size = new System.Drawing.Size(60, 22);
            this.buttonBonusMax.TabIndex = 15;
            this.buttonBonusMax.Text = "MAX";
            this.buttonBonusMax.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(217, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ОПЛАТА";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(522, 286);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}