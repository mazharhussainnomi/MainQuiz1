using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectCollision : MonoBehaviour
{
   

    
    public static int ScoreCounter1;

    private void Start()
    {

      
    }


    private void OnTriggerEnter(Collider other)
    {

       ScoreCounter1++;
        //Debug.Log(ScoreCounter1);
    

        Destroy(gameObject);
        Destroy(other.gameObject);
        Debug.Log(message: "Nomi "  + DetectCollision.ScoreCounter1);
    }

    
}
