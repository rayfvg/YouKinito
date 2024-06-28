using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFirder : MonoBehaviour
{
    private string passw = "кинито";

    public GameObject OpenScene;
    public GameObject CloseScene;

  public void SetPass(string pass)
    {
        if (pass.ToLower() == passw)
        {
            OpenScene.SetActive(true);
            CloseScene.SetActive(false);
        }
        else
        {
            return;
        }
    }
}
