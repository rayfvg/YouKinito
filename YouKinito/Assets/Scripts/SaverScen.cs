using UnityEngine;

public class SaverScen : MonoBehaviour
{
    
    public int id1;
  
    

    private void Start()
    {
        PlayerPrefs.SetInt("id1", id1);
    }

    
}
