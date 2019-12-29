using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        switch (other.gameObject.name)
        {
            case "Apple(Clone)":

                //Kalau mau pake kartu
                /*if (c.cardNum == 1)
                {
                    PlayerPoint.point += 1;
                }*/

                //kalau engga
                PlayerPoint.point += 1;

                Destroy(other.gameObject);

                //Penanda ronde selesai
                EndLevel.game += 1;
                break;

            case "Banana(Clone)":

                //Kalau mau pake kartu
                /*if (c.cardNum == 1)
                {
                    PlayerPoint.point += 1;
                }*/

                //kalau engga
                PlayerPoint.point += 1;

                //Penanda Ronde Selesai
                EndLevel.game += 1;

                Destroy(other.gameObject);
                break;
        }

    }
}
