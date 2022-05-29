using System;
using System.Collections.Generic;
using System.Text;
using DispatcherClient.Services;
using DispatcherClient.Services.Interfaces;
using FreshMvvm;
using Xamarin.Forms;

namespace DispatcherClient.PageModels
{
    internal class RegistrationPageModel : FreshBasePageModel
    {
        #region Поля

        private readonly ICustomNotification _notification;
        private readonly DataBaseConnection _dbConnection;
        private string _login;
        private string _password;

        #endregion

        #region Свойства

        public string Login
        {
            get => _login;
            set
            {
                if (_login != value)
                    _login = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                    _password = value;
            }
        }

        #endregion

        #region Команды

        public Command RegistrationCommand { get; set; }

        #endregion

        #region Методы

        private void SetCommands()
        {
            RegistrationCommand = new Command(async () =>
            {
                if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
                {
                    await _dbConnection.AddAccount(Login, Password);
                    await CoreMethods.PushPageModel<MainPageModel>(null, true);
                }
                else
                    _notification.Send("Ошибка", "Не удалось зарегестрировать аккаунт");
            });
        }

        #endregion

        public RegistrationPageModel()
        {
            SetCommands();

            _notification = DependencyService.Get<ICustomNotification>();
            _dbConnection = new DataBaseConnection(_notification);
        }
    }
}
