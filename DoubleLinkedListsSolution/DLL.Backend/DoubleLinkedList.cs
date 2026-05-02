using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DLL.Backend;

public class DoubleLinkedList<T> where T : IComparable<T>
{
    //fields
    private Node<T>? _head;
    private Node<T>? _tail;

    //constructor
    public DoubleLinkedList()
    {
        _head = null;
        _tail = null;
    }

    //methods to do:
    public void Add(T data)
    {
        /*make implementation similar to InsertInOrder method i already did in Zulu´s classes*/
        var newNode = new Node<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }
        var current = _head;
        if(newNode.Data.CompareTo(_head.Data) < 0)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
            return;
        }    
        while (current.Next != null)
        {
            if(newNode.Data.CompareTo(current.Next.Data) < 0)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                newNode.Previous = current; 
                newNode.Next.Previous = newNode; 
                return;
            }
            current = current.Next;
        }
        current.Next = newNode;
        newNode.Previous = current;
        _tail = newNode;
    }

    /*
    public string ShowForward() //this method is done alrready, is the ToString() override.
    {
        throw new NotImplementedException();
    }
    */

    /*
    public string ShowBackwards() //this method is done already, is the ToStringReverse() at the end.
    {
        throw new NotImplementedException();
    }
    */
    public void OrderDescending()
    {
        //same bubble sort that i used when making the ascending order, but instead of making the swap when the actual node was higher than the next one, do it when the actual node is lower.
        if (_head == null || _head.Next == null) return;
        bool swapped;
        do
        {
            swapped = false;
            var current = _head;
            while (current.Next != null)
            {
                if (current.Data.CompareTo(current.Next.Data) < 0)
                {
                    swapped = true;
                    var temp = current.Data;
                    current.Data = current.Next.Data;
                    current.Next.Data = temp;
                }
                current = current.Next;
            }
        } while (swapped);
    }

    public string ShowMode()
    {
        throw new NotImplementedException();
    }

    public string ShowGraph()
    {
        throw new NotImplementedException();
    }

    public bool Exists(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void DeleteOcurrence(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                if (current == _head)
                {
                    _head = _head.Next;
                    _head!.Previous = null;
                }
                else if (current == _tail)
                {
                    _tail = _tail.Previous;
                    _tail!.Next = null;
                }
                else
                {
                    current.Previous!.Next = current.Next;
                    current.Next!.Previous = current.Previous;
                }
                return;
            }
            current = current.Next;
        }
    }

    public void DeleteAllOcurrences(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                if (current == _head)
                {
                    _head = _head.Next;
                    _head!.Previous = null;
                    current = _head; //continue after eliminating the first ocurrence, until we find another.
                    continue; //to prevent the code of iterating the remaining conditions, so when an ocurrence gets deleted, the iteration starts again.
                }
                else if (current == _tail)
                {
                    _tail = _tail.Previous;
                    _tail!.Next = null;
                    current = null; //because we eliminated the last node here, then, we just stop the loop.
                    continue;
                }
                else
                {
                    current.Previous!.Next = current.Next;
                    current.Next!.Previous = current.Previous;
                    current = current.Next;
                    continue;
                }
            }
            current = current.Next;
            //i deleted the return so it iterates through all of the ocurrences instead of just one with the return. This is why this method is so similar to DeleteOcurrence().
        }
    }

    //private methods
    override public string ToString()
    {
        var current = _head;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }
        result += "null";
        return result;
    }

    public string ToStringReverse()
    {
        var current = _tail;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Previous;
        }
        result += "null";
        return result;
    }

}
