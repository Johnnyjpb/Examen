using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationRegister.Model
{
    public class UserModel
    {
        #region Variables that has the class public and private
        private string _name;
        private string _email;
        private string _password;

        public string name { get { return _name; } set { if (_name != value) { _name = value; } } }
        public string email { get { return _email; } set { if (_email != value) { _email = value; } } }
        public string password { get { return _password; } set { if(_password != value) { _password = value; } } }
        #endregion

        #region Methods of the class that make communication with database
        /// <summary>
        /// This method will connect to the database, register an user and bring an answer from it. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns> string </returns>
        public static string registerUserModel(string name, string email, string password)
        {
            string userRegistered = "No se pudo conectar";
            using (var conn = Conexion.ObjetoConexion.getconexion("ProServer", "IntelisisTmp"))
            {
                conn.Open();
                using (var command = new SqlCommand("SpInsertUser", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nickmane", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    var response = command.ExecuteReader();
                    if (!response.HasRows) return "No se pudo conectar";
                    while(response.Read())
                    {
                        userRegistered = response["Message"].ToString();
                    }
                }
                conn.Close();
            }
            return userRegistered;
        }

        /// <summary>
        /// This method will return the nickname if the user was found if not will return an empty
        /// string, IMPORTANT: The password has to be already encrypted.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns> string </returns>
        public static string toValidateLogIn(string email, string password)
        {
            string query = "SELECT Nickname FROM LMCPROYDUser WHERE Email = @Email AND Password = @Password";
            using (var conn = Conexion.ObjetoConexion.getconexion("ProServer", "IntelisisTmp"))
            {
                conn.Open();
                using (var command = new SqlCommand(query, conn))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    var response = command.ExecuteReader();
                    if (!response.HasRows) return "";
                    while (response.Read())
                    {
                        return response["Nickname"].ToString();
                    }
                }
                conn.Close();
            }
            return "";
        }

        /// <summary>
        /// This method return all the users -> Id and Nickname
        /// </summary>
        /// <returns> List </returns>
        public static List<string[]> toGetAllUser()
        {
            List<string[]> responseTo = new List<string[]>();
            string query = "SELECT IdUser, Nickname FROM LMCPROYDUser";
            using(var conn = Conexion.ObjetoConexion.getconexion("ProServer", "IntelisisTmp"))
            {
                conn.Open();
                using (var command = new SqlCommand(query, conn))
                {
                    command.CommandType = System.Data.CommandType.Text;

                    var response = command.ExecuteReader();
                    if (!response.HasRows) return null;
                    while (response.Read())
                    {
                        responseTo.Add(new string[]
                        {
                            response["IdUser"].ToString(),
                            response["Nickname"].ToString()
                        });
                    }
                }
                conn.Close();
            }
            return responseTo;
        }

        #endregion

    }
}
