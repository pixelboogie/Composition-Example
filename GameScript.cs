using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyGame;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IHealth cc = new Player();

        Debug.Log(cc.health + "/" + cc.maxHealth);
        Debug.Log("Health " + cc.CurrentHealthPercent() + "%");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
