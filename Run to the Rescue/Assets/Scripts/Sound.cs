using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound : MonoBehaviour
{
        public string name;
        public AudioClip clip;

        [Range(0f, 3f)]
        public float volume;
        [Range(.3f, 3f)]
        public float pitch;

        public bool loop;

        [HideInInspector]
        public AudioSource source;
}
