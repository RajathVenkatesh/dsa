using System;
using System.Collections.Generic;

public class TrieNode
{
    public char Character { get; set; }
    public Dictionary<char, TrieNode> Children { get; set; } = new Dictionary<char, TrieNode>();
    public bool IsEndOfWord { get; set; } = false;

    public TrieNode(char character)
    {
        Character = character;
    }
}

public class Trie
{
    private TrieNode root = new TrieNode(' ');

    // Insert a word into the Trie
    public void Insert(string word)
    {
        TrieNode current = root;
        foreach (var ch in word)
        {
            if (!current.Children.ContainsKey(ch))
            {
                current.Children[ch] = new TrieNode(ch);
            }
            current = current.Children[ch];
        }
        current.IsEndOfWord = true;
    }

    // Remove a word from the Trie
    public bool Remove(string word)
    {
        return Remove(root, word, 0);
    }

    private bool Remove(TrieNode current, string word, int index)
    {
        if (index == word.Length)
        {
            if (!current.IsEndOfWord) return false;
            current.IsEndOfWord = false;
            return current.Children.Count == 0;
        }

        char ch = word[index];
        if (!current.Children.ContainsKey(ch)) return false;

        bool shouldDeleteChild = Remove(current.Children[ch], word, index + 1);

        if (shouldDeleteChild)
        {
            current.Children.Remove(ch);
            return current.Children.Count == 0 && !current.IsEndOfWord;
        }

        return false;
    }

    // Update a word in the Trie
    public void Update(string oldWord, string newWord)
    {
        Remove(oldWord);
        Insert(newWord);
    }

    // Print all words in the Trie
    public void Print()
    {
        Print(root, "");
    }

    private void Print(TrieNode node, string prefix)
    {
        if (node.IsEndOfWord)
        {
            Console.WriteLine(prefix);
        }

        foreach (var child in node.Children.Values)
        {
            Print(child, prefix + child.Character);
        }
    }
}
