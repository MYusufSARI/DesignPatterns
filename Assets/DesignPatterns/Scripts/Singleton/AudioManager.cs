using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private Queue<AudioSource> audioSources = new Queue<AudioSource>();

    private AudioSource audioSource;



    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayClipAtPoint(AudioClip audioClip, Vector3 point)
    {
        if (transform.childCount>0)
        {
            return;
        }

        for (int i = 0; i < 10; i++)
        {
            var audioSourceGameObject = new GameObject("Audio Source" + i);
            audioSourceGameObject.transform.SetParent(transform);

            var audioSource = audioSourceGameObject.AddComponent<AudioSource>();
            audioSources.Enqueue(audioSource);
        }
    }
}
