using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruits : MonoBehaviour
{

    public GameObject fruit;
    int spawnNum = 15;

    void spawn()
    {
        for (int i = 0; i < spawnNum; i++)
        {
            Vector3 fruitPos = new Vector3(this.transform.position.x + Random.Range(-1.0f, 3.0f),
                this.transform.position.y + Random.Range(0.0f, 5.0f),
                this.transform.position.z + Random.Range(-1.0f, 6.0f));
            Instantiate(fruit, fruitPos, Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }
}