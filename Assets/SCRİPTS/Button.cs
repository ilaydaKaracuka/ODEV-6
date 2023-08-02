using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Button : MonoBehaviour
{
    
    private InputField b;
    public Toggle toggle;

    public void CikisButon()    //��k�� butonuna basarsa ��ks�n
    {
        Application.Quit();
    }
    public void AnketSahnesi()  //Anket butonu Anket sahnesine ge�i� i�in
    {
        SceneManager.LoadScene(1);
    }
    public void BilgilerimSahnesi() //Bilgilerim butonuyla Bilgilerim sahnesine ge�er
                                    //ve Anket sahnesinde girilen bilgileri Console yazd�r�r
    {
        b = GetComponent<InputField>();
        ArrayList liste = b.bilgilerim; //InputField scriptinde ki ArrayListe(bilgilerim) ula�
        foreach (string a in liste)
        {
            if (liste == null)
                print("Bilgi Girilmedi");
            else
            {
               print("Bilgilerim: "+a);
                

            }
        }
    }
    public void On_Value_Changed(float deger)
    {
        print(deger);
    }

    void Update()
    {
        bool tik = toggle.isOn;

        if (tik)   //update de s�rekli kontrol etsin
        {
            print("Ses kapat�ld�");
            Camera.main.GetComponent<AudioSource>().mute = false; //toggle tik kalkt�ysa false ise ses kald�r
        }
        else
        {

            print("Ses aktif");
            Camera.main.GetComponent<AudioSource>().mute = true;  // sesi camera i�ine atm��t�k toggle tiklendi ise ses a�
        }

    }
}






