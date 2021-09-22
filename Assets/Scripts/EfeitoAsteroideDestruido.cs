using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoAsteroideDestruido : MonoBehaviour
{
    public AudioSource audioAsteroideDestruido;
    public ParticleSystem meuParticleSystem;
    public float delay = 0.5f; 
    void Start()
    {
        meuParticleSystem.Play(false);
        audioAsteroideDestruido.Play();
        Destroy(gameObject, delay);
    }

}
