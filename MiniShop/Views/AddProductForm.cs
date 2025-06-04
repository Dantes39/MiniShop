using System;
using System.Windows.Forms;

namespace MiniShop.Views
{
    public partial class AddProductForm : Form, IAddProductView
    {
        public event Action OnSaveProductClicked;

        private string selectedImagePath = "";

        public string ProductTitle => textBoxName.Text;
        public decimal ProductPrice => numericUpDownPrice.Value;
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
        }

        public void CloseView()
        {
            Close();
        }
    }
}
