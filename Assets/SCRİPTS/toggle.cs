using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class toggle : MonoBehaviour
{
    public Toggle t;
    public Image image;
    void Update()
    {
        bool tik = t.isOn;

        if (tik)   //update de s�rekli kontrol etsin
        {
            print("Ses kapat�ld�");
            image.GetComponent<AudioSource>().mute = false; //toggle tik kalkt�ysa false ise ses kald�r
        }
        else
        {

            print("Ses aktif");
            image.GetComponent<AudioSource>().mute = true;  // sesi camera i�ine atm��t�k toggle tiklendi ise ses a�
        }

    }
}
