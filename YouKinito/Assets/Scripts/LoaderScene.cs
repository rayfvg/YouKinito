using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    public void LoadScene (int id)
    {
        SceneManager.LoadScene(id);
    }
}
