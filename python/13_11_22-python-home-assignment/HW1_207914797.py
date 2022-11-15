#Submitter's name is Sagiv Alia


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
    '''
    The procedure returns the number of students with grade higher than 55
    from the sequence of students filtered to house only students with grade higher than 55
    from the sequence of grades updated to [gradeval] + factor
    from the sequence of students who actually attended the test (grade >= 0 and grade <= 100)
    the inital value of the outter layer of the pipeline is 0 to increment it upon each successful condition val

    '''
    return functools.reduce(lambda x,y: x + (y >= 55),
    filter(lambda x: x >= 55,
    map(lambda x: (x + 15) if ((x + 15) <= 100)
        else 100,
    filter(lambda x: x >= 0 and x <= 100, grades))),0)


def Q3a1(grades):
    '''
    The procedure is behaving the same way as Q3a except we have removed the redundant second layer filter
    since we are incrementing the counter by the integer value of the condition (y >= 55) -> 0 if false, 1 if true
    '''
    return functools.reduce(lambda x, y: x + (y >= 55),
    map(lambda x: (x + 15) if ((x + 15) <= 100)
    else 100,
    filter(lambda x: x >= 0 and x <= 100, grades)), 0)

def Q3b(grades,func):
    '''
    The procedure begins returns the result of the conditional expression integer value multiplied in chains
    since 0 is false and 1 is true, and the procedure requests us to be strict in ensuring that nobody overflows the 100 mark
    a single time a student will overflow over 100, the conditional expression integer will result in 0
    thus the entire procedure will return False or 0

    '''
    return functools.reduce(lambda x,y: bool(x * (y < 100)),
    map(lambda x: func(x),
    filter(lambda x: x >= 0 and x <= 100,grades)),True)



Q5a = lambda x: len(list(filter(lambda x: x[1] >= 55, x))) == len(x)
'''
The nameless procedure filters the sequence by the predicate of the iterator's second index's value
(x[1] >= 55) if the resulting list's length is the same as the input list, the result will be True, else False
'''
Q5b = lambda x: list(map(lambda x: x[0],filter(lambda x: x[1] < 55, x)))
'''
The nameless procedure filters the input sequence according to the predicate of the iterator's second index value
(x[1] < 55) and returns a list composed of the elements returned by the filter
'''
Q5c = lambda x: list(
    map(lambda x: (x[0],) + ((x[1] + 14),) 
    if (x[1] + 14) <= 100 else 100, x))
'''
The nameless procedure iterates over all the elements and updates it's value to be value + factor
'''
Q5d = lambda x: len(list(
    filter(lambda a: 
    functools.reduce(
        lambda b,c: b + (a[1] == c[1]) , x, 0) > 1 , x))) > 0
'''
The procedure filters the sequence according to the predicate which calls the reduce procedure
which in turn returns the counter incremented by the value of the previous iterator's second index
tested if it's equal to reduce iterator's second index
if the length of the output list is greater than 0 there is duplicity thus True, else False

'''
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

    '''
    Q5d examples
    marks = [('David', 80), ('Tali', 45), ('Timmy', 30), ('Moshe', 4), ('Yanir', 80)]
    print(Q5d(marks))
    marks = [('David', 80), ('Tali', 45), ('Timmy', 30), ('Moshe', 4), ('Yanir', 80), ("Johhny", 4)]
    print(Q5d(marks))
    marks = [('David', 80), ('Tali', 80)]
    print(Q5d(marks))
    '''
    
    
    







    pass





# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    main()

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
