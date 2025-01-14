Trie trie = new Trie();

// Insert words
trie.Insert("apple");
trie.Insert("app");
trie.Insert("banana");

Console.WriteLine("Words in Trie:");
trie.Print();

// Update a word
Console.WriteLine("\nUpdating 'app' to 'apply'");
trie.Update("app", "apply");

Console.WriteLine("Words in Trie:");
trie.Print();

// Remove a word
Console.WriteLine("\nRemoving 'banana'");
trie.Remove("banana");

Console.WriteLine("Words in Trie:");
trie.Print();

// Try to remove a word not in the Trie
Console.WriteLine("\nRemoving 'grape' (not in Trie)");
bool isRemoved = trie.Remove("grape");
Console.WriteLine(isRemoved ? "Removed 'grape'" : "'grape' not found");

Console.WriteLine("\nFinal Words in Trie:");
trie.Print();