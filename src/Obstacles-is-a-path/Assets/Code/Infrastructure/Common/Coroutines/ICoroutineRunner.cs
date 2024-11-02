using System.Collections;
using UnityEngine;

namespace Code.Infrastructure.Common.Coroutines
{
  public interface ICoroutineRunner
  {
    Coroutine StartCoroutine(IEnumerator enumerator);
  }
}