using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{

    [SerializeField]
    private GameObject audioPlay;
    private ScoreCanvas score;
    void Start()
    {
        score = GameObject.Find("Canvas").gameObject.GetComponent<ScoreCanvas>();
    }

    
    

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            Instantiate(audioPlay,Vector3.down, Quaternion.identity);
            score.score_up();
        }
    }
}
