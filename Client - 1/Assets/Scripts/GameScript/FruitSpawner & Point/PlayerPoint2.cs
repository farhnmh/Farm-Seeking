using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPoint2 : MonoBehaviour
{

    //Ini untuk data point player 2
    //Masukin aja ke objek player 1 atau mungkin script movenya

    public static int point;
    public GameObject pointtext;

    [SerializeField] Text pointsCounterText;

    void Start()
    {
        point = 0;
        pointsCounterText = pointtext.GetComponent<Text>();
    }

    void Update()
    {
        pointsCounterText.text = point.ToString();
    }

}
