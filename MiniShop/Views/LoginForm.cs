using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniShop.Models;
using MiniShop.Presenters;

namespace MiniShop.Views
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter presenter;
        private DataModel dataModel;

        public LoginForm(DataModel dataModel)
        {
            this.Name = "LoginForm";
            this.dataModel = dataModel;
            InitializeComponent();
            presenter = new LoginPresenter(this, dataModel);
            btnLogin.Click += (s, e) => presenter.HandleLogin();
            WireUpEvents();
        }

        public string Phone => txtPhone.Text.Trim();
        public string Password => txtPassword.Text.Trim();
        public bool IsRegisterChecked => chkRegister.Checked;
        
        public string NameClient => txtName.Text.Trim();
        public string SurnameClient => txtSurname.Text.Trim();


        public bool IsAdmin { get; set; }
        public Client LoggedInClient { get; set; }

        public void WireUpEvents()
        {
            chkRegister.Click += (s, e) =>
            {
                if (chkRegister.Checked)
                {
                    txtName.Visible = true;
                    txtSurname.Visible = true;
                    labelName.Visible = true;
                    labelSurname.Visible = true;
                }
                else
                {
                    txtName.Visible = false;
                    txtSurname.Visible = false;
                    labelName.Visible = false;
                    labelSurname.Visible = false;
                }
            };
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CloseForm(DialogResult result)
        {
            this.DialogResult = result;
            this.Close();
        }
    }
}
