using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float a;
    public float b;
    public float c;//上面这3个b变量都是决定幅度的
    public float d;//这个决定x轴偏移
    public float e;//这个决定延时
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
                // 如果y轴大于4，执行相应的代码
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
            // 计算x轴位置
            float x = Mathf.Sin(a + y) + Mathf.Cos(b + y) * Mathf.Sin(c + y)+d;

            // 移动目标
            transform.position = new Vector3(x, y, 2);

            // 增加y轴位置
            y += g; // 生成0.008到0.01之间的随机数
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
