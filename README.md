# Konteinerių testavimas  
  
Programos veikimo greitis buvo testuojamas su 1000, 10000, 100000, 1000000, 10000000 atsitiktiniais duomenimis.  
Buvo irašomas laikas per kiek programa suskaičiuoja galutini balą ir per kiek surušiuoja juos į skirtingus failus.  
Testavimas buvo padarytas su **List<T>**, **LinkedList<T>** ir **Queue<T>** ir surušiuoti failai buvo trinami po kiekvieno paleidimo.
  
  
**List<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.011s. Išviso dirbo 0.014s;  
  10000: suskaičiavo per 0.022s, padalino i failus per 0.047s. Išviso dirbo 0.069s;  
  100000: suskaičiavo per 0.219s, padalino i failus per 0.105s. Išviso dirbo 0.324s;  
  1000000: suskaičiavo per 2.115s, padalino i failus per 0.923s. Išviso dirbo 3.038s;  
  10000000: suskaičiavo per 21.44s, padalino i failus per 9.75s. Išviso dirbo 31.19s;  
  

**LinkedList<T>**  
  1000: suskaičiavo per 0.002s, padalino i failus per 0.011s. Išviso dirbo 0.013s;  
  10000: suskaičiavo per 0.044s, padalino i failus per 0.021s. Išviso dirbo 0.065s;  
  100000: suskaičiavo per 0.51s, padalino i failus per 0.099s. Išviso dirbo 0.609s;  
  1000000: suskaičiavo per 2.626s, padalino i failus per 0.875s. Išviso dirbo 3.501s;  
  10000000: suskaičiavo per 22.78s, padalino i failus per 8.913s. Išviso dirbo 31.693s; 
  
  
**Queue<T>**  
  1000: suskaičiavo per 0.002s, padalino i failus per 0.011s. Išviso dirbo 0.013s;  
  10000: suskaičiavo per 0.022s, padalino i failus per 0.02s. Išviso dirbo 0.042s;  
  100000: suskaičiavo per 0.479s, padalino i failus per 0.099s. Išviso dirbo 0.578s;  
  1000000: suskaičiavo per 2.666s, padalino i failus per 0.894s. Išviso dirbo 3.56s;  
  10000000: suskaičiavo per 22.655s, padalino i failus per 10.67s. Išviso dirbo 33.325s;
  
 **Išvados:** Iš atliktos programos greičio analizes matoma, kad konteinerių pasirinkimas turi vos pastebimą įtaka ant programos veikimo greičio.
