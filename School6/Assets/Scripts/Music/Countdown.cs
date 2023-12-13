using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    private Text txt;

    public float time;

    private float currentTime;

    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
        currentTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0)
        {
            Destroy(parent);
        }
        txt.text = "Початок через: " + Mathf.Round(currentTime).ToString();

    }
}
