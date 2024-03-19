using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject _snakePrefab;
    public GameObject _slimePrefab;
    public GameObject _goblinPrefab;
    public GameObject _joystickPrefab;

    GameObject snake;
    GameObject slime;
    GameObject goblin;
    GameObject joystick;
    // Start is called before the first frame update
    void Start()
    {
        snake = GameObject.Instantiate(_snakePrefab);
        slime = GameObject.Instantiate(_slimePrefab);
        goblin = GameObject.Instantiate(_goblinPrefab);
        joystick = GameObject.Instantiate(_joystickPrefab);

        GameObject go = new GameObject() { name = "@Monsters" };

        snake.transform.parent = go.transform;
        slime.transform.parent = go.transform;
        goblin.transform.parent = go.transform;

        snake.name = _snakePrefab.name;
        slime.name = _slimePrefab.name;
        goblin.name = _goblinPrefab.name;
        joystick.name = _joystickPrefab.name;

        slime.AddComponent<PlayerController>();

        Camera.main.GetComponent<CameraController>().Target = slime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
