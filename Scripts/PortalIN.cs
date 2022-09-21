using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalIN : MonoBehaviour
{
    public Transform TranslatePosition;
    // public Transform[] PortalPositions;
    bool gDown;
    
    void Update() {
        gDown = Input.GetButtonDown("Interaction");
    }

    void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Player" && gDown) {

            // 님꺼 포탈 계~~~~~~~~~~~~속타면 알아서 회전하고 이상한 버그걸려서 바꿨음 걍 제가한거로 하시려면 주석 지우삼

                // Transform ParentTransform = other.transform;
                // while(true) {
                //     if(ParentTransform.parent == null)
                //         break;
                //     else
                //         ParentTransform = ParentTransform.parent;
                // }

                // ParentTransform.position = TranslatePosition.position;
                // ParentTransform.rotation = other.transform.rotation;
                other.transform.position = TranslatePosition.position;


        }
    }
}
