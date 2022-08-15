using ContactBook.Models;
using ContactBook.Resources;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ContactBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.TypeContacts = Common.Instance.Entities.TYPECONTACT.ToList();
            ViewBag.SexualityList = Common.Instance.Entities.SEXUALITY.ToList();
            ViewBag.MaritalStatusList = Common.Instance.Entities.MARITALSTATUS.ToList();
            ViewBag.Contacts = Common.Instance.Entities.CONTACTS.SqlQuery("getContacts").ToList();
            return View();
        }

        public async Task<ActionResult> addContact(CONTACTS newContact)
        {
            Common.Instance.Entities.CONTACTS.Add(newContact);
            await Common.Instance.Entities.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<ActionResult> updateContact(CONTACTS editedContact)
        {
            Common.Instance.Entities.CONTACTS.AddOrUpdate(editedContact);
            await Common.Instance.Entities.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<ActionResult> deleteContact(deleteContacts deletedContact)
        {
            CONTACTS contactedDeleted = Common.Instance.Entities.CONTACTS.FirstOrDefault(contact => contact.Id == deletedContact.Id);
            Common.Instance.Entities.CONTACTS.Remove(contactedDeleted);
            await Common.Instance.Entities.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
      
    }
}