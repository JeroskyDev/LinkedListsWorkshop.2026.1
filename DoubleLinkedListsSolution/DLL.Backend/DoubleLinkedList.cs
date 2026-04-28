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
    public void Add()
    {
        throw new NotImplementedException();
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
        return base.ToString();
    }
}
