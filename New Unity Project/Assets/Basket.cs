using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public GameObject pickup;
    bool Ended;
    public GameObject WinText;
    public Text Scoretext;
    int MaxApple = 3;
    int Apple = 0;

    void Start()
    {
        Scoretext.text = "Collected Apples: 0";
        
    }
    void Update()
    {
        if (Ended == true)
        {
            Destroy(pickup);
        }
    }
    void OnTriggerEnter(Collider other)
    {
       
        
        if (Apple == 2 && other.tag == "Apples")
        {
            Ended = true;
            Apple += 1;
            Scoretext.text = "Collected Apples: " + Apple;
            WinText.SetActive(true);
        }
        else if (Apple <= MaxApple && other.tag == "Apples")
        {
            Apple += 1;
            Scoretext.text = "Collected Apples: " + Apple;
        }
    }

}
