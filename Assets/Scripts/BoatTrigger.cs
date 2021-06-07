using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatTrigger : MonoBehaviour
{
    public float speed = 3;
    float step;
    public bool isOnBoat;
    public GameObject boat;
    public GameObject player;
    
    private void Update()
    {
        step = speed * Time.deltaTime;
        if(isOnBoat)
        {
            //boat.transform.Translate(Vector3.right * Time.deltaTime * speed);
            boat.transform.localPosition = Vector3.MoveTowards(boat.transform.localPosition, new Vector3(943, 4, 118), step);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isOnBoat = true;
        }
    }
}
