using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInputPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioManager.instance.PlayClipAtPoint(audioClip, Vector3.zero);
        }
    }
}
