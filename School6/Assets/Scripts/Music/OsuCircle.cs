using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OsuCircle : MonoBehaviour
{
    public Transform borderCircle;

    public float borderSpeed;
    private float lerpValue;

    // Update is called once per frame
    void Update()
    {
        lerpValue += borderSpeed * Time.deltaTime;
        borderCircle.localScale = new Vector3(Mathf.Lerp(2, 0.9f, lerpValue), Mathf.Lerp(2, 0.9f, lerpValue), 0);
        if(borderCircle.localScale.x <= 0.9f)
        {
            Destroy(gameObject);
        }
    }
    public void Click()
    {
        Destroy(gameObject);
    }
}
