using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcContacts.Models
{
    public interface IContactRepository
    {
        void DeleteContact(int id);
        IEnumerable<Contacts> GetContacts();
        Contacts GetContactById(int id);
        void CreateContact(Contacts contact);
        int SaveChanges();
    }
}
