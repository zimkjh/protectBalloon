using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float size = Random.Range(0.5f, 2.0f);
        transform.localScale = new Vector3(size, size, 0);

        float x = Random.Range(-2.5f, 2.5f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
