using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostCardScript : MonoBehaviour
{
    bool Check = false;
    public GameObject PostCard;
    GameObject A;
    void Start()
    {
        A = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Check && Input.GetAxis("Use") > 0)
        {
            PostCard.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Hand")
        {
            Check = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Hand")
        {
            Check = false;
            PostCard.SetActive(false);
            Destroy(A);
        }
    }
}
