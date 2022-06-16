using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            transform.GetChild(0).transform.position = new Vector3(transform.position.x + (Mathf.Abs(Input.GetAxis("Horizontal"))/Input.GetAxis("Horizontal") * 0.4f), transform.position.y, transform.position.z);
            transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
        {
            transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + (Mathf.Abs(Input.GetAxis("Vertical")) / Input.GetAxis("Vertical") * 0.4f), transform.position.z);
            transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));

        }
    }
}
