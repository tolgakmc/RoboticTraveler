using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticTraveler
{
    public class Robot
    {
        public int x;
        public int y;
        public String dir;
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x= value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public String DIR
        {
            get
            {
                return this.dir;
            }
            set
            {
                this.dir = value;
            }
        }

        public Robot(int xval, int yval, String direction)
        {
            x = xval;
            y = yval;
            dir = direction;
        }
        public void Move(String letters)
        {
            for(int i=0; i<letters.Length; i++)
            {
                if(letters[i] == 'L')
                {
                    turnLeft(this);
                }
                else if(letters[i] == 'R')
                {
                    turnRight(this);
                }
                else if(letters[i] == 'M')
                {
                    takeStep(this);
                }
            }
        }

        private void turnLeft(Robot robot)
        {
            if(robot.dir == "N")
            {
                robot.dir = "W";
            }
            else if (robot.dir == "W")
            {
                robot.dir = "S";
            }
            else if (robot.dir == "S")
            {
                robot.dir = "E";
            }
            else if (robot.dir == "E")
            {
                robot.dir = "N";
            }
        }

        private void turnRight(Robot robot)
        {
            if (robot.dir == "N")
            {
                robot.dir = "E";
            }
            else if (robot.dir == "E")
            {
                robot.dir = "S";
            }
            else if (robot.dir == "S")
            {
                robot.dir = "W";
            }
            else if (robot.dir == "W")
            {
                robot.dir = "N";
            }
        }

        private void takeStep(Robot robot)
        {
            if (robot.dir == "N")
            {
                robot.y++;
            }
            else if (robot.dir == "E")
            {
                robot.x++;
            }
            else if (robot.dir == "S")
            {
                robot.y--;
            }
            else if (robot.dir == "W")
            {
                robot.x--;
            }
        }
    } 
}
