using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public float GoldAccumulationRate = 1.0f;
    public float Gold = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gold += GoldAccumulationRate * Time.deltaTime;
    }
}
