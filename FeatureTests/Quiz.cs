using System;
using static System.Console;
class Quiz
{
    public Quiz()
    {
        int score = 2;
        var questions = new[]
        {
            ("Столица Беларуси", "Минск"),
            ("Столица Украины", "Киев"),
            ("Столица России","Москва"),
            ("Мяу?", "Мяу")
        };
        foreach (var pair in questions)
            Ask(pair.Item1, pair.Item2, ref score, questions.Length);
    }
    static void Ask(string ques, string ans, ref int score, int nquest)
    {
        WriteLine(ques);
        if (ReadLine() == ans)
        {
            score++;
            WriteLine("Молодец, правильно");
        }
        else
        {
            score--;
            WriteLine($"Увы, ошибка, правильный ответ: {ans}");
            ManageLose(score, nquest);
        }
        WriteLine($"Ваш счёт: {score}");
        static void ManageLose(int score, int nquest)
        {
            if (score > 0)
                return;
            WriteLine($"Увы, проигрыш!\nВикторина пройдена со счётом {score}/{nquest}\nТвоя оценка: { score * 10 / nquest}/ 10");
            Environment.Exit(0);
        }
    }
   
}
