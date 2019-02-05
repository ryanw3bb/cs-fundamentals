// Linked list data structure
//
// Compared to a normal list it's much faster to insert and delete items.
// A good example would be prepending items to the LinkedList, in a normal list
// everything will need to be shifted down by 1. Not in a linked list.
// 
// A downside of LinkedLists is random access is not possible without iterating the list (access by index)
//
// A linked list is technically larger to store in memory though as it must hold a
// reference to both the before and after (rather than an array based list which is just
// a load of references).
//
// Time complexity:
// Access (by index): O(n)
// Search: O(n)
// Insertion: O(1) 
// Deletion: O(1)
//
// Note: insertion and deletion doesn't including finding the node (which would be O(n))

namespace CS
{
    public class LinkedList
    {
        private Node head;

        public void AddFirst(string data)
        {
            Node newNode = new Node
            {
                Data = data
            };

            if(head != null)
            {
                head.Previous = newNode;
                newNode.Next = head;
            }

            head = newNode;
        }

        public void AddLast(string data)
        {
            Node newNode = new Node
            {
                Data = data
            };

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }

                newNode.Previous = current;
                current.Next = newNode;
            }
        }

        public Node Find(string data)
        {
            Node current = head;
            while(current.Next != null)
            {
                if(current.Data == data)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public void AddBefore(Node node, string data)
        {
            Node current = head;
            while(current.Next != null)
            {
                if(current == node)
                {
                    Node newNode = new Node
                    {
                        Data = data,
                        Next = current,
                        Previous = current.Previous
                    };

                    Node prev = current.Previous;
                    prev.Next = newNode;

                    current.Previous = newNode;

                    break;
                }

                current = current.Next;
            }
        }

        public void AddAfter(Node node, string data)
        {
            Node current = head;
            while(current.Next != null)
            {
                if(current == node)
                {
                    Node newNode = new Node
                    {
                        Data = data,
                        Previous = current,
                        Next = current.Next
                    };

                    Node next = current.Next;
                    next.Previous = newNode;

                    current.Next = newNode;

                    break;
                }

                current = current.Next;
            }
        }

        public override string ToString()
        {
            string list = "";

            Node current = head;
            while(current.Next != null)
            {
                list += string.Format("{0}, ", current.Data);
                current = current.Next;
            }

            list += current.Data;

            return list;
        }
    }

    public class Node
    {
        public Node Next;
        public Node Previous;
        public string Data;
    }
}