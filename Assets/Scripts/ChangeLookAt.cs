using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    //Declare a game object variable which defines the target where the camera should look at
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
     if(target == null){
        target = this.gameObject;
        Debug.Log("change look target is not specified. defaulting to parent Object");
     }   
    }

    // Update is called once per frame
    private void OnMouseDown(){
    
    Lookat.target = target; 
    Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1,200);
   
    }
  }
