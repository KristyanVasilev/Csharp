using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stringArr = ArrayCreator<string>.Create(5, "pesho");
            var integerArr = ArrayCreator<int>.Create(5, 123);
        }
    }
}
