using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrafficLightController : MonoBehaviour
{
    //燈號執行時間
    [SerializeField] private float RedTime = 10;
    [SerializeField] private float YellowTime = 2;
    [SerializeField] private float GreenTime = 8;

    [SerializeField] private GameObject RedLight;
    [SerializeField] private GameObject YellowLight;
    [SerializeField] private GameObject GreenLight;

    //判斷此紅綠燈是否為紅燈
    bool IsRedTime;

    //決定起始燈號種類(0為紅燈開始、1為綠燈開始)
    int startMethod;

    private void Awake()
    {
        if (RedLight.activeSelf == true)
        {
            startMethod = 0;
        }
        else if (GreenLight.activeSelf == true)
        {

            startMethod = 1;
        }
    }

    void Start()
    {
        //啟用交通燈號協程
        StartCoroutine(TrafficCoroutine());
        
    }

    private void Update()
    {
        //每一幀都要判斷是否為紅燈
        if (RedLight.activeSelf)
        {
            IsRedTime = true;
        }
        else
        {
            IsRedTime = false;
        }
    }

    IEnumerator TrafficCoroutine()
    {
        if (startMethod == 0)
        {
            while (true)
            {
                setTrafficLight(true, false, false);
                yield return new WaitForSeconds(RedTime);

                setTrafficLight(false, false, true);
                yield return new WaitForSeconds(GreenTime);

                setTrafficLight(false, true, false);
                yield return new WaitForSeconds(YellowTime);
            }
        }
        else
        {
            while (true)
            {
                setTrafficLight(false, false, true);
                yield return new WaitForSeconds(GreenTime);

                setTrafficLight(false, true, false);
                yield return new WaitForSeconds(YellowTime);

                setTrafficLight(true, false, false);
                yield return new WaitForSeconds(RedTime);

            }
        }
    }

    //回傳是否為紅燈
    public bool IsRed()
    {
        return IsRedTime;
    }

    //設定燈號
    private void setTrafficLight(bool red, bool yellow, bool green)
    {
        RedLight.SetActive(red);
        YellowLight.SetActive(yellow);
        GreenLight.SetActive(green);
    }
}
