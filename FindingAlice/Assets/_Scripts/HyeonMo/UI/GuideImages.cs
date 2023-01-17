using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GuideImages : MonoBehaviour
{
    //���� �ڽĵ��� Inspector â���� �Ҵ�
    [SerializeField] GameObject[] guideImages;

    [SerializeField] GameObject dontMoveObject;
    GameObject clockTouchZone;
    GameObject player;

    Button[] buttons;

    void Start()
    {
        player = GameObject.Find("Player");
        clockTouchZone = GameObject.Find("ClockTouchZone");

        buttons = new Button[guideImages.Length];

        for (int i = 0; i < guideImages.Length; i++)
        {
            buttons[i] = guideImages[i].GetComponent<Button>();
            buttons[i].interactable = false;
            guideImages[i].transform.GetChild(0).gameObject.SetActive(false);
            guideImages[i].SetActive(false);
        }

        dontMoveObject.SetActive(false);
    }

    //��ư������ �� �Լ� ȣ��ǵ��� �� �� �� ��, guideImages ������� Inspector â�� index ����
    public void OnButtonClicked(int index)
    {
        if (index == guideImages.Length - 1)
        {
            guideImages[index].SetActive(false);

            clockTouchZone.SetActive(true);
            Destroy(gameObject);
            return;
        }

        // ���� ���̵� �̹����� Ȱ��ȭ�ϰ� 3�� �ڿ� Button ������Ʈ�� Ȱ��ȭ
        guideImages[index + 1].SetActive(true);
        StartCoroutine(ActivateButton(index + 1));

        // ���� ���̵� �̹����� ��Ȱ��ȭ
        guideImages[index].SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ù ��° ���̵� �̹����� Ȱ��ȭ�ϰ� 3�� �ڿ� Button ������Ʈ�� Ȱ��ȭ
            guideImages[0].SetActive(true);
            StartCoroutine(ActivateButton(0));

            clockTouchZone.SetActive(false);

            dontMoveObject.SetActive(true);
            dontMoveObject.transform.position = player.transform.position;
        }
    }

    IEnumerator ActivateButton(int index)
    {
        yield return new WaitForSeconds(2.0f);
        buttons[index].interactable = true;
        guideImages[index].transform.GetChild(0).gameObject.SetActive(true);
    }
}