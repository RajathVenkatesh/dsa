Console.WriteLine("Add Nodes");

var linkedList = new LinkedList();

linkedList.AddNodeToHead(1);
linkedList.AddNodeToHead(2);
linkedList.AddNodeAtPosition(11, 1);
linkedList.AddNodeAtPosition(12, 2);
linkedList.PrintLinkedList();


Console.WriteLine("Remove Nodes");

linkedList.removeNodeAtPosition(3);
linkedList.PrintLinkedList();

Console.ReadLine(); 