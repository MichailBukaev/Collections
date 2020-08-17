using Collections.Interfaces;

namespace Collections.Generic.Interfaces
{
  public interface IEnumerable<out T> : IEnumerable
  {
    new IEnumerator<T> GetEnumerator();
  }
}