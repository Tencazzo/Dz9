using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Failik.Classes
{
    public class Zagadka : Game
    {
        private readonly List<(string Question, string Answer)> riddles;

        public Zagadka()
        {
            riddles = new List<(string, string)>
            {
            ("Что всегда впереди, но никогда не видно?", "Будущее"),
            ("Что можно сломать, но нельзя пощупать?", "Обещание"),
            ("Что растет, но не живое?", "Возраст"),
            ("Что у вас есть, но вы никогда не используете, пока не потеряете?", "Имя"),
            ("Что уходит, но всегда возвращается?", "Время")
            };
        }

        public override void Play()
        {
            Console.WriteLine("Игра 'Загадки' началась!");
            int score = 0;

            foreach (var riddle in riddles)
            {
                Console.WriteLine($"Загадка: {riddle.Question}");
                Console.Write("Введите ответ: ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.Equals(riddle.Answer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Правильно! Вы получаете 1 очко.");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Неправильно! Правильный ответ: {riddle.Answer}");
                }
            }

            Console.WriteLine($"Игра окончена! Ваш счет: {score} очков.");
        }
    }
}
