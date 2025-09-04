using UnityEngine;

public class ProvaBoolean : MonoBehaviour
{
    public bool testBool;
    private void Start()
    {
        if (testBool == true)        
            print("la mia variabile é " + testBool);


         if (testBool == false)
             print("la mia variabile é " + testBool);       
    }
}
