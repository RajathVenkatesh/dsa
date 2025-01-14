
public class LinkedListNode {

    public int _data;
    public LinkedListNode _next;

    public LinkedListNode(int data)
    {
        _data = data;
        _next = null;
    }

}


public class LinkedList {
 
    LinkedListNode _head;

    public LinkedList()
    {
        _head = null;
    }

    public void AddNodeToHead(int data) {
        var node = new LinkedListNode(data);
        node._next = _head;
        _head = node;
    }


    public void PrintLinkedList() {
        LinkedListNode runner = _head;

        while(runner != null) {
            System.Console.WriteLine(runner._data);
            runner = runner._next;
        }
    }


    public void AddNodeAtPosition(int data, int position) {
        var node = new LinkedListNode(data);

        if(position == 0){
            node._next = _head;
            _head = node;
            return;
        }

        var currentNode = _head;
        int currentIndex = 0;

        while(currentNode != null && currentIndex < position - 1) {
            currentNode = currentNode._next;
            currentIndex++;
        }


        node._next = currentNode._next;
        currentNode._next = node;

    }

    public void removeNodeAtPosition(int position) {
        
        if(position == 0){
            _head = _head._next;
            return;
        }

        var currentNode = _head;
        int currentIndex = 0;

        while(currentNode != null && currentIndex < position - 1) {
            currentNode = _head._next;
            currentIndex++;
        }

        if (currentNode == null || currentNode._next == null) {
            throw new ArgumentOutOfRangeException(nameof(position), "Position is out of bounds.");
        }

        currentNode._next = currentNode._next._next;

    }


}