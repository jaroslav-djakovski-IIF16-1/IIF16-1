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
 
 
 **1 strategija**  
Bendro studentai konteinerio skaidymas į du naujus to paties tipo konteinerius. Tokiu būdu tas pats studentas yra dvejuose konteineriuose: bendrame studentai ir viename iš suskaidytų.  
  
 **List<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.025s. Išviso dirbo 0.028s;  
  10000: suskaičiavo per 0.24s, padalino i failus per 0.043s. Išviso dirbo 0.067s;  
  100000: suskaičiavo per 0.224s, padalino i failus per 0.128s. Išviso dirbo 0.352s;  
  1000000: suskaičiavo per 2.537s, padalino i failus per 0.896s. Išviso dirbo 3.433s;  
  10000000: suskaičiavo per 22.046s, padalino i failus per 8.742s. Išviso dirbo 30.788s;  
  

**LinkedList<T>**  
  1000: suskaičiavo per 0.003s, padalino i failus per 0.03s. Išviso dirbo 0.033s;  
  10000: suskaičiavo per 0.024s, padalino i failus per 0.018s. Išviso dirbo 0.042s;  
  100000: suskaičiavo per 0.233s, padalino i failus per 0.132s. Išviso dirbo 0.356s;  
  1000000: suskaičiavo per 2.369s, padalino i failus per 0.928s. Išviso dirbo 3.297s;  
  10000000: suskaičiavo per 24.822s, padalino i failus per 8.952s. Išviso dirbo 33.774s; 
  
  
**Queue<T>**  
  1000: suskaičiavo per 0.001s, padalino i failus per 0.011s. Išviso dirbo 0.012s;  
  10000: suskaičiavo per 0.021s, padalino i failus per 0.02s. Išviso dirbo 0.041s;  
  100000: suskaičiavo per 0.221s, padalino i failus per 0.116s. Išviso dirbo 0.337s;  
  1000000: suskaičiavo per 2.138s, padalino i failus per 0.876s. Išviso dirbo 3.014s;  
  10000000: suskaičiavo per 22.225s, padalino i failus per 8.584s. Išviso dirbo 30.808s;
  
  
  **2 strategija**  
  Bendro studentų konteinerio skaidymas panaudojant tik vieną naują konteinerį: "vargšiukai". Tokiu būdu, jei studentas yra
vargšiukas, jį turime įkelti į naująjį "vargšiukų" konteinerį ir ištrinti iš bendro studentai konteinerio.


 **List<T>**  
  1000: suskaičiavo per 0.145s, padalino i failus per 0.029s. Išviso dirbo 0.174s;  
  10000: suskaičiavo per 3.234s, padalino i failus per 0.039s. Išviso dirbo 3.273s;  
  100000: Per ilgai.
  

**LinkedList<T>**  

