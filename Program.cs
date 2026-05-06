using CSostenido.Models;
using CSostenido.Services;
using CSostenido.Data;


List < Reserve > Reservas = new List<Reserve>(); 


string mainMenu = "1.Users Management \n" +
                  "2.Sport Sections Management\n" +
                  "3.Reserves Management \n" +
                  "4.Exit \n";

bool exit = true;

var context = new AppDbContext();
var userService = new UserService(context);
var sportService = new SportSectionService(context);
var reserveService = new ReserveService(context);





while (exit)
{
    Console.WriteLine(mainMenu);
    Console.WriteLine("What Do You Want?");
    string choose = Console.ReadLine();
    


    switch (choose)
    {
        case "1":
        {
            Console.WriteLine("A.Edit User \n"+
                              "B.Show All Users \n"+
                              "C.Validate Users \n"+
                              "D.Add New User \n"+
                              "E.Remove User");
            string choosing = Console.ReadLine().ToUpper();
            //string chooing = choosing.ToUpper();
            
            switch (choosing)
            {
                case "A":
                {
                   Console.WriteLine("Write The User ID For Edit");
                   string idWrite = Console.ReadLine();

                   if (int.TryParse(idWrite, out int resulteded))
                   {
                       Console.WriteLine("Okay,Let Start");
                       userService.EditUser(resulteded);
                   }
                   else
                   {
                       Console.WriteLine("User Doesn't Exissts");
                   }
                  
                    
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
                    Console.WriteLine("Enter The Id For Validate"); 
                    string idUs = Console.ReadLine();

                    if (int.TryParse(idUs, out int result))
                    {
                        //Console.WriteLine("All Users Rigth Here");
                        //userService.ListUser();
                        userService.ValidUser(result);
                        Console.WriteLine($"The User Identified With { result } ID");
                    }
                    else
                    {
                        Console.WriteLine("ff");

                    }
                    
                    
                   
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }   
                case "D":
                {
                    Console.WriteLine("Name");
                    string nameUser = Console.ReadLine();
                    Console.WriteLine("Document");
                    int documentUser = Console.ReadLine();
                    Console.WriteLine("Email");
                    string emailUser = Console.ReadLine();
                    Console.WriteLine("You Phone Number");
                    string phoneNumber = Console.ReadLine();
                    
                    userService.createUser(nameUser,documentUser,emailUser,phoneNumber);
                    break;
                }
                case "E":
                {
                    Console.WriteLine("All Users Rigth Here");
                    userService.ListUser();
                    Console.WriteLine("Write The User Id For Remove");
                    int idUser = int.Parse(Console.ReadLine());
                    userService.RemoveUser(idUser);
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
            exit = false; 
            
            break;
        }
        
        
    }







}

