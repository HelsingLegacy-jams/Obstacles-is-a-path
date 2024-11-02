using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Infrastructure.Services.Scenes.Bootstrap
{
    public class StartFromInitialSceneInEditor : MonoBehaviour
    {
#if UNITY_EDITOR
      private const int EnterSceneIndex = 0;
      
      private void Awake()
      {
        if(ProjectContext.HasInstance)
          return;
      
        SceneManager.LoadScene(EnterSceneIndex);
      }
#endif
    }
}
