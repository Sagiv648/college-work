import functools
import os

def Q1(fileName):
    dictParam = {}
    with open(fileName,'r', 1) as file:
        content = file.readlines()
        dictParam["lines"] = len(content)
        dictParam["sentences"] = functools.reduce(lambda x,y: x + len(y.split('.')) if len(y.split('.')) > 2 else x + 1,content, 0)
        dictParam["words"] = functools.reduce(lambda x,y: x +  functools.reduce(lambda a,b: a + len(b.split()) ,y.split('.'), 0) ,content, 0)
        dictParam["chars"] = len("".join(content))
    for key,val in dictParam.items():
        print("{0}:{1}".format(key.capitalize(), val))

#Q1("q1.txt")

def Q2(fileName):
    
    content = []
    with open(fileName, 'r') as file:
        content = file.readlines()
    wordsLenCounter = {word : len(word) for word in  list(map(lambda x: x[:len(x)-1] if x[len(x)-1] == '.' else x ,"".join(content).split()))}
    output = list(filter(lambda x: wordsLenCounter.get(x) == max(wordsLenCounter.values()) ,wordsLenCounter.keys()))
    return output if len(output) > 1 else output[0]
print(Q2("q1.txt"))

def Q3(fileName):
    content = []
    with open(fileName, 'r') as file:
        content = file.readlines()
    for lineNum in range(len(content)):
        print("{0}: {1}".format(lineNum+1, " ".join(content[lineNum].split())))
        

Q3('q1.txt')