 Tree<int, string> tree = new Tree<int, string>();

Console.WriteLine("Inserting elements...");
tree.Insert(50, "Node50");
tree.Insert(30, "Node30");
tree.Insert(70, "Node70");
tree.Insert(20, "Node20");
tree.Insert(40, "Node40");
tree.Insert(60, "Node60");
tree.Insert(80, "Node80");

Console.WriteLine("Tree after insertion:");
tree.PrintInOrder();

Console.WriteLine("\nRemoving key 50...");
tree.Remove(50);
Console.WriteLine("Tree after removal:");
tree.PrintInOrder();

Console.WriteLine("\nUpdating key 40 with new data 'UpdatedNode40'...");
tree.Update(40, "UpdatedNode40");
Console.WriteLine("Tree after update:");
tree.PrintInOrder();