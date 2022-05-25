using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerCollision : MonoBehaviour
{

    [SerializeField] Text _scoreText;
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Top"))
        {
            Destroy(collision.gameObject);
            score += 1;
            _scoreText.text = "Score=" + score;
            Debug.Log(score);
           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
