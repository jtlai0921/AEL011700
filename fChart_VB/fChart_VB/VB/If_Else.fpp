8       	 <--SHAPES
8       	 <--LINES
id1
2       	 <--TYPE
286       	 <--LEFT
72       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
START



id2
2       	 <--TYPE
480       	 <--LEFT
351       	 <--TOP
70       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
STOP



id3
91       	 <--TYPE
249       	 <--LEFT
123       	 <--TOP
145       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INPUT
¿é¤Jª÷ÃB
amount

id4
92       	 <--TYPE
256       	 <--LEFT
186       	 <--TOP
128       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_GREATER_EQUAL
amount
200

id8
91       	 <--TYPE
263       	 <--LEFT
346       	 <--TOP
112       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
986895       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
9§é: 
amount

id5
91       	 <--TYPE
455       	 <--LEFT
272       	 <--TOP
119       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
986895       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
9.5§é:
amount

id6
0       	 <--TYPE
242       	 <--LEFT
285       	 <--TOP
153       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
MULTIPLY
amount
0.9
amount
id7
0       	 <--TYPE
435       	 <--LEFT
195       	 <--TOP
160       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
MULTIPLY
amount
0.95
amount
  
---- LINES ---- from,to ----
id1,id3
reserved 1

id3,id4
reserved 1

id8,id2
reserved 1

id5,id2
reserved 1

id4,id6
reserved 1
YES
id6,id8
reserved 1

id4,id7
reserved 1
NO
id7,id5
reserved 1

