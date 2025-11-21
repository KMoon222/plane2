using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{



    private GameManager gameManager;

     





    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            //AddScore(1);
        }
    }

    void Update()
    {


            Destroy(this.gameObject, 3);


    }

    


}