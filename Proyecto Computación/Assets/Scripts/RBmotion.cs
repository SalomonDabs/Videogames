// Move a Rigid Body by applying forces
// Salomon Dabbah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBmotion : MonoBehaviour
{
    [SerializeField] float force;

    Rigidbody2D rb2D;
    Vector3 move;
    public float jumpSpeed;
    public bool enPiso;
    public Transform refPie; 

    private float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    } 

    // Update is called once per frame
    void Update()
    {   
        // When the foot is near the ground
        enPiso = Physics2D.OverlapCircle(refPie.position,1f, 1<<8);

        move.x = Input.GetAxis("Horizontal") * force;

        rb2D.velocity = move;

        if (Input.GetButtonDown("Jump") && enPiso) 
        {
        rb2D.AddForce(
            new Vector2(0,jumpSpeed), ForceMode2D.Impulse
            );
        }
        
    }
}
