using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class ttt_field
    {
        Random rnd_cell = new Random();

        int[,] _field = new int[3, 3];
        double[,] _weights = new double[3, 3];

        public void FieldSet(int x, int y, int data)
        {
            _field[x, y] = data;
        }
        public int[,] FieldGet()
        { 
            return _field;
        }

        public void PlayerDraw(int x, int y)
        {
            _field[x, y] = 2;
            AiMove();
        }
        void AiDraw(int x, int y)
        {
            _field[x, y] = 1;
        }

        void FindPositions()
        {
            //searching 4 availible cells to make move
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _weights[i, j] = GetReward(_field[i, j]);
                }
            }
            //searching 4 2-len ai's chains (yes, there's some shitcode) pls dont watch it
            {

                if (_field[0, 0] == 1 && _field[0, 1] == 1 && _field[0, 2] == 0)
                {
                    _weights[0, 2] += 0.5;
                }
                if (_field[1, 0] == 1 && _field[1, 1] == 1 && _field[1, 2] == 0)
                {
                    _weights[1, 2] += 0.5;
                }
                if (_field[2, 0] == 1 && _field[2, 1] == 1 && _field[2, 2] == 0)
                {
                    _weights[2, 2] += 0.5;
                }

                if (_field[0, 0] == 0 && _field[0, 1] == 1 && _field[0, 2] == 1)
                {
                    _weights[0, 0] += 0.5;
                }
                if (_field[1, 0] == 0 && _field[1, 1] == 1 && _field[1, 2] == 1)
                {
                    _weights[1, 0] += 0.5;
                }
                if (_field[2, 0] == 0 && _field[2, 1] == 1 && _field[2, 2] == 1)
                {
                    _weights[2, 0] += 0.5;
                }



                if (_field[0, 0] == 1 && _field[1, 0] == 1 && _field[2, 0] == 0)
                {
                    _weights[2, 0] += 0.5;
                }
                if (_field[0, 1] == 1 && _field[1, 1] == 1 && _field[2, 1] == 0)
                {
                    _weights[2, 1] += 0.5;
                }
                if (_field[0, 2] == 1 && _field[1, 2] == 1 && _field[2, 2] == 0)
                {
                    _weights[2, 2] += 0.5;
                }

                if (_field[0, 0] == 0 && _field[1, 0] == 1 && _field[2, 0] == 1)
                {
                    _weights[0, 0] += 0.5;
                }
                if (_field[0, 1] == 0 && _field[1, 1] == 1 && _field[2, 1] == 1)
                {
                    _weights[0, 1] += 0.5;
                }
                if (_field[0, 2] == 0 && _field[1, 2] == 1 && _field[2, 2] == 1)
                {
                    _weights[0, 2] += 0.5;
                }



                if (_field[0, 0] == 1 && _field[1, 1] == 1 && _field[2, 2] == 0)
                {
                    _weights[2, 2] += 0.5;
                }
                if (_field[0, 0] == 0 && _field[1, 1] == 1 && _field[2, 2] == 1)
                {
                    _weights[0, 0] += 0.5;
                }

                if (_field[2, 0] == 1 && _field[1, 1] == 1 && _field[0, 2] == 0)
                {
                    _weights[0, 2] += 0.5;
                }
                if (_field[2, 0] == 0 && _field[1, 1] == 1 && _field[0, 2] == 1)
                {
                    _weights[2, 0] += 0.5;
                }
            }
            //some randomise 2 make ai making moves on game start
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_weights[i, j] > 0.2)
                    {
                        _weights[i, j] += (double)rnd_cell.Next(0, 20) / 100;
                    }
                }
            }
        }

        public void AiMove()
        {
            int[] coords = new int[2] {0, 0};
            double max = 0.3;

            FindPositions();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_weights[i, j] > max)
                    {
                        max = _weights[i, j];
                        coords[0] = i;
                        coords[1] = j;
                    }
                }
            }

            AiDraw(coords[0], coords[1]);
        }

        public double GetReward(int who)
        {
            switch (who)
            {
                case 1: return 0.2; break;
                case 2: return 0.0; break;
                default: return 0.5; break;
            }
        }

        public ttt_field()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _weights[i, j] = 0.0;
                    _field[i, j] = 0;
                }
            }
        }
    }
}
