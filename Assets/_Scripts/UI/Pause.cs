using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static Pause instance;

    private void Awake()
    {
        instance = this;
    }

    public void FreezeGame()
    {
        Time.timeScale = 0;
    }

    public void UnFreezeGame()
    {
        Time.timeScale = 1;
    }
}
