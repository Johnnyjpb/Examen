using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApplicationRegister.Model
{
    public class ContactModel
    {
        #region Variables that has the class public and private
        private string _telephone;
        private string _idUser;

        public string telephone { get { return _telephone; } set { if (_telephone != value) { _telephone = value; } } }
        public string idUser { get { return _idUser; } set { if (_idUser != value) { _idUser = value; } } }

        #endregion

        #region Those methods bring information from database
        /// <summary>
        /// This method bring all the contacts in an array - List and if there was
        /// anything it will return empty or null, controller must validate
        /// </summary>
        /// <returns> List </returns>
        public static List<string[]> toGetContacts()
        {
            List<string[]> answerList = new List<string[]>();
            string query = "SELECT IdContact, Nickname, Telephone, Email FROM LMCPROYDContact AS Contacts JOIN LMCPROYDUser AS Users ON Contacts.IdUser = Users.IdUser";
            using(var conn = Conexion.ObjetoConexion.getconexion("ProServer", "IntelisisTmp"))
            {
                conn.Open();
                using (var command = new SqlCommand(query, conn))
                {
                    command.CommandType = System.Data.CommandType.Text;

                    var response = command.ExecuteReader();
                    if (!response.HasRows) return null;
                    while(response.Read())
                    {
                        answerList.Add(new string[]
                        {
                            response["IdContact"].ToString(),
                            response["Nickname"].ToString(),
                            response["Email"].ToString(),
                            response["Telephone"].ToString()
                        });
                    }
                }
                conn.Close();
            }
            return answerList;
        }

        #endregion

        #region These methods send information to database
        /// <summary>
        /// This method register a contact and return true,
        /// if not will return false
        /// </summary>
        /// <param name="telephone"></param>
        /// <param name="IdUser"></param>
        /// <returns>false</returns>
        public static bool toRegisterContact(string telephone, int IdUser)
        {
            try
            {
                bool sucessRegister = false;
                using (var conn = Conexion.ObjetoConexion.getconexion("ProServer", "IntelisisTmp"))
                {
                    conn.Open();
                    using (var command = new SqlCommand("SpInsertContact", conn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Telephone", telephone);
                        command.Parameters.AddWithValue("@IdUser", IdUser);

                        sucessRegister = command.ExecuteNonQuery().Equals(1);
                        
                    }
                    conn.Close();
                }
                return sucessRegister;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method is to delete some contact by IdContact
        /// </summary>
        /// <param name="IdContact"></param>
        /// <returns> bool </returns>
        public static bool toDeleteContact(int IdContact)
        {
            bool isDeleted = false;
            string query = "DELETE FROM LMCPROYDContact WHERE IdContact = @IdContact";
            using (var conn = Conexion.ObjetoConexion.getconexion("ProServer", "IntelisisTmp"))
            {
                conn.Open();
                using (var command = new SqlCommand(query, conn))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@IdContact", IdContact);
                    isDeleted = command.ExecuteNonQuery().Equals(1);
                }
                conn.Close();
            }
            return isDeleted;
        }
        #endregion

    }
}
