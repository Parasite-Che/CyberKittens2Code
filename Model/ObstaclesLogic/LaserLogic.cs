using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class LaserLogic : MonoBehaviour
{
    [SerializeField] private AudioSource effectPlayer;
    [SerializeField] private LineRenderer laserRenderer;
    [SerializeField] private Transform emiterPos;
    [SerializeField] private Transform targetPos;
    [SerializeField] private bool isLaserActive;
    [SerializeField] private int damageSize=1;
    [SerializeField][Range(0,1)] private float laserWidth;
    [SerializeField] private float volume;
    
    private void Start()
    {
        laserRenderer.startWidth = 0f;
        laserRenderer.endWidth = 0f;
        DrawRay(emiterPos.position,targetPos.position);
        StartCoroutine(ShootRay());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<IPlayer>(out IPlayer player) & isLaserActive)
        {
            player.TakeDamage(damageSize);
            Debug.Log(" work");
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.TryGetComponent<IPlayer>(out IPlayer player) & isLaserActive)
        {
            player.TakeDamage(damageSize);
            Debug.Log(" work");
        }
    }

    IEnumerator ShootRay()
    {
        while (gameObject.activeSelf == true)
        {
            SetRendererWidth(0.05f,0.05f);
            DrawRay(emiterPos.position,targetPos.position);
            yield return new WaitForSeconds(laserWidth);

            isLaserActive = true;
            effectPlayer.Play();
            while (laserRenderer.startWidth < laserWidth)
            {
                effectPlayer.volume = effectPlayer.volume < volume? effectPlayer.volume+0.05f: effectPlayer.volume;
                SetRendererWidth(laserRenderer.startWidth+0.0125f, laserRenderer.startWidth+0.0125f);
                DrawRay(emiterPos.position, targetPos.position);
                yield return new WaitForSeconds(0.025f);
            }

            effectPlayer.volume = volume;
            yield return new WaitForSeconds(2.0f);
            
            while (laserRenderer.startWidth > 0.0f)
            {
                effectPlayer.volume = effectPlayer.volume > 0? effectPlayer.volume-0.05f : effectPlayer.volume;
                SetRendererWidth(laserRenderer.startWidth-0.0125f, laserRenderer.startWidth-0.0125f);
                DrawRay(emiterPos.position, targetPos.position);
                yield return new WaitForSeconds(0.025f);
            }
            effectPlayer.Stop();
            isLaserActive = false;
            
            yield return new WaitForSeconds(1.5f);
        }
    }
    
    void DrawRay(Vector2 emiter,Vector2 target)
    {
        laserRenderer.SetPosition(0,emiter);
        laserRenderer.SetPosition(1,target);
    }

    void SetRendererWidth(float start, float end)
    {
        laserRenderer.startWidth = start;
        laserRenderer.endWidth = end;
    }
    
}
