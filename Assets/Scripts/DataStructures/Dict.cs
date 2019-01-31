using System;
using System.Collections.Generic;
using System.Linq;

public class Dict 
{
    public LinkedList<Entry>[] Items;

    private const int START_SIZE = 4;

    private int entryCount;

    public Dict()
    {
        Items = new LinkedList<Entry>[START_SIZE];
    }

    public Entry Get(string key)
    {
        int pos = GetPosition(key, Items.Length);

        foreach(Entry item in Items[pos].Where(item => item.Key.Equals(key)))
        {
            return item;
        }

        throw new Exception("Key does not exist");
    }

    public void Add(string key, object value)
    {
        int pos = GetPosition(key, Items.Length);

        if(Items[pos] == null)
        {
            Items[pos] = new LinkedList<Entry>();
        }
        else if(Items[pos].Any(x => x.Key.Equals(key)))
        {
            throw new Exception("Duplicate key, cannot insert");
        }

        Items[pos].AddLast(new Entry(key, value));

        entryCount++;

        if(entryCount >= Items.Length)
        {
            Resize(true);
        }
    }

    public void Remove(string key)
    { 
        int pos = GetPosition(key, Items.Length);

        if(Items[pos] != null)
        {
            Entry toRemove = Items[pos].FirstOrDefault(item => item.Key.Equals(key));

            if(Items[pos].Contains(toRemove))
            {
                Items[pos].Remove(toRemove);
                entryCount--;

                if(entryCount < Items.Length / 2)
                {
                    Resize(false);
                }
            }
        }
    }

    private int GetPosition(string key, int length)
    {
        int hash = key.GetHashCode();
        int pos = Math.Abs(hash % length);

        return pos;
    }

    private void Resize(bool increase)
    {
        int newSize = increase ? Items.Length * 2 : Items.Length / 2;
        newSize = Math.Max(newSize, START_SIZE);

        LinkedList<Entry>[] resizedItems = new LinkedList<Entry>[newSize];

        foreach(LinkedList<Entry> list in Items)
        {
            if(list == null) { continue; }

            foreach(Entry entry in list)
            {
                int pos = GetPosition(entry.Key, resizedItems.Length);

                if(resizedItems[pos] == null)
                {
                    resizedItems[pos] = new LinkedList<Entry>();
                }

                resizedItems[pos].AddLast(entry);
            }
        }

        Items = resizedItems;
    }
}

public struct Entry
{
    public string Key;
    public object Value;

    public Entry(string key, object value)
    {
        Key = key;
        Value = value;
    }
}