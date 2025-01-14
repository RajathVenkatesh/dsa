 Tree<int> tree = new Tree<int>();

Console.WriteLine("Inserting elements...");
tree.Insert(50);
tree.Insert(30);
tree.Insert(70);
tree.Insert(20);
tree.Insert(40);
tree.Insert(60);
tree.Insert(80);

Console.WriteLine("Tree after insertion:");
tree.PrintInOrder();

Console.WriteLine("\nRemoving 50...");
tree.Remove(50);
Console.WriteLine("Tree after removal:");
tree.PrintInOrder();

Console.WriteLine("\nUpdating 40 to 45...");
tree.Update(40, 45);
Console.WriteLine("Tree after update:");
tree.PrintInOrder();