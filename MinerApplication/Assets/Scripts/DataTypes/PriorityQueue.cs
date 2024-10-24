using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriorityQueue <T> where T : Desire
{
    private List<T> data;

    public PriorityQueue()
    {
        data = new List<T>();
    }

    public void Enqueue(T item)
    {
        data.Add(item);
        int childIndex = data.Count - 1;
        while (childIndex > 0)
        {
            int parentIndex = (childIndex - 1) / 2;
            if (data[childIndex].CompareTo(data[parentIndex]) >= 0)
                break;
            (data[parentIndex], data[childIndex]) = (data[childIndex], data[parentIndex]);
            childIndex = parentIndex;
        }
    }

    public T Dequeue()
    {
        if (data.Count <= 0)
        {
            Debug.LogError("ERROR: Can't Dequeue an empty Queue");
            return null;
        }

        // Assumes pq isn't empty
        int lastIndex = data.Count - 1;
        T frontItem = data[0];
        data[0] = data[lastIndex];
        data.RemoveAt(lastIndex);

        --lastIndex;
        int parentIndex = 0;
        while (true)
        {
            int childIndex = parentIndex * 2 + 1;
            if (childIndex > lastIndex) break;
            int rightChild = childIndex + 1;
            if (rightChild <= lastIndex && data[rightChild].CompareTo(data[childIndex]) < 0)
                childIndex = rightChild;
            if (data[parentIndex].CompareTo(data[childIndex]) <= 0) break;
            (data[childIndex], data[parentIndex]) = (data[parentIndex], data[childIndex]);
            parentIndex = childIndex;
        }
        return frontItem;
    }
}
