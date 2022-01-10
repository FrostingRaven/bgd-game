using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class CharacterAiming : MonoBehaviour
{
    public float turnSpeed = 15;
    public float aimDuration = 0.3f;
    Camera mainCamera;
    public Rig aimLayer;
    /*
    public Rig bodyLayer;
    public Rig poseLayer;
    public Rig ikLayer;
    */
    public bool rifleBool = false;

    RaycastWeapon weapon;

    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        weapon = GetComponentInChildren<RaycastWeapon>();
    }

    public void SmartUpdate()
    {
        float yawCamera = mainCamera.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);
    }
    /*
    public void RifleMode()
    {
        if (rifleBool == true)
        {
            bodyLayer.weight += Time.deltaTime / aimDuration;
            poseLayer.weight += Time.deltaTime / aimDuration;
            aimLayer.weight += Time.deltaTime / aimDuration;
            ikLayer.weight += Time.deltaTime / aimDuration;
        }
        else
        {
            bodyLayer.weight -= Time.deltaTime / aimDuration;
            poseLayer.weight -= Time.deltaTime / aimDuration;
            aimLayer.weight -= Time.deltaTime / aimDuration;
            ikLayer.weight -= Time.deltaTime / aimDuration;
        }
    }

    */
    private void LateUpdate()
    {
        if (aimLayer)
        {
            if (Input.GetButton("Fire2"))
            {
                aimLayer.weight += Time.deltaTime / aimDuration;
            }
            else
            {
                aimLayer.weight -= Time.deltaTime / aimDuration;
            }
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            weapon.StartFiring();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            weapon.StopFiring();
        }
        /*
        if (Input.GetKey(KeyCode.Q))
        {
            rifleBool = !rifleBool;
            exmCoroutine();
            RifleMode();
        }
        */
    }

    IEnumerator exmCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
    }
}
