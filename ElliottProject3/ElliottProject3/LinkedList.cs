using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElliottProject3
{
    internal class LinkedList
    {
        private Link root = null; //variable for start of link 

        //Method to add a new one to list
        public void AddToList(int value)
        {
            //Two conditions - root is null or not null
            if (root == null)
            {
                //First need to create a new link
                root = new Link();
                //Second set the values
                root.value = value;
            }
            else
            {
                //Adds value to list
                addFirst(value);
            }
        }
        private void addFirst(int value)
        {
            Link newLink = new Link(); //New link
            newLink.value = value; //Assigns value to new link
            newLink.nextLink = root; //Takes current root and sets it to the next link
            root = newLink; //Changes the root to the new link
        }

        public void add(int value)
        {
            if (root == null)
            {
                //First need to create a new link
                root = new Link();
                //Second set the values
                root.value = value;
            }
            else
            {
                recAdd(value, root);
            }
        }
        private void recAdd(int value, Link myLink)
        {
            //Add a new value to the end of the list
            //Can find because it will have a null pointing to the next link
            if (myLink.nextLink == null) // made it to the last one in the list
            {
                Link temp = new Link(); //temporary link
                temp.value = value;
                myLink.nextLink = temp; //adds a new one to end of list
            }
            else
            {
                //Recursion starts here
                recAdd(value, myLink.nextLink);
            }
        }

        public int? remove()
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                int? value = null;
                recRemove(ref value, ref root);
                return value;
            }
        }

        private void recRemove(ref int? value, ref Link myLink)
        {
            if (myLink.nextLink == null)
            {
                value = myLink.value;
                myLink = null;
                
            }
            else
                recRemove(ref value, ref myLink.nextLink);
        }

        public int? removeFirst()
        {   
            if(root == null)
            {
                return null;
            }
            else
            {
                int? value = root.value;
                //Removes the original root and replaces it with the second link in the list
                root = root.nextLink;
                return value;
            }         
        }

        //Method checks if there are values in the list
        public bool CValue()
        {
            if (root == null)
            {
                return false;
            }
            else
                return true;
        }
        //Creates a string containing the values in the linked list
        public string printOut()
        {
            string listString = "";
            if (CValue())
                recPrintOut(root, ref listString);
            return listString;
        }
        //Recursively adds to a string using the next link in the list
        private void recPrintOut(Link list, ref string listString)
        {
            if (list != null)
            {
                listString += list.value.ToString() + ", ";
                //Go to the next link in the list and continue to add to the string
                recPrintOut(list.nextLink, ref listString);
            }
        }

    }
}
