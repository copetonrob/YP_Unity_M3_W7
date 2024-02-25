# Задание 1: Прицел

## Описание

В первом задании мы сделаем прицел для нашего игрока. Если у тебя нет стрельбы, ничего страшного. Можно будет сделать ее позже. Основное требование к прицелу, чтобы он был зафиксирован в центральной части экрана, куда смотрит линия огня персонажа (или будет смотреть). И при этом не смещался и не искажался от изменения размеров игрового окна.

## Инструкция

1) Создай объект UI -> Canvas в иерархии сцены. Обрати внимание на компонент Canvas Scaler. Выстави параметры так, чтобы элементы UI масштабировались при изменении размера игрового окна.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/canvas.png" width="300"/>

2) Создай объект UI -> Image. Проследи, чтобы он был дочерним объектом канваса. Это будет наш прицел.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/Image.png" width="300"/>

3) Выстави якорь в центр экрана. Для этого можно использовать пресет с зажатым Alt

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/anchor.png" width="300"/>

4) Найди в интернете картинку для прицела. Желательно на прозрачном фоне в формате png. Можно использовать любой поисковик или проверить специальные стоки с изображениями, например, [этот](https://www.flaticon.com/free-icons/aim?k=1708699659805&log-in=google)

Если хочешь, можешь взять наш [прицел](https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/crosshair.png)

5) Поменяй texture type на Sprite (2D and UI). Нажми Apply, чтобы применить изменения

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/texture.png" width="300"/>

6) Помести картинку в Source Image в компоненте Image

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/source.png" width="300"/>

7) Выбери подходящую ширину и высоту в компоненте Rect Transform, чтобы прицел выглядел хорошо. Если твоя стрельба у персонажа смещена относительно центра, выстави соответствующий anchor вручную.

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/wh.png" width="300"/>

Прицел готов!

<img src="https://github.com/copetonrob/YP_Unity_M3_W7/blob/main/img/task1.png" width="600"/>
