using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiPntuacao : MonoBehaviour
{
    public TMP_Text texto;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Score: 0";

        ComportamentoCorona.CoronaMorto += CoronaFoiMorto;
    }

    void CoronaFoiMorto()
    {
        score++;
        AtualizaTexto();
    }
    void OnDestroy() 
    {
        ComportamentoCorona.CoronaMorto -= CoronaFoiMorto;
    }

    void AtualizaTexto()
    {
        string pontos = score.ToString();
        texto.text = "Score: " + pontos;
    }   
}
