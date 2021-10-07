using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Member : iMember
    {
        // get member first name
        public Member(string firstName, string lastName, string contactNumber, string Pin)
        {
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = contactNumber;
            PIN = Pin;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string PIN { get; set; }
        public string[] Tools { get { return toolsarray(); }     }

        // private tool array
        private int counter = 0;
        private ToolCollection borrowatool = new ToolCollection();

        // save tools to an array.
        public void addTool(Tool tool)
        {
            borrowatool.add(tool);
            counter++;
        }

        // remove tools from an array
        public void deleteTool(Tool tool)
        {
            borrowatool.delete(tool);
            counter--;
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName + " " + ContactNumber);
        }


        // move tools from tool collection into a string array
        private string[] toolsarray()
        {
            string[] newtoolarray = new string[counter];

            // for each tool in the toolcollection add it to the string array;
            for(int i = 0; i < borrowatool.toArray().Length; i++)
            {
                if(borrowatool.toArray()[i] != null)
                {
                    newtoolarray[i] = borrowatool.toArray()[i].Name;
                }
            }

            return newtoolarray;
        }

        // Compare to method for the binary search tree to compare a member object by last then first name.
        public int CompareTo(Member member)
        {

            Member newMember = member;
            if (this.LastName.CompareTo(newMember.LastName) < 0)
            {
                return -1;
            }
            else
            {
                if (this.LastName.CompareTo(newMember.LastName) == 0)
                {
                    return this.FirstName.CompareTo(newMember.FirstName);
                }
                else
                {
                    return 1;
                }
            }

        }

    }
}
