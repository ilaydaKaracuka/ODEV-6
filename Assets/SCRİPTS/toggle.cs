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

        if (tik)   //update de sürekli kontrol etsin
        {
            print("Ses kapatýldý");
            image.GetComponent<AudioSource>().mute = false; //toggle tik kalktýysa false ise ses kaldýr
        }
        else
        {

            print("Ses aktif");
            image.GetComponent<AudioSource>().mute = true;  // sesi camera içine atmýþtýk toggle tiklendi ise ses aç
        }

    }
}
