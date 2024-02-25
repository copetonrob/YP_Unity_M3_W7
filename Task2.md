# Задание 2: Здоровье игрока

## Описание

В этом задании сделаем полоску здоровья для игрока. Для этого мы будем использовать элемент Slider.

## Инструкция

1) Создай в сцене объект UI -> Sldier. Проверь, что он является дочерним к твоему канвасу.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/create_slider.png" width="300"/>

2) Посмотри настройки слайдера в инспекторе. Закрепи его в углу экрана. Можно так же с помощью преднастроек с зажатым Alt. Задай подходящую ширину, высоту и отступы по x, y от края экрана. Убери галочку Interactable.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/slider_settings.png" width="300"/>

3) Задай цвета для объектов Background и Fill (дочерние объекты у Slider). Отключи или удали Handle Slide Area.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/slider_colors.png" width="300"/>

4) Перенеси в проект скрипт [PlayerHealth.cs](https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/scripts/PlayerHealth.cs) и исправь закомментированные фрагменты так, чтобы скрипт заработал

5) Дополни свой скрипт [Enemy.cs](https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/scripts/Enemy.cs) (или перенеси в проект, если у тебя его не было). В нем так же нужно восстановить утраченные фрагменты.

6) Добавь скрипт PlayerHealth игроку и прокинь ссылку на слайдер здоровья.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/PlayerHealth.png" width="300"/>

7) Запусти проект и проверь, что все работает.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/task2.gif" width="300"/>

В данный момент игра ломается после смерти игрока. Это потому что в игроке лежала камера и она удаляется, когда игрок погибает. Мы исправим это на следующим вебинаре!
