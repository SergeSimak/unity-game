using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRotatingCylinder : MonoBehaviour
{
    [SerializeField] public new GameObject gameObject;
    public Vector3 Direction;
    public float MaxDistance = 5;

    private Rigidbody _rigidbody;
    private void Awake()
    {
        gameObject.transform.position = Vector3.zero;
    }

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.velocity = Direction;
        StartCoroutine(Fixed());
    }

    private IEnumerator Fixed()
    {
        var condition = new WaitUntil(() => MaxDistance <= gameObject.transform.position.magnitude);
        while (true)
        {
            yield return condition;
            _rigidbody.velocity *= -1;
            yield return new WaitForFixedUpdate();
        }
    }
}

