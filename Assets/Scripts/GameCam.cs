using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCam : MonoBehaviour
{
    public static GameCam instancia;
    public Camera minhaCamera;

    void Awake() {
        instancia = this;    
    }
}
