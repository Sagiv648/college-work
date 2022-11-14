import functools
import math
import re
def Q1CountPass(sequence):
    return len(list(filter(lambda x: x >= 55 and x <= 100, sequence)))

def Q2ReverseDigits(sequence):
    return list(
        filter(lambda x: len(str(abs(x))) == 2,
            map(lambda x:
    ((x < -9 and x >= -99) * (int(str(abs(x))[::-1])) * -1)
    + ((x > 9 and x <= 99) * int(str(abs(x))[::-1])), sequence
   )))

def Q3retEvens3Times(sequence):
    return functools.reduce(lambda x,y: (x) + (y,y,y), filter(lambda x: not(x%2), sequence), ())

def Q4convertStrToIntList(sequence):
    return list(map(lambda x: int(x),filter(lambda x: x.isdecimal(), re.split(', | |,', sequence))))

def Q5retClearText(sequence):
    return  str(list(filter(lambda x: re.match('[a-z]|[A-Z]',x), sequence.split())))
def Q6getRound(sequence):

    return functools.reduce(lambda x,y: x + [float(format(y,"."+str(len(x)+1) + 'f'))] , sequence, [])
def Q7doPower(sequence):
    return functools.reduce(lambda x,y:
    (x) + (pow(y[0],y[1]),) if (y[1] > 0) else (x) + (pow(y[0],1/abs(y[1])),),
    filter(lambda x: x[0] > 0 or x[1] > 0, sequence), ())
def main():
    #print(Q1CountPass([46,199,77,56,199,198,100,199,20,55,54])) ^
    #print(Q2ReverseDigits([2,-12,-25,100,56,183,-23,78,-3])) ^
    #print(Q3retEvens3Times((17,24,103,400,5,68)))
    #print(Q4convertStrToIntList('34 123, 145 12 12.4,456a,23.5')) ^
    #print(Q5retClearText("LondON 3 is the 125 capitaL of - Great Britain"))
    #print(Q6getRound([2.345,3.3456,1.456789,140.23476,16.489765,17.11111111111]))
    #print(Q7doPower(((2,3),(4,-2),(-5,3),(-4,-2)) ))
    pass


if __name__ == "__main__":
    main()