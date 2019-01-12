using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void LoadeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        
    }
}
