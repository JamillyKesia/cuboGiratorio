using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girar : MonoBehaviour{

    public Transform target;
    // public Transform moon;
    public float speed;
    public float eixoX;
    public float eixoY;
    public float eixoZ;

    // public float speed2;
    // Start � chamado antes da primeira atualiza��o do frame
    void Start()
    {
        if (target == null)
        {
            target = gameObject.transform;
            Debug.Log(message: "Alvo n�o definido.");
        }
    }

    //A atualiza��o � chamada uma vez por quadro
    void Update()
    {
        transform.RotateAround(target.position, new Vector3(eixoX, eixoY, eixoZ), speed * Time.deltaTime);
    }

}
