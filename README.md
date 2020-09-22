# folder_01

1. Даны целые положительные числа A, B, C. Значение
этих чисел программа должна запрашивать у пользователя. На прямоугольнике размера A*B размещено
максимально возможное количество квадратов со
стороной C. Квадраты не накладываются друг на
друга. Найти количество квадратов, размещенных на
прямоугольнике, а также площадь незанятой части
прямоугольника.
Необходимо предусмотреть служебные сообщения
в случае, если в прямоугольнике нельзя разместить ни
одного квадрата со стороной С (например, если значение С превышает размер сторон прямоугольника).

2. Начальный вклад в банке равен 10000 грн. Через
каждый месяц размер вклада увеличивается на P
процентов от имеющейся суммы (P — вещественное
число, 0 < P < 25). Значение Р программа должна получать у пользователя. По данному P определить через
сколько месяцев размер вклада превысит 11000 грн.,
и вывести найденное количество месяцев K (целое
число) и итоговый размер вклада S (вещественное
число).

3. Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое
число должно выводиться на новой строке; при этом
каждое число должно выводиться количество раз,
равное его значению (например, число 3 выводится 3 раза)

4. Дано целое число N большее 0, найти число, полученное при прочтении числа N справа налево. Например,
если было введено число 345, то программа должна
вывести число 543

# folder_02
## Array 
1. Дан одномерный массив А, состоящий из N элементов. Сколько значений элементов в массиве А встречается более одного раза.
2. Дан одномерный массив А, состоящий из N элементов. Сколько значений элементов встречается в массиве по 3 раза.
3. Дан одномерный массив А, состоящий из N элементов. Определить количество чисел, входящих в массив по одному разу.
4. Дан одномерный массив А, состоящий из N элементов. Подсчитать максимальное количество подряд идущих нулей.
5. Дан одномерный массив А, состоящий из N элементов. Перенести в начало массива все положительные элементы, а в конец массива - все отрицательные.
6. Дан одномерный массив А, состоящий из N элементов. Перенести в начало массива все четные элементы, а в конец массива - все нечетные.
7. Дан одномерный массив А, состоящий из N элементов. Подсчитать максимальное количество подряд идущих отрицательных элементов.
8. Дан одномерный массив А, состоящий из N элементов. Найти первый и последний положительные элементы массива и подсчитать количество элементов, заключенных между ними.
## String
1. Создать метод принимающий, введенную пользователем, строку и выводящий на экран статистику по этой строке.Статистика должна включать общее количество символов, количество букв(и сколько в верхнем регистре и нижнем), количество цифр, количество символов пунктуации и количество пробельных символов.
2. Пользователь вводит строку и символ. В строке найти все вхождения этого символа и перевести его в верхний регистр, а также удалить часть строки, начиная с последнего вхождения этого символа и до конца.
3. Дана строка символов. Осуществить в этой строке поиск заданного слова.
4. Дан текст. Осуществить в этом тексте поиск и замену заданной фразы.
5. Создать функцию для проверки корректности расстановки скобок в выражении.
6. Пользователь вводит с клавиатуры арифметическое выражение. Необходимо вычислить его значение с учетом приоритетов введенных математических операций и скобок.Если в выражении встречаются другие символы, выдать сообщение, что выражение введено не корректно. "5*2-(3+5)="
7. Написать функцию, преобразующую дробное или целое число в строку.
8. Написать функцию, преобразующую строку в дробное или целое число.
9. Написать функцию, которая определяет является ли строка палиндромом.
10. Сколько раз в строке, введенной пользователем, встречается указанное слово?

# folder_03
## Практическая работа 1
Классы, свойства, индексаторы. Одномерные, прямоугольные и ступенчатые
массивы
Требования к программе, общие для всех вариантов
Определить тип Gender - перечисление(enum) со значениями Male, Female
типа byte.
Определить класс Person, который имеет
• закрытое поле типа long, в котором хранится десятизначный
идентификационный код (0000000001,0000000002,0000000003,…9999999999)
– определяется автоматически
• закрытое поле типа string, в котором хранится имя;
• закрытое поле типа string, в котором хранится фамилия;
• закрытое поле типа System.DateTime для даты рождения.
• закрытое поле типа Gender для пола
В классе Person определить конструкторы:
• конструктор c параметрами для инициализации всех полей класса
кроме идентификационного кода;
• конструктор без параметров, инициализирующий все поля класса
некоторыми значениями по умолчанию.
В классе Person определить свойства c методами get и set:
• свойство типа string для доступа к полю с именем;
• свойство типа string для доступа к полю с фамилией;
• свойство типа DateTime для доступа к полю с датой рождения;
• свойство типа Gender для доступа к полю с полом;
• свойство типа string c методом get для получения информации о
идентификационном коде.
• свойство типа byte c методом get для получения информации о возрасте
(в годах).
В классе Person определить
• перегруженную(override) версию виртуального метода string ToString()
для формирования строки со значениями всех полей класса;
• виртуальный метод string ToShortString(), который возвращает строку,
содержащую только идентификационный код, имя и фамилию.
Cравнить время, необходимое для выполнения операций с элементами
одномерного, двумерного прямоугольного и двумерного ступенчатого
массивов с одинаковым числом элементов типа Person.
Для этого в методе Main() создать
• одномерный массив;
• двумерный прямоугольный массив;
• двумерный ступенчатый массив.
Массивы должны иметь одинаковое число элементов. Если число строк в
двумерном прямоугольном массиве равно nrow, а число столбцов ncolumn, то
одномерный массив должен содержать nrow*ncolumn элементов, в
двумерном ступенчатом массиве общее число элементов также должно быть
равно nrow*ncolumn.
Значения nrow и ncolumn вводятся в процессе работы приложения в виде
одной строки с разделителями. В приглашении, которое получает
пользователь, должна быть информация о том, какие символы можно
использовать как разделители, число разделителей должно быть больше 1. С
помощью метода Split класса System.String приложение разбирает введенную
пользователем текстовую строку с информацией о числе строк и числе
столбцов двумерного массива и присваивает значения переменным, которые 
содержат значения nrow и ncolumn. В первой лабораторной работе не
требуется обрабатывать ошибки ввода, предполагается, что пользователь
правильно ввел данные.
Приложение распределяет память для всех массивов и инициализирует
элементы массивов. Для инициализации элементов можно
использовать конструктор без параметров.
Для всех элементов массивов выполняется одна и та же операция,
например, присваивается значение одному из свойств, определенных для
элементов массива. В работе требуется сравнить время выполнения этой
операции для одномерного, двумерного прямоугольного и двумерного
ступенчатого массивов с одинаковым числом элементов.
Для измерения времени выполнения операций можно использовать
свойство Environment.TickCount. Cтатическое свойство TickCount класса
Environment имеет тип int, использует информацию системного таймера и
содержит время в миллисекундах, которое прошло с момента перезагрузки
компьютера.
Чтобы получить время выполнения некоторого блока кода, необходимо
вызвать Environment.TickCount непосредственно перед блоком и сразу же
после последнего оператора блока и взять разность значений.
В блоке кода, для которого измеряется время, не должно быть операций
распределения памяти для массивов, инициализации элементов массивов и
операций вывода данных на консоль. Блоки кода должны содержать только
операции с элементами массива.
Вычисленные значения времени выполнения операций для трех типов
массивов, а также число строк nrow и столбцов ncolumn выводятся на
консоль. Вывод должен быть подписан, т.е. вывод должен содержать
информацию о том, какому типу массива отвечает выведенное значение.
## Вариант 1. Требования к программе
Определить тип Education - перечисление(enum) со значениями Вachelor,
Specialist, Master.
Определить класс Exam, который имеет три открытых
автореализуемых свойства, доступных для чтения и записи:
• свойство типа string, в котором хранится название предмета;
• свойство типа int, в котором хранится оценка;
• свойство типа System.DateTime для даты экзамена.
В классе Exam определить:
• конструктор с параметрами типа string, int и DateTime для
инициализации всех свойств класса;
• конструктор без параметров, инициализирующий все свойства класса
некоторыми значениями по умолчанию;
• перегруженную(override) версию виртуального метода string ToString()
для формирования строки со значениями всех свойств класса.
Определить класс Student, который имеет
• закрытое поле типа Person, в котором хранятся данные студента;
• закрытое поле типа Education для информации о форме обучения;
• закрытое поле типа int для номера группы;
• закрытое поле типа Exam[] для информации об экзаменах, которые
сдал студент.
В классе Student определить конструкторы:
• конструктор c параметрами типа Person, Education, int для
инициализации соответствующих полей класса;
• конструктор без параметров, инициализирующий поля класса
значениями по умолчанию.
В классе Student определить свойства c методами get и set:
• свойство типа Person для доступа к полю с данными студента;
• свойство типа Education для доступа к полю с формой обучения;
• свойство типа int для доступа к полю с номером группы;
• свойство типа Exam[] для доступа к полю со списком экзаменов.
В классе Student определить
• свойство типа double ( только с методом get), в котором вычисляется
средний балл как среднее значение оценок в списке сданных экзаменов;
• индексатор булевского типа (только с методом get) с одним
параметром типа Education; значение индексатора равно true, если значение
поля с
формой обучения студента совпадает со значением индекса, и false в
противном случае;
• метод void AddExams ( params Exam [] ) для добавления элементов в
список экзаменов;
• перегруженную версию виртуального метода string ToString() для
формирования строки со значениями всех полей класса, включая список
экзаменов;
• виртуальный метод string ToShortString(), который формирует строку
со значениями всех полей класса без списка экзаменов, но со значением
среднего балла. 
В методе Main()
• Создать один объект типа Student, преобразовать данные в текстовый
вид с помощью метода ToShortString() и вывести данные.
• Вывести значения индексатора для значений индекса
Education.Specialist, Education.Bachelor и Education.SecondEducation.
• Присвоить значения всем определенным в типе Student свойствам,
преобразовать данные в текстовый вид с помощью метода ToString() и
вывести данные.
• C помощью метода AddExams( params Exam[] ) добавить элементы в
список экзаменов и вывести данные объекта Student, используя метод
ToString().
• Сравнить время выполнения операций с элементами одномерного,
двумерного прямоугольного и двумерного ступенчатого массивов с
одинаковым числом элементов типа Exam.
## Вариант 2. Требования к программе
Определить тип Frequency - перечисление (enum) со значениями
Weekly, Monthly, Yearly.
Определить класс Article, который имеет три открытых автореализуемых
свойства, доступных для чтения и записи:
• свойство типа Person, в котором хранятся данные автора статьи;
• свойство типа string для названия статьи;
• свойство типа double для рейтинга статьи.
В классе Article определить:
• конструктор c параметрами типа Person, string, double для
инициализации всех свойств класса;
• конструктор без параметров, инициализирующий все свойства класса
некоторыми значениями по умолчанию;
• перегруженную(override) версию виртуального метода string ToString()
для формирования строки со значениями всех свойств класса.
Определить класс Magazine, который имеет
• закрытое поле типа string c названием журнала;
• закрытое поле типа Frequency с информацией о периодичности выхода
журнала;
• закрытое поле типа DateTime c датой выхода журнала;
• закрытое поле типа int с тиражом журнала;
• закрытое поле типа Article[] со списком статей в журнале.
В классе Magazine определить конструкторы:
• конструктор с параметрами типа string, Frequency, DateTime, int для
инициализации соответствующих полей класса;
• конструктор без параметров, инициализирующий поля класса
значениями по умолчанию.
В классе Magazine определить свойства c методами get и set:
• свойство типа string для доступа к полю с названием журнала;
• свойство типа Frequency для доступа к полю с информацией о
периодичности выхода журнала;
• свойство типа DateTime для доступа к полю c датой выхода журнала;
• свойство типа int для доступа к полю с тиражом журнала;
• свойство типа Article[] для доступа к полю со списком статей.
В классе Magazine определить
• свойство типа double ( только с методом get), в котором вычисляется
среднее значение рейтинга в списке статей;
• индексатор булевского типа (только с методом get) с одним
параметром типа Frequency; значение индексатора равно true, если значение
поля типа Frequency совпадает со значением индекса, и false в противном
случае;
• метод void AddArticles (params Article[]) для добавления элементов в
список статей в журнале;
• перегруженную версию виртуального метода string ToString() для
формирования строки со значениями всех полей класса, включая список
статей;
• виртуальный метод string ToShortString(), который формирует строку
со значениями всех полей класса без списка статей, но со значением среднего
рейтинга статей.
В методе Main()
• Создать один объект типа Magazine, преобразовать данные в текстовый
вид с помощью метода ToShortString() и вывести данные.
• Вывести значения индексатора для значений индекса
Frequency.Weekly, Frequency.Monthly и Frequency.Yearly.
• Присвоить значения всем определенным в типе Magazine свойствам,
преобразовать данные в текстовый вид с помощью метода ToString() и
вывести данные.
• C помощью метода AddArticles( params Article*+ ) добавить элементы в
список статей и вывести данные объекта Magazine, используя метод
ToString().
• Сравнить время выполнения операций с элементами одномерного,
двумерного прямоугольного и двумерного ступенчатого массивов с
одинаковым числом элементов типа Article.
