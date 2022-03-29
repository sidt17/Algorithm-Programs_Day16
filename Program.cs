using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Permutation obj = new Permutation();
            String str = "SID";
            int k = str.Length;
            obj.Permute(str, 0, k - 1);

        }
    }


}
