
    ContactManager contact = new ContactManager();

    contact.AddContact("Luis", "0993848944");
    contact.AddContact("Yatna", "0993848944");
    contact.AddContact("Cali", "0993848944");
    contact.AddContact("Juana", "0993848944");

    Console.WriteLine("Buscando contacto");
    contact.SearchContact("Luisa");
    contact.SearchContact("Luis");
    contact.SearchContact("Amanda");

    Console.WriteLine("Eliminando contacto");
    contact.RemoveContact("Luis");
    contact.RemoveContact("Joana");

