using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Managers.Resource.LoadAllAsync<GameObject>("Prefabs", (key, count, totalCount) =>
        {
            Debug.Log($"{key} {count}/{totalCount}");

            if (count == totalCount)
            {
                StartLoaded();
            }
        });
    }

    void StartLoaded()
    {

        var player = Managers.Resource.Instantiate("Slime_01.prefab");
        player.AddComponent<PlayerController>();

        var snake = Managers.Resource.Instantiate("Snake_01.prefab");
        var goblin = Managers.Resource.Instantiate("Goblin_01.prefab");
        var joystic = Managers.Resource.Instantiate("UI_Joystick.prefab");

        //snake.name = _snakePrefab.name;
        //slime.name = _slimePrefab.name;
        //goblin.name = _goblinPrefab.name;
        //joystick.name = _joystickPrefab.name;

        var map = Managers.Resource.Instantiate("Map.prefab");
        map.name = "@Map";
        Camera.main.GetComponent<CameraController>().Target = player;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
