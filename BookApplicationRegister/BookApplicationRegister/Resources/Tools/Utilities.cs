using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookApplicationRegister.Resources.Tools
{
    public static class Utilities
    {
        #region Methods to encrypt and descrypt data
        /// <summary>
        /// This method will help you to encrypt your string with sha256
        /// </summary>
        /// <param name="password"></param>
        /// <returns> string </returns>
        public static string toEncrypt(this string password)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(password));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
        #endregion

        #region Methods to validate inputs
        /// <summary>
        /// This method will validate if the input email is correct if not
        /// will return false and an alert and also if it is correct a true and an alert
        /// </summary>
        /// <param name="email"></param>
        /// <param name="error"></param>
        /// <param name="correct"></param>
        /// <returns> bool </returns>
        public static bool toValidateEmail(this Control email, ErrorProvider error, ErrorProvider correct)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email.Text);
            if (!match.Success) 
            {
                correct.SetError(email, "");
                error.SetError(email, "No ingreso correctamente el email"); 
                return false; 
            }
            error.SetError(email, "");
            correct.SetError(email, "Correo escrito correctamente");
            return true;
        }

        /// <summary>
        /// This function validate the length of inputs, and throw true or false and an alert after 
        /// it has been validated
        /// </summary>
        /// <param name="input"></param>
        /// <param name="error"></param>
        /// <param name="correct"></param>
        /// <param name="kind"></param>
        /// <returns> bool </returns>
        public static bool toValidateInputLength(this Control input, ErrorProvider error, ErrorProvider correct, string kind)
        {
            if(input.Text.Length < 5)
            {
                correct.SetError(input, "");
                error.SetError(input, kind + " muy corto");
                return false;
            }
            error.SetError(input, "");
            correct.SetError(input, kind + " escrito correctamente");
            return true;
        }

        /// <summary>
        /// this method will clean inputs
        /// </summary>
        /// <param name="input"></param>
        /// <param name="error"></param>
        /// <param name="correct"></param>
        public static void toDeleteValidation(this Control input, ErrorProvider error, ErrorProvider correct )
        {
            error.SetError(input, "");
            correct.SetError(input, "");
            input.Text = null;
        }

        #endregion

        #region Methods to put in danger inputs
        /// <summary>
        /// This method throws an error in your input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="error"></param>
        public static void toDanger(this Control input, ErrorProvider error, ErrorProvider correct)
        {
            correct.SetError(input, "");
            error.SetError(input, "Credenciales incorrectas");
            input.Text = "";
        }

        #endregion

        #region Methods to write in a datagridview
        /// <summary>
        /// This method will write the headers of a datagridview,
        /// Important -> at least one letter uppercase.
        /// </summary>
        /// <param name="datagridview"></param>
        /// <param name="headers"></param>
        public static void writeDataGridHeaders(this DataGridView datagridview, List<string> headers)
        {
            headers.ForEach((header) =>
            {
                datagridview.Columns.Add(header.ToLower(), header);
            });
        }

        /// <summary>
        /// This method will write all the rows to datagridview, 
        /// Important -> this function just receive List with string array data
        /// </summary>
        /// <param name="datagridview"></param>
        /// <param name="datagridrows"></param>
        public static void writeDataGridRows(this DataGridView datagridview, List<string[]> datagridrows )
        {
            datagridview.Rows.Clear();
            datagridrows.ForEach((row) =>
            {
                datagridview.Rows.Add(row.GetValue(0), row.GetValue(1), row.GetValue(2), row.GetValue(3));
            });
        }

        #endregion

        #region Methods of combobox
        /// <summary>
        /// This method throws a list of nicknames 
        /// </summary>
        /// <param name="usersList"></param>
        /// <returns> List </returns>
        public static List<string> toGetUsersNickname(this List<String[]> usersList)
        {
            List<string> listOfNicknames = new List<string>();
            usersList.ForEach((array) =>
            {
                listOfNicknames.Add(array[1]);
            });
            return listOfNicknames;
        }

        #endregion

        #region Filter data on lists
        /// <summary>
        /// This method return the id of the user selected in Nickname
        /// </summary>
        /// <param name="listOfUsers"></param>
        /// <param name="Nickname"></param>
        /// <returns> int </returns>
        public static int getIdOfUsers(this List<string[]> listOfUsers, string Nickname)
        {
            int IdUser = 0;
            listOfUsers.ForEach((array) =>
            {
                if (array.GetValue(1).ToString() == Nickname) IdUser = Int32.Parse(array.GetValue(0).ToString());
            });
            return IdUser;
        }

        /// <summary>
        /// This method filter and return a contact by Id
        /// </summary>
        /// <param name="contactList"></param>
        /// <param name="IdUser"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactById(this List<string[]> contactList, int IdUser)
        {
            List<string[]> arraySelected = new List<string[]>();
            contactList.ForEach((array) =>
            {
                if (array.GetValue(0).ToString() == IdUser.ToString()) 
                { 
                    arraySelected.Add(new string[] 
                    {
                        array.GetValue(0).ToString(),
                        array.GetValue(1).ToString(),
                        array.GetValue(2).ToString(),
                        array.GetValue(3).ToString()
                    }); 
                }
            });
            return arraySelected;
        }

        /// <summary>
        /// This method filter and return by Email
        /// </summary>
        /// <param name="contactList"></param>
        /// <param name="email"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactByEmail(this List<string[]> contactList, string email)
        {
            List<string[]> arraySelected = new List<string[]>();
            contactList.ForEach((array) =>
            {
                if (array.GetValue(2).ToString() == email)
                {
                    arraySelected.Add(new string[]
                    {
                        array.GetValue(0).ToString(),
                        array.GetValue(1).ToString(),
                        array.GetValue(2).ToString(),
                        array.GetValue(3).ToString()
                    });
                }
            });
            return arraySelected;
        }

        /// <summary>
        /// This method filter and return by telephone
        /// </summary>
        /// <param name="contactList"></param>
        /// <param name="telephone"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactByTelephone(this List<string[]> contactList, string telephone)
        {
            List<string[]> arraySelected = new List<string[]>();
            contactList.ForEach((array) =>
            {
                if (array.GetValue(3).ToString() == telephone)
                {
                    arraySelected.Add(new string[]
                    {
                        array.GetValue(0).ToString(),
                        array.GetValue(1).ToString(),
                        array.GetValue(2).ToString(),
                        array.GetValue(3).ToString()
                    });
                }
            });
            return arraySelected;
        }

        /// <summary>
        /// This method filter and return by Nickname
        /// </summary>
        /// <param name="contactList"></param>
        /// <param name="nickname"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactByNickname(this List<string[]> contactList, string nickname)
        {
            List<string[]> arraySelected = new List<string[]>();
            contactList.ForEach((array) =>
            {
                if (array.GetValue(1).ToString() == nickname)
                {
                    arraySelected.Add(new string[]
                    {
                        array.GetValue(0).ToString(),
                        array.GetValue(1).ToString(),
                        array.GetValue(2).ToString(),
                        array.GetValue(3).ToString()
                    });
                }
            });
            return arraySelected;
        }

        #endregion

    }
}
