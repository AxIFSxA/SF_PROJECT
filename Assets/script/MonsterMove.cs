using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public float spd = 3.0f;

    GameObject target;
    Vector3 dircet = Vector3.down;

    public GameObject prefabsExplosion;
    public GameObject prefabsExplosion2;

    int rndNum;


    // Start is called before the first frame update
    private void Start()
    {
        target = GameObject.Find("Chracter");
        rndNum = Random.Range(0, 10);
        if (rndNum % 2 == 0)
        {

            dircet = target.transform.position - transform.position;
            dircet.Normalize();
        }
    }

    // Update is called once per frame
    private void Update()
    {
       
        transform.position = transform.position+dircet*spd*Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Bullet"))
        {
            GameObject gameManager = GameObject.Find("GameManager");

            ScoreManager scoreManager = gameManager.GetComponent<ScoreManager>();

            scoreManager.nowScore++;

            scoreManager.nowScoreUI.text = "Now Score:" + scoreManager.nowScore;

            if(scoreManager.nowScore > scoreManager.bestScore)
            {
                scoreManager.bestScore = scoreManager.nowScore;
                scoreManager.bestScoreUI.text = "Best Score :" + scoreManager.bestScore;
                PlayerPrefs.SetInt("BestScore", scoreManager.bestScore);
            }

            GameObject explosionOBJ = Instantiate(prefabsExplosion);
            explosionOBJ.transform.position = transform.position;

            Destroy(explosionOBJ, 1.0f);

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            GameObject explosionOBJ2 = Instantiate(prefabsExplosion2);
            explosionOBJ2.transform.position = transform.position;

            // 게임 종료 처리
            StartCoroutine(StopGameAfterDelay(1f));


            Debug.Log("Game Over");

            // 필요하면 플레이어도 파괴
            Destroy(collision.gameObject);

            // 적도 제거 (선택)
            Destroy(gameObject,1.1f);
        }
    }
    IEnumerator StopGameAfterDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        Time.timeScale = 0f;
    }
}
