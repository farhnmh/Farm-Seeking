using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameOver : MonoBehaviour
{
    public downloadBundleOver over;
    public PassingData pass;
    public TextMeshProUGUI akhir;

    // Update is called once per frame
    void Update()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();
        over = GameObject.Find("DownloadBundle").GetComponent<downloadBundleOver>();

        if (pass.score > pass.scoreOther && over.done == true)
        {
            akhir.text = "YOU WIN!!!";
        }
        if (pass.score < pass.scoreOther && over.done == true)
        {
            akhir.text = "YOU LOSE!!!";
        }

        Debug.Log("Your Score : " + pass.score + "Enemy's Score : " + pass.scoreOther);
    }
}
