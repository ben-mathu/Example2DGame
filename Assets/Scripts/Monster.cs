using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;
    
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        speed = 7;
    }

    private void FixedUpdate()
    {
        myBody.velocity = new Vector3(speed, myBody.velocity.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}