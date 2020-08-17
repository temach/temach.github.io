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

Возможные значения для других параметров (взяты из шаблонов):

```
<UpgBuildingsDensity>([0-9]+)</UpgBuildingsDensity>
         4 -         72

<TreasureDensity>([0-9]+)</TreasureDensity>
         4 -         60

<TreasureChestDensity>([0-9]+)</TreasureChestDensity>
         4 -         60

<Prisons>([0-9]+)</Prisons>
         0 -          1

<LandCartographer>([0-9]+)</LandCartographer>
         0 -          0

<ShopPoints>([0-9]+)</ShopPoints>
         0 -         16

<ShrinePoints>([0-9]+)</ShrinePoints>
         0 -         40

<LuckMoralBuildingsDensity>([0-9]+)</LuckMoralBuildingsDensity>
        16 -         24

<ResourceBuildingsDensity>([0-9]+)</ResourceBuildingsDensity>
         0 -         32

<TreasureBuildingPoints>([0-9]+)</TreasureBuildingPoints>
         6 -        108

<TreasureBlocksTotalValue>([0-9]+)</TreasureBlocksTotalValue>
     18000 -     400000

<DenOfThieves>([0-9]+)</DenOfThieves>
         0 -          0

<RedwoodObservatoryDensity>([0-9]+)</RedwoodObservatoryDensity>
         0 -          0

<BuffPoints>([0-9]+)</BuffPoints>
         0 -          0
```


Код для агрегирования данных:

```python
#!/usr/bin/env python

import argparse
import re

parser = argparse.ArgumentParser()
parser.add_argument('files', nargs='+')
args = parser.parse_args()

patterns = [
      r"""<UpgBuildingsDensity>([0-9]+)</UpgBuildingsDensity>""",
      r"""<TreasureDensity>([0-9]+)</TreasureDensity>""",
      r"""<TreasureChestDensity>([0-9]+)</TreasureChestDensity>""",
      r"""<Prisons>([0-9]+)</Prisons>""",
      r"""<LandCartographer>([0-9]+)</LandCartographer>""",
      r"""<ShopPoints>([0-9]+)</ShopPoints>""",
      r"""<ShrinePoints>([0-9]+)</ShrinePoints>""",
      r"""<LuckMoralBuildingsDensity>([0-9]+)</LuckMoralBuildingsDensity>""",
      r"""<ResourceBuildingsDensity>([0-9]+)</ResourceBuildingsDensity>""",
      r"""<TreasureBuildingPoints>([0-9]+)</TreasureBuildingPoints>""",
      r"""<TreasureBlocksTotalValue>([0-9]+)</TreasureBlocksTotalValue>""",
      r"""<DenOfThieves>([0-9]+)</DenOfThieves>""",
      r"""<RedwoodObservatoryDensity>([0-9]+)</RedwoodObservatoryDensity>""",
      r"""<BuffPoints>([0-9]+)</BuffPoints>""",
]

res = {p : [] for p in patterns}

for path in args.files:
    with open(path, "r") as f:
        lines = f.readlines()
        for l in lines:
            for p in patterns:
                match = re.findall(p, l)
                if match:
                    assert len(match) == 1
                    res[p].append(int(match[0]))

for pattern in res.keys():
    print(pattern)
    small =  min(res[pattern])
    big =  max(res[pattern])
    print("{:10} - {:10}\n".format(small, big))

```
