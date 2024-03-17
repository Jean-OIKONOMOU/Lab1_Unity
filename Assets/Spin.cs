using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 RotateAmount;
    public int xPosition = 1;
    public int yPosition = 1;
    void Start()
    {
        
        RotateAmount.Set(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount);
        RotateAmount.Set(0, yPosition, 0);
        xPosition += 1;
        yPosition += 1;
        if (xPosition == 360)
        {
            xPosition = 1;
        }
        if (yPosition == 360)
        {
            yPosition = 1;
        }

    }
}
