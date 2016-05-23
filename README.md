Welcome to the For-Machine!

This program snipet written in C#

*	get an int array of data
*	an array of pattern
*	and walk trough the data array by the pattern
*	if its out of boundries, gonna enter the other side

for example:

array of data: { 3, 5, 1, 7, 4, 2, 4, 5, 6 }

pattern: { +2, -1, +4 }

first item: 4

how many times to process: 9


counter: 1	 elem in workArray: 3	 value: 7	previous step: 0

counter: 2	 elem in workArray: 5	 value: 2	previous step: 2

counter: 3	 elem in workArray: 4	 value: 4	previous step: -1

counter: 4	 elem in workArray: 8	 value: 6	previous step: 4

counter: 5	 elem in workArray: 1	 value: 5	previous step: 2

counter: 6	 elem in workArray: 0	 value: 3	previous step: -1

counter: 7	 elem in workArray: 4	 value: 4	previous step: 4

counter: 8	 elem in workArray: 6	 value: 4	previous step: 2

counter: 9	 elem in workArray: 5	 value: 2	previous step: -1


Result: 

7 2 4 6 5 3 4 4 2  
