using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{

    public UISprite leader;
    // Start is called before the first frame update
    void Start()
    {
        iTween.RotateTo(leader.gameObject, iTween.Hash("y", 180, "time", 0, "easetype", iTween.EaseType.easeInOutSine));
        leader.spriteName = "DragonBallBack";   
    }

    // Update is called once per frame
    void Update()
    {
        //give the rotation angle of leader
        Debug.Log(leader.transform.rotation.eulerAngles.y);
        //set sprite of leader
        if (leader.transform.rotation.eulerAngles.y < 90) {
           leader.spriteName = "FS01-01_f";
        }else{
            leader.spriteName = "DragonBallBack";
        }
    }
    public void buttonClick()
    {
        Debug.Log("Button Clicked");
        //use itween to flip leader
        iTween.RotateTo(leader.gameObject, iTween.Hash("y", 0, "time", 1, "easetype", iTween.EaseType.easeInOutSine));
    }
}
