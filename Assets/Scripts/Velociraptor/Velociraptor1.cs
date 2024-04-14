using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velociraptor1 : MonoBehaviour
{
    public Transform Velociraptor1Transform;
    private float speed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
        Vector3 position = Velociraptor1Transform.position;
  
        if (position.x >= -2.0f && position.x < 2.0f && position.y == 0.0f)
        {
            position.x += Time.deltaTime * speed;
        }
        else if (position.x > 0.0f && position.y >= 0.0f)
        {
            position.x -= Time.deltaTime * speed;
            position.y += Time.deltaTime * speed;
        }
        else if (position.x > -2.0f && position.y >= 0.0f)
        {
            position.x -= Time.deltaTime * speed;
            position.y -= Time.deltaTime * speed;
        }
        else
        {
            position.x = -2.0f;
            position.y = 0.0f;
        }

        Velociraptor1Transform.position = position;
    }
}
