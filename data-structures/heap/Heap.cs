// Heap.cs
using System;
using System.Collections.Generic;

public class Heap<T> where T : IComparable<T>
{
    private List<T> _elements = new List<T>();

    public int Count => _elements.Count;

    public void Insert(T item)
    {
        _elements.Add(item);
        HeapifyUp(_elements.Count - 1);
    }

    public T Remove()
    {
        if (Count == 0) throw new InvalidOperationException("Heap is empty.");

        T root = _elements[0];
        _elements[0] = _elements[^1]; // Swap root with the last element
        _elements.RemoveAt(_elements.Count - 1);
        HeapifyDown(0);

        return root;
    }

    public void Update(int index, T newValue)
    {
        if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");

        T oldValue = _elements[index];
        _elements[index] = newValue;

        if (newValue.CompareTo(oldValue) < 0)
            HeapifyUp(index);
        else
            HeapifyDown(index);
    }

    public void PrintHeap()
    {
        Console.WriteLine(string.Join(", ", _elements));
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (_elements[index].CompareTo(_elements[parentIndex]) >= 0) break;

            Swap(index, parentIndex);
            index = parentIndex;
        }
    }

    private void HeapifyDown(int index)
    {
        int lastIndex = _elements.Count - 1;

        while (true)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int smallestIndex = index;

            if (leftChildIndex <= lastIndex && _elements[leftChildIndex].CompareTo(_elements[smallestIndex]) < 0)
                smallestIndex = leftChildIndex;

            if (rightChildIndex <= lastIndex && _elements[rightChildIndex].CompareTo(_elements[smallestIndex]) < 0)
                smallestIndex = rightChildIndex;

            if (smallestIndex == index) break;

            Swap(index, smallestIndex);
            index = smallestIndex;
        }
    }

    private void Swap(int index1, int index2)
    {
        T temp = _elements[index1];
        _elements[index1] = _elements[index2];
        _elements[index2] = temp;
    }
}
