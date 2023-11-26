using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerAttack()
    {
      player.GetComponent<Animator>().SetTrigger("attack");

      Invoke("EnemyDamage", 1f);
    }

    public void EnemyDamage()
    {
      enemy.GetComponent<Animator>().SetTrigger("damage");
    }
}
