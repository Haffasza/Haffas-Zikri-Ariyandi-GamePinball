using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioS;
    public GameObject SFXAudioS;

    // Start is called before the first frame update
    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioS.Play();
    }
    // Update is called once per frame
    public void PlaySFX(Vector3 SpawnPosition)
    {
        GameObject.Instantiate(SFXAudioS, SpawnPosition, Quaternion.identity);
    }
}
