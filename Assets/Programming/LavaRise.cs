using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    public GameObject relic;
    public GameObject lava;
    Vector3 lavapos;
    bool rise = false;
    public float speed;
    public GameObject player;
    CheckPoints checkies;
    // Start is called before the first frame update
    void Start()
    {
        lavapos = lava.gameObject.transform.position;
        checkies = player.GetComponent<CheckPoints>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rise == true)
        {
            lava.gameObject.transform.Translate(0, Time.deltaTime * speed, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        relic.SetActive(false);
        checkies.check = false;
        rise = true;
    }
    public void resetlava()
    {
        rise = false;
        lava.gameObject.transform.position = lavapos;
        relic.SetActive(true);
    }

}
