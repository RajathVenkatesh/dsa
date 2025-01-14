using System;

public class TreeNode<TKey, TValue> where TKey : IComparable<TKey>
{
    public TKey Key { get; set; }
    public TValue Data { get; set; }
    public TreeNode<TKey, TValue> Left { get; set; }
    public TreeNode<TKey, TValue> Right { get; set; }

    public TreeNode(TKey key, TValue data)
    {
        Key = key;
        Data = data;
        Left = null;
        Right = null;
    }
}

public class Tree<TKey, TValue> where TKey : IComparable<TKey>
{
    private TreeNode<TKey, TValue> root;

    public Tree()
    {
        root = null;
    }

    public void Insert(TKey key, TValue data)
    {
        root = InsertRec(root, key, data);
    }

    private TreeNode<TKey, TValue> InsertRec(TreeNode<TKey, TValue> node, TKey key, TValue data)
    {
        if (node == null)
        {
            return new TreeNode<TKey, TValue>(key, data);
        }

        if (key.CompareTo(node.Key) < 0)
        {
            node.Left = InsertRec(node.Left, key, data);
        }
        else if (key.CompareTo(node.Key) > 0)
        {
            node.Right = InsertRec(node.Right, key, data);
        }

        return node;
    }

    public void Remove(TKey key)
    {
        root = RemoveRec(root, key);
    }

    private TreeNode<TKey, TValue> RemoveRec(TreeNode<TKey, TValue> node, TKey key)
    {
        if (node == null)
        {
            return null;
        }

        if (key.CompareTo(node.Key) < 0)
        {
            node.Left = RemoveRec(node.Left, key);
        }
        else if (key.CompareTo(node.Key) > 0)
        {
            node.Right = RemoveRec(node.Right, key);
        }
        else
        {
            // Node with only one child or no child
            if (node.Left == null)
            {
                return node.Right;
            }
            else if (node.Right == null)
            {
                return node.Left;
            }

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            node.Key = FindMin(node.Right).Key;
            node.Data = FindMin(node.Right).Data;

            // Delete the inorder successor
            node.Right = RemoveRec(node.Right, node.Key);
        }   

        return node;
    }

    private TreeNode<TKey, TValue> FindMin(TreeNode<TKey, TValue> node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node;
    }

    public void Update(TKey key, TValue newData)
    {
        TreeNode<TKey, TValue> node = FindNode(root, key);
        if (node != null)
        {
            node.Data = newData;
        }
        else
        {
            throw new ArgumentException("Key not found in tree.");
        }
    }

    private TreeNode<TKey, TValue> FindNode(TreeNode<TKey, TValue> node, TKey key)
    {
        if (node == null || key.CompareTo(node.Key) == 0)
        {
            return node;
        }

        if (key.CompareTo(node.Key) < 0)
        {
            return FindNode(node.Left, key);
        }
        else
        {
            return FindNode(node.Right, key);
        }
    }

    public void PrintInOrder()
    {
        PrintInOrderRec(root);
        Console.WriteLine();
    }

    private void PrintInOrderRec(TreeNode<TKey, TValue> node)
    {
        if (node != null)
        {
            PrintInOrderRec(node.Left);
            Console.WriteLine($"Key: {node.Key}, Data: {node.Data}");
            PrintInOrderRec(node.Right);
        }
    }
}
