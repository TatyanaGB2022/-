# ИТОГОВАЯ РАБОТА
**Задача.** 

***Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.***

Примеры результатов работы программы:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

**Алгоритм**
1. Объявляем метод **FillArraу**
2. Инициализируем переменную **count** равную 0.
3. Внутри метода в цикле проводим проверку условия (<=3).
Если условие выполняется, то результат заносится в **count**. Переменная **count** увеличивается на 1 и возвращается к циклу. И так проверяется до конца.
4. Объявляем метод **PrintArray**, который позволяет вывести результат
