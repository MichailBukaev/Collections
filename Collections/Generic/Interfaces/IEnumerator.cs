using Collections.Interfaces;
using System;

namespace Collections.Generic.Interfaces
{
  public interface IEnumerator<out T> : IDisposable, IEnumerator
  {
    new T Current { get; }
  }
}