using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EggController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= speed * Time.deltaTime * Vector3.up;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Basket" || collision.gameObject.tag == "Bottom")
        {
            Destroy(gameObject);
        }
    }
}
