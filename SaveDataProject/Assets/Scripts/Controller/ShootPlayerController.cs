using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayerController : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;
    private Camera _cameraPlayer;
    [SerializeField] private int _damageValue;//устанавливаем какой урон дает этот шутер
                                         // Start is called before the first frame update





    private void Awake()
    {
        _cameraPlayer = Camera.main;


    }


    private void Update()
    {
        Ray traccer = _cameraPlayer.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, traccer.direction * 15);//15 это длина луча
        RaycastHit hit;
        if (Physics.Raycast(traccer, out hit))
        {
            // _targetPoint.position = hit.point;
            if (Input.GetKeyDown(KeyCode.Mouse0) && hit.collider.TryGetComponent(out IDamageableObj obj_damagable))
            {   
                
                obj_damagable.ApplyDamage(_damageValue);
            }
        }
    }
}
