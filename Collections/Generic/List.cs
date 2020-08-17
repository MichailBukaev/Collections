using Collections.Generic.Interfaces;
using Collections.Interfaces;

namespace Collections.Generic
{
  public class List<T> : IList<T>
  {
    public IEnumerator<T> GetEnumerator()
    {
      throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}