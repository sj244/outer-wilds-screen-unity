using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float a;
    public float b;
    public float c;//������3��b�������Ǿ������ȵ�
    public float d;//�������x��ƫ��
    public float e;//���������ʱ
    private float y;
    private float g;

    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
        transform.position = new Vector3(100, 5, 2);
        e = 0;
        g = 0.008f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 4+e)
        {
                // ���y�����4��ִ����Ӧ�Ĵ���
                transform.position = new Vector3(Random.Range(-80, 80) / 10.0f, -4, 2);
                y = -4;
                a = Random.Range(-80, 80) / 10.0f;
                b = Random.Range(-80, 80) / 10.0f;
                c = Random.Range(-80, 80) / 10.0f;
                d = Random.Range(-80, 80) / 10.0f;
                e = Random.Range(0, 15);
        }
        else
        {
            // ����x��λ��
            float x = Mathf.Sin(a + y) + Mathf.Cos(b + y) * Mathf.Sin(c + y)+d;

            // �ƶ�Ŀ��
            transform.position = new Vector3(x, y, 2);

            // ����y��λ��
            y += g; // ����0.008��0.01֮��������
            if (g > 0.005f)
            {
                if (g > 0.01)
                {
                    g += Random.Range(-5f, 0f) / 1000.0f;
                }
                else
                {
                    g += Random.Range(-5f, 5f) / 1000.0f;
                }
            }
           
            else 
            {
                g += Random.Range(0f, 5f) / 1000.0f;
            }

        }
    }
}
