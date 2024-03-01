using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject switchVFXSource;
     public GameObject VFXAudioS;
    // Start is called before the first frame update
     public void PlayVFX(Vector3 SpawnPosition)
    {
        GameObject.Instantiate(VFXAudioS, SpawnPosition, Quaternion.identity);
    }

    public void PlaySwitchVFX(Vector3 spawnPosition)
    {
        GameObject sfxObject = Instantiate(switchVFXSource, spawnPosition, Quaternion.identity);
    }
}
