using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 RotateAmount;
    
    void Start()
    {
        var floor = GameObject.Find("Floor").GetComponent<Renderer>(); 
        var eastWall = GameObject.Find("EastWall").GetComponent<Renderer>(); 
        var westWall = GameObject.Find("WestWall").GetComponent<Renderer>(); 
        var northWall = GameObject.Find("NorthWall").GetComponent<Renderer>();

        System.Random dice = new System.Random();
        floor.material.color = new Color((float)dice.NextDouble(), (float)dice.NextDouble(), (float)dice.NextDouble(), 1);
        eastWall.material.color = new Color((float)dice.NextDouble(), (float)dice.NextDouble(), (float)dice.NextDouble(), 1);
        westWall.material.color = new Color((float)dice.NextDouble(), (float)dice.NextDouble(), (float)dice.NextDouble(), 1);
        northWall.material.color = new Color((float)dice.NextDouble(), (float)dice.NextDouble(), (float)dice.NextDouble(), 1);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(RotateAmount);
        //RotateAmount.Set(0, yPosition, 0);
        //xPosition += 1;
        //yPosition += 1;
        //if (xPosition == 360)
        //{
        //    xPosition = 1;
        //}
        //if (yPosition == 360)
        //{
        //    yPosition = 1;
        //}

    }
}
