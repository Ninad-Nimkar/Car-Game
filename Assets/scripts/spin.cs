using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float propeller;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 10 * Time.deltaTime * propeller);
    }
}
