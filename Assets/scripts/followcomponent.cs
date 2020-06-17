using UnityEngine;

public class followcomponent : MonoBehaviour
{
  public Transform player;
  public Vector3 offset;//stores 3 float number for third person view


    // Update is called once per frame
    void Update()
    {
      transform.position = player.position + offset;
    }
}
