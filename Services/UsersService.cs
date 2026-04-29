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

    public void RemoveUser(int UserId)
    {
        bool existId = _context.User.Any(u => u.UserId == UserId);
        if (existId)
        {
            var userRemove =  _context.User.FirstOrDefault(u => u.UserId == UserId);
            _context.User.Remove(userRemove);
            _context.SaveChanges();
            Console.WriteLine("Your User Is Removed Correct");
            
        }

        else
        {
            Console.WriteLine("User Not Found");
        }
        
    }
    
    

    public void ListUser()
       {
           var user = _context.User.ToList();
           foreach (var users in user)
           {
               Console.WriteLine("ID        Name         Document             Email               Phone");
               Console.WriteLine(""+users.UserId+"       "+users.NameUser + "          " + users.DocumentId + "        "  + users.Email +"         "+ users.PhoneNumber);
           }
       }


   

    
    


}
