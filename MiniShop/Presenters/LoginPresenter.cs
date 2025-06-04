using MiniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniShop.Views;

namespace MiniShop.Presenters
{
    internal class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly DataModel dataModel;
        private const string AdminPhone = "admin";
        private const string AdminPassword = "admin123";

        public LoginPresenter(ILoginView view, DataModel dataModel)
        {
            this.view = view;
            this.dataModel = dataModel;
        }

        public void HandleLogin()
        {
            string phone = view.Phone;
            string password = view.Password;
            string name = view.Name;
            string surname = view.Surname;

            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                view.ShowError("Пожалуйста, заполните все поля.");
                return;
            }

            if (view.IsRegisterChecked)
            {
                if (dataModel.Clients.Any(c => c.Phone == phone))
                {
                    view.ShowError("Этот номер уже зарегистрирован.");
                    return;
                }

                var newClient = new Client
                {
                    ID = dataModel.Clients.Any() ? dataModel.Clients.Max(c => c.ID) + 1 : 1,
                    Phone = phone,
                    Name = name,
                    Surname = surname,
                    Address = "Не указан",
                    Password = password
                };
                dataModel.Clients.Add(newClient);
                dataModel.SaveData();
                view.LoggedInClient = newClient;
                view.IsAdmin = false;
                view.ShowSuccess("Регистрация успешна! Вы вошли как клиент. \n" +
                    $"Добро пожаловать {newClient.Name} {newClient.Surname}");
                view.ShowSuccess("За успешную первую регистрацию дарим 100 бонусов!");
                view.CloseForm(DialogResult.OK);
            }
            else
            {
                if (phone == AdminPhone && password == AdminPassword)
                {
                    view.IsAdmin = true;
                    view.LoggedInClient = null;
                    view.ShowSuccess("Вход выполнен как администратор.");
                    view.CloseForm(DialogResult.OK);
                    return;
                }

                var client = dataModel.Clients.FirstOrDefault(c => c.Phone == phone);
                if (client == null)
                {
                    view.ShowError("Номер не зарегистрирован в системе.");
                    return;
                }

                if (client.Password != password)
                {
                    view.ShowError("Неверный пароль.");
                    return;
                }

                view.LoggedInClient = client;
                view.IsAdmin = false;
                view.ShowSuccess($"С возращением {client.Name} {client.Surname}!");
                view.CloseForm(DialogResult.OK);
            }
        }
    }
}
