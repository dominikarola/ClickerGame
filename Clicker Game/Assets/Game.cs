using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    
    public TMP_Text ui;
    public void Increment()
    {
        GameManager.o2 += GameManager.multiplier;
        PlayerPrefs.SetInt("o2", GameManager.o2);
    }

    public void Buy1(int num)
    {
        if(num == 1 && GameManager.o2 >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.o2 -= 25;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.o2 >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.o2 -= 125;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.o2 >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.o2 -= 1500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    void Update()
    {
        ui.text = "O2: " + GameManager.o2;
    }
}
