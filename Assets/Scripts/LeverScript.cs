using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    bool Check = false;
    public GameObject Chest;
    public int id;
    void Start()
    {
        
    }

    void Update()
    {
        if (Check && Input.GetAxis("Use") > 0)
        {
            Chest.GetComponent<ChestScript>().StartPuzzle(id);
            this.GetComponent<spriteChanger>().ChangeSprite(true);
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
        }
    }

}
