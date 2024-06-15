using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CountMoney : MonoBehaviour
{
    public TMP_Text coinText; // UI Text to display the coin count
    private int coinCount = 0; // Variable to keep track of the collected coins
    public static CountMoney instance;

    // Start is called before the first frame update
      void Awake() {
        Debug.Log("Awake");

        instance =this;
    }
    void Start()
    {

    coinText.text= "COINS: " + coinCount.ToString();
    }

    // This method will be called when the player collides with a coin
   public void IncreaseCoind(int v){
    coinCount+=v;
    coinText.text= "COINS: " + coinCount.ToString();
   }

   
}