using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject _snakePrefab;
    public GameObject _slimePrefab;
    public GameObject _goblinPrefab;

    GameObject snake;
    GameObject slime;
    GameObject goblin;
    // Start is called before the first frame update
    void Start()
    {
        snake = GameObject.Instantiate(_snakePrefab);
        slime = GameObject.Instantiate(_slimePrefab);
        goblin = GameObject.Instantiate(_goblinPrefab);

        GameObject go = new GameObject() { name = "@Monsters" };

        snake.transform.parent = go.transform;
        slime.transform.parent = go.transform;
        goblin.transform.parent = go.transform;

        snake.name = _snakePrefab.name;
        slime.name = _slimePrefab.name;
        goblin.name = _goblinPrefab.name;

        slime.AddComponent<PlayerController>();

        Camera.main.GetComponent<CameraController>().Target = slime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
