namespace Tic_Tac_Toe;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Player1 is playing as x");
        Console.WriteLine("Player2 is playing as o");

        var jArray = new char[3, 3]
        {
            { '-', '-', '-' },
            { '-', '-', '-' },
            { '-', '-', '-' }
        };

        PrintTable(jArray);

        var gameStart = true;
        while (gameStart)
        {
            var player1 = true;
            var player2 = false;
            OuterLoop1:
            while (player1)
            {
                Console.Write("Enter Player1 position (x,y or x y): ");
                var coordinates1 = Console.ReadLine();
                var xcor1 = Convert.ToInt32(coordinates1[0].ToString());
                var ycor1 = Convert.ToInt32(coordinates1[2].ToString());


                while (0 < xcor1 && xcor1 > 2)
                {
                    Console.Write("Enter Player1 position (x,y or x y): ");
                    coordinates1 = Console.ReadLine();
                    xcor1 = Convert.ToInt32(coordinates1[0].ToString());
                    ycor1 = Convert.ToInt32(coordinates1[2].ToString());
                }

                while (0 < ycor1 && ycor1 > 2)
                {
                    Console.Write("Enter Player1 position (x,y or x y): ");
                    coordinates1 = Console.ReadLine();
                    xcor1 = Convert.ToInt32(coordinates1[0].ToString());
                    ycor1 = Convert.ToInt32(coordinates1[2].ToString());
                }


                while (jArray[xcor1, ycor1] == 'X' || jArray[xcor1, ycor1] == 'O')
                {
                    Console.Write("Cannot set position. [{0},{1}]\n", xcor1, ycor1);
                    goto OuterLoop1;
                }


                jArray[xcor1, ycor1] = 'X';
                PrintTable(jArray);
                player1 = false;
                player2 = true;
                if (Win(jArray, gameStart))
                {
                    gameStart = false;
                    player2 = false;
                }
            }


            OuterLoop2:
            while (player2)
            {
                Console.Write("Enter Player2 position (x,y or x y): ");
                var coordinates2 = Console.ReadLine();
                var xcor2 = Convert.ToInt32(coordinates2[0].ToString());
                var ycor2 = Convert.ToInt32(coordinates2[2].ToString());

                while (0 < xcor2 && xcor2 > 2)
                {
                    Console.Write("Enter Player2 position (x,y or x y): ");
                    coordinates2 = Console.ReadLine();
                    xcor2 = Convert.ToInt32(coordinates2[0].ToString());
                    ycor2 = Convert.ToInt32(coordinates2[2].ToString());
                }

                while (0 < ycor2 && ycor2 > 2)
                {
                    Console.Write("Enter Player2 position (x,y or x y): ");
                    coordinates2 = Console.ReadLine();
                    xcor2 = Convert.ToInt32(coordinates2[0].ToString());
                    ycor2 = Convert.ToInt32(coordinates2[2].ToString());
                }

                while (jArray[xcor2, ycor2] == 'X' || jArray[xcor2, ycor2] == 'O')
                {
                    Console.Write("Cannot set position. [{0},{1}]\n", xcor2, ycor2);
                    goto OuterLoop2;
                }


                jArray[xcor2, ycor2] = 'O';
                PrintTable(jArray);
                player2 = false;
                player1 = true;
                if (Win(jArray, gameStart))
                {
                    gameStart = false;
                    player1 = false;
                }
            }
        }


        static bool Win(char[,] jArray, bool gameStart)
        {
            if (checkPlayer1Winner(jArray))
            {
                Console.Write("Player1 win ");
                return true;
            }

            if (checkPlayer2Winner(jArray))
            {
                Console.Write("Player2 win ");
                return true;
            }

            return false;
        }


        static bool checkPlayer1Winner(char[,] jArray)
        {
            // check rows
            if (jArray[0, 0] == 'X' && jArray[0, 1] == 'X' && jArray[0, 2] == 'X') return true;
            if (jArray[1, 0] == 'X' && jArray[1, 1] == 'X' && jArray[1, 2] == 'X') return true;
            if (jArray[2, 0] == 'X' && jArray[2, 1] == 'X' && jArray[2, 2] == 'X') return true;

            // check columns
            if (jArray[0, 0] == 'X' && jArray[1, 0] == 'X' && jArray[2, 0] == 'X') return true;
            if (jArray[0, 1] == 'X' && jArray[1, 1] == 'X' && jArray[2, 1] == 'X') return true;
            if (jArray[0, 2] == 'X' && jArray[1, 2] == 'X' && jArray[2, 2] == 'X') return true;

            // check diags
            if (jArray[0, 0] == 'X' && jArray[1, 1] == 'X' && jArray[2, 2] == 'X') return true;
            if (jArray[0, 2] == 'X' && jArray[1, 1] == 'X' && jArray[2, 0] == 'X') return true;

            return false;
        }

        static bool checkPlayer2Winner(char[,] jArray)
        {
            // check rows
            if (jArray[0, 0] == 'O' && jArray[0, 1] == 'O' && jArray[0, 2] == 'O') return true;
            if (jArray[1, 0] == 'O' && jArray[1, 1] == 'O' && jArray[1, 2] == 'O') return true;
            if (jArray[2, 0] == 'O' && jArray[2, 1] == 'O' && jArray[2, 2] == 'O') return true;

            // check columns
            if (jArray[0, 0] == 'O' && jArray[1, 0] == 'O' && jArray[2, 0] == 'O') return true;
            if (jArray[0, 1] == 'O' && jArray[1, 1] == 'O' && jArray[2, 1] == 'O') return true;
            if (jArray[0, 2] == 'O' && jArray[1, 2] == 'O' && jArray[2, 2] == 'O') return true;

            // check diags
            if (jArray[0, 0] == 'O' && jArray[1, 1] == 'O' && jArray[2, 2] == 'O') return true;
            if (jArray[0, 2] == 'O' && jArray[1, 1] == 'O' && jArray[2, 0] == 'O') return true;

            return false;
        }


        static void PrintTable(char[,] jArray)
        {
            var rowLength = jArray.GetLength(0);
            var colLength = jArray.GetLength(1);


            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++) Console.Write(jArray[i, j] + " ");
                Console.Write("\n");
            }
        }
    }
}