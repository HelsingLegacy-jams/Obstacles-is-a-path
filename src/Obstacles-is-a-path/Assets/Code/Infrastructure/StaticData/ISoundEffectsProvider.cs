using UnityEngine;

namespace Code.Infrastructure.StaticData
{
  public interface ISoundEffectsProvider
  {
    AudioClip ForClip(SFxId typeId);
  }
}