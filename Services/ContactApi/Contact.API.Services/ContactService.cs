using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO { Id = id, FirstName = "Ramiz", LastName = "Valiyev" };
        }
    }
}
