using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool hasKey = false;
    public bool hasHammer = false;
    public GameObject gkey;
    public GameObject ghammer;
    public GameObject infobox,key,hammer;

    float A,B,C,D;
    public void Update(){
        if(hasKey){
            gkey.SetActive(true);
        }
        else if(!hasKey){
            gkey.SetActive(false);
        }
         if(hasHammer){
            ghammer.SetActive(true);
        }
        else if(!hasHammer)
        {
            ghammer.SetActive(false);
        }
    }
    public void getKey()
    {
        hasKey = true;
        infobox.GetComponent<info>().ach(key);
    }
    public void getHammer()
    {
        hasHammer = true;
        infobox.GetComponent<info>().ach(hammer);
    }
    public void loseKey()
    {
        hasKey = false;
    }
    public void loseHammer()
    {
        hasHammer = false;
    }

}
