18       	 <--SHAPES
20       	 <--LINES
id1
2       	 <--TYPE
286       	 <--LEFT
77       	 <--TOP
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
610       	 <--LEFT
438       	 <--TOP
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
238       	 <--LEFT
126       	 <--TOP
164       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INPUT
輸入金額
amount

id4
92       	 <--TYPE
256       	 <--LEFT
186       	 <--TOP
127       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_LESS
amount
100

id7
92       	 <--TYPE
256       	 <--LEFT
281       	 <--TOP
127       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_LESS
amount
500

id10
92       	 <--TYPE
252       	 <--LEFT
376       	 <--TOP
134       	 <--WIDTH
50       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
IF_LESS
amount
1000

id16
91       	 <--TYPE
569       	 <--LEFT
374       	 <--TOP
152       	 <--WIDTH
40       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
OUTPUT
外送價
amount

id6
0       	 <--TYPE
436       	 <--LEFT
290       	 <--TOP
90       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
rate
0.1
rate
id8
0       	 <--TYPE
438       	 <--LEFT
385       	 <--TOP
90       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
rate
0.05
rate
id9
0       	 <--TYPE
586       	 <--LEFT
250       	 <--TOP
120       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
ADD
1
rate
rate
id11
0       	 <--TYPE
274       	 <--LEFT
472       	 <--TOP
90       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
rate
0
rate
id12
3       	 <--TYPE
548       	 <--LEFT
481       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



id13
3       	 <--TYPE
547       	 <--LEFT
396       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



id14
3       	 <--TYPE
547       	 <--LEFT
300       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



id15
3       	 <--TYPE
547       	 <--LEFT
206       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



id17
3       	 <--TYPE
641       	 <--LEFT
205       	 <--TOP
10       	 <--WIDTH
10       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
INTERSECTION



id18
0       	 <--TYPE
566       	 <--LEFT
312       	 <--TOP
160       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
MULTIPLY
amount
rate
amount
id5
0       	 <--TYPE
436       	 <--LEFT
196       	 <--TOP
90       	 <--WIDTH
30       	 <--HEIGHT
16777215       	 <--BACKCOLOR
0       	 <--BORDERCOLOR
0       	 <--BORDERCOLOR
-reserved 1-
-reserved 2-
DEFINITION
rate
0.2
rate
  
---- LINES ---- from,to ----
id3,id4
reserved 1

id1,id3
reserved 1

id4,id7
reserved 1
NO
id7,id10
reserved 1
NO
id7,id6
reserved 1
YES
id10,id8
reserved 1
YES
id10,id11
reserved 1
NO
id11,id12
reserved 1

id12,id13
reserved 1

id8,id13
reserved 1

id6,id14
reserved 1

id15,id17
reserved 1

id17,id9
reserved 1

id9,id18
reserved 1

id18,id16
reserved 1

id16,id2
reserved 1

id4,id5
reserved 1
YES
id5,id15
reserved 1

id14,id15
reserved 1

id13,id14
reserved 1

