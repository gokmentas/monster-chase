using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    [HideInInspector]
    private Rigidbody2D myBody;

    public float speed;

    // Start is called before the first frame update

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        myBody.velocity = new Vector2(speed, myBody.velocity.y);

    }

} // class
