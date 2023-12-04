using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSpace : MonoBehaviour
{
   [SerializeField] private int additionalJump = 0;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent<MovementController>(out MovementController mc))
        {
             additionalJump = mc.additionalJumps;
             if (additionalJump == 0)
             {
                 mc.additionalJumps = 1;
             }
             else if (additionalJump == 1)
             {
                 mc.additionalJumps = 2;
             }
             
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<MovementController>(out MovementController mc))
        {

            if (additionalJump == 1 && mc.additionalJumps == 0)
            {
                mc.additionalJumps = 0;
            }
            else
            {
                mc.additionalJumps = additionalJump;
            }
        }
    }
}
