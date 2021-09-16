using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoCorona : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public Rigidbody2D prefabCoroninha;

    public float velocidadeMaxima = 1.0f;
    public float velocidadeCoroninha = 0.5f;

    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);

        //Solta 4 asteroides pequenos quando destruido
        for(int i = 0; i < 4; i++)
        {
            Rigidbody2D fragmento = Instantiate(prefabCoroninha,meuRigidbody.position,Quaternion.identity);
            fragmento.velocity = transform.up * velocidadeCoroninha;
        }

        

    }
}
