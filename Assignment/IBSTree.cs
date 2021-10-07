using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    interface IBSTree
    {
		// pre: true
		// post: return true if the binary tree is empty; otherwise, return false.
		bool IsEmpty();

		// pre: true
		// post: item is added to the binary search tree
		void Insert(Member item);

		// pre: true
		// post: an occurrence of item is removed from the binary search tree 
		//		 if item is in the binary search tree
		void Delete(Member item);

		// pre: true
		// post: return true if item is in the binary search true;
		//	     otherwise, return false.
		bool Search(Member item);

		// pre: true
		// post: all the nodes in the binary tree are visited once and only once in in-order
		void InOrderTraverse();

		// pre: true
		// post: all the nodes in the binary tree are removed and the binary tree becomes empty
		void Clear();
	}
}
