﻿using System;
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

        public Rover()
        {
            X = 0;
            Y = 0;
            Direction = "N";
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
    }
}
