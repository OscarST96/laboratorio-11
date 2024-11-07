using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clossion : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public int xDirection;
    public int yDirection;
    private Rigidbody2D _componentRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    { 
        _componentRigidbody2D.velocity = new Vector2(xSpeed * xDirection, ySpeed * yDirection);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horizon")
        {
            xDirection = xDirection * -1;
        }
        if (collision.gameObject.tag == "ObjetoC")
        {
            yDirection = yDirection * -1;
        }
    }
}
