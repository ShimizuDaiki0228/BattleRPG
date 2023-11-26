using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{
    public Button attackButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackButton()
    {
      Button btn = attackButton.GetComponent<Button>();
      btn. interactable = false;

      Invoke("VisibleButton", 3.5f);
    }

    public void VisibleButton()
    {
      Button btn = attackButton.GetComponent<Button>();
      btn. interactable = true;
    }
}
