using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class WaterManager : MonoBehaviour
{
    enum OxygenType {AddOxygen = -1,MinusOxygen = +1 }
    //=========================================
    //�̱���
    private WaterManager() { }
    public GameObject waringImage;
    private static WaterManager instance = null;
    public static WaterManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new WaterManager();
            }
            return instance;
        }
    }
    //========================================
    public float maxOxygen;
    private float curOxygen;
    private bool isInOxygenArea;

    private OxygenType oxygenType;

    private Collider playerCollider;
    public float _curOxygen
    {
        get { return curOxygen; }
        set { curOxygen = value; }
    }
    public float _maxOxygen
    {
        get { return maxOxygen; }
        set { maxOxygen = value; }
    }

    void Awake()
    {
        instance = this;
        maxOxygen = 15.0f;
        curOxygen = maxOxygen;
        oxygenType = OxygenType.MinusOxygen;
        playerCollider = GetComponent<Collider>();
        waringImage.SetActive(false);
    }

    void Update()
    {
        OnTriggerStay(playerCollider);      //��� ���� �Է� Ȯ�� 
        OnTriggerExit(playerCollider);

        if(curOxygen <= maxOxygen)
        {
            curOxygen -= (int)oxygenType * Time.deltaTime;
        }

        if (curOxygen < 0)
        {
            PlayerManager.Instance().isGameOver = true;
        }
        else if (curOxygen > maxOxygen)
        {
            curOxygen = maxOxygen;
        }
        else if (curOxygen < 5)
        {
            waringImage.SetActive(true);
        }
    }

    void OnTriggerStay(Collider collider)   //��� ���� ������ ��������
    {
        if (!isInOxygenArea && collider.gameObject.CompareTag("OxygenArea"))    //isInOxygenArea������ ��� ���ӿ�����Ʈ�� tag�� Ž���ϹǷ� ��� �߻�
        {
            isInOxygenArea = true;
            oxygenType = OxygenType.AddOxygen;
            Debug.Log("�÷��̾ �ڽ� ������ ���Խ��ϴ�.");
        }
    }

    void OnTriggerExit(Collider collider)   //��� ���� ������ ��������
    {
        if (isInOxygenArea && collider.gameObject.CompareTag("OxygenArea"))
        {
            isInOxygenArea = false;
            oxygenType =  OxygenType.MinusOxygen;
            Debug.Log("�÷��̾ �ڽ� ������ �������ϴ�.");
        }
    }
}
