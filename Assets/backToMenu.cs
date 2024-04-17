using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{
    public KeyCode transitionKey = KeyCode.Escape; // The key to trigger the transition
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the specified key is pressed
        if (Input.GetKeyDown(transitionKey))
        {
            // Load the specified scene ("Menu" in this case)
            SceneManager.LoadScene("Menu");
        }
    }
}
