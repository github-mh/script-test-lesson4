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

        //5から０になるまで引き続けている。下り４から０

        //ループの1周めは u = 5 なので array[5]（5番目）となりますが
        //これは0から数えた時「6要素目」ということになります。
        //この配列 array は要素が5つなので、範囲外でエラーとなってしまうのです。
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
