using Microsoft.AspNetCore.Mvc;

public class ContactManagementController : BaseController
{
    private readonly ContactStorage storage;

    public ContactManagementController(ContactStorage storage)
    {
        this.storage = storage;
    }

    [HttpPost("contacts")]
    public void Create([FromBody] Contact contact)
    {
        storage.Contacts.Add(contact);
    }

    [HttpGet("contacts")]
    public List<Contact> GetContacts()
    {
        return storage.Contacts;
    }

    [HttpDelete("contacts/{id}")]
    public void DeleteContact(int id)
    {
        Contact contact;
        for (int i = 0; i < storage.Contacts.Count; i++)
        {
            if (storage.Contacts[i].Id == id)
            {
                contact = storage.Contacts[i];
                storage.Contacts.Remove(contact);
                return;
            }
        }
    }

    [HttpPut("contacts/{id}")]
    public void UpdateContact([FromBody] ContactDto contactDto, int id)
    {
        Contact contact;
        for (int i = 0; i < storage.Contacts.Count; i++)
        {
            if (storage.Contacts[i].Id == id)
            {
                contact = storage.Contacts[i];
                if (!String.IsNullOrEmpty(contactDto.Email))
                {
                    contact.Email = contactDto.Email;
                }
                if (!String.IsNullOrEmpty(contactDto.Name))
                {
                    contact.Name = contactDto.Name;
                }
                return;
            }
        }
    }

}