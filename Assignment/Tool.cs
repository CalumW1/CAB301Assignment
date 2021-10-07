using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Tool : iTool
    {
        public Tool(string name, int quantity, int availablequantity, int noborrowings)
        {
            Name = name;
            Quantity = quantity;
            AvailableQuantity = availablequantity;
            NoBorrowings = noborrowings;
 
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int NoBorrowings { get; set; }
        iMemberCollection iTool.GetBorrowers { get;  }

        private MemberCollection storetools = new MemberCollection();

        public void addBorrower(Member member)
        {
            // add a new borrower
            storetools.add(member);
        }

        public void deleteBorrower(Member member)
        {
            // remove a borrower
            storetools.delete(member);
        }
    }
}
