using SmallBasicFun;

namespace SimpleSquare
{
    public class SimpleSquare
    {
        public static void Main()
		{
			
            Tortoise.Show();
            Tortoise.SetSpeed(5);
            MakeSquare();
            Tortoise.Turn(-90);
            MakeSquare();
            Tortoise.Move(50);
            MakeSquare();

		}

        private static void MakeSquare()
        {
            for (int i = 0; i < 4; i++)
            {
                Tortoise.SetPenColor("blue");
                Tortoise.Move(50);
                Tortoise.Turn(90);
            }
        }
    }
}