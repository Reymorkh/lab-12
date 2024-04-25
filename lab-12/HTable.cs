


namespace lab_12
{
  internal class HTable<T>
  {
    public Node<T>[]? table;
    public int Size { get; set; }

    public HTable(int size)
    {
      Size = size;
      table = new Node<T>[Size];
    }

    public bool Add(T item)
    {
      Node<T> point = new Node<T>(item);
      if (item == null)
        return false;
      int index = Math.Abs(point.GetHashCode()) % Size;
      if (table[index] == null)
        table[index] = point;
      else
      {
        Node<T> cur = table[index];
        if (string.Compare(cur.ToString(), point.ToString()) == 0)
          return false;
        while (cur.Next != null)
        {
          if (string.Compare(cur.ToString(), point.ToString()) == 0)
            return false;
          cur = cur.Next;
        }
        cur.Next = point;
      }
      return true;
    }

    public Node<T> this[int index] { get => table[index] == null ? throw new Exception("") : table[index]; }



  }

  class Node<T>
  {
    public int key;
    public T? Value { get; set; }

    public Node<T>? Next { get; set; }
    public Node(T item)
    {
      Value = item;
      key = GetHashCode();
      Next = null;
    }

    public override string ToString()
    {
      return Value == null ? "0" : key + ":" + Value.ToString();
    }
    public override int GetHashCode()
    {
      return Value == null ? 0 : Value.GetHashCode();
    }




  }
}
