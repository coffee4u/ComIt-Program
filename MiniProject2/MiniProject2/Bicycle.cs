using System;
namespace MiniProject2
{
    public class Bicycle
    {
        int speed;
        int gear;

        public Bicycle()
        {
            speed = 1;
            gear = 1;
        }

        public Bicycle(int speed, int gear)
        {
            this.speed = speed;
            this.gear = gear;
        }

        //change gear up
        public void gearUp()
        {
            gear++;
        }
        //change gear down
        public void gearDown()
        {
            gear--;
        }
        //increase the speed
        public void increaseSpeed()
        {
            speed++;
        }
        //decrease the speed
        public void decreaseSpeed()
        {
            speed--;
        }
        //display speed and gear
        public String ToString()
        {
            return "Speed:  " + speed + " Gear: " + gear;
        }
    }
}
