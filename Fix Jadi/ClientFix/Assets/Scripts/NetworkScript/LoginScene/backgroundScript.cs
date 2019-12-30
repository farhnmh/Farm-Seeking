using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Linq;

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class backgroundScript : MonoBehaviour
{
    public bool done = false;
    public int sceneID;
    public string passTes;

    public TextMeshProUGUI hello;
    public TextMeshProUGUI warning;
    public TextMeshProUGUI instruct;
    public TextMeshProUGUI click;

    public Text from;
    public Text ip;
    public Button submit;
    public GameObject PanelSubmit;
    public PassingData pass;

    // Start is called before the first frame update
    void Start()
    {
        submit.onClick.AddListener(submitClicked);
        PanelSubmit.SetActive(true);

        instruct.text = "Please Input Your Name\nand Every Scene Will Download Asset";
        warning.text = "";
        hello.text = "";
        click.text = "";

        int random = UnityEngine.Random.Range(1000, 5000);
        passTes = Convert.ToString(random);
    }

    // Update is called once per frame
    void Update()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();

        pass.password = passTes;
        pass.username = from.text;
        pass.ipAddress = ip.text;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (from.text == "" || ip.text == "")
            {
                PanelSubmit.SetActive(true);
                warning.text = "<- don't let it empty";
            }
            else
            {
                pass.usernameEncrypt = StringCipher.Encrypt(pass.username, pass.password);

                PanelSubmit.SetActive(false);
                instruct.text = "";
                warning.text = "";
                hello.text = "Hello " + from.text;
                click.text = "click everywhere to continue";
                done = true;
            }
        }

        if (Input.GetMouseButtonDown(0) && done == true)
        {
            SceneManager.LoadScene(sceneID);
        }
    }

    void submitClicked()
    {
        if (from.text == "" || ip.text == "")
        {
            PanelSubmit.SetActive(true);
            warning.text = "don't let it empty";
        }
        else
        {
            PanelSubmit.SetActive(false);
            instruct.text = "";
            warning.text = "";
            hello.text = "Hello " + from.text;
            click.text = "click here to continue";
            done = true;
        }
    }

    public static class StringCipher
    {
        private const int Keysize = 256;
        private const int DerivationIterations = 1000;

        public static string Encrypt(string plainText, string passPhrase)
        {
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();

                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }
        public static string Decrypt(string cipherText, string passPhrase)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
