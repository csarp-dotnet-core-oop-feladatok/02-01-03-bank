# 02-01-03-bank
*Setter és osztályok külön fájlokba. Saját kivételek. Kivétel kezelés.*

Készítsen osztályt bank számla kezelésére. A bank számla osztály nyilvántartja a számlán lévő összeget, és hogy milyen típusú számláról van szó. Bankszámlát csak típusának megadásával és az egyenlegre rakott pénz megadásával lehet létrehozni. A bankszámla típusa egy szöveg, pl. „magánszámla”, „vállalkozói számla” stb. A bankszámla típusa legyen módosítható adat! A bankszálára a tulajdonos elhelyezhet adott összeget, vagy adott összeget levehet a számláról! Ha az osztály karakterlánccá alakítja, jelenjen meg a számla típusa és a rajta lévő összeg.  
Hozzon létre osztályt a bankszámla tulajdonos kezelésére. A bankszámla tulajdonosnak legyen neve, és két bankszámlája (pl. magán számlája és család számlája). Biztosítsa, hogy a tulajdonos tudjon átvezetni pénzt a magánszámlájáról a családi számlájára! Átvezetéskor amennyi pénzt levesz a magánszámlájáról, annyi pénzt helyez el a családi számláján!  
Készítsen programot, amelyben Pénzes Péternek van két számlája. Családi számláját nyissa meg 20000 Ft-al, magánszámláját 30000 Ft-al. Rakjon 5000 Ft-ot a családi számlájára, és vegyen le 15000 Ft-ot a családi számlájáról. Vezessen át 10000 Ft-ot a magánszámlájáról a családi számlájára!  

[második rész]  
Bankszámla létrehozásakor a tulajdonosnak el kell helyeznie pénzt a számlán, legalább 10000 Ft értékben. Ha nem helyeznek el ennyi összeget a számlán, akkor dobjon saját kivételt az osztály! Bármennyi összeget el lehet helyezni a számlán, de levenni legfeljebb annyit amennyi a számlán van! Ha  a tulajdonos nagyobb összeget akar levonni, mint amennyi a számlán van, dobjon saját kivételt!  

Biztosítsa, hogy csak nullánál nagyobb pénzösszeget lehessen átvezetni a magánszámláról a családi számlára! Ha nem ez történik, dobjon saját kivételt!

A programban próbáljon létrehozni vállalkozói számlát -10000 Ft-al!  
Számlanyitás után próbáljon 100000 Ft-ot levenni Pénzes Péter magánszámlájáról.  
Próbáljon átvezetni -5000 Ft-ot Pénzes Péter magánszámlájáról a családi számlájára!  
Ezeknél a nem teljesíthető műveleteknél a program ne álljon le, hanem az outputon jelenjen meg a megfelelő hibaüzenet!  

