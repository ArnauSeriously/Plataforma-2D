using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 
    public int vida; 
    // Start is called before the first frame update
    void Awake()
    {
        if(instance !=null && instance !=this)
        {
  Destroy(this.gameObject); 
        }
        else 
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
