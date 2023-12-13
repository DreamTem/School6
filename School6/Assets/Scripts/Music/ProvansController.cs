using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvansController : MonoBehaviour
{
    public GameObject circle;

    private void Start()
    {
        StartCoroutine(CirclesSequence());
    }

    private IEnumerator CirclesSequence()
    {
        //уютнае кафе
        yield return new WaitForSeconds(10);
        Spawn(1);
        yield return new WaitForSeconds(1);
        Spawn(1);
        yield return new WaitForSeconds(1);
        Spawn(1);
        //на улице с плетеной мебелью
        yield return new WaitForSeconds(2);
        Spawn(1);
        yield return new WaitForSeconds(1);
        Spawn(1);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        //где красное вино
        yield return new WaitForSeconds(0.8f);
        Spawn(1.4f);
        yield return new WaitForSeconds(0.8f);
        Spawn(1.4f);
        yield return new WaitForSeconds(1);
        Spawn(1.4f);
        //из местных погребов больших шато
        yield return new WaitForSeconds(2);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(0.65f);
    }

    private void Spawn(float borderSpeed)
    {
        float randX = Random.Range(100, 1800);
        float randY = Random.Range(100, 900);

        GameObject spawnedCircle = Instantiate(circle, new Vector2(randX, randY), Quaternion.identity);

        spawnedCircle.transform.parent = transform;

        OsuCircle circleScript = spawnedCircle.GetComponent<OsuCircle>();

        circleScript.borderSpeed = borderSpeed;
    }
}
