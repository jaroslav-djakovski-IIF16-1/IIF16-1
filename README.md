# Konteinerių testavimas  
  
Programos veikimo greitis buvo testuojamas su 1000, 10000, 100000, 1000000, 10000000 atsitiktiniais duomenimis.  
Buvo irašomas laikas per kiek programa suskaičiuoja galutini balą ir per kiek surušiuoja juos į skirtingus failus.  
Testavimas buvo padarytas su **List<T>**, **LinkedList<T>** ir **Queue<T>** ir surušiuoti failai buvo trinami po kiekvieno paleidimo. 
 
 **1 strategija**  
Bendro studentai konteinerio skaidymas į du naujus to paties tipo konteinerius. Tokiu būdu tas pats studentas yra dvejuose konteineriuose: bendrame studentai ir viename iš suskaidytų.  
  
 **List<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.025s. Išviso dirbo 0.028s;        Memory usage: 166548 bytes;   
  10000: suskaičiavo per 0.24s, padalino i failus per 0.043s. Išviso dirbo 0.067s;  
  100000: suskaičiavo per 0.224s, padalino i failus per 0.128s. Išviso dirbo 0.352s;      Memory usage: 14671040 bytes;  
  1000000: suskaičiavo per 2.537s, padalino i failus per 0.896s. Išviso dirbo 3.433s;  
  10000000: suskaičiavo per 22.046s, padalino i failus per 8.742s. Išviso dirbo 30.788s;  Memory usage: 1540237532 bytes;  
  

**LinkedList<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.03s. Išviso dirbo 0.033s;         Memory usage: 193096 bytes;  
  10000: suskaičiavo per 0.024s, padalino i failus per 0.018s. Išviso dirbo 0.042s;  
  100000: suskaičiavo per 0.233s, padalino i failus per 0.132s. Išviso dirbo 0.356s;      Memory usage: 16393112 bytes;  
  1000000: suskaičiavo per 2.369s, padalino i failus per 0.928s. Išviso dirbo 3.297s;  
  10000000: suskaičiavo per 24.822s, padalino i failus per 8.952s. Išviso dirbo 33.774s;  Memory usage: 1715593136 bytes;  
  
  
**Queue<T>**  
  1000: suskaičiavo per 0.001s, padalino i failus per 0.011s. Išviso dirbo 0.012s;        Memory usage: 166572 bytes;  
  10000: suskaičiavo per 0.021s, padalino i failus per 0.02s. Išviso dirbo 0.041s;  
  100000: suskaičiavo per 0.221s, padalino i failus per 0.116s. Išviso dirbo 0.337s;      Memory usage: 14671064 bytes;  
  1000000: suskaičiavo per 2.138s, padalino i failus per 0.876s. Išviso dirbo 3.014s;  
  10000000: suskaičiavo per 22.225s, padalino i failus per 8.584s. Išviso dirbo 30.808s;  Memory usage: 1540236240 bytes;   
  
  
  **2 strategija**  
  Bendro studentų konteinerio skaidymas panaudojant tik vieną naują konteinerį: "vargšiukai". Tokiu būdu, jei studentas yra
vargšiukas, jį turime įkelti į naująjį "vargšiukų" konteinerį ir ištrinti iš bendro studentai konteinerio.


 **List<T>**  
  1000: suskaičiavo per 0.04s, padalino i failus per 0.011s. Išviso dirbo 0.051s;        Memory usage: 135132 bytes;  
  10000: suskaičiavo per 3.114s, padalino i failus per 0.019s. Išviso dirbo 3.133s;      Memory usage: 1026220 bytes;  
  100000: suskaičiavo per 322.634s, padalino i failus per 0.164s. Išviso dirbo 322.798s; Memory usage: 1125940 bytes;  
  

**LinkedList<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.031s. Išviso dirbo 0.034s;       Memory usage: 148912 bytes;  
  10000: suskaičiavo per 0.021s, padalino i failus per 0.041s. Išviso dirbo 0.062s;      Memory usage: 1192916 bytes;  
  100000: suskaičiavo per 0.256s, padalino i failus per 0.19s. Išviso dirbo 0.446s;      Memory usage: 11992924 bytes;  
  1000000: suskaičiavo per 2.829s, padalino i failus per 0.943s. Išviso dirbo 3.772s;    Memory usage: 123592936 bytes;  
  10000000: suskaičiavo per 26.416s, padalino i failus per 9.716s. Išviso dirbo 36.132s; Memory usage: 1275592932 bytes;  
  
  
  **Queue<T>**  
  1000: suskaičiavo per 0.004s, padalino i failus per 0.017s. Išviso dirbo 0.021s;       Memory usage: 152256 bytes;  
  10000: suskaičiavo per 0.021s, padalino i failus per 0.021s. Išviso dirbo 0.042s;      Memory usage: 1244420 bytes;  
  100000: suskaičiavo per 0.231s, padalino i failus per 0.138s. Išviso dirbo 0.369s;     Memory usage: 11525072 bytes;  
  1000000: suskaičiavo per 2.202s, padalino i failus per 0.91s. Išviso dirbo 3.112s;     Memory usage: 117341660 bytes;  
  10000000: suskaičiavo per 21.956s, padalino i failus per 9.088s. Išviso dirbo 30.808s; Memory usage: 1338909400 bytes;  
  
  
  
 **3 strategija**(mano)  
Bendro studentai konteinerio skaldimas i failus pagal studento galutinį balą;
  
  **List<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.011s. Išviso dirbo 0.014s;       Memory usage: 130776 bytes;  
  10000: suskaičiavo per 0.022s, padalino i failus per 0.047s. Išviso dirbo 0.069s;  
  100000: suskaičiavo per 0.219s, padalino i failus per 0.105s. Išviso dirbo 0.324s;     Memory usage: 10739980 bytes;  
  1000000: suskaičiavo per 2.115s, padalino i failus per 0.923s. Išviso dirbo 3.038s;  
  10000000: suskaičiavo per 21.44s, padalino i failus per 9.75s. Išviso dirbo 31.19s;    Memory usage: 1238247412 bytes;  
  

**LinkedList<T>**  
  1000: suskaičiavo per 0.002s, padalino i failus per 0.011s. Išviso dirbo 0.013s;       Memory usage: 150204 bytes;  
  10000: suskaičiavo per 0.044s, padalino i failus per 0.021s. Išviso dirbo 0.065s;  
  100000: suskaičiavo per 0.51s, padalino i failus per 0.099s. Išviso dirbo 0.609s;      Memory usage: 11994220 bytes;  
  1000000: suskaičiavo per 2.626s, padalino i failus per 0.875s. Išviso dirbo 3.501s;  
  10000000: suskaičiavo per 22.78s, padalino i failus per 8.913s. Išviso dirbo 31.693s;  Memory usage: 1275594268 bytes;  
  
  
**Queue<T>**  
  1000: suskaičiavo per 0.002s, padalino i failus per 0.011s. Išviso dirbo 0.013s;        Memory usage: 130784 bytes;  
  10000: suskaičiavo per 0.022s, padalino i failus per 0.02s. Išviso dirbo 0.042s;  
  100000: suskaičiavo per 0.479s, padalino i failus per 0.099s. Išviso dirbo 0.578s;      Memory usage: 10740012 bytes;  
  1000000: suskaičiavo per 2.666s, padalino i failus per 0.894s. Išviso dirbo 3.56s;  
  10000000: suskaičiavo per 22.655s, padalino i failus per 10.67s. Išviso dirbo 33.325s;  Memory usage: 1238247420 bytes;
  
  **Išvados:** visuose stategijuose darbo laikas ir atminties naudojamas buvo labai panašus (išskyrus 2 strategijos List<T> ten darbo laikas LABAI pailgėjo), dėl to galima naudoti bet kokį iš sių strategijų ir konteinerių.
  

# Releases

**[V0.1](https://github.com/jaroslav-djakovski-IIF16-1/IIF16-1/tree/V0.1)**  
**3 laboratorino darbo įgyvendinta versija 0.1.**  

ProgramMasyvas.cs - veikia su masyvais ir nezymonu skaiciu namų darbų, skaičiuoja galutinį balą palei vidurkį ar medianą.  
ProgramList.cs - veikia su listųir nezymomu skaiciu namų darbų, skaičiuoja galutinį balą palei vidurkį ar medianą.  
Program.cs - veikia kaip praeitas su listai, bet šiame galima sugeneruoti atsitiktinius namų darbų ir egzamino pažymius.  


**[V0.2](https://github.com/jaroslav-djakovski-IIF16-1/IIF16-1/tree/V0.2)**  
**3 laboratorino darbo įgyvendinta versija 0.2.**  

Šioje versijoje buvo dadetas menu iš kurio galima pasirinkti ar duomenys bus ivedami ranka (viskas kas buvo v0.1) ar nuskaitomi iš failo.  

Duomenys kurie yra nuskaityti yra apdorojami ir iš jų gaunamas galutinis balas su vidurkių ir mediana ir yra išsaugojami su studentu vardais į lista.  

Prieš išvedima listas yra rūšiuojamas palei studentu pavardes o po to palei vardus kad visi duomenys butu abėcėles tvarka. 


**[V0.3](https://github.com/jaroslav-djakovski-IIF16-1/IIF16-1/tree/V0.3)**  
**3 laboratorino darbo įgyvendinta versija 0.3.**  

Šioje versijoje projektas buvo iškaldytas i kelis .cs failus, panaudota struct'ūra ir dadetas išimčių valdymas kuris patikrina duomenus ivestus ranka bei iš failo.  

Taip pat šioje versijoje buvo ištaisytos klaido iš praeitų releasu, tokios kaip:  

1. Įvedant duomenys ranka dabar negalima praleisti pasirinkimo kokiu būdų bus skaičiuojamas pažymys (mediana ar vidurkis)  
2. Dadeta galimybe pačiam įvesti failo direktorija.  
3. Ištaisytas galutinio balo skaičiavimas nuskaitant iš failo (buvo imamas paskutinis pažymys vietoj egzamino balo)  


**[V0.4](https://github.com/jaroslav-djakovski-IIF16-1/IIF16-1/tree/V0.4)**  
**3 laboratorino darbo įgyvendinta versija 0.4.**  

Šioje versijoje buvo dadetas failų generavimas, studentų duomenu dalinimas palei galutini bala įrašant į failą ir programos greičio matavimas  

Failus generuoti galima norimų didžių ir juos galimą įrašyti į norimą direktorija.  

Studentų duomenys yra dalinami kai jie yra nuskaitomi norint apskaičiuoti galutini balą ir yra dalinami palei vidurki o ne palei mediana.  

Programos veikimo greitis yra matuojamas su Stopwatch. Laikas yra matuojamas keliose programos vietuose ir išvedamas sekundemis ekrane. 


**[V0.5](https://github.com/jaroslav-djakovski-IIF16-1/IIF16-1/tree/V0.5)**  
**4 laboratorino darbo įgyvendinta versija 0.5.**  

Šioje versijoje buvo dadetas failu nuskaitymas ir saugojimas su List, LinkedList ir Queue. Buvo padarytas programos veikimo greičio testavimas su 1000, 10000, 100000, 1000000, 10000000 atsitiktiniais duomenimis.  


**[V1.0](https://github.com/jaroslav-djakovski-IIF16-1/IIF16-1/tree/V1.0)** (ši versija)  

Šioje versijoje buvo atliekamas testavimas pagal veikimo greiti ir atminties naudojima, kad surasti su kokia darbo strategija veiks galutine versija (Strategijos aprašytos konteinerių testavime) ir buvo parinkta 3 strategija (mano).


# Naudojimosi instrukcija

Ijungus programa yra 4 pasirinkimai žiurint kas bus įrašytą: 
1. **file** - programa dirbs su failų;  
2. **ranka** - vartotojas pats ranka tures įvesti duomenys;  
3. **generate** - vartojas galės sugeneruoti pavyzdinį failą su atsitiktiniais duomenimis norimoje direktorijoje, pavadinimų ir norimo didžio.  
4. **exit** - programa yra uždaroma.  

### File
Jei buvo parinkas darbas su failų, vartotojas tures pasirinkti konteinerio tipą **List / LinkedList / Queue**, bet iš testavimo matome, kad ant programos greitaveikos tai neturi įtakos.  
Ten vartotojas turi ivesti kur randasi jo failas ir jo pavadinimas pvz.:D:\c#\10000.txt ir tada vyks darbas su failu.  
Po balų skaičiavimo yra galimybė išvesti duomenis į ekrana jei vartotojas įves *taip*, jei įves bet ką kito ar išvis nieko, programa veiks toliau.  
Gale programa surušiuoja studentus į **geresnius** ir **blogesnius** pagal galutini balą (geresni=>5, blogesni<5) ir irašo juos į failus su atitinkamais pavadinimas i **D:\ direktorija**.   
Jei duomenys buvo blogai ivesti, programa informuos kur atsitiko klaida ir prades darba iš naujo. 


### Ranka
Jei buvo parinkas darbas ranka, vartuotojas pirmiausiai turi įvestu studentu skaičiu.  
Veliau programi reikes per tarpus suvesti visus duomenys kurios jį prašo per tarpus (studento varda ir pavardė, pažymius, egzamino balą). Kai bus įvesti visi duomenys apie studentą, programa prašys ivesti kito studento duomenys ir tiek kartų kiek buvo įvestas studentų skaičius.  
Programa duomenų įvedumo metų dar klaus ar vartotojas nori sugeneruoti atsitiktinius pažymius ir egzamino balą. Jei vartotojas to norės, tai jis turės įvesti žodi *taip*, jei ne, paspausti *Enter* myktuką ar įrašyti bet ką kito.  
Kai visi duomenys bus įvesti, tai programa klaus kaip skaičiuoti galutinį balą, palei vidurki ar medianą. Vartotojas gales pasirinkti įvedus žodi **vidurkis** ar **mediana**.  
Jei duomenys buvo blogai ivesti, programa informuos kur atsitiko klaida ir prades darba iš naujo.
