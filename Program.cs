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
            Namespace nmsp = new Namespace(); //名前空間の生成
            Language lng = new Language();    //記述する言語
            nmsp.language = lng;              //名前空間を記述する言語
            nmsp.namespaceName = "Test";      //名前空間名
            nmsp.elements = new List<Element>(); //名前空間内の要素
            Class cls = new Class();             //クラス要素
            cls.className = "Class1";            //クラス名
            cls.language = lng;                  //クラス要素を記述する言語

            ClassFunction clf = new ClassFunction(); //メンバ関数
            clf.language = lng;                      //関数を記述する言語
            clf.functionName = "func1";              //関数名
            clf.accessLevel = E_AccessLevel.PUBLIC;  //アクセスレベル
            Type tp = new Type();                    //型
            tp.typeName = "aa";                      //型名
            clf.returnType = tp;                     //関数の戻り値型
            var clfres = clf.on_Build();             //クラス関数のビルド結果
            Console.WriteLine(clfres);               
            
            nmsp.add_ToChild(cls);                   //クラスを名前空間内に含める
            var res = nmsp.on_Build();               //名前空間要素のビルド
            Console.WriteLine(res);
        }
    }
}