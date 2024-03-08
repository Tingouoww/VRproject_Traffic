using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrafficLightController : MonoBehaviour
{
    //�O������ɶ�
    [SerializeField] private float RedTime = 10;
    [SerializeField] private float YellowTime = 2;
    [SerializeField] private float GreenTime = 8;

    [SerializeField] private GameObject RedLight;
    [SerializeField] private GameObject YellowLight;
    [SerializeField] private GameObject GreenLight;

    //�P�_������O�O�_�����O
    bool IsRedTime;

    //�M�w�_�l�O������(0�����O�}�l�B1����O�}�l)
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
        //�ҥΥ�q�O����{
        StartCoroutine(TrafficCoroutine());
        
    }

    private void Update()
    {
        //�C�@�V���n�P�_�O�_�����O
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

    //�^�ǬO�_�����O
    public bool IsRed()
    {
        return IsRedTime;
    }

    //�]�w�O��
    private void setTrafficLight(bool red, bool yellow, bool green)
    {
        RedLight.SetActive(red);
        YellowLight.SetActive(yellow);
        GreenLight.SetActive(green);
    }
}
