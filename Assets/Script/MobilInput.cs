using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilInput : MonoBehaviour
{
    private Touch isTouch;
    [SerializeField] float speed = 1;
    [SerializeField] CannonShot Shoting;
    [SerializeField] float Delay;
    float countSpawn;

    private void Update()
    {

        if (Input.touchCount > 0)
        {
            isTouch = Input.GetTouch(0);
            MoveCannon();
        }
    }
    private void MoveCannon()
    {

        if (isTouch.phase == TouchPhase.Moved || isTouch.phase == TouchPhase.Stationary)
        {
            if (Time.time > countSpawn)
            {
                Shoting.Soting();
                countSpawn = Time.time + Delay;
            }
            LineMove();
        }
        if (isTouch.phase == TouchPhase.Ended)
        {


            Shoting.SpawnBigBrother();

        }


    }
    void LineMove()
    {
        float xAxsis = Mathf.Clamp((transform.localPosition.x + isTouch.deltaPosition.x * Time.deltaTime * speed), -2.5f, 2.5f);
        transform.localPosition = new Vector3(xAxsis,
            transform.localPosition.y,
            transform.localPosition.z);
    }


}
