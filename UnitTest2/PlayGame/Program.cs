using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGame
{
    public abstract class PlayGame
    {
        public string gameTitle;
        public abstract void PlayingGame();
        public virtual void TakeABreak()
        {
            Console.WriteLine("You stop playing to go to the bathroom.");
        }
    }

    public interface UsingController
    {
        void PushButtons();
    }

    public interface UsingMouseAndKeyboard
    {
        void PressKeys();
    }

    public class PlayingOnPC : PlayGame, UsingMouseAndKeyboard
    {
        public override void PlayingGame()
        {

        }

        public void PressKeys()
        {
            Console.WriteLine("Click-clacking away");
        }
    }

    public class PlayingOnConsole : PlayGame, UsingController
    {
        public override void PlayingGame()
        {

        }

        public void PushButtons()
        {
            Console.WriteLine("Mashing all the buttons");
        }
    }

    class Program
    {

        static void MyMethod(object obj)
        {
            if (obj.GetType() == typeof(PlayingOnPC))
            {
                UsingMouseAndKeyboard plugsInKeyboard = (UsingMouseAndKeyboard)obj;
                plugsInKeyboard.PressKeys();
            }
            else if (obj.GetType() == typeof(PlayingOnConsole))
            {
                UsingController plugsInController = (UsingController)obj;
                plugsInController.PushButtons();
            }
        }

        static void Main(string[] args)
        {
            PlayingOnPC keven = new PlayingOnPC();
            PlayingOnConsole deven = new PlayingOnConsole();

            MyMethod(keven);
            MyMethod(deven);
        }
    }
}
