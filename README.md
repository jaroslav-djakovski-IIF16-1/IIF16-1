# Konteinerių testavimas  
  
Programos veikimo greitis buvo testuojamas su 1000, 10000, 100000, 1000000, 10000000 atsitiktiniais duomenimis.  
Buvo irašomas laikas per kiek programa suskaičiuoja galutini balą ir per kiek surušiuoja juos į skirtingus failus.  
Testavimas buvo padarytas su **List<T>**, **LinkedList<T>** ir **Queue<T>**
  
  
**List<T>**  
  1000: suskaičiavo ir surušiavo per 0.009s, padalino i failus per 0.01. Išviso dirbo 0.019s;  
  10000: suskaičiavo ir surušiavo per 0.069s, padalino i failus per 0.019. Išviso dirbo 0.088s;  
  100000: suskaičiavo ir surušiavo per 0.695s, padalino i failus per 0.116. Išviso dirbo 0.811s;  
  100000: suskaičiavo ir surušiavo per 8.018s, padalino i failus per 0.925. Išviso dirbo 8.943s;  
  1000000: suskaičiavo ir surušiavo per 75.929s, padalino i failus per 11.702. Išviso dirbo 87.631s;  
  
  **LinkedList<T>**  
