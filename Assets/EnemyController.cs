using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public int maxHp = 1000;
    int currentHp;

    public Slider slider;

    GameObject gameManager;
    TalkScript talkScript;

    public AudioSource audioSource;
    public AudioClip attackSE;
 
    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        Debug.Log("Start currentHp :" + currentHp);

        slider.value = 1;

        gameManager = GameObject.Find("GameManager");
        talkScript = gameManager.GetComponent<TalkScript>();
    }

    // Update is called once per frame
    void Update()
    {
      if(currentHp <= 0)
      {
        gameObject.SendMessage("GameClearPauseWait");
      }
    }

    public void AttackPush()
    {
        int damage = Random.Range(100, 200);
        Debug.Log("damage :" + damage);

        currentHp = currentHp - damage;
        Debug.Log("After current:" + currentHp);

        slider.value = (float)currentHp / (float)maxHp;
        Debug.Log("slider.value :" + slider.value);

        Invoke("DamageButton", 2f);

        Text damage_text = talkScript.talkText;
        damage_text.text = damage + "のダメージをあたえる！";

        audioSource.PlayOneShot(attackSE);
    }

    public void DamageButton()
    {
      gameObject.SendMessage("DamagePush");
    }
}
