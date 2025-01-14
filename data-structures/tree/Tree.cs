// TreeImplementation.cs
using System;

public class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Left { get; set; }
    public TreeNode<T> Right { get; set; }

    public TreeNode(T data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class Tree<T> where T : IComparable<T>
{
    private TreeNode<T> root;

    public Tree()
    {
        root = null;
    }

    public void Insert(T data)
    {
        root = InsertRec(root, data);
    }

    private TreeNode<T> InsertRec(TreeNode<T> node, T data)
    {
        if (node == null)
        {
            return new TreeNode<T>(data);
        }

        if (data.CompareTo(node.Data) < 0)
        {
            node.Left = InsertRec(node.Left, data);
        }
        else if (data.CompareTo(node.Data) > 0)
        {
            node.Right = InsertRec(node.Right, data);
        }

        return node;
    }

    public void Remove(T data)
    {
        root = RemoveRec(root, data);
    }

    private TreeNode<T> RemoveRec(TreeNode<T> node, T data)
    {
        if (node == null)
        {
            return null;
        }

        if (data.CompareTo(node.Data) < 0)
        {
            node.Left = RemoveRec(node.Left, data);
        }
        else if (data.CompareTo(node.Data) > 0)
        {
            node.Right = RemoveRec(node.Right, data);
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
            node.Data = FindMin(node.Right);

            // Delete the inorder successor
            node.Right = RemoveRec(node.Right, node.Data);
        }

        return node;
    }

    private T FindMin(TreeNode<T> node)
    {
        T minValue = node.Data;
        while (node.Left != null)
        {
            minValue = node.Left.Data;
            node = node.Left;
        }
        return minValue;
    }

    public void Update(T oldData, T newData)
    {
        Remove(oldData);
        Insert(newData);
    }

    public void PrintInOrder()
    {
        PrintInOrderRec(root);
        Console.WriteLine();
    }

    private void PrintInOrderRec(TreeNode<T> node)
    {
        if (node != null)
        {
            PrintInOrderRec(node.Left);
            Console.Write(node.Data + " ");
            PrintInOrderRec(node.Right);
        }
    }
}
