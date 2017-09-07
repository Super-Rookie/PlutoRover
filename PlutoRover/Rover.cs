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

        public int LastCheckX;
        public int LastCheckY;

        public string Direction;
        public bool[,] Pluto;


        public Rover()
        {
            X = 0;
            Y = 0;
            Direction = "N";
            Pluto = new bool[100, 100];
        }

        public void Move(string command)
        {
            throw new NotImplementedException();
        }

        //Move rover according to input
        public bool Move(string input, string direction)
        {
            var moved = false;

            switch (direction)
            {
                case "N":
                    switch (input)
                    {
                        case "F":
                            if ((Y + 1) == Pluto.GetLength(1))
                            {
                                LastCheckX = X;
                                LastCheckY = 0;
                                moved = !Pluto[X, 0];
                                Y = moved ? 0 : Y;
                            }
                            else
                            {
                                LastCheckX = X;
                                LastCheckY = Y + 1;
                                moved = !Pluto[X, Y + 1];
                                Y = moved ? Y + 1 : Y;
                            }
                            break;
                        case "B":
                            if ((Y - 1) < 0)
                            {
                                LastCheckX = X;
                                LastCheckY = Pluto.GetLength(1) - 1;
                                moved = !Pluto[X, Pluto.GetLength(1) - 1];
                                Y = moved ? Pluto.GetLength(1) - 1 : Y;
                            }
                            else
                            {
                                LastCheckX = X;
                                LastCheckY = Y - 1;
                                moved = !Pluto[X, Y - 1];
                                Y = moved ? Y - 1 : Y;
                            }
                            break;
                    }
                    break;
                case "E":
                    switch (input)
                    {
                        case "F":
                            if ((X + 1) == Pluto.GetLength(0))
                            {
                                LastCheckX = 0;
                                LastCheckY = Y;
                                moved = !Pluto[0, Y];
                                X = moved ? 0 : X;
                            }
                            else
                            {
                                LastCheckX = X + 1;
                                LastCheckY = Y;
                                moved = !Pluto[X + 1, Y];
                                X = moved ? X + 1 : X;
                            }
                            break;
                        case "B":
                            if ((X - 1) < 0)
                            {
                                LastCheckX = Pluto.GetLength(0) - 1;
                                LastCheckY = Y;
                                moved = !Pluto[Pluto.GetLength(0) - 1, Y];
                                X = moved ? Pluto.GetLength(0) - 1 : X;
                            }
                            else
                            {
                                LastCheckX = X - 1;
                                LastCheckY = Y;
                                moved = !Pluto[X - 1, Y];
                                X = moved ? X - 1 : X;
                            }
                            break;
                    }
                    break;
                case "S":
                    switch (input)
                    {
                        case "F":
                            if ((Y - 1) < 0)
                            {
                                LastCheckX = X;
                                LastCheckY = Pluto.GetLength(1) - 1;
                                moved = !Pluto[X, Pluto.GetLength(1) - 1];
                                Y = moved ? Pluto.GetLength(1) - 1 : 0;
                            }
                            else
                            {
                                LastCheckX = X;
                                LastCheckY = Y - 1;
                                moved = !Pluto[X, Y - 1];
                                Y = moved ? Y - 1 : Y;
                            }
                            break;
                        case "B":
                            if ((Y + 1) == Pluto.GetLength(1))
                            {
                                LastCheckX = X;
                                LastCheckY = 0;
                                moved = !Pluto[X, 0];
                                Y = moved ? 0: Y;
                            }
                            else
                            {
                                LastCheckX = X;
                                LastCheckY = Y + 1;
                                moved = !Pluto[X, Y + 1];
                                Y = moved ? Y + 1 : Y;
                            }
                            break;
                    }
                    break;
                case "W":
                    switch (input)
                    {
                        case "F":
                            if ((X - 1) < 0)
                            {
                                LastCheckX = Pluto.GetLength(0) - 1;
                                LastCheckY = Y;
                                moved = !Pluto[Pluto.GetLength(0) - 1, Y];
                                X = moved ? Pluto.GetLength(0) - 1 : X;
                            }
                            else
                            {
                                LastCheckX = X - 1;
                                LastCheckY = Y;
                                moved = !Pluto[X - 1, Y];
                                X = moved ? X - 1 : X;
                            }
                            break;
                        case "B":
                            if ((X + 1) == Pluto.GetLength(0))
                            {
                                LastCheckX = 0;
                                LastCheckY = Y;
                                moved = !Pluto[0, Y];
                                X = moved ? 0 : X;
                            }
                            else
                            {
                                LastCheckX = X + 1;
                                LastCheckY = Y;
                                moved = !Pluto[X + 1, Y];
                                X = moved ? X + 1 : X;
                            }
                            break;
                    }
                    break;
            }

            return moved;
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
