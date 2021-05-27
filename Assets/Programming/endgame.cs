using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    public GameObject lava;
    LavaRise lavascript;
   
    // Start is called before the first frame update
    void Start()
    {        
        lavascript = lava.GetComponent<LavaRise>();
    }

        // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (lavascript.rise == true)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    
    
}
