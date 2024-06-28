using UnityEngine;

public class LoaderScenPiz2 : MonoBehaviour
{

    public GameObject[] Scenes;
    private int id3;

    private void Awake()
    {

        id3 = PlayerPrefs.GetInt("id3");

        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(false);
        }
        Scenes[id3].SetActive(true);
    }
}
