using System;
using System.Collections;
using UnityEngine;

public class FirewallLogic : MonoBehaviour
{
    [SerializeField] private AudioSource effectPlayer;
    [SerializeField] private Transform visualTransform;
    [SerializeField] private Vector3 upperPoint;
    [SerializeField] private Vector3 downPoint;
    [SerializeField] private float speed;
    [SerializeField] private float range;
    [SerializeField] private float delayTime;

    private void Start()
    {
        
        upperPoint.x = visualTransform.position.x;
        upperPoint.y = visualTransform.position.y;
        upperPoint.z = visualTransform.position.z;
        
        downPoint.x = visualTransform.position.x;
        downPoint.y = visualTransform.position.y-range;
        downPoint.z = visualTransform.position.z;
        
        StartCoroutine(MoveFirewall());
    }

    IEnumerator MoveFirewall()
    {
        while (gameObject.activeSelf)
        {
            while (visualTransform.position != downPoint)
            {
                visualTransform.position = Vector3.MoveTowards(visualTransform.position, downPoint, speed);
                yield return new WaitForFixedUpdate();
            }
            
            effectPlayer.Play();
            yield return new WaitForSeconds(delayTime);
            effectPlayer.Stop();

            while (visualTransform.position != upperPoint)
            {
                visualTransform.position = Vector3.MoveTowards(visualTransform.position, upperPoint, speed);
                yield return new WaitForFixedUpdate();
            }
            
            yield return new WaitForSeconds(delayTime);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<IPlayer>(out IPlayer player))
            player.TakeDamage(1);
    }
}
