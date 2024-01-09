string binaryNumber = "1010"; // Ikkilik sanoq sistemasidagi son
int decimalNumber = 0;
int baseValue = 1;
for (int i = binaryNumber.Length - 1; i >= 0; i--)
{
    if (binaryNumber[i] == '1')
    {
        decimalNumber += baseValue;
    }
    baseValue *= 2;
}
Console.WriteLine(decimalNumber); // O'nlik sanoq sistemasidagi sonni konsolda chiqarish


