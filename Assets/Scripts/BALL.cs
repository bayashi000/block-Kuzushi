using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class BALL : MonoBehaviour{

    private float speed = 20.0f;    //これを追加

    

     // Start is called before the first frame update
    void Start()
    {
                this.GetComponent<Rigidbody>().AddForce(
                  (transform.forward + transform.right) * speed,
                   ForceMode.VelocityChange);

            }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "block")
        {
            //相手のタグがBallならば、自分を消す
            Destroy(collision.gameObject);
        }
    }

}
