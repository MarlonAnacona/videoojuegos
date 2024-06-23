using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sections : MonoBehaviour
{
    public List<GameObject> obstacles;
    public List<GameObject> sections;
    void Start()
    {
        obstacles = new List<GameObject>();
        sections = new List<GameObject>();
        foreach (Transform child in transform)
        {
            if (child.tag == "Obstacles")
            {
                obstacles.Add(child.gameObject);
            }
        }
        EnableRandomSection();
    }

    public void EnableRandomSection()
    {
        foreach (GameObject obstacle in obstacles)
        {
            obstacle.SetActive(false);
        }
        int randomIndex = Random.Range(0, obstacles.Count);
        obstacles[randomIndex].SetActive(true);
    }
}
