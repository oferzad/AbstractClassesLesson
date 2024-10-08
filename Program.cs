namespace AbstractClassesLesson
{
    abstract class Vehicle
    {
        private int speed;
        public Vehicle(int speed)
        {
            this.speed = speed;
        }
        public abstract void TurnLeft();
        public abstract void TurnRight();
    }
    class Bicycle : Vehicle
    {
        private bool hasTrainingWheels;
        private bool isElectric;
        public Bicycle(int speed, bool hasTW, bool isElectric) : base(speed)
        {
            this.hasTrainingWheels = hasTW;
            this.isElectric = isElectric;
        }

        public override void TurnLeft()
        {
        }
        public override void TurnRight()
        {
        }
    }

    abstract class MotorVehicle : Vehicle
    {
        private int motorVolume;
        private int gasLevel;
        public MotorVehicle(int speed, int mV, int gL) : base(speed)
        {
            this.motorVolume = mV;
            this.gasLevel = gL;
        }
    }

    class Car : MotorVehicle
    {
        private int seats;
        public Car(int speed, int mV, int gL, int seats) : base(speed, mV, gL)
        {
            this.seats = seats;
        }
        public override void TurnLeft()
        {

        }
        public override void TurnRight()
        {

        }
    }

    class Truck : MotorVehicle
    {
        private int cabinVolume;
        public Truck(int speed, int mV, int gL, int cabinVolume) : base(speed, mV, gL)
        {
            this.cabinVolume = cabinVolume;
        }
        public override void TurnLeft()
        {

        }
        public override void TurnRight()
        {

        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Vehicle v = new Car(100, 2000, 100, 5);
        }
    }
}
