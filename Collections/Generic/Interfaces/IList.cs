using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Generic.Interfaces
{
  public interface IList<T>:ICollection<T>
  {
    int IndexOf(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
  }
}
