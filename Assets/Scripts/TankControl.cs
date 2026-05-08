using UnityEngine;

public class TankControl : MonoBehaviour
{
    public GameObject playerObject;
    float hor = Input.GetAxis("Horizontal");
    float ver = Input.GetAxis("Vertical");
    void Update()
    {
        
    }
    void KeyBoard()
    {
        if(hor == 1)
        {
            //playerObject.transform.position += Vector3.right; доделай движение вправо и влево
        }
    }
}
