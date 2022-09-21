using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int curHealth;
    public int maxHealth;
    public TPSCharacterController tPS;

    bool isDamaging;
    Rigidbody rigid;

    // Audio
    AudioSource audioSource;
    public AudioClip jumpClip;
    void Awake() {
        rigid = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zombie_Attack_Area" && !isDamaging)
        {
            StartCoroutine(onHit(other.GetComponentInParent<Enemy>().zombie_Attack_Damage));
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "MapComponent")
        {
            tPS.animator.SetBool("isJump", false);
            tPS.isJump = false;
        } 
    }

    // onHit, onDamage, isDamaging, isDamaged
    IEnumerator onHit(int zombie_Damage){
        isDamaging = true;
        curHealth -= zombie_Damage;
        Debug.Log("onHit!!!");
        yield return new WaitForSeconds(0.25f);
        isDamaging = false;
    }
}
