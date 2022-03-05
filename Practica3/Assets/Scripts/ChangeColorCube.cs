using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCube : Botar
{
    //public Color[] colors;
    private Material material;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interactive()
    {
        base.Interactive();
        //Cambio de color
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        material.color = new Color(r, g, b, 1f);
    }
}
