using System.Collections.Generic;
using UnityEngine;

public class CableInstantiateControler : MonoBehaviour
{
    [SerializeField] private GameObject CablePrefab;

    [SerializeField] private float cableWidth, cableHeight;
    [SerializeField] private int  cableCount;
    [SerializeField] private List<GameObject> cables;

    private void Awake()
    {
        SpawnCables();
        FillCables();
    }

    private void SpawnCables()
    {
        if (cableCount <= 0)
        {
            return;
        }

        for (int i = 0; i < cableCount; i++)
        {
            CableBirth();
        }
    }

    /*private void OnValidate()
    {
        for (int i = 0; i < cables.Count; i++)
        {
            DestroyImmediate(cables[i]);
            
        }
        cables.Clear();
        SpawnCables();
    }*/

    private void CableBirth()
    {
        cables.Add(Instantiate(CablePrefab, gameObject.transform));
        cables[cables.Count - 1].transform.localPosition = -new Vector3(0, ((cables.Count - 1) * cableHeight + cableHeight/2), 0);
        cables[cables.Count - 1].transform.localScale = new Vector3(cableWidth, cableHeight);
        
    }

    private void FillCables()
    {
        for (int i = 0; i < cableCount - 1; i++)
        {
            cables[i].name = i.ToString();
            cables[i].AddComponent<Rigidbody2D>();
            cables[i].AddComponent<BoxCollider2D>();
            cables[i].GetComponent<BoxCollider2D>().isTrigger = true;
            cables[i].AddComponent<HingeJoint2D>();
            
        }
        cables[cableCount - 1].AddComponent<Rigidbody2D>();

        for (int i = 0; i < cableCount - 1; i++)
        {
            cables[i].GetComponent<HingeJoint2D>().connectedBody = cables[i + 1].GetComponent<Rigidbody2D>();
            cables[i].GetComponent<HingeJoint2D>().anchor = new Vector2(0, -0.5f);

        }
        
        HingeJoint2D sec = cables[0].AddComponent<HingeJoint2D>();
        sec.connectedBody = gameObject.GetComponent<Rigidbody2D>();
        sec.anchor = new Vector2(0,0.5f);



        if (gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb)) 
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
        else
        {
            gameObject.AddComponent<Rigidbody2D>();
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
        

        cables[cableCount - 1].AddComponent<BoxCollider2D>();
        //cables[cableCount - 1].GetComponent<BoxCollider2D>().isTrigger = true;
        //cables[cableCount - 1].AddComponent<DistanceJoint2D>();
        //cables[cableCount - 1].GetComponent<DistanceJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();

        gameObject.AddComponent<DistanceJoint2D>();
        gameObject.GetComponent<DistanceJoint2D>().connectedBody = cables[cableCount - 1].GetComponent<Rigidbody2D>();

    }
    
}
