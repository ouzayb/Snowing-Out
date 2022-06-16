using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    bool Check = false,a=true;
    public GameObject Inventory;
    public GameObject infobox, HintScreen;
    public GameObject closen;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Check && Input.GetAxis("Use") > 0 && Inventory.GetComponent<Inventory>().hasKey)
        {
            HintScreen.SetActive(true);
            Inventory.GetComponent<Inventory>().loseKey();
            a=false;
        }
        else if (Check && Input.GetAxis("Use") > 0 && !Inventory.GetComponent<Inventory>().hasKey&&a)
        {
            infobox.GetComponent<info>().ach(closen);
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
            HintScreen.SetActive(false);
        }
    }
}
