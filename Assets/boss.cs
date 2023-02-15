using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{

    //mp = 53 =use =Magic
    private int mp = 53;

    //Magic関数
    public void Magic(int use)
    {
   
        this.mp -= use;

        if(mp>=5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else if(mp<5)
        {
            Debug.Log("MPが足りないため、魔法攻撃が使えない。");
        }
    }
    
 

}



public class boss : MonoBehaviour

{
    int mmm(int use, int b)
    {
        int c = use - b;
        return c;
    }



    // Start is called before the first frame update
    void Start()
    {
        //bossクラスの変数を宣言
        Boss myBoss = new Boss();
     

        for (int i = 0; i < 10; i++)
        {
            myBoss.Magic(5);

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
//Lesson4で作成したBossクラスをもとに作成してください

//int型の変数mpを宣言し、53で初期化してください
//mpを消費して魔法攻撃をするMagic関数を作ってください
//Magic関数内でmpを5以上の場合は5減らし、コンソールに 魔法攻撃をした。
//残りMPは〇〇。 と表示してください。
//mpが足りない場合、MPが足りないため、魔法が使えない。 と表示してください



//Start関数で下記の条件を満たしてください

//Magic関数を呼び出して、魔法を使ってください
//Magic関数を10回使った後に、さらにMagic関数を呼び出すと、
//mpが足りないメッセージを表示することを確認してください