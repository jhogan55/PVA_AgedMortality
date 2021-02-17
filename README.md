# PVA_AgedMortality
Population viability assessment program for Santa Rosa Capuchins, with age-based mortality rates. This is a monthly, individual based model designed to test how different frequencies of Alpha Male Replacement (AMR) occurence affects the capuchin population. 

The front end of the program is deliberately simple, and allows users to select:  
1. one of three pre-set capuchin groups of different female group sizes. These groups are modelled after the real demographics of three Santa Rosa capuchin groups in January, 2021. 
2. the rate of AMR occurrence for the simulation (Santa Rosa baseline is 0.03)
3. the number of years to simulate 
4. the number of trials to conduct

Following these selections, the simulation proceeds as follows (brief version): 
1. Each month, the age and various other time-based variables increase for each individual. Infants who reach 12 months of age lose their mother dependency, pregnant females give birth if gestation length is achieved. 
2. Whether an Alpha Male Replacement has occurred or not is determined via weighted coin flip
3. Survival of each individual (including infant males and females) is tested via weighted coin flip. Odds are established using age and, for infants, whether there is AMR risk. 
4. For adult females not already pregnant, a weighted coin flip determines whether they conceive that month. Odds are established based on whether previous infant survived to wean, and the time-since-previous infant's birth or death (depending on first infants survival). 
5. This process is continued for N months until the user's desired end year is reached, and the ending population is recorded. 
6. Steps 1-5 occur for the number of trials user desires, and the ending populations from all trials are saved in a text file. 
