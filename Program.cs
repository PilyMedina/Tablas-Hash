ContactManager contact = new ContactManager();
int opcion = int.Parse(Console.ReadLine()!);
do
{
        Console.WriteLine(@" 
    -------MENU-------
    [1] AGREGAR CONTACTO
    [2] BUSCAR CONTACTO
    [3] ELIMINAR CONTACTO
    [4] VOLVER
    [5] SALIR
    ");
    switch (opcion)
    {
        case 1:

            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine()!;
            Console.WriteLine("Introduce tu telefono");
            string tele = Console.ReadLine()!;
            contact.AddContact(nombre, tele);
            break;

        case 2:

            Console.WriteLine("Introduce un nombre para buscar");
            string busnombre = Console.ReadLine()!;
            contact.SearchContact(busnombre);
            break;

        case 3:

            Console.WriteLine("Introduce un nombre para buscar");
            string elinombre = Console.ReadLine()!;
            contact.RemoveContact(elinombre);
            break;

    }
}
while( opcion != 5);



//contact.AddContact("Luis", "0993848944");
//contact.AddContact("Yatna", "0993848944");
//contact.AddContact("Cali", "0993848944");
//contact.AddContact("Juana", "0993848944");

//Console.WriteLine("Buscando contacto");
//contact.SearchContact("Luisa");
//contact.SearchContact("Luis");
//contact.SearchContact("Amanda");

//Console.WriteLine("Eliminando contacto");
//contact.RemoveContact("Luis");
//contact.RemoveContact("Joana");










