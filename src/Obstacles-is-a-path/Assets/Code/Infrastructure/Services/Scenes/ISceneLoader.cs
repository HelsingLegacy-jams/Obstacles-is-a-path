using System;
using System.Collections;
using Code.Infrastructure.Common.Coroutines;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.Services.Scenes
{
  public interface ISceneLoader
  {
    void Load(string name, Action onLoaded = null);
  }

  public class SceneLoader : ISceneLoader
  {
    private readonly ICoroutineRunner _coroutineRunner;

    public SceneLoader(ICoroutineRunner coroutineRunner)
    {
      _coroutineRunner = coroutineRunner;
    }

    public void Load(string name, Action onLoaded = null)
    {
      _coroutineRunner.StartCoroutine(LoadScene(name, onLoaded));
    }

    private IEnumerator LoadScene(string name, Action onLoaded = null)
    {
      if (SceneManager.GetActiveScene().name == name) 
        onLoaded?.Invoke();

      AsyncOperation waitScene = SceneManager.LoadSceneAsync(name);

      while (!waitScene.isDone)
        yield return null;
      
      onLoaded?.Invoke();
    }
  }
}