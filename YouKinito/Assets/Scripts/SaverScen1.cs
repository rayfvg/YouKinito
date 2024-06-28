using UnityEngine;

public class SaverScen1 : MonoBehaviour
{
    
    public int id2;
  
    

    private void Start()
    {
        PlayerPrefs.SetInt("id2", id2);
    }

    
}
