using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleterAntivir : MonoBehaviour
{
    public int IdScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out AntiVirus antiVirus))
        {
            SceneManager.LoadScene(IdScene);
            Destroy(antiVirus);
        }
    }
}
