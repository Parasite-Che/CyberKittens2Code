using System.Collections;
using UnityEngine;

public class SpeedUpBonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<IPlayer>(out IPlayer player))
            StartCoroutine(Take(other.gameObject));
    }
    
    IEnumerator Take(GameObject obj)
    {
        while (Vector3.Distance(transform.position, obj.transform.position) > 0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, obj.transform.position, 0.2f);
            if (transform.localScale.x > 0.0f & transform.localScale.y > 0.0f)
            {
                transform.localScale = new Vector3(transform.localScale.x - 0.05f,transform.localScale.y - 0.05f);
            }

            yield return new WaitForFixedUpdate();
        }
        
        Events.onSpeedUp?.Invoke();
        Destroy(gameObject);
    }
}
