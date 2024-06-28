using UnityEngine;

public class SaverScen2 : MonoBehaviour
{
    
    public int id3;
  
    

    private void Start()
    {
        PlayerPrefs.SetInt("id3", id3);
    }

    
}
