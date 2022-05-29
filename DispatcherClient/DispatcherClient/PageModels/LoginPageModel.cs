using System;
using System.Collections.Generic;
using System.Text;
using DispatcherClient.Services;
using DispatcherClient.Services.Interfaces;
using FreshMvvm;
using Xamarin.Forms;

namespace DispatcherClient.PageModels
{
    internal class LoginPageModel : FreshBasePageModel
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

        public Command RegistrationOpenCommand { get; set; }
        public Command EnterInAccountCommand { get; set; }

        #endregion

        #region Методы

        private void SetCommands()
        {
            EnterInAccountCommand = new Command(async () =>
            {
                if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
                {
                    if (await _dbConnection.CheckAccountAsync(Login, Password))
                        await CoreMethods.PushPageModel<MainPageModel>(null, true);
                    else
                        _notification.Send("Ошибка", "Аккаунт не был найден");
                }
                else
                {
                    _notification.Send("Ошибка", "Введите данные аккаунта");
                }
                
            });

            RegistrationOpenCommand = new Command(async () =>
            {
                await CoreMethods.PushPageModel<RegistrationPageModel>();
            });
        }

        #endregion

        public LoginPageModel()
        {
            SetCommands();

            _notification = DependencyService.Get<ICustomNotification>();
            _dbConnection = new DataBaseConnection(_notification);
        }
    }
}
