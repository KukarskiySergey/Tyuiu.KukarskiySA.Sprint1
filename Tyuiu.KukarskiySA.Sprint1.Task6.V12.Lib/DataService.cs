using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KukarskiySA.Sprint1.Task6.V12.Lib;

public class DataService : ISprint1Task6V12
{
    public bool CheckLastWordRepetiton(string text)
    {
        // Проверка на пустой ввод
        if (string.IsNullOrWhiteSpace(text))
        {
            return false; // Возвращаем false, если строка пустая или состоит только из пробелов
        }

        // Разделение строки на слова
        string[] words = text.Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        // Получение последнего слова
        string lastWord = words[words.Length - 1];

        // Удаляем последнее слово из текста для проверки
        string textWithoutLastWord = text.Substring(0, text.LastIndexOf(lastWord)).Trim();

        // Проверяем, встречается ли последнее слово еще раз в тексте
        return textWithoutLastWord.Contains(lastWord);
    }
}
