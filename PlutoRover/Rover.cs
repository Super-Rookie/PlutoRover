using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRover
{
    public class Rover
    {
        public int X;
        public int Y;
        public string Direction;
        public bool[,] Pluto;

        public Rover()
        {
            X = 0;
            Y = 0;
            Direction = "N";
            Pluto = new bool[100, 100];
        }

        //Move rover according to input
        public void Move(string input, string direction)
        {
            switch (direction)
            {
                case "N":
                    switch (input)
                    {
                        case "F":
                            Y++;
                            break;
                        case "B":
                            Y--;
                            break;
                    }
                    break;
                case "E":
                    switch (input)
                    {
                        case "F":
                            X++;
                            break;
                        case "B":
                            X--;
                            break;
                    }
                    break;
                case "S":
                    switch (input)
                    {
                        case "F":
                            Y--;
                            break;
                        case "B":
                            Y++;
                            break;
                    }
                    break;
                case "W":
                    switch (input)
                    {
                        case "F":
                            X--;
                            break;
                        case "B":
                            X++;
                            break;
                    }
                    break;
            }
        }

        //Turn rover according to input
        public void Turn(string input, string currentDirection)
        {
            switch (currentDirection)
            {
                case "N":
                    switch (input)
                    {
                        case "L":
                            Direction = "W";
                            break;
                        case "R":
                            Direction = "E";
                            break;
                    }
                    break;
                case "E":
                    switch (input)
                    {
                        case "L":
                            Direction = "N";
                            break;
                        case "R":
                            Direction = "S";
                            break;
                    }
                    break;
                case "S":
                    switch (input)
                    {
                        case "L":
                            Direction = "E";
                            break;
                        case "R":
                            Direction = "W";
                            break;
                    }
                    break;
                case "W":
                    switch (input)
                    {
                        case "L":
                            Direction = "S";
                            break;
                        case "R":
                            Direction = "N";
                            break;
                    }
                    break;
            }
        }
    }
}
