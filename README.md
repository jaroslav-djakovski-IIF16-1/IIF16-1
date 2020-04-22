# Konteinerių testavimas  
  
Programos veikimo greitis buvo testuojamas su 1000, 10000, 100000, 1000000, 10000000 atsitiktiniais duomenimis.  
Buvo irašomas laikas per kiek programa suskaičiuoja galutini balą ir per kiek surušiuoja juos į skirtingus failus.  
Testavimas buvo padarytas su **List<T>**, **LinkedList<T>** ir **Queue<T>** ir sugeneruoti failai buvo trinami.
  
  
**List<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.011. Išviso dirbo 0.014s;  
  10000: suskaičiavo per 0.022s, padalino i failus per 0.047. Išviso dirbo 0.069s;  
  100000: suskaičiavo per 0.219s, padalino i failus per 0.105. Išviso dirbo 0.324s;  
  1000000: suskaičiavo per 2.115s, padalino i failus per 0.923. Išviso dirbo 3.038s;  
  10000000: suskaičiavo per 21.44s, padalino i failus per 9.75. Išviso dirbo 31.19;  
  

**LinkedList<T>**  
