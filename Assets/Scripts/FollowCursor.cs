
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    // Start is called before the first frame update

    TrailRenderer trail;
    void Start(){
        //Cursor.visible=false;
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 pos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position=pos;
        
    }

}
