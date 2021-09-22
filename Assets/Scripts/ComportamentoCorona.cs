using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoCorona : MonoBehaviour
{
    public static System.Action CoronaMorto = null;
    public Rigidbody2D meuRigidbody;
    public Rigidbody2D prefabCoroninha;

    public EfeitoAsteroideDestruido efeitoAsteroideDestruido;

    public float velocidadeMaxima = 1.0f;
    public int quantidadeCoroninha = 4;

    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Instantiate(efeitoAsteroideDestruido, meuRigidbody.position, Quaternion.identity); 

        //Solta 4 asteroides pequenos quando destruido
        for(int i = 0; i < quantidadeCoroninha; i++)
        {
            Rigidbody2D fragmento = Instantiate(prefabCoroninha,meuRigidbody.position,Quaternion.identity);
        }

        if(CoronaMorto != null)
        {
            CoronaMorto();
        }
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}
