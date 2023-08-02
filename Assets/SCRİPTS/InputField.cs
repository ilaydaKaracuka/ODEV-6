using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.SceneManagement;

public class InputField : MonoBehaviour
{
    private int sayi;
   
    public ArrayList bilgilerim = new ArrayList();
    public void OnEndEditText(string metin)
    { 
        print("metin=" + metin);
        bilgilerim.Add(metin);
    }
    public void DropDown(int sayi)
    {
        if (sayi == 0)
        {
            
            bilgilerim.Add("Unity'den çok memnunum");
        }
        else if (sayi == 1)
        {
           
            bilgilerim.Add(" Unity'den memnunum");
        }
        else if (sayi == 2)
        {
           
            bilgilerim.Add("Unity'den memnun deðilim");
        }
    }
}
