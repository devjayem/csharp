using System;

static class AssemblyLine
{
    static double carProductionPerHour = 221.0;
    static double successRate;
    static double totalProducedCar;
    static int totalProducedWorkingCarPerMin;
    public static double SuccessRate(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");


        if (speed == 10)
        {
            successRate = 0.77;
        }
        else if (speed == 9)
        {
            successRate = 0.8;
        }
        else if (speed >= 5 && speed <= 8)
        {
            successRate = 0.9;
        }
        else if(speed >= 1 && speed <= 4)
        {
            successRate = 1.0;
        }
        else if (speed == 0)
        {
            return 0;
        }

        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");

        switch (speed)
        {
            case 0:
                return 0.0;
            default:
                return totalProducedCar = speed * carProductionPerHour * SuccessRate(speed);
        }
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        double _totalProduceWorkingPerMinutes = 0;
        double producedCarPerMinutes = carProductionPerHour / 60;

        if (speed == 0)
        {
            totalProducedCar = 0;
        }
        else if (speed >= 1 && speed <= 10)
        {
            _totalProduceWorkingPerMinutes = (producedCarPerMinutes * speed) * SuccessRate(speed);
        }

        return totalProducedWorkingCarPerMin = (int)_totalProduceWorkingPerMinutes;

    }
}
