using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Teleport : MonoBehaviour
{
    public GameObject car;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    float currentTime = 0f;
    float time1 = 0f;
    float time2 = 0f;
    float time3 = 0f;
    public TextMeshProUGUI textM;
    public TextMeshProUGUI textMTimes;
    int level = 1;

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        textM.text = currentTime.ToString("0.0");
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "flag1")
        {
            car.transform.position = spawn2.position;
            time1 = currentTime;
            currentTime = 0f;
            level = 2;
            textMTimes.text = "Score\n" + "1: " + time1.ToString();
        }
        else if (collision.name == "flag2")
        {
            car.transform.position = spawn3.position;
            time2 = currentTime;
            currentTime = 0f;
            level = 3;
            textMTimes.text = "Score\n" + "1: " + time1.ToString() + "\n2: " + time2.ToString();
        }
        else if (collision.name == "flag3")
        {
            car.transform.position = spawn1.position;
            time3 = currentTime;
            currentTime = 0f;
            textMTimes.text = "Score\n" + "1: " + time1.ToString() + "\n2: " + time2.ToString() + "\n3: " + time3.ToString();
            level = 1;
        }
    }

    public void Restart()
    {
        if (level == 1)
        {
            car.transform.position = spawn1.position;
            car.transform.rotation = spawn1.rotation;
        }
        else if (level == 2)
        {
            car.transform.position = spawn2.position;
            car.transform.rotation = spawn2.rotation;
        }
        else if (level == 3)
        {
            car.transform.position = spawn3.position;
            car.transform.rotation = spawn3.rotation;
        }
    }
}
