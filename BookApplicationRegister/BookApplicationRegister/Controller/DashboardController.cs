using BookApplicationRegister.Model;
using BookApplicationRegister.Resources.Tools;
using BookApplicationRegister.View;
using BookApplicationRegister.View.MessageDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplicationRegister.Controller
{
    public static class DashboardController
    {
        #region Methods to show MessageDialogs
        /// <summary>
        /// This method will show the form Register to upload a contact
        /// </summary>
        public static void toShowRegisterDialog()
        {
            DashRegisterContact registerContact = new DashRegisterContact();
            registerContact.ShowDialog();
        }

        /// <summary>
        /// This method will show the search form to look for a contact
        /// </summary>
        public static void toShowSearchDialog()
        {
            DashSearchContact searchContact = new DashSearchContact();
            searchContact.ShowDialog();
        }

        /// <summary>
        /// This method will show the delete form to delete a contact
        /// </summary>
        /// <param name="dataIdContact"></param>
        public static void toShowDeleteDialog(string dataIdContact)
        {
            DashSureDeleteContact deleteContact = new DashSureDeleteContact(dataIdContact);
            deleteContact.ShowDialog();
        }

        #endregion

        #region Bring information from database
        /// <summary>
        /// This method brings the contacts from database or null or empty if it
        /// was anything
        /// </summary>
        /// <returns> List </returns>
        public static List<string[]> askToBringContacts()
        {
            return ContactModel.toGetContacts();
        }

        /// <summary>
        /// This method brings the contacts from database or null or empty if it
        /// was anything
        /// </summary>
        /// <returns> List </returns>
        public static List<string[]> askToBringAllUsers()
        {
            return UserModel.toGetAllUser();
        }

        #endregion

        #region Send information to database
        /// <summary>
        /// This method controller register a contact
        /// </summary>
        /// <param name="Telephone"></param>
        /// <param name="Nickname"></param>
        /// <returns> string </returns>
        public static string toRegisterContact(string Telephone, string Nickname)
        {
            bool wasRegistered = ContactModel.toRegisterContact(Telephone, UserModel.toGetAllUser().getIdOfUsers(Nickname));
            if (wasRegistered) return "Registro Exitoso!!!";
            return "Contacto sin poder registrarse!!!";
        }

        /// <summary>
        /// Method in controller to delete a contact
        /// </summary>
        /// <param name="IdContact"></param>
        /// <returns> string </returns>
        public static string toDeleteContact(int IdContact)
        {
            if (ContactModel.toDeleteContact(IdContact)) return "La eliminación fue exitosa!!!";
            return "Algo paso durante la eliminación";
        }

        #endregion

        #region Filter information that came from database
        /// <summary>
        /// This method bring data by Id
        /// </summary>
        /// <param name="idContact"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactById(int idContact)
        {
            return ContactModel.toGetContacts().getContactById(idContact);
        }

        /// <summary>
        /// This method bring data by Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactByEmail(string email)
        {
            return ContactModel.toGetContacts().getContactByEmail(email);
        }

        /// <summary>
        /// This method bring data by Telephone
        /// </summary>
        /// <param name="telephone"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactByTelephone(string telephone)
        {
            return ContactModel.toGetContacts().getContactByTelephone(telephone);
        }

        /// <summary>
        /// This method bring data by Nickname
        /// </summary>
        /// <param name="nickname"></param>
        /// <returns> List </returns>
        public static List<string[]> getContactByNickname(string nickname)
        {
            return ContactModel.toGetContacts().getContactByNickname(nickname);
        }

        #endregion

    }
}
