using System;
using System.Collections.Generic;
using Code.Infrastructure.StaticData.Data;
using UnityEngine;

namespace Code.Infrastructure.StaticData
{
  public class StaticDataService : IStaticDataServiceBinder, ISoundEffectsProvider
  {
    private const string SoundsDataPath = "StaticData/SoundEffects";
    
    private Dictionary<SFxId, AudioClip> _clips;

    public AudioClip ForClip(SFxId typeId) =>
      _clips.TryGetValue(typeId, out AudioClip clip)
        ? clip
        : throw new Exception($"Audio Clip config for {clip} does not exist!");

    public void BindStaticData()
    {
      BindSoundEffects();
    }
    
    private void BindSoundEffects()
    {
      List<SFxData> sFxDatas = Resources.Load<SoundEffectsData>(SoundsDataPath).Data;
      
      _clips = new Dictionary<SFxId, AudioClip>(sFxDatas.Count);
      
      foreach (SFxData data in sFxDatas)
        _clips.Add(data.Id, data.Clip);
    }
  }
}