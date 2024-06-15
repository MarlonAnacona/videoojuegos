using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public int value;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter (Collider other)
    {

        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            CountMoney.instance.IncreaseCoind(value);

        }
    }
}
