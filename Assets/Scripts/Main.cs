using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EnemyPrefab;
    
    private static List<GameObject> _enemyList;
    private static List<GameObject> _fireArmsList;
    private  GameObject Score;
    public static int ScoreCount;

    
    void Start()
    {
        _enemyList = new List<GameObject>();
        _fireArmsList = new List<GameObject>();
        Score = GameObject.FindWithTag("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemyList.Count < 5)
        {
            _enemyList.Add(Instantiate(EnemyPrefab, new Vector3(Random.Range(0, 1000), 0, 800), Quaternion.Euler(0, 180, 0)));
        }

        GameObject o = null;

        foreach (var e in _enemyList) if (e.transform.position.z < 0)
        {
            DecreaseScore();
            o = e;
        }

        if (o != null)
        {
            RemoveEnemy(o);
        }

        GameObject e1 = null;
        foreach (var o1 in _fireArmsList) if (o1.transform.position.z > 1000) e1 = o1;

        _fireArmsList.Remove(e1);
        Destroy(e1);

        (Score.GetComponent("Text") as Text).text = ScoreCount.ToString();
    }

    private void RemoveEnemy(GameObject enemy)
    {
        _enemyList.Remove(enemy);
        Destroy(enemy);
    }
    private static void DecreaseScore()
    {
        ScoreCount--;
        
    }
    public static void IncreaseScoreAndDestroy(GameObject enemy, GameObject firearm)
    {
        _enemyList.Remove(enemy);
        Destroy(enemy);
        ScoreCount++;
    }

    public static void Fire(GameObject fireArm)
    {
        _fireArmsList.Add(fireArm);
    }
}
