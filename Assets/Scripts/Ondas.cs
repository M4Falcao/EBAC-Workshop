using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondas : MonoBehaviour
{
    public ComportamentoCorona prefabAsteroide;
    public int quantosAsteroides = 3;

    void Start()
    {
        for (int i = 0; i < quantosAsteroides; i++)
        {
            float x = Random.Range (-7.0f, 7.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }
}
