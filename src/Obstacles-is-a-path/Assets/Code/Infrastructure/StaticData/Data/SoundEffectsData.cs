using System.Collections.Generic;
using UnityEngine;

namespace Code.Infrastructure.StaticData.Data
{
  [CreateAssetMenu(menuName = "StaticData/SFX", fileName = "SoundEffects", order = 20)]
  public class SoundEffectsData : ScriptableObject
  {
    public List<SFxData> Data;
  }
}