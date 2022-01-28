using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine

public class LevelManagerScript : MonoBehaviour
{
    public GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
        startButton.GetCompenent<startButton>().Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
