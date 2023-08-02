using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Button : MonoBehaviour
{
    
    private InputField b;
    public Toggle toggle;

    public void CikisButon()    //çýkýþ butonuna basarsa çýksýn
    {
        Application.Quit();
    }
    public void AnketSahnesi()  //Anket butonu Anket sahnesine geçiþ için
    {
        SceneManager.LoadScene(1);
    }
    public void BilgilerimSahnesi() //Bilgilerim butonuyla Bilgilerim sahnesine geçer
                                    //ve Anket sahnesinde girilen bilgileri Console yazdýrýr
    {
        b = GetComponent<InputField>();
        ArrayList liste = b.bilgilerim; //InputField scriptinde ki ArrayListe(bilgilerim) ulaþ
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

        if (tik)   //update de sürekli kontrol etsin
        {
            print("Ses kapatýldý");
            Camera.main.GetComponent<AudioSource>().mute = false; //toggle tik kalktýysa false ise ses kaldýr
        }
        else
        {

            print("Ses aktif");
            Camera.main.GetComponent<AudioSource>().mute = true;  // sesi camera içine atmýþtýk toggle tiklendi ise ses aç
        }

    }
}






