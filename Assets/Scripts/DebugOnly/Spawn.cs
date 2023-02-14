using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private int times = 0;
    public GameObject Player;

    private void Update()
    {
        Vector3 PlayerPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);

        if (Debug.isDebugBuild)
        {
            // start
            if (Input.GetKey(KeyCode.Home))
            {
                GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                /*if (Cube.transform.position != PlayerPos)
                {
                    PlayerPos = new Vector3(Cube.transform.position.x, Cube.transform.position.y, Cube.transform.position.z);
                }*/
                Cube.transform.position = PlayerPos;
                Cube.name = "HomeSpawned cube #" + times;
                // v this thing turns this game into a "go to space with a cube simulator"
                Cube.AddComponent<Rigidbody>();
                times += 1;
                string txt = "Spawned cube #" + times + ", position (Vector3): " + PlayerPos;
                if (Application.platform == RuntimePlatform.WindowsEditor)
                {
                    Debug.LogFormat(txt);
                }
                else
                {
                    Debug.LogWarningFormat(txt);
                }
            }
        }
    }
}
