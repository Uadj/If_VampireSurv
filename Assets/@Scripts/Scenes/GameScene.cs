using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    GameObject snake;
    GameObject slime;
    GameObject goblin;
    GameObject joystick;

    // Start is called before the first frame update
    void Start()
    {

        Managers.Resource.LoadAllAsync<GameObject>("Prefabs", (key, count, totalCount) =>
        {
            Debug.Log($"{key} {count}/{totalCount}");

            if(count == totalCount)
            {
                StartLoaded();
            }
        });
    }
    void StartLoaded(){

        GameObject prefab = Managers.Resource.Load<GameObject>("Slime_01.prefab");
        GameObject go = new GameObject() { name = "@Monsters" };

        snake.transform.parent = go.transform;
        slime.transform.parent = go.transform;
        goblin.transform.parent = go.transform;

        //snake.name = _snakePrefab.name;
        //slime.name = _slimePrefab.name;
        //goblin.name = _goblinPrefab.name;
        //joystick.name = _joystickPrefab.name;

        slime.AddComponent<PlayerController>();

        Camera.main.GetComponent<CameraController>().Target = slime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
