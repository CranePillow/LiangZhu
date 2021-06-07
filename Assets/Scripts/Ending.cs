using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject hudie1;
    public GameObject hudie2;
    public bool isFly;

    public GameObject endingUI;
    public GameObject quitbtn;

    public float speed = 3;
    float step;
    void Update()
    {
        step = speed * Time.deltaTime;
        if(isFly)
        {
            hudie1.transform.localPosition = Vector3.MoveTowards(hudie1.transform.localPosition, new Vector3(973, 100, 110), step);
            hudie2.transform.localPosition = Vector3.MoveTowards(hudie2.transform.localPosition, new Vector3(972, 100, 111), step);
            endingUI.SetActive(true);
            quitbtn.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isFly = true;
        }
    }

}
