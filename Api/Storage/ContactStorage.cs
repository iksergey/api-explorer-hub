public class ContactStorage
{
    private List<Contact> Contacts { get; set; }

    public ContactStorage()
    {
        this.Contacts = new List<Contact>();

        for (int i = 1; i <= 5; i++)
        {
            this.Contacts.Add(new Contact()
            {
                Id = i,
                Name = $"Полное имя {i}",
                Email = $"{Guid.NewGuid().ToString().Substring(0, 5)}_{i}@ksergey.ru"
            });
        }
    }



    public List<Contact> GetContacts()
    {
        return Contacts;
    }

    public void Add(Contact contact)
    {
        Contacts.Add(contact);
    }

    public void Remove(int id)
    {
        Contact contact;
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (this.Contacts[i].Id == id)
            {
                contact = Contacts[i];
                Contacts.Remove(contact);
                return;
            }
        }
    }

    public void UpdateContact(ContactDto contactDto, int id)
    {
        Contact contact;
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Id == id)
            {
                contact = Contacts[i];
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