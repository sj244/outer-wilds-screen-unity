using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        

}

// Update is called once per frame
void Update()
    {
        
        //��⵽e�����¹ر�
        if (Input.GetKeyDown(KeyCode.E))
        {
            Application.Quit();
        }
        //��ȡ��ǰʱ��
        DateTime now = DateTime.Now;

        //����Сʱ
        int hour = now.Hour % 12;
        if (hour == 0) hour = 12;
        SetDigitActive("Hour1", hour / 10);
        SetDigitActive("Hour", hour % 10);

        //���÷���
        int minute = now.Minute;
        SetDigitActive("Minute1", minute / 10);
        SetDigitActive("Minute", minute % 10);

        //������
        int second = now.Second;
        SetDigitActive("Second1", second / 10);
        SetDigitActive("Second", second % 10);

        //�����ֶ����Active��������Ϊtrue��false
        void SetDigitActive(string parentName, int digit)
        {
            Transform parent = transform.Find(parentName);
            for (int i = 0; i < 10; i++)
            {
                Transform digitObj = parent.Find(i.ToString());
                digitObj.gameObject.SetActive(i == digit);
            }
        }

    }
}
