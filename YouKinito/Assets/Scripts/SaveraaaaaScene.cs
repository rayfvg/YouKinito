using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveraaaaaScene : MonoBehaviour
{
    public int SceneID;
    private void Start()
    {
        PlayerPrefs.SetInt("SceneID", SceneID);
    }
}
