using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("awake 실행");
    }
    private void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisEnable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    private void Update()
    {
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
}
