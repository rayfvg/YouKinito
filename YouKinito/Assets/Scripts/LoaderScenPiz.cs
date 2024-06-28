using UnityEngine;

public class LoaderScenPiz : MonoBehaviour
{

    public GameObject[] Scenes;
    private int id1;

    private void Awake()
    {

        id1 = PlayerPrefs.GetInt("id1");

        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(false);
        }
        Scenes[id1].SetActive(true);
    }
}
