using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class utidai : MonoBehaviour
{
    //この中で使うものを宣言していく

    public float speed = 3;



    // 画面生成時に一度だけ処理するのをカッコ内にかく
    void Start()
    {
        
    }

    // ゲーム中ずっと処理するのをカッコ内にかく
    void Update()
    {
        if(Input.GetKey("left"))

        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            this.transform.position += new Vector3( speed * Time.deltaTime,0,0);
        }
        if(Input.GetKey("down"))
        {
            this.transform.position -= new Vector3(0,0, speed * Time.deltaTime);
        }
        if(Input.GetKey("up"))
        {
            this.transform.position += new Vector3(0, 0, speed* Time.deltaTime);

         }

    }   
      
}
