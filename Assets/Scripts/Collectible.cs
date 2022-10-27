using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    bool IsCollect;
    int Index;
    public Collector Collect;

    // Start is called before the first frame update
    void Start()
    {
        IsCollect = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollect == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -Index, 0);
            }
        }
        
    }
    public bool GetIsCollect()
    {
        return IsCollect;
    }
    public void Collected()
    {
        IsCollect = true;
    }
    public void SetIndex(int Index)
    {
        this.Index = Index;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Block")
        {
            Collect.DecreaseHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

        }
    }
}
