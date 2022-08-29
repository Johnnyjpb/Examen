using BookApplicationRegister.Model;
using BookApplicationRegister.Resources.Tools;
using BookApplicationRegister.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationRegister.Controller
{
    public static class MainController
    {
        #region Change screen to another
        /// <summary>
        /// This method will change the screen to login
        /// </summary>
        /// <param name="register"></param>
        public static void changeToLogin(Main register)
        {
            MainLogin login = new MainLogin();
            login.Show();
            register.Close();
        }

        /// <summary>
        /// This method will change the screen to register
        /// </summary>
        /// <param name="login"></param>
        public static void changeToRegister(MainLogin login)
        {
            Main register = new Main();
            register.Show();
            login.Close();
        }

        /// <summary>
        /// This method just can be call by this controller
        /// and is to change the screen to a login screen
        /// </summary>
        /// <param name="login"></param>
        /// <param name="nickname"></param>
        private static void _changeToDashboard(MainLogin login, string nickname)
        {
            Dashboard dashboard = new Dashboard(nickname);
            dashboard.Show();
            login.Close();
        }

        #endregion

        #region Send information from user to database
        /// <summary>
        /// This controller method ask the userModel to register an user
        /// and after that receives an answer from the server if it was registered.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns> string </returns>
        public static string saveUser(string name, string email, string password)
        {
            return UserModel.registerUserModel(name, email, password.toEncrypt());
        }

        /// <summary>
        /// This method is in charge of the login if exists the user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="login"></param>
        /// <returns>string</returns>
        public static string toLogInUser(string email, string password, MainLogin login)
        {
            string toValidateString = UserModel.toValidateLogIn(email, password.toEncrypt());
            if (string.IsNullOrEmpty(toValidateString)) return "Usuario o contraseña incorrectos";
            _changeToDashboard(login, toValidateString);
            return "Entrada Exitosa!!!";
        }

        #endregion

    }
}
