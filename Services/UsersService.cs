using CSostenido.Models;
using Microsoft.EntityFrameworkCore;
using CSostenido.Data;


namespace CSostenido.Services;


public class UserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;

        
    }

    public void createUser(string nameUser, string documentUser, string emailUser,string phoneNumber)
    {
        bool existDocument = _context.User.Any(u => u.DocumentId == documentUser);
        if (existDocument)
        {
            Console.WriteLine("You Cant Enter With Same Document");
        }

        bool existEmail = _context.User.Any(u => u.Email == emailUser);
        if (existEmail)
        {
            Console.WriteLine("You Cant Enter With Same Email");
        }

        if (!existEmail && !existDocument)
        {
            var user = new User
            {
                NameUser = nameUser,
                DocumentId = documentUser,
                Email = emailUser,
                PhoneNumber = phoneNumber
            };
            _context.User.Add(user);
            _context.SaveChanges();

            Console.WriteLine("You Can Enter");
            Console.ReadLine();
            Console.Clear();
        }
    }

    public void ListUser()
       {
           var user = _context.User.ToList();
           foreach (var users in user)
           {
               Console.WriteLine(users.NameUser + "" + users.DocumentId);
           }
       }


   

    
    


}
