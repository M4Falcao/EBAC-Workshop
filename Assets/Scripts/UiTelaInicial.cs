using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiTelaInicial : MonoBehaviour
{
    public TMP_Text textoInicial;
    void Awake() 
    {
        Pause();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) 
        {
            textoInicial.text = "";
            Resume(); 
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
    
    public void Resume()
    {
        Time.timeScale = 1;
    }
}
