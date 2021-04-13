using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : Megaman
{
    public Animator animController;
    public bool simple;

    void Update()
    {
        if(simple)
        {
            animController.SetBool("Forward", Input.GetKey(KeyCode.W));
            animController.SetBool("Backward", Input.GetKey(KeyCode.S));
            animController.SetBool("Faster", Input.GetKey(KeyCode.LeftShift));
            
            if(Input.GetKey(KeyCode.E))
            {
                animController.SetTrigger("Wave");
            }
            
        }
        else
        {
            int mult = Input.GetKey(KeyCode.LeftShift) ? 2 : 1;
            animController.SetFloat("Speed", Input.GetAxis("Vertical") * mult);
        }
    }
}
