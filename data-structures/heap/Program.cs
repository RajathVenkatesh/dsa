Heap<int> minHeap = new Heap<int>();

        Console.WriteLine("Inserting elements: 5, 3, 8, 1, 9");
        minHeap.Insert(5);
        minHeap.Insert(3);
        minHeap.Insert(8);
        minHeap.Insert(1);
        minHeap.Insert(9);
        
        Console.WriteLine("Heap after insertions:");
        minHeap.PrintHeap();

        Console.WriteLine("\nRemoving the root element:");
        minHeap.Remove();
        minHeap.PrintHeap();

        Console.WriteLine("\nUpdating element at index 1 to 2:");
        minHeap.Update(1, 2);
        minHeap.PrintHeap();

        Console.WriteLine("\nFinal Heap:");
        minHeap.PrintHeap();