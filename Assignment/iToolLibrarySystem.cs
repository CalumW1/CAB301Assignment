using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    interface iToolLibrarySystem
    {
        void add(Tool tool); // add a new tool to the system

        void add(Tool tool, int quantity); //add new pieces of an existing tool to the system

        void delete(Tool tool); //delte a given tool from the system

        void delete(Tool tool, int quantity); //remove some pieces of a tool from the system

        void add(Member member); //add a new memeber to the system

        void delete(Member member); //delete a member from the system

        void displayBorrowingTools(Member aMember); //given a member, display all the tools that the member are currently renting

        void displayTools(string tooltype); // display all the tools of a tool type selected by a member

        void borrowTool(Member member, Tool tool); //a member borrows a tool from the tool library

        void returnTool(Member member, Tool tool); //a member return a tool to the tool library

        string[] listTools(Member member); //get a list of tools that are currently held by a given member

        void displayTopTHree(); //Display top three most frequently borrowed tools by the members in the descending order by the number of times each tool has been borrowed.


    }

    class ToolLibrarySystem : iToolLibrarySystem
    {

        private MemberCollection members = new MemberCollection();
        private ToolMenus toolMenus = new ToolMenus();
       
        // setup for jagged array initalise each of the 9 arrays
        private ToolCollection[][] jaggedarraytools = new ToolCollection[][]
        {
            new ToolCollection[5],
            new ToolCollection[6],
            new ToolCollection[5],
            new ToolCollection[6],
            new ToolCollection[6],
            new ToolCollection[6],
            new ToolCollection[5],
            new ToolCollection[5],
            new ToolCollection[6],
        };


        // add a new tool to the system
        public void add(Tool tool)
        {
            toolMenus.ToolCategory();
            int tooltype;
            switch (Console.ReadLine())
            {
                case "1":
                    toolMenus.Gardeningtools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(1, tooltype, tool);
                    break;
                case "2":
                    toolMenus.Flooringtools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(2, tooltype, tool);
                    break;
                case "3":
                    toolMenus.Fencingtools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(3, tooltype, tool);
                    break;
                case "4":
                    toolMenus.measuringtools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(4, tooltype, tool);
                    break;
                case "5":
                    toolMenus.cleaningtools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(5, tooltype, tool);
                    break;
                case "6":
                    toolMenus.paintingtools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(6, tooltype, tool);
                    break;
                case "7":
                    toolMenus.electronictools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(7, tooltype, tool);
                    break;
                case "8":
                    toolMenus.electricitytools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(8, tooltype, tool);
                    break;
                case "9":
                    toolMenus.automotivetools();
                    tooltype = int.Parse(Console.ReadLine());
                    addanewtool(9, tooltype, tool);
                    break;
                case "0":
                    break;
            }

        }

        // add a new member the system
        public void add(Member member)
        {
            // submit to binary search tree 
            members.add(member);
            
        }

        // remove a member from the system.
        public void delete(Member member)
        {
            members.delete(member);
        }

        // display all tools within a given tool category and type
        public void displayTools(string tool)
        {
            // take user input and change it from string to int to increment arrays
            int toolcategory = int.Parse(tool);
            int tooltype;
            if (toolcategory == 1)
            {
                toolMenus.Gardeningtools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 2)
            {
                toolMenus.Flooringtools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 3)
            {
                toolMenus.Fencingtools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 4)
            {
                toolMenus.measuringtools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 5)
            {
                toolMenus.cleaningtools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 6)
            {
                toolMenus.paintingtools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 7)
            {
                toolMenus.electronictools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 8)
            {
                toolMenus.electricitytools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
            else if (toolcategory == 9)
            {
                toolMenus.automotivetools();
                tooltype = int.Parse(Console.ReadLine());
                displaytools(toolcategory, tooltype);
            }
        }
        private void displaytools(int category, int type)
        {
            // layout for the heading bar with titles
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("   Tool Name \t\t\t\t Avalible \t\t\t\t Quantity");
            Console.WriteLine("====================================================================================================");
            for (int j = 0; j < jaggedarraytools[category - 1][type - 1].toArray().Length; j++)
            {
                // need to minus 1 as array starts a 0 and user input starts at 1
                if (jaggedarraytools[category - 1][type - 1].toArray()[j] == null)
                {
                    break;
                }
                else
                {

                    Console.WriteLine("{0}.  {1} \t\t\t\t {2} \t\t\t\t\t {3} \n", j, jaggedarraytools[category - 1][type - 1].toArray()[j].Name, jaggedarraytools[category - 1][type - 1].toArray()[j].AvailableQuantity, jaggedarraytools[category - 1][type - 1].toArray()[j].Quantity);
                }
            }
        }

        // remove a tool from the system 
        void iToolLibrarySystem.delete(Tool tool)
        {

        }

        // remove a piece of a tool from the system
        public void delete(Tool tool, int quantity)
        {
            // find tool category and number
            toolMenus.ToolCategory();
            int userselection = int.Parse(Console.ReadLine());
            bool add = false;
            findmemberstooltype(userselection, add);
        }

        // add update the quantity on a given tool.
        public void add(Tool tool, int quantity)
        {
            // find tool category and number
            toolMenus.ToolCategory();
            int userselection = int.Parse(Console.ReadLine());
            bool add = true;
            findmemberstooltype(userselection, add);
        }

        // display tool type menus and save user input
        private void findmemberstooltype(int number, bool userpreference)
        {
            int toolcategory = number;
            int tooltype;
            bool addordelete = userpreference;
            if (toolcategory == 1)
            {
                toolMenus.Gardeningtools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 2)
            {
                toolMenus.Flooringtools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 3)
            {
                toolMenus.Fencingtools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 4)
            {
                toolMenus.measuringtools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 5)
            {
                toolMenus.cleaningtools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 6)
            {
                toolMenus.paintingtools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 7)
            {
                toolMenus.electronictools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 8)
            {
                toolMenus.electricitytools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
            else if (toolcategory == 9)
            {
                toolMenus.automotivetools();
                tooltype = int.Parse(Console.ReadLine());
                updatetoolquantity(toolcategory, tooltype, addordelete);
            }
        }

        private void updatetoolquantity(int category, int type, bool addordelete)
        {
            // layout for the heading bar with titles
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("   Tool Name \t\t\t\t Avalible \t\t\t\t Quantity");
            Console.WriteLine("====================================================================================================");
            for (int j = 0; j < jaggedarraytools[category - 1][type - 1].toArray().Length; j++)
            {
                // need to minus 1 as array starts a 0 and user input starts at 1
                if (jaggedarraytools[category - 1][type - 1].toArray()[j] == null)
                {
                    break;
                }
                else
                {

                    Console.WriteLine("{0}.  {1} \t\t\t\t {2} \t\t\t\t\t {3} \n", j, jaggedarraytools[category - 1][type - 1].toArray()[j].Name, jaggedarraytools[category - 1][type - 1].toArray()[j].AvailableQuantity, jaggedarraytools[category - 1][type - 1].toArray()[j].Quantity);
                }
            }

            // take a boolean value, if set to true add to quantity has been selected, if false user wants to remove tools;
            if(addordelete == true)
            {
                // increase the amount of tools
                Console.WriteLine("Select a tool you would like to update quantity on");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("How many new tools would you like to add? ");
                int toolcount = int.Parse(Console.ReadLine());
                // increase the quanity and available quantity for the selected tool
                jaggedarraytools[category - 1][type - 1].toArray()[choice].Quantity += toolcount;
                jaggedarraytools[category - 1][type - 1].toArray()[choice].AvailableQuantity += toolcount;
                Console.WriteLine("Updated the quantity of {0} in the library to {1}", jaggedarraytools[category - 1][type - 1].toArray()[choice].Name, jaggedarraytools[category - 1][type - 1].toArray()[choice].Quantity);
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Write("\n");
            }
            else
            {
                // decrease the amount of tools
                Console.WriteLine("Select a tool you would like to decrease quantity on");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("How many new tools would you like to remove? ");
                int toolcount = int.Parse(Console.ReadLine());
                // decreases the quanity and avalible quantity for the selected tool
                jaggedarraytools[category - 1][type - 1].toArray()[choice].Quantity -= toolcount;
                jaggedarraytools[category - 1][type - 1].toArray()[choice].AvailableQuantity -= toolcount;
                Console.WriteLine("Updated the quantity of {0} in the library to {1}", jaggedarraytools[category - 1][type - 1].toArray()[choice].Name, jaggedarraytools[category - 1][type - 1].toArray()[choice].Quantity);
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Write("\n");
            }
            
        }


        // private function to help add a tool to the jagged array
        private void addanewtool(int category, int type, Tool tool)
        {
            // create a boolean value, if true the tool already exist if false then it doesn't exist
            bool toolfound = false;
            if (jaggedarraytools[category - 1][type - 1] == null)
            {
                // if the jagged array at particular index is null create a new tool object
                jaggedarraytools[category - 1][type - 1] = new ToolCollection();
                jaggedarraytools[category - 1][type - 1].add(tool);
                Console.WriteLine("The tool has been sucessfully added");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                // check to see if the tool name matches any name within the tool type
                for (int i = 0; i < jaggedarraytools[category-1][type-1].toArray().Length; i++)
                {
                    // check if index is null first, if true check tool name else return false
                    if(jaggedarraytools[category - 1][type - 1].toArray()[i] != null)
                    {
                        if(tool.Name == jaggedarraytools[category - 1][type - 1].toArray()[i].Name)
                        {
                            Console.WriteLine("This tool is already in the system");
                            Console.Write("\n");
                            toolfound = true;
                            return;
                        }
                    }
                    else
                    {
                        toolfound = false;
                    }
                }
                // if the tool doesn't exist within the tool type, then add it 
                if (!toolfound)
                {
                    // if the tool collection has already been created then add into the collection
                    jaggedarraytools[category - 1][type - 1].add(tool);
                    // print success message and wait for user input
                    Console.WriteLine("The tool has been sucessfully added");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                
                        
            }  
        }

        // function to borrow a tool for the user;
        public void borrowTool(Member member, Tool tool)
        {
            int category = tool.Quantity;
            int type = tool.AvailableQuantity;
            int userchosentool;
            // display a list of tools based on users selections
            Console.WriteLine("================== Select a Tool ==================");
            for (int j = 0; j < jaggedarraytools[category - 1][type - 1].toArray().Length; j++)
            {
                // need to minus 1 as array starts a 0 and user input starts at 1
                if (jaggedarraytools[category - 1][type - 1].toArray()[j] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("{0}.  {1} \n", j, jaggedarraytools[category - 1][type - 1].toArray()[j].Name);
                }
            }
            Console.WriteLine("Please select a tool you would like to borrow");
            userchosentool = int.Parse(Console.ReadLine());
            Tool selectedtool = jaggedarraytools[category - 1][type - 1].toArray()[userchosentool];
            // check the tool quantity 
            if (tool.AvailableQuantity > 0)
            {
                // check the number of tools the user is currently holding MAX of 3 
                if (member.Tools.Length < 3)
                {
                    member.addTool(selectedtool);
                    selectedtool.AvailableQuantity--;
                    selectedtool.NoBorrowings++;
                    Console.WriteLine("Tool {0} has been borrowed", selectedtool.Name);
                }
                else
                {
                    Console.WriteLine("Member has borrowed the maximum amount of tools");
                    Console.Write("\n");
                }

            }
        }

        // return a list of tools
        public string[] listTools(Member member)
        {
            return member.Tools;
        }


        // display all the tools the member is currently holding
        public void displayBorrowingTools(Member aMember) 
        {
            Console.WriteLine("===================== Tools Currently Borrowed by {0} {1} ===================== ", aMember.FirstName, aMember.LastName);
            // check to see if the members tools not are null; 
            for (int i = 0; i < aMember.Tools.Length; i++)
            {
                if (aMember.Tools[i] != null)
                {
                    Console.WriteLine("{0}.\t {1} ", i, aMember.Tools[i]);
                }
                else
                {
                    Console.WriteLine("No tools currently borrowed");
                }
            }
            Console.WriteLine("===================================================================================");
            Console.Write("\n");
        }

        public void returnTool(Member member, Tool tool)
        {
            
            // display the tools the member currently has on loan
            Console.WriteLine("======================= Return Tool Menu ======================================");
            for (int i = 0; i < member.Tools.Length; i++)
            {
                if (member.Tools[i] != null)
                {
                    Console.WriteLine("{0}.\t {1} ", i + 1, member.Tools[i]);
                }
            }
            Console.WriteLine("===================================================================================");
            Console.Write("\n");
            Console.WriteLine("Please Select a tool you would like to return");
            int userselection = int.Parse(Console.ReadLine());
            string returnedtool = member.Tools[userselection - 1];
            // search for the tool that is being returned and increase the avalible quantity by 1
            for (int i = 0; i < jaggedarraytools.Length; i++)
            {
                for(int j = 0; j < jaggedarraytools[i].Length; j++)
                {
                    if(jaggedarraytools[i][j] != null)
                    {
                        for(int k = 0; k < jaggedarraytools[i][j].toArray().Length; k++)
                        {
                             if(jaggedarraytools[i][j].toArray()[k].Name == returnedtool)
                             {
                                Tool selectedtool = jaggedarraytools[i][j].toArray()[k];
                                member.deleteTool(selectedtool);
                                selectedtool.AvailableQuantity++;
                                break;
                             }
                        }
                    }
                }
            }

            Console.WriteLine("Tool has been returned");

        }

        public void displayTopTHree()
        {

            // create a list to add the tools too
            List<Tool> toollist = new List<Tool>();

            // loop through the jagged array an add all tools in the system
            for (int i = 0; i < jaggedarraytools.Length; i++)
            {
                for (int j = 0; j < jaggedarraytools[i].Length; j++)
                {
                    if (jaggedarraytools[i][j] != null)
                    {
                        for (int k = 0; k < jaggedarraytools[i][j].toArray().Length; k++)
                        {
                            toollist.Add(jaggedarraytools[i][j].toArray()[k]);
                        }
                    }
                }
            }

            Tool[] heap = toollist.ToArray();
            Console.WriteLine("======================== Top 3 Most Borrowed Tools ============================");
            for (int i = 0; i < 3 && i < heap.Length - 2; i++){
                heap = Heapsort(heap, i);
            }
            // print out the top 3 most borrowed tools 
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Tool {0} was borrowed {1} times", heap[i].Name, heap[i].NoBorrowings);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        // pass the array of tools through the heapsort algorithm and return a sorted array.
        Tool[] Heapsort(Tool[] heap, int index)
        {
            int n = (heap.Length - index - 1);

            for(int i = n/2; i >= 0; i--)
            {
                int k = i;
                Tool tool = heap[index + k];
                bool isHeap = false;
                while( !isHeap && 2 * k <= n)
                {
                    int j = 2 * k;
                    if (j < n)
                    {
                        if(heap[index + j].NoBorrowings < heap[index + j + 1].NoBorrowings)
                        {
                            j++;
                        }
                    }
                    if(tool.NoBorrowings >= heap[index + j].NoBorrowings)
                    {
                        isHeap = true;
                    }
                    else
                    {
                        heap[index + k] = heap[index + j];
                        k = j;
                    }
                }
                heap[index + k] = tool;
            }
            return heap;
        }
    }
}
