using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace MvcContacts.Models
{
    public class EntityContactManagerRepository : IContactRepository
    {
        private MvcContacts.ContactEntities _db = new ContactEntities();
        public void CreateContact(Contacts contact)
        {
            _db.Contacts.Add(contact);
            this.SaveChanges();
        }

        public void DeleteContact(int id)
        {
            Contacts contact = this.GetContactById(id);
            _db.Contacts.Remove(contact);
            this.SaveChanges();
        }

        public Contacts GetContactById(int id)
        {
            Contacts contact = _db.Contacts.Where(x => x.Id == id).FirstOrDefault();
            return contact;
        }

        public IEnumerable<Contacts> GetContacts()
        {
           return _db.Contacts;
        }

        public int SaveChanges()
        {
            Debug.WriteLine(_db.SaveChanges());
            return _db.SaveChanges();
        }
    }
}