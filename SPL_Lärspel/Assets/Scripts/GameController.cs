using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    private static int index = 0;

    [SerializeField] private string[] hints;
    [SerializeField] private Image[][] images;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reDraw()
    {
        changeText();
        changeImg();
    }

    void changeText()
    {

    }

    void changeImg()
    {

    }


}
