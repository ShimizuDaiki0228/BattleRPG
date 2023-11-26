using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkScript : MonoBehaviour
{
    public GameObject talkBox;
    public Text talkText;

    // Start is called before the first frame update
    void Start()
    {
        talkText.text = "スライムが現れた！";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WaitNext()
    {
      talkText.text = "次はどうする？";
    }
}
