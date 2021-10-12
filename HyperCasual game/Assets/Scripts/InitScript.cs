using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class InitScript : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera virtualCamera;

    // Update is called once per frame
   private void Update()
    {
        virtualCamera.m_Lens.OrthographicSize -= 20f * Time.deltaTime;
        virtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>().m_CameraDistance -= 20f * Time.deltaTime;
        if(virtualCamera.m_Lens.OrthographicSize <= 8.2f)
        {
            Destroy(gameObject);
        }
    }
}
