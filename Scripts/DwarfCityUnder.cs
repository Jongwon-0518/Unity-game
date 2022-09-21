using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwarfCityUnder : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            gameManager.PlayBGM("DwarfCityUnder");
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            gameManager.StopBGM();
        }
    }
}
