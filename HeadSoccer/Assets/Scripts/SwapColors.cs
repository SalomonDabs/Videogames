/*
    Basic Motion affecting the transform of an object

    Uriel Aguilar
    2022-02-23
*/
using UnityEngine;

public class SwapColors : MonoBehaviour
{   
    [SerializeField] Color color1;
    [SerializeField] Color color2;

    int colorIndex = 0;

    // Traer la referencia del sprinte render
    SpriteRenderer renderer2d;

    // Start is called before the first frame update
    void Start()
    {   
        // Get a reference to another component on this object
        renderer2d = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            colorIndex++;
            if (colorIndex%2 == 0)
                renderer2d.color = color1;
            else
                renderer2d.color = color2;
        }
    }
}
