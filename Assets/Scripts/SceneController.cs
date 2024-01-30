using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private GameObject enemy;

    
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer rend = GetComponent(MeshRenderer).enemy;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null) {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1f, 0);
            enemy.transform.localScale = new Vector3(1,Random.Range(2f, 6f),1);
            rend.material.Color(Random.Range(0,1),Random.Range(0,1),Random.Range(0,1));
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
        }
    }
}
