import functools




def Q1(x):
    '''
    The procedure initalizes a new output list and iterates while the length of the new initialized list is lower than the input list
    which means that not all elements are sorted yet.
    Since we are checking the sum of even numbers, it will be logical to determine...
    that each incrementation between each even digit will be equal to 2 so the num is incremented by 2
    :param x:
    :return a list sorted by the sum of the even digts of each element:
    '''
    output = []
    num = 0
    while len(output) < len(x):
        for element in x:
            if(functools.reduce(lambda x,y: x + int(y) if int(y) % 2 == 0 else x + 0, str(abs(element)), 0) == num):
                output.append(element)
        num+=2
    return output

def Q2(str):
    '''
    The procedure parses the string to retrieve the operator and separate the operators
    The procedure then proceeds to convert the numbers to the comfortable base 10 and then does the operation
    :param str:
    :return: sum/product/difference of 2 numbers regardless of their base according to the operator
    '''

    operator = "".join( list(filter(lambda x: len(str.split(x)) == 2, ['+','-','*'])))
    operands = str.split(operator)
    operands = (list(map(lambda x: int(x[:len(x)-1],16) if x[len(x)-1] == 'h' else
    int(x[:len(x)-1],8) if x[len(x)-1] == 'q' else
    int(x[:len(x)-1],2) if x[len(x)-1] == 'b' else
    int(x), operands)))

    return (operands[0] + operands[1]) * (operator == '+') + \
           ((operands[0]-operands[1]) * (operator == '-')) + \
           operands[0]*operands[1] * (operator == '*')



def Q3a(grades):
    return functools.reduce(lambda x,y: x + (y >= 55),
    filter(lambda x: x >= 55,
    map(lambda x: (x + 15) if ((x + 15) <= 100)
        else 100,
    filter(lambda x: x >= 0 and x <= 100, grades))),0)


def Q3a1(grades):
    return functools.reduce(lambda x, y: x + (y >= 55),
    map(lambda x: (x + 15) if ((x + 15) <= 100)
    else 100,
    filter(lambda x: x >= 0 and x <= 100, grades)), 0)

def Q3b(grades,func):
    return functools.reduce(lambda x,y: bool(x * (y < 100)),
    map(lambda x: func(x),
    filter(lambda x: x >= 0 and x <= 100,grades)),True)

'''
def Q4(funcs, data):
    return (lambda f,d: )(funcs, data)
'''

Q5a = lambda x: len(list(filter(lambda x: x[1] >= 55, x))) == len(x)
Q5b = lambda x: list(map(lambda x: x[0],filter(lambda x: x[1] < 55, x)))
Q5c = lambda x: list(map(lambda x: (x[0],) + ((x[1] + 14),) if (x[1] + 14) <= 100 else 100, x))
#Q5d = lambda x: functools.reduce(lambda t,y: bool(x * (len(list(filter(lambda b: b[1] == y[1],x))) == 1)) ,x, True)
def main():

    '''
    Q1 examples
    print(Q1([478,-4788,2843,145,829,-144,986,-6]))
    print(Q1([28,4,6,8,10,12,14,16,18,20,-22,-2222]))

    '''
    '''
    Q2 examples
    print(Q2('1001b+1ah'))
    print(Q2('10+10'))
    print(Q2('ah*1010b'))
    '''

    '''
    Q3 examples
    print(Q3a([46,199,77,100,199,14,51,74]))
    '''

    '''
    Q3a1 examples
    print(Q3a1([46,199,77,100,199,14,51,74]))
    '''

    '''
    Q3b examples
    print(Q3b([46,19,77,53,99,199,14,51,74], lambda x: x+15))
    '''

    '''
    Q4 examples
    print(Q4((lambda x: x>0,lambda  x: x%2 == 0, lambda x: 9<abs(x)<100), (20,-45,133,8,400,7,-300,68)))
    '''

    '''
    Q5a examples
    marks = [('David',80),('Tali',45),('Moshe',86),('Yanir',80)]
    print(Q5a(marks[:1] + marks[2:]))
    print(Q5a([('David',80),('Tali',80),('Moshe',86),('Yanir',80)]))
    '''

    '''
    Q5b examples
    marks = [('David', 80), ('Tali', 45),('Timmy', 30) ,('Moshe', 86), ('Yanir', 80)]
    print(Q5b(marks))
    '''

    '''
    Q5c examples
    marks = [('David', 80), ('Tali', 45), ('Timmy', 30), ('Moshe', 86), ('Yanir', 80)]
    print(Q5c(marks))
    '''
    marks = [('David', 80), ('Tali', 45), ('Timmy', 30), ('Moshe', 86), ('Yanir', 81)]
    #print(Q5d(marks))









    pass





# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    main()

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
