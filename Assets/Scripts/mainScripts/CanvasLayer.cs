using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLayer : MonoBehaviour
{
    
    public Canvas canvas;

    void Start()
    {
        canvas.sortingLayerName = "Screen";

    }
}
