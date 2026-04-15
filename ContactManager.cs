using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ContactManager
{
    Dictionary<string, string> ContactDictionary;

    public ContactManager()
    {
        ContactDictionary = new Dictionary<string, string>();
    }
    public void AddContact(string name, string phoneNumber)
    {
        if (ContactDictionary.ContainsKey(name))
        {
            Console.WriteLine("El contacto" + name + "ya existe");
        }
        else
        {
            ContactDictionary.Add(name, phoneNumber);
            Console.WriteLine("Contacto agregado");
        }
    }
    public void SearchContact(string name)
    {
        if (ContactDictionary.ContainsKey(name))
        {
            Console.WriteLine($"Nombre: {name}  , Telefono: {ContactDictionary[name]}" );
        }
        else
        {
            Console.WriteLine($"El contacto '{name}' no existe en la agenda");
        }
    }
    public void RemoveContact(string name)
    {
        if (ContactDictionary.ContainsKey(name))
        {
            ContactDictionary.Remove(name);
            Console.WriteLine($"{name} Ha sido eliminado con exito");
        }
        else
        {
            Console.WriteLine($"El contacto {name} no se encuntra en la agenda");
        }
    }
    
}
    
