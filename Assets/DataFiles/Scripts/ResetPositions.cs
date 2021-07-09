using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositions : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 orignalPos;
    void Start()
    {
        orignalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AEROPLANE"))
        {
            transform.localPosition = orignalPos;
        }

    }
}
