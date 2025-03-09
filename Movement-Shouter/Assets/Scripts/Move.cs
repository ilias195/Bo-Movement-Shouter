using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float Movespeed = 5f;
    public Rigidbody rb;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       movement.x =  Input.GetAxisRaw("Horizontal"); // Dat is een waarde tussen -1 .. 1 op de horizontale as dus als je naar links gaat = -1 rechts +1 //
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
           rb.MovePosition (rb.position +  movement * Movespeed * Time.fixedDeltaTime);
         
        // movement//
    }
}
