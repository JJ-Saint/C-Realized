using CSostenido.Models;
using CSostenido.Services;
using CSostenido.Data;


List < Reserve >Reservas = new List<Reserve>(); 


string MainMenu = "1.Users Management \n" +
                  "2.Sport Sections Management\n" +
                  "3.Reserves Management \n" +
                  "4.Exit \n";

bool Exit = true;

var context = new AppDbContext();
var userService = new UserService(context);
var sportService = new SportSectionService(context);
var reserveService = new ReserveService(context);





while (Exit)
{
    Console.WriteLine(MainMenu);
    Console.WriteLine("What Do You Want?");
    string choose = Console.ReadLine();


    switch (choose)
    {
        case "1":
        {
            Console.WriteLine("A.Edit User \n"+
                              "B.Show All Users \n"+
                              "C.Validate Users \n"+
                              "D.Add New User \n");
            string choosing = Console.ReadLine();
            
            switch (choosing)
            {
                case "A":
                {
                    
                    
                    break;
                }   
                case "B":
                {
                    userService.ListUser();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }   
                case "C":
                {
                    
                    
                    break;
                }   
                case "D":
                {
                    Console.WriteLine("Name");
                    string nameUser = Console.ReadLine();
                    Console.WriteLine("Document");
                    string documentUser = Console.ReadLine();
                    Console.WriteLine("Email");
                    string emailUser = Console.ReadLine();
                    Console.WriteLine("You Phone Number");
                    string phoneNumber = Console.ReadLine();
                    
                    userService.createUser(nameUser,documentUser,emailUser,phoneNumber);
                    break;
                }   
            }
            
            
            
            
            break;
        }
        case "2":
        {
            Console.WriteLine("Name");
            string nameSportSection = Console.ReadLine();
            Console.WriteLine("Type Of Section?");
            string typeSportSection = Console.ReadLine();
            Console.WriteLine("Capacity");
            int capacity = int.Parse(Console.ReadLine());
            
            break;
        }
        
        case "3":
        {
            Console.WriteLine("Date");
            string Date = Console.ReadLine();
            Console.WriteLine("Start Time?"); 
            DateTime startTimeReserve = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("End Time?");
            DateTime endTimeReserve = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Name Of User?");
            string nameUser = Console.ReadLine();
            Console.WriteLine("Document");
            string documentUser = Console.ReadLine();
            
            break;
        }
        case "4":
        {
            Console.WriteLine("Bye Bye");
            Exit = false;
            
            break;
        }
        
        
    }







}

