namespace LinkedList
{
    internal partial class Program
    {
        public class SinglyLinkedList
        {
            public Node head;

            public void InsertFirst(int value)
            {
                var new_node = new Node();
                new_node.data = value;
                new_node.next = head;
                head = new_node;
            }
            
            
            
        }
    }
}