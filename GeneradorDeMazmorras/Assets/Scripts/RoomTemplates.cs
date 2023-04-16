using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] rightRooms;
    public GameObject[] leftRooms;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    System.Random rnd = new System.Random();

    private int roomCount = 0;
    public Text roomCountText;


    public void IncrementRoomCount()
    {
        roomCount++;
        UpdateRoomCount();
    }

    private void UpdateRoomCount() 
    {
        roomCountText.text = "Cuartos Generados: " + roomCount.ToString();
    }
}
   



