using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDetecting : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            Enemy enemy = gameObject.GetComponentInParent<Enemy>();
            enemy.isChase = true;
        }
    }
}
