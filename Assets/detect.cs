using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detect : MonoBehaviour
{
    // Start is called before the first frame update
    public int value;
    public GameObject canvas; // Referencia al GameObject del canvas


 
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter (Collider other)
    {


        if (other.CompareTag("Enemy"))
        {

            EventoActivarCanvas();

        }
        if (other.CompareTag("FCoin"))
        {

            EventoFinalizar();

        }
        if (other.CompareTag("FCoinMAAO"))
        {

            EventoFinalizar2();

        }

        
    }


  public void EventoActivarCanvas()
    {                                                                                                                                                                                           
       
        if (CountMoney.instance != null)
        {
            CountMoney.instance.ResetCoins();
        }
        SceneManager.LoadScene("Scene DCN");
    }
    public void EventoFinalizar()
  {                                                                                                                                                                                           
       
        if (CountMoney.instance != null)
        {
            CountMoney.instance.ResetCoins();
        }
        SceneManager.LoadScene("Scene1");
    }
  public void EventoFinalizar2()
  {                                                                                                                                                                                           
       
        if (CountMoney.instance != null)
        {
            CountMoney.instance.ResetCoins();
        }
        SceneManager.LoadScene("Scene3");
    }

}
