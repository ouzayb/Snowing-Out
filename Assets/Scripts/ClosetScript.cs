using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetScript: MonoBehaviour
{
    bool Check = false, a = false;
    public GameObject passwordScreen;
    public GameObject Inventory;
    public int[] password = { 1, 1, 1, 1 };
    public int[] passwordTry = { 0, 0, 0, 0 };
    int k = 0;

    void Start()
    {

    }

    void Update()
    {
        if (Check && Input.GetAxis("Use") > 0 && !a)
        {
            passwordScreen.SetActive(true);
            a = true;
        }
        if (Check && Input.GetAxis("Cancel") > 0 && a)
        {
            passwordScreen.SetActive(false);
            a = false;
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
            a = false;
            passwordScreen.SetActive(false);
        }
    }

    public void Pressbutton(int A)
    {
        if (k < password.Length)
        {
            passwordTry[k] = A;
            k++;
        }
        else
        {
            for (int i = 0; i < password.Length - 1; i++)
            {
                passwordTry[i] = passwordTry[i + 1];
            }
            passwordTry[password.Length - 1] = A;
        }
        if (k >= password.Length)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] != passwordTry[i])
                {
                    return;
                }
            }
            passwordScreen.SetActive(false);
            Inventory.GetComponent<Inventory>().getHammer();
        }
    }
}
