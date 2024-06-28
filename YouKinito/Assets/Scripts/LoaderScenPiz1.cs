using UnityEngine;

public class LoaderScenPiz1 : MonoBehaviour
{

    public GameObject[] Scenes;
    private int id2;

    private void Awake()
    {

        id2 = PlayerPrefs.GetInt("id2");

        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(false);
        }
        Scenes[id2].SetActive(true);
    }
}
