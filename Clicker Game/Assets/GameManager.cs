using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int o2;
    public static int multiplier;

    private void Start()
    {
        o2 = PlayerPrefs.GetInt("o2", 0);
        multiplier = PlayerPrefs.GetInt("o2", 1);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
