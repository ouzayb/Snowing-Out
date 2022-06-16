using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public float puzzletime;
    public GameObject Inventory;
    float nextPuzzleTime;
    bool starter = false, b1 = false, b2 = false, b3 = false, timerready = false, chestOpen = false, Check = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (starter && !timerready)
        {
            timerready = true;
            nextPuzzleTime = puzzletime + Time.timeSinceLevelLoad;
        }
        if (nextPuzzleTime > Time.timeSinceLevelLoad && b1 && b2 && b3)
        {
            chestOpen = true;
            this.GetComponent<spriteChanger>().ChangeSprite(true);
        }
        if (nextPuzzleTime < Time.timeSinceLevelLoad && !chestOpen)
        {
            b1 = false;
            b2 = false;
            b3 = false;
            timerready = false;
            transform.Find("Button1C").GetComponent<spriteChanger>().ChangeSprite(false);
            transform.Find("Button2C").GetComponent<spriteChanger>().ChangeSprite(false);
            transform.Find("Button3C").GetComponent<spriteChanger>().ChangeSprite(false);
        }
        if (Check && Input.GetAxis("Use") > 0 && chestOpen)
        {
            Inventory.GetComponent<Inventory>().getKey();
        }
    }


    public void StartPuzzle(int id)
    {
        starter = true;
        if (id == 1)
        {
            b1 = true;
        }
        else if (id == 2)
        {
            b2 = true;
        }

        else if (id == 3)
        {
            b3 = true;
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
