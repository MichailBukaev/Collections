using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Interfaces
{
  public interface IEnumerator
  {
    Object Current { get; }
    bool MoveNext();
    void Reset();
  }
}