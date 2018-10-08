using System;

namespace DLLweightConversions
{
    public class Class1
    {
        public double ConvertToOunces(double grams)
        {
            double oz = grams * 0.03527396195;
            return oz;


        }

        public double ConverttoGrams(double ounces)
        {
            double grams = ounces * 28.34952;
            return grams;
        }
    }
}
