namespace C__Hex_to_Ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char choice = Helpers.Setup();
                switch (choice)
                {
                    case '1':
                        Helpers.ChoiceOne();
                        break;
                    case '2':
                        Helpers.ChoiceTwo();
                        break;
                }
            }
        }
    }
}
