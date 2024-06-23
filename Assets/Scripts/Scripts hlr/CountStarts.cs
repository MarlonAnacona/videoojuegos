using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountStarts : MonoBehaviour
{
public TMP_Text starText; // UI Text to display the coin count
    public static int starCount = 0; // Variable to keep track of the collected coins
    public static CountStarts instance;

    // Start is called before the first frame update
      void Awake() {
        Debug.Log("Awake");

        instance =this;
    }
    void Start()
    {

    starText.text= "STARS: " + starCount.ToString();
    }

    // This method will be called when the player collides with a coin
   public void IncreaseStar(int v){
    starCount+=v;
    starText.text= "STARS: " + starCount.ToString();
   }

   
}
