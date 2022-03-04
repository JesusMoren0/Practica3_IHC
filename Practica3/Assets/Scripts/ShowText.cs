using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public string textValue;
    public Text textelement;

    // Start is called before the first frame update
    void Start()
    {
        textelement.text = textValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
