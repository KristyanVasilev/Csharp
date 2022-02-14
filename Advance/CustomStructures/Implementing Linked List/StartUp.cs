using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var linkedList = new DoublyLinkedList();
            linkedList.AddFirst(new Node(1));
            linkedList.AddFirst(new Node(2));
            linkedList.AddFirst(new Node(3));

            linkedList.AddLast(new Node(1));
            linkedList.AddLast(new Node(2));
            linkedList.AddLast(new Node(3));

            Console.WriteLine($"Removed first element - {linkedList.RemoveFirst().Value}");
            Console.WriteLine($"Removed last element - {linkedList.RemoveLast().Value}");

            linkedList.ForEach(x => Console.WriteLine(x.Value));

            //var linkedList = new DoublyLinkedList<string>();
            //linkedList.AddFirst(new Node<string>("pesho"));
            //Console.WriteLine($"Removed first element - {linkedList.RemoveFirst().Value}");




        }
    }
}
/*In this workshop, we are going to create another custom data structure, which has similar functionalities as the C# doubly linked list.
 * Just like the structures from the previous workshop, our custom doubly linked list will work only with integers. It will have the following functionalities: 
 
      •	void AddFirst(int element) – adds an element at the beginning of the collection
      •	void AddLast(int element) – adds an element at the end of the collection
      •	int RemoveFirst() – removes the element at the beginning of the collection
      •	int RemoveLast() – removes the element at the end of the collection
      •	void ForEach() – goes through the collection and executes a given action
      •	int[] ToArray() – returns the collection as an array

Feel free to implement your functionality or to write the methods by yourself. 
*/
