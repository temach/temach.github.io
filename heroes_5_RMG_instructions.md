## Рандомный генератор карт

Создать папки (data, RMG, Templates) чтобы существовал такой путь:

C:\Program Files (x86)\Buka\Герои Меча и Магии V - Повелители Орды\data\RMG\Templates\

Или

C:\GOG Games\Heroes of Might and Magic V - Tribes of the East\data\RMG\Templates\

В эту папку можно класть файлы с расширением .xdb (будьте внимательны должно выглядеть так - https://github.com/temach/temach.github.io/blob/master/Capture.PNG )
на самом деле это просто XML текстовые файлы
их можно редактировать в обычном текстовом редакторе - Notepad++ : https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v7.8.8/npp.7.8.8.Installer.x64.exe

Есть несколько шаблонов из интернета: https://github.com/temach/temach.github.io/blob/master/RMG-templates.zip?raw=true

Тот шаблон на котором играть: https://raw.githubusercontent.com/temach/temach.github.io/master/artem.xdb

Шаблон чтобы посмотреть как работают разные параметры: https://raw.githubusercontent.com/temach/temach.github.io/master/S6-11P2-8Z9K2XL.xdb
При выборе этого шаблона он будет в "Громадных" картах с названием: 3P-Team-H/Lu-(All) 


## Параметры для генератора
Возможные значения для размеров карт и зон:

```
$ fgrep Size  S1*  | awk '{print $0} /MaxMapSize/ {print "\n"}'
S1-2P2-4Z4K1S.xdb:      <Size>10</Size>
S1-2P2-4Z4K1S.xdb:      <Size>10</Size>
S1-2P2-4Z4K1S.xdb:      <Size>10</Size>
S1-2P2-4Z4K1S.xdb:      <Size>10</Size>
S1-2P2-4Z4K1S.xdb:      <Size>10</Size>
S1-2P2-4Z4K1S.xdb:  <MinMapSize>30</MinMapSize>
S1-2P2-4Z4K1S.xdb:  <MaxMapSize>35</MaxMapSize>


S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>10</Size>
S1-2P2-8Z8K2S.xdb:      <Size>20</Size>
S1-2P2-8Z8K2S.xdb:  <MinMapSize>60</MinMapSize>
S1-2P2-8Z8K2S.xdb:  <MaxMapSize>70</MaxMapSize>


S1-2P2Z7V2.xdb:      <Size>10</Size>
S1-2P2Z7V2.xdb:      <Size>10</Size>
S1-2P2Z7V2.xdb:      <Size>10</Size>
S1-2P2Z7V2.xdb:      <Size>10</Size>
S1-2P2Z7V2.xdb:      <Size>10</Size>
S1-2P2Z7V2.xdb:      <Size>10</Size>
S1-2P2Z7V2.xdb:      <Size>20</Size>
S1-2P2Z7V2.xdb:  <MinMapSize>45</MinMapSize>
S1-2P2Z7V2.xdb:  <MaxMapSize>50</MaxMapSize>


S1-3P2-4Z5V.xdb:      <Size>10</Size>
S1-3P2-4Z5V.xdb:      <Size>10</Size>
S1-3P2-4Z5V.xdb:      <Size>10</Size>
S1-3P2-4Z5V.xdb:      <Size>10</Size>
S1-3P2-4Z5V.xdb:  <MinMapSize>15</MinMapSize>
S1-3P2-4Z5V.xdb:  <MaxMapSize>20</MaxMapSize>


S1-3P2Z7V3.xdb:      <Size>10</Size>
S1-3P2Z7V3.xdb:      <Size>10</Size>
S1-3P2Z7V3.xdb:      <Size>10</Size>
S1-3P2Z7V3.xdb:      <Size>20</Size>
S1-3P2Z7V3.xdb:  <MinMapSize>30</MinMapSize>
S1-3P2Z7V3.xdb:  <MaxMapSize>35</MaxMapSize>


S1P2Z2M1.xdb:      <Size>10</Size>
S1P2Z2M1.xdb:      <Size>10</Size>
S1P2Z2M1.xdb:      <Size>10</Size>
S1P2Z2M1.xdb:  <MinMapSize>15</MinMapSize>
S1P2Z2M1.xdb:  <MaxMapSize>20</MaxMapSize>


S1P2Z3K5.1.xdb:      <Size>10</Size>
S1P2Z3K5.1.xdb:      <Size>10</Size>
S1P2Z3K5.1.xdb:      <Size>10</Size>
S1P2Z3K5.1.xdb:      <Size>10</Size>
S1P2Z3K5.1.xdb:      <Size>10</Size>
S1P2Z3K5.1.xdb:      <Size>20</Size>
S1P2Z3K5.1.xdb:  <MinMapSize>45</MinMapSize>
S1P2Z3K5.1.xdb:  <MaxMapSize>50</MaxMapSize>
```


Возможные значения для Name поля чтобы работал фильтр по размеру:

```
$ fgrep Name S* | grep -v FileRef | awk '{print $2}' | sort -u
<Name>2P-Belt-M.Su-(All)</Name>
<Name>2P-Chain-M.Su-(All)</Name>
<Name>2P-Mini-S/Tu-(All)</Name>
<Name>2P-Mini-T-(All)</Name>
<Name>2P-Std-M-(All)</Name>
<Name>3P-Belt-Mu-(All)</Name>
<Name>3P-Mini-M-(All)</Name>
<Name>3P-Std-L-(All)</Name>
<Name>3P-Std-M/Su-(All)</Name>
<Name>4P-Belt-XL-(All)</Name>
<Name>4P-Mini-M/Su-(All)</Name>
<Name>4P-Std-L-(All)</Name>
<Name>4P-Std-Mu-(All)</Name>
<Name>5P-Belt-H/Lu-(All)</Name>
<Name>5P-Std-XL-(All)</Name>
<Name>6P-Belt-H/Lu-(All)</Name>
<Name>6P-Std-XL-(All)</Name>
<Name>6P-Team-H/Lu-(All)</Name>
<Name>6P-Team-XL-(All)</Name>
<Name>8P-Std-H/Lu-(All)</Name>
<Name>8P-Team-H/Lu-(All)</Name>
<Name>8P-Team-XLu-(All)</Name>
```

