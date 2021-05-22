using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{

    GameObject Snake;

    // Start is called before the first frame update

    void Start()
    {
        this.Snake = GameObject.Find("Snake");
    }

    // Update is called once per frame

    //Chicken ������Ʈ�� Snake�� ������ GameDirector�� CreaseHp�� �˸�.

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Snake")
        {
            Destroy(gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().CreaseHp();
        }
    }
}