using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTest : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void GoToNewScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}
