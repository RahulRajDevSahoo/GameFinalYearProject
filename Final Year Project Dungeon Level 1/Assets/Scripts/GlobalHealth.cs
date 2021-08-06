//Script to create health 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{

    public static int currentHealth = 50;
    public int internalHealth;

    void Update()
    {
        internalHealth = currentHealth;
        if(currentHealth<=0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
