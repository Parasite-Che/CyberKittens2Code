using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CableController : MonoBehaviour
{
    [SerializeField] private bool conected = false;


    private void Start()
    {
        GameInputController.Instance.OnJumpActionPerformed += Uncoupling;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "cable")
        {

            StartCoroutine(CableConnection(col.transform));
                //Debug.LogError("conected");
            
        }
        else
        {
            //Debug.LogError("not");
        }
    }


    public IEnumerator CableConnection(Transform obj)
    {
        Vector3 scale = new Vector3(1, 2, 0);
        gameObject.transform.SetParent(obj);
        obj.GetComponent<BoxCollider2D>().isTrigger = true;
        conected = true;
        while (conected)
        {
            gameObject.transform.localPosition = new Vector3(-(gameObject.transform.localScale.x  +  scale.x )/ 2 , 0, 0);
            //gameObject.transform.localPosition = new Vector3(0, 0, 0);
            gameObject.transform.localScale = new Vector3(scale.x / Mathf.Abs(obj.localScale.x),
                scale.y / Mathf.Abs(obj.localScale.y), 0);
            gameObject.transform.localRotation = new Quaternion(gameObject.transform.localRotation.x,
                gameObject.transform.localRotation.y, 0, gameObject.transform.localRotation.w);

            yield return new WaitForFixedUpdate();

        }

        gameObject.transform.SetParent(obj.parent.parent);
        gameObject.transform.localScale = scale;
         
        yield return new WaitForSeconds(2);
        
        obj.GetComponent<BoxCollider2D>().isTrigger = false;
    }

    private void Uncoupling(object sender, EventArgs eventArgs)
    {
        
        conected = false;
    }
    
}
