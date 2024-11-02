using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Infrastructure.Services.Scenes.Bootstrap
{
#if UNITY_EDITOR
    public class StartFromInitialSceneInEditor : MonoBehaviour
    {

      private const int EnterSceneIndex = 0;
      
      private void Awake()
      {
        if(ProjectContext.HasInstance)
          return;

        foreach (GameObject root in gameObject.scene.GetRootGameObjects()) 
          root.SetActive(false);
      
        SceneManager.LoadScene(EnterSceneIndex);
      }

    }
#endif
}
