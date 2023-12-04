using System;
using System.Collections;
using UnityEngine;

public class JammerLogic : MonoBehaviour
{
    [SerializeField] private AudioSource effectPlayer;
    [SerializeField] private int damageSize = 1;
    private bool isUnderInfluence = false;

    private void Start()
    {
    }

    private void Update()
    {
        if(!effectPlayer.isPlaying)
            effectPlayer.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<IPlayer>(out IPlayer player))
        {
            player.SpeedDown();
            MovementController.instance.underJammer = true;
            isUnderInfluence = true;
            StartCoroutine(InfluenceOnPlayer(player));
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<IPlayer>(out IPlayer player))
        {
            isUnderInfluence = false;
            MovementController.instance.underJammer = false;
            player.RestoreSpeed();
        }
    }

    IEnumerator InfluenceOnPlayer(IPlayer player)
    {
        Debug.Log("Coroutine work");
        while (isUnderInfluence)
        {
            Debug.Log("Coroutine work-----");
            yield return new WaitForSeconds(4.0f);
            if(isUnderInfluence)player.TakeDamage(damageSize);
        }
    }
    
    
}
