using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    #region variable
    public GameObject foodPrefab;
    public GameObject curFood;
    private Vector3 curPos;
    #endregion
    
    private void AddNewFood()
    {
        curPos = RandomPos();
        curFood = Instantiate(foodPrefab, curPos, Quaternion.identity);
    }

    private Vector3 RandomPos()
    {
        float randomX = Random.Range(-8.8f, 8.8f);
        float randomZ = Random.Range(-8.8f, 8.8f);

        return new Vector3(randomX, 0.3f, randomZ);
    }
    private void Update()
    {
        if(!curFood)
        {
            AddNewFood();
        }
    }
}
