using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{

    //mp = 53 =use =Magic
    private int mp = 53;

    //Magic�֐�
    public void Magic(int use)
    {
   
        this.mp -= use;

        if(mp>=5)
        {
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else if(mp<5)
        {
            Debug.Log("MP������Ȃ����߁A���@�U�����g���Ȃ��B");
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
        //boss�N���X�̕ϐ���錾
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
//Lesson4�ō쐬����Boss�N���X�����Ƃɍ쐬���Ă�������

//int�^�̕ϐ�mp��錾���A53�ŏ��������Ă�������
//mp������Ė��@�U��������Magic�֐�������Ă�������
//Magic�֐�����mp��5�ȏ�̏ꍇ��5���炵�A�R���\�[���� ���@�U���������B
//�c��MP�́Z�Z�B �ƕ\�����Ă��������B
//mp������Ȃ��ꍇ�AMP������Ȃ����߁A���@���g���Ȃ��B �ƕ\�����Ă�������



//Start�֐��ŉ��L�̏����𖞂����Ă�������

//Magic�֐����Ăяo���āA���@���g���Ă�������
//Magic�֐���10��g������ɁA�����Magic�֐����Ăяo���ƁA
//mp������Ȃ����b�Z�[�W��\�����邱�Ƃ��m�F���Ă�������