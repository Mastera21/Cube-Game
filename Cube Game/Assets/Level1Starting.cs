using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Starting : MonoBehaviour
{
   
    public void LoadLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }
}
