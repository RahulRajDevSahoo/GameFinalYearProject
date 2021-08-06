//Script to give zombie health and apply damage to the zombie

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{

    public int EnemyHealth = 20; // each shot to the zombie is 5 damage. So 4 shots to kill the zombie
    public GameObject TheEnemy;
    public int StatusCheck;
    public AudioSource JumpscareMusic;
    public AudioSource AmbMusic;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }




    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("Z_Walk 3");
            TheEnemy.GetComponent<Animation>().Play("Z_FallingBack 1");
            JumpscareMusic.Stop();
            AmbMusic.Play();
            //TheEnemy.SetActive(false);
        }
    }
}