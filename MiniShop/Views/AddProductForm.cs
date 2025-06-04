using System;
using System.Windows.Forms;

namespace MiniShop.Views
{
    public partial class AddProductForm : Form, IAddProductView
    {
        public event Action OnSaveProductClicked;

        private string selectedImagePath = "";

        public string ProductTitle => textBoxName.Text;
        public float ProductPrice => (float)numericUpDownPrice.Value;
        public int ProductQuantity => (int)numericUpDownQuantity.Value;
        public DateTime ProductExpiration => dateTimePickerExpiration.Value;
        public string ProductPhotoPath => selectedImagePath;
        public bool IsWeighable => checkBoxWeighable.Checked;
        public int[] Weight => new int[2] { (int)numericUpDownMinWeight.Value, (int)numericUpDownMaxWeight.Value };

        public AddProductForm()
        {
            InitializeComponent();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            buttonUploadPhoto.Click += (s, e) =>
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Images|*.jpg;*.jpeg;*.png";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedImagePath = dialog.FileName;
                        pictureBoxPhoto.ImageLocation = dialog.FileName;
                    }
                }
            };
            buttonSave.Click += (s, e) => OnSaveProductClicked?.Invoke();

            checkBoxWeighable.Click += (s, e) =>
            {
                if (checkBoxWeighable.Checked)
                {
                    numericUpDownMinWeight.Visible = true;
                    numericUpDownMaxWeight.Visible = true;
                    labelMinWeight.Visible = true;
                    labelMaxWeight.Visible = true;
                }
                else
                {
                    numericUpDownMinWeight.Visible = false;
                    numericUpDownMaxWeight.Visible = false;
                    labelMinWeight.Visible = false;
                    labelMaxWeight.Visible = false;
                }
            };
        }

        public void CloseView()
        {
            Close();
        }
    }
}
