using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int maxHp = 1000;
    int currentHp;

    public Slider slider;

    GameObject gameManager;
    TalkScript talkScript;

    public AudioSource audioSource;
    public AudioClip damageSE;

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
          gameObject.SendMessage("GameOverPauseWait");
        }
    }

    public void DamagePush()
    {
      int damage = Random.Range(100, 200);
      Debug.Log("playerdamage :" + damage);
  
      currentHp = currentHp - damage;
      Debug.Log("After currentHp : + currentHp");

      slider.value = (float)currentHp / (float)maxHp;
      Debug.Log("slider.value :" + slider.value);

      Text damage_text = talkScript.talkText;
      damage_text.text = damage + "のダメージを食らった！";

      Invoke("AllTalk", 3f);

      audioSource.PlayOneShot(damageSE);
    }

    public void AllTalk()
    {
      talkScript.WaitNext();
    }
}
