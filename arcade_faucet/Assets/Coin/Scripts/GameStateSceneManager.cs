using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateSceneManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        // Make the game run as fast as possible
        Application.targetFrameRate = 120;
    }
}
