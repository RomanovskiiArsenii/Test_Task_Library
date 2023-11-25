# Test_Task_Library

Задание1:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга 
по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

Задание 1 расположено в данном репозитории

Легкость добавления других фигур может быть достигнута через построение иерархии на основе их характеристик:
         
фигура   <   эллипс          <   круг

фигура   <   треугольник     <   равнобедренный треугольник 

фигура   <   треугольник     <   прямоугольный треугольник

фигура   <   прямоугольник   <   трапеция    <   параллелограмм    <   ромб


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
