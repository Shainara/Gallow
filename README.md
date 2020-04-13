# Gallow
Игра создана на языке C# с использованием WF.
Реализация кнопок меню Start, Stop, Rules и Developer.
Поле ввода букв и кнопка отправки заблокированы, если игра не начались или окончилась.
В полях выводится информация о количестве букв в загаданном слове и процессе его открытия, допущенные ошибки, количество доступных попыток.
При изменении количества попыток, меняется изображение виселицы.
В поле ввода происходит проверка на валидность введенных букв путем регулярных выражений (допускается лишь одна буква русского алфавита), игрок информируется о некорректности ввода и ему даются инструкции.
Загаданное слово генерируется случайно из списка слов в текстовом файле.
