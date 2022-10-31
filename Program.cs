using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoCoder // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Namespace nmsp = new Namespace(); //���O��Ԃ̐���
            Language lng = new Language();    //�L�q���錾��
            nmsp.language = lng;              //���O��Ԃ��L�q���錾��
            nmsp.namespaceName = "Test";      //���O��Ԗ�
            nmsp.elements = new List<Element>(); //���O��ԓ��̗v�f
            Class cls = new Class();             //�N���X�v�f
            cls.className = "Class1";            //�N���X��
            cls.language = lng;                  //�N���X�v�f���L�q���錾��

            ClassFunction clf = new ClassFunction(); //�����o�֐�
            clf.language = lng;                      //�֐����L�q���錾��
            clf.functionName = "func1";              //�֐���
            clf.accessLevel = E_AccessLevel.PUBLIC;  //�A�N�Z�X���x��
            Type tp = new Type();                    //�^
            tp.typeName = "aa";                      //�^��
            clf.returnType = tp;                     //�֐��̖߂�l�^
            var clfres = clf.on_Build();             //�N���X�֐��̃r���h����
            Console.WriteLine(clfres);               
            
            nmsp.add_ToChild(cls);                   //�N���X�𖼑O��ԓ��Ɋ܂߂�
            var res = nmsp.on_Build();               //���O��ԗv�f�̃r���h
            Console.WriteLine(res);
        }
    }
}