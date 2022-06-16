using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassManager : MonoBehaviour
{
    bool Check = false,laaa=true;
    public GameObject Inventory,glass,infobox,broken;
    public GameObject a, b, c;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Check && Input.GetAxis("Use") > 0 && Inventory.GetComponent<Inventory>().hasHammer)
        {
            Inventory.GetComponent<Inventory>().loseHammer();
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            glass.GetComponent<spriteChanger>().ChangeSprite(true);
            laaa=false;
        }
        else if (Check && Input.GetAxis("Use") > 0 && !Inventory.GetComponent<Inventory>().hasHammer&&laaa)
        {
            infobox.GetComponent<info>().ach(broken);
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
