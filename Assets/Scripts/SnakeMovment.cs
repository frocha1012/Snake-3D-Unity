using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SnakeMovment : MonoBehaviour
{
    #region variable
    public float speed = 3.0f;
    public float rotationSpeed = 100f;
    public float offset = 0.5f;
    public List<GameObject> tail = new();
    public GameObject tailPrefab;
    public TMP_Text scoreText;
    public int score = 0;
    #endregion

    public void Start()
    {
        tail.Add(gameObject);
    }
    public void Update()
    {
        scoreText.text = Convert.ToString(score);
        transform.Translate(speed * Time.deltaTime * Vector3.forward);


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
    public void AddTail()
    {
        score = score + 100;
        Vector3 newTailPos = tail[^1].transform.position;
        newTailPos.z -= offset;
        tail.Add(GameObject.Instantiate(tailPrefab, newTailPos, Quaternion.identity));
    }
}
