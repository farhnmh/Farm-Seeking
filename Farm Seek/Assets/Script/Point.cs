using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public static int point;
    public GameObject pointtext;
    [SerializeField] Text pointsCounterText;

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        pointsCounterText = pointtext.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsCounterText.text = point.ToString();
    }
}
