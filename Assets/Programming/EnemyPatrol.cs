/////////
///By: Dhruv D
///Date: 5/25/2021
///Desc: Enemy patrol
/////////

using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyPatrol : MonoBehaviour
{
    public float mMovementSpeed = 3.0f;
    public bool bIsGoingRight = true;
    public float mRaycastingDistance = 1f;

    private SpriteRenderer SpriteRenderer;

    void Start()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SpriteRenderer.flipX = bIsGoingRight;
    }


    void Update()
    {
        Vector3 directionTranslation = (bIsGoingRight) ? transform.right : -transform.right;
        directionTranslation *= Time.deltaTime * mMovementSpeed;

        transform.Translate(directionTranslation);
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Terrain")
        {
            print("Test");
            bIsGoingRight = !bIsGoingRight;
            SpriteRenderer.flipX = bIsGoingRight;

        }
    }
}