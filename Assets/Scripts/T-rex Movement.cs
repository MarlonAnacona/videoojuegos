using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f; // Speed of movement in units per second

    private bool shouldMove = true;

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            // Move the object forward along its z-axis
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    // Call this function when you want the object to start moving
    public void StartMoving()
    {
        shouldMove = true;
    }
}
