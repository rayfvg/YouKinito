using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderPizdec : MonoBehaviour
{
    private int SceneID;


    private void Awake()
    {
        
        
        SceneID = PlayerPrefs.GetInt("SceneID");
        if(SceneID == 0)
        {
            SceneManager.LoadScene(SceneID + 1);
        }
        else
        {
            SceneManager.LoadScene(SceneID);
        }
       
    }
}
