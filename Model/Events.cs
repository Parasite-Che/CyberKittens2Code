using UnityEngine;

public class Events : MonoBehaviour
{
    void Awake()
    {
        onPlayerDeath = null;
        onActivateShield = null;
        onAddLife = null;
        onSpeedUp = null;
        onEffectPlay = null;
        onChangeInterHealth = null;
    }
    public delegate void OnPlayerDeath();
    public static OnPlayerDeath onPlayerDeath { get; set; }

    public delegate void OnActivateShield();
    public static OnActivateShield onActivateShield{ get; set; }

    public delegate void OnAddLife();
    public static OnAddLife onAddLife{ get; set; }

    public delegate void OnSpeedUp();
    public static OnSpeedUp onSpeedUp { get; set; }

    public delegate void OnEffectPlay(AudioClip clip);
    public static OnEffectPlay onEffectPlay { get; set; }

    public delegate void OnChangeInterfaceHealth(int health);
    public static OnChangeInterfaceHealth onChangeInterHealth { get; set; }
}
