using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];

        array[0] = 100;
        array[1] = 200;
        array[2] = 300;
        array[3] = 400;
        array[4] = 500;

        //5����O�ɂȂ�܂ň��������Ă���B����S����O

        //���[�v��1���߂� u = 5 �Ȃ̂� array[5]�i5�Ԗځj�ƂȂ�܂���
        //�����0���琔�������u6�v�f�ځv�Ƃ������ƂɂȂ�܂��B
        //���̔z�� array �͗v�f��5�Ȃ̂ŁA�͈͊O�ŃG���[�ƂȂ��Ă��܂��̂ł��B
        for (int u = 4; u >= 0; u--)
        {
            Debug.Log(array[u]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
