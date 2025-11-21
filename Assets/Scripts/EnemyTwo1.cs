using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo1 : MonoBehaviour
{


    private float horizontalScreenLimit = 9.5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);

        //Player leaves the screen horizontally
        if (transform.position.x > horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }
        


        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 3f);
    }


}