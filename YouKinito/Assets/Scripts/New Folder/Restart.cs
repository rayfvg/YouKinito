using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
  public void RestartThisShit()
    {
        PlayerPrefs.SetInt("SceneID", 0);
        SceneManager.LoadScene(0);

    }
}
