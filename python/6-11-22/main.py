import functools
import math


def Q1(seq):

    return sum(list(map(lambda x: x % 2, seq)))


def Q2(seq):

    return list(map(lambda x: int(str(x)[::-1]), seq))[::-1]

def Q3(seq):
    return list(filter(lambda x: (len(str(x)) == 3)
            and ((x // 100 + x // 10 % 10 + x % 10) == 3
            or (x // 100 + x // 10 % 10 + x % 10) == 8), seq))

def Q4():

    return functools.reduce(lambda x, y:
    (x if x % 8 == 0 else 1) * (y if y % 8 == 0 else 1), range(10,100))

def Q5(seq):
    return bool(functools.reduce(lambda x,y:
    (x % 2 == 0) and y, seq))


#לא הבנתי את מהות השאלה
def Q6(startVal, func, seq):

    for i in range(0, len(seq)-1):
        startVal += (func(i,i+1))
    return sum(startVal)

    
def Q7(func, seq):
    output = ()
    for i in seq:
        output += (func(i),)
    return output

def Q8(filterOne, filterTwo, param):
    return bool(filterOne(param) or filterTwo(param))
def main():
  x = (23, 12, 35, 1, 0, 486, 721)
  #print(Q1(x))
  #print(Q2(x))
  #testCase = [111, 22, 55, 521]
  #print(Q3(testCase))


  #print(Q4())
  #print(Q5((2,450,634,170,58)))
  #print(Q6(1, lambda x,y: x*y, (1,2,3,4,5)))
  #print(Q7(lambda x: x%2 == 0, range(1,5)))








if __name__ == "__main__":
    main()
