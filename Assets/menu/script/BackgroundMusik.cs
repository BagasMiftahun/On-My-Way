using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusik : MonoBehaviour
{
    private static BackgroundMusik backgroundMusic;
    void Awake()
    {
        if (backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
