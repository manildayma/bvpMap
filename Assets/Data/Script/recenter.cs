using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recenter : MonoBehaviour
{
   public GameObject cam, other;
   public void recenterCam()
   { 
      cam.transform.position = new Vector3 (-290f, 105f, -278.7f); 

      Vector3 dir = other.transform.position - cam.transform.position;
      //Debug.Log(dir);
      //Quaternion targetRotation = Quaternion.LookRotation(dir);
      //cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, targetRotation, Time.deltaTime);
      cam.transform.rotation = Quaternion.LookRotation(dir);
   }


}
