using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ScreenStart : MonoBehaviour
{
    public GameObject Fader;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        Fader.SetActive(true);
        Fader.GetComponent<Image>().DOFade(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
