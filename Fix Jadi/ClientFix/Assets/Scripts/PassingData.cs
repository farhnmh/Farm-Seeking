using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingData : MonoBehaviour
{
    public int urutan;
    public int urutanOther;
    public string ipAddress;
    public string username;
    public int character;
    public int characterOther;
    public int totalClient;
    public int score;
    public int scoreOther;

    public string usernameEncrypt;
    public string password;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
