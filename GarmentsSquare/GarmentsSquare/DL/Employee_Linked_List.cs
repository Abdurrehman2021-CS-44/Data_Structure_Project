using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarmentsSquare.BL;

namespace GarmentsSquare.DL
{
    internal class Employee_Linked_List
    {
        static Employee head = null; // declaring an empty doubly linked list

        static void insert_at_head(Employee n)
        {

            n.Next = head;

            if (head != null)
            {
                head.Prev = n;
            }
            head = n;
        }

        static void insert_at_tail(Employee n)
        {
            if (head == null)
            {
                insert_at_head(n);
                return;
            }
            Employee temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = n;
            n.Prev = temp;
        }

        static void display(Product head)
        {
            Product temp = head;
            while (temp != null)
            {
                Console.WriteLine("NULL");

            }

        }

        // Function to delete a node in a Doubly Linked List.
        // head_ref --> pointer to head node pointer.
        // del --> data of node to be deleted.
        static void deleteNode(Employee del)
        {

            // Base case
            if (head == null || del == null)
            {
                return;
            }

            // If node to be deleted is head node
            if (head == del)
            {
                head = del.Next;
            }

            // Change next only if node to be deleted
            // is NOT the last node
            if (del.Next != null)
            {
                del.Next.Prev = del.Prev;
            }

            // Change prev only if node to be deleted
            // is NOT the first node
            if (del.Prev != null)
            {
                del.Prev.Next = del.Next;
            }

            // Finally, free the memory occupied by del
            return;
        }

        // Function to delete the node at the
        // given position in the doubly linked list
        static void deleteNodeAtGivenPos(Employee head, int n)
        {
            /* if list in NULL or invalid position is given */
            if (head == null || n <= 0)
                return;

            Employee current = head;
            int i;

            /*
            * traverse up to the node at position 'n' from the beginning
            */
            for (i = 1; current != null && i < n; i++)
            {
                current = current.Next;
            }

            // if 'n' is greater than the number of nodes
            // in the doubly linked list
            if (current == null)
                return;

            // delete the node pointed to by 'current'
            deleteNode(current);
        }
    }
}
