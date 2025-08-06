public class HourlyEmployee : Employee
{
    private float _payRate = 0;
    private int _hoursWorked;

    public float GetPayrate()
    {
        return _payRate;
    }
    public void SetPayRate(float payRate)
    {
        _payRate = payRate;
    }

    public int GetHoursWorked()
    {
        return _hoursWorked;
    }
    public void SetHoursWorked(int hours)
    {
        _hoursWorked = hours;
    }

    public override float GetPay()
    {
        return _hoursWorked * 4 * _payRate;
    }
}