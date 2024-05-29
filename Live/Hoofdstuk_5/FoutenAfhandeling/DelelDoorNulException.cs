namespace FoutenAfhandeling;

internal class DelelDoorNulException : DivideByZeroException
{
    public int FoutGetal { get; set; }
}
