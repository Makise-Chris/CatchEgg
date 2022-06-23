using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreText;
    private int score;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed *Time.deltaTime;
        transform.position += new Vector3(x, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Egg")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
