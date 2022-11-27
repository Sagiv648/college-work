from functools import reduce
# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
def Q1(group):
    return set(filter(lambda x: x % 2 == 0, group))

def Q2(string):

    return {x for x in string.lower().split()}

def Q3(n):
    return {x: x*x for x in range(1,n+1)}

def Q4(seq):
    dict1 = {}
    max = []
    lenMax = 0
    for i in seq:
        dict1[len(str(i))] = dict1.get(len(str(i)), []) + [i]
        if(len(dict1[len(str(i))]) > lenMax):
            lenMax = len(dict1[len(str(i))])
            max = dict1[len(str(i))]

    return max

def Q5(dic,dictwo):
    output = {}

    for key,val in dic.items():
        output[key] = dic.get(key,0) + dictwo.get(key,0)
    for key,val in dictwo.items():
        output[key] = dic.get(key,0) + dictwo.get(key,0)

    return output

def main():
    #print(Q1({2,6,5,3,7,89,34}))
    #print(Q2('London is the capital londoN cApital of the Great capitaL the London Britain capital London'))
    #print(Q3(9))
    print(Q4([1,3456,34,245,567321,5432,675,1876,34]))
    #print(Q5({'a': 100, 'b': 200, 'c':300},{'a': 300, 'b': 200, 'd':400}))

    pass
if __name__ == '__main__':
    main()

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
