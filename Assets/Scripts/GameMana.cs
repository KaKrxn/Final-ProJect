using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMana : MonoBehaviour
{
    public static int nScore; // คะแนนที่สามารถเข้าถึงได้จากทุกที่

    void Start()
    {
        nScore = 0; // กำหนดค่าเริ่มต้น
    }
}
