using System;

namespace MyDictionary
{
    class MyDict<TK, TV>
    {
        TK[] arrayKey;
        TK[] tempKey;
        TV[] arrayValue;
        TV[] tempValue;
        public MyDict()
        {
            arrayKey = new TK[0];
            arrayValue = new TV[0];
            
        }
        public void Add(TK key, TV value)
        {
            tempKey = arrayKey;
            tempValue = arrayValue;
            arrayKey = new TK[arrayKey.Length + 1];
            arrayValue = new TV[arrayValue.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                arrayKey[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                arrayValue[i] = tempValue[i];
            }

            arrayKey[arrayKey.Length - 1] = key;
            arrayValue[arrayValue.Length - 1] = value;
            
            for (int i = 0; i < arrayKey.Length; i++)
            {
               Console.WriteLine("Stok:" + arrayKey[i] + "   Malzeme Adı:" + arrayValue[i]);
              
            }
            Console.WriteLine("");
        }


    }
}
