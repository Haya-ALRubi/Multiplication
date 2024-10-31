using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<=10; i++)
        {
            int result = Muliply(5,i);
            Debug.Log("5 x "+i+" "+"="+" "+result);
        }
    }
    int Muliply(int numOne , int numTwo){
        int multi = numOne * numTwo;
        return multi;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
