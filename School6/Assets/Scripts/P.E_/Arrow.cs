using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    enum Direction {Left, Right, Up, Down };
    private Direction _direction;

    private Image image;
    public Sprite[] sprites;

    private RectTransform transf;

    public RectTransform clickLevel;

    public PEGameplayController controller;
    // Start is called before the first frame update
    void Start()
    {
        transf = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        RandomizeDirection();

        switch (_direction)
        {
            case Direction.Left:
                image.sprite = sprites[0];
                break;
            case Direction.Right:
                image.sprite = sprites[1];
                break;
            case Direction.Up:
                image.sprite = sprites[2];
                break; 
            case Direction.Down:
                image.sprite = sprites[3];
                break;
        }
    }
    private void RandomizeDirection()
    {
        int rand = Random.Range(0, 4);
        switch (rand)
        {
            case 0:
                _direction = Direction.Left;
                break;
            case 1:
                _direction = Direction.Right;
                break;
            case 2:
                _direction = Direction.Up;
                break;
            case 3:
                _direction = Direction.Down;
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        transf.position = transf.position + new Vector3(0,-500f * Time.deltaTime,0);
        if (Mathf.Abs((transf.position.y - clickLevel.position.y)) <= 70)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if(_direction == Direction.Left)
                {
                    controller.AddScore(1);
                }
                else
                {
                    controller.AddScore(-1);
                }
                Destroy(gameObject);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (_direction == Direction.Right)
                {
                    controller.AddScore(1);
                }
                else
                {
                    controller.AddScore(-1);
                }
                Destroy(gameObject);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (_direction == Direction.Up)
                {
                    controller.AddScore(1);
                }
                else
                {
                    controller.AddScore(-1);
                }
                Destroy(gameObject);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (_direction == Direction.Down)
                {
                    controller.AddScore(1);
                }
                else
                {
                    controller.AddScore(-1);
                }
                Destroy(gameObject);
            }
        }

        if(transf.position.y < 0)
        {
            controller.AddScore(-1);
            Destroy(gameObject);
        }
    }
}
