using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Vector3 RottationVector;
    public int Size;
    private bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(RottationVector);
    }

    private void FixedUpdate()
    {
        if (flag)
        {
            this.gameObject.transform.localScale += Vector3.one*Size;
            flag = false;
        }
        else
        {
            this.gameObject.transform.localScale -= Vector3.one *Size;
            flag = true;
        }
    }
}
