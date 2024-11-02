using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.Bootstrap
{
    public class StartFromInitialSceneInEditor : MonoBehaviour
    {
#if UNITY_EDITOR
      // private const int EnterSceneIndex = 1;
      //
      // private void Awake()
      // {
      //   if(ProjectContext.HasInstance)
      //     return;
      //
      //   SceneManager.LoadScene(EnterSceneIndex);
      // }
#endif
    }
}
