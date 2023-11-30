# Test_Task_Library

Так как в описании к вакансии было требование предоставить веб-проект, я опубликовал на GitHub небольшой сайт, дублирующий мое резюме. 
Ознакомиться можно здесь:  

https://romanovskiiarsenii.github.io/cv/

https://github.com/RomanovskiiArsenii/cv

Задание1:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга 
по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

Решение задания 1 расположено в данном репозитории.

1. Разработаны Юнит-тесты (MSTest) для классов: Triangle, Ellipse, Circle.

2. Легкость добавления других фигур может быть достигнута через построение иерархии на основе их характеристик:
фигура < эллипс < круг
фигура < трапеция < параллелограмм < ромб
фигура < трапеция < прямоугольник 

В данном решении, в целях демонстрации расширяемости библиотеки, эллипс представлен как класс в иерархии 
Shape < Ellipse < Circle, поскольку круг является частным случаем эллипса.

3. Площадь любой фигуры может быть вычислена без знания типы фигуры в compile-time, так как все 
производные классы могут быть приведены к типу базового класса без потери или искажения функциональности
базового класса, что согласуется как с принципом "Барбары Лисков", так и с принципом "Открытости - Закрытости".

4. Проверка на то, является ли треугольник прямоугольным, реализована в нестатическом методе IsTriangleRight класса Triangle 

************************************************************

Задание 2:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать 
много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора 
всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно 
должно выводиться.

Решение задания 2 приведено ниже по тексту:

Описанное отношение является отношением "многое ко многим", значит мы строим запрос через таблицу, 
которая представляет из себя специальную таблицу связей между таблицами products и categories, 
назовем ее  productscategories. Запрос будет выглядеть так:

select p.Name, c.Name
from products p
left join productscategories pc on p.id = pc.productid
left join categories c on c.id = pc.categoriesid
