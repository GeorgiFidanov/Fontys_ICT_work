public class Car
{
    private string brand;
    private int currentSpeed;
    private int maxSpeed;

    public void SetBrand(string brand)
    {
        this.brand = brand;
    }

    public void SetMaxSpeed(int maxSpeed)
    {
        this.maxSpeed = maxSpeed;
    }

    public void SpeedUp()
    {
        if (currentSpeed + 7 <= maxSpeed)
        {
            currentSpeed += 7;
        }
        else
        {
            currentSpeed = maxSpeed;
        }
    }

    public void SlowDown()
    {
        if (currentSpeed - 10 >= 0)
        {
            currentSpeed -= 10;
        }
        else
        {
            currentSpeed = 0;
        }
    }

    public string GetInfo()
    {
        return $"Brand: {brand}, Current Speed: {currentSpeed} km/h, Max Speed: {maxSpeed} km/h";
    }
}
