using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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
        throw new NotImplementedException();
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

    public void DeleteOcurrence()
    {
        throw new NotImplementedException();
    }

    public void DeleteAllOcurrences()
    {
        throw new NotImplementedException();
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
