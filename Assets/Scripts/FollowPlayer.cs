using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset=new Vector3(0,4.75f,-10f);


    // Start is called before the first frame update
    void Update()
    {
        
    }

    //To ensure smoothness we can change update to lateupdate, so anything in update will run first and late will run second
    void LateUpdate()
    {

        //updating the cameras position to the players position but question is dont you neeed an offset here?
        //and this brins us to the new vector3 add
        transform.position=player.transform.position+ offset;

    }
}
