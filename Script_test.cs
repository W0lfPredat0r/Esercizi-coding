using System;
using UnityEngine;

public class Script_test : MonoBehaviour
{
    public int healt;
    [Space]
    public int lightDamage;
    public int heavyDamage;
    [Space]
    public KeyCode ButtonA;
    public KeyCode ButtonB;

     // public enum AttackType
     //{
     //    LightAttack,
     //    HeavyAttack
     // }

    void Update()
    {
        if (Input.GetKeyDown(ButtonA))
        {
            //healt -= lightDamage;
           
            TakeDamage(lightDamage, "pugno");
            Debug.Log("Vita attuale: " + healt);
           // Debug.Log("light damage");
        }
        else if (Input.GetKeyDown(ButtonB))
        {
            //healt -= heavyDamage;
           
            TakeDamage(heavyDamage, "Padellata");
            Debug.Log("Vita attuale: " + healt);
           // Debug.Log("heavy damage");
        }
    }

    public void TakeDamage(int damage, string message)
    {
        healt -= damage;
        print (message);
    }
}