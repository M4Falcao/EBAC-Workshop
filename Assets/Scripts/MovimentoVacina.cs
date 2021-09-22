using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoVacina : MonoBehaviour
{
    public static System.Action FimDeJogo = null;
    public Rigidbody2D meuRigidbody;
    public float aceleracao = 1.0f;
    public float coice = -1.0f;
    public float velocidadeAngular = 180.0f;
    public float velocidadeMaxima = 10.0f;

    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil = 10.0f;

    public AudioSource somDoTiro;
    public AudioSource gripezinha;

    void Start()
    {
        //somDoTiro = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(
                prefabProjetil,
                meuRigidbody.position,
                Quaternion.identity
            );

            projetil.velocity = transform.up * velocidadeProjetil;

            Vector3 direcao = transform.up * coice;
            meuRigidbody.AddForce(direcao, ForceMode2D.Force);

            somDoTiro.Play();
        }
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direcao = transform.up * aceleracao;
            meuRigidbody.AddForce(direcao, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            meuRigidbody.rotation += velocidadeAngular * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            meuRigidbody.rotation -= velocidadeAngular * Time.deltaTime;
        }

        if (meuRigidbody.velocity.magnitude > velocidadeMaxima)
        {
            meuRigidbody.velocity = Vector2.ClampMagnitude(
                meuRigidbody.velocity,
                velocidadeMaxima
            );
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        gripezinha.Play();
        Destroy(gameObject);
        if(FimDeJogo != null) FimDeJogo();
    }
}
