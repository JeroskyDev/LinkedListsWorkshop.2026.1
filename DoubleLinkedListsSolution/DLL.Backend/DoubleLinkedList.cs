using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DLL.Backend;

public class DoubleLinkedList<T>
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
        var newNode = new Node<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }
    }

    public string ShowForward()
    {
        throw new NotImplementedException();
    }

    public string ShowBackwards()
    {
        throw new NotImplementedException();
    }

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

    public bool Exists()
    {
        throw new NotImplementedException();
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
