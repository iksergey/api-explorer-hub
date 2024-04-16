public class ContactStorage
{
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

    public List<Contact> Contacts { get; set; }
}