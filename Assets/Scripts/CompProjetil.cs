using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompProjetil : MonoBehaviour
{
    public Rigidbody2D meuRigidBody;
    public int limiteTelaX = 10;
    public int limiteTelaY = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(meuRigidBody.position.x > limiteTelaX || meuRigidBody.position.x < (-1*limiteTelaX) )
        {
            if(meuRigidBody.position.y > limiteTelaY || meuRigidBody.position.y < (-1*limiteTelaY) )
            {   
                Destroy(gameObject);
            }
        }
    }
}
