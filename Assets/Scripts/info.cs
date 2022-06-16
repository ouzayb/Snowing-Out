using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    public GameObject infor,car,hammer,close;


    //void Update(){}

    public void ach(GameObject a){
        a.SetActive(true);
        infor.SetActive(true);
        Invoke("destroy", 2);
    }

    void destroy(){
        infor.SetActive(false);
        car.SetActive(false);
        hammer.SetActive(false);
        close.SetActive(false);
    }
}
