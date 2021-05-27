using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    Vector3 spawn;
    Quaternion rotateion;
    public GameObject lava;
    LavaRise lavascript;
    public bool check = true;
    // Start is called before the first frame update
    void Start()
    {
        spawn = this.gameObject.transform.position;
        lavascript = lava.GetComponent<LavaRise>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "checkpoint" && check == true)
        {
            spawn = this.gameObject.transform.position;
            rotateion = this.gameObject.transform.rotation;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            this.gameObject.transform.rotation = rotateion;
            this.gameObject.transform.position = spawn;
            lavascript.resetlava();
        }
    }

}
