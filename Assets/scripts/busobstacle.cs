using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busobstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float busspeed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * busspeed);
    }
}
