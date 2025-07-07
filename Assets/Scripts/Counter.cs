using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private float totalPoints;
    public float getPoints()
    {
        return this.totalPoints;
    }
    public void addPoints(float points)
    {
        this.totalPoints += points;
    }
    // Start is called before the first frame update
    void Start()
    {
        totalPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
