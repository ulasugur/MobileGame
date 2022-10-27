using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject MainCube;
    int Height;

    // Start is called before the first frame update
    void Start()
    {
        MainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        MainCube.transform.position = new Vector3(transform.position.x, Height + 1, transform.position.z);
        this.transform.localPosition=new Vector3(0,-Height,0);
    }
    public void DecreaseHeight()
    {
        Height--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectible" && other.gameObject.GetComponent<Collectible>().GetIsCollect()==false)
        {
            Height += 1;
            other.gameObject.GetComponent<Collectible>().Collected();
            other.gameObject.GetComponent<Collectible>().SetIndex(Height);
            other.gameObject.transform.parent=MainCube.transform;
        }
    }
}
