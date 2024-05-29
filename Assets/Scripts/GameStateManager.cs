using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStateManager : MonoBehaviour
{
    public float GoldAccumulationRate = 1.0f;
    public float Gold = 0.0f;

    private TMP_Text goldDisplayText;

    // Start is called before the first frame update
    void Start()
    {
        goldDisplayText = GameObject.Find("Gold Display Text").GetComponent<TMP_Text>();
        goldDisplayText.text = "" + Gold;
    }

    // Update is called once per frame
    void Update()
    {
        Gold += GoldAccumulationRate * Time.deltaTime;
        goldDisplayText.text = "" + (int)Gold;
    }
}
