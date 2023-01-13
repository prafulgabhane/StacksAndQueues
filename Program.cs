using System.Threading.Tasks;

namespace StackQueueUsingLinkedList
{
    public class Program
    {   
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocome to Stack & Queue Programs Using Linked list");

            Queue obj = new Queue();
            Console.WriteLine("After push the elements are : ");

            obj.enqueue(56);
            obj.enqueue(30);
            obj.enqueue(70);
            Console.WriteLine();
            Console.WriteLine("Top Element of the Queue is : " + obj.peek());

            //We can check other functios:
            Console.WriteLine("Item popped from stack = " + obj.pop());

        }
    }
}