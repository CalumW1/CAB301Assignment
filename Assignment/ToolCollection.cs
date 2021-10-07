using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ToolCollection : iToolCollection
    {
        private Tool[] tools = new Tool[10];
        private int numberoftools = 0;
        
        public int Number { get; }

        // add a new tool to the array
        public void add(Tool tool)
        {
            for(int i = 0; i < tools.Length; i++)
            {
                if(tools[i] == null)
                {
                    tools[numberoftools] = tool;
                    break;
                }
            }
            numberoftools++;
        }

        // remove a tool from the array
        public void delete(Tool tool)
        {
            for(int i = 0; i < tools.Length; i++)
            {
                if(tools[i] == tool)
                {
                    tools[i] = null;
                    break;
                }
            }
            numberoftools--;
        }

        // search for a tool in array
        public bool search(Tool tool)
        {
            for (int i = 0; i < tools.Length; i++)
            {
                if (tools[i].Name == tool.Name)
                {
                    return true;
                }
            }
            return false;
        }

        // return the tools to an array.
        public Tool[] toArray()
        {
            Tool[] toolsarray = new Tool[numberoftools];
            int tempindex = 0;
            for(int i = 0; i < tools.Length; i++)
            {
                if(tools[i] != null)
                {
                    toolsarray[tempindex] = tools[i];
                    tempindex++;
                }
            }
            return toolsarray;
        }
    }
}
