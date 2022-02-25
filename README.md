# 02-01-03-bank
*Setter és osztályok külön fájlokba. Saját kivételek. Kivétel kezelés.*

Készítsen osztályt bankszámla kezelésére (BankBalance). A bankszámla osztály nyilvántartja a számlán lévő összeget, és hogy milyen típusú számláról van szó (string). Bankszámlát csak típusának megadásával és az egyenlegre rakott pénz (amount) megadásával lehet létrehozni. A bankszámla típusa (type) egy szöveg, pl. „magánszámla”, „vállalkozói számla” stb. Bankszámla létrehozásakor harmadik paraméterként egy összeget kell megadni. Annál kevesebb összeggel nem jöhet létre a bankszámla. Ha az összeg kevesebb, akkor az egyenleget nullára kell állítani.

A bankszámla típusa legyen módosítható és olvasható adat! A számlán lévő összeg csak olvasható! A bankszálára a tulajdonos elhelyezhet adott összeget (Deposit), vagy adott összeget levehet a számláról (Withdraw)! Ha az osztály karakterlánccá alakítja, jelenjen meg a számla típusa és a rajta lévő összeg. Ebben a feladatrészben az rendellenességekkel még nem kell foglalkozni!

Készítsen osztályt FamilyMember néven. Egy családtagnak adott a neve (name), saját bankszámlája (ownAccount) és közös, családi bankszámlája (jointAccount). Az osztály ezen adatok megadásával jöhet létre! Minegyeik adat gettelhető és settelhető. Ha az osztály karakterlánccá alakítja, akkor jelenjen meg a tulajdonos neve és a két számlájának adata! A családtag áthelyezhet egy adott pénzösszeget az egyik számlájáról a másikra (TransferMoney). Ilyenkor meg kell adni annak a számlának a nevét ahonnan vesszük le a pénzt, azután azt a számlát amelyre rakjuk a pénzt, majd végül az összeget. A lehetséges rendellenességekkel it sem kell még foglalkozni.
A teszt kód kimenete:
```
Tulajdonos:Pénzes Mária
Számla típusa: Mária magán számlája
Számlán lévő összeg: 30000
Számla típusa: Családi közös számla
Számlán lévő összeg: 20000

Tulajdonos:Pénzes Péter
Számla típusa: Péter magán számlája
Számlán lévő összeg: 10000
Számla típusa: Családi közös számla
Számlán lévő összeg: 20000

A számla típusút helytelenül adta meg
```
[második rész]


Hibát dobó rendellenességek programozása:
 -	Negatív vagy nulla összeget nem lehet a számláról levenni vagy a számlára berakni! ) ExceptionAmountCanNotNegativeOrZero)
 -	Nagyobb összeget nem lehet a számláról levenni, mint ami a számlán van (ExceptionCanNotTakeMore)
 -	Pénzösszeg átvezetése esetén negatív vagy nulla összeg esetén nem valósítható meg az átvezetés (ExceptionAmountCanNotNegativeOrZero) és az összegek nem változnak!
 -	Pénzösszeg átvezetése esetén rosszul megadott számlanév esetén nem valósítható meg az átvezetés (ExceptionAccountNameIsWrong) és az összegek nem változnak!
 -	Pénzösszeg átvezetése esetén nagyobb összeget nem lehet levenni, mint ami a számlán van és ilyenkor a pénzösszegek nem változnak a számlán! (ExceptionTransferIsNotPossible)


