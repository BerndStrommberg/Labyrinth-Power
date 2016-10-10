using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {

    Animator anim;
    bool keyUp = AnimatorControllerParameter.Equals(keyUp)
    
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            anim.SetBool(keyUp);
        }

    }
}
