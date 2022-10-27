using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float VerticalSpeed;
    [SerializeField]
    private float HorizontalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalAxis = Input.GetAxis("Horizontal") * HorizontalSpeed * Time.deltaTime;
        this.transform.Translate(HorizontalAxis, 0, VerticalSpeed * Time.deltaTime);

    }
}
