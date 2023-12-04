using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public RespawnManager respawnManager;
    public PlayerController pc;
    public bool isActivated = false;

    void Start()
    {
        respawnManager = RespawnManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActivated) return;
        //Debug.LogError(collision);
        if (collision.TryGetComponent<PlayerController>(out pc))
        {
            //Debug.LogError("Colided");
            if (pc != null)
            {
                pc.FullHealth();
                respawnManager.SetCurrentCheckpoint(this);
                
                isActivated = true;
                StartCoroutine(CheckpointGet());
            }
        }


    }

    private IEnumerator CheckpointGet()
    {
        yield return FadePanel(respawnManager.checkpointText, 100, 0, 1);

        yield return new WaitForSeconds(1);
        
        yield return FadePanel(respawnManager.checkpointText, 100, 1, 0);
    }

    public IEnumerator FadePanel(TMP_Text panel, int speed, float start, float end)
    {
        for (int j = 0; j <= speed; j++)
        {
            panel.color = new Color(panel.color.r,
                panel.color.g, panel.color.b,
                Mathf.Lerp(start, end, (float)j / speed));
            yield return null;
        }
    }
    
    public void Respawn()
    {
        pc.transform.position = transform.position;
        //pc.Respawn();
    }
}
