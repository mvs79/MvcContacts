using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcContacts.Models;

namespace MvcContacts.Tests.Models
{
    public class InMemoryContactRepository : IContactRepository
    {
        private List<Contacts> _db = new List<Contacts>();
        public Exception ExceptionToThrow { get; set; }

        public void CreateContact(Contacts contact)
        {
            if (ExceptionToThrow != null)
                throw ExceptionToThrow;

            _db.Add(contact);
        }

        public void DeleteContact(int id)
        {
            
           _db.Remove(this.GetContactById(id));
             
        }

        public Contacts GetContactById(int id)
        {
         Contacts contact = _db.Where(x => x.Id == id).FirstOrDefault();
            return contact;
        }

        public IEnumerable<Contacts> GetContacts()
        {
            return _db.ToList();
        }

        public void SaveChanges(Contacts contactToUpdate)
        {
            foreach (var item in _db)
            {
              Contacts contact =  _db.Where(x => x.Id == contactToUpdate.Id).FirstOrDefault();
              _db.Remove(contact);
              _db.Add(contactToUpdate);
                break;
            }


        }
        public int SaveChanges()
        {
            return 1;
        }

        public void Add(Contacts contact)
        {
            _db.Add(contact);

        }
    }
}
