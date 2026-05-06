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

    public void EditUser(int UuserId)
    {
        bool existsId = _context.User.Any(u => u.UserId == UuserId);
        //bool existsName = _context.User.Any(u => u.NameUser == UserName);
        
        if (existsId)
        {
            var editUser = _context.User.FirstOrDefault(u => u.UserId == UuserId);
            Console.WriteLine("Name");
            string nameUsere = Console.ReadLine();
            Console.WriteLine("Document");
            string documentIdUser = Console.ReadLine();
            if (int.TryParse(documentIdUser, out int resulte))
            {
               Console.WriteLine("Continue");
            }
            else
            {
                Console.WriteLine("ff");

            }

            Console.WriteLine("Phone");
            string phoneNumberUser = Console.ReadLine();
            if (int.TryParse(phoneNumberUser, out int resulted))
            {
                Console.WriteLine("Continue");
            }
            else
            {
                Console.WriteLine("ff");

            }

            Console.WriteLine("Email");
            string emailUserEmail = Console.ReadLine();
            
           editUser.NameUser = nameUsere;
           editUser.DocumentId = resulte;
           editUser.PhoneNumber = resulted;
           editUser.Email = emailUserEmail;
            ;
            _context.SaveChanges();


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

        public void ValidUser(int UserIdd)
        {
                bool existIdUser = _context.User.Any(u => u.UserId == UserIdd);
               // bool existId = _context.User.Any<User>(this IEnumerable<User>, Func<User,bool>) (in class Enumerable)
                if (existIdUser)
                {
                    Console.WriteLine("Your User It's In The System");
                    ListUser();
                
                }

                else
                {
                    Console.WriteLine("Enter A New User Please,Because The User Doesn't Exists");
                }
        
        }
    }

