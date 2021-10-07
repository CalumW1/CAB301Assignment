using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Menu
    {
        // temporary membercollection for login and finding contact number.
        private  MemberCollection TempmembersCollection = new MemberCollection();
        private  ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();
        private ToolMenus toolMenus = new ToolMenus();

        public void welcomeMenu()
        {
            // define layout for main menu 
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("==========Main Menu========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===========================");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-2, or 0 to exit):");

            // switch case to navigate to staff menu, member menu or exit
            switch (Console.ReadLine())
            {
                case "1":
                    StaffPasswordScreen();
                    break;
                case "2":
                    MemberloginScreen();
                    break;
                case "3":
                    MemberloginScreen();
                    break;
                case "0":
                    return;
            }
        }

        // save the member details when they log in, this will be used as a variable for borrowing, returning
        // and displaying a list of tools
        private Member memberdetails;
        
        // Member login 
        public void MemberloginScreen()
        {
            Console.Write("Please enter username (Lastname + Firstname): ");
            string username = Console.ReadLine();
            Console.Write("Please enter pin number: ");
            string pin = Console.ReadLine();
            int counter = 0;
            // put members into an array to check 
            Member[] memberarray = TempmembersCollection.toArray();
            // search to see if the user exsits in the system
            for(int i = 0; i < memberarray.Length; i++)
            {
                // check the entered username and password against the members in the array.
                string checkusername = memberarray[i].LastName + memberarray[i].FirstName;
                string checkpin = memberarray[i].PIN;
                
                // if true show member menu
                if (username.CompareTo(checkusername) == 0 && pin.CompareTo(checkpin) == 0)
                {
                    Console.Write("\n");
                    memberdetails = memberarray[i];
                    MemberMenu();
                    break;
                }
                // increment counter and if equal to the length of the array then return member not found
                counter++;
                if (counter == memberarray.Length){
                    Console.WriteLine("Username is not in the system");
                    Console.Write("\n");
                    welcomeMenu();
                }
            }
        }

        public void StaffPasswordScreen()
        {
            // predefined username and password
            string username = "staff";
            string password = "today123";

            // ask user for username and password; 
            Console.Write("Please enter Staff username: ");
            string usernamecheck = Console.ReadLine();

            Console.Write("Please enter Staff password: ");
            string passwordcheck = Console.ReadLine();

            // check username and password, if correct show staff menu, false go back to main menu
            if (username == usernamecheck && password == passwordcheck)
            {
                Console.Write("\n");
                StaffMenu();
            }
            else
            {
                Console.WriteLine("Error please try again");
                Console.Write("\n");
                welcomeMenu();
            }
        }

        public void StaffMenu()
        {
            // layout for staff menu

            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("=========Staff Menu========");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an exisiting tool");
            Console.WriteLine("3. Remove some pieces of a tool");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a member");
            Console.WriteLine("6. Find the contact number of a member");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===========================");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-6, or 0 to return to main menu):");


            switch (Console.ReadLine()) 
            {
                case "1":
                    addnewTool();
                    break;
                case "2":
                    addatoolPiece();
                    break;
                case "3":
                    deleteatoolPiece();
                    break;
                case "4":
                    registernewemember();
                    break;
                case "5":
                    removeAMember();
                    break;
                case "6":
                    findMembersphoneNumber();
                    break;
                case "0":
                    welcomeMenu();
                    break;
            }
        }

        // register a new user to a system
        public void registernewemember()
        {
            Console.Write("Please enter firstname: ");
            string firstname = Console.ReadLine();

            Console.Write("Please enter lastname: ");
            string lastname = Console.ReadLine();

            Console.Write("Please enter a contact number: ");
            string contactnumber = Console.ReadLine();

            Console.Write("Please enter a PIN number: ");
            string PIN = Console.ReadLine();
            Console.Write("\n");
            // check details
            Console.WriteLine("Check Details:");
            Console.WriteLine("First name: " + firstname);
            Console.WriteLine("Last name: " + lastname);
            Console.WriteLine("Contact number: " + contactnumber);
            Console.WriteLine("PIN: " + PIN);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            // submit to binary search tree 
            toolLibrarySystem.add(new Member(firstname, lastname, contactnumber, PIN));
            TempmembersCollection.add(new Member(firstname, lastname, contactnumber, PIN));
            // return to menu
            StaffMenu();

        }

        // remove a member from the system
        public void removeAMember()
        {
            Console.Write("Please enter member's first name: ");
            string firstname = Console.ReadLine();
            Console.Write("Please enter member's last name: ");
            string lastname = Console.ReadLine();
            string contactnumnber = " ";
            string pin = " ";
            Member member = new Member(firstname, lastname, contactnumnber, pin);
            Console.WriteLine("Are you sure you want to delete {0} {1} from the system? ", firstname, lastname);
            Console.ReadLine();
            toolLibrarySystem.delete(member);
            TempmembersCollection.delete(member);
            StaffMenu();
        }

        // search to a members phone number based on firstname and lastname
        public void findMembersphoneNumber()
        {
            Console.Write("Please enter member's first name: ");
            string firstname = Console.ReadLine();
            Console.Write("please enter member's last name: ");
            string lastname = Console.ReadLine();
            bool testbool = true;
            bool memberfound = false;
            Member[] membersarray = TempmembersCollection.toArray();
            if (testbool)
            {
                for (int i = 0; i < membersarray.Length; i++)
                {
                    if (membersarray[i] != null)
                    {
                        if (membersarray[i].LastName == lastname)
                        {
                            if (membersarray[i].FirstName == firstname)
                            {
                                Console.WriteLine("Members phone number is {0}", membersarray[i].ContactNumber);
                                Console.Write('\n');
                                memberfound = true;
                                StaffMenu();
                                return;

                            }
                        }
                    }
                }
                if (!memberfound)
                {
                    Console.WriteLine("Member not found");
                    StaffMenu();
                }
            }
        }
        
        // add a new tool
        public void addnewTool()
        {
            // Hardcode tool categories and types: 
            Console.WriteLine("Please enter the name of the tool you would like to add: ");
            string name = Console.ReadLine();
            toolLibrarySystem.add(new Tool(name, 1, 1, 0));
            StaffMenu();
        }

        // add a new peice to existing tool
        public void addatoolPiece()
        {
            string name = "";
            int amount = 0;
            toolLibrarySystem.add(new Tool(name, 0, 0, 0), amount);
            StaffMenu();
        }

        // remove a piece of an existing tool
        private void deleteatoolPiece()
        {
            string name = "";
            int amount = 0;
            toolLibrarySystem.delete(new Tool(name, 0, 0, 0), amount);
            StaffMenu();
        }
       
        public void MemberMenu()
        {
            // layout for member menu
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("=========Member Menu=======");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools that i am renting");
            Console.WriteLine("5. Display top three (3) most frequentely rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===========================");
            Console.Write("\n");
            Console.WriteLine("Please make a selection (1-5, or 0 to return to main menu):");

            switch (Console.ReadLine())
            {
                case "1":
                   Displaytoolsmenu();
                    break;
                case "2":
                   borrowatool();
                    break;
                case "3":
                   returnatool();
                    break;
                case "4":
                    displaytoolsiamrenting();
                    break;
                case "5":
                    displayTop3tools();
                    break;
                case "0":
                    welcomeMenu();
                    break;
            }
        }

        private void Displaytoolsmenu()
        {
            // display category types
            toolMenus.ToolCategory();
            string selection = Console.ReadLine();
            // send users chosen category to libsystem class
            switch (selection)
            {
                case "1":
                    toolLibrarySystem.displayTools("1");
                    MemberMenu();
                    break;
                case "2":
                    toolLibrarySystem.displayTools("2");
                    MemberMenu();
                    break;
                case "3":
                    toolLibrarySystem.displayTools("3");
                    MemberMenu();
                    break;
                case "4":
                    toolLibrarySystem.displayTools("4");
                    MemberMenu();
                    break;
                case "5":
                    toolLibrarySystem.displayTools("5");
                    MemberMenu();
                    break;
                case "6":
                    toolLibrarySystem.displayTools("6");
                    MemberMenu();
                    break;
                case "7":
                    toolLibrarySystem.displayTools("7");
                    MemberMenu();
                    break;
                case "8":
                    toolLibrarySystem.displayTools("8");
                    MemberMenu();
                    break;
                case "9":
                    toolLibrarySystem.displayTools("9");
                    MemberMenu();
                    break;
                case "0":
                    MemberMenu();
                    break;
            }

        }
        // borrow a tool from the library
        private void borrowatool()
        {
            toolMenus.ToolCategory();
            int category = int.Parse(Console.ReadLine());
            displaytooltypemenu(category);
            MemberMenu();
        }

        // this function will allow users to naviagate through the different menus to borrow a tool
        private void displaytooltypemenu(int userselection)
        {
            int toolselction;
            if (userselection == 1)
            {
                toolMenus.Gardeningtools();
                toolselction = int.Parse(Console.ReadLine());
                // these inputs will allow me to index the jagged array in TLS to display tools and allow them to select one
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 2)
            {
                toolMenus.Flooringtools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 3)
            {
                toolMenus.Fencingtools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 4)
            {
                toolMenus.measuringtools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 5)
            {
                toolMenus.cleaningtools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 6)
            {
                toolMenus.paintingtools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 7)
            {
                toolMenus.electronictools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 8)
            {
                toolMenus.electricitytools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
            else if (userselection == 9)
            {
                toolMenus.automotivetools();
                toolselction = int.Parse(Console.ReadLine());
                toolLibrarySystem.borrowTool(memberdetails, new Tool("", userselection, toolselction, 0));
            }
        }

        // return a tool to the tool library
        private void returnatool()
        {
            toolLibrarySystem.returnTool(memberdetails, new Tool("", 0, 0, 0));
            MemberMenu();
        }

        // display all the tools the member is currently renting
        private void displaytoolsiamrenting()
        {
            toolLibrarySystem.displayBorrowingTools(memberdetails);
            MemberMenu();
        }

        // display the toop three most borrowed tools
        private void displayTop3tools()
        {
            toolLibrarySystem.displayTopTHree();
            MemberMenu();
        }





    }
}
