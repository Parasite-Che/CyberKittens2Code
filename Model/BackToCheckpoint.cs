using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToCheckpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerController>(out PlayerController pc))
        {
            RespawnManager.instance.Respawn();
        }
    }
    
}
