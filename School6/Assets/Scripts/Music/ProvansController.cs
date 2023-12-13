using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class ProvansController : MonoBehaviour
{
    public GameObject circle;

    public MusicScore score;

    private Vector2 prevPosition = new Vector2(0,0);

    public VideoPlayer player;

    public GameObject scoreObj;

    public VideoClip clappingClip;

    private LevelLoader loader;

    public Text endScoreText;

    private void Start()
    {
        StartCoroutine(CirclesSequence());
        loader = GetComponent<LevelLoader>();
    }

    private IEnumerator CirclesSequence()
    {
        //������ ����
        yield return new WaitForSeconds(10);
        Spawn(1.5f);
        yield return new WaitForSeconds(1);
        Spawn(1.5f);
        yield return new WaitForSeconds(1);
        Spawn(1.5f);
        //�� ����� � �������� �������
        yield return new WaitForSeconds(2);
        Spawn(1.5f);
        yield return new WaitForSeconds(1);
        Spawn(1.5f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        //��� ������� ����
        yield return new WaitForSeconds(0.8f);
        Spawn(1.4f);
        yield return new WaitForSeconds(0.8f);
        Spawn(1.4f);
        yield return new WaitForSeconds(1);
        Spawn(1.4f);
        //�� ������� �������� ������� ����
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
        //�� ������ ��������
        yield return new WaitForSeconds(2);
        Spawn(1.25f);
        yield return new WaitForSeconds(0.75f);
        Spawn(1.5f);
        yield return new WaitForSeconds(0.75f);
        Spawn(1.5f);
        //��� ��� ������ ������ �����
        yield return new WaitForSeconds(3);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        yield return new WaitForSeconds(1);
        Spawn(1.1f);
        yield return new WaitForSeconds(1);
        Spawn(1.25f);
        //�� � ������ � ����
        yield return new WaitForSeconds(1);
        Spawn(1.3f);
        yield return new WaitForSeconds(1);
        Spawn(1.3f);
        yield return new WaitForSeconds(1);
        Spawn(0.35f);
        //�� ������ ������� �����
        yield return new WaitForSeconds(3);
        Spawn(1.5f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.5f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        //���� ������ � ���� �������� ��� � ����
        yield return new WaitForSeconds(1);
        Spawn(1.5f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.7f);
        yield return new WaitForSeconds(0.75f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        //���� �� ������ �������
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(1.5f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        //��� ������ � ������
        yield return new WaitForSeconds(1);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        //� ��� ��� ������� � �������
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);
        yield return new WaitForSeconds(0.5f);
        Spawn(2f);

        //starting clapping clip and ending game
        yield return new WaitForSeconds(1);
        scoreObj.SetActive(false);
        player.clip = clappingClip;
        player.Play();
        endScoreText.text = "�������������! �� �������: " + score.score.ToString() + " ����!";
        endScoreText.gameObject.SetActive(true);

        yield return new WaitForSeconds(5);
        loader.Load();
    }

    private void Spawn(float borderSpeed)
    {
        float randX = Random.Range(100, 1800);
        float randY = Random.Range(100, 900);

        while(Mathf.Abs(randX - prevPosition.x) < 300 && Mathf.Abs(randY - prevPosition.y) < 300)
        {
            randX = Random.Range(100, 1800);
            randY = Random.Range(100, 900);
        }

        prevPosition = new Vector2(randX, randY);

        GameObject spawnedCircle = Instantiate(circle, new Vector2(randX, randY), Quaternion.identity);

        spawnedCircle.transform.parent = transform;

        OsuCircle circleScript = spawnedCircle.GetComponent<OsuCircle>();

        circleScript.borderSpeed = borderSpeed;

        circleScript.scoreRef = score;
    }
}
