namespace MiniShop.Views
{
    partial class AddProductForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerExpiration = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxWeighable = new System.Windows.Forms.CheckBox();
            this.numericUpDownMinWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.labelMinWeight = new System.Windows.Forms.Label();
            this.labelMaxWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(206, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(15, 77);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(206, 22);
            this.numericUpDownPrice.TabIndex = 1;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(15, 132);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(206, 22);
            this.numericUpDownQuantity.TabIndex = 2;
            // 
            // dateTimePickerExpiration
            // 
            this.dateTimePickerExpiration.Location = new System.Drawing.Point(15, 183);
            this.dateTimePickerExpiration.Name = "dateTimePickerExpiration";
            this.dateTimePickerExpiration.Size = new System.Drawing.Size(206, 22);
            this.dateTimePickerExpiration.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSave.Location = new System.Drawing.Point(15, 284);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(206, 62);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Добавить Продукт";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(253, 28);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(300, 177);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUploadPhoto.Location = new System.Drawing.Point(253, 284);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(300, 62);
            this.buttonUploadPhoto.TabIndex = 6;
            this.buttonUploadPhoto.Text = "Загрузить Фото";
            this.buttonUploadPhoto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Срок годности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фото";
            // 
            // checkBoxWeighable
            // 
            this.checkBoxWeighable.AutoSize = true;
            this.checkBoxWeighable.Location = new System.Drawing.Point(15, 241);
            this.checkBoxWeighable.Name = "checkBoxWeighable";
            this.checkBoxWeighable.Size = new System.Drawing.Size(204, 20);
            this.checkBoxWeighable.TabIndex = 13;
            this.checkBoxWeighable.Text = "Необходиость взвешивать";
            this.checkBoxWeighable.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMinWeight
            // 
            this.numericUpDownMinWeight.Location = new System.Drawing.Point(253, 241);
            this.numericUpDownMinWeight.Name = "numericUpDownMinWeight";
            this.numericUpDownMinWeight.Size = new System.Drawing.Size(122, 22);
            this.numericUpDownMinWeight.TabIndex = 14;
            this.numericUpDownMinWeight.Visible = false;
            // 
            // numericUpDownMaxWeight
            // 
            this.numericUpDownMaxWeight.Location = new System.Drawing.Point(426, 241);
            this.numericUpDownMaxWeight.Name = "numericUpDownMaxWeight";
            this.numericUpDownMaxWeight.Size = new System.Drawing.Size(123, 22);
            this.numericUpDownMaxWeight.TabIndex = 15;
            this.numericUpDownMaxWeight.Visible = false;
            // 
            // labelMinWeight
            // 
            this.labelMinWeight.AutoSize = true;
            this.labelMinWeight.Location = new System.Drawing.Point(251, 219);
            this.labelMinWeight.Name = "labelMinWeight";
            this.labelMinWeight.Size = new System.Drawing.Size(122, 16);
            this.labelMinWeight.TabIndex = 16;
            this.labelMinWeight.Text = "MIN вес продукта";
            this.labelMinWeight.Visible = false;
            // 
            // labelMaxWeight
            // 
            this.labelMaxWeight.AutoSize = true;
            this.labelMaxWeight.Location = new System.Drawing.Point(423, 219);
            this.labelMaxWeight.Name = "labelMaxWeight";
            this.labelMaxWeight.Size = new System.Drawing.Size(126, 16);
            this.labelMaxWeight.TabIndex = 17;
            this.labelMaxWeight.Text = "MAX вес продукта";
            this.labelMaxWeight.Visible = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(565, 388);
            this.Controls.Add(this.labelMaxWeight);
            this.Controls.Add(this.labelMinWeight);
            this.Controls.Add(this.numericUpDownMaxWeight);
            this.Controls.Add(this.numericUpDownMinWeight);
            this.Controls.Add(this.checkBoxWeighable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUploadPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerExpiration);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiration;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxWeighable;
        private System.Windows.Forms.NumericUpDown numericUpDownMinWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxWeight;
        private System.Windows.Forms.Label labelMinWeight;
        private System.Windows.Forms.Label labelMaxWeight;
    }
}