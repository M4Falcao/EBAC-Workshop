using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondas : MonoBehaviour
{
    public ComportamentoCorona prefabAsteroide;
    public Rigidbody2D player;
    public int quantosAsteroides = 3;
    public float tempoOndas = 5;
    public float T1 = 0;

    public bool status = true;
    public int rodada = 0;

    void Start()
    {
        MandaCorona();
        
    }

    void Update() 
    {   
        MovimentoVacina.FimDeJogo += TerminaJogo;

        if(!status) return;

        float T0 = Time.fixedTime;
        

        if(T0-T1 > tempoOndas)
        {
            quantosAsteroides = quantosAsteroides + (rodada/3);
            MandaCorona();
            T1 = T0;
            rodada++;         
        }
    }

    void TerminaJogo()
    {
        status = false;
    }

    void MandaCorona()
    {
        for (int i = 0; i < quantosAsteroides; i++)
        {
            float x = Random.Range (-7.0f, 7.0f);
            float y = Random.Range(-4.0f, 4.0f);
            if((int)x!=(int)player.position.x && (int)y!=(int)player.position.y)
            {
                Vector3 posicao = new Vector3(x, y, 0.0f);
                Instantiate(prefabAsteroide, posicao, Quaternion.identity);
            }
        }
    }
}
