using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public static RespawnManager instance;
    public Checkpoint checkpoint;
    public TMP_Text checkpointText;
    [SerializeField] private PlayerController pc; 

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        Events.onPlayerDeath += Respawn;
    }

    public void SetCurrentCheckpoint(Checkpoint checkpoint)
    {
        this.checkpoint = checkpoint;
    }

    public void Respawn()
    {
        pc.FullHealth();
        checkpoint.Respawn();
    }

}
