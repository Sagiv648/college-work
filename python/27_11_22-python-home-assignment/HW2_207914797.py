#Submitter is Sagiv Alia


from functools import reduce

def Q1(dic):
    '''
    The procedure iterates over all the keys and for each key in the list of keys
    the procedure iterates over the values in the list of values, if there is a match
    the procedure halts and return true else it will run until it will either end or return true
    :param dic:
    :return:
    '''
    for key in dic.keys():
        for vals in dic.values():
            if(key == vals):
                return  True
    return False

def Q2(seq):
    '''
    The procedure filters the list by the items which their length as a string equal to their length as a set
    if they are equal the number doesn't have duplicate digits
    else it does
    '''
    return list(filter(lambda x: len(str(x)) == len(reduce(lambda a,b: a.union(b) ,str(x), set())) ,seq))

def Q3(dic):
    '''
    Since the only mutable types studied were dicts and lists, it is easier to take those as control group
    the procedure iterates over all the values and catches the type names in a dictionary counter
    and then iterates over the keys to check if there is even a mutable type present, if there isn't
    the procedure simply reverses the dictionary and returns
    else it will filter the values for types that are immutable and return them as a set
    :param dic:
    :return:
    '''
    types = {}
    for val in dic.values():
        types[type(val)] = types.get(type(val),0) + 1
        #types[type(val)] = types[type(val)] + 1 if type(val) in types.keys() else 1
    for key in types.keys():
        if(key == list or key == dict):
            return set(filter(lambda x: type(x) != list and type(x) != dict ,dic.values()))
    return {val: key for key,val in dic.items()}



def Q4(string, stoppingWords):
    '''
    The procedure first arranges all the valid words in a list(not numeric and not present in the input set)
    then it will perform a simple word count
    :param string:
    :param stoppingWords:
    :return:
    '''
    words = list(filter(lambda x: not(x.lower() in stoppingWords) and not (x.isnumeric()) ,string.split()))
    output = {}
    for i in words:
        output[i.lower()] = output.get(i.lower(),0) + 1
    return output

def Q5(string):
    '''
    The procedure first filter the string input into a list composed of all the valid strings
    it then performs the count as instructed by indexing the string until the third numeric
    and stringing an additional ".x" along as the key and then a simple count is performed
    :param string:
    :return:
    '''
    correct = list(filter(lambda x: len(x.split('.')) == 4 and
    reduce(lambda x,y: x * (int(y) >= 0 and int(y) <= 255) if y.isnumeric() else x*0
    ,x.split('.'), 1), string.split()))
    dic = {}
    for i in correct:
        dic[i[:(len(i)-2)  ] + ".x"] = dic.get(i[:(len(i)-2)  ] + ".x", 0) + 1
    return  dic
'''
Q1
print(Q1({1:2, 3:'abc', 5:1})) -> True
print(Q1({1:2, 3:'abc', 5:21})) -> False
'''
'''
Q2
print(Q2([12321,3854,2452,78652,5,44]))
'''

'''
Q3
print(Q3({1:2, 3:4, 5:6}))
print(Q3({(1,2,3):'abc', 'qwerty':18, '12':'xyz'}) )
print(Q3({1: [1, 2, 3], 2: 'abc', 3: (1, 2, 4), 4: {3: 4, 5: 6}, 3.5: 18}))
'''

'''
Q4
print(Q4('My cat is 10 and it is a very fat Cat', {'is', 'it', 'a', 'the', 'my', 'and'}))
'''

'''
print(Q5 ('192.168.15.3 192.168.15.1 19.133.256.5 217.145.x.x 192.24.5 217.145.1.8'))
'''
