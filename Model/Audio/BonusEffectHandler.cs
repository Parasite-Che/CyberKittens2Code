using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusEffectHandler : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent<IPlayer>(out IPlayer player))
            Events.onEffectPlay?.Invoke(clip);
    }
}
