using System.Collections;
using UnityEngine;
using System;

public class Spawn : MonoBehaviour
{
    private int times = 0;
    public GameObject Player;
    public Material CubeMaterial1;
    public Material CubeMaterial2;
    public Material CubeMaterial3;
    public Material CubeMaterial4;
    System.Random random = new System.Random();

    private void Update()
    {
        var materials = new[]{CubeMaterial1, CubeMaterial2, CubeMaterial3, CubeMaterial4};
        Vector3 PlayerPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
        // just allow this function everywhere, for fun :D
        //if (Debug.isDebugBuild)
        //{
        // start
        if (Input.GetKey(KeyCode.Home))
        {
            var mts = random.Next(0, materials.Length);
            Material CubeMaterial = materials[mts];
            GameObject Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            /*if (Cube.transform.position != PlayerPos)
            {
                PlayerPos = new Vector3(Cube.transform.position.x, Cube.transform.position.y, Cube.transform.position.z);
            }*/
            Cube.transform.position = PlayerPos;
            Cube.name = "OhioCube™ #" + times;
            // v this thing turns this game into a "go to space with a cube simulator"
            Cube.AddComponent<Rigidbody>();
            Cube.AddComponent<Renderer>();
            Cube.GetComponent<Renderer>().material = CubeMaterial;
            times += 1;
            string txt = "Spawned OhioCube™ #" + times + ", position (Vector3): " + PlayerPos + ", with material: " + CubeMaterial;
            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                Debug.LogFormat(txt);
            }
            else
            {
                Debug.LogErrorFormat(txt);
            }
            //}
        }
    }
}
