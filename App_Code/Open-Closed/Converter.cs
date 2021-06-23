using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Converter
/// </summary>
public abstract class Converter
{
    public int DecimalNumber { get; set; }
    public Converter(int decimalNumber)
    {
        DecimalNumber = decimalNumber;
    }
    public abstract string Convert();
}
public class BinaryConverter : Converter
{
    public BinaryConverter(int decimalNumber)
    : base(decimalNumber)
    {
    }
    public override string Convert()
    {
        return "The result is: "+ System.Convert.ToString(DecimalNumber, 2);
    }
}
public class OctalConverter : Converter
{
    public OctalConverter(int decimalNumber)
    : base(decimalNumber)
    {
    }
    public override string Convert()
    {
        return "The result is: " + System.Convert.ToString(DecimalNumber, 8);
    }
}
public class HexadecimalConverter : Converter
{
    public HexadecimalConverter(int decimalNumber) : base(decimalNumber)
    { }
    public override string Convert()
    {
        return "The result is"+ DecimalNumber.ToString("X");
    }
}