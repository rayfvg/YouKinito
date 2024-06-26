using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleterAntivir : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out AntiVirus antiVirus))
        {
            SceneManager.LoadScene(2);
            Destroy(antiVirus);
        }
    }
}
