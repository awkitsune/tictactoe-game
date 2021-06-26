using System;

namespace tic_tac_toe
{
    public delegate void MoveHandler(int x, int y);
    public class Move
    {
        public event MoveHandler Pressed;
        public void BtnPressed(int x, int y)
        {
            if (Pressed != null) Pressed(x, y);
        }
    }
    class TicTacToeField
    {
        Random rnd_icon = new Random();
        Random rnd_cell = new Random();

        int[,] _icon = new int[3, 3];
        int[,] _field = new int[3, 3];
        double[,] _weights = new double[3, 3];

        bool _isWinned = true;
        bool _isPlayerWinned = false;

        public void FieldSetCell(int x, int y, int data)
        {
            _field[x, y] = data;
        }
        public int[,] GetField()
        { 
            return _field;
        }
        public int GetIcon(int x, int y)
        {
            return _icon[x, y];
        }
        public bool GetWinState()
        {
            return _isWinned;
        }
        public void SetWinState(bool value)
        { 
            _isWinned = value; 
        }
        public bool GetPlayerState()
        {
            return _isPlayerWinned;
        }
        public void SetPlayerState(bool value)
        {
            _isPlayerWinned = value;
        }
        public void Flush()
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

        public void PlayerDraw(int x, int y)
        {
            if (_field[x, y] == 0)
            {
                _field[x, y] = 2;
                Console.WriteLine($"Placed user's zero to {x}, {y}");
                PrintField();

                if (!CheckForWin(true))
                { 
                    _isWinned = false;
                    _isPlayerWinned = false;
                    AiMove();
                }
                else 
                {
                    _isWinned = true;
                    _isPlayerWinned = true;
                }
            }
        }
        void AiDraw(int x, int y)
        {
            if (_field[x, y] == 0)
            {
                _field[x, y] = 1;
            }
        }

        void AiMove()
        {
            int[] coords = new int[2] {0, 0};
            double max = 0.1;

            FindPosition();

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

            Console.WriteLine($"Placed ai's cross to {coords[0]}, {coords[1]}");
            AiDraw(coords[0], coords[1]);
            Console.WriteLine();

            if (!CheckForWin(false))
            {
                _isWinned = false; 
                _isPlayerWinned = false;
            }
            else
            {
                _isWinned = true;
                _isPlayerWinned = false;
            }
            PrintField();
            ClearWeights();
        }
        void FindPosition()
        {
            Console.WriteLine("Searching for cells");
            //searching for availible cells to make move
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _weights[j, i] = GetFreeCells(_field[j, i]);
                }
            }
            PrintWeights();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //searching for cells to make move
                    if (_field[i, j] == 1)
                    {
                        try { if (!(_field[i - 1, j - 1] == 2)) _weights[i - 1, j - 1] += 0.1; }
                        catch (Exception) { }
                        try { if (!(_field[i, j - 1] == 2)) _weights[i, j - 1] += 0.1; }
                        catch (Exception) { }
                        try { if (!(_field[i + 1, j - 1] == 2)) _weights[i + 1, j - 1] += 0.1; }
                        catch (Exception) { }

                        try { if (!(_field[i - 1, j] == 2)) _weights[i - 1, j] += 0.1; }
                        catch (Exception) { }
                        try { if (!(_field[i + 1, j] == 2)) _weights[i + 1, j] += 0.1; }
                        catch (Exception) { }

                        try { if (!(_field[i - 1, j + 1] == 2)) _weights[i - 1, j + 1] += 0.1; }
                        catch (Exception) { }
                        try { if (!(_field[i, j + 1] == 2)) _weights[i, j + 1] += 0.1; }
                        catch (Exception) { }
                        try { if (!(_field[i + 1, j + 1] == 2)) _weights[i + 1, j + 1] += 0.1; }
                        catch (Exception) { }
                    }
                }
            }
            PrintWeights();

            //searching for player's combinations 2 make ai supress it
            Console.WriteLine("Searching for player's winnable combinations to preserve it...");

            Console.WriteLine("Searching in vertical positions...");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_weights[i, j] > 0.2)
                    {
                        if (_field[i, 0] + _field[i, 1] + _field[i, 2] == 4)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (_field[i, k] == 0) 
                                    _weights[i, k] += 0.3;
                            }
                        }
                    }
                }
            }
            PrintWeights();

            Console.WriteLine("Searching in horizontal positions...");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_weights[i, j] > 0.2)
                    {
                        if (_field[0, i] + _field[1, i] + _field[2, i] == 4)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (_field[k, i] == 0)
                                    _weights[k, i] += 0.3;
                            }
                        }
                    }
                }
            }
            PrintWeights();

            Console.WriteLine("Searching in main diagonal positions...");

            if (_field[0, 0] + _field[1, 1] + _field[2, 2] == 4)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (_field[k, k] == 0)
                        _weights[k, k] += 0.3;
                }
            }

            PrintWeights();

            Console.WriteLine("Searching in additional diagonal positions...");

            if (_field[2, 0] + _field[1, 1] + _field[0, 2] == 4)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (_field[2 - k, k] == 0) 
                        _weights[2 - k, k] += 0.3;
                }
            }

            PrintWeights();

            //searching for 2-len ai's chains (yes, there's some shitcode) pls dont watch it
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

            Console.WriteLine("Randomizing weights");
            //some randomize 2 make ai making moves on game start
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_field[i, j] == 0)
                    {
                        _weights[i, j] += (double)rnd_cell.Next(0, 123) / 1000;
                    }
                }
            }
            PrintWeights();
        }
        double GetFreeCells(int who)
        {
            switch (who)
            {
                case 1: return 0.0; break;
                case 2: return 0.0; break;
                default: return 0.5; break;
            }
        }

        bool CheckForWin(bool isPlayer) //searching 4 3-cells combinations
        {
            int n = 1;
            if (isPlayer)
            {
                n = 2;
            }

            //checking horizontal lines
            if ((_field[0, 0] == n && _field[1, 0] == n && _field[2, 0] == n) ||
                (_field[0, 1] == n && _field[1, 1] == n && _field[2, 1] == n) ||
                (_field[0, 2] == n && _field[1, 2] == n && _field[2, 2] == n))
            {
                return true;
            }
            //checking vertical lines
            if ((_field[0, 0] == n && _field[0, 1] == n && _field[0, 2] == n) ||
                (_field[1, 0] == n && _field[1, 1] == n && _field[1, 2] == n) ||
                (_field[2, 0] == n && _field[2, 1] == n && _field[2, 2] == n))
            {
                return true;
            }
            //checking diagonal lines
            if ((_field[0, 0] == n && _field[1, 1] == n && _field[2, 2] == n) ||
                (_field[2, 0] == n && _field[1, 1] == n && _field[0, 2] == n))
            {
                return true;
            }

            return false;
        }

        void ClearWeights()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _weights[i, j] = 0;
                }
            }
        }

        void PrintWeights()
        {   Console.WriteLine("_weights: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {_weights[j, i]:F3} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        void PrintField()
        {
            Console.WriteLine("_field: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string str = $"   {_field[j, i]}   |";
                    str = str.Replace('2', 'o');
                    str = str.Replace('1', 'x');
                    str = str.Replace('0', ' ');
                    Console.Write(str);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public TicTacToeField()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _weights[i, j] = 0.0;
                    _field[i, j] = 0;
                    _icon[i, j] = rnd_icon.Next(1, 3);
                }
            }
        }
    }
}
