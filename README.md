# Roulette
## Playing 
Roulette is a very simple game. A roulette wheel has 38 bins. Thirty-six bins are numbered from 1 to 36. The last two bins contain 0 and 00. The two zero bins are colored green. The others are colored randomly red and black, 18 of each color. As the wheel spins, a ball is dropped into the wheel. When the wheel stops spinning, the ball comes to rest in one bin.
## Betting
Betting is much more complicated. The following bets can win:
1. Numbers: the number of the bin
2. Evens/Odds: even or odd numbers
3. Reds/Blacks: red or black colored numbers
4. Lows/Highs: low (1 – 18) or high (19 – 38) numbers.
5. Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36
6. Columns: ﬁrst, second, or third columns
7. Street: rows, e.g., 1/2/3 or 22/23/24
8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26
9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
## Assignment
You are to write a program that models a roulette wheel. The ball can fall randomly into one of 38 diﬀerent bins. You are to calculate all the winning bets according to the bin the ball falls into. Use arrays to model this game. You should use two arrays to model the wheel (numbers and colors). You can use arrays as appropriate to determine the winning bets. As output, your program should print the winning bin to standard output, together with all the winning bets. For example, if the ball comes to rest in square 26, the winning Split bets could be 23/26, 26/27, 26/29, and 25/26, while the winning Corner bets could be 22/23/25/26, 23/24/26/27, 25/26/28/29, and 26/27/29/30
