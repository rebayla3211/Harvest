using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevellingAndScoring: MonoBehaviour
{
    public GameObject pickup;
    public GameObject WinText;
    public Text Scoretext;
    bool Ended;
    int MaxApple = 0;
    int Apple = 0;


    void Update()
    {
        if (Ended == true)
        {
            Destroy(pickup);
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (Apple == MaxApple - 1 && other.tag == "Apples")
        {
            Ended = true;
            Apple += 1;
            Destroy(other);
            Scoretext.text = "Collected Apples: " + Apple + "/"+ MaxApple;
            WinText.SetActive(true);
        }
        else if (Apple <= MaxApple && other.tag == "Apples")
        {
            Apple += 1;
            Scoretext.text = "Collected Apples: " + Apple + "/"+ MaxApple;
            Destroy(other);
        }
    }
    public void LevelOne(){
        MaxApple = 3;
        Scoretext.text = "Collected Apples: 0" + "/"+ MaxApple;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void LevelTwo(){
        MaxApple = 6;
        Scoretext.text = "Collected Apples: 0" + "/"+ MaxApple;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void LevelThree(){
        MaxApple = 12;
        Scoretext.text = "Collected Apples: 0" + "/"+ MaxApple;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
